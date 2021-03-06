/* 
 * BRP historie bevragen
 *
 * API voor het zoeken en raadplegen van historische verblijfplaatsen, partners, nationaliteiten en verblijfstitels uit de BRP (inclusief de RNI).  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-historie-bevragen/tree/v1.0.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 0.0.1 (develop)
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Verblijfplaatshistorie
    /// </summary>
    [DataContract]
    public partial class Verblijfplaatshistorie :  IEquatable<Verblijfplaatshistorie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Verblijfplaatshistorie" /> class.
        /// </summary>
        /// <param name="straat">Een naam die door de gemeente aan een openbare ruimte is gegeven..</param>
        /// <param name="huisnummer">Een nummer dat door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisletter">Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisnummertoevoeging">Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="postcode">De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort..</param>
        /// <param name="woonplaats">Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam..</param>
        /// <param name="adresseerbaarObjectIdentificatie">De verblijfplaats van de persoon kan een ligplaats, een standplaats of een verblijfsobject zijn. .</param>
        /// <param name="aanduidingBijHuisnummer">aanduidingBijHuisnummer.</param>
        /// <param name="nummeraanduidingIdentificatie">Unieke identificatie van een nummeraanduiding (en het bijbehorende adres) in de BAG. .</param>
        /// <param name="functieAdres">functieAdres.</param>
        /// <param name="indicatieVestigingVanuitBuitenland">Geeft aan dat de ingeschreven persoon zich vanuit het buitenland heeft ingeschreven. .</param>
        /// <param name="locatiebeschrijving">Omschrijving van de ligging van een verblijfsobject, standplaats of ligplaats. .</param>
        /// <param name="korteNaam">De officiële openbareruimtenaam uit de Basisregistratie Gebouwen en Adressen (BAG) of een verkorte versie. .</param>
        /// <param name="vanuitVertrokkenOnbekendWaarheen">Geeft aan dat de persoon is teruggekeerd uit een situatie van &#39;vertrokken onbekend waarheen.&#39; .</param>
        /// <param name="datumAanvangAdreshouding">datumAanvangAdreshouding.</param>
        /// <param name="datumIngangGeldigheid">datumIngangGeldigheid.</param>
        /// <param name="datumInschrijvingInGemeente">datumInschrijvingInGemeente.</param>
        /// <param name="datumVestigingInNederland">datumVestigingInNederland.</param>
        /// <param name="gemeenteVanInschrijving">gemeenteVanInschrijving.</param>
        /// <param name="landVanwaarIngeschreven">landVanwaarIngeschreven.</param>
        /// <param name="adresregel1">Het eerste deel van een adres is een combinatie van de straat en huisnummer. .</param>
        /// <param name="adresregel2">Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. .</param>
        /// <param name="adresregel3">Het derde deel van een adres is optioneel. Het gaat om een of meer geografische gebieden van het adres in het buitenland. .</param>
        /// <param name="vertrokkenOnbekendWaarheen">Indicatie dat de ingeschreven persoon is vertrokken naar het buitenland, maar dat niet bekend is waar naar toe. .</param>
        /// <param name="land">land.</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        /// <param name="datumTot">datumTot.</param>
        /// <param name="geheimhoudingPersoonsgegevens">Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. .</param>
        public Verblijfplaatshistorie(string straat = default(string), int huisnummer = default(int), string huisletter = default(string), string huisnummertoevoeging = default(string), string postcode = default(string), string woonplaats = default(string), string adresseerbaarObjectIdentificatie = default(string), AanduidingBijHuisnummerEnum aanduidingBijHuisnummer = default(AanduidingBijHuisnummerEnum), string nummeraanduidingIdentificatie = default(string), SoortAdresEnum functieAdres = default(SoortAdresEnum), bool indicatieVestigingVanuitBuitenland = default(bool), string locatiebeschrijving = default(string), string korteNaam = default(string), bool vanuitVertrokkenOnbekendWaarheen = default(bool), DatumOnvolledig datumAanvangAdreshouding = default(DatumOnvolledig), DatumOnvolledig datumIngangGeldigheid = default(DatumOnvolledig), DatumOnvolledig datumInschrijvingInGemeente = default(DatumOnvolledig), DatumOnvolledig datumVestigingInNederland = default(DatumOnvolledig), Waardetabel gemeenteVanInschrijving = default(Waardetabel), Waardetabel landVanwaarIngeschreven = default(Waardetabel), string adresregel1 = default(string), string adresregel2 = default(string), string adresregel3 = default(string), bool vertrokkenOnbekendWaarheen = default(bool), Waardetabel land = default(Waardetabel), VerblijfplaatsInOnderzoek inOnderzoek = default(VerblijfplaatsInOnderzoek), DatumOnvolledig datumTot = default(DatumOnvolledig), bool geheimhoudingPersoonsgegevens = default(bool))
        {
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisletter = huisletter;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
            this.AdresseerbaarObjectIdentificatie = adresseerbaarObjectIdentificatie;
            this.AanduidingBijHuisnummer = aanduidingBijHuisnummer;
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.FunctieAdres = functieAdres;
            this.IndicatieVestigingVanuitBuitenland = indicatieVestigingVanuitBuitenland;
            this.Locatiebeschrijving = locatiebeschrijving;
            this.KorteNaam = korteNaam;
            this.VanuitVertrokkenOnbekendWaarheen = vanuitVertrokkenOnbekendWaarheen;
            this.DatumAanvangAdreshouding = datumAanvangAdreshouding;
            this.DatumIngangGeldigheid = datumIngangGeldigheid;
            this.DatumInschrijvingInGemeente = datumInschrijvingInGemeente;
            this.DatumVestigingInNederland = datumVestigingInNederland;
            this.GemeenteVanInschrijving = gemeenteVanInschrijving;
            this.LandVanwaarIngeschreven = landVanwaarIngeschreven;
            this.Adresregel1 = adresregel1;
            this.Adresregel2 = adresregel2;
            this.Adresregel3 = adresregel3;
            this.VertrokkenOnbekendWaarheen = vertrokkenOnbekendWaarheen;
            this.Land = land;
            this.InOnderzoek = inOnderzoek;
            this.DatumTot = datumTot;
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
        }
        
        /// <summary>
        /// Een naam die door de gemeente aan een openbare ruimte is gegeven.
        /// </summary>
        /// <value>Een naam die door de gemeente aan een openbare ruimte is gegeven.</value>
        [DataMember(Name="straat", EmitDefaultValue=false)]
        public string Straat { get; set; }

        /// <summary>
        /// Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisnummer", EmitDefaultValue=false)]
        public int Huisnummer { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisletter", EmitDefaultValue=false)]
        public string Huisletter { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisnummertoevoeging", EmitDefaultValue=false)]
        public string Huisnummertoevoeging { get; set; }

        /// <summary>
        /// De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.
        /// </summary>
        /// <value>De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.
        /// </summary>
        /// <value>Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.</value>
        [DataMember(Name="woonplaats", EmitDefaultValue=false)]
        public string Woonplaats { get; set; }

        /// <summary>
        /// De verblijfplaats van de persoon kan een ligplaats, een standplaats of een verblijfsobject zijn. 
        /// </summary>
        /// <value>De verblijfplaats van de persoon kan een ligplaats, een standplaats of een verblijfsobject zijn. </value>
        [DataMember(Name="adresseerbaarObjectIdentificatie", EmitDefaultValue=false)]
        public string AdresseerbaarObjectIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets AanduidingBijHuisnummer
        /// </summary>
        [DataMember(Name="aanduidingBijHuisnummer", EmitDefaultValue=false)]
        public AanduidingBijHuisnummerEnum AanduidingBijHuisnummer { get; set; }

        /// <summary>
        /// Unieke identificatie van een nummeraanduiding (en het bijbehorende adres) in de BAG. 
        /// </summary>
        /// <value>Unieke identificatie van een nummeraanduiding (en het bijbehorende adres) in de BAG. </value>
        [DataMember(Name="nummeraanduidingIdentificatie", EmitDefaultValue=false)]
        public string NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets FunctieAdres
        /// </summary>
        [DataMember(Name="functieAdres", EmitDefaultValue=false)]
        public SoortAdresEnum FunctieAdres { get; set; }

        /// <summary>
        /// Geeft aan dat de ingeschreven persoon zich vanuit het buitenland heeft ingeschreven. 
        /// </summary>
        /// <value>Geeft aan dat de ingeschreven persoon zich vanuit het buitenland heeft ingeschreven. </value>
        [DataMember(Name="indicatieVestigingVanuitBuitenland", EmitDefaultValue=false)]
        public bool IndicatieVestigingVanuitBuitenland { get; set; }

        /// <summary>
        /// Omschrijving van de ligging van een verblijfsobject, standplaats of ligplaats. 
        /// </summary>
        /// <value>Omschrijving van de ligging van een verblijfsobject, standplaats of ligplaats. </value>
        [DataMember(Name="locatiebeschrijving", EmitDefaultValue=false)]
        public string Locatiebeschrijving { get; set; }

        /// <summary>
        /// De officiële openbareruimtenaam uit de Basisregistratie Gebouwen en Adressen (BAG) of een verkorte versie. 
        /// </summary>
        /// <value>De officiële openbareruimtenaam uit de Basisregistratie Gebouwen en Adressen (BAG) of een verkorte versie. </value>
        [DataMember(Name="korteNaam", EmitDefaultValue=false)]
        public string KorteNaam { get; set; }

        /// <summary>
        /// Geeft aan dat de persoon is teruggekeerd uit een situatie van &#39;vertrokken onbekend waarheen.&#39; 
        /// </summary>
        /// <value>Geeft aan dat de persoon is teruggekeerd uit een situatie van &#39;vertrokken onbekend waarheen.&#39; </value>
        [DataMember(Name="vanuitVertrokkenOnbekendWaarheen", EmitDefaultValue=false)]
        public bool VanuitVertrokkenOnbekendWaarheen { get; set; }

        /// <summary>
        /// Gets or Sets DatumAanvangAdreshouding
        /// </summary>
        [DataMember(Name="datumAanvangAdreshouding", EmitDefaultValue=false)]
        public DatumOnvolledig DatumAanvangAdreshouding { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngangGeldigheid
        /// </summary>
        [DataMember(Name="datumIngangGeldigheid", EmitDefaultValue=false)]
        public DatumOnvolledig DatumIngangGeldigheid { get; set; }

        /// <summary>
        /// Gets or Sets DatumInschrijvingInGemeente
        /// </summary>
        [DataMember(Name="datumInschrijvingInGemeente", EmitDefaultValue=false)]
        public DatumOnvolledig DatumInschrijvingInGemeente { get; set; }

        /// <summary>
        /// Gets or Sets DatumVestigingInNederland
        /// </summary>
        [DataMember(Name="datumVestigingInNederland", EmitDefaultValue=false)]
        public DatumOnvolledig DatumVestigingInNederland { get; set; }

        /// <summary>
        /// Gets or Sets GemeenteVanInschrijving
        /// </summary>
        [DataMember(Name="gemeenteVanInschrijving", EmitDefaultValue=false)]
        public Waardetabel GemeenteVanInschrijving { get; set; }

        /// <summary>
        /// Gets or Sets LandVanwaarIngeschreven
        /// </summary>
        [DataMember(Name="landVanwaarIngeschreven", EmitDefaultValue=false)]
        public Waardetabel LandVanwaarIngeschreven { get; set; }

        /// <summary>
        /// Het eerste deel van een adres is een combinatie van de straat en huisnummer. 
        /// </summary>
        /// <value>Het eerste deel van een adres is een combinatie van de straat en huisnummer. </value>
        [DataMember(Name="adresregel1", EmitDefaultValue=false)]
        public string Adresregel1 { get; set; }

        /// <summary>
        /// Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. 
        /// </summary>
        /// <value>Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. </value>
        [DataMember(Name="adresregel2", EmitDefaultValue=false)]
        public string Adresregel2 { get; set; }

        /// <summary>
        /// Het derde deel van een adres is optioneel. Het gaat om een of meer geografische gebieden van het adres in het buitenland. 
        /// </summary>
        /// <value>Het derde deel van een adres is optioneel. Het gaat om een of meer geografische gebieden van het adres in het buitenland. </value>
        [DataMember(Name="adresregel3", EmitDefaultValue=false)]
        public string Adresregel3 { get; set; }

        /// <summary>
        /// Indicatie dat de ingeschreven persoon is vertrokken naar het buitenland, maar dat niet bekend is waar naar toe. 
        /// </summary>
        /// <value>Indicatie dat de ingeschreven persoon is vertrokken naar het buitenland, maar dat niet bekend is waar naar toe. </value>
        [DataMember(Name="vertrokkenOnbekendWaarheen", EmitDefaultValue=false)]
        public bool VertrokkenOnbekendWaarheen { get; set; }

        /// <summary>
        /// Gets or Sets Land
        /// </summary>
        [DataMember(Name="land", EmitDefaultValue=false)]
        public Waardetabel Land { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public VerblijfplaatsInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Gets or Sets DatumTot
        /// </summary>
        [DataMember(Name="datumTot", EmitDefaultValue=false)]
        public DatumOnvolledig DatumTot { get; set; }

        /// <summary>
        /// Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. 
        /// </summary>
        /// <value>Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. </value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Verblijfplaatshistorie {\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
            sb.Append("  AdresseerbaarObjectIdentificatie: ").Append(AdresseerbaarObjectIdentificatie).Append("\n");
            sb.Append("  AanduidingBijHuisnummer: ").Append(AanduidingBijHuisnummer).Append("\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  FunctieAdres: ").Append(FunctieAdres).Append("\n");
            sb.Append("  IndicatieVestigingVanuitBuitenland: ").Append(IndicatieVestigingVanuitBuitenland).Append("\n");
            sb.Append("  Locatiebeschrijving: ").Append(Locatiebeschrijving).Append("\n");
            sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
            sb.Append("  VanuitVertrokkenOnbekendWaarheen: ").Append(VanuitVertrokkenOnbekendWaarheen).Append("\n");
            sb.Append("  DatumAanvangAdreshouding: ").Append(DatumAanvangAdreshouding).Append("\n");
            sb.Append("  DatumIngangGeldigheid: ").Append(DatumIngangGeldigheid).Append("\n");
            sb.Append("  DatumInschrijvingInGemeente: ").Append(DatumInschrijvingInGemeente).Append("\n");
            sb.Append("  DatumVestigingInNederland: ").Append(DatumVestigingInNederland).Append("\n");
            sb.Append("  GemeenteVanInschrijving: ").Append(GemeenteVanInschrijving).Append("\n");
            sb.Append("  LandVanwaarIngeschreven: ").Append(LandVanwaarIngeschreven).Append("\n");
            sb.Append("  Adresregel1: ").Append(Adresregel1).Append("\n");
            sb.Append("  Adresregel2: ").Append(Adresregel2).Append("\n");
            sb.Append("  Adresregel3: ").Append(Adresregel3).Append("\n");
            sb.Append("  VertrokkenOnbekendWaarheen: ").Append(VertrokkenOnbekendWaarheen).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
            sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
            sb.Append("  DatumTot: ").Append(DatumTot).Append("\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Verblijfplaatshistorie);
        }

        /// <summary>
        /// Returns true if Verblijfplaatshistorie instances are equal
        /// </summary>
        /// <param name="input">Instance of Verblijfplaatshistorie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Verblijfplaatshistorie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    (this.Huisnummer != null &&
                    this.Huisnummer.Equals(input.Huisnummer))
                ) && 
                (
                    this.Huisletter == input.Huisletter ||
                    (this.Huisletter != null &&
                    this.Huisletter.Equals(input.Huisletter))
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    (this.Huisnummertoevoeging != null &&
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    (this.Woonplaats != null &&
                    this.Woonplaats.Equals(input.Woonplaats))
                ) && 
                (
                    this.AdresseerbaarObjectIdentificatie == input.AdresseerbaarObjectIdentificatie ||
                    (this.AdresseerbaarObjectIdentificatie != null &&
                    this.AdresseerbaarObjectIdentificatie.Equals(input.AdresseerbaarObjectIdentificatie))
                ) && 
                (
                    this.AanduidingBijHuisnummer == input.AanduidingBijHuisnummer ||
                    (this.AanduidingBijHuisnummer != null &&
                    this.AanduidingBijHuisnummer.Equals(input.AanduidingBijHuisnummer))
                ) && 
                (
                    this.NummeraanduidingIdentificatie == input.NummeraanduidingIdentificatie ||
                    (this.NummeraanduidingIdentificatie != null &&
                    this.NummeraanduidingIdentificatie.Equals(input.NummeraanduidingIdentificatie))
                ) && 
                (
                    this.FunctieAdres == input.FunctieAdres ||
                    (this.FunctieAdres != null &&
                    this.FunctieAdres.Equals(input.FunctieAdres))
                ) && 
                (
                    this.IndicatieVestigingVanuitBuitenland == input.IndicatieVestigingVanuitBuitenland ||
                    (this.IndicatieVestigingVanuitBuitenland != null &&
                    this.IndicatieVestigingVanuitBuitenland.Equals(input.IndicatieVestigingVanuitBuitenland))
                ) && 
                (
                    this.Locatiebeschrijving == input.Locatiebeschrijving ||
                    (this.Locatiebeschrijving != null &&
                    this.Locatiebeschrijving.Equals(input.Locatiebeschrijving))
                ) && 
                (
                    this.KorteNaam == input.KorteNaam ||
                    (this.KorteNaam != null &&
                    this.KorteNaam.Equals(input.KorteNaam))
                ) && 
                (
                    this.VanuitVertrokkenOnbekendWaarheen == input.VanuitVertrokkenOnbekendWaarheen ||
                    (this.VanuitVertrokkenOnbekendWaarheen != null &&
                    this.VanuitVertrokkenOnbekendWaarheen.Equals(input.VanuitVertrokkenOnbekendWaarheen))
                ) && 
                (
                    this.DatumAanvangAdreshouding == input.DatumAanvangAdreshouding ||
                    (this.DatumAanvangAdreshouding != null &&
                    this.DatumAanvangAdreshouding.Equals(input.DatumAanvangAdreshouding))
                ) && 
                (
                    this.DatumIngangGeldigheid == input.DatumIngangGeldigheid ||
                    (this.DatumIngangGeldigheid != null &&
                    this.DatumIngangGeldigheid.Equals(input.DatumIngangGeldigheid))
                ) && 
                (
                    this.DatumInschrijvingInGemeente == input.DatumInschrijvingInGemeente ||
                    (this.DatumInschrijvingInGemeente != null &&
                    this.DatumInschrijvingInGemeente.Equals(input.DatumInschrijvingInGemeente))
                ) && 
                (
                    this.DatumVestigingInNederland == input.DatumVestigingInNederland ||
                    (this.DatumVestigingInNederland != null &&
                    this.DatumVestigingInNederland.Equals(input.DatumVestigingInNederland))
                ) && 
                (
                    this.GemeenteVanInschrijving == input.GemeenteVanInschrijving ||
                    (this.GemeenteVanInschrijving != null &&
                    this.GemeenteVanInschrijving.Equals(input.GemeenteVanInschrijving))
                ) && 
                (
                    this.LandVanwaarIngeschreven == input.LandVanwaarIngeschreven ||
                    (this.LandVanwaarIngeschreven != null &&
                    this.LandVanwaarIngeschreven.Equals(input.LandVanwaarIngeschreven))
                ) && 
                (
                    this.Adresregel1 == input.Adresregel1 ||
                    (this.Adresregel1 != null &&
                    this.Adresregel1.Equals(input.Adresregel1))
                ) && 
                (
                    this.Adresregel2 == input.Adresregel2 ||
                    (this.Adresregel2 != null &&
                    this.Adresregel2.Equals(input.Adresregel2))
                ) && 
                (
                    this.Adresregel3 == input.Adresregel3 ||
                    (this.Adresregel3 != null &&
                    this.Adresregel3.Equals(input.Adresregel3))
                ) && 
                (
                    this.VertrokkenOnbekendWaarheen == input.VertrokkenOnbekendWaarheen ||
                    (this.VertrokkenOnbekendWaarheen != null &&
                    this.VertrokkenOnbekendWaarheen.Equals(input.VertrokkenOnbekendWaarheen))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
                ) && 
                (
                    this.InOnderzoek == input.InOnderzoek ||
                    (this.InOnderzoek != null &&
                    this.InOnderzoek.Equals(input.InOnderzoek))
                ) && 
                (
                    this.DatumTot == input.DatumTot ||
                    (this.DatumTot != null &&
                    this.DatumTot.Equals(input.DatumTot))
                ) && 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    (this.GeheimhoudingPersoonsgegevens != null &&
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Straat != null)
                    hashCode = hashCode * 59 + this.Straat.GetHashCode();
                if (this.Huisnummer != null)
                    hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                if (this.Huisletter != null)
                    hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                    hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Woonplaats != null)
                    hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
                if (this.AdresseerbaarObjectIdentificatie != null)
                    hashCode = hashCode * 59 + this.AdresseerbaarObjectIdentificatie.GetHashCode();
                if (this.AanduidingBijHuisnummer != null)
                    hashCode = hashCode * 59 + this.AanduidingBijHuisnummer.GetHashCode();
                if (this.NummeraanduidingIdentificatie != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
                if (this.FunctieAdres != null)
                    hashCode = hashCode * 59 + this.FunctieAdres.GetHashCode();
                if (this.IndicatieVestigingVanuitBuitenland != null)
                    hashCode = hashCode * 59 + this.IndicatieVestigingVanuitBuitenland.GetHashCode();
                if (this.Locatiebeschrijving != null)
                    hashCode = hashCode * 59 + this.Locatiebeschrijving.GetHashCode();
                if (this.KorteNaam != null)
                    hashCode = hashCode * 59 + this.KorteNaam.GetHashCode();
                if (this.VanuitVertrokkenOnbekendWaarheen != null)
                    hashCode = hashCode * 59 + this.VanuitVertrokkenOnbekendWaarheen.GetHashCode();
                if (this.DatumAanvangAdreshouding != null)
                    hashCode = hashCode * 59 + this.DatumAanvangAdreshouding.GetHashCode();
                if (this.DatumIngangGeldigheid != null)
                    hashCode = hashCode * 59 + this.DatumIngangGeldigheid.GetHashCode();
                if (this.DatumInschrijvingInGemeente != null)
                    hashCode = hashCode * 59 + this.DatumInschrijvingInGemeente.GetHashCode();
                if (this.DatumVestigingInNederland != null)
                    hashCode = hashCode * 59 + this.DatumVestigingInNederland.GetHashCode();
                if (this.GemeenteVanInschrijving != null)
                    hashCode = hashCode * 59 + this.GemeenteVanInschrijving.GetHashCode();
                if (this.LandVanwaarIngeschreven != null)
                    hashCode = hashCode * 59 + this.LandVanwaarIngeschreven.GetHashCode();
                if (this.Adresregel1 != null)
                    hashCode = hashCode * 59 + this.Adresregel1.GetHashCode();
                if (this.Adresregel2 != null)
                    hashCode = hashCode * 59 + this.Adresregel2.GetHashCode();
                if (this.Adresregel3 != null)
                    hashCode = hashCode * 59 + this.Adresregel3.GetHashCode();
                if (this.VertrokkenOnbekendWaarheen != null)
                    hashCode = hashCode * 59 + this.VertrokkenOnbekendWaarheen.GetHashCode();
                if (this.Land != null)
                    hashCode = hashCode * 59 + this.Land.GetHashCode();
                if (this.InOnderzoek != null)
                    hashCode = hashCode * 59 + this.InOnderzoek.GetHashCode();
                if (this.DatumTot != null)
                    hashCode = hashCode * 59 + this.DatumTot.GetHashCode();
                if (this.GeheimhoudingPersoonsgegevens != null)
                    hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
