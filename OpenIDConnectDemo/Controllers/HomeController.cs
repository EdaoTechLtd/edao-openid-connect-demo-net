using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenIDConnectDemo.Models;

namespace OpenIDConnectDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            CustomizeConfig config = new CustomizeConfig();
            OpenIDConnectSDK.Oauth2 oauth2 = new OpenIDConnectSDK.Oauth2();
            String uri = oauth2.Connect(config);
            return Redirect(uri);
        }

        [HttpGet]
        public ActionResult CallBack()
        {
            String code = Request.Params["code"];
            String randon = Request.Params["random"];
            if (code != null && randon != null)
            {
                CustomizeConfig config = new CustomizeConfig();
                OpenIDConnectSDK.Oauth2 oauth2 = new OpenIDConnectSDK.Oauth2();
                oauth2.GetUserInfo(code, randon, config);

                if (oauth2.userInfo == null)
                {
                    ViewData["error"] = oauth2.errorInfo["error"];
                    ViewData["error_description"] = oauth2.errorInfo["error_description"];
                }
                else
                {
                    ViewData["openid"] = oauth2.userInfo["openid"];
                }
            }

            return View("~/Views/home/index.aspx");
        }

    }
}
