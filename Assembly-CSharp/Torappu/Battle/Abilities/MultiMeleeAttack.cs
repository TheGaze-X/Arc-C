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
	// Token: 0x02002AA1 RID: 10913
	[Token(Token = "0x2002AA1")]
	public class MultiMeleeAttack : MeleeAttack
	{
		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x060121F9 RID: 74233 RVA: 0x0006F108 File Offset: 0x0006D308
		[Token(Token = "0x170027CE")]
		public bool waitAttackEventForAllAttacks
		{
			[Token(Token = "0x60121F9")]
			[Address(RVA = "0xA27840", Offset = "0xA26440", VA = "0x180A27840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x060121FA RID: 74234 RVA: 0x0006F120 File Offset: 0x0006D320
		[Token(Token = "0x170027CF")]
		protected override FP postDelay
		{
			[Token(Token = "0x60121FA")]
			[Address(RVA = "0xA27760", Offset = "0xA26360", VA = "0x180A27760", Slot = "97")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x060121FB RID: 74235 RVA: 0x0006F138 File Offset: 0x0006D338
		[Token(Token = "0x170027D0")]
		protected override bool onlyTrigAudioSignalForFirstSpell
		{
			[Token(Token = "0x60121FB")]
			[Address(RVA = "0xA27700", Offset = "0xA26300", VA = "0x180A27700", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x060121FC RID: 74236 RVA: 0x0006F150 File Offset: 0x0006D350
		[Token(Token = "0x170027D1")]
		protected override bool onlyTrigAudioSignalForFirstHit
		{
			[Token(Token = "0x60121FC")]
			[Address(RVA = "0xA276A0", Offset = "0xA262A0", VA = "0x180A276A0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060121FD RID: 74237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121FD")]
		[Address(RVA = "0xA27190", Offset = "0xA25D90", VA = "0x180A27190", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x060121FE RID: 74238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121FE")]
		[Address(RVA = "0xA26AA0", Offset = "0xA256A0", VA = "0x180A26AA0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060121FF RID: 74239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60121FF")]
		[Address(RVA = "0xA27000", Offset = "0xA25C00", VA = "0x180A27000", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012200 RID: 74240 RVA: 0x0006F168 File Offset: 0x0006D368
		[Token(Token = "0x6012200")]
		[Address(RVA = "0xA265A0", Offset = "0xA251A0", VA = "0x180A265A0", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x06012201 RID: 74241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012201")]
		[Address(RVA = "0xA26DF0", Offset = "0xA259F0", VA = "0x180A26DF0", Slot = "91")]
		protected override void DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x06012202 RID: 74242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012202")]
		[Address(RVA = "0xA26BE0", Offset = "0xA257E0", VA = "0x180A26BE0", Slot = "92")]
		protected override void DoEmitAudioSignalForHit(Entity target)
		{
		}

		// Token: 0x06012203 RID: 74243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012203")]
		[Address(RVA = "0xA272D0", Offset = "0xA25ED0", VA = "0x180A272D0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012204 RID: 74244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012204")]
		[Address(RVA = "0xA27230", Offset = "0xA25E30", VA = "0x180A27230", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012205 RID: 74245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012205")]
		[Address(RVA = "0xA268F0", Offset = "0xA254F0", VA = "0x180A268F0", Slot = "74")]
		protected override void DoApplyActionsOnTarget(Entity target, IList<ActionNode> actions)
		{
		}

		// Token: 0x06012206 RID: 74246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012206")]
		[Address(RVA = "0xA27400", Offset = "0xA26000", VA = "0x180A27400", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012207 RID: 74247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012207")]
		[Address(RVA = "0xA274B0", Offset = "0xA260B0", VA = "0x180A274B0", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x06012208 RID: 74248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012208")]
		[Address(RVA = "0xA275F0", Offset = "0xA261F0", VA = "0x180A275F0")]
		public MultiMeleeAttack()
		{
		}

		// Token: 0x0601220A RID: 74250 RVA: 0x0006F180 File Offset: 0x0006D380
		[Token(Token = "0x601220A")]
		[Address(RVA = "0xA275E0", Offset = "0xA261E0", VA = "0x180A275E0")]
		private FP <>xLuaBaseProxy_get_postDelay()
		{
			return default(FP);
		}

		// Token: 0x0601220B RID: 74251 RVA: 0x0006F198 File Offset: 0x0006D398
		[Token(Token = "0x601220B")]
		[Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		private bool <>xLuaBaseProxy_get_onlyTrigAudioSignalForFirstSpell()
		{
			return default(bool);
		}

		// Token: 0x0601220C RID: 74252 RVA: 0x0006F1B0 File Offset: 0x0006D3B0
		[Token(Token = "0x601220C")]
		[Address(RVA = "0xA275D0", Offset = "0xA261D0", VA = "0x180A275D0")]
		private bool <>xLuaBaseProxy_get_onlyTrigAudioSignalForFirstHit()
		{
			return default(bool);
		}

		// Token: 0x0601220D RID: 74253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601220D")]
		[Address(RVA = "0xA275B0", Offset = "0xA261B0", VA = "0x180A275B0")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601220E RID: 74254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601220E")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601220F RID: 74255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601220F")]
		[Address(RVA = "0xA1FD10", Offset = "0xA1E910", VA = "0x180A1FD10")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012210 RID: 74256 RVA: 0x0006F1C8 File Offset: 0x0006D3C8
		[Token(Token = "0x6012210")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x06012211 RID: 74257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012211")]
		[Address(RVA = "0xA275A0", Offset = "0xA261A0", VA = "0x180A275A0")]
		private void <>xLuaBaseProxy_DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x06012212 RID: 74258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012212")]
		[Address(RVA = "0xA27590", Offset = "0xA26190", VA = "0x180A27590")]
		private void <>xLuaBaseProxy_DoEmitAudioSignalForHit(Entity P0)
		{
		}

		// Token: 0x06012213 RID: 74259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012213")]
		[Address(RVA = "0xA1FD50", Offset = "0xA1E950", VA = "0x180A1FD50")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012214 RID: 74260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012214")]
		[Address(RVA = "0xA275C0", Offset = "0xA261C0", VA = "0x180A275C0")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012215 RID: 74261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012215")]
		[Address(RVA = "0xA27570", Offset = "0xA26170", VA = "0x180A27570")]
		private void <>xLuaBaseProxy_DoApplyActionsOnTarget(Entity P0, IList<ActionNode> P1)
		{
		}

		// Token: 0x06012216 RID: 74262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012216")]
		[Address(RVA = "0xA27560", Offset = "0xA26160", VA = "0x180A27560")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012217 RID: 74263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012217")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x04014820 RID: 84000
		[Token(Token = "0x4014820")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("Multi")]
		private int _additionalTimes;

		// Token: 0x04014821 RID: 84001
		[Token(Token = "0x4014821")]
		[FieldOffset(Offset = "0x21C")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("waitAttackEventForAllAttacks", false)]
		private float _triggerDelta;

		// Token: 0x04014822 RID: 84002
		[Token(Token = "0x4014822")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Group("Multi")]
		private bool _waitAttackEventForAllAttacks;

		// Token: 0x04014823 RID: 84003
		[Token(Token = "0x4014823")]
		[FieldOffset(Offset = "0x221")]
		[SerializeField]
		[Group("Multi")]
		private bool _splitDamage;

		// Token: 0x04014824 RID: 84004
		[Token(Token = "0x4014824")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		[Group("Multi")]
		private float _minPostDelay;

		// Token: 0x04014825 RID: 84005
		[Token(Token = "0x4014825")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToLastOne;

		// Token: 0x04014826 RID: 84006
		[Token(Token = "0x4014826")]
		[FieldOffset(Offset = "0x229")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToFirstOne;

		// Token: 0x04014827 RID: 84007
		[Token(Token = "0x4014827")]
		[FieldOffset(Offset = "0x22A")]
		[SerializeField]
		[Group("Multi")]
		private bool _addSpellCntToAllSignalId;

		// Token: 0x04014828 RID: 84008
		[Token(Token = "0x4014828")]
		[FieldOffset(Offset = "0x22B")]
		[SerializeField]
		[Group("Multi")]
		private bool _addSpellCntToLastSignalId;

		// Token: 0x04014829 RID: 84009
		[Token(Token = "0x4014829")]
		[FieldOffset(Offset = "0x22C")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyTrigAudioSignalForFirstSpell;

		// Token: 0x0401482A RID: 84010
		[Token(Token = "0x401482A")]
		[FieldOffset(Offset = "0x22D")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyTrigAudioSignalForFirstHit;

		// Token: 0x0401482B RID: 84011
		[Token(Token = "0x401482B")]
		[FieldOffset(Offset = "0x22E")]
		[SerializeField]
		[Group("Multi")]
		private bool _addSpellCntToAllHitSignalId;

		// Token: 0x0401482C RID: 84012
		[Token(Token = "0x401482C")]
		[FieldOffset(Offset = "0x22F")]
		[SerializeField]
		[Group("Multi")]
		protected bool _refreshInputTargetOnCheckSpell;

		// Token: 0x0401482D RID: 84013
		[Token(Token = "0x401482D")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[Group("Multi")]
		protected TargetTrigger _refreshInputTargetTrigger;

		// Token: 0x0401482E RID: 84014
		[Token(Token = "0x401482E")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		[Group("Multi")]
		private bool _refreshTimesOnCastStart;

		// Token: 0x0401482F RID: 84015
		[Token(Token = "0x401482F")]
		[FieldOffset(Offset = "0x239")]
		[SerializeField]
		[Group("Multi")]
		protected bool _refreshTimesOnCheckAnotherSpell;

		// Token: 0x04014830 RID: 84016
		[Token(Token = "0x4014830")]
		[FieldOffset(Offset = "0x23C")]
		protected int m_additionalTimes;

		// Token: 0x04014831 RID: 84017
		[Token(Token = "0x4014831")]
		[FieldOffset(Offset = "0x240")]
		private float m_triggerDelta;

		// Token: 0x04014832 RID: 84018
		[Token(Token = "0x4014832")]
		[FieldOffset(Offset = "0x248")]
		private ModifierSplitter m_damageSplitter;

		// Token: 0x04014833 RID: 84019
		[Token(Token = "0x4014833")]
		[FieldOffset(Offset = "0x250")]
		private MultiEventListener m_multiEventListener;

		// Token: 0x04014834 RID: 84020
		[Token(Token = "0x4014834")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitAttackEventForAllAttacks;

		// Token: 0x04014835 RID: 84021
		[Token(Token = "0x4014835")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_postDelay;

		// Token: 0x04014836 RID: 84022
		[Token(Token = "0x4014836")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstSpell;

		// Token: 0x04014837 RID: 84023
		[Token(Token = "0x4014837")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstHit;

		// Token: 0x04014838 RID: 84024
		[Token(Token = "0x4014838")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014839 RID: 84025
		[Token(Token = "0x4014839")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401483A RID: 84026
		[Token(Token = "0x401483A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401483B RID: 84027
		[Token(Token = "0x401483B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x0401483C RID: 84028
		[Token(Token = "0x401483C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForSpellOn;

		// Token: 0x0401483D RID: 84029
		[Token(Token = "0x401483D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForHit;

		// Token: 0x0401483E RID: 84030
		[Token(Token = "0x401483E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401483F RID: 84031
		[Token(Token = "0x401483F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014840 RID: 84032
		[Token(Token = "0x4014840")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoApplyActionsOnTarget;

		// Token: 0x04014841 RID: 84033
		[Token(Token = "0x4014841")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014842 RID: 84034
		[Token(Token = "0x4014842")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x04014843 RID: 84035
		[Token(Token = "0x4014843")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
