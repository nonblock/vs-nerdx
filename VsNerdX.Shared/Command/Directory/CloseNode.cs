using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Directory
{
    public class CloseNode : ICommand
    {
        private readonly IHierarchyControl _hierarchyControl;

        public CloseNode(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            this._hierarchyControl.CloseNode();
            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}