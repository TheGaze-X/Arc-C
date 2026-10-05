using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BFA RID: 11258
	[Token(Token = "0x2002BFA")]
	public class ScreenEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x0601303B RID: 77883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601303B")]
		[Address(RVA = "0xAE9FB0", Offset = "0xAE8BB0", VA = "0x180AE9FB0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0601303C RID: 77884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601303C")]
		[Address(RVA = "0xAEA2C0", Offset = "0xAE8EC0", VA = "0x180AEA2C0")]
		private void _ClearEffect()
		{
		}

		// Token: 0x0601303D RID: 77885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601303D")]
		[Address(RVA = "0xAE9F00", Offset = "0xAE8B00", VA = "0x180AE9F00", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601303E RID: 77886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601303E")]
		[Address(RVA = "0xAEA440", Offset = "0xAE9040", VA = "0x180AEA440")]
		public ScreenEffectEmitter()
		{
		}

		// Token: 0x0601303F RID: 77887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601303F")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015796 RID: 87958
		[Token(Token = "0x4015796")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effect;

		// Token: 0x04015797 RID: 87959
		[Token(Token = "0x4015797")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityStandard.Event _startEv;

		// Token: 0x04015798 RID: 87960
		[Token(Token = "0x4015798")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbilityStandard.Event _endEv;

		// Token: 0x04015799 RID: 87961
		[Token(Token = "0x4015799")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isCameraEffect;

		// Token: 0x0401579A RID: 87962
		[Token(Token = "0x401579A")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Effect> m_effect;

		// Token: 0x0401579B RID: 87963
		[Token(Token = "0x401579B")]
		[FieldOffset(Offset = "0x48")]
		private CameraEffect m_cameraEffect;

		// Token: 0x0401579C RID: 87964
		[Token(Token = "0x401579C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401579D RID: 87965
		[Token(Token = "0x401579D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ClearEffect;

		// Token: 0x0401579E RID: 87966
		[Token(Token = "0x401579E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401579F RID: 87967
		[Token(Token = "0x401579F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
