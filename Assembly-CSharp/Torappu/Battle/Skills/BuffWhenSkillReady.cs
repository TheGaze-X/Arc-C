using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028AE RID: 10414
	[Token(Token = "0x20028AE")]
	public class BuffWhenSkillReady : BasicSkill.Behaviour, IBuffSource, IEffectSource
	{
		// Token: 0x06011516 RID: 70934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011516")]
		[Address(RVA = "0x91DE50", Offset = "0x91CA50", VA = "0x18091DE50", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011517 RID: 70935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011517")]
		[Address(RVA = "0x91DCE0", Offset = "0x91C8E0", VA = "0x18091DCE0", Slot = "16")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06011518 RID: 70936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011518")]
		[Address(RVA = "0x91DDE0", Offset = "0x91C9E0", VA = "0x18091DDE0", Slot = "11")]
		public override void OnInit()
		{
		}

		// Token: 0x06011519 RID: 70937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011519")]
		[Address(RVA = "0x91DD70", Offset = "0x91C970", VA = "0x18091DD70", Slot = "17")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601151A RID: 70938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151A")]
		[Address(RVA = "0x91E1F0", Offset = "0x91CDF0", VA = "0x18091E1F0")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x0601151B RID: 70939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151B")]
		[Address(RVA = "0x91E2E0", Offset = "0x91CEE0", VA = "0x18091E2E0")]
		public BuffWhenSkillReady()
		{
		}

		// Token: 0x0601151C RID: 70940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151C")]
		[Address(RVA = "0x91E1E0", Offset = "0x91CDE0", VA = "0x18091E1E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0601151D RID: 70941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151D")]
		[Address(RVA = "0x91E1D0", Offset = "0x91CDD0", VA = "0x18091E1D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04013592 RID: 79250
		[Token(Token = "0x4013592")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04013593 RID: 79251
		[Token(Token = "0x4013593")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _clearBuffGivenLastTime;

		// Token: 0x04013594 RID: 79252
		[Token(Token = "0x4013594")]
		[FieldOffset(Offset = "0x2C")]
		private int m_cachedSkillStack;

		// Token: 0x04013595 RID: 79253
		[Token(Token = "0x4013595")]
		[FieldOffset(Offset = "0x30")]
		private List<uint> m_buffUid;

		// Token: 0x04013596 RID: 79254
		[Token(Token = "0x4013596")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013597 RID: 79255
		[Token(Token = "0x4013597")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04013598 RID: 79256
		[Token(Token = "0x4013598")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013599 RID: 79257
		[Token(Token = "0x4013599")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401359A RID: 79258
		[Token(Token = "0x401359A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x0401359B RID: 79259
		[Token(Token = "0x401359B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
