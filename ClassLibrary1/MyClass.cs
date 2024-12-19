using System.Linq;

namespace MyCompany.MyLib
{
    public class MyClass : IMyClass
    {
        public bool HasDuplicate(int[] arr)
        {
            if (arr == null || arr.Length <= 0) return false;

            var newArr = arr.Distinct().ToList();

            if (newArr == null || newArr.Count <= 0) return false;

            return arr.Length != newArr.Count;
        }
    }
}