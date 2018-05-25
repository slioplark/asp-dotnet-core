using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.API.Controllers
{
    /// <summary>
    /// 資料控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> List()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 取得指定資料
        /// </summary>
        /// <param name="id">唯一識別號</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Data(int id)
        {
            return "value";
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="value">資料</param>
        [HttpPost]
        public void Create([FromBody]string value)
        {
        }

        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="id">唯一識別號</param>
        /// <param name="value">資料</param>
        [HttpPut("{id}")]
        public void Update(int id, [FromBody]string value)
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
