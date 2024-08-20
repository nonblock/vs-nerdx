using System;
using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Navigation
{
    public class GoPageDown : ICommand
    {
        private readonly IHierarchyControl _hierarchyControl;

        public GoPageDown(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            try
            {
                if (((HierarchyControl) this._hierarchyControl).GetHierarchyListBox().IsKeyboardFocusWithin)
                {
                    this._hierarchyControl.GoPageDown(false);
                }
            }
            catch (Exception e)
            {
            }

            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}