using Polyglot.Application.Models;
using Polyglot.WebUI.ViewModels;

namespace Polyglot.WebUI.StateContainers;

public class PracticeSetupContainer
{
    public int SuccessCount { get; set; }
    public Lesson[] LessonsToPractice { get; set; } = Array.Empty<Lesson>();
}