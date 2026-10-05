using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200417A RID: 16762
	[Token(Token = "0x200417A")]
	public class SandboxV2RiftSettleState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06019DE5 RID: 105957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DE5")]
		[Address(RVA = "0x12C76A0", Offset = "0x12C62A0", VA = "0x1812C76A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019DE6 RID: 105958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE6")]
		[Address(RVA = "0x12C7700", Offset = "0x12C6300", VA = "0x1812C7700", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019DE7 RID: 105959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE7")]
		[Address(RVA = "0x12C79C0", Offset = "0x12C65C0", VA = "0x1812C79C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019DE8 RID: 105960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE8")]
		[Address(RVA = "0x12C7910", Offset = "0x12C6510", VA = "0x1812C7910", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019DE9 RID: 105961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE9")]
		[Address(RVA = "0x12C7A60", Offset = "0x12C6660", VA = "0x1812C7A60")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x06019DEA RID: 105962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DEA")]
		[Address(RVA = "0x12C7D40", Offset = "0x12C6940", VA = "0x1812C7D40")]
		public SandboxV2RiftSettleState()
		{
		}

		// Token: 0x06019DEB RID: 105963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DEB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402080A RID: 133130
		[Token(Token = "0x402080A")]
		[NonSerialized]
		public const int ON_CONFIRM_CLICKED = 0;

		// Token: 0x0402080B RID: 133131
		[Token(Token = "0x402080B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RiftSettleView _view;

		// Token: 0x0402080C RID: 133132
		[Token(Token = "0x402080C")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2RiftSettleStateBean m_stateBean;

		// Token: 0x0402080D RID: 133133
		[Token(Token = "0x402080D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402080E RID: 133134
		[Token(Token = "0x402080E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402080F RID: 133135
		[Token(Token = "0x402080F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020810 RID: 133136
		[Token(Token = "0x4020810")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020811 RID: 133137
		[Token(Token = "0x4020811")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020812 RID: 133138
		[Token(Token = "0x4020812")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x04020813 RID: 133139
		[Token(Token = "0x4020813")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
