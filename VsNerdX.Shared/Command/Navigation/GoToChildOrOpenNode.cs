using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Navigation
{
    public class GoToChildOrOpenNode : ICommand
    {
        private IHierarchyControl _hierarchyControl;

        public GoToChildOrOpenNode(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            this._hierarchyControl.GoToChildOrOpenNode();
            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}