using Caliburn.Micro;
using CheerfulWaterCarrier.DataAccess;
using CheerfulWaterCarrier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.ViewModels
{
    public class SubdivisionViewModel : Screen
    {
        private readonly ISubdivisionData _subdivisionData;

        public SubdivisionViewModel(ISubdivisionData subdivisionData)
        {
            _subdivisionData = subdivisionData;
        }

        private SubdivisionModel _subdivision = new SubdivisionModel();

        public SubdivisionModel Subdivision
        {
            get    
            {
                return _subdivision; 
            }
            set
            {
                _subdivision = value;
                NotifyOfPropertyChange(() => Subdivision);
            }
        }

        public void Save()
        {
            if (null != Subdivision.SubdivisionId)
            {
                _subdivisionData.UpdateSubdivision(Subdivision);
            }
            else
            {
                _subdivisionData.InsertSubdivision(Subdivision);
            }

            TryClose();
        }
    }
}
