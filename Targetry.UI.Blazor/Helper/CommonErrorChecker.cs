using System.Collections.Generic;

namespace Targetry.UI.BlazorWeb.Helper
{
    /// <summary>
    /// Class to define common error checker.
    /// </summary>
    public static class CommonErrorChecker
    {
        public static bool IsSignalRIssue(string errorMessage)
        {
            List<string> signalRErrorMessages = new List<string>();
            signalRErrorMessages.Add("A command is already in progress");
            signalRErrorMessages.Add("A second operation was started");
            for (int i = 0; i < signalRErrorMessages.Count; i++)
            {
                if (errorMessage.Contains(signalRErrorMessages[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
