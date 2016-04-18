// Helpers/Settings.cs

using System.Collections.Generic;
using Newtonsoft.Json;
using Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Chat.Esperance.PaperviewApi.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
        private static ISettings AppSettings
        {
          get
          {
            return CrossSettings.Current;
          }
        }

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = "ABC";

        public static string GeneralSettings
        {
          get
          {
            return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
          }
          set
          {
            AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
          }
        }

        private const string ApplicationNameKey = "applicationname_key";
        private static readonly string ApplicationNameDefault = "Paperview";

        public static string ApplicationName
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(ApplicationNameKey, ApplicationNameDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(ApplicationNameKey, value);
            }
        }

        private const string PublishersKey = "publishers_key";
        private static readonly string PublishersDefault = JsonConvert.SerializeObject(new List<Publisher>());

        public static string Publishers
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(PublishersKey, PublishersDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(PublishersKey, value);
            }
        }

        private const string DefaultPublishersIdKey = "defaultpublishersid_key";
        private static readonly string DefaultPublishersIdDefault = string.Empty;

        public static string DefaultPublishersId
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(DefaultPublishersIdKey, DefaultPublishersIdDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(DefaultPublishersIdKey, value);
            }
        }
    }
}