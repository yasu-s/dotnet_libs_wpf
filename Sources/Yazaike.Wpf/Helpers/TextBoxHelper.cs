namespace Yazaike.Wpf.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Yazaike.Wpf.Extensions;

    /// <summary>
    /// TextBox helper class.
    /// </summary>
    public static class TextBoxHelper
    {
        /// <summary>EnterCommand Attached Property</summary>
        public static readonly DependencyProperty EnterCommandProperty = DependencyProperty.RegisterAttached("EnterCommand", typeof(ICommand), typeof(TextBoxHelper), new PropertyMetadata(null, EnterCommandPropertyChanged));

        /// <summary>EnterCommandParameter Attached Property</summary>
        public static readonly DependencyProperty EnterCommandParameterProperty = DependencyProperty.RegisterAttached("EnterCommandParameter", typeof(object), typeof(TextBoxHelper));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]  
        public static ICommand GetEnterCommand(DependencyObject target)
        {
            return target.GetValue(EnterCommandProperty) as ICommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="value"></param>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]  
        public static void SetEnterCommand(DependencyObject target, ICommand value)
        {
            target.SetValue(EnterCommandProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static object GetEnterCommandParameter(DependencyObject target)
        {
            return target.GetValue(EnterCommandParameterProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="value"></param>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetEnterCommandParameter(DependencyObject target, object value)
        {
            target.SetValue(EnterCommandParameterProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void EnterCommandPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            if ((e.OldValue == null) && (e.NewValue != null))
                textBox.KeyUp += OnKeyUp;
            else
                textBox.KeyUp -= OnKeyUp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnKeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            ICommand command = GetEnterCommand(textBox);

            if ((e.Key == Key.Enter) && (command != null))
                command.ExecuteIfCan(GetEnterCommandParameter(textBox));
        }  
    }
}
