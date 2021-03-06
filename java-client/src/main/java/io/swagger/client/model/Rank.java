/*
 * StrafesNET Public API
 * ### How to use To request an api key open a support request in the [issue tracker](https://issues.strafes.net/client/index.php#/types/3/issues).  ### Default API request rate limits are as follows * 100 requests per minute * 3000 requests per hour  ### Game IDs ``` 1 Bhop 2 Surf ``` ### Style IDs ``` 1 Autohop 2 Scroll 3 Sideways 4 Half-Sideways 5 W-Only 6 A-Only 7 Backwards ``` 
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.math.BigDecimal;

/**
 * Rank
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2021-09-23T01:26:26.652Z")
public class Rank {
  @SerializedName("ID")
  private Integer ID = null;

  @SerializedName("User")
  private Integer user = null;

  @SerializedName("Style")
  private Integer style = null;

  @SerializedName("Mode")
  private Integer mode = null;

  @SerializedName("Game")
  private Integer game = null;

  @SerializedName("Rank")
  private BigDecimal rank = null;

  @SerializedName("Skill")
  private BigDecimal skill = null;

  @SerializedName("Placement")
  private Integer placement = null;

  public Rank ID(Integer ID) {
    this.ID = ID;
    return this;
  }

   /**
   * Get ID
   * @return ID
  **/
  @ApiModelProperty(value = "")
  public Integer getID() {
    return ID;
  }

  public void setID(Integer ID) {
    this.ID = ID;
  }

  public Rank user(Integer user) {
    this.user = user;
    return this;
  }

   /**
   * Get user
   * @return user
  **/
  @ApiModelProperty(value = "")
  public Integer getUser() {
    return user;
  }

  public void setUser(Integer user) {
    this.user = user;
  }

  public Rank style(Integer style) {
    this.style = style;
    return this;
  }

   /**
   * Get style
   * @return style
  **/
  @ApiModelProperty(value = "")
  public Integer getStyle() {
    return style;
  }

  public void setStyle(Integer style) {
    this.style = style;
  }

  public Rank mode(Integer mode) {
    this.mode = mode;
    return this;
  }

   /**
   * Get mode
   * @return mode
  **/
  @ApiModelProperty(value = "")
  public Integer getMode() {
    return mode;
  }

  public void setMode(Integer mode) {
    this.mode = mode;
  }

  public Rank game(Integer game) {
    this.game = game;
    return this;
  }

   /**
   * Get game
   * @return game
  **/
  @ApiModelProperty(value = "")
  public Integer getGame() {
    return game;
  }

  public void setGame(Integer game) {
    this.game = game;
  }

  public Rank rank(BigDecimal rank) {
    this.rank = rank;
    return this;
  }

   /**
   * Get rank
   * @return rank
  **/
  @ApiModelProperty(value = "")
  public BigDecimal getRank() {
    return rank;
  }

  public void setRank(BigDecimal rank) {
    this.rank = rank;
  }

  public Rank skill(BigDecimal skill) {
    this.skill = skill;
    return this;
  }

   /**
   * Get skill
   * @return skill
  **/
  @ApiModelProperty(value = "")
  public BigDecimal getSkill() {
    return skill;
  }

  public void setSkill(BigDecimal skill) {
    this.skill = skill;
  }

  public Rank placement(Integer placement) {
    this.placement = placement;
    return this;
  }

   /**
   * Get placement
   * @return placement
  **/
  @ApiModelProperty(value = "")
  public Integer getPlacement() {
    return placement;
  }

  public void setPlacement(Integer placement) {
    this.placement = placement;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Rank rank = (Rank) o;
    return Objects.equals(this.ID, rank.ID) &&
        Objects.equals(this.user, rank.user) &&
        Objects.equals(this.style, rank.style) &&
        Objects.equals(this.mode, rank.mode) &&
        Objects.equals(this.game, rank.game) &&
        Objects.equals(this.rank, rank.rank) &&
        Objects.equals(this.skill, rank.skill) &&
        Objects.equals(this.placement, rank.placement);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ID, user, style, mode, game, rank, skill, placement);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Rank {\n");
    
    sb.append("    ID: ").append(toIndentedString(ID)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    style: ").append(toIndentedString(style)).append("\n");
    sb.append("    mode: ").append(toIndentedString(mode)).append("\n");
    sb.append("    game: ").append(toIndentedString(game)).append("\n");
    sb.append("    rank: ").append(toIndentedString(rank)).append("\n");
    sb.append("    skill: ").append(toIndentedString(skill)).append("\n");
    sb.append("    placement: ").append(toIndentedString(placement)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

