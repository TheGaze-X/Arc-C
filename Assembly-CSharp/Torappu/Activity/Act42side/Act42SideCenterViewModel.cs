using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200731C RID: 29468
	[Token(Token = "0x200731C")]
	public class Act42SideCenterViewModel : IHotfixable
	{
		// Token: 0x06029ABF RID: 170687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABF")]
		[Address(RVA = "0x250A5B0", Offset = "0x25091B0", VA = "0x18250A5B0")]
		public Act42SideCenterViewModel()
		{
		}

		// Token: 0x0403B9E0 RID: 244192
		[Token(Token = "0x403B9E0")]
		[FieldOffset(Offset = "0x10")]
		public List<Act42SideTaskBtnViewModel> btnModels;

		// Token: 0x0403B9E1 RID: 244193
		[Token(Token = "0x403B9E1")]
		[FieldOffset(Offset = "0x18")]
		public string gunId;

		// Token: 0x0403B9E2 RID: 244194
		[Token(Token = "0x403B9E2")]
		[FieldOffset(Offset = "0x20")]
		public string gunImgColor;

		// Token: 0x0403B9E3 RID: 244195
		[Token(Token = "0x403B9E3")]
		[FieldOffset(Offset = "0x28")]
		public string gunImgWhite;

		// Token: 0x0403B9E4 RID: 244196
		[Token(Token = "0x403B9E4")]
		[FieldOffset(Offset = "0x30")]
		public bool isGunSelected;

		// Token: 0x0403B9E5 RID: 244197
		[Token(Token = "0x403B9E5")]
		[FieldOffset(Offset = "0x31")]
		public bool isGunUnlocked;

		// Token: 0x0403B9E6 RID: 244198
		[Token(Token = "0x403B9E6")]
		[FieldOffset(Offset = "0x32")]
		public bool isGunNew;

		// Token: 0x0403B9E7 RID: 244199
		[Token(Token = "0x403B9E7")]
		[FieldOffset(Offset = "0x38")]
		public string defaultTaskId;

		// Token: 0x0403B9E8 RID: 244200
		[Token(Token = "0x403B9E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
