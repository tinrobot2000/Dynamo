using Autodesk.DesignScript.Runtime;
using Dynamo.Engine;
using Newtonsoft.Json;

namespace Dynamo.Graph.Nodes.ZeroTouch
{
    /// <summary>
    ///     DesignScript function node. All functions from DesignScript share the
    ///     same function node but internally have different procedure.
    /// </summary>
    [NodeName("Function Node"), NodeDescription("DSFunctionNodeDescription", typeof(Properties.Resources)),
    IsVisibleInDynamoLibrary(false), IsMetaNode]
    [AlsoKnownAs("Dynamo.Nodes.DSFunction")]
    public class DSFunction : DSFunctionBase
    {
        /// <summary>
        /// The NodeType property provides a name which maps to the 
        /// server type for the node. This property should only be
        /// used for serialization. 
        /// </summary>
        public override string NodeType
        {
            get
            {
                return "FunctionNode";
            }
        }

        [JsonProperty(Order = 5)]
        public string FunctionSignature
        {
            get
            {
                return Controller.Definition.MangledName;
            }
        }

        /// <summary>
        ///     Indicates whether Node is input or not.
        ///     Used to bind visibility of UI for user selection.
        /// </summary>
        public override bool IsInputNode
        {
            get { return false; }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DSFunction"/> class.
        /// </summary>
        /// <param name="functionDescription">Function descritor.</param>
        public DSFunction(FunctionDescriptor functionDescription) 
            : base(new ZeroTouchNodeController<FunctionDescriptor>(functionDescription)) 
        {
        }
    }
}

