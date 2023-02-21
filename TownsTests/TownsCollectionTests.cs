
namespace TownsTests
{
    public class TownsCollectionTests
    {

        [Test]
        public void Test_Constructor_EmptyConstructor()
        {
            var townCollection = new TownsCollection();
            Assert.That(townCollection.Towns.Count, Is.EqualTo(0));
            Assert.That(townCollection.ToString(), Is.Empty);
        }
        [Test]
        public void Test_Constructor_SingleTown()
        {
            var townCollection = new TownsCollection("Paris");
            Assert.That(townCollection.Towns.Count, Is.EqualTo(1));
            Assert.That(townCollection.ToString(), Is.EqualTo("Paris"));
        }
        [Test]
        public void Test_Constructor_TwoTowns()
        {
            var townCollection = new TownsCollection("Paris, London");
            Assert.That(townCollection.Towns.Count, Is.EqualTo(2));
            Assert.That(townCollection.ToString(), Is.EqualTo("Paris, London"));
        }
        [Test]
        public void Test_Add_SingleTown()
        {
            var townCollection = new TownsCollection("Paris, London");
            townCollection.Add("Sofia");
            Assert.That(townCollection.Towns.Count, Is.EqualTo(3));
            Assert.That(townCollection.ToString(), Is.EqualTo("Paris, London, Sofia"));

        }
        [Test]
        public void Test_Add_SingleTownAlternative()
        {
            var isAdded = new TownsCollection("Paris, London").Add("Sofia");
            Assert.True(isAdded);
           

        }
        [Test]
        public void Test_Add_EmptyTown()
        {
            var townCollection = new TownsCollection("Paris, London");
            townCollection.Add("");
            Assert.That(townCollection.Towns.Count, Is.EqualTo(2));
            Assert.That(townCollection.ToString(), Is.EqualTo("Paris, London"));

        }
        [Test]
        public void Test_Add_DuplicateTown()
        {
            var townCollection = new TownsCollection("Paris, London");
            townCollection.Add("Paris");
            Assert.That(townCollection.Towns.Count, Is.EqualTo(2));
            Assert.That(townCollection.ToString(), Is.EqualTo("Paris, London"));

        }
        [Test]
        public void Test_RemoveAtIndex_ValidIndex()
        {
            var townCollection = new TownsCollection("Paris, London");
            townCollection.RemoveAt(0);
            Assert.That(townCollection.Towns.Count, Is.EqualTo(1));
            Assert.That(townCollection.ToString(), Is.EqualTo("London"));

        }
        [Test]
        public void Test_RemoveAtIndex_InvalidIndex()
        {
            Assert.That(() => new TownsCollection("Paris, London").RemoveAt(5), Throws.InstanceOf<ArgumentException>());

        }
        [Test]
        public void Test_Reverse_TwoTowns()
        {
            var townCollection = new TownsCollection("Paris, London");
            townCollection.Reverse();
            Assert.That(townCollection.Towns.Count, Is.EqualTo(2));
            Assert.That(townCollection.ToString(), Is.EqualTo("London, Paris"));

        }
        [Test]
        public void Test_Reverse_SingleTown()
        {
            Assert.That(() => new TownsCollection("Paris").Reverse(), Throws.InstanceOf<InvalidOperationException>());

        }
        [Test]
        public void Test_Reverse_ZeroTown()
        {
            Assert.That(() => new TownsCollection("Paris").Reverse(), Throws.InstanceOf<InvalidOperationException>());

        }
    }
}
