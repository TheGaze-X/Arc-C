using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D4 RID: 26580
	[Token(Token = "0x20067D4")]
	public class ZoneHomeEntryGroupModel : IHotfixable
	{
		// Token: 0x060261AA RID: 156074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261AA")]
		[Address(RVA = "0x2129F50", Offset = "0x2128B50", VA = "0x182129F50")]
		public void LoadData(StageStateBean stateBean)
		{
		}

		// Token: 0x060261AB RID: 156075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261AB")]
		[Address(RVA = "0x212ABE0", Offset = "0x21297E0", VA = "0x18212ABE0")]
		private static void _ExtractHomeThemeEntry(List<ZoneHomeEntryItemModel> entryList, StageStateBean stateBean, out ZoneHomeEntryItemModel themeEntry, out ActivityThemeData themeData)
		{
		}

		// Token: 0x060261AC RID: 156076 RVA: 0x000C9FF0 File Offset: 0x000C81F0
		[Token(Token = "0x60261AC")]
		[Address(RVA = "0x212A750", Offset = "0x2129350", VA = "0x18212A750")]
		private static bool _ExtractActivityThemeEntryImpl(List<ZoneHomeEntryItemModel> entryList, StageStateBean stateBean, out ZoneHomeEntryItemModel themeEntry, out ActivityThemeData themeData)
		{
			return default(bool);
		}

		// Token: 0x060261AD RID: 156077 RVA: 0x000CA008 File Offset: 0x000C8208
		[Token(Token = "0x60261AD")]
		[Address(RVA = "0x212ACA0", Offset = "0x21298A0", VA = "0x18212ACA0")]
		private static bool _ExtractMainlineEntryAsThemeImpl(List<ZoneHomeEntryItemModel> entryList, StageStateBean stateBean, out ZoneHomeEntryItemModel themeEntry, out ActivityThemeData themeData)
		{
			return default(bool);
		}

		// Token: 0x060261AE RID: 156078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261AE")]
		[Address(RVA = "0x212AE90", Offset = "0x2129A90", VA = "0x18212AE90")]
		private void _UpdateViewIndex()
		{
		}

		// Token: 0x060261AF RID: 156079 RVA: 0x000CA020 File Offset: 0x000C8220
		[Token(Token = "0x60261AF")]
		[Address(RVA = "0x212A3F0", Offset = "0x2128FF0", VA = "0x18212A3F0")]
		private static int _CompareEntryItem(ZoneHomeEntryItemModel lhs, ZoneHomeEntryItemModel rhs)
		{
			return 0;
		}

		// Token: 0x060261B0 RID: 156080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261B0")]
		[Address(RVA = "0x212AF50", Offset = "0x2129B50", VA = "0x18212AF50")]
		public ZoneHomeEntryGroupModel()
		{
		}

		// Token: 0x04035A69 RID: 219753
		[Token(Token = "0x4035A69")]
		[FieldOffset(Offset = "0x10")]
		public ZoneHomeEntryItemModel themeEntry;

		// Token: 0x04035A6A RID: 219754
		[Token(Token = "0x4035A6A")]
		[FieldOffset(Offset = "0x18")]
		public ActivityThemeData themeData;

		// Token: 0x04035A6B RID: 219755
		[Token(Token = "0x4035A6B")]
		[FieldOffset(Offset = "0x20")]
		public List<ZoneHomeEntryItemModel> entryList;

		// Token: 0x04035A6C RID: 219756
		[Token(Token = "0x4035A6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035A6D RID: 219757
		[Token(Token = "0x4035A6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ExtractHomeThemeEntry;

		// Token: 0x04035A6E RID: 219758
		[Token(Token = "0x4035A6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExtractActivityThemeEntryImpl;

		// Token: 0x04035A6F RID: 219759
		[Token(Token = "0x4035A6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExtractMainlineEntryAsThemeImpl;

		// Token: 0x04035A70 RID: 219760
		[Token(Token = "0x4035A70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateViewIndex;

		// Token: 0x04035A71 RID: 219761
		[Token(Token = "0x4035A71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CompareEntryItem;

		// Token: 0x04035A72 RID: 219762
		[Token(Token = "0x4035A72")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
