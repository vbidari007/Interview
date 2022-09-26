using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksQueues
{
    public class KeysAndLockSolution
    {
        // [[1,3],[3,0,1],[2],[0]]
        // [[1],[2],[3],[]]
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int total_rooms = rooms.Count;
            HashSet<int> visited = new HashSet<int>();
            //visited.Add(0);

            Stack<int> keys = new Stack<int>();
            keys.Push(0);

            while(keys.Count > 0)
            {
                var key = keys.Pop();
                visited.Add(key);
                var new_keys = rooms[key];
                foreach (var new_key in new_keys)
                {
                    if(!visited.Contains(new_key))
                        keys.Push(new_key);
                }
            }

            return visited.Count == total_rooms;
        }
    }
}
