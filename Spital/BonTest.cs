using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{   [TestFixture]
    class BonTest
    {
        [TestCase]
        public void totalPlata()
        {
            Boala boala = new Boala("7");
            Bon bon = new Bon(boala,59);
            Assert.AreEqual(413,bon.totalPlata());
        }
    }
}
