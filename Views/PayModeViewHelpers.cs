using Supermarket_mvp.Views;

internal static class PayModeViewHelpers
{
    public static PayModeView GetInstance(Form parentContainer)
    {
        if (instance == null || instance.IsDisposed)
        {
            instance = new PayModeView();
            instance.MdiParent = parentContainer;


            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;
        }
        else
        {
            if (instance.WindowState == FormWindowState.Minimized)
            {
                instance.WindowState = FormWindowState.Normal;
            }
            instance.BringToFront();
        }
        return instance;
    }
}