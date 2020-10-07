using CheerfulWaterCarrier.Models;
using System.Collections.Generic;

namespace CheerfulWaterCarrier.DataAccess
{
    public interface ISubdivisionData
    {
        List<SubdivisionModel> GetSubdivisions();
        void InsertSubdivision(SubdivisionModel item);
        void UpdateSubdivision(SubdivisionModel item);
    }
}