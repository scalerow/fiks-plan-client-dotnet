using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Fiks.Plan.Client.Models
{
    public class FiksPlanMeldingtypeV2
    {
        // Forespørsler-innsyn
        public const string FinnPlanerForMatrikkelenhet = "no.ks.fiks.gi.plan.v2.innsyn.planerformatrikkelenhet.finn";
        public const string FinnPlaner = "no.ks.fiks.gi.plan.v2.innsyn.planer.finn";
        public const string FinnDispensasjoner = "no.ks.fiks.gi.plan.v2.innsyn.dispensasjoner.finn";
        public const string FinnPlanbehandlinger = "no.ks.fiks.gi.plan.v2.innsyn.planbehandlinger.finn";
        public const string HentArealplan = "no.ks.fiks.gi.plan.v2.innsyn.arealplan.hent";
        public const string HentGjeldendePlanbestemmelser = "no.ks.fiks.gi.plan.v2.innsyn.gjeldendeplanbestemmelser.hent";
        public const string HentAktoerer = "no.ks.fiks.gi.plan.v2.innsyn.aktoerer.hent";
        public const string HentRelatertePlaner = "no.ks.fiks.gi.plan.v2.innsyn.relaterteplaner.hent";
        public const string HentKodeliste = "no.ks.fiks.gi.plan.v2.innsyn.kodeliste.hent";
        public const string FinnPlandokumenter = "no.ks.fiks.gi.plan.v2.innsyn.plandokumenter.finn";
        public const string HentPlanfil = "no.ks.fiks.gi.plan.v2.innsyn.planfil.hent";
        public const string FinnPlanerForOmraade = "no.ks.fiks.gi.plan.v2.innsyn.planerforomraade.finn";
        public const string HentBboxForPlan = "no.ks.fiks.gi.plan.v2.innsyn.bboxforplan.hent";
        public const string HentPlanomraader = "no.ks.fiks.gi.plan.v2.innsyn.planomraader.hent";

        // Resultat på forespørsler-innsyn
        public const string ResultatFinnPlanerForMatrikkelenhet = "no.ks.fiks.gi.plan.v2.innsyn.planerformatrikkelenhet.resultat";
        public const string ResultatFinnPlaner = "no.ks.fiks.gi.plan.v2.innsyn.planer.resultat";
        public const string ResultatFinnDispensasjoner = "no.ks.fiks.gi.plan.v2.innsyn.dispensasjoner.resultat";
        public const string ResultatFinnPlanbehandlinger = "no.ks.fiks.gi.plan.v2.innsyn.planbehandlinger.resultat";
        public const string ResultatHentArealplan = "no.ks.fiks.gi.plan.v2.innsyn.arealplan.resultat";
        public const string ResultatHentGjeldendePlanbestemmelser = "no.ks.fiks.gi.plan.v2.innsyn.gjeldendeplanbestemmelser.resultat";
        public const string ResultatHentAktoerer = "no.ks.fiks.gi.plan.v2.innsyn.aktoerer.resultat";
        public const string ResultatHentRelatertePlaner = "no.ks.fiks.gi.plan.v2.innsyn.relaterteplaner.resultat";
        public const string ResultatHentKodeliste = "no.ks.fiks.gi.plan.v2.innsyn.kodeliste.resultat";
        public const string ResultatFinnPlandokumenter = "no.ks.fiks.gi.plan.v2.innsyn.plandokumenter.resultat";
        public const string ResultatHentPlanfil = "no.ks.fiks.gi.plan.v2.innsyn.planfil.resultat";
        public const string ResultatFinnPlanerForOmraade = "no.ks.fiks.gi.plan.v2.innsyn.planerforomraade.resultat";
        public const string ResultatHentBboxForPlan = "no.ks.fiks.gi.plan.v2.innsyn.bbox.resultat";
        public const string ResultatHentPlanomraader = "no.ks.fiks.gi.plan.v2.innsyn.planomraader.resultat";

        // Forespørsler-oppdatering
        public const string OpprettArealplan = "no.ks.fiks.gi.plan.v2.oppdatering.arealplan.opprett";
        public const string RegistrertPlanavgrensning = "no.ks.fiks.gi.plan.v2.oppdatering.planavgrensning.registrer";
        public const string RegistrerPlanbehandling = "no.ks.fiks.gi.plan.v2.oppdatering.planbehandling.registrer";
        public const string OppdaterArealplan = "no.ks.fiks.gi.plan.v2.oppdatering.arealplan.oppdater";

        // Resultat på forespørsler-oppdatering
        public const string ResultatOpprettArealplan = "no.ks.fiks.gi.plan.v2.oppdatering.meldingomplanident.resultat";
        public const string ResultatMottat = "no.ks.fiks.gi.plan.v2.oppdatering.mottatt";

        // Ebyggesak 
        public const string RegistrerDispensasjonFraPlan = "no.ks.fiks.gi.plan.v2.oppdatering.dispensasjonplan.registrer";
        public const string OppdaterDispensasjon = "no.ks.fiks.gi.plan.v2.oppdatering.dispensasjon.oppdater";

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
