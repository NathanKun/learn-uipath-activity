using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

/**
 * Tutorial: https://activities.uipath.com/docs/creating-a-custom-activity
 * NuGet Package Explorer: https://www.microsoft.com/store/apps/9wzdncrdmdm3
 */

namespace CustomUiPathActivities
{
    public class SumActivity : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<double> FirstNumber { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<double> SecondNumber { get; set; }

        [Category("Input")]
        public InArgument<double> ThirdNumber { get; set; }

        [Category("Output")]
        public OutArgument<double> ResultNumber { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var num1 = FirstNumber.Get(context);
            var num2 = SecondNumber.Get(context);
            var num3 = ThirdNumber.Get(context);

            ResultNumber.Set(context, num1 + num2 + num3);
        }
    }
}
