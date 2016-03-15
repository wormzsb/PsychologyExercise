using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PsyEx.Mapper
{
    public class TaskResult
    {
        private string task;
        private List<string> columns;
        private List<List<string>> values;

        public List<string> Columns
        {
            get
            {
                return columns;
            }

            set
            {
                columns = value;
            }
        }

        public List<List<string>> Values
        {
            get
            {
                return values;
            }

            set
            {
                values = value;
            }
        }

        public string Task
        {
            get
            {
                return task;
            }

            set
            {
                task = value;
            }
        }
    }
}
