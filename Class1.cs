using System;
using System.Management.Automation;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace dinLinqTestModule
{
    [Cmdlet("Get", "Test")]
    public class GetTestCmdlet : PSCmdlet
    {
        protected override void ProcessRecord()
        {

            var values = new[] { -1, 2, 3, 4, 5, 6, 10 }.AsQueryable();

            var result = values.Where("it = 2").ToArray();

            foreach (var r in result)
                WriteObject(r);
        }
    }
}
