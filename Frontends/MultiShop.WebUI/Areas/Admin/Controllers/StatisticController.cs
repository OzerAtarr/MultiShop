using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CommentServices;
using MultiShop.WebUI.Services.StatisticServices.CatalogStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.DiscountStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.MessageStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.UserStatisticServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly ICatalogStatisticService _catalogStatisticService;
        private readonly IUserStatisticService _userStatisticService;
        private readonly IMessageStatisticService _messageStatisticService;
        private readonly IDiscountStatisticService _discountStatisticService;
        private readonly ICommentService _commentService;
        public StatisticController(ICatalogStatisticService catalogStatisticService, IUserStatisticService userStatisticService, IMessageStatisticService messageStatisticService, IDiscountStatisticService discountStatisticService, ICommentService commentService)
        {
            _catalogStatisticService = catalogStatisticService;
            _userStatisticService = userStatisticService;
            _messageStatisticService = messageStatisticService;
            _discountStatisticService = discountStatisticService;
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            var getBrandCount = await _catalogStatisticService.GetBrandCount();
            var getProductCount = await _catalogStatisticService.GetProductCount();
            var getCategoryCount = await _catalogStatisticService.GetCategoryCount();
            var getMaxPriceProductName = await _catalogStatisticService.GetMaxPriceProductName();
            var getMinPriceProductName = await _catalogStatisticService.GetMinPriceProductName();

            var getUserCount = await _userStatisticService.GetUsercount();

            var getTotalCommentCount = await _commentService.GetTotalCommentCount();
            var getActiveCommentCount = await _commentService.GetActiveCommentCount();
            var getPassiveCommentCount = await _commentService.GetPAssiveCommentCount();

            var getDiscountCouponCount = await _discountStatisticService.GetDiscountCouponCount();

            var getMessageTotalCount = await _messageStatisticService.GetTotalMessageCount();

            ViewBag.getBrandCount = getBrandCount;
            ViewBag.getProductCount = getProductCount;
            ViewBag.getCategoryCount = getCategoryCount;
            ViewBag.getMaxPriceProductName = getMaxPriceProductName;
            ViewBag.getMinPriceProductName = getMinPriceProductName;

            ViewBag.getUserCount = getUserCount;

            ViewBag.getTotalCommentCount = getTotalCommentCount;
            ViewBag.getActiveCommentCount = getActiveCommentCount;
            ViewBag.getPassiveCommentCount = getPassiveCommentCount;

            ViewBag.getDiscountCouponCount = getDiscountCouponCount;

            ViewBag.getMessageTotalCount = getMessageTotalCount;

            return View();
        }
    }
}
