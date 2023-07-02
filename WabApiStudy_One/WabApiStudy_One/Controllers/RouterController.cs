using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WabApiStudy_One.Services;
using static WabApiStudy_One.Services.DataAccess;

namespace WabApiStudy_One.Controllers
{
    // 跨域三部曲
    [EnableCors("any")]
    /// <summary>
    /// action属性：可以自定义方法名（如Get1、Get2）
    /// 路由推荐 写在控制器上
    /// </summary>
    [Route("api/[controller]/[action]")]
    ///[ApiController]
    [ApiControllerAttribute]
    public class RouterController : ControllerBase
    {
        /// <summary>
        /// [HttpGet("Morning{i}")] 当在这里添加参数时，参数就是必传项 
        /// 此时的url是一个伪静态（不是？拼接的）
        /// ？i=1 这种是动态的
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        [HttpGet("Morning{i}/{name}")]
        ///[Route("api/Morning/aaa")]
        public string Get(int i,string name)
        {
            return "test" + i + name;
        }
        [HttpGet("{i}-{name}")]
        ///[Route("api/Morning/bbb")]
        public string Get1(int i, string name)
        {
            return "test1"+ i + name;
        }
        private readonly DataAccess _dataAccess;
        public RouterController()
        {
            _dataAccess = new DataAccess();
        }
        [HttpGet]
        ///[Route("api/Morning/bbb")]
        public string Get3()
        {
            var data = _dataAccess.GetData();
            var response = new MorningDto
            {
                Id = data.Id,
                Name = data.Name
            };
            return Ok(response);
        }
        [HttpPost]
        public string Post(int i, string name)
        {
            return $"{name}";
        }
        [HttpPut]
        public string Put(int i, string name)
        {
            return "put";
        }
        [HttpDelete]
        public string Delete(int i)
        {
            return "delete";
        }
    }
}
