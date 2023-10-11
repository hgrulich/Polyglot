using Polyglot.Application.Models;

namespace Polyglot.Application;

public interface IVocabularyService
{
    Task InitializeAsync(CancellationToken token);
    Lesson[] AvailableLessons { get; }
}