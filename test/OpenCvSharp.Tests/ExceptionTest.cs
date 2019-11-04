﻿using Xunit;

namespace OpenCvSharp.Tests
{
    public class ExceptionTest : TestBase
    {
        [Fact]
        public void RedirectError()
        {
            using var img = new Mat(3, 3, MatType.CV_8UC1);

            var ex = Assert.Throws<OpenCVException>(() =>
            {
                Cv2.GaussianBlur(img, img, new Size(2, 2), 1); 
            });

            Assert.StartsWith("ksize.width > 0", ex.ErrMsg);
            Assert.NotEmpty(ex.FileName);
            Assert.NotEmpty(ex.FuncName);
            Assert.True(ex.Line > 0);
            Assert.Equal(ErrorCode.StsAssert, ex.Status);
        }
    }
}
