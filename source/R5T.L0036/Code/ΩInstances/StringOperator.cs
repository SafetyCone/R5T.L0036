using System;


namespace R5T.L0036
{
    public class StringOperator : IStringOperator
    {
        #region Infrastructure

        public static StringOperator Instance { get; } = new StringOperator();


        private StringOperator()
        {
        }

        #endregion
    }
}
