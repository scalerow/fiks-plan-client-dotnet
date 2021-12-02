using System.IO;
using KS.Fiks.Plan.Client.Models;
using NUnit.Framework;

namespace KS.Fiks.Plan.Client.Tests
{
    public class MeldingtypeTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        [TestCase(FiksPlanMeldingtypeV2.FinnDispensasjoner)]
        [TestCase(FiksPlanMeldingtypeV2.HentAktoerer)]
        public void Gi_plan_schema_har_filnavn_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemafileExistInSchemaFolder(meldingstype));
        }

        private static bool SchemafileExistInSchemaFolder(string meldingstype)
        {
            return File.Exists(Path.Combine("Schema", $"{meldingstype}.schema.json"));
        }
    }
}