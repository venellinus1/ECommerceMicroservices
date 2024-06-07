
using Basket.API.Basket.Data;

namespace Basket.API.Basket.GetBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;
public record GetBasketResult(ShoppingCart Cart);
public class GetBaskeQuerytHandler(IBasketRepository repository)
    : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        //todo get basket from database
        var basket = await repository.GetBasket(query.UserName);
        return new GetBasketResult(basket);
    }
}
