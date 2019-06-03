using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFarmaciaElvis.Entidades.DTOs;
using ApiFarmaciaElvis.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFarmarciaElvis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
        {
            this.reportsService = reportsService;
        }

        // GET: api/Reports
        [HttpGet]
        public ReportsDTO Get()
        {
            ReportsDTO reportsDTO = reportsService.GetReports();

            return reportsDTO;
        }
    }
}
