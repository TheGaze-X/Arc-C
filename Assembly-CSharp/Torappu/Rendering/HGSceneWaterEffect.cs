using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002072 RID: 8306
	[Token(Token = "0x2002072")]
	public class HGSceneWaterEffect : BaseSceneEffect
	{
		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x00049CF8 File Offset: 0x00047EF8
		[Token(Token = "0x1700183D")]
		private bool ReflEnabled
		{
			[Token(Token = "0x600CC9A")]
			[Address(RVA = "0x34D4DB0", Offset = "0x34D39B0", VA = "0x1834D4DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x0600CC9B RID: 52379 RVA: 0x00049D10 File Offset: 0x00047F10
		[Token(Token = "0x1700183E")]
		private bool DepthEnabled
		{
			[Token(Token = "0x600CC9B")]
			[Address(RVA = "0x34D4A70", Offset = "0x34D3670", VA = "0x1834D4A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600CC9C RID: 52380 RVA: 0x00049D28 File Offset: 0x00047F28
		[Token(Token = "0x1700183F")]
		private bool IntersectEnable
		{
			[Token(Token = "0x600CC9C")]
			[Address(RVA = "0x34D4C90", Offset = "0x34D3890", VA = "0x1834D4C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600CC9D RID: 52381 RVA: 0x00049D40 File Offset: 0x00047F40
		[Token(Token = "0x17001840")]
		private bool DistortEnabled
		{
			[Token(Token = "0x600CC9D")]
			[Address(RVA = "0x34D4AF0", Offset = "0x34D36F0", VA = "0x1834D4AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600CC9E RID: 52382 RVA: 0x00049D58 File Offset: 0x00047F58
		[Token(Token = "0x17001841")]
		private bool GradingSimple
		{
			[Token(Token = "0x600CC9E")]
			[Address(RVA = "0x34D4C00", Offset = "0x34D3800", VA = "0x1834D4C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x00049D70 File Offset: 0x00047F70
		[Token(Token = "0x17001842")]
		private int DepthDownScaler
		{
			[Token(Token = "0x600CC9F")]
			[Address(RVA = "0x34D49B0", Offset = "0x34D35B0", VA = "0x1834D49B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x0600CCA0 RID: 52384 RVA: 0x00049D88 File Offset: 0x00047F88
		[Token(Token = "0x17001843")]
		private int ReflectionDownScaler
		{
			[Token(Token = "0x600CCA0")]
			[Address(RVA = "0x34D4E60", Offset = "0x34D3A60", VA = "0x1834D4E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x0600CCA1 RID: 52385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001844")]
		private Animator WaterAnimator
		{
			[Token(Token = "0x600CCA1")]
			[Address(RVA = "0x34D4EF0", Offset = "0x34D3AF0", VA = "0x1834D4EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA2")]
		[Address(RVA = "0x34D2160", Offset = "0x34D0D60", VA = "0x1834D2160", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CCA3 RID: 52387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA3")]
		[Address(RVA = "0x34D1790", Offset = "0x34D0390", VA = "0x1834D1790", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CCA4 RID: 52388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA4")]
		[Address(RVA = "0x34D2350", Offset = "0x34D0F50", VA = "0x1834D2350")]
		private void Update()
		{
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA5")]
		[Address(RVA = "0x34D3450", Offset = "0x34D2050", VA = "0x1834D3450")]
		private void _InitializeWater()
		{
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x00049DA0 File Offset: 0x00047FA0
		[Token(Token = "0x600CCA6")]
		[Address(RVA = "0x34D2FF0", Offset = "0x34D1BF0", VA = "0x1834D2FF0")]
		private RenderTextureFormat _GetDepthRTFormat()
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA7")]
		[Address(RVA = "0x34D24A0", Offset = "0x34D10A0", VA = "0x1834D24A0")]
		private void _AddWaterCommandBuffer()
		{
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA8")]
		[Address(RVA = "0x34D3D20", Offset = "0x34D2920", VA = "0x1834D3D20")]
		private void _RemoveWaterCommandBuffer()
		{
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCA9")]
		[Address(RVA = "0x34D18E0", Offset = "0x34D04E0", VA = "0x1834D18E0", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCAA")]
		[Address(RVA = "0x34D1EA0", Offset = "0x34D0AA0", VA = "0x1834D1EA0", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCAB")]
		[Address(RVA = "0x34D1730", Offset = "0x34D0330", VA = "0x1834D1730", Slot = "10")]
		public override Animation GetSceneWaterAnimator()
		{
			return null;
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCAC")]
		[Address(RVA = "0x34D1450", Offset = "0x34D0050", VA = "0x1834D1450", Slot = "11")]
		public override Shader GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCAD")]
		[Address(RVA = "0x34D3060", Offset = "0x34D1C60", VA = "0x1834D3060")]
		private void _InitReflection()
		{
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCAE")]
		[Address(RVA = "0x34D3F50", Offset = "0x34D2B50", VA = "0x1834D3F50")]
		private void _UpdateReflectCamera()
		{
		}

		// Token: 0x0600CCAF RID: 52399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCAF")]
		[Address(RVA = "0x34D2B80", Offset = "0x34D1780", VA = "0x1834D2B80")]
		private Camera _CreateReflCamera(Camera sceneCamera)
		{
			return null;
		}

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB0")]
		[Address(RVA = "0x34D2720", Offset = "0x34D1320", VA = "0x1834D2720")]
		private void _CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x00049DB8 File Offset: 0x00047FB8
		[Token(Token = "0x600CCB1")]
		[Address(RVA = "0x34D28D0", Offset = "0x34D14D0", VA = "0x1834D28D0")]
		private Vector4 _CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
		{
			return default(Vector4);
		}

		// Token: 0x0600CCB2 RID: 52402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB2")]
		[Address(RVA = "0x34D4840", Offset = "0x34D3440", VA = "0x1834D4840")]
		public HGSceneWaterEffect()
		{
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB3")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CCB4 RID: 52404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB4")]
		[Address(RVA = "0x34D2340", Offset = "0x34D0F40", VA = "0x1834D2340")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB5")]
		[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB6")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCB7")]
		[Address(RVA = "0x34D2330", Offset = "0x34D0F30", VA = "0x1834D2330")]
		private Animation <>xLuaBaseProxy_GetSceneWaterAnimator()
		{
			return null;
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCB8")]
		[Address(RVA = "0x34D2320", Offset = "0x34D0F20", VA = "0x1834D2320")]
		private Shader <>xLuaBaseProxy_GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0400D79B RID: 55195
		[Token(Token = "0x400D79B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public WaterEffectProfile _waterProfile;

		// Token: 0x0400D79C RID: 55196
		[Token(Token = "0x400D79C")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Shader _depthShader;

		// Token: 0x0400D79D RID: 55197
		[Token(Token = "0x400D79D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<MeshRenderer> _underwaterOpaqueList;

		// Token: 0x0400D79E RID: 55198
		[Token(Token = "0x400D79E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		[Obsolete("Not used anymore")]
		private List<MeshRenderer> _reflObjectList;

		// Token: 0x0400D79F RID: 55199
		[Token(Token = "0x400D79F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<MeshRenderer> _waterMeshList;

		// Token: 0x0400D7A0 RID: 55200
		[Token(Token = "0x400D7A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _gradingEffectStrict;

		// Token: 0x0400D7A1 RID: 55201
		[Token(Token = "0x400D7A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animation _waterAnimationTrap;

		// Token: 0x0400D7A2 RID: 55202
		[Token(Token = "0x400D7A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Warning : Mesh should have any offset in height!")]
		private Transform _waterSurfaceTransform;

		// Token: 0x0400D7A3 RID: 55203
		[Token(Token = "0x400D7A3")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_camera;

		// Token: 0x0400D7A4 RID: 55204
		[Token(Token = "0x400D7A4")]
		[FieldOffset(Offset = "0x68")]
		private Camera m_reflCamera;

		// Token: 0x0400D7A5 RID: 55205
		[Token(Token = "0x400D7A5")]
		[FieldOffset(Offset = "0x70")]
		private CommandBuffer m_depthCB;

		// Token: 0x0400D7A6 RID: 55206
		[Token(Token = "0x400D7A6")]
		[FieldOffset(Offset = "0x78")]
		private Material m_depthMat;

		// Token: 0x0400D7A7 RID: 55207
		[Token(Token = "0x400D7A7")]
		[FieldOffset(Offset = "0x80")]
		private RenderTexture m_depthRT;

		// Token: 0x0400D7A8 RID: 55208
		[Token(Token = "0x400D7A8")]
		[FieldOffset(Offset = "0x88")]
		private RenderTexture m_reflRT;

		// Token: 0x0400D7A9 RID: 55209
		[Token(Token = "0x400D7A9")]
		[FieldOffset(Offset = "0x90")]
		private CommandBuffer m_distortCB;

		// Token: 0x0400D7AA RID: 55210
		[Token(Token = "0x400D7AA")]
		[FieldOffset(Offset = "0x98")]
		private bool m_initializeSuccess;

		// Token: 0x0400D7AB RID: 55211
		[Token(Token = "0x400D7AB")]
		[FieldOffset(Offset = "0x99")]
		private bool m_cameraCommandBufferActive;

		// Token: 0x0400D7AC RID: 55212
		[Token(Token = "0x400D7AC")]
		private const string CB_NAME_DEPTH = "HG Draw Depth";

		// Token: 0x0400D7AD RID: 55213
		[Token(Token = "0x400D7AD")]
		private const string RT_NAME_DEPTH = "HG Depth RT";

		// Token: 0x0400D7AE RID: 55214
		[Token(Token = "0x400D7AE")]
		private const string RT_NAME_REFL = "HG Refl RT";

		// Token: 0x0400D7AF RID: 55215
		[Token(Token = "0x400D7AF")]
		[FieldOffset(Offset = "0x9C")]
		private int m_refCntDelay;

		// Token: 0x0400D7B0 RID: 55216
		[Token(Token = "0x400D7B0")]
		[FieldOffset(Offset = "0xA0")]
		private int m_refCntDown;

		// Token: 0x0400D7B1 RID: 55217
		[Token(Token = "0x400D7B1")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 m_oldPos;

		// Token: 0x0400D7B2 RID: 55218
		[Token(Token = "0x400D7B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ReflEnabled;

		// Token: 0x0400D7B3 RID: 55219
		[Token(Token = "0x400D7B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_DepthEnabled;

		// Token: 0x0400D7B4 RID: 55220
		[Token(Token = "0x400D7B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IntersectEnable;

		// Token: 0x0400D7B5 RID: 55221
		[Token(Token = "0x400D7B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_DistortEnabled;

		// Token: 0x0400D7B6 RID: 55222
		[Token(Token = "0x400D7B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_GradingSimple;

		// Token: 0x0400D7B7 RID: 55223
		[Token(Token = "0x400D7B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_DepthDownScaler;

		// Token: 0x0400D7B8 RID: 55224
		[Token(Token = "0x400D7B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ReflectionDownScaler;

		// Token: 0x0400D7B9 RID: 55225
		[Token(Token = "0x400D7B9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_WaterAnimator;

		// Token: 0x0400D7BA RID: 55226
		[Token(Token = "0x400D7BA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D7BB RID: 55227
		[Token(Token = "0x400D7BB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D7BC RID: 55228
		[Token(Token = "0x400D7BC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D7BD RID: 55229
		[Token(Token = "0x400D7BD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitializeWater;

		// Token: 0x0400D7BE RID: 55230
		[Token(Token = "0x400D7BE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetDepthRTFormat;

		// Token: 0x0400D7BF RID: 55231
		[Token(Token = "0x400D7BF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AddWaterCommandBuffer;

		// Token: 0x0400D7C0 RID: 55232
		[Token(Token = "0x400D7C0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RemoveWaterCommandBuffer;

		// Token: 0x0400D7C1 RID: 55233
		[Token(Token = "0x400D7C1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D7C2 RID: 55234
		[Token(Token = "0x400D7C2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D7C3 RID: 55235
		[Token(Token = "0x400D7C3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetSceneWaterAnimator;

		// Token: 0x0400D7C4 RID: 55236
		[Token(Token = "0x400D7C4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetReplaceSpineShader;

		// Token: 0x0400D7C5 RID: 55237
		[Token(Token = "0x400D7C5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitReflection;

		// Token: 0x0400D7C6 RID: 55238
		[Token(Token = "0x400D7C6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateReflectCamera;

		// Token: 0x0400D7C7 RID: 55239
		[Token(Token = "0x400D7C7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CreateReflCamera;

		// Token: 0x0400D7C8 RID: 55240
		[Token(Token = "0x400D7C8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CalculateReflectionMatrix;

		// Token: 0x0400D7C9 RID: 55241
		[Token(Token = "0x400D7C9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CameraSpacePlane;

		// Token: 0x0400D7CA RID: 55242
		[Token(Token = "0x400D7CA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
