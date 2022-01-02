
public class BookReturn{

    private string Id;
    private string BookId;
    private string BorrowId;
    private DateTime BorrowDate;
    private DateTime ReturnDate;
    private string FineId;

    public string getId()
    {
        return this.Id;
    }

    public void setId(string Id)
    {
        this.Id = Id;
    }

    public string getBookId()
    {
        return this.BookId;
    }

    public void setBookId(string BookId)
    {
        this.BookId = BookId;
    }

    public string getBorrowId()
    {
        return this.BorrowId;
    }

    public void setBorrowId(string BorrowId)
    {
        this.BorrowId = BorrowId;
    }

    public DateTime getBorrowDate()
    {
        return this.BorrowDate;
    }

    public void setBorrowDate(DateTime BorrowDate)
    {
        this.BorrowDate = BorrowDate;
    }

    public DateTime getReturnDate()
    {
        return this.ReturnDate;
    }

    public void setReturnDate(DateTime ReturnDate)
    {
        this.ReturnDate = ReturnDate;
    }

    public string getFineId()
    {
        return this.FineId;
    }

    public void setFineId(string FineId)
    {
        this.FineId = FineId;
    }

    public BookReturn(string id, string bookId, string borrowId, DateTime borrowDate, DateTime returnDate, string fineId){
        Id = id;
        BookId = bookId;
        BorrowId = borrowId;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
        FineId = fineId;
    }

    public BookReturn() {
    }
    
}