using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_task1
{
    internal class Operations
    {
        private string _add;
        private string _remove;
        private string _update;
        private string _delete;
        public string Add
        {
            get { return _add; }
            set { _add = value; }
        }
        public string Remove
        {
            get { return _remove; }
            set { _remove = value; }
        }
        public string Update
        {
            get { return _update; }
            set { _update = value; }
        }
        public string Delete
        {
            get { return _delete; }
            set { _delete = value; }

        }
    }
}
