using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335F RID: 13151
	[Token(Token = "0x200335F")]
	public class UIHudCharSpCastSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x06014FCD RID: 85965 RVA: 0x00089F28 File Offset: 0x00088128
		[Token(Token = "0x170031D4")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FCD")]
			[Address(RVA = "0xD5F740", Offset = "0xD5E340", VA = "0x180D5F740", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x06014FCE RID: 85966 RVA: 0x00089F40 File Offset: 0x00088140
		[Token(Token = "0x170031D5")]
		public bool needToShow
		{
			[Token(Token = "0x6014FCE")]
			[Address(RVA = "0xD5F7A0", Offset = "0xD5E3A0", VA = "0x180D5F7A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FCF RID: 85967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FCF")]
		[Address(RVA = "0xD5F000", Offset = "0xD5DC00", VA = "0x180D5F000", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FD0 RID: 85968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD0")]
		[Address(RVA = "0xD5F150", Offset = "0xD5DD50", VA = "0x180D5F150", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FD1 RID: 85969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD1")]
		[Address(RVA = "0xD5F1B0", Offset = "0xD5DDB0", VA = "0x180D5F1B0", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FD2 RID: 85970 RVA: 0x00089F58 File Offset: 0x00088158
		[Token(Token = "0x6014FD2")]
		[Address(RVA = "0xD5F540", Offset = "0xD5E140", VA = "0x180D5F540")]
		private float _GetOverloadSpProgress(Character character)
		{
			return 0f;
		}

		// Token: 0x06014FD3 RID: 85971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FD3")]
		[Address(RVA = "0xD5F6E0", Offset = "0xD5E2E0", VA = "0x180D5F6E0")]
		public UIHudCharSpCastSlider()
		{
		}

		// Token: 0x04018F74 RID: 102260
		[Token(Token = "0x4018F74")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F75 RID: 102261
		[Token(Token = "0x4018F75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F76 RID: 102262
		[Token(Token = "0x4018F76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F77 RID: 102263
		[Token(Token = "0x4018F77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F78 RID: 102264
		[Token(Token = "0x4018F78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F79 RID: 102265
		[Token(Token = "0x4018F79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F7A RID: 102266
		[Token(Token = "0x4018F7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetOverloadSpProgress;

		// Token: 0x04018F7B RID: 102267
		[Token(Token = "0x4018F7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
