using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002067 RID: 8295
	[Token(Token = "0x2002067")]
	[RequireComponent(typeof(Camera))]
	public class ShadowCamera : BaseSceneEffect
	{
		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x0600CC4B RID: 52299 RVA: 0x00049B90 File Offset: 0x00047D90
		[Token(Token = "0x17001837")]
		private bool needFollowMainCamera
		{
			[Token(Token = "0x600CC4B")]
			[Address(RVA = "0x34E98D0", Offset = "0x34E84D0", VA = "0x1834E98D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x00049BA8 File Offset: 0x00047DA8
		[Token(Token = "0x17001838")]
		private bool recalculateShadowCamSize
		{
			[Token(Token = "0x600CC4C")]
			[Address(RVA = "0x34E9940", Offset = "0x34E8540", VA = "0x1834E9940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600CC4D RID: 52301 RVA: 0x00049BC0 File Offset: 0x00047DC0
		[Token(Token = "0x17001839")]
		private bool ProfileLegal
		{
			[Token(Token = "0x600CC4D")]
			[Address(RVA = "0x34E9790", Offset = "0x34E8390", VA = "0x1834E9790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC4E")]
		[Address(RVA = "0x34E6F90", Offset = "0x34E5B90", VA = "0x1834E6F90", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC4F")]
		[Address(RVA = "0x34E6F20", Offset = "0x34E5B20", VA = "0x1834E6F20", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CC50 RID: 52304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC50")]
		[Address(RVA = "0x34E84C0", Offset = "0x34E70C0", VA = "0x1834E84C0")]
		private void _FollowMainCamera()
		{
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC51")]
		[Address(RVA = "0x34E8A00", Offset = "0x34E7600", VA = "0x1834E8A00")]
		private void _OptimizeShadowCameraSize()
		{
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC52")]
		[Address(RVA = "0x34E8880", Offset = "0x34E7480", VA = "0x1834E8880")]
		private void _InitializeCameraParam()
		{
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC53")]
		[Address(RVA = "0x34E7330", Offset = "0x34E5F30", VA = "0x1834E7330", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC54")]
		[Address(RVA = "0x34E7890", Offset = "0x34E6490", VA = "0x1834E7890")]
		public void Update()
		{
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC55")]
		[Address(RVA = "0x34E7C70", Offset = "0x34E6870", VA = "0x1834E7C70")]
		private void _CalculateAndApplyShadowMatrix()
		{
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC56")]
		[Address(RVA = "0x34E71C0", Offset = "0x34E5DC0", VA = "0x1834E71C0", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00049BD8 File Offset: 0x00047DD8
		[Token(Token = "0x600CC57")]
		[Address(RVA = "0x34E9460", Offset = "0x34E8060", VA = "0x1834E9460")]
		private bool _TryRecalculateShadowCamSizeOffset(out float orthographicSize, out Vector3 offset)
		{
			return default(bool);
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x00049BF0 File Offset: 0x00047DF0
		[Token(Token = "0x600CC58")]
		[Address(RVA = "0x34E82B0", Offset = "0x34E6EB0", VA = "0x1834E82B0")]
		private float _CalculateShadowCamSize(Vector3[] mainCamGroundIntersection)
		{
			return 0f;
		}

		// Token: 0x0600CC59 RID: 52313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC59")]
		[Address(RVA = "0x34E7980", Offset = "0x34E6580", VA = "0x1834E7980")]
		private void _AlignShadowCamWithMainCam(Vector3 offset)
		{
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x00049C08 File Offset: 0x00047E08
		[Token(Token = "0x600CC5A")]
		[Address(RVA = "0x34E7F50", Offset = "0x34E6B50", VA = "0x1834E7F50")]
		private Vector3 _CalculateGroundIntersectionCenter(Vector3[] groundIntersections)
		{
			return default(Vector3);
		}

		// Token: 0x0600CC5B RID: 52315 RVA: 0x00049C20 File Offset: 0x00047E20
		[Token(Token = "0x600CC5B")]
		[Address(RVA = "0x34E8E60", Offset = "0x34E7A60", VA = "0x1834E8E60")]
		private bool _TryCalculateFrustumGroundIntersections(Camera camera, Vector3[] listToFill)
		{
			return default(bool);
		}

		// Token: 0x0600CC5C RID: 52316 RVA: 0x00049C38 File Offset: 0x00047E38
		[Token(Token = "0x600CC5C")]
		[Address(RVA = "0x34E86E0", Offset = "0x34E72E0", VA = "0x1834E86E0")]
		private Plane _GetGroundPlane()
		{
			return default(Plane);
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x00049C50 File Offset: 0x00047E50
		[Token(Token = "0x600CC5D")]
		[Address(RVA = "0x34E8B50", Offset = "0x34E7750", VA = "0x1834E8B50")]
		private bool _TryCalcPlaneIntersection(Plane plane, Vector3 p1, Vector3 p2, out Vector3 intersection)
		{
			return default(bool);
		}

		// Token: 0x0600CC5E RID: 52318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC5E")]
		[Address(RVA = "0x34E8110", Offset = "0x34E6D10", VA = "0x1834E8110")]
		private void _CalculateOrthoFrustumCorners(float orthoSize, float aspect, float distance, Vector3[] arrayToFill)
		{
		}

		// Token: 0x0600CC5F RID: 52319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC5F")]
		[Address(RVA = "0x34E9670", Offset = "0x34E8270", VA = "0x1834E9670")]
		public ShadowCamera()
		{
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC60")]
		[Address(RVA = "0x50E130", Offset = "0x50CD30", VA = "0x18050E130")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC61")]
		[Address(RVA = "0x34D2340", Offset = "0x34D0F40", VA = "0x1834D2340")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0600CC62 RID: 52322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC62")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CC63 RID: 52323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC63")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D6DA RID: 55002
		[Token(Token = "0x400D6DA")]
		private const float GROUND_Z = 0f;

		// Token: 0x0400D6DB RID: 55003
		[Token(Token = "0x400D6DB")]
		private const float GROUND_Y = 0f;

		// Token: 0x0400D6DC RID: 55004
		[Token(Token = "0x400D6DC")]
		private const float SIZE_PADDING = 1f;

		// Token: 0x0400D6DD RID: 55005
		[Token(Token = "0x400D6DD")]
		private const float MIN_SIZE = 5f;

		// Token: 0x0400D6DE RID: 55006
		[Token(Token = "0x400D6DE")]
		private const float MAX_SIZE = 30f;

		// Token: 0x0400D6DF RID: 55007
		[Token(Token = "0x400D6DF")]
		private const string RT_NAME_SHADOW = "HG SHADOW RT";

		// Token: 0x0400D6E0 RID: 55008
		[Token(Token = "0x400D6E0")]
		[FieldOffset(Offset = "0x20")]
		public HGShadowProfile _shadowProfile;

		// Token: 0x0400D6E1 RID: 55009
		[Token(Token = "0x400D6E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isUpdating;

		// Token: 0x0400D6E2 RID: 55010
		[Token(Token = "0x400D6E2")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _followMainCamera;

		// Token: 0x0400D6E3 RID: 55011
		[Token(Token = "0x400D6E3")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _fade;

		// Token: 0x0400D6E4 RID: 55012
		[Token(Token = "0x400D6E4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 0.05f)]
		[HideInInspector]
		private float _fadeDistance;

		// Token: 0x0400D6E5 RID: 55013
		[Token(Token = "0x400D6E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _optimizeShadowCamSize;

		// Token: 0x0400D6E6 RID: 55014
		[Token(Token = "0x400D6E6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Inspect("recalculateShadowCamSize")]
		private ShadowCamera.GroundPlaneMode _groundPlaneMode;

		// Token: 0x0400D6E7 RID: 55015
		[Token(Token = "0x400D6E7")]
		[FieldOffset(Offset = "0x38")]
		private bool m_needFollowMainCamera;

		// Token: 0x0400D6E8 RID: 55016
		[Token(Token = "0x400D6E8")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_cameraOffset;

		// Token: 0x0400D6E9 RID: 55017
		[Token(Token = "0x400D6E9")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_shadowCamera;

		// Token: 0x0400D6EA RID: 55018
		[Token(Token = "0x400D6EA")]
		[FieldOffset(Offset = "0x50")]
		private Camera m_mainCamera;

		// Token: 0x0400D6EB RID: 55019
		[Token(Token = "0x400D6EB")]
		[FieldOffset(Offset = "0x58")]
		private RenderTexture m_renderTarget;

		// Token: 0x0400D6EC RID: 55020
		[Token(Token = "0x400D6EC")]
		[FieldOffset(Offset = "0x60")]
		private Matrix4x4 m_posToUV;

		// Token: 0x0400D6ED RID: 55021
		[Token(Token = "0x400D6ED")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Vector3[] m_frustumCornersNear;

		// Token: 0x0400D6EE RID: 55022
		[Token(Token = "0x400D6EE")]
		[FieldOffset(Offset = "0xA8")]
		private readonly Vector3[] m_frustumCornersFar;

		// Token: 0x0400D6EF RID: 55023
		[Token(Token = "0x400D6EF")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Vector3[] m_groundIntersections;

		// Token: 0x0400D6F0 RID: 55024
		[Token(Token = "0x400D6F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needFollowMainCamera;

		// Token: 0x0400D6F1 RID: 55025
		[Token(Token = "0x400D6F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_recalculateShadowCamSize;

		// Token: 0x0400D6F2 RID: 55026
		[Token(Token = "0x400D6F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ProfileLegal;

		// Token: 0x0400D6F3 RID: 55027
		[Token(Token = "0x400D6F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D6F4 RID: 55028
		[Token(Token = "0x400D6F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D6F5 RID: 55029
		[Token(Token = "0x400D6F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FollowMainCamera;

		// Token: 0x0400D6F6 RID: 55030
		[Token(Token = "0x400D6F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OptimizeShadowCameraSize;

		// Token: 0x0400D6F7 RID: 55031
		[Token(Token = "0x400D6F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitializeCameraParam;

		// Token: 0x0400D6F8 RID: 55032
		[Token(Token = "0x400D6F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D6F9 RID: 55033
		[Token(Token = "0x400D6F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D6FA RID: 55034
		[Token(Token = "0x400D6FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateAndApplyShadowMatrix;

		// Token: 0x0400D6FB RID: 55035
		[Token(Token = "0x400D6FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D6FC RID: 55036
		[Token(Token = "0x400D6FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryRecalculateShadowCamSizeOffset;

		// Token: 0x0400D6FD RID: 55037
		[Token(Token = "0x400D6FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalculateShadowCamSize;

		// Token: 0x0400D6FE RID: 55038
		[Token(Token = "0x400D6FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AlignShadowCamWithMainCam;

		// Token: 0x0400D6FF RID: 55039
		[Token(Token = "0x400D6FF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalculateGroundIntersectionCenter;

		// Token: 0x0400D700 RID: 55040
		[Token(Token = "0x400D700")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryCalculateFrustumGroundIntersections;

		// Token: 0x0400D701 RID: 55041
		[Token(Token = "0x400D701")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetGroundPlane;

		// Token: 0x0400D702 RID: 55042
		[Token(Token = "0x400D702")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryCalcPlaneIntersection;

		// Token: 0x0400D703 RID: 55043
		[Token(Token = "0x400D703")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CalculateOrthoFrustumCorners;

		// Token: 0x0400D704 RID: 55044
		[Token(Token = "0x400D704")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002068 RID: 8296
		[Token(Token = "0x2002068")]
		public enum GroundPlaneMode
		{
			// Token: 0x0400D706 RID: 55046
			[Token(Token = "0x400D706")]
			XOY,
			// Token: 0x0400D707 RID: 55047
			[Token(Token = "0x400D707")]
			XOZ
		}
	}
}
