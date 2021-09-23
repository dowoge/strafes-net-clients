using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// If a new time is made it will retain the previous time&#39;s id.
  /// </summary>
  [DataContract]
  public class Time {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets _Time
    /// </summary>
    [DataMember(Name="Time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Time")]
    public int? _Time { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="User", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "User")]
    public int? User { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="Map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Map")]
    public int? Map { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public int? Date { get; set; }

    /// <summary>
    /// Gets or Sets Style
    /// </summary>
    [DataMember(Name="Style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Style")]
    public int? Style { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="Mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Mode")]
    public int? Mode { get; set; }

    /// <summary>
    /// Gets or Sets Game
    /// </summary>
    [DataMember(Name="Game", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Game")]
    public int? Game { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Time {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  _Time: ").Append(_Time).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Style: ").Append(Style).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Game: ").Append(Game).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
