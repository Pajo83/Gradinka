using System;
using System.Collections.Generic;
using System.Text;

namespace Gradinka
{
    class Group
    {
        private List<Kid> kids = new List<Kid>();

        private string groupType;
        private int limit;

        public string GroupType { get => groupType; set => groupType = value; }
        public int Limit { get => limit; set => limit = value; }

        public Group(string groupType, int limit)
        {
            this.groupType = groupType;
            this.limit = limit;
        }

        public bool IsLimitReached()
        {
            if (limit <= this.kids.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void AddKid(Kid kid)
        {
            this.kids.Add(kid);
        }

    }
}
