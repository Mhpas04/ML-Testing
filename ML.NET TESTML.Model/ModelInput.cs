

using Microsoft.ML.Data;

namespace ML_NET_TESTML.Model
{
    public class ModelInput
    {
        [ColumnName("col0"), LoadColumn(0)]
        public string Col0 { get; set; }


        [ColumnName("col1"), LoadColumn(1)]
        public string Col1 { get; set; }


    }
}
