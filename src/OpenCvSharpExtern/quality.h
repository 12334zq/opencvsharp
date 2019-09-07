#ifndef _CPP_QUALITY_H_
#define _CPP_QUALITY_H_

#include "include_opencv.h"

#pragma region QualityBase

CVAPI(MyCvScalar) quality_QualityBase_compute(cv::quality::QualityBase *obj, cv::_InputArray *img)
{
    const auto ret = obj->compute(*img);
    return c(ret);
}

CVAPI(void) quality_QualityBase_getQualityMap(cv::quality::QualityBase *obj, cv::_OutputArray *dst)
{
    obj->getQualityMap(*dst);
}

CVAPI(void) quality_QualityBase_clear(cv::quality::QualityBase *obj)
{
    obj->clear();
}

CVAPI(int) quality_QualityBase_empty(cv::quality::QualityBase *obj)
{
    return obj->empty() ? 1 : 0;
}

#pragma endregion

#pragma region QualityPSNR

CVAPI(cv::Ptr<cv::quality::QualityPSNR>*) quality_createQualityPSNR(cv::_InputArray *ref, double maxPixelValue)
{
    const auto ptr = cv::quality::QualityPSNR::create(*ref, maxPixelValue);
    return new cv::Ptr<cv::quality::QualityPSNR>(ptr);
}

CVAPI(void) quality_Ptr_QualityPSNR_delete(cv::Ptr<cv::quality::QualityPSNR> *obj)
{
    delete obj;
}

CVAPI(cv::quality::QualityPSNR*) quality_Ptr_QualityPSNR_get(cv::Ptr<cv::quality::QualityPSNR>* ptr)
{
    return ptr->get();
}

CVAPI(MyCvScalar) quality_QualityPSNR_staticCompute(cv::_InputArray *ref, cv::_InputArray *cmp, cv::_OutputArray *qualityMap, double maxPixelValue)
{
    cv::Scalar ret;
    if (qualityMap == nullptr)
        ret = cv::quality::QualityPSNR::compute(*ref, *cmp, cv::noArray(), maxPixelValue);
    else
        ret = cv::quality::QualityPSNR::compute(*ref, *cmp, *qualityMap, maxPixelValue);
    return c(ret);
}

CVAPI(double) quality_QualityPSNR_getMaxPixelValue(cv::quality::QualityPSNR *obj)
{
    return obj->getMaxPixelValue();
}

CVAPI(void) quality_QualityPSNR_setMaxPixelValue(cv::quality::QualityPSNR *obj, double val)
{
    obj->setMaxPixelValue(val);
}

#pragma endregion

#pragma region QualitySSIM

CVAPI(cv::Ptr<cv::quality::QualitySSIM>*) quality_createQualitySSIM(cv::_InputArray* ref)
{
    const auto ptr = cv::quality::QualitySSIM::create(*ref);
    return new cv::Ptr<cv::quality::QualitySSIM>(ptr);
}

CVAPI(void) quality_Ptr_QualitySSIM_delete(cv::Ptr<cv::quality::QualitySSIM>* obj)
{
    delete obj;
}

CVAPI(cv::quality::QualitySSIM*) quality_Ptr_QualitySSIM_get(cv::Ptr<cv::quality::QualitySSIM>* ptr)
{
    return ptr->get();
}

CVAPI(MyCvScalar) quality_QualitySSIM_staticCompute(cv::_InputArray* ref, cv::_InputArray* cmp, cv::_OutputArray* qualityMap)
{
    cv::Scalar ret;
    if (qualityMap == nullptr)
        ret = cv::quality::QualitySSIM::compute(*ref, *cmp, cv::noArray());
    else
        ret = cv::quality::QualitySSIM::compute(*ref, *cmp, *qualityMap);
    return c(ret);
}

#pragma endregion

#endif