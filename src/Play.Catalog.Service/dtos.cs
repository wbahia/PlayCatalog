using System;
using System.ComponentModel.DataAnnotations;
namespace Play.Catalog.Service.dtos
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreadtedDate);
    public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);


}