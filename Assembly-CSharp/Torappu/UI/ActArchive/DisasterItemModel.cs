using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B65 RID: 27493
	[Token(Token = "0x2006B65")]
	public class DisasterItemModel : ArchiveItemModel, IComparable<DisasterItemModel>, IHotfixable
	{
		// Token: 0x0602748F RID: 160911 RVA: 0x000CDEA8 File Offset: 0x000CC0A8
		[Token(Token = "0x602748F")]
		[Address(RVA = "0x2287A70", Offset = "0x2286670", VA = "0x182287A70", Slot = "7")]
		public int CompareTo(DisasterItemModel obj)
		{
			return 0;
		}

		// Token: 0x06027490 RID: 160912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027490")]
		[Address(RVA = "0x2287B20", Offset = "0x2286720", VA = "0x182287B20", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027491 RID: 160913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027491")]
		[Address(RVA = "0x2287B80", Offset = "0x2286780", VA = "0x182287B80", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027492 RID: 160914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027492")]
		[Address(RVA = "0x2287BE0", Offset = "0x22867E0", VA = "0x182287BE0")]
		public DisasterItemModel()
		{
		}

		// Token: 0x040379EC RID: 227820
		[Token(Token = "0x40379EC")]
		[FieldOffset(Offset = "0x30")]
		public string disasterId;

		// Token: 0x040379ED RID: 227821
		[Token(Token = "0x40379ED")]
		[FieldOffset(Offset = "0x38")]
		public int level;

		// Token: 0x040379EE RID: 227822
		[Token(Token = "0x40379EE")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x040379EF RID: 227823
		[Token(Token = "0x40379EF")]
		[FieldOffset(Offset = "0x48")]
		public string desc;

		// Token: 0x040379F0 RID: 227824
		[Token(Token = "0x40379F0")]
		[FieldOffset(Offset = "0x50")]
		public int sortId;

		// Token: 0x040379F1 RID: 227825
		[Token(Token = "0x40379F1")]
		[FieldOffset(Offset = "0x58")]
		public string typeSmallIconId;

		// Token: 0x040379F2 RID: 227826
		[Token(Token = "0x40379F2")]
		[FieldOffset(Offset = "0x60")]
		public string typeBigActiveIconId;

		// Token: 0x040379F3 RID: 227827
		[Token(Token = "0x40379F3")]
		[FieldOffset(Offset = "0x68")]
		public string typeBigInactiveIconId;

		// Token: 0x040379F4 RID: 227828
		[Token(Token = "0x40379F4")]
		[FieldOffset(Offset = "0x70")]
		public string levelName;

		// Token: 0x040379F5 RID: 227829
		[Token(Token = "0x40379F5")]
		[FieldOffset(Offset = "0x78")]
		public string effect;

		// Token: 0x040379F6 RID: 227830
		[Token(Token = "0x40379F6")]
		[FieldOffset(Offset = "0x80")]
		public bool isAttained;

		// Token: 0x040379F7 RID: 227831
		[Token(Token = "0x40379F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040379F8 RID: 227832
		[Token(Token = "0x40379F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040379F9 RID: 227833
		[Token(Token = "0x40379F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040379FA RID: 227834
		[Token(Token = "0x40379FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
