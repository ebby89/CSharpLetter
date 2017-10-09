using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Adam");
      myLetterVariable.SetVacation("Thailand");
      myLetterVariable.SetSouvenir("Coconut Bikini");
      return View(myLetterVariable);
    }
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
  }
}