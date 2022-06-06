using DemoLibrary.GeneralInterface;

namespace DemoLibrary.AudioBook
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
