using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onCancel;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnCancel(ICommand command)
        {
            _onCancel = command;
        }

        public void Start()
        {
            if (_onCancel is ICommand)
            {
                _onStart.Execute();
            }
        }

        public void Cancel()
        {
            if (_onCancel is ICommand)
            {
                _onCancel.Execute();
            }
        }
    }
}
