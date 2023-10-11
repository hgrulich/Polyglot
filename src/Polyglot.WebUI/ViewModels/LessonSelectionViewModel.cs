namespace Polyglot.WebUI.ViewModels;

public class LessonSelectionViewModel
{
    public LessonSelectionViewModel(string lessonName, bool isSelected = false)
    {
        LessonName = lessonName;
        IsSelected = isSelected;
    }

    public string LessonName { get; set; }
    public bool IsSelected { get; set; }
}