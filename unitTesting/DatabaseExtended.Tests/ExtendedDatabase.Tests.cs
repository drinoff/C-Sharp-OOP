using NUnit.Framework;
using System;


namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Person person;
        private Person[] persons = new Person[16];
        [SetUp]
        public void Setup()
        {
            for (int i = 0; i < 16; i++)
            {
                var userName = "person" + i;
                var person = new Person(i, userName);
                persons[i] = person;
            }
            
        }

        [Test]
        public void TestIfPersonConstructorWorksCorrectly()
        {
            var expectedName = "Pesho";
            var expectedId = (long)1;

            var person = new Person(1, "Pesho");

            Assert.AreEqual(expectedName, this.person.UserName);
            Assert.AreEqual(expectedId, this.person.Id);
        }

        [Test]
        public void ConstructorShouldAddCorectlyTheRangeOfPersons()
        {
            //Arrange

            var expected = persons.Length;

            //Act
            var dataBase = new ExtendedDatabase(persons);
            var actual = dataBase.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestIfAddRangeThrowsExceptionWhenDatabaseIsFull()
        {
            var data = new Person[17];

            Assert.Throws<ArgumentException>(() =>
            {
                var dataBase = new ExtendedDatabase(data);
            });
        }

        [Test]
        public void AddMethodShouldThrowInvalidOpExceptionIfPersonWithSameNameExistInDataBase()
        {
            //Arrange

            var testPerosnId = 100000;
            var testPersonName = "person5";
            var testPerson = new Person(testPerosnId, testPersonName);
            var dataBase = new ExtendedDatabase(persons);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.Add(testPerson); // Act
            });
        }

        [Test]
        public void AddMethodShouldThrowInvalidOpExceptionIfPersonWithSameIdExistInDataBase()
        {
            //Arrange

            var testPerosnId = 1;
            var testPersonName = "person567";
            var testPerson = new Person(testPerosnId, testPersonName);
            var dataBase = new ExtendedDatabase(persons);

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.Add(testPerson); // Act
            });
        }

        [Test]
        public void RemoveShouldThrowInvalidOpExceptionIfDataBaseIsEmpty()
        {
            //Arrange            
            var dataBase = new ExtendedDatabase();

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.Remove();   // Act
            });
        }

        [Test]
        public void RemoveMethodShouldDeleteTheLastPersonFromDataBase()
        {
            //Arrange

            var testPerosnId = 1;
            var testPersonName = "person567";
            var testPerson = new Person(testPerosnId, testPersonName);
            var dataBase = new ExtendedDatabase(persons);

            //Act
            dataBase.Remove();
            var expected = persons.Length - 1;
            var actual = dataBase.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldThrowArgumentNullExceptionIfUsernameParameterIsNull()
        {
            //Arrange            
            var dataBase = new ExtendedDatabase();
            string personName = null;

            //Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                dataBase.FindByUsername(personName);   // Act
            });
        }

        [Test]
        public void ShouldThrowInvalidOpExceptionIfPersonWithGivenUsernameDoesNotExistInDataBase()
        {
            //Arrange            
            var dataBase = new ExtendedDatabase(persons);
            string personName = "Pesho";

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.FindByUsername(personName);   // Act
            });
        }

        [Test]
        public void ShouldThrowInvalidOpExceptionIfPersonByGivenIdIsNotInDataBase()
        {
            //Arrange            
            var dataBase = new ExtendedDatabase(persons);
            long personId = 4763746376473;

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.FindById(personId);   // Act
            });
        }

        [Test]
        public void ShouldThrowArgumentOutOfRangeExceptionIfNegativeId()
        {
            //Arrange            
            var dataBase = new ExtendedDatabase(persons);
            long personId = -2232323232;

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                dataBase.FindById(personId);   // Act
            });
        }        

        [Test]

        public void CountShouldReturnDataLentgh()
        {
            //Arrange
            var dataBase = new ExtendedDatabase(persons);

            //Act
            var expected = persons.Length;
            var actual = dataBase.Count;

            //Asert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfTryToAddMoreThanSixteenPersons()
        {
            //Arrange
            var dataBase = new ExtendedDatabase(persons);
            var personName = "Stamat";
            long personID = 4567;
            var person = new Person(personID,personName);

            //Asert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.Add(person);  //Act
            });
        }

       // [Test]

        //public void AddMethodShouldAddGivenPersonToDataIfDataCountIsLessThanSixteen()
        //{
            //Arrange
            
           // var personName = "Stamat";
           // long personID = 4567;
           // var person = new ExtendedDatabase.Person(personID,personName);
           // var persons = new ExtendedDatabase.Person[] {person};
           // var dataBase = new ExtendedDatabase.ExtendedDatabase(persons);

            //Act
           // var testPersonName = "Dimitrichko";
           // long testPersonID = 6467346736473;
           // var testPerson = new ExtendedDatabase.Person(testPersonID, testPersonName);
           // dataBase.Add(testPerson);
            

            //Asert
           // Assert.Contains(testPerson,persons);
       // }

        [Test]
        public void RemoveMethodShouldThrowExceptionIfDataIsEmpty()
        {
            //Arrange
            var emptyPersons = new Person[0];
            var dataBase = new ExtendedDatabase(emptyPersons);


            //Asert
            Assert.Throws<InvalidOperationException>(() =>
            {
                dataBase.Remove();  //Act
            });
        }

        [Test]

        public void RemoveMethdShouldRemoveAnPersonFromDataIfNotEmpty()
        {
            //Arrange
            
            var dataBase = new ExtendedDatabase(persons);

            //Act
            dataBase.Remove();
            var expected = persons.Length - 1;
            var actual = dataBase.Count;

            //Asert
            Assert.AreEqual(expected, actual);
        }

        
    }
}