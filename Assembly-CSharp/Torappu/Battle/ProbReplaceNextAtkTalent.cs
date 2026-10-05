using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002492 RID: 9362
	[Token(Token = "0x2002492")]
	public class ProbReplaceNextAtkTalent : Talent, Character.IReplacement
	{
		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600F0B9 RID: 61625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F47")]
		public TargetTrigger trigger
		{
			[Token(Token = "0x600F0B9")]
			[Address(RVA = "0x6784F0", Offset = "0x6770F0", VA = "0x1806784F0", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600F0BA RID: 61626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F48")]
		public string probKey
		{
			[Token(Token = "0x600F0BA")]
			[Address(RVA = "0x678460", Offset = "0x677060", VA = "0x180678460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600F0BB RID: 61627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F49")]
		private Blackboard probBlackboard
		{
			[Token(Token = "0x600F0BB")]
			[Address(RVA = "0x6782E0", Offset = "0x676EE0", VA = "0x1806782E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F0BC RID: 61628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0BC")]
		[Address(RVA = "0x6777F0", Offset = "0x6763F0", VA = "0x1806777F0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0BD")]
		[Address(RVA = "0x6778F0", Offset = "0x6764F0", VA = "0x1806778F0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0BE RID: 61630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0BE")]
		[Address(RVA = "0x677950", Offset = "0x676550", VA = "0x180677950", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0BF RID: 61631 RVA: 0x00058B78 File Offset: 0x00056D78
		[Token(Token = "0x600F0BF")]
		[Address(RVA = "0x677D10", Offset = "0x676910", VA = "0x180677D10", Slot = "24")]
		public override bool OnBeforeAttack(Ability oldAbility, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600F0C0 RID: 61632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C0")]
		[Address(RVA = "0x677AE0", Offset = "0x6766E0", VA = "0x180677AE0", Slot = "25")]
		public override void OnAfterAttack(Ability oldAbility, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F0C1 RID: 61633 RVA: 0x00058B90 File Offset: 0x00056D90
		[Token(Token = "0x600F0C1")]
		[Address(RVA = "0x6781D0", Offset = "0x676DD0", VA = "0x1806781D0", Slot = "35")]
		public bool TryHookSearchTarget(out bool isFound)
		{
			return default(bool);
		}

		// Token: 0x0600F0C2 RID: 61634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C2")]
		[Address(RVA = "0x678240", Offset = "0x676E40", VA = "0x180678240")]
		public ProbReplaceNextAtkTalent()
		{
		}

		// Token: 0x0600F0C3 RID: 61635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C3")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C4")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0C5 RID: 61637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C5")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F0C6 RID: 61638 RVA: 0x00058BA8 File Offset: 0x00056DA8
		[Token(Token = "0x600F0C6")]
		[Address(RVA = "0x66FD40", Offset = "0x66E940", VA = "0x18066FD40")]
		private bool <>xLuaBaseProxy_OnBeforeAttack(Ability P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C7")]
		[Address(RVA = "0x66FD30", Offset = "0x66E930", VA = "0x18066FD30")]
		private void <>xLuaBaseProxy_OnAfterAttack(Ability P0, bool P1, Ability.FinishReason P2)
		{
		}

		// Token: 0x04010A3C RID: 68156
		[Token(Token = "0x4010A3C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TargetTrigger _trigger;

		// Token: 0x04010A3D RID: 68157
		[Token(Token = "0x4010A3D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Ability.FamilyGroupMask _familyMask;

		// Token: 0x04010A3E RID: 68158
		[Token(Token = "0x4010A3E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _probKey;

		// Token: 0x04010A3F RID: 68159
		[Token(Token = "0x4010A3F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _isModeTalent;

		// Token: 0x04010A40 RID: 68160
		[Token(Token = "0x4010A40")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _syncProbWithBuffKey;

		// Token: 0x04010A41 RID: 68161
		[Token(Token = "0x4010A41")]
		[FieldOffset(Offset = "0xB8")]
		private float m_prob;

		// Token: 0x04010A42 RID: 68162
		[Token(Token = "0x4010A42")]
		[FieldOffset(Offset = "0xC0")]
		private Buff m_probSyncBuff;

		// Token: 0x04010A43 RID: 68163
		[Token(Token = "0x4010A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trigger;

		// Token: 0x04010A44 RID: 68164
		[Token(Token = "0x4010A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_probKey;

		// Token: 0x04010A45 RID: 68165
		[Token(Token = "0x4010A45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_probBlackboard;

		// Token: 0x04010A46 RID: 68166
		[Token(Token = "0x4010A46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A47 RID: 68167
		[Token(Token = "0x4010A47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A48 RID: 68168
		[Token(Token = "0x4010A48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A49 RID: 68169
		[Token(Token = "0x4010A49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04010A4A RID: 68170
		[Token(Token = "0x4010A4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x04010A4B RID: 68171
		[Token(Token = "0x4010A4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryHookSearchTarget;

		// Token: 0x04010A4C RID: 68172
		[Token(Token = "0x4010A4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
