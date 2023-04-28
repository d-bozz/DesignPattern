﻿using DesignPatterns.Repository;
using DesignPatternsAsp.Strategies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tools.Generator;

namespace DesignPatternsAsp.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcretBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork, 
            GeneratorConcretBuilder generatorConcretBuilder)
        { 
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcretBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile) 
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(x => x.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content,path);
                else
                    generatorDirector.CreateSimplePipeGenerator(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();
                return Json("Archivo generado");
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
