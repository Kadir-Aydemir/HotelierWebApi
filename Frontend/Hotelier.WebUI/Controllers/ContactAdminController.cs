using Hotelier.WebUI.Dtos.ContactDto;
using Hotelier.WebUI.Dtos.RoomDto;
using Hotelier.WebUI.Dtos.SendMessageDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotelier.WebUI.Controllers
{
    public class ContactAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5270/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5270/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendboxDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> InboxMessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5270/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> SendboxMessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5270/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageBySendIdDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessageDto model)
        {
            model.SenderMail = "admin@gmail.com";
            model.SenderName = "admin";
            model.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5270/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }


        public PartialViewResult SideBarContactAdminPartial()
        {
            return PartialView();
        }

        public PartialViewResult SideBarContactAdminCategoryPartial()
        {
            return PartialView();
        }
    }
}
