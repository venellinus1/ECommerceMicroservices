

using Ordering.Domain.Enums;
using Ordering.Application.DTOs;

namespace Ordering.Application.DTOs;

public record OrderDto(
    Guid Id, Guid CustomerId, 
    string OrderName, 
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems);