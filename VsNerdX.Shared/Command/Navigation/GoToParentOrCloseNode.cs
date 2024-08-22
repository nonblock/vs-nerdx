using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Navigation
{
    public class GoToParentOrCloseNode : ICommand
    {
        private IHierarchyControl _hierarchyControl;

        public GoToParentOrCloseNode(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            this._hierarchyControl.GoToParentOrCloseNode();
            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}