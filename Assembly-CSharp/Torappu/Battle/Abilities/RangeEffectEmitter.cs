using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BF7 RID: 11255
	[Token(Token = "0x2002BF7")]
	public class RangeEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x06013022 RID: 77858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013022")]
		[Address(RVA = "0xAE8C80", Offset = "0xAE7880", VA = "0x180AE8C80", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013023 RID: 77859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013023")]
		[Address(RVA = "0xAE8C10", Offset = "0xAE7810", VA = "0x180AE8C10", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013024 RID: 77860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013024")]
		[Address(RVA = "0xAE8B90", Offset = "0xAE7790", VA = "0x180AE8B90", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013025 RID: 77861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013025")]
		[Address(RVA = "0xAE8AF0", Offset = "0xAE76F0", VA = "0x180AE8AF0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013026 RID: 77862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013026")]
		[Address(RVA = "0xAE9070", Offset = "0xAE7C70", VA = "0x180AE9070")]
		private void _ClearEffects()
		{
		}

		// Token: 0x06013027 RID: 77863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013027")]
		[Address(RVA = "0xAE9210", Offset = "0xAE7E10", VA = "0x180AE9210")]
		public RangeEffectEmitter()
		{
		}

		// Token: 0x06013029 RID: 77865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013029")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0601302A RID: 77866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302A")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601302B RID: 77867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302B")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x04015777 RID: 87927
		[Token(Token = "0x4015777")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _playCastEffectOnEvent;

		// Token: 0x04015778 RID: 87928
		[Token(Token = "0x4015778")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _castEffects;

		// Token: 0x04015779 RID: 87929
		[Token(Token = "0x4015779")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbilityStandard.Event _stopCastEffectOnEvent;

		// Token: 0x0401577A RID: 87930
		[Token(Token = "0x401577A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _onlyCastOnce;

		// Token: 0x0401577B RID: 87931
		[Token(Token = "0x401577B")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _oneShot;

		// Token: 0x0401577C RID: 87932
		[Token(Token = "0x401577C")]
		[FieldOffset(Offset = "0x36")]
		[SerializeField]
		private bool _holdByOwner;

		// Token: 0x0401577D RID: 87933
		[Token(Token = "0x401577D")]
		[FieldOffset(Offset = "0x37")]
		private bool m_casted;

		// Token: 0x0401577E RID: 87934
		[Token(Token = "0x401577E")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x0401577F RID: 87935
		[Token(Token = "0x401577F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015780 RID: 87936
		[Token(Token = "0x4015780")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015781 RID: 87937
		[Token(Token = "0x4015781")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015782 RID: 87938
		[Token(Token = "0x4015782")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015783 RID: 87939
		[Token(Token = "0x4015783")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x04015784 RID: 87940
		[Token(Token = "0x4015784")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
