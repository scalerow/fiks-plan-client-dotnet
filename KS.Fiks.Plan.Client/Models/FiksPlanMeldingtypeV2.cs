namespace KS.Fiks.Plan.Client.Models
{
    public static class FiksPlanMeldingtypeV2
    {
        /*
         * Er .innsyn, og .oppdatering nødvendig som del av meldingstype navn? Det står jo hva den gjør til slutt. 
         */
        
        //Finn meldingstyper m/svar
        public const string FinnDispensasjoner = "no.ks.fiks.plan.v2.dispensasjoner.finn"; //"no.ks.fiks.gi.plan.innsyn.finndispensasjoner.v2" Slik det var definert i RequestMessageTypes.resx i validator
        //TODO
        /*
         * Putt inn resterende her med korrigert navn.
         * Se forslag over her. Tatt bort .gi og .innsyn, flyttet .v2 fram etter .plan og skilt objekt og handling. 
         */
        
        
        //Hent meldingstyper m/svar
        public const string HentAktoerer = "no.ks.fiks.plan.v2.aktoerer.hent";
        public const string ResultatAktoerer = "no.ks.fiks.plan.v2.aktoerer.hent.resultat"; // Er dette et bedre navn enn "no.ks.fiks.gi.plan.innsyn.aktører.v2"? Jeg antar dette er kun resultatet for hent meldingen? Det er ikke lett å se slik det er definert nå. 
        //TODO
        /*
         * Putt inn resterende her med korrigert navn.
         * Se forslag over her. Tatt bort .gi og .innsyn, flyttet .v2 fram etter .plan og skilt objekt og handling. 
         */
        
        //Oppdater meldingstyper m/svar
        public const string OppdaterArealplan = "no.ks.fiks.plan.v2.arealplan.oppdater";
        //TODO
        /*
        * Putt inn resterende her med korrigert navn.
        * Se forslag over her. Tatt bort .gi og .innsyn, flyttet .v2 fram etter .plan og skilt objekt og handling. 
        */
        
        // Mottatt og kvitteringsmeldingstype
    }
    
}