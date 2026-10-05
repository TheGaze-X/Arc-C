using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A20 RID: 18976
	[Token(Token = "0x2004A20")]
	public class InformantNewsTabViewModel : IHotfixable
	{
		// Token: 0x0601C8B6 RID: 116918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B6")]
		[Address(RVA = "0x15FFF20", Offset = "0x15FEB20", VA = "0x1815FFF20")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C8B7 RID: 116919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B7")]
		[Address(RVA = "0x1600140", Offset = "0x15FED40", VA = "0x181600140")]
		public InformantNewsTabViewModel()
		{
		}

		// Token: 0x040256FA RID: 153338
		[Token(Token = "0x40256FA")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x040256FB RID: 153339
		[Token(Token = "0x40256FB")]
		[FieldOffset(Offset = "0x18")]
		public string desc1;

		// Token: 0x040256FC RID: 153340
		[Token(Token = "0x40256FC")]
		[FieldOffset(Offset = "0x20")]
		public string desc2;

		// Token: 0x040256FD RID: 153341
		[Token(Token = "0x40256FD")]
		[FieldOffset(Offset = "0x28")]
		public int day;

		// Token: 0x040256FE RID: 153342
		[Token(Token = "0x40256FE")]
		[FieldOffset(Offset = "0x30")]
		public string imgId;

		// Token: 0x040256FF RID: 153343
		[Token(Token = "0x40256FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025700 RID: 153344
		[Token(Token = "0x4025700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
