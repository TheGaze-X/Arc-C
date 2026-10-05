using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA9 RID: 10921
	[Token(Token = "0x2002AA9")]
	public class CooledChargeRangedAttack : ChargeRangedAttack
	{
		// Token: 0x0601227D RID: 74365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601227D")]
		[Address(RVA = "0xA38CE0", Offset = "0xA378E0", VA = "0x180A38CE0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601227E RID: 74366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601227E")]
		[Address(RVA = "0xA38B30", Offset = "0xA37730", VA = "0x180A38B30", Slot = "129")]
		public override void AddChargeTimes()
		{
		}

		// Token: 0x0601227F RID: 74367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601227F")]
		[Address(RVA = "0xA38E00", Offset = "0xA37A00", VA = "0x180A38E00", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012280 RID: 74368 RVA: 0x0006F408 File Offset: 0x0006D608
		[Token(Token = "0x6012280")]
		[Address(RVA = "0xA38BF0", Offset = "0xA377F0", VA = "0x180A38BF0", Slot = "130")]
		public override bool CanCharge()
		{
			return default(bool);
		}

		// Token: 0x06012281 RID: 74369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012281")]
		[Address(RVA = "0xA38F00", Offset = "0xA37B00", VA = "0x180A38F00")]
		public CooledChargeRangedAttack()
		{
		}

		// Token: 0x06012282 RID: 74370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012282")]
		[Address(RVA = "0xA38EC0", Offset = "0xA37AC0", VA = "0x180A38EC0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012283 RID: 74371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012283")]
		[Address(RVA = "0xA373C0", Offset = "0xA35FC0", VA = "0x180A373C0")]
		private void <>xLuaBaseProxy_AddChargeTimes()
		{
		}

		// Token: 0x06012284 RID: 74372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012284")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012285 RID: 74373 RVA: 0x0006F420 File Offset: 0x0006D620
		[Token(Token = "0x6012285")]
		[Address(RVA = "0xA374C0", Offset = "0xA360C0", VA = "0x180A374C0")]
		private bool <>xLuaBaseProxy_CanCharge()
		{
			return default(bool);
		}

		// Token: 0x040148A3 RID: 84131
		[Token(Token = "0x40148A3")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Group("Extra")]
		private float _chargeCoolDown;

		// Token: 0x040148A4 RID: 84132
		[Token(Token = "0x40148A4")]
		[FieldOffset(Offset = "0x294")]
		private float m_chargeCoolDown;

		// Token: 0x040148A5 RID: 84133
		[Token(Token = "0x40148A5")]
		[FieldOffset(Offset = "0x298")]
		private float m_remainingTime;

		// Token: 0x040148A6 RID: 84134
		[Token(Token = "0x40148A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040148A7 RID: 84135
		[Token(Token = "0x40148A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddChargeTimes;

		// Token: 0x040148A8 RID: 84136
		[Token(Token = "0x40148A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040148A9 RID: 84137
		[Token(Token = "0x40148A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CanCharge;

		// Token: 0x040148AA RID: 84138
		[Token(Token = "0x40148AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
