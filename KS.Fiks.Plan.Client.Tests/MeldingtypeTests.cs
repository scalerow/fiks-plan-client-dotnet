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
        [TestCase(FiksPlanMeldingtypeV2.FinnPlanerForMatrikkelenhet)]
        [TestCase(FiksPlanMeldingtypeV2.FinnPlaner)]
        [TestCase(FiksPlanMeldingtypeV2.FinnPlanbehandlinger)]
        [TestCase(FiksPlanMeldingtypeV2.HentArealplan)]
        [TestCase(FiksPlanMeldingtypeV2.HentGjeldendePlanbestemmelser)]
        [TestCase(FiksPlanMeldingtypeV2.HentRelatertePlaner)]
        [TestCase(FiksPlanMeldingtypeV2.HentKodeliste)]
        [TestCase(FiksPlanMeldingtypeV2.FinnPlandokumenter)]
        [TestCase(FiksPlanMeldingtypeV2.HentPlanfil)]
        [TestCase(FiksPlanMeldingtypeV2.FinnPlanerForOmraade)]
        [TestCase(FiksPlanMeldingtypeV2.HentBboxForPlan)]
        [TestCase(FiksPlanMeldingtypeV2.HentPlanomraader)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatFinnPlanerForMatrikkelenhet)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatFinnPlaner)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatFinnDispensasjoner)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentGjeldendePlanbestemmelser)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentAktoerer)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentRelatertePlaner)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentKodeliste)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatFinnPlandokumenter)]
        //[TestCase(FiksPlanMeldingtypeV2.ResultatHentPlanfil)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatFinnPlanerForOmraade)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentBboxForPlan)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatHentPlanomraader)]
        public void Gi_plan_innsyn_schema_har_filnavn_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemafileExistInSchemaFolder(meldingstype));
        }

        [TestCase(FiksPlanMeldingtypeV2.OpprettArealplan)]
        [TestCase(FiksPlanMeldingtypeV2.RegistrertPlanavgrensning)]
        [TestCase(FiksPlanMeldingtypeV2.RegistrerPlanbehandling)]
        [TestCase(FiksPlanMeldingtypeV2.OppdaterArealplan)]
        [TestCase(FiksPlanMeldingtypeV2.ResultatOpprettArealplan)]
        public void Gi_plan_oppdater_schema_har_filnavn_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemafileExistInSchemaFolder(meldingstype));
        }

        [TestCase(FiksPlanMeldingtypeV2.RegistrerDispensasjonFraPlan)]
        [TestCase(FiksPlanMeldingtypeV2.OppdaterDispensasjon)]
        public void Gi_plan_ebyggesak_schema_har_filnavn_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemafileExistInSchemaFolder(meldingstype));
        }

        private static bool SchemafileExistInSchemaFolder(string meldingstype)
        {
            return File.Exists(Path.Combine("Schema", $"{meldingstype}.schema.json"));
        }
    }
}