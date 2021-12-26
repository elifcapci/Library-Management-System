
public class BookReturn{

    private string iD;
    private string bookId;
    private string borrowId;
    private DateTime borrowDate;
    private DateTime returnDate;
    private string fineId;

    public string getID()
    {
        return this.iD;
    }

    public void setID(string iD)
    {
        this.iD = iD;
    }

    public string getBookId()
    {
        return this.bookId;
    }

    public void setBookId(string bookId)
    {
        this.bookId = bookId;
    }

    public string getBorrowId()
    {
        return this.borrowId;
    }

    public void setBorrowId(string borrowId)
    {
        this.borrowId = borrowId;
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

    public string getFineId()
    {
        return this.fineId;
    }

    public void setFineId(string fineId)
    {
        this.fineId = fineId;
    }


}