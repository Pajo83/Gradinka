using System;
using System.Collections.Generic;
using System.Text;

namespace Gradinka
{
    class Kindergarden
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(Group group)
        {
            groups.Add(group);
        }
        
        public Group FindByGroupType(string type)
        {
            for(var i=0; i< this.groups.Count;i++)
            {
                if (this.groups[i].GroupType == type)
                {
                    return this.groups[i];
                }
            }
            return null;
        }

        public void UpdateGroup(Group groupUpdated)
        {
            for (var i = 0; i < this.groups.Count; i++)
            {
                if (this.groups[i].GroupType == groupUpdated.GroupType)
                {
                    this.groups[i] = groupUpdated;
                }
            }
        }
    }
}
