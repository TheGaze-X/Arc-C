using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002065 RID: 8293
	[Token(Token = "0x2002065")]
	[ExecuteInEditMode]
	public class SceneShaderEffect : BaseSceneEffect
	{
		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600CC35 RID: 52277 RVA: 0x00049B60 File Offset: 0x00047D60
		[Token(Token = "0x17001836")]
		protected bool isReflect
		{
			[Token(Token = "0x600CC35")]
			[Address(RVA = "0x34E4550", Offset = "0x34E3150", VA = "0x1834E4550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC36")]
		[Address(RVA = "0x34E2DE0", Offset = "0x34E19E0", VA = "0x1834E2DE0", Slot = "6")]
		protected override void OnLateInit()
		{
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC37")]
		[Address(RVA = "0x34E2940", Offset = "0x34E1540", VA = "0x1834E2940", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC38")]
		[Address(RVA = "0x34E27E0", Offset = "0x34E13E0", VA = "0x1834E27E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC39")]
		[Address(RVA = "0x34E3660", Offset = "0x34E2260", VA = "0x1834E3660")]
		private Camera _CreateReflCamera(Camera sceneCamera)
		{
			return null;
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC3A")]
		[Address(RVA = "0x34E2450", Offset = "0x34E1050", VA = "0x1834E2450")]
		private void InitReflection()
		{
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC3B")]
		[Address(RVA = "0x34E22B0", Offset = "0x34E0EB0", VA = "0x1834E22B0")]
		private void ClearReflection()
		{
		}

		// Token: 0x0600CC3C RID: 52284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC3C")]
		[Address(RVA = "0x34E3080", Offset = "0x34E1C80", VA = "0x1834E3080")]
		private void UpdateReflection()
		{
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC3D")]
		[Address(RVA = "0x34E3AC0", Offset = "0x34E26C0", VA = "0x1834E3AC0")]
		private void _UpdateReflectCamera()
		{
		}

		// Token: 0x0600CC3E RID: 52286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC3E")]
		[Address(RVA = "0x34E3190", Offset = "0x34E1D90", VA = "0x1834E3190")]
		private void _CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x0600CC3F RID: 52287 RVA: 0x00049B78 File Offset: 0x00047D78
		[Token(Token = "0x600CC3F")]
		[Address(RVA = "0x34E3340", Offset = "0x34E1F40", VA = "0x1834E3340")]
		private Vector4 _CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
		{
			return default(Vector4);
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC40")]
		[Address(RVA = "0x34E2FD0", Offset = "0x34E1BD0", VA = "0x1834E2FD0")]
		private void UpdateDepth()
		{
		}

		// Token: 0x0600CC41 RID: 52289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC41")]
		[Address(RVA = "0x34E2000", Offset = "0x34E0C00", VA = "0x1834E2000")]
		private void AddCopyColorBuffer(Camera camera)
		{
		}

		// Token: 0x0600CC42 RID: 52290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC42")]
		[Address(RVA = "0x34E2E40", Offset = "0x34E1A40", VA = "0x1834E2E40")]
		private void RemoveCopyColorBuffer(Camera camera)
		{
		}

		// Token: 0x0600CC43 RID: 52291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC43")]
		[Address(RVA = "0x34E2F40", Offset = "0x34E1B40", VA = "0x1834E2F40")]
		private void UpdateCopyColorBuffer()
		{
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC44")]
		[Address(RVA = "0x34E2B90", Offset = "0x34E1790", VA = "0x1834E2B90", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CC45 RID: 52293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC45")]
		[Address(RVA = "0x34E35F0", Offset = "0x34E21F0", VA = "0x1834E35F0")]
		private void _ClearCurrentCamera()
		{
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC46")]
		[Address(RVA = "0x34E4460", Offset = "0x34E3060", VA = "0x1834E4460")]
		public SceneShaderEffect()
		{
		}

		// Token: 0x0600CC47 RID: 52295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC47")]
		[Address(RVA = "0x50E150", Offset = "0x50CD50", VA = "0x18050E150")]
		private void <>xLuaBaseProxy_OnLateInit()
		{
		}

		// Token: 0x0600CC48 RID: 52296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC48")]
		[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC49")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D6B0 RID: 54960
		[Token(Token = "0x400D6B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _CopyColorbuffer;

		// Token: 0x0400D6B1 RID: 54961
		[Token(Token = "0x400D6B1")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _Depth;

		// Token: 0x0400D6B2 RID: 54962
		[Token(Token = "0x400D6B2")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _Reflect;

		// Token: 0x0400D6B3 RID: 54963
		[Token(Token = "0x400D6B3")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_camera;

		// Token: 0x0400D6B4 RID: 54964
		[Token(Token = "0x400D6B4")]
		[FieldOffset(Offset = "0x30")]
		private CommandBuffer m_copyColor_cmd;

		// Token: 0x0400D6B5 RID: 54965
		[Token(Token = "0x400D6B5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_cmd_inited;

		// Token: 0x0400D6B6 RID: 54966
		[Token(Token = "0x400D6B6")]
		[FieldOffset(Offset = "0x40")]
		private Camera[] sceneCameras;

		// Token: 0x0400D6B7 RID: 54967
		[Token(Token = "0x400D6B7")]
		[FieldOffset(Offset = "0x48")]
		private bool isReflectInit;

		// Token: 0x0400D6B8 RID: 54968
		[Token(Token = "0x400D6B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("isReflect")]
		private GameObject reflectPlane;

		// Token: 0x0400D6B9 RID: 54969
		[Token(Token = "0x400D6B9")]
		[FieldOffset(Offset = "0x58")]
		private RenderTexture reflectRT;

		// Token: 0x0400D6BA RID: 54970
		[Token(Token = "0x400D6BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Inspect("isReflect")]
		private Shader replaceShader;

		// Token: 0x0400D6BB RID: 54971
		[Token(Token = "0x400D6BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Inspect("isReflect")]
		private Material reflectMat;

		// Token: 0x0400D6BC RID: 54972
		[Token(Token = "0x400D6BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(1f, 4f)]
		[Inspect("isReflect")]
		private int downScale;

		// Token: 0x0400D6BD RID: 54973
		[Token(Token = "0x400D6BD")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Inspect("isReflect")]
		public float refPlaneOffset;

		// Token: 0x0400D6BE RID: 54974
		[Token(Token = "0x400D6BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Range(0f, 7f)]
		[Inspect("isReflect")]
		private int reflectRoughness;

		// Token: 0x0400D6BF RID: 54975
		[Token(Token = "0x400D6BF")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Range(0f, 2f)]
		[Inspect("isReflect")]
		private float reflectIntensity;

		// Token: 0x0400D6C0 RID: 54976
		[Token(Token = "0x400D6C0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Inspect("isReflect")]
		private bool isRefUpdate;

		// Token: 0x0400D6C1 RID: 54977
		[Token(Token = "0x400D6C1")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_reflCamera;

		// Token: 0x0400D6C2 RID: 54978
		[Token(Token = "0x400D6C2")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 m_oldPos;

		// Token: 0x0400D6C3 RID: 54979
		[Token(Token = "0x400D6C3")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_oldEuler;

		// Token: 0x0400D6C4 RID: 54980
		[Token(Token = "0x400D6C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReflect;

		// Token: 0x0400D6C5 RID: 54981
		[Token(Token = "0x400D6C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLateInit;

		// Token: 0x0400D6C6 RID: 54982
		[Token(Token = "0x400D6C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D6C7 RID: 54983
		[Token(Token = "0x400D6C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0400D6C8 RID: 54984
		[Token(Token = "0x400D6C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateReflCamera;

		// Token: 0x0400D6C9 RID: 54985
		[Token(Token = "0x400D6C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitReflection;

		// Token: 0x0400D6CA RID: 54986
		[Token(Token = "0x400D6CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearReflection;

		// Token: 0x0400D6CB RID: 54987
		[Token(Token = "0x400D6CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateReflection;

		// Token: 0x0400D6CC RID: 54988
		[Token(Token = "0x400D6CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateReflectCamera;

		// Token: 0x0400D6CD RID: 54989
		[Token(Token = "0x400D6CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateReflectionMatrix;

		// Token: 0x0400D6CE RID: 54990
		[Token(Token = "0x400D6CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CameraSpacePlane;

		// Token: 0x0400D6CF RID: 54991
		[Token(Token = "0x400D6CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateDepth;

		// Token: 0x0400D6D0 RID: 54992
		[Token(Token = "0x400D6D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AddCopyColorBuffer;

		// Token: 0x0400D6D1 RID: 54993
		[Token(Token = "0x400D6D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RemoveCopyColorBuffer;

		// Token: 0x0400D6D2 RID: 54994
		[Token(Token = "0x400D6D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateCopyColorBuffer;

		// Token: 0x0400D6D3 RID: 54995
		[Token(Token = "0x400D6D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D6D4 RID: 54996
		[Token(Token = "0x400D6D4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearCurrentCamera;

		// Token: 0x0400D6D5 RID: 54997
		[Token(Token = "0x400D6D5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
