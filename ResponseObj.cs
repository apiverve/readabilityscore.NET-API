using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// TextCounts data
    /// </summary>
    public class TextCounts
    {
        [JsonProperty("syllableCount")]
        public int SyllableCount { get; set; }

        [JsonProperty("lexiconCount")]
        public int LexiconCount { get; set; }

        [JsonProperty("sentenceCount")]
        public int SentenceCount { get; set; }

    }
    /// <summary>
    /// Readability data
    /// </summary>
    public class Readability
    {
        [JsonProperty("fleschReadingEase")]
        public double FleschReadingEase { get; set; }

        [JsonProperty("fleschKincaidGrade")]
        public double FleschKincaidGrade { get; set; }

        [JsonProperty("gunningFog")]
        public double GunningFog { get; set; }

        [JsonProperty("colemanLiauIndex")]
        public double ColemanLiauIndex { get; set; }

        [JsonProperty("smogIndex")]
        public double SmogIndex { get; set; }

        [JsonProperty("automatedReadabilityIndex")]
        public double AutomatedReadabilityIndex { get; set; }

        [JsonProperty("daleChallReadabilityScore")]
        public int DaleChallReadabilityScore { get; set; }

    }
    /// <summary>
    /// ReadabilityText data
    /// </summary>
    public class ReadabilityText
    {
        [JsonProperty("fleschReadingEase")]
        public string FleschReadingEase { get; set; }

        [JsonProperty("daleChallReadabilityScore")]
        public string DaleChallReadabilityScore { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("textCounts")]
        public TextCounts TextCounts { get; set; }

        [JsonProperty("readability")]
        public Readability Readability { get; set; }

        [JsonProperty("readabilityText")]
        public ReadabilityText ReadabilityText { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
