using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Gyro
{
	// Token: 0x020016EB RID: 5867
	[Token(Token = "0x20016EB")]
	public class CameraGyroController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06009495 RID: 38037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009495")]
		[Address(RVA = "0x3101A40", Offset = "0x3100640", VA = "0x183101A40")]
		public void SetAutoUpdate(bool enable)
		{
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00039E10 File Offset: 0x00038010
		[Token(Token = "0x6009496")]
		[Address(RVA = "0x31019E0", Offset = "0x31005E0", VA = "0x1831019E0")]
		public bool IsStandaloneMode()
		{
			return default(bool);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009497")]
		[Address(RVA = "0x3101B80", Offset = "0x3100780", VA = "0x183101B80")]
		public void TweenToOriginalPositions(float duration, [Optional] Action tweenFinishCb)
		{
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009498")]
		[Address(RVA = "0x3101860", Offset = "0x3100460", VA = "0x183101860")]
		public void InitAndStart()
		{
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x00039E28 File Offset: 0x00038028
		[Token(Token = "0x6009499")]
		[Address(RVA = "0x31018C0", Offset = "0x31004C0", VA = "0x1831018C0")]
		public static bool IsGyroSupported()
		{
			return default(bool);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600949A")]
		[Address(RVA = "0x3101AD0", Offset = "0x31006D0", VA = "0x183101AD0")]
		protected void Start()
		{
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600949B")]
		[Address(RVA = "0x3101EA0", Offset = "0x3100AA0", VA = "0x183101EA0")]
		protected void Update()
		{
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600949C")]
		[Address(RVA = "0x31022A0", Offset = "0x3100EA0", VA = "0x1831022A0")]
		private void _EnableAutoUpdate()
		{
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600949D")]
		[Address(RVA = "0x3102670", Offset = "0x3101270", VA = "0x183102670")]
		private void _UpdateAttitude()
		{
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00039E40 File Offset: 0x00038040
		[Token(Token = "0x600949E")]
		[Address(RVA = "0x31023D0", Offset = "0x3100FD0", VA = "0x1831023D0")]
		public Vector2 _GetCameraAttitude()
		{
			return default(Vector2);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x00039E58 File Offset: 0x00038058
		[Token(Token = "0x600949F")]
		[Address(RVA = "0x3101F10", Offset = "0x3100B10", VA = "0x183101F10")]
		private Vector3 _Attitude2Offset(Vector2 maxOffset, Vector2 maxAttitude, Vector2 attitude)
		{
			return default(Vector3);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x00039E70 File Offset: 0x00038070
		[Token(Token = "0x60094A0")]
		[Address(RVA = "0x3102110", Offset = "0x3100D10", VA = "0x183102110")]
		private float _CalcSpeedFactor(Vector2 relativePos)
		{
			return 0f;
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00039E88 File Offset: 0x00038088
		[Token(Token = "0x60094A1")]
		[Address(RVA = "0x31025B0", Offset = "0x31011B0", VA = "0x1831025B0")]
		private static float _LerpMobileOffset(float end, float value)
		{
			return 0f;
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094A2")]
		[Address(RVA = "0x3102BA0", Offset = "0x31017A0", VA = "0x183102BA0")]
		public CameraGyroController()
		{
		}

		// Token: 0x04008A7F RID: 35455
		[Token(Token = "0x4008A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetCamera;

		// Token: 0x04008A80 RID: 35456
		[Token(Token = "0x4008A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraAim;

		// Token: 0x04008A81 RID: 35457
		[Token(Token = "0x4008A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 cameraOffset;

		// Token: 0x04008A82 RID: 35458
		[Token(Token = "0x4008A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 aimOffset;

		// Token: 0x04008A83 RID: 35459
		[Token(Token = "0x4008A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 maxAttitude;

		// Token: 0x04008A84 RID: 35460
		[Token(Token = "0x4008A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxSpeedFactor;

		// Token: 0x04008A85 RID: 35461
		[Token(Token = "0x4008A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float minSpeedFactor;

		// Token: 0x04008A86 RID: 35462
		[Token(Token = "0x4008A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float maxSpeedDistance;

		// Token: 0x04008A87 RID: 35463
		[Token(Token = "0x4008A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float minSpeedDistance;

		// Token: 0x04008A88 RID: 35464
		[Token(Token = "0x4008A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Additional factors to apply on standalone platforms like PC.")]
		public CameraGyroController.StandaloneFactor standalone;

		// Token: 0x04008A89 RID: 35465
		[Token(Token = "0x4008A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private Vector3 m_oriCameraPosition;

		// Token: 0x04008A8A RID: 35466
		[Token(Token = "0x4008A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private Vector3 m_oriAimPosition;

		// Token: 0x04008A8B RID: 35467
		[Token(Token = "0x4008A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CameraGyroController.UpdateType m_updateType;

		// Token: 0x04008A8C RID: 35468
		[Token(Token = "0x4008A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Tweener m_tweener;

		// Token: 0x04008A8D RID: 35469
		[Token(Token = "0x4008A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetAutoUpdate;

		// Token: 0x04008A8E RID: 35470
		[Token(Token = "0x4008A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsStandaloneMode;

		// Token: 0x04008A8F RID: 35471
		[Token(Token = "0x4008A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TweenToOriginalPositions;

		// Token: 0x04008A90 RID: 35472
		[Token(Token = "0x4008A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitAndStart;

		// Token: 0x04008A91 RID: 35473
		[Token(Token = "0x4008A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsGyroSupported;

		// Token: 0x04008A92 RID: 35474
		[Token(Token = "0x4008A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04008A93 RID: 35475
		[Token(Token = "0x4008A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008A94 RID: 35476
		[Token(Token = "0x4008A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnableAutoUpdate;

		// Token: 0x04008A95 RID: 35477
		[Token(Token = "0x4008A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateAttitude;

		// Token: 0x04008A96 RID: 35478
		[Token(Token = "0x4008A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetCameraAttitude;

		// Token: 0x04008A97 RID: 35479
		[Token(Token = "0x4008A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Attitude2Offset;

		// Token: 0x04008A98 RID: 35480
		[Token(Token = "0x4008A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalcSpeedFactor;

		// Token: 0x04008A99 RID: 35481
		[Token(Token = "0x4008A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LerpMobileOffset;

		// Token: 0x04008A9A RID: 35482
		[Token(Token = "0x4008A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016EC RID: 5868
		[Token(Token = "0x20016EC")]
		[Serializable]
		public struct StandaloneFactor
		{
			// Token: 0x04008A9B RID: 35483
			[Token(Token = "0x4008A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static readonly CameraGyroController.StandaloneFactor RECOMMENDED;

			// Token: 0x04008A9C RID: 35484
			[Token(Token = "0x4008A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			public float offset;

			// Token: 0x04008A9D RID: 35485
			[Token(Token = "0x4008A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Interpolator.EaseType speedEase;
		}

		// Token: 0x020016ED RID: 5869
		[Token(Token = "0x20016ED")]
		private enum UpdateType
		{
			// Token: 0x04008A9F RID: 35487
			[Token(Token = "0x4008A9F")]
			NONE,
			// Token: 0x04008AA0 RID: 35488
			[Token(Token = "0x4008AA0")]
			MOBILE,
			// Token: 0x04008AA1 RID: 35489
			[Token(Token = "0x4008AA1")]
			STANDALONE
		}
	}
}
