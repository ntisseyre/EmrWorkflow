﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmrWorkflow {
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
    internal class SwfResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SwfResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EmrWorkflow.SwfResources", typeof(SwfResources).Assembly);
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
        ///   Looks up a localized string similar to Unsupported EMR Activty type &quot;{0}&quot;.
        /// </summary>
        internal static string E_UnsupportedEmrActivityTypeTemplate {
            get {
                return ResourceManager.GetString("E_UnsupportedEmrActivityTypeTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Activity task &quot;{0}&quot; completed. JobFlowId: {1}..
        /// </summary>
        internal static string Info_ActivityCompletedTemplate {
            get {
                return ResourceManager.GetString("Info_ActivityCompletedTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process activity for input &quot;{0}&quot;..
        /// </summary>
        internal static string Info_ActivityFailedTemplate {
            get {
                return ResourceManager.GetString("Info_ActivityFailedTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decision: Complete Workflow Execution.
        /// </summary>
        internal static string Info_DecisionSwfCompleted {
            get {
                return ResourceManager.GetString("Info_DecisionSwfCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Emr job failed.
        /// </summary>
        internal static string Info_EmrJobFailed {
            get {
                return ResourceManager.GetString("Info_EmrJobFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Polling for the SWF activity task....
        /// </summary>
        internal static string Info_PollingActivityTask {
            get {
                return ResourceManager.GetString("Info_PollingActivityTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Polling for the SWF decision task....
        /// </summary>
        internal static string Info_PollingDecisionTask {
            get {
                return ResourceManager.GetString("Info_PollingDecisionTask", resourceCulture);
            }
        }
    }
}
