using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B0C RID: 27404
	[Token(Token = "0x2006B0C")]
	public class AvgItemModel : ArchiveItemModel
	{
		// Token: 0x060272F9 RID: 160505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272F9")]
		[Address(RVA = "0x2259600", Offset = "0x2258200", VA = "0x182259600", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060272FA RID: 160506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272FA")]
		[Address(RVA = "0x2259570", Offset = "0x2258170", VA = "0x182259570", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060272FB RID: 160507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272FB")]
		[Address(RVA = "0x2259660", Offset = "0x2258260", VA = "0x182259660")]
		public AvgItemModel()
		{
		}

		// Token: 0x040376EE RID: 227054
		[Token(Token = "0x40376EE")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.AvgArchiveResItemData avgItemData;

		// Token: 0x040376EF RID: 227055
		[Token(Token = "0x40376EF")]
		[FieldOffset(Offset = "0x38")]
		public string avgId;

		// Token: 0x040376F0 RID: 227056
		[Token(Token = "0x40376F0")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x040376F1 RID: 227057
		[Token(Token = "0x40376F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040376F2 RID: 227058
		[Token(Token = "0x40376F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040376F3 RID: 227059
		[Token(Token = "0x40376F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
