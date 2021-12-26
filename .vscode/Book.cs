public class Book {

    private string Id;
    private string Name;
    private string PublicationDate;
    private string Publisher;
    private int NumberOfPages;
    private string Language;
    private string AuthorID;
    private string IsbnNumber;
    private string Category;

    public string getId()
    {
        return this.Id;
    }

    public void setId(string Id)
    {
        this.Id = Id;
    }

    public string getName()
    {
        return this.Name;
    }

    public void setName(string Name)
    {
        this.Name = Name;
    }

    public string getPublicationDate()
    {
        return this.PublicationDate;
    }

    public void setPublicationDate(string PublicationDate)
    {
        this.PublicationDate = PublicationDate;
    }

    public string getPublisher()
    {
        return this.Publisher;
    }

    public void setPublisher(string Publisher)
    {
        this.Publisher = Publisher;
    }

    public int getNumberOfPages()
    {
        return this.NumberOfPages;
    }

    public void setNumberOfPages(int NumberOfPages)
    {
        this.NumberOfPages = NumberOfPages;
    }

    public string getLanguage()
    {
        return this.Language;
    }

    public void setLanguage(string Language)
    {
        this.Language = Language;
    }

    public string getAuthorID()
    {
        return this.AuthorID;
    }

    public void setAuthorID(string AuthorID)
    {
        this.AuthorID = AuthorID;
    }

    public string getIsbnNumber()
    {
        return this.IsbnNumber;
    }

    public void setIsbnNumber(string IsbnNumber)
    {
        this.IsbnNumber = IsbnNumber;
    }

    public string getCategory()
    {
        return this.Category;
    }

    public void setCategory(string Category)
    {
        this.Category = Category;
    }

    public Book(string name,string isbnNumber,string category,string publicationDate){

        Name = name;
        IsbnNumber = isbnNumber;
        Category = category;
        PublicationDate = publicationDate;
    }

    public Book(){

    }
}
