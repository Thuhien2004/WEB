using System;
using System.Web;
using Love; // DLL từ Project 1

namespace LoveWeb
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string startDateStr = Request.Form["startDate"];
            DateTime startDate;
            string json = "{ \"message\": \"Ngày không hợp lệ!\" }";

            if (DateTime.TryParse(startDateStr, out startDate))
            {
                LoveCalculator calc = new LoveCalculator();
                calc.StartDate = startDate;
                calc.Calculate();
                // JSON tạo thủ công để tránh .NET 2.0 không có JavaScriptSerializer
                json = "{ \"message\": \"" + calc.Message.Replace("\"", "\\\"") + "\" }";
            }

            Response.ContentType = "application/json";
            Response.Write(json);
            Response.End();
        }
    }
}
