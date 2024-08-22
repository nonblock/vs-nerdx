namespace VsNerdX.Core
{
    public interface IHierarchyControl
    {
        void GoUp();
        void GoDown();
        void GoPageUp(bool halfPage);
        void GoPageDown(bool halfPage);

        void GoToTop();
        void GoToBottom();
        void GoToParent();
        void GoToParentOrCloseNode();
        void GoToChildOrOpenNode();
        void GoToLastChild();
        void GoToFirstOrLastChild();
        void CloseParentNode();
        void CloseNode();
        void OpenOrCloseNode();
        void OpenNode();
        void ToggleHelp();
        object GetSelectedItem();
    }
}
