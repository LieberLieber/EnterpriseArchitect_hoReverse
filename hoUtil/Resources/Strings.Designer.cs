﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ho_Tools.Utils.Resources {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ho_Tools.Utils.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;RootSearch&gt;&lt;Search Name=&quot;Favorites&quot; GUID=&quot;{A70B9F0E-14CD-4c03-B8FE-21C644DC2D5E}&quot; 
        ///PkgGUID=&quot;-1&quot; Type=&quot;0&quot; LnksToObj=&quot;0&quot; CustomSearch=&quot;1&quot; AddinAndMethodName=&quot;&quot;&gt;&lt;SrchOn&gt;
        ///&lt;RootTable Filter=&quot;select o.ea_guid As CLASSGUID, o.Object_Type as CLASSTYPE, o.Name, o.stereotype, o.object_type &amp;#xA;from t_object o inner join t_xref x on (o.EA_GUID = x.client)&amp;#xA;where Type = &apos;Favorite&apos;&amp;#xA;UNION&amp;#xA;select d.ea_guid As CLASSGUID, d.Diagram_Type as CLASSTYPE, d.Name, d.stereotyp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SearchFavorite {
            get {
                return ResourceManager.GetString("SearchFavorite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Favorites.
        /// </summary>
        internal static string SearchFavoriteName {
            get {
                return ResourceManager.GetString("SearchFavoriteName", resourceCulture);
            }
        }
    }
}
