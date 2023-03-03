using System.Collections;
using System.Collections.Generic;
using Tekla.Structures.Model;

namespace BourneIssueApp.Utilities
{
    public static class ModelUI
    {
        public static void SelectParts(List<Part> parts)
        {
            var mos = new Tekla.Structures.Model.UI.ModelObjectSelector();
            mos.Select(new ArrayList(parts), false);
        }
    }
}