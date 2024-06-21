namespace Shopping.Web.Pages;

public class CheckoutModel(IBasketService basketService, ILogger<ProductModel> logger)
    : PageModel
{
    [BindProperty]
    public BasketCheckoutModel Order { get; set; } = default!;
    public ShoppingCartModel Cart { get; set; } = default!;
    public async Task<IActionResult> OnGetAsync()
    {
        Cart = await basketService.LoadUserBasket();
        return Page();
    }

    public async Task<IActionResult> OnPostCheckoutAsync()
    {
        logger.LogInformation("Checkout button clicked");
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // customer Id should be passed from the UI authenticated user -atm hardcoded as "swm"
        Order.CustomerId = new Guid("58c49479-ec65-4de2-86e7-033c546291aa");
        Order.UserName = Cart.UserName;
        Order.TotalPrice = Cart.TotalPrice;

        await basketService.CheckoutBasket(new CheckoutBasketRequest(Order));

        return RedirectToPage("Confirmation", "OrderSubmitted");
    }
}
