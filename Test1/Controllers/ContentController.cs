﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Test1.Models;

namespace Test1.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
        //public IActionResult Index()
        //{
        //    var contents = new List<Content>();
        //    for (int i = 1; i < 11; i++)
        //    {
        //        contents.Add(
        //            new Content
        //            {
        //                Id = i,
        //                title = $"{i}的标题",
        //                content = $"{i}的内容",
        //                status = 1,
        //                add_time = DateTime.Now.AddDays(-i)
        //            });
        //    }
        //    return View(new ContentViewModel { Contents = contents });
        //}
        public IActionResult Index2()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(
                    new Content
                    {
                        Id = i,
                        title = $"{i}的标题",
                        content = $"{i}的内容",
                        status = 1,
                        add_time = DateTime.Now.AddDays(-i)
                    });
            }
            return View(new ContentViewModel { Contents = contents });
        }
        public IActionResult Index3()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(
                    new Content
                    {
                        Id = i,
                        title = $"{i}的标题",
                        content = $"{i}的内容",
                        status = 1,
                        add_time = DateTime.Now.AddDays(-i)
                    });
            }
            return View(new ContentViewModel { Contents = contents });
        }
        public IActionResult Index4()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(
                    new Content
                    {
                        Id = i,
                        title = $"{i}的标题",
                        content = $"{i}的内容",
                        status = 1,
                        add_time = DateTime.Now.AddDays(-i)
                    });
            }
            return View(new ContentViewModel { Contents = contents });
        }
    }
}