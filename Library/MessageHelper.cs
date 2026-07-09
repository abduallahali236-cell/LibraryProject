public static class MessageHelper
{
    public static void Success(string message)
    {
        MessageBox.Show(
            message,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    public static void Error(string message)
    {
        MessageBox.Show(
            message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }

    public static bool Confirm(string message)
    {
        return MessageBox.Show(
            message,
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            == DialogResult.Yes;
    }
}