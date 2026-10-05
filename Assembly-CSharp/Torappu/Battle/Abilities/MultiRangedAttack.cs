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
	// Token: 0x02002AB6 RID: 10934
	[Token(Token = "0x2002AB6")]
	public class MultiRangedAttack : RangedAttack
	{
		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x06012314 RID: 74516 RVA: 0x0006F7B0 File Offset: 0x0006D9B0
		[Token(Token = "0x170027E4")]
		private bool useMultiAdditionalProjectiles
		{
			[Token(Token = "0x6012314")]
			[Address(RVA = "0xA45440", Offset = "0xA44040", VA = "0x180A45440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x06012315 RID: 74517 RVA: 0x0006F7C8 File Offset: 0x0006D9C8
		[Token(Token = "0x170027E5")]
		private bool enableMountPointGroup
		{
			[Token(Token = "0x6012315")]
			[Address(RVA = "0xA452B0", Offset = "0xA43EB0", VA = "0x180A452B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x06012316 RID: 74518 RVA: 0x0006F7E0 File Offset: 0x0006D9E0
		[Token(Token = "0x170027E6")]
		public bool waitAttackEventForAllAttacks
		{
			[Token(Token = "0x6012316")]
			[Address(RVA = "0xA454A0", Offset = "0xA440A0", VA = "0x180A454A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x06012317 RID: 74519 RVA: 0x0006F7F8 File Offset: 0x0006D9F8
		[Token(Token = "0x170027E7")]
		public bool isLastSpell
		{
			[Token(Token = "0x6012317")]
			[Address(RVA = "0xA45310", Offset = "0xA43F10", VA = "0x180A45310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x06012318 RID: 74520 RVA: 0x0006F810 File Offset: 0x0006DA10
		[Token(Token = "0x170027E8")]
		protected override bool onlyTrigAudioSignalForFirstSpell
		{
			[Token(Token = "0x6012318")]
			[Address(RVA = "0xA453E0", Offset = "0xA43FE0", VA = "0x180A453E0", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x06012319 RID: 74521 RVA: 0x0006F828 File Offset: 0x0006DA28
		[Token(Token = "0x170027E9")]
		protected int additionalTimes
		{
			[Token(Token = "0x6012319")]
			[Address(RVA = "0xA45250", Offset = "0xA43E50", VA = "0x180A45250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0601231A RID: 74522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027EA")]
		protected string additionalProjectile
		{
			[Token(Token = "0x601231A")]
			[Address(RVA = "0xA451F0", Offset = "0xA43DF0", VA = "0x180A451F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601231B RID: 74523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601231B")]
		[Address(RVA = "0xA44510", Offset = "0xA43110", VA = "0x180A44510", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601231C RID: 74524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601231C")]
		[Address(RVA = "0xA440C0", Offset = "0xA42CC0", VA = "0x180A440C0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601231D RID: 74525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601231D")]
		[Address(RVA = "0xA44870", Offset = "0xA43470", VA = "0x180A44870", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601231E RID: 74526 RVA: 0x0006F840 File Offset: 0x0006DA40
		[Token(Token = "0x601231E")]
		[Address(RVA = "0xA44200", Offset = "0xA42E00", VA = "0x180A44200", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0601231F RID: 74527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601231F")]
		[Address(RVA = "0xA44BB0", Offset = "0xA437B0", VA = "0x180A44BB0", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012320 RID: 74528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012320")]
		[Address(RVA = "0xA437E0", Offset = "0xA423E0", VA = "0x180A437E0", Slot = "116")]
		protected virtual void AfterCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x0006F858 File Offset: 0x0006DA58
		[Token(Token = "0x6012321")]
		[Address(RVA = "0xA43920", Offset = "0xA42520", VA = "0x180A43920", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x0006F870 File Offset: 0x0006DA70
		[Token(Token = "0x6012322")]
		[Address(RVA = "0xA45010", Offset = "0xA43C10", VA = "0x180A45010", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012323 RID: 74531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012323")]
		[Address(RVA = "0xA44C90", Offset = "0xA43890", VA = "0x180A44C90", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012324 RID: 74532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012324")]
		[Address(RVA = "0xA44B10", Offset = "0xA43710", VA = "0x180A44B10", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012325 RID: 74533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012325")]
		[Address(RVA = "0xA43F00", Offset = "0xA42B00", VA = "0x180A43F00", Slot = "74")]
		protected override void DoApplyActionsOnTarget(Entity target, IList<ActionNode> actions)
		{
		}

		// Token: 0x06012326 RID: 74534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012326")]
		[Address(RVA = "0xA43D50", Offset = "0xA42950", VA = "0x180A43D50", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x06012327 RID: 74535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012327")]
		[Address(RVA = "0xA44F50", Offset = "0xA43B50", VA = "0x180A44F50", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012328 RID: 74536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012328")]
		[Address(RVA = "0xA44DF0", Offset = "0xA439F0", VA = "0x180A44DF0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012329 RID: 74537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012329")]
		[Address(RVA = "0xA44EA0", Offset = "0xA43AA0", VA = "0x180A44EA0", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0601232A RID: 74538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601232A")]
		[Address(RVA = "0xA44930", Offset = "0xA43530", VA = "0x180A44930", Slot = "114")]
		protected override string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601232B RID: 74539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601232B")]
		[Address(RVA = "0xA44690", Offset = "0xA43290", VA = "0x180A44690", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601232C RID: 74540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601232C")]
		[Address(RVA = "0xA447D0", Offset = "0xA433D0", VA = "0x180A447D0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601232D RID: 74541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601232D")]
		[Address(RVA = "0xA43B70", Offset = "0xA42770", VA = "0x180A43B70", Slot = "115")]
		protected override void CheckProjectileNameOnApplied(string projectileKey)
		{
		}

		// Token: 0x0601232E RID: 74542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601232E")]
		[Address(RVA = "0xA450C0", Offset = "0xA43CC0", VA = "0x180A450C0")]
		public MultiRangedAttack()
		{
		}

		// Token: 0x06012330 RID: 74544 RVA: 0x0006F888 File Offset: 0x0006DA88
		[Token(Token = "0x6012330")]
		[Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		private bool <>xLuaBaseProxy_get_onlyTrigAudioSignalForFirstSpell()
		{
			return default(bool);
		}

		// Token: 0x06012331 RID: 74545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012331")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012332 RID: 74546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012332")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012333 RID: 74547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012333")]
		[Address(RVA = "0xA44FF0", Offset = "0xA43BF0", VA = "0x180A44FF0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x06012334 RID: 74548 RVA: 0x0006F8A0 File Offset: 0x0006DAA0
		[Token(Token = "0x6012334")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012335 RID: 74549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012335")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012336 RID: 74550 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
		[Token(Token = "0x6012336")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x06012337 RID: 74551 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
		[Token(Token = "0x6012337")]
		[Address(RVA = "0xA45000", Offset = "0xA43C00", VA = "0x180A45000")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x06012338 RID: 74552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012338")]
		[Address(RVA = "0xA36010", Offset = "0xA34C10", VA = "0x180A36010")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012339 RID: 74553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012339")]
		[Address(RVA = "0xA37180", Offset = "0xA35D80", VA = "0x180A37180")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601233A RID: 74554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601233A")]
		[Address(RVA = "0xA27570", Offset = "0xA26170", VA = "0x180A27570")]
		private void <>xLuaBaseProxy_DoApplyActionsOnTarget(Entity P0, IList<ActionNode> P1)
		{
		}

		// Token: 0x0601233B RID: 74555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601233B")]
		[Address(RVA = "0xA37170", Offset = "0xA35D70", VA = "0x180A37170")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x0601233C RID: 74556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601233C")]
		[Address(RVA = "0xA36020", Offset = "0xA34C20", VA = "0x180A36020")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0601233D RID: 74557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601233D")]
		[Address(RVA = "0xA27560", Offset = "0xA26160", VA = "0x180A27560")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x0601233E RID: 74558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601233E")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0601233F RID: 74559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601233F")]
		[Address(RVA = "0xA35FA0", Offset = "0xA34BA0", VA = "0x180A35FA0")]
		private string <>xLuaBaseProxy_GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012340 RID: 74560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012340")]
		[Address(RVA = "0xA35F90", Offset = "0xA34B90", VA = "0x180A35F90")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012341 RID: 74561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012341")]
		[Address(RVA = "0xA275B0", Offset = "0xA261B0", VA = "0x180A275B0")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012342 RID: 74562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012342")]
		[Address(RVA = "0xA44FE0", Offset = "0xA43BE0", VA = "0x180A44FE0")]
		private void <>xLuaBaseProxy_CheckProjectileNameOnApplied(string P0)
		{
		}

		// Token: 0x0401493D RID: 84285
		[Token(Token = "0x401493D")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Multi")]
		private int _additionalTimes;

		// Token: 0x0401493E RID: 84286
		[Token(Token = "0x401493E")]
		[FieldOffset(Offset = "0x26C")]
		[Group("Multi")]
		[Inspect("waitAttackEventForAllAttacks", false)]
		[SerializeField]
		private float _triggerDelta;

		// Token: 0x0401493F RID: 84287
		[Token(Token = "0x401493F")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Multi")]
		private bool _waitAttackEventForAllAttacks;

		// Token: 0x04014940 RID: 84288
		[Token(Token = "0x4014940")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("useMultiAdditionalProjectiles", false)]
		private string _additionalProjectile;

		// Token: 0x04014941 RID: 84289
		[Token(Token = "0x4014941")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		[Group("Multi")]
		private bool _useMultiAdditionalProjectiles;

		// Token: 0x04014942 RID: 84290
		[Token(Token = "0x4014942")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		[Group("Multi")]
		[Inspect("useMultiAdditionalProjectiles")]
		private string[] _additionalProjectiles;

		// Token: 0x04014943 RID: 84291
		[Token(Token = "0x4014943")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Group("Multi")]
		private bool _enableMountPointGroup;

		// Token: 0x04014944 RID: 84292
		[Token(Token = "0x4014944")]
		[FieldOffset(Offset = "0x298")]
		[Group("Multi")]
		[Inspect("enableMountPointGroup")]
		[SerializeField]
		private Entity.MountPointType[] _mountPointGroup;

		// Token: 0x04014945 RID: 84293
		[Token(Token = "0x4014945")]
		[FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActionsToFirstOne;

		// Token: 0x04014946 RID: 84294
		[Token(Token = "0x4014946")]
		[FieldOffset(Offset = "0x2A1")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyTrigAudioSignalForFirstOne;

		// Token: 0x04014947 RID: 84295
		[Token(Token = "0x4014947")]
		[FieldOffset(Offset = "0x2A2")]
		[SerializeField]
		[Group("Multi")]
		private bool _limitToOneTargetAfterFirstRound;

		// Token: 0x04014948 RID: 84296
		[Token(Token = "0x4014948")]
		[FieldOffset(Offset = "0x2A3")]
		[SerializeField]
		[Group("Multi")]
		private bool _splitDamage;

		// Token: 0x04014949 RID: 84297
		[Token(Token = "0x4014949")]
		[FieldOffset(Offset = "0x2A4")]
		[SerializeField]
		[Group("Multi")]
		private bool _addSpellCntToSignalId;

		// Token: 0x0401494A RID: 84298
		[Token(Token = "0x401494A")]
		[FieldOffset(Offset = "0x2A5")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToLastOne;

		// Token: 0x0401494B RID: 84299
		[Token(Token = "0x401494B")]
		[FieldOffset(Offset = "0x2A6")]
		[SerializeField]
		[Group("Multi")]
		private bool _onlyFeedActiveBuffToFirstOne;

		// Token: 0x0401494C RID: 84300
		[Token(Token = "0x401494C")]
		[FieldOffset(Offset = "0x2A7")]
		[SerializeField]
		[Group("Multi")]
		private bool _refreshTimesOnCastStart;

		// Token: 0x0401494D RID: 84301
		[Token(Token = "0x401494D")]
		[FieldOffset(Offset = "0x2A8")]
		[Inspect("emitToInputPosWhenTargetIsInvalid", false)]
		[SerializeField]
		[Group("Multi")]
		private bool _castToFirstRoundTargetLocationsAtProjectileBirth;

		// Token: 0x0401494E RID: 84302
		[Token(Token = "0x401494E")]
		[FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		[Group("Multi")]
		private string _hookTheLastProjectile;

		// Token: 0x0401494F RID: 84303
		[Token(Token = "0x401494F")]
		[FieldOffset(Offset = "0x2B8")]
		private float m_triggerDelta;

		// Token: 0x04014950 RID: 84304
		[Token(Token = "0x4014950")]
		[FieldOffset(Offset = "0x2BC")]
		private bool m_alreadyFeedFirstOne;

		// Token: 0x04014951 RID: 84305
		[Token(Token = "0x4014951")]
		[FieldOffset(Offset = "0x2C0")]
		private ModifierSplitter m_damageSplitter;

		// Token: 0x04014952 RID: 84306
		[Token(Token = "0x4014952")]
		[FieldOffset(Offset = "0x2C8")]
		private MultiEventListener m_multiEventListener;

		// Token: 0x04014953 RID: 84307
		[Token(Token = "0x4014953")]
		[FieldOffset(Offset = "0x2D0")]
		private List<Vector2> m_locationsFirstSpellCastTo;

		// Token: 0x04014954 RID: 84308
		[Token(Token = "0x4014954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useMultiAdditionalProjectiles;

		// Token: 0x04014955 RID: 84309
		[Token(Token = "0x4014955")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enableMountPointGroup;

		// Token: 0x04014956 RID: 84310
		[Token(Token = "0x4014956")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_waitAttackEventForAllAttacks;

		// Token: 0x04014957 RID: 84311
		[Token(Token = "0x4014957")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isLastSpell;

		// Token: 0x04014958 RID: 84312
		[Token(Token = "0x4014958")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onlyTrigAudioSignalForFirstSpell;

		// Token: 0x04014959 RID: 84313
		[Token(Token = "0x4014959")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_additionalTimes;

		// Token: 0x0401495A RID: 84314
		[Token(Token = "0x401495A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_additionalProjectile;

		// Token: 0x0401495B RID: 84315
		[Token(Token = "0x401495B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401495C RID: 84316
		[Token(Token = "0x401495C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401495D RID: 84317
		[Token(Token = "0x401495D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x0401495E RID: 84318
		[Token(Token = "0x401495E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x0401495F RID: 84319
		[Token(Token = "0x401495F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014960 RID: 84320
		[Token(Token = "0x4014960")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AfterCastOnTarget;

		// Token: 0x04014961 RID: 84321
		[Token(Token = "0x4014961")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x04014962 RID: 84322
		[Token(Token = "0x4014962")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014963 RID: 84323
		[Token(Token = "0x4014963")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014964 RID: 84324
		[Token(Token = "0x4014964")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014965 RID: 84325
		[Token(Token = "0x4014965")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoApplyActionsOnTarget;

		// Token: 0x04014966 RID: 84326
		[Token(Token = "0x4014966")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x04014967 RID: 84327
		[Token(Token = "0x4014967")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014968 RID: 84328
		[Token(Token = "0x4014968")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014969 RID: 84329
		[Token(Token = "0x4014969")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x0401496A RID: 84330
		[Token(Token = "0x401496A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x0401496B RID: 84331
		[Token(Token = "0x401496B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0401496C RID: 84332
		[Token(Token = "0x401496C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x0401496D RID: 84333
		[Token(Token = "0x401496D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckProjectileNameOnApplied;

		// Token: 0x0401496E RID: 84334
		[Token(Token = "0x401496E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
