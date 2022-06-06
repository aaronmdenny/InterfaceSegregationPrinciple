using DemoLibrary.GeneralInterface;
using System.Collections.Generic;

namespace DemoLibrary.DVD
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }

        int RuntimeInMinutes { get; set; }
    }
}
