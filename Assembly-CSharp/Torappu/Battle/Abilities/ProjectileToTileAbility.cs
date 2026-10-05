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
	// Token: 0x02002AEA RID: 10986
	[Token(Token = "0x2002AEA")]
	public class ProjectileToTileAbility : CastOnTileAbility
	{
		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06012564 RID: 75108 RVA: 0x000704D0 File Offset: 0x0006E6D0
		[Token(Token = "0x17002836")]
		public bool waitForProjectileInvalid
		{
			[Token(Token = "0x6012564")]
			[Address(RVA = "0xA5BB00", Offset = "0xA5A700", VA = "0x180A5BB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x06012565 RID: 75109 RVA: 0x000704E8 File Offset: 0x0006E6E8
		[Token(Token = "0x17002837")]
		public bool hasEpDamage
		{
			[Token(Token = "0x6012565")]
			[Address(RVA = "0xA5B980", Offset = "0xA5A580", VA = "0x180A5B980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x06012566 RID: 75110 RVA: 0x00070500 File Offset: 0x0006E700
		[Token(Token = "0x17002838")]
		public bool useCachedAtkOnly
		{
			[Token(Token = "0x6012566")]
			[Address(RVA = "0xA5BAA0", Offset = "0xA5A6A0", VA = "0x180A5BAA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x06012567 RID: 75111 RVA: 0x00070518 File Offset: 0x0006E718
		[Token(Token = "0x17002839")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x6012567")]
			[Address(RVA = "0xA5B860", Offset = "0xA5A460", VA = "0x180A5B860", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x06012568 RID: 75112 RVA: 0x00070530 File Offset: 0x0006E730
		[Token(Token = "0x1700283A")]
		protected override Modifier.SourceAttackType attackType
		{
			[Token(Token = "0x6012568")]
			[Address(RVA = "0xA5B920", Offset = "0xA5A520", VA = "0x180A5B920", Slot = "99")]
			get
			{
				return Modifier.SourceAttackType.NONE;
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x06012569 RID: 75113 RVA: 0x00070548 File Offset: 0x0006E748
		[Token(Token = "0x1700283B")]
		public FP atkScale
		{
			[Token(Token = "0x6012569")]
			[Address(RVA = "0xA5B8C0", Offset = "0xA5A4C0", VA = "0x180A5B8C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0601256A RID: 75114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700283C")]
		protected List<ObjectPtr<Projectile>> projectiles
		{
			[Token(Token = "0x601256A")]
			[Address(RVA = "0xA5BA40", Offset = "0xA5A640", VA = "0x180A5BA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0601256B RID: 75115 RVA: 0x00070560 File Offset: 0x0006E760
		[Token(Token = "0x1700283D")]
		protected Entity.MountPointType mountPointType
		{
			[Token(Token = "0x601256B")]
			[Address(RVA = "0xA5B9E0", Offset = "0xA5A5E0", VA = "0x180A5B9E0")]
			get
			{
				return Entity.MountPointType.FOOT;
			}
		}

		// Token: 0x0601256C RID: 75116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601256C")]
		[Address(RVA = "0xA5A850", Offset = "0xA59450", VA = "0x180A5A850", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601256D RID: 75117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601256D")]
		[Address(RVA = "0xA5ADD0", Offset = "0xA599D0", VA = "0x180A5ADD0", Slot = "103")]
		protected override Nodes.ApplyDamage NewDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x0601256E RID: 75118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601256E")]
		[Address(RVA = "0xA5AD00", Offset = "0xA59900", VA = "0x180A5AD00", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601256F RID: 75119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601256F")]
		[Address(RVA = "0xA59F00", Offset = "0xA58B00", VA = "0x180A59F00")]
		public void ApplyAtkScale(FP atkScale, bool overwrite = false, bool createNewNode = false, bool mergeDamgeNodeAtkScale = false)
		{
		}

		// Token: 0x06012570 RID: 75120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012570")]
		[Address(RVA = "0xA5A040", Offset = "0xA58C40", VA = "0x180A5A040")]
		public void ApplyElementDamageScale(FP epDamageScale, bool createNewNode = false)
		{
		}

		// Token: 0x06012571 RID: 75121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012571")]
		[Address(RVA = "0xA5A1E0", Offset = "0xA58DE0", VA = "0x180A5A1E0")]
		public void CreateAndReplaceDamageNode(float atkScale, IList<ActionNode> actionNodes)
		{
		}

		// Token: 0x06012572 RID: 75122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012572")]
		[Address(RVA = "0xA5ABD0", Offset = "0xA597D0", VA = "0x180A5ABD0", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012573 RID: 75123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012573")]
		[Address(RVA = "0xA5B490", Offset = "0xA5A090", VA = "0x180A5B490", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012574 RID: 75124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012574")]
		[Address(RVA = "0xA5AC90", Offset = "0xA59890", VA = "0x180A5AC90", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012575 RID: 75125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012575")]
		[Address(RVA = "0xA5B210", Offset = "0xA59E10", VA = "0x180A5B210", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012576 RID: 75126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012576")]
		[Address(RVA = "0xA5B130", Offset = "0xA59D30", VA = "0x180A5B130", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012577 RID: 75127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012577")]
		[Address(RVA = "0xA5A530", Offset = "0xA59130", VA = "0x180A5A530", Slot = "111")]
		protected virtual void CreateProjectileOnTile(Tile tile)
		{
		}

		// Token: 0x06012578 RID: 75128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012578")]
		[Address(RVA = "0xA5B3E0", Offset = "0xA59FE0", VA = "0x180A5B3E0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012579 RID: 75129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012579")]
		[Address(RVA = "0xA5AF60", Offset = "0xA59B60", VA = "0x180A5AF60", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0601257A RID: 75130 RVA: 0x00070578 File Offset: 0x0006E778
		[Token(Token = "0x601257A")]
		[Address(RVA = "0xA5A180", Offset = "0xA58D80", VA = "0x180A5A180", Slot = "89")]
		protected override bool CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x0601257B RID: 75131 RVA: 0x00070590 File Offset: 0x0006E790
		[Token(Token = "0x601257B")]
		[Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		private bool _CheckProjectileValid()
		{
			return default(bool);
		}

		// Token: 0x0601257C RID: 75132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601257C")]
		[Address(RVA = "0xA58A40", Offset = "0xA57640", VA = "0x180A58A40", Slot = "112")]
		protected virtual string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601257D RID: 75133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601257D")]
		[Address(RVA = "0xA5B6C0", Offset = "0xA5A2C0", VA = "0x180A5B6C0")]
		public ProjectileToTileAbility()
		{
		}

		// Token: 0x0601257F RID: 75135 RVA: 0x000705A8 File Offset: 0x0006E7A8
		[Token(Token = "0x601257F")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x06012580 RID: 75136 RVA: 0x000705C0 File Offset: 0x0006E7C0
		[Token(Token = "0x6012580")]
		[Address(RVA = "0xA1E540", Offset = "0xA1D140", VA = "0x180A1E540")]
		private Modifier.SourceAttackType <>xLuaBaseProxy_get_attackType()
		{
			return Modifier.SourceAttackType.NONE;
		}

		// Token: 0x06012581 RID: 75137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012581")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012582 RID: 75138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012582")]
		[Address(RVA = "0xA4B090", Offset = "0xA49C90", VA = "0x180A4B090")]
		private Nodes.ApplyDamage <>xLuaBaseProxy_NewDamageNode(DamageType P0, FP P1)
		{
			return null;
		}

		// Token: 0x06012583 RID: 75139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012583")]
		[Address(RVA = "0xA52A00", Offset = "0xA51600", VA = "0x180A52A00")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x06012584 RID: 75140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012584")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012585 RID: 75141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012585")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012586 RID: 75142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012586")]
		[Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012587 RID: 75143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012587")]
		[Address(RVA = "0xA4C4A0", Offset = "0xA4B0A0", VA = "0x180A4C4A0")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012588")]
		[Address(RVA = "0xA4B060", Offset = "0xA49C60", VA = "0x180A4B060")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012589 RID: 75145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012589")]
		[Address(RVA = "0xA4FF60", Offset = "0xA4EB60", VA = "0x180A4FF60")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601258A RID: 75146 RVA: 0x000705D8 File Offset: 0x0006E7D8
		[Token(Token = "0x601258A")]
		[Address(RVA = "0xA1E4D0", Offset = "0xA1D0D0", VA = "0x180A1E4D0")]
		private bool <>xLuaBaseProxy_CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x04014BAA RID: 84906
		[Token(Token = "0x4014BAA")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("CastOnTile")]
		private string _projectileKey;

		// Token: 0x04014BAB RID: 84907
		[Token(Token = "0x4014BAB")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("CastOnTile")]
		private Entity.MountPointType _mountPointType;

		// Token: 0x04014BAC RID: 84908
		[Token(Token = "0x4014BAC")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		[Group("CastOnTile")]
		private DamageType _damageType;

		// Token: 0x04014BAD RID: 84909
		[Token(Token = "0x4014BAD")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("CastOnTile")]
		private float _atkScale;

		// Token: 0x04014BAE RID: 84910
		[Token(Token = "0x4014BAE")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("CastOnTile")]
		private string _atkScaleKey;

		// Token: 0x04014BAF RID: 84911
		[Token(Token = "0x4014BAF")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Group("CastOnTile")]
		private ElementType _elementDamageType;

		// Token: 0x04014BB0 RID: 84912
		[Token(Token = "0x4014BB0")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		[Inspect("hasEpDamage")]
		private float _epDamageRatio;

		// Token: 0x04014BB1 RID: 84913
		[Token(Token = "0x4014BB1")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[Group("Detail", Priority = 1)]
		private bool _useCachedAtkOnly;

		// Token: 0x04014BB2 RID: 84914
		[Token(Token = "0x4014BB2")]
		[FieldOffset(Offset = "0x229")]
		[SerializeField]
		[Inspect("useCachedAtkOnly")]
		[Group("Detail", Priority = 1)]
		private bool _transferSource;

		// Token: 0x04014BB3 RID: 84915
		[Token(Token = "0x4014BB3")]
		[FieldOffset(Offset = "0x22A")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _finishProjectileWhenCastStart;

		// Token: 0x04014BB4 RID: 84916
		[Token(Token = "0x4014BB4")]
		[FieldOffset(Offset = "0x22B")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _notClearProjectileOnCastStart;

		// Token: 0x04014BB5 RID: 84917
		[Token(Token = "0x4014BB5")]
		[FieldOffset(Offset = "0x22C")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _waitForProjectileInvalid;

		// Token: 0x04014BB6 RID: 84918
		[Token(Token = "0x4014BB6")]
		[FieldOffset(Offset = "0x22D")]
		[SerializeField]
		[Group("CastOnTile")]
		[Inspect("waitForProjectileInvalid")]
		private bool _fireAttackFinishWhenProjectileInvalid;

		// Token: 0x04014BB7 RID: 84919
		[Token(Token = "0x4014BB7")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[Group("CastOnTile")]
		[Inspect("waitForProjectileInvalid")]
		private float _minPostDelayWhenProjectileInvalid;

		// Token: 0x04014BB8 RID: 84920
		[Token(Token = "0x4014BB8")]
		[FieldOffset(Offset = "0x234")]
		[SerializeField]
		private Modifier.SourceAttackType _attackType;

		// Token: 0x04014BB9 RID: 84921
		[Token(Token = "0x4014BB9")]
		[FieldOffset(Offset = "0x238")]
		private List<ObjectPtr<Projectile>> m_projectiles;

		// Token: 0x04014BBA RID: 84922
		[Token(Token = "0x4014BBA")]
		[FieldOffset(Offset = "0x240")]
		private FP m_epDamageRatio;

		// Token: 0x04014BBB RID: 84923
		[Token(Token = "0x4014BBB")]
		[FieldOffset(Offset = "0x248")]
		protected FP m_atkScale;

		// Token: 0x04014BBC RID: 84924
		[Token(Token = "0x4014BBC")]
		[FieldOffset(Offset = "0x250")]
		protected List<ActionNode> m_actions;

		// Token: 0x04014BBD RID: 84925
		[Token(Token = "0x4014BBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitForProjectileInvalid;

		// Token: 0x04014BBE RID: 84926
		[Token(Token = "0x4014BBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasEpDamage;

		// Token: 0x04014BBF RID: 84927
		[Token(Token = "0x4014BBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_useCachedAtkOnly;

		// Token: 0x04014BC0 RID: 84928
		[Token(Token = "0x4014BC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04014BC1 RID: 84929
		[Token(Token = "0x4014BC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_attackType;

		// Token: 0x04014BC2 RID: 84930
		[Token(Token = "0x4014BC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_atkScale;

		// Token: 0x04014BC3 RID: 84931
		[Token(Token = "0x4014BC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_projectiles;

		// Token: 0x04014BC4 RID: 84932
		[Token(Token = "0x4014BC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_mountPointType;

		// Token: 0x04014BC5 RID: 84933
		[Token(Token = "0x4014BC5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014BC6 RID: 84934
		[Token(Token = "0x4014BC6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NewDamageNode;

		// Token: 0x04014BC7 RID: 84935
		[Token(Token = "0x4014BC7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014BC8 RID: 84936
		[Token(Token = "0x4014BC8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ApplyAtkScale;

		// Token: 0x04014BC9 RID: 84937
		[Token(Token = "0x4014BC9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ApplyElementDamageScale;

		// Token: 0x04014BCA RID: 84938
		[Token(Token = "0x4014BCA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateAndReplaceDamageNode;

		// Token: 0x04014BCB RID: 84939
		[Token(Token = "0x4014BCB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014BCC RID: 84940
		[Token(Token = "0x4014BCC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014BCD RID: 84941
		[Token(Token = "0x4014BCD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014BCE RID: 84942
		[Token(Token = "0x4014BCE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014BCF RID: 84943
		[Token(Token = "0x4014BCF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014BD0 RID: 84944
		[Token(Token = "0x4014BD0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CreateProjectileOnTile;

		// Token: 0x04014BD1 RID: 84945
		[Token(Token = "0x4014BD1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014BD2 RID: 84946
		[Token(Token = "0x4014BD2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014BD3 RID: 84947
		[Token(Token = "0x4014BD3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckIsDamageOrHealSource;

		// Token: 0x04014BD4 RID: 84948
		[Token(Token = "0x4014BD4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckProjectileValid;

		// Token: 0x04014BD5 RID: 84949
		[Token(Token = "0x4014BD5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x04014BD6 RID: 84950
		[Token(Token = "0x4014BD6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
