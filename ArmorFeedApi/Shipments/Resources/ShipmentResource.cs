using ArmorFeedApi.Customers.Domain.Models;
using ArmorFeedApi.Customers.Resource;
using ArmorFeedApi.Enterprises.Resources;
using ArmorFeedApi.Shipments.Domain.Models;

namespace ArmorFeedApi.Shipments.Resources;

public class ShipmentResource
{
    public int Id { get; set; }
    public string PickUpDate { get; set; }
    public string DeliveryDate { get; set; }
    public string Status { get; set; }
    public string Origin { get; set; }
    public string OriginTypeAddress { get; set; }
    public string OriginAddress { get; set; }
    public string OriginUrbanization { get; set; }
    public string OriginReference { get; set; }
    public string Destiny { get; set; }
    public string DestinyTypeAddress { get; set; }
    public string DestinyAddress { get; set; }
    public string DestinyUrbanization { get; set; }
    public string DestinyReference { get; set; }
    public EnterpriseResource Enterprise;
    public CustomerResource Customer;
}