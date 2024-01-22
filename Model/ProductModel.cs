using System.ComponentModel.DataAnnotations;
namespace UpdateWebapi.Model{
public class VehicleModel{
    [Key]
    public int VehicleID{get;set;} 
    [Required]
    public string? VehicleType{get;set;}
    [Required]
     public string? VehicleName{get;set;}
     [Required]
      public int? VehicleNumber{get;set;}
     [Required]
    public string? OwnerName{get;set;}

}
}
