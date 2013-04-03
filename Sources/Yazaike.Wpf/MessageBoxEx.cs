namespace Yazaike.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using Yazaike.Wpf.Properties;

    /// <summary>
    /// 
    /// </summary>
    public static class MessageBoxEx
    {
        public static MessageBoxResult ShowInfomationMessage(string message)
        {
            return ShowInfomationMessage(message, MessageBoxButton.OK);
        }

        public static MessageBoxResult ShowInfomationMessage(string message, MessageBoxButton button)
        {
            return MessageBox.Show(message, Resources.Message_Caption_Information, button, MessageBoxImage.Information);
        }

        public static MessageBoxResult ShowQuestionMessage(string message)
        {
            return ShowQuestionMessage(message, MessageBoxButton.YesNo);
        }

        public static MessageBoxResult ShowQuestionMessage(string message, MessageBoxButton button)
        {
            return MessageBox.Show(message, Resources.Message_Caption_Question, button, MessageBoxImage.Question);
        }

        public static MessageBoxResult ShowWarningMessage(string message)
        {
            return ShowWarningMessage(message, MessageBoxButton.OK);
        }

        public static MessageBoxResult ShowWarningMessage(string message, MessageBoxButton button)
        {
            return MessageBox.Show(message, Resources.Message_Caption_Warning, button, MessageBoxImage.Warning);
        }

        public static MessageBoxResult ShowErrorMessage(string message)
        {
            return ShowErrorMessage(message, MessageBoxButton.OK);
        }

        public static MessageBoxResult ShowErrorMessage(string message, MessageBoxButton button)
        {
            return MessageBox.Show(message, Resources.Message_Caption_Error, button, MessageBoxImage.Error);
        }
    }
}
