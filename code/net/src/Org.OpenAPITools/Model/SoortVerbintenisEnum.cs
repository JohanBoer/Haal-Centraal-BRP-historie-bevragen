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
    /// Soort verbintenis die bij de burgerlijke stand is ingeschreven * &#x60;huwelijk&#x60; - H * &#x60;geregistreerd_partnerschap&#x60; - P 
    /// </summary>
    /// <value>Soort verbintenis die bij de burgerlijke stand is ingeschreven * &#x60;huwelijk&#x60; - H * &#x60;geregistreerd_partnerschap&#x60; - P </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SoortVerbintenisEnum
    {
        /// <summary>
        /// Enum Huwelijk for value: huwelijk
        /// </summary>
        [EnumMember(Value = "huwelijk")]
        Huwelijk = 1,

        /// <summary>
        /// Enum Geregistreerdpartnerschap for value: geregistreerd_partnerschap
        /// </summary>
        [EnumMember(Value = "geregistreerd_partnerschap")]
        Geregistreerdpartnerschap = 2

    }

}
