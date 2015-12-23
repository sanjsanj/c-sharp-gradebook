using System;

namespace Grades
{
    public class NameChangedEventArgs : EventArgs
    {
        internal object existingName;
        internal object newName;

        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
