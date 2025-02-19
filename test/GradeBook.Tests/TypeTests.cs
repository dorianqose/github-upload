using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
            
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book1 = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
            
        }

        private void GetBookSetName(Book book, string name)
        {
            book1 = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
            
        }

        private void SetName(Book book1, string name)
        {
            book.Name = name;
        }

        [Fact] //this is an attribute which attaches to the symbol it follows it, in this case Test1()
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
            
        }

        [Fact] //this is an attribute which attaches to the symbol it follows it, in this case Test1()
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; 

            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));
            
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
