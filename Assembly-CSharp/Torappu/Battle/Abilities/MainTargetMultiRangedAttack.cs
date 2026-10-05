using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB1 RID: 10929
	[Token(Token = "0x2002AB1")]
	public class MainTargetMultiRangedAttack : MultiRangedAttack
	{
		// Token: 0x060122D4 RID: 74452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D4")]
		[Address(RVA = "0xA3E7C0", Offset = "0xA3D3C0", VA = "0x180A3E7C0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060122D5 RID: 74453 RVA: 0x0006F648 File Offset: 0x0006D848
		[Token(Token = "0x60122D5")]
		[Address(RVA = "0xA3E730", Offset = "0xA3D330", VA = "0x180A3E730", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x060122D6 RID: 74454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D6")]
		[Address(RVA = "0xA3E8D0", Offset = "0xA3D4D0", VA = "0x180A3E8D0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060122D7 RID: 74455 RVA: 0x0006F660 File Offset: 0x0006D860
		[Token(Token = "0x60122D7")]
		[Address(RVA = "0xA3E9F0", Offset = "0xA3D5F0", VA = "0x180A3E9F0", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x060122D8 RID: 74456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D8")]
		[Address(RVA = "0xA3EB20", Offset = "0xA3D720", VA = "0x180A3EB20")]
		public MainTargetMultiRangedAttack()
		{
		}

		// Token: 0x060122D9 RID: 74457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D9")]
		[Address(RVA = "0xA3E9A0", Offset = "0xA3D5A0", VA = "0x180A3E9A0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122DA RID: 74458 RVA: 0x0006F678 File Offset: 0x0006D878
		[Token(Token = "0x60122DA")]
		[Address(RVA = "0xA3E990", Offset = "0xA3D590", VA = "0x180A3E990")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x060122DB RID: 74459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122DB")]
		[Address(RVA = "0xA3E9D0", Offset = "0xA3D5D0", VA = "0x180A3E9D0")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060122DC RID: 74460 RVA: 0x0006F690 File Offset: 0x0006D890
		[Token(Token = "0x60122DC")]
		[Address(RVA = "0xA3E9E0", Offset = "0xA3D5E0", VA = "0x180A3E9E0")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04014902 RID: 84226
		[Token(Token = "0x4014902")]
		[FieldOffset(Offset = "0x2D8")]
		private int m_remainTimes;

		// Token: 0x04014903 RID: 84227
		[Token(Token = "0x4014903")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014904 RID: 84228
		[Token(Token = "0x4014904")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x04014905 RID: 84229
		[Token(Token = "0x4014905")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014906 RID: 84230
		[Token(Token = "0x4014906")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014907 RID: 84231
		[Token(Token = "0x4014907")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
