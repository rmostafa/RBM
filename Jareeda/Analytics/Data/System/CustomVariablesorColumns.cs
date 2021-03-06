
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class CustomVariablesorColumns
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The name of the requested custom dimension, where XX refers the number/index of the custom dimension.")]
            public static DataItem dimensionXX = new DataItem("dimensionXX");
                                      
            [DescriptionAttribute("The name for the requested custom variable.")]
            public static DataItem customVarNameXX = new DataItem("customVarNameXX");
                                      
            [DescriptionAttribute("The filter for the requested custom variable.")]
            public static DataItem customVarValueXX = new DataItem("customVarValueXX");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The name of the requested custom metric, where XX refers the number/index of the custom metric.")]
            public static DataItem metricXX = new DataItem("metricXX");
                                      

            public sealed class Calculated
            {
                
            }
        }
    }
}
