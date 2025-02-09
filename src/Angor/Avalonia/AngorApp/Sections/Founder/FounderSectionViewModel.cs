using System.Collections.ObjectModel;
using System.Linq;
using AngorApp.Model;
using AngorApp.Sections.Browse;

namespace AngorApp.Sections.Founder;

public class FounderSectionViewModel : ReactiveObject, IFounderSectionViewModel
{
    public FounderSectionViewModel()
    {
        Projects = new ReadOnlyCollection<IProject>(SampleData.GetProjects().ToList());
    }

    public IReadOnlyCollection<IProject> Projects { get; set; }
}