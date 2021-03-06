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

/**
 * If a new time is made it will retain the previous time&#39;s id.
 */
@ApiModel(description = "If a new time is made it will retain the previous time's id.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2021-09-23T01:26:26.652Z")
public class Time {
  @SerializedName("ID")
  private Integer ID = null;

  @SerializedName("Time")
  private Integer time = null;

  @SerializedName("User")
  private Integer user = null;

  @SerializedName("Map")
  private Integer map = null;

  @SerializedName("Date")
  private Integer date = null;

  @SerializedName("Style")
  private Integer style = null;

  @SerializedName("Mode")
  private Integer mode = null;

  @SerializedName("Game")
  private Integer game = null;

  public Time ID(Integer ID) {
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

  public Time time(Integer time) {
    this.time = time;
    return this;
  }

   /**
   * Get time
   * @return time
  **/
  @ApiModelProperty(value = "")
  public Integer getTime() {
    return time;
  }

  public void setTime(Integer time) {
    this.time = time;
  }

  public Time user(Integer user) {
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

  public Time map(Integer map) {
    this.map = map;
    return this;
  }

   /**
   * Get map
   * @return map
  **/
  @ApiModelProperty(value = "")
  public Integer getMap() {
    return map;
  }

  public void setMap(Integer map) {
    this.map = map;
  }

  public Time date(Integer date) {
    this.date = date;
    return this;
  }

   /**
   * Get date
   * @return date
  **/
  @ApiModelProperty(value = "")
  public Integer getDate() {
    return date;
  }

  public void setDate(Integer date) {
    this.date = date;
  }

  public Time style(Integer style) {
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

  public Time mode(Integer mode) {
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

  public Time game(Integer game) {
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


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Time time = (Time) o;
    return Objects.equals(this.ID, time.ID) &&
        Objects.equals(this.time, time.time) &&
        Objects.equals(this.user, time.user) &&
        Objects.equals(this.map, time.map) &&
        Objects.equals(this.date, time.date) &&
        Objects.equals(this.style, time.style) &&
        Objects.equals(this.mode, time.mode) &&
        Objects.equals(this.game, time.game);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ID, time, user, map, date, style, mode, game);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Time {\n");
    
    sb.append("    ID: ").append(toIndentedString(ID)).append("\n");
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    user: ").append(toIndentedString(user)).append("\n");
    sb.append("    map: ").append(toIndentedString(map)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    style: ").append(toIndentedString(style)).append("\n");
    sb.append("    mode: ").append(toIndentedString(mode)).append("\n");
    sb.append("    game: ").append(toIndentedString(game)).append("\n");
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

