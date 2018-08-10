using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;

namespace redisTryout.Pages
{
    public class CachingDemoModel : PageModel
    {
        private IDistributedCache _cache;

        public string PageLoadTime { get; private set; }
        public string PreviousPageLoadTime { get; private set; }

        public CachingDemoModel(IDistributedCache cache)
        {
            _cache = cache;
        }

        public void OnGet()
        {
            string time = DateTime.Now.ToString();
            PageLoadTime = time;
            byte[] previous = _cache.Get("n");
            PreviousPageLoadTime = previous == null? 
                "This is the first time!" : Encoding.UTF8.GetString(previous);

            _cache.Set("n", Encoding.UTF8.GetBytes(time));
        }
    }
}
