using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 取得指定資料
        /// </summary>
        /// <param name="id">唯一識別號</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="value">資料</param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="id">唯一識別號</param>
        /// <param name="value">資料</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">唯一識別號</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
