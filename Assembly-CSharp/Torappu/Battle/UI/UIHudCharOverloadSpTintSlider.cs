using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335D RID: 13149
	[Token(Token = "0x200335D")]
	public class UIHudCharOverloadSpTintSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x06014FBC RID: 85948 RVA: 0x00089EB0 File Offset: 0x000880B0
		[Token(Token = "0x170031D0")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FBC")]
			[Address(RVA = "0xD5D940", Offset = "0xD5C540", VA = "0x180D5D940", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x06014FBD RID: 85949 RVA: 0x00089EC8 File Offset: 0x000880C8
		[Token(Token = "0x170031D1")]
		public bool needToShow
		{
			[Token(Token = "0x6014FBD")]
			[Address(RVA = "0xD5D9A0", Offset = "0xD5C5A0", VA = "0x180D5D9A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FBE RID: 85950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FBE")]
		[Address(RVA = "0xD5D360", Offset = "0xD5BF60", VA = "0x180D5D360", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FBF RID: 85951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FBF")]
		[Address(RVA = "0xD5D4B0", Offset = "0xD5C0B0", VA = "0x180D5D4B0", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FC0 RID: 85952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC0")]
		[Address(RVA = "0xD5D510", Offset = "0xD5C110", VA = "0x180D5D510", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FC1 RID: 85953 RVA: 0x00089EE0 File Offset: 0x000880E0
		[Token(Token = "0x6014FC1")]
		[Address(RVA = "0xD5D750", Offset = "0xD5C350", VA = "0x180D5D750")]
		private static float _GetOverloadSpProgress(Character character)
		{
			return 0f;
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FC2")]
		[Address(RVA = "0xD5D8E0", Offset = "0xD5C4E0", VA = "0x180D5D8E0")]
		public UIHudCharOverloadSpTintSlider()
		{
		}

		// Token: 0x04018F57 RID: 102231
		[Token(Token = "0x4018F57")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F58 RID: 102232
		[Token(Token = "0x4018F58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F59 RID: 102233
		[Token(Token = "0x4018F59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F5A RID: 102234
		[Token(Token = "0x4018F5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F5B RID: 102235
		[Token(Token = "0x4018F5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F5C RID: 102236
		[Token(Token = "0x4018F5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F5D RID: 102237
		[Token(Token = "0x4018F5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetOverloadSpProgress;

		// Token: 0x04018F5E RID: 102238
		[Token(Token = "0x4018F5E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
