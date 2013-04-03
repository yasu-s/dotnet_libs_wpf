namespace Yazaike.Wpf.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Input;

    /// <summary>
    /// ICommand Extension Class
    /// </summary>
    public static class ICommandExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        public static void ExecuteIfCan(this ICommand command, object parameters)
        {
            if (command.CanExecute(parameters))
                command.Execute(parameters);
        }
    }
}
