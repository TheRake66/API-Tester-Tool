//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Tester_Tool.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("API_Tester_Tool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une chaîne localisée semblable à &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;doc&gt;
        ///    &lt;assembly&gt;
        ///        &lt;name&gt;Newtonsoft.Json&lt;/name&gt;
        ///    &lt;/assembly&gt;
        ///    &lt;members&gt;
        ///        &lt;member name=&quot;T:Newtonsoft.Json.Bson.BsonObjectId&quot;&gt;
        ///            &lt;summary&gt;
        ///            Represents a BSON Oid (object id).
        ///            &lt;/summary&gt;
        ///        &lt;/member&gt;
        ///        &lt;member name=&quot;P:Newtonsoft.Json.Bson.BsonObjectId.Value&quot;&gt;
        ///            &lt;summary&gt;
        ///            Gets or sets the value of the Oid.
        ///            &lt;/summary&gt;
        ///            &lt;value&gt;The value of the Oid.&lt;/value&gt;
        ///        &lt; [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Newtonsoft_Json {
            get {
                return ResourceManager.GetString("Newtonsoft_Json", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] Newtonsoft_Json1 {
            get {
                object obj = ResourceManager.GetObject("Newtonsoft_Json1", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
