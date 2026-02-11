using System.Globalization;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace jQueryNotification.Helper
{
    public static class NotificationHelper
    {
        public enum MessageType { Success, Error, Info, Warning };

        private static string EscapeSpecialCharacters(string notificationMessage)
        {
            string cleanedString = notificationMessage;
            //Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            //cleanedString = rgx.Replace(notificationMessage, "");

            //TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            //cleanedString = textInfo.ToTitleCase(cleanedString);

            return cleanedString+".";
        }
        public static void ShowSuccessfulNotification(this Control currentControl, string notificationMessage)
        {
            notificationMessage = EscapeSpecialCharacters(notificationMessage);
            ScriptManager.RegisterStartupScript(currentControl, currentControl.GetType(), "ss", "ShowMessage('" + notificationMessage + "','" + MessageType.Success + "');", true);
        }

        public static void ShowWarningNotification(this Control currentControl, string notificationMessage)
        {
            notificationMessage = EscapeSpecialCharacters(notificationMessage);
            ScriptManager.RegisterStartupScript(currentControl, currentControl.GetType(), "war", "ShowMessage('" + notificationMessage + "','" + MessageType.Warning + "');", true);
        }

        public static void ShowErrorNotification(this Control currentControl, string notificationMessage)
        {
            notificationMessage = EscapeSpecialCharacters(notificationMessage);
            ScriptManager.RegisterStartupScript(currentControl, currentControl.GetType(), "er", "ShowMessage('" + notificationMessage + "','" + MessageType.Error + "');", true);
        }

        public static void ShowInfomationNotification(this Control currentControl, string notificationMessage)
        {
            notificationMessage = EscapeSpecialCharacters(notificationMessage);
            ScriptManager.RegisterStartupScript(currentControl, currentControl.GetType(), "in", "ShowMessage('" + notificationMessage + "','" + MessageType.Info + "');", true);
        }

        /*
        public static void ShowSuccessfulNotification(this Page page, string message)
        {

            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'>  $(document).ready(function () { $.jnotify('" +
                                                    message + "'); });</script>");
        }

      
        public static void ShowWarningNotification(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'warning'); });</script>");
        }
        
        public static void ShowErrorNotification(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'error'); });</script>");
        }
               
        public static void ShowSuccessfulNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'>  $(document).ready(function () { $.jnotify('" +
                                                    message + "', " + delayTimeSpan + " ); });</script>");
        }
        
        public static void ShowWarningNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'warning', " + delayTimeSpan + " ); });</script>");
        }
      
        public static void ShowErrorNotification(this Page page, string message, int delayTimeSpan)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "notificationScript",
                                                    "<script type='text/javascript'> $(document).ready(function () { $.jnotify('" +
                                                    message + "', 'error', " + delayTimeSpan + " ); });</script>");
        }
        */
    }
}