using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AE5 RID: 10981
	[Token(Token = "0x2002AE5")]
	public class MultiProjectileToTileAbility : ProjectileToTileAbility
	{
		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0601252B RID: 75051 RVA: 0x00070398 File Offset: 0x0006E598
		[Token(Token = "0x1700282A")]
		public bool isLastSpell
		{
			[Token(Token = "0x601252B")]
			[Address(RVA = "0xA58E60", Offset = "0xA57A60", VA = "0x180A58E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0601252C RID: 75052 RVA: 0x000703B0 File Offset: 0x0006E5B0
		[Token(Token = "0x1700282B")]
		protected int additionalTimes
		{
			[Token(Token = "0x601252C")]
			[Address(RVA = "0xA58CF0", Offset = "0xA578F0", VA = "0x180A58CF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0601252D RID: 75053 RVA: 0x000703C8 File Offset: 0x0006E5C8
		[Token(Token = "0x1700282C")]
		protected bool waitAttackEventForAllAttacks
		{
			[Token(Token = "0x601252D")]
			[Address(RVA = "0xA58F80", Offset = "0xA57B80", VA = "0x180A58F80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0601252E RID: 75054 RVA: 0x000703E0 File Offset: 0x0006E5E0
		[Token(Token = "0x1700282D")]
		protected bool castToTileOneByOne
		{
			[Token(Token = "0x601252E")]
			[Address(RVA = "0xA58D50", Offset = "0xA57950", VA = "0x180A58D50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0601252F RID: 75055 RVA: 0x000703F8 File Offset: 0x0006E5F8
		[Token(Token = "0x1700282E")]
		protected override bool finishStartEffectsOnCastEnd
		{
			[Token(Token = "0x601252F")]
			[Address(RVA = "0xA58DB0", Offset = "0xA579B0", VA = "0x180A58DB0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06012530 RID: 75056 RVA: 0x00070410 File Offset: 0x0006E610
		[Token(Token = "0x1700282F")]
		protected override bool onlyTrigAudioSignalForFirstSpell
		{
			[Token(Token = "0x6012530")]
			[Address(RVA = "0xA58F20", Offset = "0xA57B20", VA = "0x180A58F20", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012531 RID: 75057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012531")]
		[Address(RVA = "0xA580C0", Offset = "0xA56CC0", VA = "0x180A580C0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012532 RID: 75058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012532")]
		[Address(RVA = "0xA57F80", Offset = "0xA56B80", VA = "0x180A57F80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012533 RID: 75059 RVA: 0x00070428 File Offset: 0x0006E628
		[Token(Token = "0x6012533")]
		[Address(RVA = "0xA57C60", Offset = "0xA56860", VA = "0x180A57C60", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x06012534 RID: 75060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012534")]
		[Address(RVA = "0xA58510", Offset = "0xA57110", VA = "0x180A58510", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012535 RID: 75061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012535")]
		[Address(RVA = "0xA58470", Offset = "0xA57070", VA = "0x180A58470", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012536 RID: 75062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012536")]
		[Address(RVA = "0xA57DD0", Offset = "0xA569D0", VA = "0x180A57DD0", Slot = "74")]
		protected override void DoApplyActionsOnTarget(Entity target, IList<ActionNode> actions)
		{
		}

		// Token: 0x06012537 RID: 75063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012537")]
		[Address(RVA = "0xA58890", Offset = "0xA57490", VA = "0x180A58890", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012538 RID: 75064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012538")]
		[Address(RVA = "0xA587E0", Offset = "0xA573E0", VA = "0x180A587E0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012539 RID: 75065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012539")]
		[Address(RVA = "0xA58940", Offset = "0xA57540", VA = "0x180A58940", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0601253A RID: 75066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601253A")]
		[Address(RVA = "0xA58310", Offset = "0xA56F10", VA = "0x180A58310", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601253B")]
		[Address(RVA = "0xA583B0", Offset = "0xA56FB0", VA = "0x180A583B0", Slot = "112")]
		protected override string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601253C RID: 75068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601253C")]
		[Address(RVA = "0xA58240", Offset = "0xA56E40", VA = "0x180A58240", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601253D RID: 75069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601253D")]
		[Address(RVA = "0xA58AC0", Offset = "0xA576C0", VA = "0x180A58AC0")]
		public MultiProjectileToTileAbility()
		{
		}

		// Token: 0x06012540 RID: 75072 RVA: 0x00070440 File Offset: 0x0006E640
		[Token(Token = "0x6012540")]
		[Address(RVA = "0xA53D80", Offset = "0xA52980", VA = "0x180A53D80")]
		private bool <>xLuaBaseProxy_get_finishStartEffectsOnCastEnd()
		{
			return default(bool);
		}

		// Token: 0x06012541 RID: 75073 RVA: 0x00070458 File Offset: 0x0006E658
		[Token(Token = "0x6012541")]
		[Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		private bool <>xLuaBaseProxy_get_onlyTrigAudioSignalForFirstSpell()
		{
			return default(bool);
		}

		// Token: 0x06012542 RID: 75074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012542")]
		[Address(RVA = "0xA58A00", Offset = "0xA57600", VA = "0x180A58A00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012543 RID: 75075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012543")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012544 RID: 75076 RVA: 0x00070470 File Offset: 0x0006E670
		[Token(Token = "0x6012544")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x06012545 RID: 75077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012545")]
		[Address(RVA = "0xA58AB0", Offset = "0xA576B0", VA = "0x180A58AB0")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012546 RID: 75078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012546")]
		[Address(RVA = "0xA58AA0", Offset = "0xA576A0", VA = "0x180A58AA0")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012547 RID: 75079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012547")]
		[Address(RVA = "0xA27570", Offset = "0xA26170", VA = "0x180A27570")]
		private void <>xLuaBaseProxy_DoApplyActionsOnTarget(Entity P0, IList<ActionNode> P1)
		{
		}

		// Token: 0x06012548 RID: 75080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012548")]
		[Address(RVA = "0xA27560", Offset = "0xA26160", VA = "0x180A27560")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012549 RID: 75081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012549")]
		[Address(RVA = "0xA589F0", Offset = "0xA575F0", VA = "0x180A589F0")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601254A RID: 75082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601254A")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0601254B RID: 75083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601254B")]
		[Address(RVA = "0xA275B0", Offset = "0xA261B0", VA = "0x180A275B0")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601254C RID: 75084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601254C")]
		[Address(RVA = "0xA58A40", Offset = "0xA57640", VA = "0x180A58A40")]
		private string <>xLuaBaseProxy_GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601254D RID: 75085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601254D")]
		[Address(RVA = "0xA58A30", Offset = "0xA57630", VA = "0x180A58A30")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x04014B79 RID: 84857
		[Token(Token = "0x4014B79")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		[Group("Multi")]
		private int _additionalTimes;

		// Token: 0x04014B7A RID: 84858
		[Token(Token = "0x4014B7A")]
		[FieldOffset(Offset = "0x25C")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("waitAttackEventForAllAttacks", false)]
		private float _triggerDelta;

		// Token: 0x04014B7B RID: 84859
		[Token(Token = "0x4014B7B")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		[Group("Multi")]
		private bool _waitAttackEventForAllAttacks;

		// Token: 0x04014B7C RID: 84860
		[Token(Token = "0x4014B7C")]
		[FieldOffset(Offset = "0x261")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyTrigAudioSignalForFirstOne;

		// Token: 0x04014B7D RID: 84861
		[Token(Token = "0x4014B7D")]
		[FieldOffset(Offset = "0x262")]
		[SerializeField]
		[Group("Multi")]
		private bool _splitDamage;

		// Token: 0x04014B7E RID: 84862
		[Token(Token = "0x4014B7E")]
		[FieldOffset(Offset = "0x263")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToLastOne;

		// Token: 0x04014B7F RID: 84863
		[Token(Token = "0x4014B7F")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToFirstOne;

		// Token: 0x04014B80 RID: 84864
		[Token(Token = "0x4014B80")]
		[FieldOffset(Offset = "0x265")]
		[SerializeField]
		[Group("Multi")]
		private bool _refreshTimesOnCastStart;

		// Token: 0x04014B81 RID: 84865
		[Token(Token = "0x4014B81")]
		[FieldOffset(Offset = "0x266")]
		[SerializeField]
		[Group("Multi")]
		private bool _castToTileOneByOne;

		// Token: 0x04014B82 RID: 84866
		[Token(Token = "0x4014B82")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Multi")]
		private string[] _additionalProjectiles;

		// Token: 0x04014B83 RID: 84867
		[Token(Token = "0x4014B83")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("castToTileOneByOne")]
		private bool _fireAttackFinishWhenCastToTileOneByOne;

		// Token: 0x04014B84 RID: 84868
		[Token(Token = "0x4014B84")]
		[FieldOffset(Offset = "0x274")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("castToTileOneByOne")]
		private float _minPostDelayWhenCastToTileOneByOne;

		// Token: 0x04014B85 RID: 84869
		[Token(Token = "0x4014B85")]
		[FieldOffset(Offset = "0x278")]
		private float m_triggerDelta;

		// Token: 0x04014B86 RID: 84870
		[Token(Token = "0x4014B86")]
		[FieldOffset(Offset = "0x280")]
		private ModifierSplitter m_damageSplitter;

		// Token: 0x04014B87 RID: 84871
		[Token(Token = "0x4014B87")]
		[FieldOffset(Offset = "0x288")]
		private MultiEventListener m_multiEventListener;

		// Token: 0x04014B88 RID: 84872
		[Token(Token = "0x4014B88")]
		[FieldOffset(Offset = "0x290")]
		private List<Tile> m_cachedCastTiles;

		// Token: 0x04014B89 RID: 84873
		[Token(Token = "0x4014B89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLastSpell;

		// Token: 0x04014B8A RID: 84874
		[Token(Token = "0x4014B8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_additionalTimes;

		// Token: 0x04014B8B RID: 84875
		[Token(Token = "0x4014B8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_waitAttackEventForAllAttacks;

		// Token: 0x04014B8C RID: 84876
		[Token(Token = "0x4014B8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_castToTileOneByOne;

		// Token: 0x04014B8D RID: 84877
		[Token(Token = "0x4014B8D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_finishStartEffectsOnCastEnd;

		// Token: 0x04014B8E RID: 84878
		[Token(Token = "0x4014B8E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstSpell;

		// Token: 0x04014B8F RID: 84879
		[Token(Token = "0x4014B8F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014B90 RID: 84880
		[Token(Token = "0x4014B90")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014B91 RID: 84881
		[Token(Token = "0x4014B91")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x04014B92 RID: 84882
		[Token(Token = "0x4014B92")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014B93 RID: 84883
		[Token(Token = "0x4014B93")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014B94 RID: 84884
		[Token(Token = "0x4014B94")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoApplyActionsOnTarget;

		// Token: 0x04014B95 RID: 84885
		[Token(Token = "0x4014B95")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014B96 RID: 84886
		[Token(Token = "0x4014B96")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014B97 RID: 84887
		[Token(Token = "0x4014B97")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x04014B98 RID: 84888
		[Token(Token = "0x4014B98")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014B99 RID: 84889
		[Token(Token = "0x4014B99")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x04014B9A RID: 84890
		[Token(Token = "0x4014B9A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014B9B RID: 84891
		[Token(Token = "0x4014B9B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
