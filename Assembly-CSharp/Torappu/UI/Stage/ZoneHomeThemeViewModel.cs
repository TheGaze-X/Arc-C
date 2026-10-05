using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067DA RID: 26586
	[Token(Token = "0x20067DA")]
	public class ZoneHomeThemeViewModel : IHotfixable
	{
		// Token: 0x060261E4 RID: 156132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261E4")]
		[Address(RVA = "0x2145DB0", Offset = "0x21449B0", VA = "0x182145DB0")]
		public ZoneHomeThemeViewModel()
		{
		}

		// Token: 0x04035AC1 RID: 219841
		[Token(Token = "0x4035AC1")]
		[FieldOffset(Offset = "0x10")]
		public ZoneHomeEntryItemModel entryModel;

		// Token: 0x04035AC2 RID: 219842
		[Token(Token = "0x4035AC2")]
		[FieldOffset(Offset = "0x18")]
		public ActivityThemeData themeData;

		// Token: 0x04035AC3 RID: 219843
		[Token(Token = "0x4035AC3")]
		[FieldOffset(Offset = "0x20")]
		public string funcId;

		// Token: 0x04035AC4 RID: 219844
		[Token(Token = "0x4035AC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
