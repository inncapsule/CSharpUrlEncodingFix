using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PubNub_Messaging.Tests
{
    [TestClass]
    public class WhenGetRequestServerTime
    {
        [TestMethod]
        public void ThenItShouldReturnTimeStamp()
        {
            Pubnub pubnub = new Pubnub(
                "demo",
                "demo",
                "",
                false
            );
            
            object timestamp = pubnub.Time();
            Assert.AreNotEqual(null, timestamp);
        }
    }
}
