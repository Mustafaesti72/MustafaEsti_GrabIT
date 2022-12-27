namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }

    /*
    public int Id { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string Language { get; set; }
    public string Culture { get; set; }
    public string Password { get; set; }
    */
    [JsonIgnore]
    public string PasswordHash { get; set; }
}