using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002490 RID: 9360
	[Token(Token = "0x2002490")]
	public class OverrideAttackOrCombatTalent : Talent
	{
		// Token: 0x0600F0A9 RID: 61609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0A9")]
		[Address(RVA = "0x676B20", Offset = "0x675720", VA = "0x180676B20", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0AA RID: 61610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AA")]
		[Address(RVA = "0x676D10", Offset = "0x675910", VA = "0x180676D10", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0AB RID: 61611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AB")]
		[Address(RVA = "0x676F00", Offset = "0x675B00", VA = "0x180676F00")]
		public OverrideAttackOrCombatTalent()
		{
		}

		// Token: 0x0600F0AC RID: 61612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AC")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0AD RID: 61613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AD")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010A2D RID: 68141
		[Token(Token = "0x4010A2D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _overrideAttack;

		// Token: 0x04010A2E RID: 68142
		[Token(Token = "0x4010A2E")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _overrideCombat;

		// Token: 0x04010A2F RID: 68143
		[Token(Token = "0x4010A2F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TargetTrigger _trigger;

		// Token: 0x04010A30 RID: 68144
		[Token(Token = "0x4010A30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A31 RID: 68145
		[Token(Token = "0x4010A31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A32 RID: 68146
		[Token(Token = "0x4010A32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
