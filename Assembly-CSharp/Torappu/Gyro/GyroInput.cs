using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Gyro
{
	// Token: 0x020016F2 RID: 5874
	[Token(Token = "0x20016F2")]
	public class GyroInput : SingletonMonoBehaviour<GyroInput>, ISingletonNotAutoCreate
	{
		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x00039EE8 File Offset: 0x000380E8
		[Token(Token = "0x17000FEA")]
		[Inspect]
		public Vector2 simpleAttitude
		{
			[Token(Token = "0x60094B2")]
			[Address(RVA = "0x3106660", Offset = "0x3105260", VA = "0x183106660")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060094B3 RID: 38067 RVA: 0x00039F00 File Offset: 0x00038100
		[Token(Token = "0x17000FEB")]
		[Inspect]
		public bool gyroSupported
		{
			[Token(Token = "0x60094B3")]
			[Address(RVA = "0x3106600", Offset = "0x3105200", VA = "0x183106600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B4")]
		[Address(RVA = "0x3105F40", Offset = "0x3104B40", VA = "0x183105F40", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B5")]
		[Address(RVA = "0x3105FE0", Offset = "0x3104BE0", VA = "0x183105FE0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B6")]
		[Address(RVA = "0x3106100", Offset = "0x3104D00", VA = "0x183106100")]
		private void Start()
		{
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B7")]
		[Address(RVA = "0x3105B80", Offset = "0x3104780", VA = "0x183105B80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x00039F18 File Offset: 0x00038118
		[Token(Token = "0x60094B8")]
		[Address(RVA = "0x31060A0", Offset = "0x3104CA0", VA = "0x1831060A0")]
		public bool SetOriginRotation()
		{
			return default(bool);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00039F30 File Offset: 0x00038130
		[Token(Token = "0x60094B9")]
		[Address(RVA = "0x3106280", Offset = "0x3104E80", VA = "0x183106280")]
		private static Quaternion _GetNormalized(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00039F48 File Offset: 0x00038148
		[Token(Token = "0x60094BA")]
		[Address(RVA = "0x31061B0", Offset = "0x3104DB0", VA = "0x1831061B0")]
		private static Quaternion _GetInverse(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x00039F60 File Offset: 0x00038160
		[Token(Token = "0x60094BB")]
		[Address(RVA = "0x31063B0", Offset = "0x3104FB0", VA = "0x1831063B0")]
		private static bool _IsValidQuaternion(Quaternion q)
		{
			return default(bool);
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094BC")]
		[Address(RVA = "0x3106580", Offset = "0x3105180", VA = "0x183106580")]
		public GyroInput()
		{
		}

		// Token: 0x04008AB9 RID: 35513
		[Token(Token = "0x4008AB9")]
		private const double BOUNCE_BACK_SPEED = 1.0;

		// Token: 0x04008ABA RID: 35514
		[Token(Token = "0x4008ABA")]
		private const float MIN_ROTATE_SPEED = 0.1f;

		// Token: 0x04008ABB RID: 35515
		[Token(Token = "0x4008ABB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x04008ABC RID: 35516
		[Token(Token = "0x4008ABC")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 m_simpleAttitude;

		// Token: 0x04008ABD RID: 35517
		[Token(Token = "0x4008ABD")]
		[FieldOffset(Offset = "0x28")]
		private double m_rotateX;

		// Token: 0x04008ABE RID: 35518
		[Token(Token = "0x4008ABE")]
		[FieldOffset(Offset = "0x30")]
		private double m_rotateY;

		// Token: 0x04008ABF RID: 35519
		[Token(Token = "0x4008ABF")]
		[FieldOffset(Offset = "0x38")]
		private bool m_gyroSupported;

		// Token: 0x04008AC0 RID: 35520
		[Token(Token = "0x4008AC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_simpleAttitude;

		// Token: 0x04008AC1 RID: 35521
		[Token(Token = "0x4008AC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gyroSupported;

		// Token: 0x04008AC2 RID: 35522
		[Token(Token = "0x4008AC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04008AC3 RID: 35523
		[Token(Token = "0x4008AC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008AC4 RID: 35524
		[Token(Token = "0x4008AC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04008AC5 RID: 35525
		[Token(Token = "0x4008AC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04008AC6 RID: 35526
		[Token(Token = "0x4008AC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetOriginRotation;

		// Token: 0x04008AC7 RID: 35527
		[Token(Token = "0x4008AC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetNormalized;

		// Token: 0x04008AC8 RID: 35528
		[Token(Token = "0x4008AC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetInverse;

		// Token: 0x04008AC9 RID: 35529
		[Token(Token = "0x4008AC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsValidQuaternion;

		// Token: 0x04008ACA RID: 35530
		[Token(Token = "0x4008ACA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
