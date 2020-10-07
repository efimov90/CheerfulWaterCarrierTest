using CheerfulWaterCarrier.Internal.DataAccess;
using CheerfulWaterCarrier.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.DataAccess
{
    public class SubdivisionData : ISubdivisionData
    {
        private readonly IConfiguration _config;
        private readonly ISqlDataAccess _sql;

        public SubdivisionData(IConfiguration config, ISqlDataAccess sql)
        {
            _config = config;
            _sql = sql;
        }

        public List<SubdivisionModel> GetSubdivisions()
        {
            var output = _sql.LoadData<SubdivisionModel, dynamic>("dbo.spSubdivision_GetAll", new { }, "CheerfulWaterCarrierDB");

            return output;
        }

        public void InsertSubdivision(SubdivisionModel item)
        {
            _sql.SaveData("dbo.spSubdivision_Insert", item, "CheerfulWaterCarrierDB");
        }

        public void UpdateSubdivision(SubdivisionModel item)
        {
            _sql.SaveData("dbo.spSubdivision_Update", item, "CheerfulWaterCarrierDB");
        }
    }
}
