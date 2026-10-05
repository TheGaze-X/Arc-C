using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BEA RID: 11242
	[Token(Token = "0x2002BEA")]
	public class ChannelingEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x06012FC2 RID: 77762 RVA: 0x000744D8 File Offset: 0x000726D8
		[Token(Token = "0x170029DE")]
		protected FP nextEscapeTime
		{
			[Token(Token = "0x6012FC2")]
			[Address(RVA = "0xADF4B0", Offset = "0xADE0B0", VA = "0x180ADF4B0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06012FC3 RID: 77763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC3")]
		[Address(RVA = "0xADEDC0", Offset = "0xADD9C0", VA = "0x180ADEDC0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FC4 RID: 77764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC4")]
		[Address(RVA = "0xADEB80", Offset = "0xADD780", VA = "0x180ADEB80", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012FC5 RID: 77765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC5")]
		[Address(RVA = "0xADED60", Offset = "0xADD960", VA = "0x180ADED60", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012FC6 RID: 77766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC6")]
		[Address(RVA = "0xADEB10", Offset = "0xADD710", VA = "0x180ADEB10", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012FC7 RID: 77767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC7")]
		[Address(RVA = "0xADF0B0", Offset = "0xADDCB0", VA = "0x180ADF0B0", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012FC8 RID: 77768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC8")]
		[Address(RVA = "0xADE9F0", Offset = "0xADD5F0", VA = "0x180ADE9F0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012FC9 RID: 77769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FC9")]
		[Address(RVA = "0xADEA90", Offset = "0xADD690", VA = "0x180ADEA90", Slot = "18")]
		protected virtual void OnAttackFinished(object arg)
		{
		}

		// Token: 0x06012FCA RID: 77770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCA")]
		[Address(RVA = "0xADF280", Offset = "0xADDE80", VA = "0x180ADF280")]
		private void _StopEffectIfNot()
		{
		}

		// Token: 0x06012FCB RID: 77771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCB")]
		[Address(RVA = "0xADF1A0", Offset = "0xADDDA0", VA = "0x180ADF1A0")]
		private void _ClearEffectIfNot()
		{
		}

		// Token: 0x06012FCC RID: 77772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCC")]
		[Address(RVA = "0xADF400", Offset = "0xADE000", VA = "0x180ADF400")]
		public ChannelingEffectEmitter()
		{
		}

		// Token: 0x06012FCD RID: 77773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCD")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012FCE RID: 77774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCE")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06012FCF RID: 77775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FCF")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012FD0 RID: 77776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD0")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012FD1 RID: 77777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD1")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015709 RID: 87817
		[Token(Token = "0x4015709")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _playOnEvent;

		// Token: 0x0401570A RID: 87818
		[Token(Token = "0x401570A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effect;

		// Token: 0x0401570B RID: 87819
		[Token(Token = "0x401570B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbilityStandard.Event _stopOnEvent;

		// Token: 0x0401570C RID: 87820
		[Token(Token = "0x401570C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _stopOnAttackFinished;

		// Token: 0x0401570D RID: 87821
		[Token(Token = "0x401570D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _hitEffect;

		// Token: 0x0401570E RID: 87822
		[Token(Token = "0x401570E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_casted;

		// Token: 0x0401570F RID: 87823
		[Token(Token = "0x401570F")]
		[FieldOffset(Offset = "0x41")]
		private bool m_stopped;

		// Token: 0x04015710 RID: 87824
		[Token(Token = "0x4015710")]
		[FieldOffset(Offset = "0x48")]
		private FP m_nextEscapeTime;

		// Token: 0x04015711 RID: 87825
		[Token(Token = "0x4015711")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Effect> m_effectHolder;

		// Token: 0x04015712 RID: 87826
		[Token(Token = "0x4015712")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nextEscapeTime;

		// Token: 0x04015713 RID: 87827
		[Token(Token = "0x4015713")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015714 RID: 87828
		[Token(Token = "0x4015714")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015715 RID: 87829
		[Token(Token = "0x4015715")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015716 RID: 87830
		[Token(Token = "0x4015716")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015717 RID: 87831
		[Token(Token = "0x4015717")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015718 RID: 87832
		[Token(Token = "0x4015718")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015719 RID: 87833
		[Token(Token = "0x4015719")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAttackFinished;

		// Token: 0x0401571A RID: 87834
		[Token(Token = "0x401571A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopEffectIfNot;

		// Token: 0x0401571B RID: 87835
		[Token(Token = "0x401571B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearEffectIfNot;

		// Token: 0x0401571C RID: 87836
		[Token(Token = "0x401571C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
