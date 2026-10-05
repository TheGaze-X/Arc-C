using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x0200206C RID: 8300
	[Token(Token = "0x200206C")]
	[ExecuteAlways]
	public class SceneVolumeEffect : BaseSceneEffect
	{
		// Token: 0x0600CC75 RID: 52341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC75")]
		[Address(RVA = "0x34E5B70", Offset = "0x34E4770", VA = "0x1834E5B70", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC76")]
		[Address(RVA = "0x34E6C70", Offset = "0x34E5870", VA = "0x1834E6C70")]
		private void _ClearCurrentCamera()
		{
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC77")]
		[Address(RVA = "0x34E5E10", Offset = "0x34E4A10", VA = "0x1834E5E10", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC78")]
		[Address(RVA = "0x34E5250", Offset = "0x34E3E50", VA = "0x1834E5250")]
		private void InitInternal()
		{
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC79")]
		[Address(RVA = "0x34E5E70", Offset = "0x34E4A70", VA = "0x1834E5E70")]
		private void RtRelease()
		{
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7A")]
		[Address(RVA = "0x34E5D40", Offset = "0x34E4940", VA = "0x1834E5D40", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7B")]
		[Address(RVA = "0x34E4F00", Offset = "0x34E3B00", VA = "0x1834E4F00")]
		public static void ComputeTransformedAABB(Matrix4x4 modelMatrix, out Vector3 min, out Vector3 max)
		{
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7C")]
		[Address(RVA = "0x34E64A0", Offset = "0x34E50A0", VA = "0x1834E64A0")]
		private void Update()
		{
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7D")]
		[Address(RVA = "0x34E6060", Offset = "0x34E4C60", VA = "0x1834E6060")]
		private void SetCameraMatrix(Camera camera, ref Matrix4x4 matrix)
		{
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7E")]
		[Address(RVA = "0x34E6D20", Offset = "0x34E5920", VA = "0x1834E6D20")]
		public SceneVolumeEffect()
		{
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC7F")]
		[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC80")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC81")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D71E RID: 55070
		[Token(Token = "0x400D71E")]
		[FieldOffset(Offset = "0x20")]
		public Material cloudMat;

		// Token: 0x0400D71F RID: 55071
		[Token(Token = "0x400D71F")]
		[FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		// Token: 0x0400D720 RID: 55072
		[Token(Token = "0x400D720")]
		[FieldOffset(Offset = "0x30")]
		public Shader blendShader;

		// Token: 0x0400D721 RID: 55073
		[Token(Token = "0x400D721")]
		[FieldOffset(Offset = "0x38")]
		public Shader FixShader;

		// Token: 0x0400D722 RID: 55074
		[Token(Token = "0x400D722")]
		[FieldOffset(Offset = "0x40")]
		public bool hightQuality;

		// Token: 0x0400D723 RID: 55075
		[Token(Token = "0x400D723")]
		[FieldOffset(Offset = "0x44")]
		[Range(1f, 5f)]
		public float jitter;

		// Token: 0x0400D724 RID: 55076
		[Token(Token = "0x400D724")]
		[FieldOffset(Offset = "0x48")]
		private Material sceneCloudMat;

		// Token: 0x0400D725 RID: 55077
		[Token(Token = "0x400D725")]
		[FieldOffset(Offset = "0x50")]
		private Material blendMat;

		// Token: 0x0400D726 RID: 55078
		[Token(Token = "0x400D726")]
		[FieldOffset(Offset = "0x58")]
		private Material blurMat;

		// Token: 0x0400D727 RID: 55079
		[Token(Token = "0x400D727")]
		[FieldOffset(Offset = "0x60")]
		private Material fixMat;

		// Token: 0x0400D728 RID: 55080
		[Token(Token = "0x400D728")]
		[FieldOffset(Offset = "0x68")]
		private Camera cam;

		// Token: 0x0400D729 RID: 55081
		[Token(Token = "0x400D729")]
		[FieldOffset(Offset = "0x70")]
		private Camera sceneCam;

		// Token: 0x0400D72A RID: 55082
		[Token(Token = "0x400D72A")]
		[FieldOffset(Offset = "0x78")]
		[Range(1f, 8f)]
		public int downScale;

		// Token: 0x0400D72B RID: 55083
		[Token(Token = "0x400D72B")]
		[FieldOffset(Offset = "0x80")]
		private RenderTexture rt;

		// Token: 0x0400D72C RID: 55084
		[Token(Token = "0x400D72C")]
		[FieldOffset(Offset = "0x88")]
		private RenderTexture rt_edge;

		// Token: 0x0400D72D RID: 55085
		[Token(Token = "0x400D72D")]
		[FieldOffset(Offset = "0x90")]
		private RenderTexture rt_multiFrame;

		// Token: 0x0400D72E RID: 55086
		[Token(Token = "0x400D72E")]
		[FieldOffset(Offset = "0x98")]
		private RenderTexture rt_cloudBlit;

		// Token: 0x0400D72F RID: 55087
		[Token(Token = "0x400D72F")]
		[FieldOffset(Offset = "0xA0")]
		private RenderTexture sceneRT;

		// Token: 0x0400D730 RID: 55088
		[Token(Token = "0x400D730")]
		[FieldOffset(Offset = "0xA8")]
		private RenderTexture scenert_edge;

		// Token: 0x0400D731 RID: 55089
		[Token(Token = "0x400D731")]
		[FieldOffset(Offset = "0xB0")]
		private Matrix4x4 frustunCorners;

		// Token: 0x0400D732 RID: 55090
		[Token(Token = "0x400D732")]
		[FieldOffset(Offset = "0xF0")]
		private Matrix4x4 frustunCorners_scene;

		// Token: 0x0400D733 RID: 55091
		[Token(Token = "0x400D733")]
		[FieldOffset(Offset = "0x130")]
		private Matrix4x4 sceneVP;

		// Token: 0x0400D734 RID: 55092
		[Token(Token = "0x400D734")]
		[FieldOffset(Offset = "0x170")]
		private CommandBuffer cmd;

		// Token: 0x0400D735 RID: 55093
		[Token(Token = "0x400D735")]
		[FieldOffset(Offset = "0x178")]
		private CommandBuffer scene_cmd;

		// Token: 0x0400D736 RID: 55094
		[Token(Token = "0x400D736")]
		[FieldOffset(Offset = "0x180")]
		private CameraEvent cloudEvent;

		// Token: 0x0400D737 RID: 55095
		[Token(Token = "0x400D737")]
		[FieldOffset(Offset = "0x184")]
		private Vector3 boundMin;

		// Token: 0x0400D738 RID: 55096
		[Token(Token = "0x400D738")]
		[FieldOffset(Offset = "0x190")]
		private Vector3 boundMax;

		// Token: 0x0400D739 RID: 55097
		[Token(Token = "0x400D739")]
		[FieldOffset(Offset = "0x19C")]
		public bool multiFrame;

		// Token: 0x0400D73A RID: 55098
		[Token(Token = "0x400D73A")]
		[FieldOffset(Offset = "0x19D")]
		public bool edgeFix;

		// Token: 0x0400D73B RID: 55099
		[Token(Token = "0x400D73B")]
		[FieldOffset(Offset = "0x19E")]
		public bool debug;

		// Token: 0x0400D73C RID: 55100
		[Token(Token = "0x400D73C")]
		[FieldOffset(Offset = "0x1A0")]
		private int frameIndex;

		// Token: 0x0400D73D RID: 55101
		[Token(Token = "0x400D73D")]
		[FieldOffset(Offset = "0x1A4")]
		private bool isInit;

		// Token: 0x0400D73E RID: 55102
		[Token(Token = "0x400D73E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D73F RID: 55103
		[Token(Token = "0x400D73F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ClearCurrentCamera;

		// Token: 0x0400D740 RID: 55104
		[Token(Token = "0x400D740")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D741 RID: 55105
		[Token(Token = "0x400D741")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitInternal;

		// Token: 0x0400D742 RID: 55106
		[Token(Token = "0x400D742")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RtRelease;

		// Token: 0x0400D743 RID: 55107
		[Token(Token = "0x400D743")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D744 RID: 55108
		[Token(Token = "0x400D744")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ComputeTransformedAABB;

		// Token: 0x0400D745 RID: 55109
		[Token(Token = "0x400D745")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D746 RID: 55110
		[Token(Token = "0x400D746")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetCameraMatrix;

		// Token: 0x0400D747 RID: 55111
		[Token(Token = "0x400D747")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
