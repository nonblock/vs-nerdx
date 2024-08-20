using System;
using System.Windows.Forms;
using VsNerdX.Core;

namespace VsNerdX.Command.Navigation
{
    public class GoPageDownHalf : ICommand
    {
        private readonly IHierarchyControl _hierarchyControl;

        public GoPageDownHalf(IHierarchyControl hierarchyControl)
        {
            this._hierarchyControl = hierarchyControl;
        }

        public ExecutionResult Execute(IExecutionContext executionContext, Keys key)
        {
            try
            {
                if (((HierarchyControl) this._hierarchyControl).GetHierarchyListBox().IsKeyboardFocusWithin)
                {
                    this._hierarchyControl.GoPageDown(true);
                }
            }
            catch (Exception e)
            {
            }

            return new ExecutionResult(executionContext.Clear(), CommandState.Handled);
        }
    }
}