//=============================================================================================================================
//
// Copyright (c) 2015-2017 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
// EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
// and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
//
//=============================================================================================================================

using UnityEngine;

namespace EasyAR
{
    public class ImageTargetBehaviour : ImageTargetBaseBehaviour
    {
        [SerializeField] private Renderer planeRender;

        protected override void Start()
        {
            base.Start();
            TargetFound += ImageTargetBehaviour_TargetFound;
            TargetLost += ImageTargetBehaviour_TargetLost;
        }

        private void ImageTargetBehaviour_TargetFound(TargetAbstractBehaviour obj)
        {
            print("Target Name Found:: "+ Target.Name);

            switch(Target.Name)
            {
                case Constants.NAME_TARGET_1:
                    AppManager.Instance.GetVideoPlayer().url = Constants.LINK_VIDEO_TARGET_1;
                    break;
                case Constants.NAME_TARGET_2:
                    AppManager.Instance.GetVideoPlayer().url = Constants.LINK_VIDEO_TARGET_2;
                    break;
            }

            AppManager.Instance.GetVideoPlayer().targetMaterialRenderer = planeRender;
            AppManager.Instance.GetVideoPlayer().Play();
        }

        private void ImageTargetBehaviour_TargetLost(TargetAbstractBehaviour obj)
        {
            print("Target Name Lost:: " + Target.Name);
            AppManager.Instance.GetVideoPlayer().Stop();
        }
    }
}