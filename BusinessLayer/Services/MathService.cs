using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MathService : IMathService
    {
        private readonly DbContext _dbContext;
        public MathService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(int num1, int num2)
        {
            var sum = num1 + num2;

            var math = new DataLayer.Math
            {
                Number1 = num1,
                Number2 = num2,
                Sum = sum
            };
           // await _dbContext.Maths.InsertOneAsync(math);
            return sum;
        }
    }
}
