using AgileFramework.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mo = WebProject.TemplateApi.Site.Models;
using AgileFramework.Business;
using WebProject.TemplateApi.Site.Common;
using AgileFramework.Web;

namespace WebProject.TemplateApi.Site.Controllers.Sys
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("http://www.baidu.com");
        }
        public ActionResult Enter()
        {
            var actionResult = default(AgileJsonResult);

            var inModel = new Mo.SysUser();

            try
            {
                UpdateModel(inModel);

                var url = Config.PDAUrl;

                var method = AgilePDAMethod.Login;

                var parameter = $"username={inModel.UserName}&password={inModel.Password}";

                var entity = AgilePDASoap.Post(url, method, parameter);

                actionResult.Content = AgileJson.ToJson(entity);

                if (entity.Status == "1")
                {
                    Identity.Login(inModel);
                }
            }
            catch
            {

            }

            return actionResult;
        }
    }
}