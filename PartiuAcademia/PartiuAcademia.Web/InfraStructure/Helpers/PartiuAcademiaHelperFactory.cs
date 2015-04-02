using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartiuAcademia.Web.InfraStructure.Helpers
{
    public static class PartiuAcademiaHelperFactory
    {
        public static PartiuAcademiaHelpers Academia(this HtmlHelper helper)
        {
            return new PartiuAcademiaHelpers(helper);
        }
    }
}