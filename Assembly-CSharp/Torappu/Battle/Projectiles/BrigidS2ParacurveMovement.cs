using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D4 RID: 10708
	[Token(Token = "0x20029D4")]
	public class BrigidS2ParacurveMovement : ParacurveMovement
	{
		// Token: 0x06011C08 RID: 72712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C08")]
		[Address(RVA = "0x999080", Offset = "0x997C80", VA = "0x180999080", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011C09 RID: 72713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C09")]
		[Address(RVA = "0x999240", Offset = "0x997E40", VA = "0x180999240", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C0A RID: 72714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C0A")]
		[Address(RVA = "0x999020", Offset = "0x997C20", VA = "0x180999020", Slot = "28")]
		protected override void DoCheckReached()
		{
		}

		// Token: 0x06011C0B RID: 72715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C0B")]
		[Address(RVA = "0x9991D0", Offset = "0x997DD0", VA = "0x1809991D0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011C0C RID: 72716 RVA: 0x0006CB88 File Offset: 0x0006AD88
		[Token(Token = "0x6011C0C")]
		[Address(RVA = "0x9994A0", Offset = "0x9980A0", VA = "0x1809994A0")]
		private bool _CheckProjectileMissTarget()
		{
			return default(bool);
		}

		// Token: 0x06011C0D RID: 72717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C0D")]
		[Address(RVA = "0x999600", Offset = "0x998200", VA = "0x180999600")]
		private void _DoCheckReachedUpdateState(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C0E RID: 72718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C0E")]
		[Address(RVA = "0x999A40", Offset = "0x998640", VA = "0x180999A40")]
		public BrigidS2ParacurveMovement()
		{
		}

		// Token: 0x06011C0F RID: 72719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C0F")]
		[Address(RVA = "0x999480", Offset = "0x998080", VA = "0x180999480")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011C10 RID: 72720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C10")]
		[Address(RVA = "0x999490", Offset = "0x998090", VA = "0x180999490")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C11 RID: 72721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C11")]
		[Address(RVA = "0x9992D0", Offset = "0x997ED0", VA = "0x1809992D0")]
		private void <>xLuaBaseProxy_DoCheckReached()
		{
		}

		// Token: 0x06011C12 RID: 72722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C12")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013EA2 RID: 81570
		[Token(Token = "0x4013EA2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x04013EA3 RID: 81571
		[Token(Token = "0x4013EA3")]
		[FieldOffset(Offset = "0x150")]
		private bool m_hasReachedTargetOnce;

		// Token: 0x04013EA4 RID: 81572
		[Token(Token = "0x4013EA4")]
		[FieldOffset(Offset = "0x151")]
		private bool m_inReachedDelayState;

		// Token: 0x04013EA5 RID: 81573
		[Token(Token = "0x4013EA5")]
		[FieldOffset(Offset = "0x152")]
		private bool m_leaveFirstTarget;

		// Token: 0x04013EA6 RID: 81574
		[Token(Token = "0x4013EA6")]
		[FieldOffset(Offset = "0x154")]
		private float m_delayTimer;

		// Token: 0x04013EA7 RID: 81575
		[Token(Token = "0x4013EA7")]
		[FieldOffset(Offset = "0x158")]
		private Entity m_cacheTraceTarget;

		// Token: 0x04013EA8 RID: 81576
		[Token(Token = "0x4013EA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013EA9 RID: 81577
		[Token(Token = "0x4013EA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013EAA RID: 81578
		[Token(Token = "0x4013EAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013EAB RID: 81579
		[Token(Token = "0x4013EAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013EAC RID: 81580
		[Token(Token = "0x4013EAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckProjectileMissTarget;

		// Token: 0x04013EAD RID: 81581
		[Token(Token = "0x4013EAD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoCheckReachedUpdateState;

		// Token: 0x04013EAE RID: 81582
		[Token(Token = "0x4013EAE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
