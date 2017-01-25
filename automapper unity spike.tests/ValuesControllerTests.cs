using System;
using automapper_unity_spike.Controllers;
using AutoMapper;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace automapper_unity_spike.tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        private ValuesController _ctrl;
        private readonly IMapper _mapper;
        private readonly IUnityContainer _container;

        [TestInitialize]
        public void ControllerInit()
        {
            var mapper = AutoMapperConfiguration.AutoMapperInit();

            _ctrl = new ValuesController(new Repo(), mapper);
        }

        [TestMethod]
        public void Ctrl_With_AutoMapper_Example()
        {
            var result = _ctrl.Get();

            Assert.AreEqual(result, "Bruce Wayne is Batman!");
        }
    }
}
