﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUnitTestAdapter.Resources {
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
    public class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MUnitTestAdapter.Resources.Errors", typeof(Errors).Assembly);
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
        ///   Looks up a localized string similar to Hash of local assembly and that of remote assembly is not matched..
        /// </summary>
        public static string HashNotMatched {
            get {
                return ResourceManager.GetString("HashNotMatched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Socket Error: {0}.
        /// </summary>
        public static string SocketError {
            get {
                return ResourceManager.GetString("SocketError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} operation to App is time-out..
        /// </summary>
        public static string TimeoutFormattableString {
            get {
                return ResourceManager.GetString("TimeoutFormattableString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LoggerLevel cannot be parsed. It can only be one of these five values: {0}, {1}, {2}, {3}, {4}.
        /// </summary>
        public static string UTA_CantParseLoggerLevel {
            get {
                return ResourceManager.GetString("UTA_CantParseLoggerLevel", resourceCulture);
            }
        }
    }
}
