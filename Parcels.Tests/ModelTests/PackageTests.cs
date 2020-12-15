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
        [TestMethod]
        public void GetVolume_GetsVolumeOfPackage_Int()
        {
            Package newPackage = new Package(2, 3, 4, 5);
            int testVolume = 24;
            newPackage.GetVolume();
            Assert.AreEqual(testVolume, newPackage.Volume);

        }
        [TestMethod]
        public void CostToShip_GetsShipmentPrice_Int()
        {
            Package newPackage = new Package(2,3,4,5);
            newPackage.Volume = 10;
            int testCost = 45;
            int shippingCost = newPackage.CostToShip();
            Assert.AreEqual(testCost, shippingCost);
        }
        
    }
    
} 