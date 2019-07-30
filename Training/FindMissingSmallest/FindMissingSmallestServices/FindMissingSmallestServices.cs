using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMissingSmallestServices {
    public class FindMissingSmallestServices : IDisposable {
        public List<int> FindMissing (int[] arr) {
            if (arr.Length != 0) {
                //Sort list first..
                var ordered = arr.Select (p => p).OrderBy (o => o).ToArray ();

                List<int> missingList = new List<int> ();

                for (int i = 1; i < arr.Max () + 1; i++) {

                    if (!ordered.Contains (i)) {
                        missingList.Add (i);
                    }
                }
                return missingList;
            }
            return new List<int> ();
        }

        public void Dispose () {
            //
        }

    }

}