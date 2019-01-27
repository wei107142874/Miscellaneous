using CodeCarvings.Piczard;
using CodeCarvings.Piczard.Filters.Watermarks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static partial class CommHelper
    {
        /// <summary>
        /// 缩略图
        /// </summary>
        public static void Thumb(object source, string destFilePath)
        {
            ImageProcessingJob jobThumb = new ImageProcessingJob();
            jobThumb.Filters.Add(new FixedResizeConstraint(200, 200));//缩略图尺寸 200*200
            jobThumb.SaveProcessedImageToFileSystem(source, destFilePath);
        }

        /// <summary>
        /// 水印
        /// </summary>
        public static void Watermark(string imageFilePath, object source, string destFilePath)
        {
            ImageWatermark imgWatermark = new ImageWatermark(imageFilePath);
            imgWatermark.ContentAlignment = System.Drawing.ContentAlignment.BottomRight;//水印位置
imgWatermark.Alpha = 50;//透明度，需要水印图片是背景透明的 png 图片
            ImageProcessingJob jobNormal = new ImageProcessingJob();
            jobNormal.Filters.Add(imgWatermark);//添加水印
            jobNormal.Filters.Add(new FixedResizeConstraint(600, 600));//限制图片的大小，避免生成大图。如果想原图大小处理，就不用加这个 Filter
            jobNormal.SaveProcessedImageToFileSystem(source, destFilePath);
        }
    }
}
