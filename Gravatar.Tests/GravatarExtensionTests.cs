using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("e@hotmail.com", false)]
        [DataRow("ermersonrafael@hotmail.com", true)]
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/512cf606c878977168872fc50331d64c";
            Assert.AreEqual((email.ToGravatar() == result), status);
        }
    }
}
