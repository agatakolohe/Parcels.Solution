using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{   
    [TestClass]
    public class PackageTest
    {
        [TestMethod]
        public void PackageConstructor_CreateInstanceOfPackage_Package()
        {
            Package newPackage = new Package(1, 1, 1, 1);
            Assert.AreEqual(typeof(Package), newPackage.GetType());
            Assert.AreEqual(1, newPackage.Width);

        }
        
    }
    
} 