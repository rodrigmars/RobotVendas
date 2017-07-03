using RobotVendas.Application.Interfaces;
using RobotVendas.Domain.Entities;
using System;
namespace RobotVendas.Application
{
    public class VendasApp : AppBase<Venda>, IVendaApp
    {
        readonly IVendaApp _vendaApp;

        public VendasApp(IVendaApp vendaApp) : base(vendaApp)
        {
            _vendaApp = vendaApp;
        }

        public bool DiaUtil()
        {

            var days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            return true;
        }
    }
}
