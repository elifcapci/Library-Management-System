public class Borrow{

    private string Id;
    private string BookId;
    private string MemberId;
    private DateTime BorrowDate;
    private DateTime ReturnDate;
    private DateTime MustReturnDate;

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

    public string getMemberId()
    {
        return this.MemberId;
    }

    public void setMemberId(string MemberId)
    {
        this.MemberId = MemberId;
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

    public DateTime getMustReturnDate()
    {
        return this.MustReturnDate;
    }

    public void setMustReturnDate(DateTime MustReturnDate)
    {
        this.MustReturnDate = MustReturnDate;
    }

    public Borrow(string id, string bookId, string memberId, DateTme borrowDate, DateTime returnDate, DateTime mustReturnDate) {
        Id = id;
        BookId = bookId;
        MemberId = memberId;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
        MustReturnDate = mustReturnDate;
    }

    public Borrow(){

    }

    public static void createBorrow(){

    }
    public static void deleteBorrow(){

    }
    public static void displayBorrow(){

    }
}