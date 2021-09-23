using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Map {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="Creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Creator")]
    public string Creator { get; set; }

    /// <summary>
    /// Gets or Sets Game
    /// </summary>
    [DataMember(Name="Game", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Game")]
    public int? Game { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public int? Date { get; set; }

    /// <summary>
    /// Gets or Sets PlayCount
    /// </summary>
    [DataMember(Name="PlayCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlayCount")]
    public int? PlayCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Map {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  Game: ").Append(Game).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  PlayCount: ").Append(PlayCount).Append("\n");
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
