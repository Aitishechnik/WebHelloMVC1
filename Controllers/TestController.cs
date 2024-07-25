using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WebHelloMVC1.Filters;
using WebHelloMVC1.Models;
namespace WebHelloMVC1.Controllers
{
    [Controller]
    [MyActionFilter]
    public class TestController : Controller
    {
        private List<string> _strings = [];
        public TestController() { foreach (var name in Names.AllNames) _strings.Add(name); }
        private Task<List<string>> GetNameList()
        {
            return Task.FromResult(_strings);
        }

        [HttpGet]
        [ActionName("AllNames")]
        public async Task<IActionResult> GetNames()
        {
            var result = await GetNameList();
            if (result != null || result?.Count != 0)
                return Ok(result);
            else return BadRequest("Name list was not found");
        }

        [HttpPost]
        [ActionName("AddNames")]
        public async Task<IActionResult> AddName(List<string> names)
        {
            var result = await GetNameList();
            if (names != null || result != null || result?.Count != 0)
            {
                result?.AddRange(names);
                Names.AllNames.AddRange(names);
                return Ok(result);
            }
            return BadRequest($"Not able to add {names} to list");
        }

        [HttpDelete]
        [ActionName("RemoveName")]
        public async Task<IActionResult> DeleteName(string name)
        {
            var result = await GetNameList();
            if (!string.IsNullOrEmpty(name) || result != null || result?.Count != 0)
            {
                if (result.Contains(name))
                {
                    result.Remove(name);
                    Names.AllNames.Remove(name);
                    return Ok(result);
                }
            }
            return BadRequest($"{name} was not found in the list");
        }
    }
}
