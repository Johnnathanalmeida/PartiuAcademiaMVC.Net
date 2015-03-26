using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.InfraStructure.CustomActionResult
{
    public class RedirectResultWithStatus : ActionResult
    {
        private string url;

        private int status;

        public RedirectResultWithStatus(string urlParam, int statusParam)
        {
            url = urlParam;
            status = statusParam;
        }
        
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.StatusCode = status;
            response.RedirectLocation = url;
            response.End();
        }
    }
}