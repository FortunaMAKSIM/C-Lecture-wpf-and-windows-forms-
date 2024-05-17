using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laba6.Models
{
    public class PersonModelMVVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; } = DateOnly.MinValue;

        private int _percentDone = 0;

        public int PercentDone
        {
            get => _percentDone;
            set
            {
                _percentDone = value;
                OnPropertyChanged();
            }
        }

        private bool _isCancelled;

        public async void BeginProcess()
        {
            _isCancelled = false;

            for (int i = PercentDone; i <= 100; i += 5)
            {
                if (_isCancelled)
                {
                    break;
                }

                PercentDone = i;
                await Task.Delay(500);
            }
        }

        public void StopProcess()
        {
            _isCancelled = true;
        }

        public async void ResetProcessAsync()
        {
            StopProcess();
            PercentDone = 0;
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
