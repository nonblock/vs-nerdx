using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Directory
{
    public class OpenNode : ICommand
    {
        private readonly IHierarchyControl _hierarchyControl;

        public OpenNode(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            this._hierarchyControl.OpenNode();
            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}