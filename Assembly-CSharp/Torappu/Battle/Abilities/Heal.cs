using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD5 RID: 10965
	[Token(Token = "0x2002AD5")]
	public class Heal : AbstractAnimatedAbility
	{
		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x06012460 RID: 74848 RVA: 0x0006FEE8 File Offset: 0x0006E0E8
		[Token(Token = "0x17002813")]
		protected bool isCont
		{
			[Token(Token = "0x6012460")]
			[Address(RVA = "0xA55570", Offset = "0xA54170", VA = "0x180A55570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x06012461 RID: 74849 RVA: 0x0006FF00 File Offset: 0x0006E100
		[Token(Token = "0x17002814")]
		protected bool ignoreHealFree
		{
			[Token(Token = "0x6012461")]
			[Address(RVA = "0xA55510", Offset = "0xA54110", VA = "0x180A55510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x06012462 RID: 74850 RVA: 0x0006FF18 File Offset: 0x0006E118
		[Token(Token = "0x17002815")]
		protected bool isHpRatio
		{
			[Token(Token = "0x6012462")]
			[Address(RVA = "0xA555D0", Offset = "0xA541D0", VA = "0x180A555D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x06012463 RID: 74851 RVA: 0x0006FF30 File Offset: 0x0006E130
		[Token(Token = "0x17002816")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x6012463")]
			[Address(RVA = "0xA55420", Offset = "0xA54020", VA = "0x180A55420", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06012464 RID: 74852 RVA: 0x0006FF48 File Offset: 0x0006E148
		[Token(Token = "0x17002817")]
		public FP healScale
		{
			[Token(Token = "0x6012464")]
			[Address(RVA = "0xA55480", Offset = "0xA54080", VA = "0x180A55480")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06012465 RID: 74853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012465")]
		[Address(RVA = "0xA55000", Offset = "0xA53C00", VA = "0x180A55000", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012466 RID: 74854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012466")]
		[Address(RVA = "0xA55080", Offset = "0xA53C80", VA = "0x180A55080", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012467 RID: 74855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012467")]
		[Address(RVA = "0xA54AB0", Offset = "0xA536B0", VA = "0x180A54AB0")]
		public void ApplyHealScale(FP healScale, bool overwrite = false, bool createNewNode = false)
		{
		}

		// Token: 0x06012468 RID: 74856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012468")]
		[Address(RVA = "0xA549F0", Offset = "0xA535F0", VA = "0x180A549F0")]
		public void ApplyElementHealScale(FP elementHealScale, bool overwrite = false)
		{
		}

		// Token: 0x06012469 RID: 74857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012469")]
		[Address(RVA = "0xA54940", Offset = "0xA53540", VA = "0x180A54940")]
		public void ApplyElementHealScaleForElementHealNode(FP elementHealScale)
		{
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601246A")]
		[Address(RVA = "0xA54C60", Offset = "0xA53860", VA = "0x180A54C60", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601246B")]
		[Address(RVA = "0xA55210", Offset = "0xA53E10", VA = "0x180A55210", Slot = "108")]
		protected virtual Nodes.ApplyHeal NewHealNode(FP healScale)
		{
			return null;
		}

		// Token: 0x0601246C RID: 74860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601246C")]
		[Address(RVA = "0xA55110", Offset = "0xA53D10", VA = "0x180A55110", Slot = "109")]
		protected virtual Nodes.ApplyElementHeal NewElementHealNode()
		{
			return null;
		}

		// Token: 0x0601246D RID: 74861 RVA: 0x0006FF60 File Offset: 0x0006E160
		[Token(Token = "0x601246D")]
		[Address(RVA = "0xA54C00", Offset = "0xA53800", VA = "0x180A54C00", Slot = "89")]
		protected override bool CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x0601246E RID: 74862 RVA: 0x0006FF78 File Offset: 0x0006E178
		[Token(Token = "0x601246E")]
		[Address(RVA = "0xA54FA0", Offset = "0xA53BA0", VA = "0x180A54FA0", Slot = "90")]
		protected override ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601246F")]
		[Address(RVA = "0xA55320", Offset = "0xA53F20", VA = "0x180A55320")]
		public Heal()
		{
		}

		// Token: 0x06012470 RID: 74864 RVA: 0x0006FF90 File Offset: 0x0006E190
		[Token(Token = "0x6012470")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x06012471 RID: 74865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012471")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012472 RID: 74866 RVA: 0x0006FFA8 File Offset: 0x0006E1A8
		[Token(Token = "0x6012472")]
		[Address(RVA = "0xA1E4D0", Offset = "0xA1D0D0", VA = "0x180A1E4D0")]
		private bool <>xLuaBaseProxy_CheckIsDamageOrHealSource()
		{
			return default(bool);
		}

		// Token: 0x06012473 RID: 74867 RVA: 0x0006FFC0 File Offset: 0x0006E1C0
		[Token(Token = "0x6012473")]
		[Address(RVA = "0xA1E510", Offset = "0xA1D110", VA = "0x180A1E510")]
		private ActionPurposeMask <>xLuaBaseProxy_GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x04014A9B RID: 84635
		[Token(Token = "0x4014A9B")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private bool _isCont;

		// Token: 0x04014A9C RID: 84636
		[Token(Token = "0x4014A9C")]
		[FieldOffset(Offset = "0x1C9")]
		[SerializeField]
		private bool _isHpRatio;

		// Token: 0x04014A9D RID: 84637
		[Token(Token = "0x4014A9D")]
		[FieldOffset(Offset = "0x1CA")]
		[SerializeField]
		private bool _hasNoActionNode;

		// Token: 0x04014A9E RID: 84638
		[Token(Token = "0x4014A9E")]
		[FieldOffset(Offset = "0x1CB")]
		[SerializeField]
		private bool _ignoreHealFree;

		// Token: 0x04014A9F RID: 84639
		[Token(Token = "0x4014A9F")]
		[FieldOffset(Offset = "0x1CC")]
		[SerializeField]
		private bool _applyEPHeal;

		// Token: 0x04014AA0 RID: 84640
		[Token(Token = "0x4014AA0")]
		[FieldOffset(Offset = "0x1CD")]
		[SerializeField]
		private bool _applyHealScaleToEPHealScale;

		// Token: 0x04014AA1 RID: 84641
		[Token(Token = "0x4014AA1")]
		[FieldOffset(Offset = "0x1D0")]
		protected float m_healScale;

		// Token: 0x04014AA2 RID: 84642
		[Token(Token = "0x4014AA2")]
		[FieldOffset(Offset = "0x1D8")]
		protected Nodes.ApplyHeal m_healNode;

		// Token: 0x04014AA3 RID: 84643
		[Token(Token = "0x4014AA3")]
		[FieldOffset(Offset = "0x1E0")]
		protected List<ActionNode> m_actions;

		// Token: 0x04014AA4 RID: 84644
		[Token(Token = "0x4014AA4")]
		[FieldOffset(Offset = "0x1E8")]
		protected FP m_elementHealScale;

		// Token: 0x04014AA5 RID: 84645
		[Token(Token = "0x4014AA5")]
		[FieldOffset(Offset = "0x1F0")]
		protected Nodes.ApplyElementHeal m_elementHealNode;

		// Token: 0x04014AA6 RID: 84646
		[Token(Token = "0x4014AA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCont;

		// Token: 0x04014AA7 RID: 84647
		[Token(Token = "0x4014AA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04014AA8 RID: 84648
		[Token(Token = "0x4014AA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isHpRatio;

		// Token: 0x04014AA9 RID: 84649
		[Token(Token = "0x4014AA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04014AAA RID: 84650
		[Token(Token = "0x4014AAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_healScale;

		// Token: 0x04014AAB RID: 84651
		[Token(Token = "0x4014AAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014AAC RID: 84652
		[Token(Token = "0x4014AAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014AAD RID: 84653
		[Token(Token = "0x4014AAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyHealScale;

		// Token: 0x04014AAE RID: 84654
		[Token(Token = "0x4014AAE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyElementHealScale;

		// Token: 0x04014AAF RID: 84655
		[Token(Token = "0x4014AAF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyElementHealScaleForElementHealNode;

		// Token: 0x04014AB0 RID: 84656
		[Token(Token = "0x4014AB0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014AB1 RID: 84657
		[Token(Token = "0x4014AB1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NewHealNode;

		// Token: 0x04014AB2 RID: 84658
		[Token(Token = "0x4014AB2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_NewElementHealNode;

		// Token: 0x04014AB3 RID: 84659
		[Token(Token = "0x4014AB3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIsDamageOrHealSource;

		// Token: 0x04014AB4 RID: 84660
		[Token(Token = "0x4014AB4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x04014AB5 RID: 84661
		[Token(Token = "0x4014AB5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
