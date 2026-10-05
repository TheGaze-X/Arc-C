using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029CC RID: 10700
	[Token(Token = "0x20029CC")]
	public class AdvancedMovementWithRandomBodyOffset : AdvancedMovement
	{
		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06011BB6 RID: 72630 RVA: 0x0006CA38 File Offset: 0x0006AC38
		[Token(Token = "0x1700271D")]
		public bool isValid
		{
			[Token(Token = "0x6011BB6")]
			[Address(RVA = "0x994120", Offset = "0x992D20", VA = "0x180994120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011BB7 RID: 72631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB7")]
		[Address(RVA = "0x993980", Offset = "0x992580", VA = "0x180993980", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011BB8 RID: 72632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB8")]
		[Address(RVA = "0x993B70", Offset = "0x992770", VA = "0x180993B70", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BB9 RID: 72633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB9")]
		[Address(RVA = "0x993C50", Offset = "0x992850", VA = "0x180993C50", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BBA RID: 72634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BBA")]
		[Address(RVA = "0x994080", Offset = "0x992C80", VA = "0x180994080")]
		public AdvancedMovementWithRandomBodyOffset()
		{
		}

		// Token: 0x06011BBB RID: 72635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BBB")]
		[Address(RVA = "0x9936C0", Offset = "0x9922C0", VA = "0x1809936C0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011BBC RID: 72636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BBC")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BBD RID: 72637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BBD")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013E2C RID: 81452
		[Token(Token = "0x4013E2C")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("RandomBodyOffset")]
		private Vector3 _randomRange;

		// Token: 0x04013E2D RID: 81453
		[Token(Token = "0x4013E2D")]
		[FieldOffset(Offset = "0x14C")]
		private Vector3 m_randomTargetOffset;

		// Token: 0x04013E2E RID: 81454
		[Token(Token = "0x4013E2E")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 m_bodyMapPosition;

		// Token: 0x04013E2F RID: 81455
		[Token(Token = "0x4013E2F")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 m_bodyDirection;

		// Token: 0x04013E30 RID: 81456
		[Token(Token = "0x4013E30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04013E31 RID: 81457
		[Token(Token = "0x4013E31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013E32 RID: 81458
		[Token(Token = "0x4013E32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E33 RID: 81459
		[Token(Token = "0x4013E33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E34 RID: 81460
		[Token(Token = "0x4013E34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
