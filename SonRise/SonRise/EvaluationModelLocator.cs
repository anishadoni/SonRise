using SonRise.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SonRise
{
    public class EvaluationModelLocator
    {
        private static EvaluationViewModel _addevalModel = new EvaluationViewModel();
        public static EvaluationViewModel MainViewModel
        {
            get
            {
                return _addevalModel;
            }
        }
    }
}
