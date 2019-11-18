using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GetImageHandler
{
    /// <summary>
    /// Summary description for Handler
    /// </summary>
    public class Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.ContentType = "image/jpeg";
            string rootDir = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            string imagePath = Path.Combine(rootDir, @"images\biology\biology-2.jpg");
            
            byte[] byteArray = File.ReadAllBytes(imagePath);
            context.Response.BinaryWrite(byteArray);

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}