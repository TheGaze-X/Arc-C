using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B2F RID: 11055
	[Token(Token = "0x2002B2F")]
	public class DsdevrMarkTileAuraAbility : AbilityStandard
	{
		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06012871 RID: 75889 RVA: 0x00071940 File Offset: 0x0006FB40
		[Token(Token = "0x170028CE")]
		private bool hasEffect
		{
			[Token(Token = "0x6012871")]
			[Address(RVA = "0xA7F920", Offset = "0xA7E520", VA = "0x180A7F920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06012872 RID: 75890 RVA: 0x00071958 File Offset: 0x0006FB58
		[Token(Token = "0x170028CF")]
		public override FP cooldown
		{
			[Token(Token = "0x6012872")]
			[Address(RVA = "0xA7F880", Offset = "0xA7E480", VA = "0x180A7F880", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x06012873 RID: 75891 RVA: 0x00071970 File Offset: 0x0006FB70
		[Token(Token = "0x170028D0")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012873")]
			[Address(RVA = "0xA7F810", Offset = "0xA7E410", VA = "0x180A7F810", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06012874 RID: 75892 RVA: 0x00071988 File Offset: 0x0006FB88
		[Token(Token = "0x170028D1")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012874")]
			[Address(RVA = "0xA7F9A0", Offset = "0xA7E5A0", VA = "0x180A7F9A0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06012875 RID: 75893 RVA: 0x000719A0 File Offset: 0x0006FBA0
		[Token(Token = "0x170028D2")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012875")]
			[Address(RVA = "0xA7F7A0", Offset = "0xA7E3A0", VA = "0x180A7F7A0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012876")]
		[Address(RVA = "0xA7E390", Offset = "0xA7CF90", VA = "0x180A7E390", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012877 RID: 75895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012877")]
		[Address(RVA = "0xA7E480", Offset = "0xA7D080", VA = "0x180A7E480", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012878")]
		[Address(RVA = "0xA7E410", Offset = "0xA7D010", VA = "0x180A7E410", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012879 RID: 75897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012879")]
		[Address(RVA = "0xA7E320", Offset = "0xA7CF20", VA = "0x180A7E320", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601287A")]
		[Address(RVA = "0xA7E5D0", Offset = "0xA7D1D0", VA = "0x180A7E5D0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x0601287B RID: 75899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601287B")]
		[Address(RVA = "0xA7E520", Offset = "0xA7D120", VA = "0x180A7E520", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601287C")]
		[Address(RVA = "0xA7E260", Offset = "0xA7CE60", VA = "0x180A7E260", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601287D")]
		[Address(RVA = "0xA7E130", Offset = "0xA7CD30", VA = "0x180A7E130", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601287E RID: 75902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601287E")]
		[Address(RVA = "0xA7DEB0", Offset = "0xA7CAB0", VA = "0x180A7DEB0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601287F RID: 75903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601287F")]
		[Address(RVA = "0xA7DFF0", Offset = "0xA7CBF0", VA = "0x180A7DFF0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012880 RID: 75904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012880")]
		[Address(RVA = "0xA7F520", Offset = "0xA7E120", VA = "0x180A7F520")]
		private void _clearAll()
		{
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012881")]
		[Address(RVA = "0xA7F220", Offset = "0xA7DE20", VA = "0x180A7F220")]
		private void _UpdateEffects()
		{
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012882")]
		[Address(RVA = "0xA7F020", Offset = "0xA7DC20", VA = "0x180A7F020")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012883")]
		[Address(RVA = "0xA7ED50", Offset = "0xA7D950", VA = "0x180A7ED50")]
		private IEnumerator _DelayUpdateTargets()
		{
			return null;
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012884")]
		[Address(RVA = "0xA7EE10", Offset = "0xA7DA10", VA = "0x180A7EE10")]
		private void _FilterTiles()
		{
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012885")]
		[Address(RVA = "0xA7E910", Offset = "0xA7D510", VA = "0x180A7E910")]
		private void _CreateMarkEnemy()
		{
		}

		// Token: 0x06012886 RID: 75910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012886")]
		[Address(RVA = "0xA7EC50", Offset = "0xA7D850", VA = "0x180A7EC50")]
		private IEnumerator _DelayCreateEnemy(GridPosition position, FP delay)
		{
			return null;
		}

		// Token: 0x06012887 RID: 75911 RVA: 0x000719B8 File Offset: 0x0006FBB8
		[Token(Token = "0x6012887")]
		[Address(RVA = "0xA7E680", Offset = "0xA7D280", VA = "0x180A7E680")]
		private int _Comparer(DsdevrMarkTileAuraAbility.TargetTileBundle a, DsdevrMarkTileAuraAbility.TargetTileBundle b)
		{
			return 0;
		}

		// Token: 0x06012888 RID: 75912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012888")]
		[Address(RVA = "0xA7F6D0", Offset = "0xA7E2D0", VA = "0x180A7F6D0")]
		public DsdevrMarkTileAuraAbility()
		{
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601288A")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601288B")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601288C")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601288D RID: 75917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601288D")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04014EFE RID: 85758
		[Token(Token = "0x4014EFE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FP CREATE_MARK_INTERVAL;

		// Token: 0x04014EFF RID: 85759
		[Token(Token = "0x4014EFF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float MARK_ENEMY_WAIT_TIME;

		// Token: 0x04014F00 RID: 85760
		[Token(Token = "0x4014F00")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private int _maxTarget;

		// Token: 0x04014F01 RID: 85761
		[Token(Token = "0x4014F01")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _tileEffect;

		// Token: 0x04014F02 RID: 85762
		[Token(Token = "0x4014F02")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _markEnemyKey;

		// Token: 0x04014F03 RID: 85763
		[Token(Token = "0x4014F03")]
		[FieldOffset(Offset = "0x128")]
		private int m_maxTarget;

		// Token: 0x04014F04 RID: 85764
		[Token(Token = "0x4014F04")]
		[FieldOffset(Offset = "0x130")]
		private CoroutineId m_coroutine;

		// Token: 0x04014F05 RID: 85765
		[Token(Token = "0x4014F05")]
		[FieldOffset(Offset = "0x140")]
		private List<DsdevrMarkTileAuraAbility.TargetTileBundle> m_targetTileBundles;

		// Token: 0x04014F06 RID: 85766
		[Token(Token = "0x4014F06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasEffect;

		// Token: 0x04014F07 RID: 85767
		[Token(Token = "0x4014F07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014F08 RID: 85768
		[Token(Token = "0x4014F08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014F09 RID: 85769
		[Token(Token = "0x4014F09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014F0A RID: 85770
		[Token(Token = "0x4014F0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014F0B RID: 85771
		[Token(Token = "0x4014F0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014F0C RID: 85772
		[Token(Token = "0x4014F0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014F0D RID: 85773
		[Token(Token = "0x4014F0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014F0E RID: 85774
		[Token(Token = "0x4014F0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014F0F RID: 85775
		[Token(Token = "0x4014F0F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014F10 RID: 85776
		[Token(Token = "0x4014F10")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014F11 RID: 85777
		[Token(Token = "0x4014F11")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014F12 RID: 85778
		[Token(Token = "0x4014F12")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014F13 RID: 85779
		[Token(Token = "0x4014F13")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014F14 RID: 85780
		[Token(Token = "0x4014F14")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014F15 RID: 85781
		[Token(Token = "0x4014F15")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__clearAll;

		// Token: 0x04014F16 RID: 85782
		[Token(Token = "0x4014F16")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateEffects;

		// Token: 0x04014F17 RID: 85783
		[Token(Token = "0x4014F17")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04014F18 RID: 85784
		[Token(Token = "0x4014F18")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DelayUpdateTargets;

		// Token: 0x04014F19 RID: 85785
		[Token(Token = "0x4014F19")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FilterTiles;

		// Token: 0x04014F1A RID: 85786
		[Token(Token = "0x4014F1A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CreateMarkEnemy;

		// Token: 0x04014F1B RID: 85787
		[Token(Token = "0x4014F1B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__DelayCreateEnemy;

		// Token: 0x04014F1C RID: 85788
		[Token(Token = "0x4014F1C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Comparer;

		// Token: 0x04014F1D RID: 85789
		[Token(Token = "0x4014F1D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B30 RID: 11056
		[Token(Token = "0x2002B30")]
		private class TargetTileBundle
		{
			// Token: 0x170028D3 RID: 10451
			// (get) Token: 0x0601288E RID: 75918 RVA: 0x000719D0 File Offset: 0x0006FBD0
			[Token(Token = "0x170028D3")]
			public bool hasEffect
			{
				[Token(Token = "0x601288E")]
				[Address(RVA = "0xA92120", Offset = "0xA90D20", VA = "0x180A92120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601288F RID: 75919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601288F")]
			[Address(RVA = "0xA92090", Offset = "0xA90C90", VA = "0x180A92090")]
			public void ClearEffect()
			{
			}

			// Token: 0x06012890 RID: 75920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012890")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TargetTileBundle()
			{
			}

			// Token: 0x04014F1E RID: 85790
			[Token(Token = "0x4014F1E")]
			[FieldOffset(Offset = "0x10")]
			public Tile tile;

			// Token: 0x04014F1F RID: 85791
			[Token(Token = "0x4014F1F")]
			[FieldOffset(Offset = "0x18")]
			public List<Enemy> enemies;

			// Token: 0x04014F20 RID: 85792
			[Token(Token = "0x4014F20")]
			[FieldOffset(Offset = "0x20")]
			public FP createdTime;

			// Token: 0x04014F21 RID: 85793
			[Token(Token = "0x4014F21")]
			[FieldOffset(Offset = "0x28")]
			public ObjectPtr<Effect> effect;
		}
	}
}
