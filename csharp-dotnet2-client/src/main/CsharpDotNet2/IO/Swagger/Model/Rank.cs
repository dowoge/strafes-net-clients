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
  public class Rank {
    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="User", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "User")]
    public int? User { get; set; }

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
    /// Gets or Sets _Rank
    /// </summary>
    [DataMember(Name="Rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rank")]
    public decimal? _Rank { get; set; }

    /// <summary>
    /// Gets or Sets Skill
    /// </summary>
    [DataMember(Name="Skill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Skill")]
    public decimal? Skill { get; set; }

    /// <summary>
    /// Gets or Sets Placement
    /// </summary>
    [DataMember(Name="Placement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Placement")]
    public int? Placement { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Rank {\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Style: ").Append(Style).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Game: ").Append(Game).Append("\n");
      sb.Append("  _Rank: ").Append(_Rank).Append("\n");
      sb.Append("  Skill: ").Append(Skill).Append("\n");
      sb.Append("  Placement: ").Append(Placement).Append("\n");
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
