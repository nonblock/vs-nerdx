using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Navigation
{
    public class GoToFirstOrLastChild : ICommand
    {
        private IHierarchyControl _hierarchyControl;

        public GoToFirstOrLastChild(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            this._hierarchyControl.GoToFirstOrLastChild();
            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}