﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudNotes.DesktopClient.Extensions.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CloudNotes.DesktopClient.Extensions.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BlogIcon {
            get {
                object obj = ResourceManager.GetObject("BlogIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading the web page....
        /// </summary>
        internal static string DownloadingWebPage {
            get {
                return ResourceManager.GetString("DownloadingWebPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ExportToHTMLImage {
            get {
                object obj = ResourceManager.GetObject("ExportToHTMLImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ExportToTextImage {
            get {
                object obj = ResourceManager.GetObject("ExportToTextImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saves the note as an HTML file..
        /// </summary>
        internal static string HtmlExporterDescription {
            get {
                return ResourceManager.GetString("HtmlExporterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save As HTML.
        /// </summary>
        internal static string HtmlExporterDisplayName {
            get {
                return ResourceManager.GetString("HtmlExporterDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTML Files (*.html).
        /// </summary>
        internal static string HtmlFileFilterDescription {
            get {
                return ResourceManager.GetString("HtmlFileFilterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import from Web....
        /// </summary>
        internal static string ImportFromWeb {
            get {
                return ResourceManager.GetString("ImportFromWeb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download the HTML web and import it as a new note..
        /// </summary>
        internal static string ImportFromWebDescription {
            get {
                return ResourceManager.GetString("ImportFromWebDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The title is duplicated with the existing note..
        /// </summary>
        internal static string ImportFromWebDuplicatedTitleErrorMsg {
            get {
                return ResourceManager.GetString("ImportFromWebDuplicatedTitleErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The title cannot be empty..
        /// </summary>
        internal static string ImportFromWebEmptyTitleErrorMsg {
            get {
                return ResourceManager.GetString("ImportFromWebEmptyTitleErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImportFromWebImage {
            get {
                object obj = ResourceManager.GetObject("ImportFromWebImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The title extracted from the downloaded HTML is either duplicated with the existing one, or empty. Please specify another title for the importing note..
        /// </summary>
        internal static string ImportFromWebInputTitlePrompt {
            get {
                return ResourceManager.GetString("ImportFromWebInputTitlePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicated Note Title.
        /// </summary>
        internal static string ImportFromWebInputTitleText {
            get {
                return ResourceManager.GetString("ImportFromWebInputTitleText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The link cannot be empty..
        /// </summary>
        internal static string LinkEmpty {
            get {
                return ResourceManager.GetString("LinkEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format of the link is invalid..
        /// </summary>
        internal static string LinkNotValid {
            get {
                return ResourceManager.GetString("LinkNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing images....
        /// </summary>
        internal static string ProcessingImages {
            get {
                return ResourceManager.GetString("ProcessingImages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saves the note as a text file..
        /// </summary>
        internal static string TextFileExporterDescription {
            get {
                return ResourceManager.GetString("TextFileExporterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save As Text File.
        /// </summary>
        internal static string TextFileExporterDisplayName {
            get {
                return ResourceManager.GetString("TextFileExporterDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text Files (*.txt).
        /// </summary>
        internal static string TextFileFilterDescription {
            get {
                return ResourceManager.GetString("TextFileFilterDescription", resourceCulture);
            }
        }
    }
}
