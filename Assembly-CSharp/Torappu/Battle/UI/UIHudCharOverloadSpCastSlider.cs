using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335C RID: 13148
	[Token(Token = "0x200335C")]
	public class UIHudCharOverloadSpCastSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x06014FB6 RID: 85942 RVA: 0x00089E80 File Offset: 0x00088080
		[Token(Token = "0x170031CE")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FB6")]
			[Address(RVA = "0xD5D1C0", Offset = "0xD5BDC0", VA = "0x180D5D1C0", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x06014FB7 RID: 85943 RVA: 0x00089E98 File Offset: 0x00088098
		[Token(Token = "0x170031CF")]
		public bool needToShow
		{
			[Token(Token = "0x6014FB7")]
			[Address(RVA = "0xD5D220", Offset = "0xD5BE20", VA = "0x180D5D220", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FB8 RID: 85944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB8")]
		[Address(RVA = "0xD5CE80", Offset = "0xD5BA80", VA = "0x180D5CE80", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FB9 RID: 85945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB9")]
		[Address(RVA = "0xD5CFD0", Offset = "0xD5BBD0", VA = "0x180D5CFD0", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FBA RID: 85946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FBA")]
		[Address(RVA = "0xD5D030", Offset = "0xD5BC30", VA = "0x180D5D030", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FBB RID: 85947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FBB")]
		[Address(RVA = "0xD5D160", Offset = "0xD5BD60", VA = "0x180D5D160")]
		public UIHudCharOverloadSpCastSlider()
		{
		}

		// Token: 0x04018F50 RID: 102224
		[Token(Token = "0x4018F50")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F51 RID: 102225
		[Token(Token = "0x4018F51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F52 RID: 102226
		[Token(Token = "0x4018F52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F53 RID: 102227
		[Token(Token = "0x4018F53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F54 RID: 102228
		[Token(Token = "0x4018F54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F55 RID: 102229
		[Token(Token = "0x4018F55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F56 RID: 102230
		[Token(Token = "0x4018F56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
