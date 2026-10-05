using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BDF RID: 27615
	[Token(Token = "0x2006BDF")]
	public class PicItemModel : ArchiveItemModel
	{
		// Token: 0x060276F6 RID: 161526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276F6")]
		[Address(RVA = "0x22A65E0", Offset = "0x22A51E0", VA = "0x1822A65E0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060276F7 RID: 161527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276F7")]
		[Address(RVA = "0x22A6550", Offset = "0x22A5150", VA = "0x1822A6550", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060276F8 RID: 161528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276F8")]
		[Address(RVA = "0x22A6640", Offset = "0x22A5240", VA = "0x1822A6640")]
		public PicItemModel()
		{
		}

		// Token: 0x04037DF9 RID: 228857
		[Token(Token = "0x4037DF9")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.PicArchiveResItemData picItemData;

		// Token: 0x04037DFA RID: 228858
		[Token(Token = "0x4037DFA")]
		[FieldOffset(Offset = "0x38")]
		public string picId;

		// Token: 0x04037DFB RID: 228859
		[Token(Token = "0x4037DFB")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04037DFC RID: 228860
		[Token(Token = "0x4037DFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037DFD RID: 228861
		[Token(Token = "0x4037DFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037DFE RID: 228862
		[Token(Token = "0x4037DFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
