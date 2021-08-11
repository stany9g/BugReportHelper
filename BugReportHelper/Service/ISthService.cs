using System.Collections.Generic;
using BugReportHelper.Model;

namespace BugReportHelper.Service
{
    public interface ISthService
    {
        List<Vbs> LoadInfo(string path);
    }
}