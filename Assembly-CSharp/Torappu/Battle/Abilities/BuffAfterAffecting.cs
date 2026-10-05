using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD9 RID: 11225
	[Token(Token = "0x2002BD9")]
	public class BuffAfterAffecting : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06012F41 RID: 77633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F41")]
		[Address(RVA = "0xADB960", Offset = "0xADA560", VA = "0x180ADB960", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012F42 RID: 77634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F42")]
		[Address(RVA = "0xADB5A0", Offset = "0xADA1A0", VA = "0x180ADB5A0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F43 RID: 77635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F43")]
		[Address(RVA = "0xADB4A0", Offset = "0xADA0A0", VA = "0x180ADB4A0", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F44 RID: 77636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F44")]
		[Address(RVA = "0xADB530", Offset = "0xADA130", VA = "0x180ADB530", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F45 RID: 77637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F45")]
		[Address(RVA = "0xADB7A0", Offset = "0xADA3A0", VA = "0x180ADB7A0", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012F46 RID: 77638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F46")]
		[Address(RVA = "0xADB620", Offset = "0xADA220", VA = "0x180ADB620", Slot = "12")]
		public override void OnStopAffect()
		{
		}

		// Token: 0x06012F47 RID: 77639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F47")]
		[Address(RVA = "0xADB9F0", Offset = "0xADA5F0", VA = "0x180ADB9F0")]
		public BuffAfterAffecting()
		{
		}

		// Token: 0x06012F48 RID: 77640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F48")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06012F49 RID: 77641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F49")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012F4A RID: 77642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4A")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012F4B RID: 77643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4B")]
		[Address(RVA = "0xADB9E0", Offset = "0xADA5E0", VA = "0x180ADB9E0")]
		private void <>xLuaBaseProxy_OnStopAffect()
		{
		}

		// Token: 0x0401564E RID: 87630
		[Token(Token = "0x401564E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401564F RID: 87631
		[Token(Token = "0x401564F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _onlyCheckOnStopAffect;

		// Token: 0x04015650 RID: 87632
		[Token(Token = "0x4015650")]
		[FieldOffset(Offset = "0x29")]
		private bool m_waitForAffectingEnd;

		// Token: 0x04015651 RID: 87633
		[Token(Token = "0x4015651")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015652 RID: 87634
		[Token(Token = "0x4015652")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015653 RID: 87635
		[Token(Token = "0x4015653")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015654 RID: 87636
		[Token(Token = "0x4015654")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015655 RID: 87637
		[Token(Token = "0x4015655")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015656 RID: 87638
		[Token(Token = "0x4015656")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStopAffect;

		// Token: 0x04015657 RID: 87639
		[Token(Token = "0x4015657")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
