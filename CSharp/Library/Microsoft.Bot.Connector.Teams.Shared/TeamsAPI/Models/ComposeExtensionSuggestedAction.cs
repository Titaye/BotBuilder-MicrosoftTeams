// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using Microsoft.Bot.Schema;
    using System.Linq;

    /// <summary>
    /// Compose extension Actions (Only when type is auth or config)
    /// </summary>
    public partial class ComposeExtensionSuggestedAction
    {
        /// <summary>
        /// Initializes a new instance of the ComposeExtensionSuggestedAction
        /// class.
        /// </summary>
        public ComposeExtensionSuggestedAction() { }

        /// <summary>
        /// Initializes a new instance of the ComposeExtensionSuggestedAction
        /// class.
        /// </summary>
        /// <param name="actions">Actions</param>
        public ComposeExtensionSuggestedAction(System.Collections.Generic.IList<CardAction> actions = default(System.Collections.Generic.IList<CardAction>))
        {
            Actions = actions;
        }

        /// <summary>
        /// Gets or sets actions
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actions")]
        public System.Collections.Generic.IList<CardAction> Actions { get; set; }

    }
}
