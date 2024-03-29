﻿using System;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels
{
    public class BootViewModel : ViewModelBase
    {
        private string _title = $"Boot View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        public BootViewModel()
        {
            IsGhosted = true;
            ChooseTargetPage();
        }

        /// <summary>
        /// This is reserved to determine which page to navigate to, depending upon whether a user is logged in or not.
        /// </summary>
        private void ChooseTargetPage()
        {
            Navigator.Show(typeof(ManageTemplatesViewModel));
        }
    }
}