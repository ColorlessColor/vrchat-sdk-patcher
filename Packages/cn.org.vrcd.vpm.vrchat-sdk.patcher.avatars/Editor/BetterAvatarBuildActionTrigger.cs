﻿using UnityEditor;
using VRCD.VRChatPackages.VRChatSDKPatcher.Avatars.Editor.Utils;

namespace VRCD.VRChatPackages.VRChatSDKPatcher.Avatars.Editor
{
    internal static class BetterAvatarBuildActionTrigger
    {
        [MenuItem("VRChat SDK Patcher/[Avatars] Build Actions/[Build] Only", priority = 1000)]
        private static void Build()
        {
            AvatarBuildActionUtils.BuildGuard();
        }

        [MenuItem("VRChat SDK Patcher/[Avatars] Build Actions/[Build] and [Test]", priority = 2000)]
        private static void BuildAndTest()
        {
            AvatarBuildActionUtils.BuildAndTestGuard();
        }

        [MenuItem("VRChat SDK Patcher/[Avatars] Build Actions/[Build] and [Upload]", priority = 3000)]
        private static void BuildAndUpload()
        {
            AvatarBuildActionUtils.BuildAndUploadGuard();
        }

        [MenuItem("VRChat SDK Patcher/[Avatars] Build Actions/[Upload] Last Build", priority = 3000)]
        private static void UploadLastBuild()
        {
            AvatarBuildActionUtils.UploadLastBuildGuard();
        }
    }
}
