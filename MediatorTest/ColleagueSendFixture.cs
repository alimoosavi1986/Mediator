using Mediator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediatorTest
{
    [TestClass]
    public class ColleagueSendFixture
    {
        [TestMethod]
        public void ColleagueSendTest1()
        {
            ConcreateColleague1 c1 = new ConcreateColleague1();
            ConcreateColleague2 c2 = new ConcreateColleague2();
            ConcreateMediator mediator = new ConcreateMediator(c1, c2);

            c1.SetMediator(mediator);
            c2.SetMediator(mediator);

            string expected = c1.Send("Hello");

            string actual = "ConcreateColleague2 Receiveed: Hello";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ColleagueSendTest2()
        {
            ConcreateColleague1 c1 = new ConcreateColleague1();
            ConcreateColleague2 c2 = new ConcreateColleague2();
            ConcreateMediator mediator = new ConcreateMediator(c1, c2);

            c1.SetMediator(mediator);
            c2.SetMediator(mediator);

            string expected = c2.Send("I'm Fine");

            string actual = "ConcreateColleague1 Receiveed: I'm Fine";

            Assert.AreEqual(expected, actual);

        }
    }
}
