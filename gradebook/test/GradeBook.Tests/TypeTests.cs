using GradeBook.Model;
using Xunit;

namespace GradeBook.Tests
{

  public delegate string WriteLogDelegate(string logMessage);

  public class TypeTests
  {

    int count = 0;

    [Fact]
    public void WriteLogDelegateCanPointToMethod()
    {
      WriteLogDelegate log = ReturnMessage;
      log += ReturnMessage;
      log += IncrementCount;
      string result = log("Hello");
      Assert.Equal(3, count);
      Assert.Equal("hello", result);
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
      string name = "Minh Duy";
      string newName = MakeUpperCase(name);

      Assert.Equal("Minh Duy", name);
      Assert.Equal("MINH DUY", newName);
    }
    
    [Fact]
    public void Test1()
    {
      var x = GetInt();
      SetInt(ref x);
      Assert.Equal(42, x);
    }

    [Fact]
    public void CSharpCanPassByReference()
    {
      Book book1 = GetBook("Book 1");
      GetBookSetName(ref book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void CSharpIsPassByValue()
    {
      Book book1 = GetBook("Book 1");
      GetBookSetName(book1, "New Name");

      Assert.Equal("Book 1", book1.Name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
      Book book1 = GetBook("Book 1");
      SetName(book1, "New Name");

      Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void GetBookReturnsDifferenObjects()
    {
      Book book1 = GetBook("Book 1");
      Book book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
      Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
      Book book1 = GetBook("Book 1");
      Book book2 = book1;

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 1", book2.Name);
      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
    }

    private Book GetBook(string name)
    {
      return new Book(name);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }

    private void GetBookSetName(ref Book book, string name)
    {
      book = new Book(name);
    }

    private void GetBookSetName(Book book, string name)
    {
      book = new Book(name);
    }

    private int GetInt()
    {
      return 3;
    }

    private void SetInt(ref int x)
    {
      x = 42;
    }

    private string MakeUpperCase(string name)
    {
      return name.ToUpper();
    }

    string ReturnMessage(string message)
    {
      count++;
      return message;
    }

    string IncrementCount(string message)
    {
      count++;
      return message.ToLower();
    }

  }
}