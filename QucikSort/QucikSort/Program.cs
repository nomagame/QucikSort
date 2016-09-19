using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 快速排序算法
/// </summary>
/// 
namespace QucikSort
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            int[] arry = new int[] {34,1,232,12,2,33,23,123};
            QuickSortClass.QucikSortFunction(arry,0,arry.Length- 1);
            for (int m = 0; m < arry.Length; m++)
            {
                Console.Write("\t"+arry[m]);
            }
            Console.Read();
        }
    }

    /// <summary>
    /// 快速排序算法函数
    /// </summary>
    /// 
    static class QuickSortClass
    {

        static public void QucikSortFunction ( this int [ ] arry , int left , int right )
        {
            if (left < right)
            {
                int middle = arry [ (left + right) / 2 ];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (arry [ ++i ] < middle && i < right) ;
                    while (arry [ --j ] > middle && j > 0) ;
                    if (i >= j)
                        break;
                    int number = arry [ i ];
                    arry [ i ] = arry [ j ];
                    arry [ j ] = number;
                }

                QucikSortFunction(arry, left,i - 1 );
                QucikSortFunction ( arry , j + 1 , right );
            }
        }
    } 
}
