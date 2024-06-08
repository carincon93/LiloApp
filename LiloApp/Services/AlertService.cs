using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace LiloApp.Services
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string message, string cancel);
        Task<bool> ShowConfirmationAsync(string title, string message, string accept, string cancel);
    }

    public class AlertService : IAlertService
    {
        public async Task ShowAlertAsync(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> ShowConfirmationAsync(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}