using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BC9 RID: 27593
	[Token(Token = "0x2006BC9")]
	public class NewsItemModel : ArchiveItemModel
	{
		// Token: 0x0602768E RID: 161422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602768E")]
		[Address(RVA = "0x22A5700", Offset = "0x22A4300", VA = "0x1822A5700", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602768F RID: 161423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602768F")]
		[Address(RVA = "0x22A5670", Offset = "0x22A4270", VA = "0x1822A5670", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027690 RID: 161424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027690")]
		[Address(RVA = "0x22A5760", Offset = "0x22A4360", VA = "0x1822A5760")]
		public NewsItemModel()
		{
		}

		// Token: 0x04037D66 RID: 228710
		[Token(Token = "0x4037D66")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.NewsArchiveResItemData newsItemData;

		// Token: 0x04037D67 RID: 228711
		[Token(Token = "0x4037D67")]
		[FieldOffset(Offset = "0x38")]
		public string newsId;

		// Token: 0x04037D68 RID: 228712
		[Token(Token = "0x4037D68")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04037D69 RID: 228713
		[Token(Token = "0x4037D69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037D6A RID: 228714
		[Token(Token = "0x4037D6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037D6B RID: 228715
		[Token(Token = "0x4037D6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
