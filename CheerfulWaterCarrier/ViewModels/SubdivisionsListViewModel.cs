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
    public class SubdivisionsListViewModel : Screen
    {
        private readonly IWindowManager _windowManager;
        private readonly ISubdivisionData _subdivisionData;

        public SubdivisionsListViewModel(IWindowManager windowManager, ISubdivisionData subdivisionData)
        {
            _windowManager = windowManager;
            _subdivisionData = subdivisionData;

            LoadSubdivisions();
        }

        private BindableCollection<SubdivisionModel> subdivisions = new BindableCollection<SubdivisionModel>();

        public BindableCollection<SubdivisionModel> Subdivisions
        {
            get 
            {
                return subdivisions; 
            }
            set
            {
                subdivisions = value; 
            }
        }

        private SubdivisionModel selectedSubdivision;

        public SubdivisionModel SelectedSubdivision
        {
            get 
            {
                return selectedSubdivision; 
            }
            set 
            {
                selectedSubdivision = value;
                NotifyOfPropertyChange(() => SelectedSubdivision);
                NotifyOfPropertyChange(() => CanModify);
            }
        }

        public bool CanModify
        {
            get
            {
                bool output = false;

                if (null != SelectedSubdivision && Subdivisions.IndexOf(SelectedSubdivision) > -1)
                {
                    output = true;
                }

                return output;
            }
        }

        public void Modify()
        {
            var subdivisionVM = new SubdivisionViewModel(_subdivisionData);

            subdivisionVM.Subdivision = SelectedSubdivision;

            _windowManager.ShowDialog(subdivisionVM);
        }

        public void BtnRefresh()
        {
            Subdivisions.Clear();

            LoadSubdivisions();
        }

        private void LoadSubdivisions()
        {
            var subdivisions = _subdivisionData.GetSubdivisions();

            foreach (var subdivision in subdivisions)
            {
                Subdivisions.Add(subdivision);
            }
        }

        public void Add()
        {
            _windowManager.ShowDialog(new SubdivisionViewModel(_subdivisionData));
        }
    }
}
