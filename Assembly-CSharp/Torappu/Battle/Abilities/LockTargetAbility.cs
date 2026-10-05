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
	// Token: 0x02002B29 RID: 11049
	[Token(Token = "0x2002B29")]
	public class LockTargetAbility : AbilityStandard
	{
		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0601283D RID: 75837 RVA: 0x00071838 File Offset: 0x0006FA38
		[Token(Token = "0x170028C6")]
		public override FP cooldown
		{
			[Token(Token = "0x601283D")]
			[Address(RVA = "0xA8B930", Offset = "0xA8A530", VA = "0x180A8B930", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0601283E RID: 75838 RVA: 0x00071850 File Offset: 0x0006FA50
		[Token(Token = "0x170028C7")]
		public override Ability.Category category
		{
			[Token(Token = "0x601283E")]
			[Address(RVA = "0xA8B8D0", Offset = "0xA8A4D0", VA = "0x180A8B8D0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0601283F RID: 75839 RVA: 0x00071868 File Offset: 0x0006FA68
		[Token(Token = "0x170028C8")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601283F")]
			[Address(RVA = "0xA8B9B0", Offset = "0xA8A5B0", VA = "0x180A8B9B0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06012840 RID: 75840 RVA: 0x00071880 File Offset: 0x0006FA80
		[Token(Token = "0x170028C9")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012840")]
			[Address(RVA = "0xA8B870", Offset = "0xA8A470", VA = "0x180A8B870", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012841 RID: 75841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012841")]
		[Address(RVA = "0xA8A5D0", Offset = "0xA891D0", VA = "0x180A8A5D0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012842 RID: 75842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012842")]
		[Address(RVA = "0xA8A6A0", Offset = "0xA892A0", VA = "0x180A8A6A0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012843")]
		[Address(RVA = "0xA8A640", Offset = "0xA89240", VA = "0x180A8A640", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012844 RID: 75844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012844")]
		[Address(RVA = "0xA8A570", Offset = "0xA89170", VA = "0x180A8A570", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012845 RID: 75845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012845")]
		[Address(RVA = "0xA8AFE0", Offset = "0xA89BE0", VA = "0x180A8AFE0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012846 RID: 75846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012846")]
		[Address(RVA = "0xA8AF50", Offset = "0xA89B50", VA = "0x180A8AF50", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012847 RID: 75847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012847")]
		[Address(RVA = "0xA8A2E0", Offset = "0xA88EE0", VA = "0x180A8A2E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012848")]
		[Address(RVA = "0xA8AA00", Offset = "0xA89600", VA = "0x180A8AA00", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012849")]
		[Address(RVA = "0xA8A140", Offset = "0xA88D40", VA = "0x180A8A140", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601284A RID: 75850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284A")]
		[Address(RVA = "0xA8A730", Offset = "0xA89330", VA = "0x180A8A730", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x0601284B RID: 75851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284B")]
		[Address(RVA = "0xA8A430", Offset = "0xA89030", VA = "0x180A8A430", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0601284C RID: 75852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284C")]
		[Address(RVA = "0xA8A4D0", Offset = "0xA890D0", VA = "0x180A8A4D0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601284D RID: 75853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284D")]
		[Address(RVA = "0xA8B070", Offset = "0xA89C70", VA = "0x180A8B070")]
		private void _UpdateTargets()
		{
		}

		// Token: 0x0601284E RID: 75854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284E")]
		[Address(RVA = "0xA8B730", Offset = "0xA8A330", VA = "0x180A8B730")]
		public LockTargetAbility()
		{
		}

		// Token: 0x0601284F RID: 75855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601284F")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012850 RID: 75856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012850")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012851 RID: 75857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012851")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012852 RID: 75858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012852")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012853 RID: 75859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012853")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012854 RID: 75860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012854")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04014ECD RID: 85709
		[Token(Token = "0x4014ECD")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _interval;

		// Token: 0x04014ECE RID: 85710
		[Token(Token = "0x4014ECE")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private BuffData _buff;

		// Token: 0x04014ECF RID: 85711
		[Token(Token = "0x4014ECF")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _lineEffect;

		// Token: 0x04014ED0 RID: 85712
		[Token(Token = "0x4014ED0")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private string _lineAudio;

		// Token: 0x04014ED1 RID: 85713
		[Token(Token = "0x4014ED1")]
		[FieldOffset(Offset = "0x130")]
		private List<ObjectPtr<Entity>> m_targetsLock;

		// Token: 0x04014ED2 RID: 85714
		[Token(Token = "0x4014ED2")]
		[FieldOffset(Offset = "0x138")]
		private List<ObjectPtr<Entity>> m_lastTargets;

		// Token: 0x04014ED3 RID: 85715
		[Token(Token = "0x4014ED3")]
		[FieldOffset(Offset = "0x140")]
		private ObjectPtr<Effect> m_effect;

		// Token: 0x04014ED4 RID: 85716
		[Token(Token = "0x4014ED4")]
		[FieldOffset(Offset = "0x150")]
		private PeriodicTimer m_tickTimer;

		// Token: 0x04014ED5 RID: 85717
		[Token(Token = "0x4014ED5")]
		[FieldOffset(Offset = "0x158")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04014ED6 RID: 85718
		[Token(Token = "0x4014ED6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014ED7 RID: 85719
		[Token(Token = "0x4014ED7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014ED8 RID: 85720
		[Token(Token = "0x4014ED8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014ED9 RID: 85721
		[Token(Token = "0x4014ED9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014EDA RID: 85722
		[Token(Token = "0x4014EDA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014EDB RID: 85723
		[Token(Token = "0x4014EDB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014EDC RID: 85724
		[Token(Token = "0x4014EDC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014EDD RID: 85725
		[Token(Token = "0x4014EDD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014EDE RID: 85726
		[Token(Token = "0x4014EDE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014EDF RID: 85727
		[Token(Token = "0x4014EDF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014EE0 RID: 85728
		[Token(Token = "0x4014EE0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014EE1 RID: 85729
		[Token(Token = "0x4014EE1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014EE2 RID: 85730
		[Token(Token = "0x4014EE2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014EE3 RID: 85731
		[Token(Token = "0x4014EE3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014EE4 RID: 85732
		[Token(Token = "0x4014EE4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014EE5 RID: 85733
		[Token(Token = "0x4014EE5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014EE6 RID: 85734
		[Token(Token = "0x4014EE6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateTargets;

		// Token: 0x04014EE7 RID: 85735
		[Token(Token = "0x4014EE7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
