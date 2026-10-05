using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BAA RID: 19370
	[Token(Token = "0x2004BAA")]
	public class MailTitleViewModel : IHotfixable
	{
		// Token: 0x0601D203 RID: 119299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D203")]
		[Address(RVA = "0x16AB520", Offset = "0x16AA120", VA = "0x1816AB520")]
		public void LoadData()
		{
		}

		// Token: 0x0601D204 RID: 119300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D204")]
		[Address(RVA = "0x16AB5C0", Offset = "0x16AA1C0", VA = "0x1816AB5C0")]
		public MailTitleViewModel()
		{
		}

		// Token: 0x04026384 RID: 156548
		[Token(Token = "0x4026384")]
		[FieldOffset(Offset = "0x10")]
		public bool isArchiveOpen;

		// Token: 0x04026385 RID: 156549
		[Token(Token = "0x4026385")]
		[FieldOffset(Offset = "0x11")]
		public bool showArchiveTrackPoint;

		// Token: 0x04026386 RID: 156550
		[Token(Token = "0x4026386")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026387 RID: 156551
		[Token(Token = "0x4026387")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
