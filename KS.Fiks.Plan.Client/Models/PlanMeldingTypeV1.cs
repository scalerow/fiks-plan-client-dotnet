using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Fiks.Plan.Client.Models
{
    public class PlanMeldingTypeV1
    {
        // Forespørsler-innsyn
        public const string FinnPlanerForMatrikkelenhet = "no.ks.fiks.gi.plan.innsyn.finnplanerformatrikkelenhet.v2";
        public const string FinnPlaner = "no.ks.fiks.gi.plan.innsyn.finnplaner.v2";
        public const string FinnDispensasjoner = "no.ks.fiks.gi.plan.innsyn.finndispensasjoner.v2";
        public const string FinnPlanbehandlinger = "no.ks.fiks.gi.plan.innsyn.finnplanbehandlinger.v2";
        public const string HentArealplan = "no.ks.fiks.gi.plan.innsyn.hentarealplan.v2";
        public const string HentGjeldendePlanbestemmelser = "no.ks.fiks.gi.plan.innsyn.hentgjeldendeplanbestemmelser.v2";
        public const string HentAktoerer = "no.ks.fiks.gi.plan.innsyn.hentaktorer.v2";
        public const string HentRelatertePlaner = "no.ks.fiks.gi.plan.innsyn.hentrelaterteplaner.v2";
        public const string HentKodeliste = "no.ks.fiks.gi.plan.innsyn.hentkodeliste.v2";
        public const string FinnPlandokumenter = "no.ks.fiks.gi.plan.innsyn.finnplandokumenter.v2";
        public const string HentPlanfil = "no.ks.fiks.gi.plan.innsyn.hentplanfil.v2";
        public const string FinnPlanerForOmraade = "no.ks.fiks.gi.plan.innsyn.finnplanerforomraade.v2";
        public const string HentBboxForPlan = "no.ks.fiks.gi.plan.innsyn.hentbboxforplan.v2";
        public const string HentPlanomraader = "no.ks.fiks.gi.plan.innsyn.hentplanomraader.v2";
         
        // Resultat på forespørsler-innsyn
        public const string ResultatFinnPlanerForMatrikkelenhet = "no.ks.fiks.gi.plan.innsyn.planerformatrikkelenhet.v2";
        public const string ResultatFinnPlaner = "no.ks.fiks.gi.plan.innsyn.planerforsoek.v2";
        public const string ResultatFinnDispensasjoner = "no.ks.fiks.gi.plan.innsyn.dispensasjoner.v2";
        public const string ResultatHentGjeldendePlanbestemmelser = "no.ks.fiks.gi.plan.innsyn.gjeldendeplanbestemmelser.v2";
        public const string ResultatHentAktoerer = "no.ks.fiks.gi.plan.innsyn.aktoerer.v2";
        public const string ResultatHentRelatertePlaner = "no.ks.fiks.gi.plan.innsyn.relaterteplaner.v2";
        public const string ResultatHentKodeliste = "no.ks.fiks.gi.plan.innsyn.kodeliste.v2";
        public const string ResultatFinnPlandokumenter = "no.ks.fiks.gi.plan.innsyn.plandokumenter.v2";
        public const string ResultatHentPlanfil = "no.ks.fiks.gi.plan.innsyn.planfil.v2";
        public const string ResultatFinnPlanerForOmraade = "no.ks.fiks.gi.plan.innsyn.planerforområde.v2";
        public const string ResultatHentBboxForPlan = "no.ks.fiks.gi.plan.innsyn.bbox.v2";
        public const string ResultatHentPlanomraader = "no.ks.fiks.gi.plan.innsyn.planomraader.v2";

        // Forespørsler-oppdatering
        public const string OpprettArealplan = "no.ks.fiks.gi.plan.oppdatering.opprettarealplan.v2";
        public const string RegistrertPlanavgrensning = "no.ks.fiks.gi.plan.oppdatering.registrerplanavgrensning.v2";
        public const string RegistrerPlanbehandling = "no.ks.fiks.gi.plan.oppdatering.registrerplanbehandling.v2";
        public const string OppdaterArealplan = "no.ks.fiks.gi.plan.oppdatering.oppdaterarealplan.v2";

        // Resultat på forespørsler-oppdatering
        public const string ResultatOpprettArealplan = "no.ks.fiks.gi.plan.oppdatering.meldingomplanident.v2";
        public const string ResultatMottat = "no.ks.fiks.gi.plan.oppdatering.mottatt.v2";

        // Ebyggesak 
        public const string RegistrerDispensasjonFraPlan = "no.ks.fiks.gi.plan.oppdatering.registrerdispensasjonplan.v2";
        public const string OppdaterDispensasjon = "no.ks.fiks.gi.plan.oppdatering.oppdaterdispensasjon.v2";

        private static Dictionary<string, string> Skjemanavn;

        public static string GetSkjemanavn(string meldingstypeNavn)
        {
            if (Skjemanavn == null)
            {
                initSkjemanavn();
            }
            return Skjemanavn[meldingstypeNavn];
        }

        private static void initSkjemanavn()
        {
            Skjemanavn = new Dictionary<string, string>();
            AddSkjemanavnTilDictionary(FinnPlanerForMatrikkelenhet);
            AddSkjemanavnTilDictionary(FinnPlaner);
            AddSkjemanavnTilDictionary(FinnDispensasjoner);
            AddSkjemanavnTilDictionary(FinnPlanbehandlinger);
            AddSkjemanavnTilDictionary(HentArealplan);
            AddSkjemanavnTilDictionary(HentGjeldendePlanbestemmelser);
            AddSkjemanavnTilDictionary(HentAktoerer);
            AddSkjemanavnTilDictionary(HentRelatertePlaner);
            AddSkjemanavnTilDictionary(HentKodeliste);
            AddSkjemanavnTilDictionary(FinnPlandokumenter);
            AddSkjemanavnTilDictionary(HentPlanfil);
            AddSkjemanavnTilDictionary(FinnPlanerForOmraade);
            AddSkjemanavnTilDictionary(HentBboxForPlan);
            AddSkjemanavnTilDictionary(HentPlanomraader);
            AddSkjemanavnTilDictionary(ResultatFinnPlanerForMatrikkelenhet);
            AddSkjemanavnTilDictionary(ResultatFinnPlaner);
            AddSkjemanavnTilDictionary(ResultatFinnDispensasjoner);
            AddSkjemanavnTilDictionary(ResultatHentGjeldendePlanbestemmelser);
            AddSkjemanavnTilDictionary(ResultatHentAktoerer);
            AddSkjemanavnTilDictionary(ResultatHentRelatertePlaner);
            AddSkjemanavnTilDictionary(ResultatHentKodeliste);
            AddSkjemanavnTilDictionary(ResultatHentPlanfil);
            AddSkjemanavnTilDictionary(ResultatFinnPlanerForOmraade);
            AddSkjemanavnTilDictionary(ResultatHentBboxForPlan);
            AddSkjemanavnTilDictionary(OpprettArealplan);
            AddSkjemanavnTilDictionary(RegistrertPlanavgrensning);
            AddSkjemanavnTilDictionary(RegistrerPlanbehandling);
            AddSkjemanavnTilDictionary(OppdaterArealplan);
            AddSkjemanavnTilDictionary(ResultatMottat);
            AddSkjemanavnTilDictionary(RegistrerDispensasjonFraPlan);
            AddSkjemanavnTilDictionary(OppdaterDispensasjon);
        }

        private static void AddSkjemanavnTilDictionary(string meldingstype)
        {
            Skjemanavn.Add(meldingstype, $"{meldingstype}.schema.json");
        }

    }
}
