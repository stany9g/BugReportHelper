using System.Collections.Generic;
using BugReportHelper.Model;

namespace BugReportHelper.Service
{
    public class SthsService : ISthService
    {
        public List<Vbs> LoadInfo(string path)
        {
            //Here will be code from previous project
            return new List<Vbs>()
            {
                new Vbs() {TextToCopy = "A"},
                new Vbs() {TextToCopy = "B"},
                new Vbs() {TextToCopy = "C", IsSelected = true},
                new Vbs() {TextToCopy = "D"},
                new Vbs() {TextToCopy = "E", IsSelected = true},
            };
        }
    }
}