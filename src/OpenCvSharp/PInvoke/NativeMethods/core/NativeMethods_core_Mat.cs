﻿using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

#pragma warning disable 1591

#pragma warning disable CA1401 // P/Invokes should not be visible
#pragma warning disable IDE1006 // Naming style

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_sizeof();

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new1(out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new2(int rows, int cols, int type, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new3(int rows, int cols, int type, Scalar scalar, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new4(IntPtr mat, Range rowRange, Range colRange, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new5(IntPtr mat, Range rowRange, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new6(IntPtr mat, [MarshalAs(UnmanagedType.LPArray)] Range[] rowRange, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new7(IntPtr mat, Rect roi, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new8(int rows, int cols, int type, IntPtr data, IntPtr step, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new9(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, 
            int type, IntPtr data, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] steps, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new9(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes,
                                int type, IntPtr data, IntPtr steps, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new10(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new11(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type, Scalar s, out IntPtr returnValue);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_new12(IntPtr mat, out IntPtr returnValue);

        //[Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        //public static extern ExceptionStatus core_Mat_release(IntPtr mat);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_delete(IntPtr mat);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_row(IntPtr self, int y, out IntPtr returnValue);
        
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_col(IntPtr self, int x, out IntPtr returnValue);
        
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_rowRange(IntPtr self, int startRow, int endRow, out IntPtr returnValue);
        
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExceptionStatus core_Mat_colRange(IntPtr self, int startCol, int endCol, out IntPtr returnValue);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_adjustROI(IntPtr nativeObj, int dtop, int dbottom, int dleft, int dright);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_assignTo1(IntPtr self, IntPtr m);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_assignTo2(IntPtr self, IntPtr m, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_channels(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_checkVector1(IntPtr self, int elemChannels);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_checkVector2(IntPtr self, int elemChannels, int depth);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_checkVector3(IntPtr self, int elemChannels, int depth, int requireContinuous);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_clone(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_cols(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_dims(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_convertTo(IntPtr self, IntPtr m, int rtype, double alpha, double beta);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_copyTo(IntPtr self, IntPtr m, IntPtr mask);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_create1(IntPtr self, int rows, int cols, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_create2(IntPtr self, int ndims, 
            [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_cross(IntPtr self, IntPtr m);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe byte* core_Mat_data(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_datastart(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_dataend(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_datalimit(IntPtr self);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_depth(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_diag1(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_diag2(IntPtr self, int d);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_diag3(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double core_Mat_dot(IntPtr self, IntPtr m);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_elemSize(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_elemSize1(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_empty(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_eye(int rows, int cols, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_inv1(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_inv2(IntPtr self, int method);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_isContinuous(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_isSubmatrix(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_locateROI(IntPtr self, out Size wholeSize, out Point ofs);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_mul1(IntPtr self, IntPtr m);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_mul2(IntPtr self, IntPtr m, double scale);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ones1(int rows, int cols, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ones2(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_reshape1(IntPtr self, int cn);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_reshape2(IntPtr self, int cn, int rows);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_reshape3(IntPtr self, int cn, int newndims, [MarshalAs(UnmanagedType.LPArray)] int[] newsz);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_rows(IntPtr self);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_setTo_Scalar(IntPtr self, Scalar value, IntPtr mask);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_setTo_InputArray(IntPtr self, IntPtr value, IntPtr mask);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Size core_Mat_size(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_sizeAt(IntPtr self, int i);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_step11(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_step12(IntPtr self, int i);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long core_Mat_step(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_stepAt(IntPtr self, int i);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_subMat1(IntPtr self, int rowStart, int rowEnd, int colStart, int colEnd);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_subMat2(IntPtr self, int nRanges, Range[] ranges);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_t(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong core_Mat_total(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int core_Mat_type(IntPtr self);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_zeros1(int rows, int cols, int type);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_zeros2(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ptr1d(IntPtr self, int i0);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ptr2d(IntPtr self, int i0, int i1);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ptr3d(IntPtr self, int i0, int i1, int i2);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_ptrnd(IntPtr self, [MarshalAs(UnmanagedType.LPArray)] int[] idx);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_assignment_FromMat(IntPtr self, IntPtr newMat);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_assignment_FromScalar(IntPtr self, Scalar scalar);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorUnaryMinus(IntPtr mat);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAdd_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAdd_MatScalar(IntPtr a, Scalar s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAdd_ScalarMat(Scalar s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorMinus_Mat(IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorSubtract_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorSubtract_MatScalar(IntPtr a, Scalar s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorSubtract_ScalarMat(Scalar s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorMultiply_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorMultiply_MatDouble(IntPtr a, double s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorMultiply_DoubleMat(double s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorDivide_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorDivide_MatDouble(IntPtr a, double s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorDivide_DoubleMat(double s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAnd_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAnd_MatDouble(IntPtr a, double s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorAnd_DoubleMat(double s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorOr_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorOr_MatDouble(IntPtr a, double s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorOr_DoubleMat(double s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorXor_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorXor_MatDouble(IntPtr a, double s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorXor_DoubleMat(double s, IntPtr a);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorNot(IntPtr a);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLT_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLT_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLT_MatDouble(IntPtr a, double b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLE_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLE_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorLE_MatDouble(IntPtr a, double b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGT_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGT_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGT_MatDouble(IntPtr a, double b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGE_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGE_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorGE_MatDouble(IntPtr a, double b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorEQ_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorEQ_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorEQ_MatDouble(IntPtr a, double b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorNE_MatMat(IntPtr a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorNE_DoubleMat(double a, IntPtr b);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_Mat_operatorNE_MatDouble(IntPtr a, double b);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr core_abs_Mat(IntPtr e);

        #region nSet

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetB(IntPtr obj, int row, int col, 
            byte* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetS(IntPtr obj, int row, int col, 
            short* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetS(IntPtr obj, int row, int col,
            ushort* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetI(IntPtr obj, int row, int col, 
            int* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetF(IntPtr obj, int row, int col, 
            float* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetD(IntPtr obj, int row, int col, 
            double* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetVec3b(IntPtr obj, int row, int col,
            Vec3b* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetVec3d(IntPtr obj, int row, int col,
            Vec3d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetVec4f(IntPtr obj, int row, int col,
            Vec4f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetVec6f(IntPtr obj, int row, int col,
            Vec6f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetVec4i(IntPtr obj, int row, int col,
            Vec4i* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint(IntPtr obj, int row, int col,
            Point* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint2f(IntPtr obj, int row, int col,
            Point2f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint2d(IntPtr obj, int row, int col,
            Point2d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint3i(IntPtr obj, int row, int col,
            Point3i* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint3f(IntPtr obj, int row, int col,
            Point3f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetPoint3d(IntPtr obj, int row, int col,
            Point3d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nSetRect(IntPtr obj, int row, int col,
            Rect* vals, int valsLength);

        #endregion

        #region nGet

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetB(IntPtr obj, int row, int col, 
            byte* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetS(IntPtr obj, int row, int col, 
            short* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetS(IntPtr obj, int row, int col,
            ushort* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetI(IntPtr obj, int row, int col, 
            int* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetF(IntPtr obj, int row, int col, 
            float* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetD(IntPtr obj, int row, int col, 
            double* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetVec3b(IntPtr obj, int row, int col,
            Vec3b* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetVec3d(IntPtr obj, int row, int col,
            Vec3d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetVec4f(IntPtr obj, int row, int col,
            Vec4f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetVec6f(IntPtr obj, int row, int col,
            Vec6f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetVec4i(IntPtr obj, int row, int col,
            Vec4i* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint(IntPtr obj, int row, int col,
            Point* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint2f(IntPtr obj, int row, int col,
            Point2f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint2d(IntPtr obj, int row, int col,
            Point2d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint3i(IntPtr obj, int row, int col,
            Point3i* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint3f(IntPtr obj, int row, int col,
            Point3f* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetPoint3d(IntPtr obj, int row, int col,
            Point3d* vals, int valsLength);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern unsafe int core_Mat_nGetRect(IntPtr obj, int row, int col,
            Rect* vals, int valsLength);

        #endregion

        #region push_back
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Mat(IntPtr self, IntPtr m);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_char(IntPtr self, sbyte v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_uchar(IntPtr self, byte v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_short(IntPtr self, short v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_ushort(IntPtr self, ushort v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_int(IntPtr self, int v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_float(IntPtr self, float v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_double(IntPtr self, double v);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2b(IntPtr self, Vec2b v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3b(IntPtr self, Vec3b v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4b(IntPtr self, Vec4b v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6b(IntPtr self, Vec6b v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2s(IntPtr self, Vec2s v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3s(IntPtr self, Vec3s v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4s(IntPtr self, Vec4s v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6s(IntPtr self, Vec6s v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2w(IntPtr self, Vec2w v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3w(IntPtr self, Vec3w v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4w(IntPtr self, Vec4w v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6w(IntPtr self, Vec6w v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2i(IntPtr self, Vec2i v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3i(IntPtr self, Vec3i v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4i(IntPtr self, Vec4i v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6i(IntPtr self, Vec6i v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2f(IntPtr self, Vec2f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3f(IntPtr self, Vec3f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4f(IntPtr self, Vec4f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6f(IntPtr self, Vec6f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec2d(IntPtr self, Vec2d v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec3d(IntPtr self, Vec3d v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec4d(IntPtr self, Vec4d v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Vec6d(IntPtr self, Vec6d v);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point(IntPtr self, Point v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point2f(IntPtr self, Point2f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point2d(IntPtr self, Point2d v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point3i(IntPtr self, Point3i v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point3f(IntPtr self, Point3f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Point3d(IntPtr self, Point3d v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Size(IntPtr self, Size v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Size2f(IntPtr self, Size2f v);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_push_back_Rect(IntPtr self, Rect v);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_reserve(IntPtr obj, IntPtr sz);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_resize1(IntPtr obj, IntPtr sz);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_resize2(IntPtr obj, IntPtr sz, Scalar s);
        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_pop_back(IntPtr obj, IntPtr nelems);
        #endregion

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_uchar(IntPtr m, MatForeachFunctionByte proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec2b(IntPtr m, MatForeachFunctionVec2b proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec3b(IntPtr m, MatForeachFunctionVec3b proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec4b(IntPtr m, MatForeachFunctionVec4b proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec6b(IntPtr m, MatForeachFunctionVec6b proc);


        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_short(IntPtr m, MatForeachFunctionInt16 proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec2s(IntPtr m, MatForeachFunctionVec2s proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec3s(IntPtr m, MatForeachFunctionVec3s proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec4s(IntPtr m, MatForeachFunctionVec4s proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec6s(IntPtr m, MatForeachFunctionVec6s proc);


        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_int(IntPtr m, MatForeachFunctionInt32 proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec2i(IntPtr m, MatForeachFunctionVec2i proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec3i(IntPtr m, MatForeachFunctionVec3i proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec4i(IntPtr m, MatForeachFunctionVec4i proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec6i(IntPtr m, MatForeachFunctionVec6i proc);


        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_float(IntPtr m, MatForeachFunctionFloat proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec2f(IntPtr m, MatForeachFunctionVec2f proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec3f(IntPtr m, MatForeachFunctionVec3f proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec4f(IntPtr m, MatForeachFunctionVec4f proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec6f(IntPtr m, MatForeachFunctionVec6f proc);


        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_double(IntPtr m, MatForeachFunctionDouble proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec2d(IntPtr m, MatForeachFunctionVec2d proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec3d(IntPtr m, MatForeachFunctionVec3d proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec4d(IntPtr m, MatForeachFunctionVec4d proc);

        [Pure, DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void core_Mat_forEach_Vec6d(IntPtr m, MatForeachFunctionVec6d proc);
    }
}