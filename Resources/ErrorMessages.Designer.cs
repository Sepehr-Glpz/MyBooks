﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You Must specify a Book Type for this book!.
        /// </summary>
        public static string BookTypeError {
            get {
                return ResourceManager.GetString("BookTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description Length Can Only be {1} characters!.
        /// </summary>
        public static string DescriptionLengthError {
            get {
                return ResourceManager.GetString("DescriptionLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You Must specify a genre for this book!.
        /// </summary>
        public static string GenreError {
            get {
                return ResourceManager.GetString("GenreError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the name must be between {2}-{1} characters!.
        /// </summary>
        public static string NameLengthError {
            get {
                return ResourceManager.GetString("NameLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  A Book name is required to continue!.
        /// </summary>
        public static string NameRequiredError {
            get {
                return ResourceManager.GetString("NameRequiredError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Publish year must be between {1}-{2} !.
        /// </summary>
        public static string PublishYearRangeError {
            get {
                return ResourceManager.GetString("PublishYearRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Author&apos;s name must be between {2}-{1} characters!.
        /// </summary>
        public static string WriterNameLengthError {
            get {
                return ResourceManager.GetString("WriterNameLengthError", resourceCulture);
            }
        }
    }
}
