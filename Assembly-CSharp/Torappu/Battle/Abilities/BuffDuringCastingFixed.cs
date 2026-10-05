using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BDB RID: 11227
	[Token(Token = "0x2002BDB")]
	public class BuffDuringCastingFixed : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06012F52 RID: 77650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F52")]
		[Address(RVA = "0xADBC00", Offset = "0xADA800", VA = "0x180ADBC00", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012F53 RID: 77651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F53")]
		[Address(RVA = "0xADBB80", Offset = "0xADA780", VA = "0x180ADBB80", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012F54 RID: 77652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F54")]
		[Address(RVA = "0xADBB10", Offset = "0xADA710", VA = "0x180ADBB10", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F55 RID: 77653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F55")]
		[Address(RVA = "0xADBA80", Offset = "0xADA680", VA = "0x180ADBA80", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F56 RID: 77654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F56")]
		[Address(RVA = "0xADBE00", Offset = "0xADAA00", VA = "0x180ADBE00")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06012F57 RID: 77655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F57")]
		[Address(RVA = "0xADBD70", Offset = "0xADA970", VA = "0x180ADBD70", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F58 RID: 77656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F58")]
		[Address(RVA = "0xADBEF0", Offset = "0xADAAF0", VA = "0x180ADBEF0")]
		public BuffDuringCastingFixed()
		{
		}

		// Token: 0x06012F59 RID: 77657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F59")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012F5A RID: 77658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F5A")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012F5B RID: 77659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F5B")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401565A RID: 87642
		[Token(Token = "0x401565A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401565B RID: 87643
		[Token(Token = "0x401565B")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_buffUid;

		// Token: 0x0401565C RID: 87644
		[Token(Token = "0x401565C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401565D RID: 87645
		[Token(Token = "0x401565D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401565E RID: 87646
		[Token(Token = "0x401565E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401565F RID: 87647
		[Token(Token = "0x401565F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015660 RID: 87648
		[Token(Token = "0x4015660")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04015661 RID: 87649
		[Token(Token = "0x4015661")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015662 RID: 87650
		[Token(Token = "0x4015662")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
