using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class textCounts
{
    [JsonProperty("syllableCount")]
    public int syllableCount { get; set; }

    [JsonProperty("lexiconCount")]
    public int lexiconCount { get; set; }

    [JsonProperty("sentenceCount")]
    public int sentenceCount { get; set; }

}

public class readability
{
    [JsonProperty("fleschReadingEase")]
    public double fleschReadingEase { get; set; }

    [JsonProperty("fleschKincaidGrade")]
    public double fleschKincaidGrade { get; set; }

    [JsonProperty("gunningFog")]
    public double gunningFog { get; set; }

    [JsonProperty("colemanLiauIndex")]
    public double colemanLiauIndex { get; set; }

    [JsonProperty("smogIndex")]
    public int smogIndex { get; set; }

    [JsonProperty("automatedReadabilityIndex")]
    public double automatedReadabilityIndex { get; set; }

    [JsonProperty("daleChallReadabilityScore")]
    public double daleChallReadabilityScore { get; set; }

}

public class readabilityText
{
    [JsonProperty("fleschReadingEase")]
    public string fleschReadingEase { get; set; }

    [JsonProperty("daleChallReadabilityScore")]
    public string daleChallReadabilityScore { get; set; }

}

public class data
{
    [JsonProperty("textCounts")]
    public textCounts textCounts { get; set; }

    [JsonProperty("readability")]
    public readability readability { get; set; }

    [JsonProperty("readabilityText")]
    public readabilityText readabilityText { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
