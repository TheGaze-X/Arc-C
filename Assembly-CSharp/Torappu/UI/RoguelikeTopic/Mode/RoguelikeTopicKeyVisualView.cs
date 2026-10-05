using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x0200466F RID: 18031
	[Token(Token = "0x200466F")]
	public class RoguelikeTopicKeyVisualView : RoguelikeTopicSubView
	{
		// Token: 0x0601B604 RID: 112132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B604")]
		[Address(RVA = "0x14BAEC0", Offset = "0x14B9AC0", VA = "0x1814BAEC0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B605 RID: 112133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B605")]
		[Address(RVA = "0x14BB420", Offset = "0x14BA020", VA = "0x1814BB420", Slot = "8")]
		public override void SetEffectEnable(bool enable)
		{
		}

		// Token: 0x0601B606 RID: 112134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B606")]
		[Address(RVA = "0x14BB5A0", Offset = "0x14BA1A0", VA = "0x1814BB5A0")]
		public RoguelikeTopicKeyVisualView()
		{
		}

		// Token: 0x0601B607 RID: 112135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B607")]
		[Address(RVA = "0x14BB4E0", Offset = "0x14BA0E0", VA = "0x1814BB4E0")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B608")]
		[Address(RVA = "0x14BB540", Offset = "0x14BA140", VA = "0x1814BB540")]
		private void <>xLuaBaseProxy_SetEffectEnable(bool P0)
		{
		}

		// Token: 0x0402360D RID: 144909
		[Token(Token = "0x402360D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] _bgContainers;

		// Token: 0x0402360E RID: 144910
		[Token(Token = "0x402360E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _bgEffectContainer;

		// Token: 0x0402360F RID: 144911
		[Token(Token = "0x402360F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _fgContainer;

		// Token: 0x04023610 RID: 144912
		[Token(Token = "0x4023610")]
		[FieldOffset(Offset = "0x40")]
		private string m_KVName;

		// Token: 0x04023611 RID: 144913
		[Token(Token = "0x4023611")]
		[FieldOffset(Offset = "0x48")]
		private UICommonPageEffectHolder m_effectHolder;

		// Token: 0x04023612 RID: 144914
		[Token(Token = "0x4023612")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023613 RID: 144915
		[Token(Token = "0x4023613")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x04023614 RID: 144916
		[Token(Token = "0x4023614")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
