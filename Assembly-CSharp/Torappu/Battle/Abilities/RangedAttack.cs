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
	// Token: 0x02002ABE RID: 10942
	[Token(Token = "0x2002ABE")]
	public class RangedAttack : AbstractBasicAttack, IOnPrefabUpdated
	{
		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0601237B RID: 74619 RVA: 0x0006FA98 File Offset: 0x0006DC98
		[Token(Token = "0x170027F4")]
		public virtual bool waitForProjectileInvalid
		{
			[Token(Token = "0x601237B")]
			[Address(RVA = "0xA477C0", Offset = "0xA463C0", VA = "0x180A477C0", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0601237C RID: 74620 RVA: 0x0006FAB0 File Offset: 0x0006DCB0
		[Token(Token = "0x170027F5")]
		protected virtual bool emitToInputPosWhenTargetIsInvalid
		{
			[Token(Token = "0x601237C")]
			[Address(RVA = "0xA4B7B0", Offset = "0xA4A3B0", VA = "0x180A4B7B0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0601237D RID: 74621 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		[Token(Token = "0x170027F6")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x601237D")]
			[Address(RVA = "0xA4B6F0", Offset = "0xA4A2F0", VA = "0x180A4B6F0", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0601237E RID: 74622 RVA: 0x0006FAE0 File Offset: 0x0006DCE0
		[Token(Token = "0x170027F7")]
		protected override DamageType damageType
		{
			[Token(Token = "0x601237E")]
			[Address(RVA = "0xA4B750", Offset = "0xA4A350", VA = "0x180A4B750", Slot = "108")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0601237F RID: 74623 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
		[Token(Token = "0x170027F8")]
		protected override DamageType extraDamageType
		{
			[Token(Token = "0x601237F")]
			[Address(RVA = "0xA4B810", Offset = "0xA4A410", VA = "0x180A4B810", Slot = "109")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06012380 RID: 74624 RVA: 0x0006FB10 File Offset: 0x0006DD10
		[Token(Token = "0x170027F9")]
		protected bool useCachedAtkOnly
		{
			[Token(Token = "0x6012380")]
			[Address(RVA = "0xA4B930", Offset = "0xA4A530", VA = "0x180A4B930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06012381 RID: 74625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027FA")]
		protected string projectileKey
		{
			[Token(Token = "0x6012381")]
			[Address(RVA = "0xA4B8D0", Offset = "0xA4A4D0", VA = "0x180A4B8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06012382 RID: 74626 RVA: 0x0006FB28 File Offset: 0x0006DD28
		[Token(Token = "0x170027FB")]
		private bool useMountGroup
		{
			[Token(Token = "0x6012382")]
			[Address(RVA = "0xA4B990", Offset = "0xA4A590", VA = "0x180A4B990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06012383 RID: 74627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170027FC")]
		public List<Entity.MountPointType> mountPointCache
		{
			[Token(Token = "0x6012383")]
			[Address(RVA = "0xA4B870", Offset = "0xA4A470", VA = "0x180A4B870")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012384 RID: 74628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012384")]
		[Address(RVA = "0xA4AE00", Offset = "0xA49A00", VA = "0x180A4AE00", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012385 RID: 74629 RVA: 0x0006FB40 File Offset: 0x0006DD40
		[Token(Token = "0x6012385")]
		[Address(RVA = "0xA4B0C0", Offset = "0xA49CC0", VA = "0x180A4B0C0", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012386 RID: 74630 RVA: 0x0006FB58 File Offset: 0x0006DD58
		[Token(Token = "0x6012386")]
		[Address(RVA = "0xA49AD0", Offset = "0xA486D0", VA = "0x180A49AD0", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012387 RID: 74631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012387")]
		[Address(RVA = "0xA4A810", Offset = "0xA49410", VA = "0x180A4A810", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012388 RID: 74632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012388")]
		[Address(RVA = "0xA4A190", Offset = "0xA48D90", VA = "0x180A4A190")]
		protected ILocatable GetTargetLocatable(Entity target)
		{
			return null;
		}

		// Token: 0x06012389 RID: 74633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012389")]
		[Address(RVA = "0xA4A050", Offset = "0xA48C50", VA = "0x180A4A050", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601238A RID: 74634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601238A")]
		[Address(RVA = "0xA4A0C0", Offset = "0xA48CC0", VA = "0x180A4A0C0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601238B RID: 74635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601238B")]
		[Address(RVA = "0xA49F00", Offset = "0xA48B00", VA = "0x180A49F00", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601238C RID: 74636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601238C")]
		[Address(RVA = "0xA4AFB0", Offset = "0xA49BB0", VA = "0x180A4AFB0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x0601238D RID: 74637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601238D")]
		[Address(RVA = "0xA4B460", Offset = "0xA4A060", VA = "0x180A4B460")]
		private void _ClearMountPointsCache()
		{
		}

		// Token: 0x0601238E RID: 74638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601238E")]
		[Address(RVA = "0xA4AF00", Offset = "0xA49B00", VA = "0x180A4AF00", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601238F RID: 74639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601238F")]
		[Address(RVA = "0xA4A750", Offset = "0xA49350", VA = "0x180A4A750", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012390 RID: 74640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012390")]
		[Address(RVA = "0xA49680", Offset = "0xA48280", VA = "0x180A49680", Slot = "64")]
		public override void ClearProjectile()
		{
		}

		// Token: 0x06012391 RID: 74641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012391")]
		[Address(RVA = "0xA4A420", Offset = "0xA49020", VA = "0x180A4A420", Slot = "103")]
		protected override Nodes.ApplyDamage NewDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x06012392 RID: 74642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012392")]
		[Address(RVA = "0xA49830", Offset = "0xA48430", VA = "0x180A49830", Slot = "113")]
		protected virtual Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x06012393 RID: 74643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012393")]
		[Address(RVA = "0xA4B4E0", Offset = "0xA4A0E0", VA = "0x180A4B4E0")]
		private MountPoint _GetMountPoint()
		{
			return null;
		}

		// Token: 0x06012394 RID: 74644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012394")]
		[Address(RVA = "0xA35FA0", Offset = "0xA34BA0", VA = "0x180A35FA0", Slot = "114")]
		protected virtual string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012395 RID: 74645 RVA: 0x0006FB70 File Offset: 0x0006DD70
		[Token(Token = "0x6012395")]
		[Address(RVA = "0xA4B2E0", Offset = "0xA49EE0", VA = "0x180A4B2E0")]
		private bool _CheckProjectileValid()
		{
			return default(bool);
		}

		// Token: 0x06012396 RID: 74646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012396")]
		[Address(RVA = "0xA49580", Offset = "0xA48180", VA = "0x180A49580", Slot = "115")]
		protected virtual void CheckProjectileNameOnApplied(string projectileKey)
		{
		}

		// Token: 0x06012397 RID: 74647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012397")]
		[Address(RVA = "0xA4AEA0", Offset = "0xA49AA0", VA = "0x180A4AEA0", Slot = "110")]
		public void OnPrefabUpdated()
		{
		}

		// Token: 0x06012398 RID: 74648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012398")]
		[Address(RVA = "0xA4A5B0", Offset = "0xA491B0", VA = "0x180A4A5B0", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012399 RID: 74649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012399")]
		[Address(RVA = "0xA4B620", Offset = "0xA4A220", VA = "0x180A4B620")]
		public RangedAttack()
		{
		}

		// Token: 0x0601239B RID: 74651 RVA: 0x0006FB88 File Offset: 0x0006DD88
		[Token(Token = "0x601239B")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x0601239C RID: 74652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601239C")]
		[Address(RVA = "0xA1FD50", Offset = "0xA1E950", VA = "0x180A1FD50")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601239D RID: 74653 RVA: 0x0006FBA0 File Offset: 0x0006DDA0
		[Token(Token = "0x601239D")]
		[Address(RVA = "0xA25D30", Offset = "0xA24930", VA = "0x180A25D30")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0601239E RID: 74654 RVA: 0x0006FBB8 File Offset: 0x0006DDB8
		[Token(Token = "0x601239E")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x0601239F RID: 74655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601239F")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060123A0 RID: 74656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123A0")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x060123A1 RID: 74657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123A1")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060123A2 RID: 74658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123A2")]
		[Address(RVA = "0xA4B060", Offset = "0xA49C60", VA = "0x180A4B060")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x060123A3 RID: 74659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123A3")]
		[Address(RVA = "0xA275C0", Offset = "0xA261C0", VA = "0x180A275C0")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060123A4 RID: 74660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123A4")]
		[Address(RVA = "0xA4B070", Offset = "0xA49C70", VA = "0x180A4B070")]
		private void <>xLuaBaseProxy_ClearProjectile()
		{
		}

		// Token: 0x060123A5 RID: 74661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123A5")]
		[Address(RVA = "0xA4B090", Offset = "0xA49C90", VA = "0x180A4B090")]
		private Nodes.ApplyDamage <>xLuaBaseProxy_NewDamageNode(DamageType P0, FP P1)
		{
			return null;
		}

		// Token: 0x060123A6 RID: 74662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123A6")]
		[Address(RVA = "0xA4B0A0", Offset = "0xA49CA0", VA = "0x180A4B0A0")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x040149AD RID: 84397
		[Token(Token = "0x40149AD")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x040149AE RID: 84398
		[Token(Token = "0x40149AE")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Inspect("useMountGroup", false)]
		private Entity.MountPointType _mountPointType;

		// Token: 0x040149AF RID: 84399
		[Token(Token = "0x40149AF")]
		[FieldOffset(Offset = "0x214")]
		[SerializeField]
		private bool _useMountGroup;

		// Token: 0x040149B0 RID: 84400
		[Token(Token = "0x40149B0")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Inspect("useMountGroup")]
		private Entity.MountPointGroup _mountGroup;

		// Token: 0x040149B1 RID: 84401
		[Token(Token = "0x40149B1")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private DamageType _damageType;

		// Token: 0x040149B2 RID: 84402
		[Token(Token = "0x40149B2")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		private bool _waitForProjectileInvalid;

		// Token: 0x040149B3 RID: 84403
		[Token(Token = "0x40149B3")]
		[FieldOffset(Offset = "0x225")]
		[SerializeField]
		[Inspect("waitForProjectileInvalid")]
		private bool _notClearProjectileWhenCastEnd;

		// Token: 0x040149B4 RID: 84404
		[Token(Token = "0x40149B4")]
		[FieldOffset(Offset = "0x226")]
		[SerializeField]
		[Inspect("waitForProjectileInvalid")]
		private bool _fireAttackFinishWhenProjectileInvalid;

		// Token: 0x040149B5 RID: 84405
		[Token(Token = "0x40149B5")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[Inspect("waitForProjectileInvalid")]
		private float _minPostDelayWhenProjectileInvalid;

		// Token: 0x040149B6 RID: 84406
		[Token(Token = "0x40149B6")]
		[FieldOffset(Offset = "0x22C")]
		[SerializeField]
		[Inspect("waitForProjectileInvalid")]
		private bool _waitForAnimEndWhenProjectileInvalid;

		// Token: 0x040149B7 RID: 84407
		[Token(Token = "0x40149B7")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private RangedAttack.ProjectileDestinationType _projectileDestination;

		// Token: 0x040149B8 RID: 84408
		[Token(Token = "0x40149B8")]
		[FieldOffset(Offset = "0x234")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private DamageType _extraDamageType;

		// Token: 0x040149B9 RID: 84409
		[Token(Token = "0x40149B9")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private bool _emitToInputPosWhenTargetIsInvalid;

		// Token: 0x040149BA RID: 84410
		[Token(Token = "0x40149BA")]
		[FieldOffset(Offset = "0x239")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private bool _emitToInputRootTileWhenTargetIsInvalid;

		// Token: 0x040149BB RID: 84411
		[Token(Token = "0x40149BB")]
		[FieldOffset(Offset = "0x23A")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private bool _useCachedAtkOnly;

		// Token: 0x040149BC RID: 84412
		[Token(Token = "0x40149BC")]
		[FieldOffset(Offset = "0x23B")]
		[SerializeField]
		[Inspect("useCachedAtkOnly")]
		[Group("Detail", Priority = 1)]
		private bool _transferSource;

		// Token: 0x040149BD RID: 84413
		[Token(Token = "0x40149BD")]
		[FieldOffset(Offset = "0x240")]
		[Group("Detail", Priority = 1)]
		[Tooltip("Used to preload extra projectiles emitted by projectile.\n eg. skchr_archet_1 ScatteredProjectileHitBehaviour")]
		[SerializeField]
		private string[] _extraProjectileKeys;

		// Token: 0x040149BE RID: 84414
		[Token(Token = "0x40149BE")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private bool _fireCreateProjectileEvent;

		// Token: 0x040149BF RID: 84415
		[Token(Token = "0x40149BF")]
		[FieldOffset(Offset = "0x250")]
		protected List<ObjectPtr<Projectile>> m_projectiles;

		// Token: 0x040149C0 RID: 84416
		[Token(Token = "0x40149C0")]
		[FieldOffset(Offset = "0x258")]
		private List<Entity.MountPointType> m_mountPointsCache;

		// Token: 0x040149C1 RID: 84417
		[Token(Token = "0x40149C1")]
		[FieldOffset(Offset = "0x260")]
		private int m_mountPointIndex;

		// Token: 0x040149C2 RID: 84418
		[Token(Token = "0x40149C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitForProjectileInvalid;

		// Token: 0x040149C3 RID: 84419
		[Token(Token = "0x40149C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_emitToInputPosWhenTargetIsInvalid;

		// Token: 0x040149C4 RID: 84420
		[Token(Token = "0x40149C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x040149C5 RID: 84421
		[Token(Token = "0x40149C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x040149C6 RID: 84422
		[Token(Token = "0x40149C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_extraDamageType;

		// Token: 0x040149C7 RID: 84423
		[Token(Token = "0x40149C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useCachedAtkOnly;

		// Token: 0x040149C8 RID: 84424
		[Token(Token = "0x40149C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_projectileKey;

		// Token: 0x040149C9 RID: 84425
		[Token(Token = "0x40149C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_useMountGroup;

		// Token: 0x040149CA RID: 84426
		[Token(Token = "0x40149CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_mountPointCache;

		// Token: 0x040149CB RID: 84427
		[Token(Token = "0x40149CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040149CC RID: 84428
		[Token(Token = "0x40149CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x040149CD RID: 84429
		[Token(Token = "0x40149CD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040149CE RID: 84430
		[Token(Token = "0x40149CE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040149CF RID: 84431
		[Token(Token = "0x40149CF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTargetLocatable;

		// Token: 0x040149D0 RID: 84432
		[Token(Token = "0x40149D0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040149D1 RID: 84433
		[Token(Token = "0x40149D1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040149D2 RID: 84434
		[Token(Token = "0x40149D2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x040149D3 RID: 84435
		[Token(Token = "0x40149D3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040149D4 RID: 84436
		[Token(Token = "0x40149D4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearMountPointsCache;

		// Token: 0x040149D5 RID: 84437
		[Token(Token = "0x40149D5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x040149D6 RID: 84438
		[Token(Token = "0x40149D6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x040149D7 RID: 84439
		[Token(Token = "0x40149D7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ClearProjectile;

		// Token: 0x040149D8 RID: 84440
		[Token(Token = "0x40149D8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_NewDamageNode;

		// Token: 0x040149D9 RID: 84441
		[Token(Token = "0x40149D9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x040149DA RID: 84442
		[Token(Token = "0x40149DA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetMountPoint;

		// Token: 0x040149DB RID: 84443
		[Token(Token = "0x40149DB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x040149DC RID: 84444
		[Token(Token = "0x40149DC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckProjectileValid;

		// Token: 0x040149DD RID: 84445
		[Token(Token = "0x40149DD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckProjectileNameOnApplied;

		// Token: 0x040149DE RID: 84446
		[Token(Token = "0x40149DE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnPrefabUpdated;

		// Token: 0x040149DF RID: 84447
		[Token(Token = "0x40149DF")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x040149E0 RID: 84448
		[Token(Token = "0x40149E0")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002ABF RID: 10943
		[Token(Token = "0x2002ABF")]
		public enum ProjectileDestinationType
		{
			// Token: 0x040149E2 RID: 84450
			[Token(Token = "0x40149E2")]
			TARGET,
			// Token: 0x040149E3 RID: 84451
			[Token(Token = "0x40149E3")]
			INPUT_POINT,
			// Token: 0x040149E4 RID: 84452
			[Token(Token = "0x40149E4")]
			INPUT_VECTOR3,
			// Token: 0x040149E5 RID: 84453
			[Token(Token = "0x40149E5")]
			TARGET_ROOT_TILE,
			// Token: 0x040149E6 RID: 84454
			[Token(Token = "0x40149E6")]
			INPUT_VEC3_WITH_TILE_HEIGHT
		}
	}
}
