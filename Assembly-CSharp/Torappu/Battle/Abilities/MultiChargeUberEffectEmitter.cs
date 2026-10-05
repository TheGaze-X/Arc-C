using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BEF RID: 11247
	[Token(Token = "0x2002BEF")]
	[RequireComponent(typeof(IMultiChargeUberEffectEmitterAbility))]
	public class MultiChargeUberEffectEmitter : UberEffectEmitter
	{
		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x06012FF5 RID: 77813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029E1")]
		protected MultiChargeUberEffectEmitter.ChargeEffectGroup[] chargeEffectGroups
		{
			[Token(Token = "0x6012FF5")]
			[Address(RVA = "0xAE7070", Offset = "0xAE5C70", VA = "0x180AE7070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x06012FF6 RID: 77814 RVA: 0x00074538 File Offset: 0x00072738
		[Token(Token = "0x170029E2")]
		protected int chargeIndex
		{
			[Token(Token = "0x6012FF6")]
			[Address(RVA = "0xAE70D0", Offset = "0xAE5CD0", VA = "0x180AE70D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06012FF7 RID: 77815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FF7")]
		[Address(RVA = "0xAE6180", Offset = "0xAE4D80", VA = "0x180AE6180", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06012FF8 RID: 77816 RVA: 0x00074550 File Offset: 0x00072750
		[Token(Token = "0x6012FF8")]
		[Address(RVA = "0xAE6070", Offset = "0xAE4C70", VA = "0x180AE6070", Slot = "18")]
		protected virtual int GetChargeIndex()
		{
			return 0;
		}

		// Token: 0x06012FF9 RID: 77817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FF9")]
		[Address(RVA = "0xAE6740", Offset = "0xAE5340", VA = "0x180AE6740", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012FFA RID: 77818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FFA")]
		[Address(RVA = "0xAE6430", Offset = "0xAE5030", VA = "0x180AE6430", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012FFB RID: 77819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FFB")]
		[Address(RVA = "0xAE65D0", Offset = "0xAE51D0", VA = "0x180AE65D0", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012FFC RID: 77820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FFC")]
		[Address(RVA = "0xAE6900", Offset = "0xAE5500", VA = "0x180AE6900", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FFD RID: 77821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FFD")]
		[Address(RVA = "0xAE5F00", Offset = "0xAE4B00", VA = "0x180AE5F00", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012FFE RID: 77822 RVA: 0x00074568 File Offset: 0x00072768
		[Token(Token = "0x6012FFE")]
		[Address(RVA = "0xAE63B0", Offset = "0xAE4FB0", VA = "0x180AE63B0", Slot = "19")]
		protected virtual bool IsInChargeAction()
		{
			return default(bool);
		}

		// Token: 0x06012FFF RID: 77823 RVA: 0x00074580 File Offset: 0x00072780
		[Token(Token = "0x6012FFF")]
		[Address(RVA = "0xAE6E20", Offset = "0xAE5A20", VA = "0x180AE6E20")]
		private bool _CheckChargeActionValid()
		{
			return default(bool);
		}

		// Token: 0x06013000 RID: 77824 RVA: 0x00074598 File Offset: 0x00072798
		[Token(Token = "0x6013000")]
		[Address(RVA = "0xAE6F70", Offset = "0xAE5B70", VA = "0x180AE6F70")]
		private bool _CheckChargeIndexValid()
		{
			return default(bool);
		}

		// Token: 0x06013001 RID: 77825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013001")]
		[Address(RVA = "0xAE7000", Offset = "0xAE5C00", VA = "0x180AE7000")]
		public MultiChargeUberEffectEmitter()
		{
		}

		// Token: 0x06013002 RID: 77826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013002")]
		[Address(RVA = "0xAE6DD0", Offset = "0xAE59D0", VA = "0x180AE6DD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013003 RID: 77827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013003")]
		[Address(RVA = "0xAE6E00", Offset = "0xAE5A00", VA = "0x180AE6E00")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06013004 RID: 77828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013004")]
		[Address(RVA = "0xAE6DE0", Offset = "0xAE59E0", VA = "0x180AE6DE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06013005 RID: 77829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013005")]
		[Address(RVA = "0xAE6DF0", Offset = "0xAE59F0", VA = "0x180AE6DF0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06013006 RID: 77830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013006")]
		[Address(RVA = "0xAE6E10", Offset = "0xAE5A10", VA = "0x180AE6E10")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06013007 RID: 77831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013007")]
		[Address(RVA = "0xAE6DC0", Offset = "0xAE59C0", VA = "0x180AE6DC0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0401574E RID: 87886
		[Token(Token = "0x401574E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MultiChargeUberEffectEmitter.ChargeEffectGroup[] _chargeEffectGroups;

		// Token: 0x0401574F RID: 87887
		[Token(Token = "0x401574F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MultiChargeUberEffectEmitter.ChargeCastGroup[] _chargeCastGroups;

		// Token: 0x04015750 RID: 87888
		[Token(Token = "0x4015750")]
		[FieldOffset(Offset = "0x68")]
		private IMultiChargeUberEffectEmitterAbility m_chargeAbility;

		// Token: 0x04015751 RID: 87889
		[Token(Token = "0x4015751")]
		[FieldOffset(Offset = "0x70")]
		private int m_chargeIndex;

		// Token: 0x04015752 RID: 87890
		[Token(Token = "0x4015752")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chargeEffectGroups;

		// Token: 0x04015753 RID: 87891
		[Token(Token = "0x4015753")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_chargeIndex;

		// Token: 0x04015754 RID: 87892
		[Token(Token = "0x4015754")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04015755 RID: 87893
		[Token(Token = "0x4015755")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetChargeIndex;

		// Token: 0x04015756 RID: 87894
		[Token(Token = "0x4015756")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015757 RID: 87895
		[Token(Token = "0x4015757")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015758 RID: 87896
		[Token(Token = "0x4015758")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015759 RID: 87897
		[Token(Token = "0x4015759")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401575A RID: 87898
		[Token(Token = "0x401575A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401575B RID: 87899
		[Token(Token = "0x401575B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsInChargeAction;

		// Token: 0x0401575C RID: 87900
		[Token(Token = "0x401575C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckChargeActionValid;

		// Token: 0x0401575D RID: 87901
		[Token(Token = "0x401575D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckChargeIndexValid;

		// Token: 0x0401575E RID: 87902
		[Token(Token = "0x401575E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BF0 RID: 11248
		[Token(Token = "0x2002BF0")]
		[Serializable]
		public class ChargeEffectOptions : UberEffectEmitter.CastEffectOptions
		{
			// Token: 0x06013008 RID: 77832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6013008")]
			[Address(RVA = "0xAE0B00", Offset = "0xADF700", VA = "0x180AE0B00", Slot = "9")]
			protected override Effect CreateEffect(string effect)
			{
				return null;
			}

			// Token: 0x06013009 RID: 77833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6013009")]
			[Address(RVA = "0xAE09A0", Offset = "0xADF5A0", VA = "0x180AE09A0")]
			public void ClearChargeEffects()
			{
			}

			// Token: 0x0601300A RID: 77834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601300A")]
			[Address(RVA = "0xAE0C00", Offset = "0xADF800", VA = "0x180AE0C00")]
			public ChargeEffectOptions()
			{
			}

			// Token: 0x0401575F RID: 87903
			[Token(Token = "0x401575F")]
			[FieldOffset(Offset = "0x60")]
			protected List<ObjectPtr<Effect>> m_chargeEffects;
		}

		// Token: 0x02002BF1 RID: 11249
		[Token(Token = "0x2002BF1")]
		[Serializable]
		public struct ChargeEffectGroup
		{
			// Token: 0x0601300B RID: 77835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601300B")]
			[Address(RVA = "0xAE08F0", Offset = "0xADF4F0", VA = "0x180AE08F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04015760 RID: 87904
			[Token(Token = "0x4015760")]
			[FieldOffset(Offset = "0x0")]
			public MultiChargeUberEffectEmitter.ChargeEffectOptions[] effects;
		}

		// Token: 0x02002BF2 RID: 11250
		[Token(Token = "0x2002BF2")]
		[Serializable]
		public struct ChargeCastGroup
		{
			// Token: 0x0601300C RID: 77836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601300C")]
			[Address(RVA = "0xAE0840", Offset = "0xADF440", VA = "0x180AE0840", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04015761 RID: 87905
			[Token(Token = "0x4015761")]
			[FieldOffset(Offset = "0x0")]
			public UberEffectEmitter.CastEffectOptions[] effects;
		}
	}
}
