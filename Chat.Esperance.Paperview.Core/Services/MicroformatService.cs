using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;
using Paperview.Interfaces;

namespace Chat.Esperance.Paperview.Core.Services
{
    public static class Extensions
    {
        public static string Localisation(this Dictionary<string, string> localisations, string code)
        {
            return localisations[code];
        }

        public static string EmbedPaperviewScriptElement(this string document, string scriptElement)
        {
            return document.Replace("__paperview-template__", scriptElement);
        }
    }

    public class MicroformatService : IMicroformatService
    {
        private readonly Dictionary<string, string> _documents = new Dictionary<string, string>();

        private readonly IMicroformatTemplateService _templateService;
        private readonly List<ServiceError> _errorCache = new List<ServiceError>();
        private object _itemCache;

        private IObserver<object> _observer;

        public MicroformatService(IMicroformatTemplateService templateService)
        {
            _templateService = templateService;
        }

        public void Create(object obj)
        {
            _observer.OnNext(obj); 
        }

        #region Document publics
        private void AddDocument(string docId, string html5)
        {
            _documents.Add(docId, html5);
        }

        public Dictionary<string, string> GetDocuments()
        {
            return _documents;
        }

        public string GetDocument(string docId)
        {
            var response = string.Empty;

            if(_documents.ContainsKey(docId))
            {
                response = _documents[docId];
            }

            return response;
        }

        public void RemoveDocument(string docId)
        {
            if(_documents.ContainsKey(docId))
            {
                _documents.Remove(docId);
            }
        }
        #endregion

        public void Close()
        {
            var a = this._documents;
            _observer.OnCompleted();
        }

        public IDisposable CreateFactory()
        {
            return Observable.Create<object>(
                    (IObserver<object> observer) =>
                    {
                        _observer = observer;

                        return Disposable.Create(() => Debug.WriteLine("Observer has unsubscribed."));
                    }
                ).Subscribe(
                (value) =>
                {
                    /* onNext*/
                    _itemCache = value;


                    IPaperviewMicroformatRoot documentMetadata = (IPaperviewMicroformatRoot)value;
                    var docId = documentMetadata.Document.DocumentId;

                    var microformatFactoryType = value.GetType().GetTypeInfo().Assembly.GetType(
                        $"{value.GetType().Namespace}.MicroformatFactory");
                    var microformatFactory = (IMicroformatFactory)Activator.CreateInstance(microformatFactoryType);
                    var mf = microformatFactory.Create(value);

                    var embed = @"var esperance = '" + JsonConvert.SerializeObject(mf).Trim() + "';";

                    if (_documents.ContainsKey(docId))
                    {
                        _documents[documentMetadata.Document.DocumentId] = _templateService.Get(Guid.Parse(documentMetadata.Document.PresentationId)).EmbedPaperviewScriptElement(embed);
                    }
                    else
                    {
                        AddDocument(documentMetadata.Document.DocumentId, _templateService.Get(Guid.Parse(documentMetadata.Document.PresentationId)).EmbedPaperviewScriptElement(embed));
                    }

                    Debug.WriteLine("---- Microformat-----------");
                    Debug.WriteLine("Building Microformat {0}", documentMetadata.Document.Microformat.Id);
                    Debug.WriteLine("Id: {0}", documentMetadata.Document.Microformat.Id);
                    Debug.WriteLine("Language Default: {0}", documentMetadata.Document.Microformat.LanguageDefault);
                    Debug.WriteLine("Name ({0}): {1}", documentMetadata.Document.Microformat.LanguageDefault, documentMetadata.Document.Microformat.Name.Localisation(documentMetadata.Document.Microformat.LanguageDefault));
                    Debug.WriteLine("Description ({0}): {1}", documentMetadata.Document.Microformat.LanguageDefault, documentMetadata.Document.Microformat.Description.Localisation(documentMetadata.Document.Microformat.LanguageDefault));
                    Debug.WriteLine("Author: {0}", documentMetadata.Document.Microformat.Author);
                    Debug.WriteLine("Author Email Address: {0}", documentMetadata.Document.Microformat.AuthorEmailAddress);
                    Debug.WriteLine("Author Web Address: {0}", documentMetadata.Document.Microformat.AuthorWebAddress);
                    Debug.WriteLine("Derivation: {0}", documentMetadata.Document.Microformat.Derivation);
                    Debug.WriteLine("---------------");



                },
                ex =>
                {
                    /* OnError */
                    _errorCache.Add(new ServiceError { Type = _itemCache.GetType(), Cache = _itemCache, ErrorMessage = ex.Message });
                    Debug.WriteLine(ex.Message);
                },
                () =>
                {
                    /* OnCompleted */
                    Debug.WriteLine("The service has completed.");
                }
                );
        }
    }
}