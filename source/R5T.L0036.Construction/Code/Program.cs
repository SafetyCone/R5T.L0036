using System;
using System.Threading.Tasks;


namespace R5T.L0036.Construction
{
    class Program
    {
        static async Task Main()
        {
            await Experiments.Instance.TestRepositoryExists();
        }
    }
}