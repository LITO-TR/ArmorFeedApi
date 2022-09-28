using System.ComponentModel.DataAnnotations;

namespace ArmorFeedApi.Shipments.Resources;

public class SaveShipmentResource
{
    [Required]
    public string Origin { get; set; }
    
    [Required]
    public string OriginTypeAddress { get; set; }
    
    [Required]
    public string OriginAddress { get; set; }
    
    [Required]
    public string OriginUrbanization { get; set; }
    
    [Required]
    public string OriginReference { get; set; }
    
    [Required]
    public string Destiny { get; set; }
    
    [Required]
    public string DestinyTypeAddress { get; set; }
    
    [Required]
    public string DestinyAddress { get; set; }
    
    [Required]
    public string DestinyUrbanization { get; set; }
    
    [Required]
    public string DestinyReference { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime PickUpDate { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DeliveryDate { get; set; }
    
    [Required]
    public int Status { get; set; }
    
    [Required]
    public int EnterpriseId { get; set; }
    
    [Required]
    public int CustomerId { get; set; }
}