using System;

namespace DemoLibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }

        string Title { get; set; }

        //DateTime BorrowDate { get; set; }

        //string Borrower { get; set; }

        //int CheckOutDurationInDays { get; set; }

        //void CheckIn();

        //void CheckOut(string borrower);

        //DateTime GetDueDate();
    }
}
