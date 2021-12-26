public class Borrow{

    private string id;
    private string bookId;
    private string memberId;
    private DateTime borrowDate;
    private DateTime returnDate;
    private DateTime mustReturnDate;

    public string getId()
    {
        return this.id;
    }

    public void setId(string id)
    {
        this.id = id;
    }

    public string getBookId()
    {
        return this.bookId;
    }

    public void setBookId(string bookId)
    {
        this.bookId = bookId;
    }

    public string getMemberId()
    {
        return this.memberId;
    }

    public void setMemberId(string memberId)
    {
        this.memberId = memberId;
    }

    public DateTime getBorrowDate()
    {
        return this.borrowDate;
    }

    public void setBorrowDate(DateTime borrowDate)
    {
        this.borrowDate = borrowDate;
    }

    public DateTime getReturnDate()
    {
        return this.returnDate;
    }

    public void setReturnDate(DateTime returnDate)
    {
        this.returnDate = returnDate;
    }

    public DateTime getMustReturnDate()
    {
        return this.mustReturnDate;
    }

    public void setMustReturnDate(DateTime mustReturnDate)
    {
        this.mustReturnDate = mustReturnDate;
    }


}