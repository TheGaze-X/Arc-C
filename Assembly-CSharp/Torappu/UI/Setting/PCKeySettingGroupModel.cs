using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FE1 RID: 16353
	[Token(Token = "0x2003FE1")]
	public class PCKeySettingGroupModel : IHotfixable, IComparable
	{
		// Token: 0x06019560 RID: 103776 RVA: 0x0009DC08 File Offset: 0x0009BE08
		[Token(Token = "0x6019560")]
		[Address(RVA = "0x11FAB00", Offset = "0x11F9700", VA = "0x1811FAB00", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06019561 RID: 103777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019561")]
		[Address(RVA = "0x11FAC00", Offset = "0x11F9800", VA = "0x1811FAC00")]
		public PCKeySettingGroupModel()
		{
		}

		// Token: 0x0401F815 RID: 129045
		[Token(Token = "0x401F815")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F816 RID: 129046
		[Token(Token = "0x401F816")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x0401F817 RID: 129047
		[Token(Token = "0x401F817")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0401F818 RID: 129048
		[Token(Token = "0x401F818")]
		[FieldOffset(Offset = "0x28")]
		public List<PCKeySettingItemModel> itemList;

		// Token: 0x0401F819 RID: 129049
		[Token(Token = "0x401F819")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PCKeySettingItemModel> itemDict;

		// Token: 0x0401F81A RID: 129050
		[Token(Token = "0x401F81A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401F81B RID: 129051
		[Token(Token = "0x401F81B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
