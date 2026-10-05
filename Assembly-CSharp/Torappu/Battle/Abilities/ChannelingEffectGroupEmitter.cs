using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BEB RID: 11243
	[Token(Token = "0x2002BEB")]
	public class ChannelingEffectGroupEmitter : ChannelingEffectEmitter
	{
		// Token: 0x06012FD2 RID: 77778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD2")]
		[Address(RVA = "0xADF960", Offset = "0xADE560", VA = "0x180ADF960", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FD3 RID: 77779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD3")]
		[Address(RVA = "0xADF840", Offset = "0xADE440", VA = "0x180ADF840", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012FD4 RID: 77780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD4")]
		[Address(RVA = "0xADF7C0", Offset = "0xADE3C0", VA = "0x180ADF7C0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012FD5 RID: 77781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD5")]
		[Address(RVA = "0xADFDA0", Offset = "0xADE9A0", VA = "0x180ADFDA0", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012FD6 RID: 77782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD6")]
		[Address(RVA = "0xADF510", Offset = "0xADE110", VA = "0x180ADF510", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012FD7 RID: 77783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD7")]
		[Address(RVA = "0xADF690", Offset = "0xADE290", VA = "0x180ADF690", Slot = "18")]
		protected override void OnAttackFinished(object arg)
		{
		}

		// Token: 0x06012FD8 RID: 77784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD8")]
		[Address(RVA = "0xAE0360", Offset = "0xADEF60", VA = "0x180AE0360")]
		private void _OnExtraAttackFired(object arg)
		{
		}

		// Token: 0x06012FD9 RID: 77785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FD9")]
		[Address(RVA = "0xAE05C0", Offset = "0xADF1C0", VA = "0x180AE05C0")]
		private void _StopEffectGroupIfNot(ChannelingEffectGroupEmitter.EventGroup eventGroup)
		{
		}

		// Token: 0x06012FDA RID: 77786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDA")]
		[Address(RVA = "0xAE01E0", Offset = "0xADEDE0", VA = "0x180AE01E0")]
		private void _ClearEffectGroupIfNot(ChannelingEffectGroupEmitter.EventGroup eventGroup)
		{
		}

		// Token: 0x06012FDB RID: 77787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDB")]
		[Address(RVA = "0xADFFB0", Offset = "0xADEBB0", VA = "0x180ADFFB0")]
		private void _ClearAllEffectGroupIfNot()
		{
		}

		// Token: 0x06012FDC RID: 77788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDC")]
		[Address(RVA = "0xAE0700", Offset = "0xADF300", VA = "0x180AE0700")]
		public ChannelingEffectGroupEmitter()
		{
		}

		// Token: 0x06012FDD RID: 77789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDD")]
		[Address(RVA = "0xADFF90", Offset = "0xADEB90", VA = "0x180ADFF90")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012FDE RID: 77790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDE")]
		[Address(RVA = "0xADED60", Offset = "0xADD960", VA = "0x180ADED60")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012FDF RID: 77791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FDF")]
		[Address(RVA = "0xADEB10", Offset = "0xADD710", VA = "0x180ADEB10")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012FE0 RID: 77792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE0")]
		[Address(RVA = "0xADFFA0", Offset = "0xADEBA0", VA = "0x180ADFFA0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012FE1 RID: 77793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE1")]
		[Address(RVA = "0xADE9F0", Offset = "0xADD5F0", VA = "0x180ADE9F0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x06012FE2 RID: 77794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE2")]
		[Address(RVA = "0xADFF80", Offset = "0xADEB80", VA = "0x180ADFF80")]
		private void <>xLuaBaseProxy_OnAttackFinished(object P0)
		{
		}

		// Token: 0x0401571D RID: 87837
		[Token(Token = "0x401571D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<ChannelingEffectGroupEmitter.EventGroup> _extraEventGroup;

		// Token: 0x0401571E RID: 87838
		[Token(Token = "0x401571E")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, ObjectPtr<Effect>> m_effectHolderDict;

		// Token: 0x0401571F RID: 87839
		[Token(Token = "0x401571F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015720 RID: 87840
		[Token(Token = "0x4015720")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015721 RID: 87841
		[Token(Token = "0x4015721")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015722 RID: 87842
		[Token(Token = "0x4015722")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015723 RID: 87843
		[Token(Token = "0x4015723")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015724 RID: 87844
		[Token(Token = "0x4015724")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAttackFinished;

		// Token: 0x04015725 RID: 87845
		[Token(Token = "0x4015725")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnExtraAttackFired;

		// Token: 0x04015726 RID: 87846
		[Token(Token = "0x4015726")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopEffectGroupIfNot;

		// Token: 0x04015727 RID: 87847
		[Token(Token = "0x4015727")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearEffectGroupIfNot;

		// Token: 0x04015728 RID: 87848
		[Token(Token = "0x4015728")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearAllEffectGroupIfNot;

		// Token: 0x04015729 RID: 87849
		[Token(Token = "0x4015729")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BEC RID: 11244
		[Token(Token = "0x2002BEC")]
		[Serializable]
		public struct EventGroup
		{
			// Token: 0x0401572A RID: 87850
			[Token(Token = "0x401572A")]
			[FieldOffset(Offset = "0x0")]
			public AbilityStandard.Event playOnEvent;

			// Token: 0x0401572B RID: 87851
			[Token(Token = "0x401572B")]
			[FieldOffset(Offset = "0x8")]
			public string effect;

			// Token: 0x0401572C RID: 87852
			[Token(Token = "0x401572C")]
			[FieldOffset(Offset = "0x10")]
			public AbilityStandard.Event stopOnEvent;

			// Token: 0x0401572D RID: 87853
			[Token(Token = "0x401572D")]
			[FieldOffset(Offset = "0x14")]
			public bool stopOnAttackFinished;

			// Token: 0x0401572E RID: 87854
			[Token(Token = "0x401572E")]
			[FieldOffset(Offset = "0x15")]
			[NonSerialized]
			public bool isCasted;

			// Token: 0x0401572F RID: 87855
			[Token(Token = "0x401572F")]
			[FieldOffset(Offset = "0x16")]
			[NonSerialized]
			public bool isStopped;
		}
	}
}
