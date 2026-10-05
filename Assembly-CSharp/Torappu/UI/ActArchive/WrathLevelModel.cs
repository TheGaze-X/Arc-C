using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C62 RID: 27746
	[Token(Token = "0x2006C62")]
	public class WrathLevelModel : ArchiveItemModel, IComparable<WrathLevelModel>, IHotfixable
	{
		// Token: 0x060279A4 RID: 162212 RVA: 0x000CED48 File Offset: 0x000CCF48
		[Token(Token = "0x60279A4")]
		[Address(RVA = "0x22D3AC0", Offset = "0x22D26C0", VA = "0x1822D3AC0", Slot = "7")]
		public int CompareTo(WrathLevelModel obj)
		{
			return 0;
		}

		// Token: 0x060279A5 RID: 162213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279A5")]
		[Address(RVA = "0x22D3B70", Offset = "0x22D2770", VA = "0x1822D3B70", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060279A6 RID: 162214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279A6")]
		[Address(RVA = "0x22D3BD0", Offset = "0x22D27D0", VA = "0x1822D3BD0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060279A7 RID: 162215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279A7")]
		[Address(RVA = "0x22D3C30", Offset = "0x22D2830", VA = "0x1822D3C30")]
		public WrathLevelModel()
		{
		}

		// Token: 0x040382B2 RID: 230066
		[Token(Token = "0x40382B2")]
		[FieldOffset(Offset = "0x30")]
		public string wrathId;

		// Token: 0x040382B3 RID: 230067
		[Token(Token = "0x40382B3")]
		[FieldOffset(Offset = "0x38")]
		public int level;

		// Token: 0x040382B4 RID: 230068
		[Token(Token = "0x40382B4")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x040382B5 RID: 230069
		[Token(Token = "0x40382B5")]
		[FieldOffset(Offset = "0x48")]
		public bool isAttained;

		// Token: 0x040382B6 RID: 230070
		[Token(Token = "0x40382B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040382B7 RID: 230071
		[Token(Token = "0x40382B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040382B8 RID: 230072
		[Token(Token = "0x40382B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040382B9 RID: 230073
		[Token(Token = "0x40382B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
