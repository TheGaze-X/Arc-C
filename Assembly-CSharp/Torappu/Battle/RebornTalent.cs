using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002494 RID: 9364
	[Token(Token = "0x2002494")]
	[RequireComponent(typeof(Ability))]
	public class RebornTalent : Talent
	{
		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x0600F0CD RID: 61645 RVA: 0x00058BD8 File Offset: 0x00056DD8
		[Token(Token = "0x17001F4B")]
		protected bool useAbilityToHandle
		{
			[Token(Token = "0x600F0CD")]
			[Address(RVA = "0x695880", Offset = "0x694480", VA = "0x180695880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x0600F0CE RID: 61646 RVA: 0x00058BF0 File Offset: 0x00056DF0
		[Token(Token = "0x17001F4C")]
		protected bool needPlayEffectWhenReborn
		{
			[Token(Token = "0x600F0CE")]
			[Address(RVA = "0x6957E0", Offset = "0x6943E0", VA = "0x1806957E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F0CF RID: 61647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0CF")]
		[Address(RVA = "0x694EA0", Offset = "0x693AA0", VA = "0x180694EA0", Slot = "31")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600F0D0 RID: 61648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D0")]
		[Address(RVA = "0x695040", Offset = "0x693C40", VA = "0x180695040", Slot = "32")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600F0D1 RID: 61649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D1")]
		[Address(RVA = "0x694320", Offset = "0x692F20", VA = "0x180694320", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F0D2 RID: 61650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D2")]
		[Address(RVA = "0x694BA0", Offset = "0x6937A0", VA = "0x180694BA0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0D3 RID: 61651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D3")]
		[Address(RVA = "0x694D20", Offset = "0x693920", VA = "0x180694D20", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0D4 RID: 61652 RVA: 0x00058C08 File Offset: 0x00056E08
		[Token(Token = "0x600F0D4")]
		[Address(RVA = "0x6949B0", Offset = "0x6935B0", VA = "0x1806949B0", Slot = "26")]
		public override bool CheckReborn(out Unit.RebornData respawnData)
		{
			return default(bool);
		}

		// Token: 0x0600F0D5 RID: 61653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D5")]
		[Address(RVA = "0x6951D0", Offset = "0x693DD0", VA = "0x1806951D0")]
		public void ModifyHpRatio(FP hpRatio)
		{
		}

		// Token: 0x0600F0D6 RID: 61654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D6")]
		[Address(RVA = "0x6954B0", Offset = "0x6940B0", VA = "0x1806954B0")]
		private void _OnRebornAfterFakeDeath(object arg)
		{
		}

		// Token: 0x0600F0D7 RID: 61655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D7")]
		[Address(RVA = "0x6953D0", Offset = "0x693FD0", VA = "0x1806953D0")]
		private void _OnAfterReborn(object arg)
		{
		}

		// Token: 0x0600F0D8 RID: 61656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D8")]
		[Address(RVA = "0x695760", Offset = "0x694360", VA = "0x180695760")]
		public RebornTalent()
		{
		}

		// Token: 0x0600F0D9 RID: 61657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0D9")]
		[Address(RVA = "0x6900B0", Offset = "0x68ECB0", VA = "0x1806900B0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0600F0DA RID: 61658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0DA")]
		[Address(RVA = "0x6953C0", Offset = "0x693FC0", VA = "0x1806953C0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600F0DB RID: 61659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0DB")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F0DC RID: 61660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0DC")]
		[Address(RVA = "0x694060", Offset = "0x692C60", VA = "0x180694060")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0DD RID: 61661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0DD")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F0DE RID: 61662 RVA: 0x00058C20 File Offset: 0x00056E20
		[Token(Token = "0x600F0DE")]
		[Address(RVA = "0x66FD20", Offset = "0x66E920", VA = "0x18066FD20")]
		private bool <>xLuaBaseProxy_CheckReborn(out Unit.RebornData P0)
		{
			return default(bool);
		}

		// Token: 0x04010A52 RID: 68178
		[Token(Token = "0x4010A52")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Inspect(1)]
		private int _maxRespawnCnt;

		// Token: 0x04010A53 RID: 68179
		[Token(Token = "0x4010A53")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Group("Basic", 2)]
		private int _modeIndex;

		// Token: 0x04010A54 RID: 68180
		[Token(Token = "0x4010A54")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _keepAlive;

		// Token: 0x04010A55 RID: 68181
		[Token(Token = "0x4010A55")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Basic", 2)]
		private BuffData[] _buffs;

		// Token: 0x04010A56 RID: 68182
		[Token(Token = "0x4010A56")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Basic", 2)]
		private string[] _effects;

		// Token: 0x04010A57 RID: 68183
		[Token(Token = "0x4010A57")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("needPlayEffectWhenReborn")]
		[Group("Basic", 2)]
		private bool _clearEffectsAfterReborn;

		// Token: 0x04010A58 RID: 68184
		[Token(Token = "0x4010A58")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		[Group("Basic", 2)]
		private bool _useAbilityToHandle;

		// Token: 0x04010A59 RID: 68185
		[Token(Token = "0x4010A59")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("useAbilityToHandle")]
		[Group("Basic", 2)]
		private string _abilityName;

		// Token: 0x04010A5A RID: 68186
		[Token(Token = "0x4010A5A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Inspect("useAbilityToHandle")]
		[Group("Basic", 2)]
		private bool _finishHandleAbilityAfterReborn;

		// Token: 0x04010A5B RID: 68187
		[Token(Token = "0x4010A5B")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("Basic", 2)]
		private float _hpRechargeRatio;

		// Token: 0x04010A5C RID: 68188
		[Token(Token = "0x4010A5C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Basic", 2)]
		private List<string> _buffsRetainedWhenReborn;

		// Token: 0x04010A5D RID: 68189
		[Token(Token = "0x4010A5D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Basic", 2)]
		private bool _detachAbilityWhenReborn;

		// Token: 0x04010A5E RID: 68190
		[Token(Token = "0x4010A5E")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		[Group("Basic", 2)]
		private bool _rebornAfterWave;

		// Token: 0x04010A5F RID: 68191
		[Token(Token = "0x4010A5F")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("Basic", 2)]
		private int _rebornAfterWaveCnt;

		// Token: 0x04010A60 RID: 68192
		[Token(Token = "0x4010A60")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Basic", 2)]
		private string _validWhenContainsBuff;

		// Token: 0x04010A61 RID: 68193
		[Token(Token = "0x4010A61")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Inspect(3)]
		private List<RebornTalent.AdvancedRebornData> _extraRebornDataPresets;

		// Token: 0x04010A62 RID: 68194
		[Token(Token = "0x4010A62")]
		[FieldOffset(Offset = "0xE8")]
		protected int m_maxRespawnCnt;

		// Token: 0x04010A63 RID: 68195
		[Token(Token = "0x4010A63")]
		[FieldOffset(Offset = "0xEC")]
		protected int m_respawnCnt;

		// Token: 0x04010A64 RID: 68196
		[Token(Token = "0x4010A64")]
		[FieldOffset(Offset = "0xF0")]
		protected int m_rebornAfterWaveCnt;

		// Token: 0x04010A65 RID: 68197
		[Token(Token = "0x4010A65")]
		[FieldOffset(Offset = "0xF8")]
		protected Unit.RebornData m_defaultRespawnData;

		// Token: 0x04010A66 RID: 68198
		[Token(Token = "0x4010A66")]
		[FieldOffset(Offset = "0x140")]
		protected List<Unit.RebornData> m_respawnDataList;

		// Token: 0x04010A67 RID: 68199
		[Token(Token = "0x4010A67")]
		[FieldOffset(Offset = "0x148")]
		private ObjectPtr<Ability> m_handleAbility;

		// Token: 0x04010A68 RID: 68200
		[Token(Token = "0x4010A68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useAbilityToHandle;

		// Token: 0x04010A69 RID: 68201
		[Token(Token = "0x4010A69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needPlayEffectWhenReborn;

		// Token: 0x04010A6A RID: 68202
		[Token(Token = "0x4010A6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04010A6B RID: 68203
		[Token(Token = "0x4010A6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04010A6C RID: 68204
		[Token(Token = "0x4010A6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A6D RID: 68205
		[Token(Token = "0x4010A6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A6E RID: 68206
		[Token(Token = "0x4010A6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A6F RID: 68207
		[Token(Token = "0x4010A6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckReborn;

		// Token: 0x04010A70 RID: 68208
		[Token(Token = "0x4010A70")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ModifyHpRatio;

		// Token: 0x04010A71 RID: 68209
		[Token(Token = "0x4010A71")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnRebornAfterFakeDeath;

		// Token: 0x04010A72 RID: 68210
		[Token(Token = "0x4010A72")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAfterReborn;

		// Token: 0x04010A73 RID: 68211
		[Token(Token = "0x4010A73")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002495 RID: 9365
		[Token(Token = "0x2002495")]
		[Serializable]
		public struct AdvancedRebornData
		{
			// Token: 0x04010A74 RID: 68212
			[Token(Token = "0x4010A74")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int modeIndex;

			// Token: 0x04010A75 RID: 68213
			[Token(Token = "0x4010A75")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public bool keepAlive;

			// Token: 0x04010A76 RID: 68214
			[Token(Token = "0x4010A76")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public BuffData[] buffs;

			// Token: 0x04010A77 RID: 68215
			[Token(Token = "0x4010A77")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string[] effects;

			// Token: 0x04010A78 RID: 68216
			[Token(Token = "0x4010A78")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string handleAbilityName;

			// Token: 0x04010A79 RID: 68217
			[Token(Token = "0x4010A79")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public float hpRechargeRatio;

			// Token: 0x04010A7A RID: 68218
			[Token(Token = "0x4010A7A")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			public bool useMinHpRatio;

			// Token: 0x04010A7B RID: 68219
			[Token(Token = "0x4010A7B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public List<string> buffsRetainedWhenReborn;

			// Token: 0x04010A7C RID: 68220
			[Token(Token = "0x4010A7C")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public bool clearEffectsAfterReborn;

			// Token: 0x04010A7D RID: 68221
			[Token(Token = "0x4010A7D")]
			[FieldOffset(Offset = "0x31")]
			[SerializeField]
			public bool rebornAfterWave;

			// Token: 0x04010A7E RID: 68222
			[Token(Token = "0x4010A7E")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			public int rebornAfterWaveCnt;

			// Token: 0x04010A7F RID: 68223
			[Token(Token = "0x4010A7F")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public string durationKey;
		}
	}
}
