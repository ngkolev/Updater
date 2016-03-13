namespace Updater.Common
{
    interface IOutput
    {
        void Write(string text, params object[] args);
        void WriteLine(string text, params object[] args);
    }
}
