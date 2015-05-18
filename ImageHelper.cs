using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace PhotoRenamer
{
    class ImageHelper
    {
        /// <summary>
        /// �õ���Ƭ����������
        /// </summary>
        /// <param name="imageFile"></param>
        /// <returns></returns>
        public static DateTime GetPhotoDate(string imageFile)
        {
            DateTime tmPhoto = DateTime.MinValue;

            using (Image img = Image.FromFile(imageFile))
            {
                try
                {
                    tmPhoto = ExifHelper.GetPropertyDateTime(img.GetPropertyItem((int)EXIFIDCodes.DateTimeOriginal));
                }
                catch { }
                finally
                {
                    img.Dispose();
                }
            }

            //GC.Collect();

            return tmPhoto;
            
        }



        /// <summary>
        /// ���������㷨
        /// </summary>
        /// ��������Ϊ���ȶ�����,ʱ�临�Ӷ�O(nlog2n),Ϊͬ���������������򷽷�
        /// <param name="arr">���ֵ�����</param>
        /// <param name="low">����Ͷ��ϱ�</param>
        /// <param name="high">����߶��±�</param>
        /// <returns></returns>
        static int Partition(FileInfo[] arr, int low, int high)
        {
            //����һ�˿�������,�����������¼λ��
            // arr[0] = arr[low];
            FileInfo pivot = arr[low];//������������arr[0]
            while (low < high)
            {
                while (low < high && arr[high].CreationTime <= pivot.CreationTime)
                    --high;
                //�����������¼С���Ƶ��Ͷ�
                Swap(ref arr[high], ref arr[low]);
                while (low < high && arr[low].CreationTime >= pivot.CreationTime)
                    ++low;
                Swap(ref arr[high], ref arr[low]);
                //�����������¼����Ƶ��߶�
            }
            arr[low] = pivot; //�������Ƶ���ȷλ��
            return low;  //����������λ��
        }
        static void Swap(ref FileInfo i, ref FileInfo j)
        {
            FileInfo t;
            t = i;
            i = j;
            j = t;
        }

        /// <summary>
        /// ���������㷨
        /// </summary>
        /// ��������Ϊ���ȶ�����,ʱ�临�Ӷ�O(nlog2n),Ϊͬ���������������򷽷�
        /// <param name="arr">���ֵ�����</param>
        /// <param name="low">����Ͷ��ϱ�</param>
        /// <param name="high">����߶��±�</param>
        public static void QuickSort(FileInfo[] arr, int low, int high)
        {
            if (low <= high - 1)//�� arr[low,high]Ϊ�ջ�ֻһ����¼��������
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);

            }
        }


    }
}
