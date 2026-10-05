using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003360 RID: 13152
	[Token(Token = "0x2003360")]
	public class UIHudCharSpSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x06014FD4 RID: 85972 RVA: 0x00089F70 File Offset: 0x00088170
		[Token(Token = "0x170031D6")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FD4")]
			[Address(RVA = "0xD748A0", Offset = "0xD734A0", VA = "0x180D748A0", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x06014FD5 RID: 85973 RVA: 0x00089F88 File Offset: 0x00088188
		[Token(Token = "0x170031D7")]
		public bool needToShow
		{
			[Token(Token = "0x6014FD5")]
			[Address(RVA = "0xD74900", Offset = "0xD73500", VA = "0x180D74900", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FD6 RID: 85974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD6")]
		[Address(RVA = "0xD744D0", Offset = "0xD730D0", VA = "0x180D744D0", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FD7 RID: 85975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD7")]
		[Address(RVA = "0xD74620", Offset = "0xD73220", VA = "0x180D74620", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FD8 RID: 85976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD8")]
		[Address(RVA = "0xD74680", Offset = "0xD73280", VA = "0x180D74680", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FD9 RID: 85977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD9")]
		[Address(RVA = "0xD74840", Offset = "0xD73440", VA = "0x180D74840")]
		public UIHudCharSpSlider()
		{
		}

		// Token: 0x04018F7C RID: 102268
		[Token(Token = "0x4018F7C")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F7D RID: 102269
		[Token(Token = "0x4018F7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F7E RID: 102270
		[Token(Token = "0x4018F7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F7F RID: 102271
		[Token(Token = "0x4018F7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F80 RID: 102272
		[Token(Token = "0x4018F80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F81 RID: 102273
		[Token(Token = "0x4018F81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F82 RID: 102274
		[Token(Token = "0x4018F82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
