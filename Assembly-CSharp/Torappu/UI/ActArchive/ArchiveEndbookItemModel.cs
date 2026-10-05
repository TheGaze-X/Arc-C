using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B7E RID: 27518
	[Token(Token = "0x2006B7E")]
	public class ArchiveEndbookItemModel : ArchiveItemModel, IComparable<ArchiveEndbookItemModel>
	{
		// Token: 0x0602750E RID: 161038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602750E")]
		[Address(RVA = "0x2280040", Offset = "0x227EC40", VA = "0x182280040", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602750F RID: 161039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602750F")]
		[Address(RVA = "0x227FFD0", Offset = "0x227EBD0", VA = "0x18227FFD0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027510 RID: 161040 RVA: 0x000CDFE0 File Offset: 0x000CC1E0
		[Token(Token = "0x6027510")]
		[Address(RVA = "0x227FF40", Offset = "0x227EB40", VA = "0x18227FF40", Slot = "7")]
		public int CompareTo(ArchiveEndbookItemModel other)
		{
			return 0;
		}

		// Token: 0x06027511 RID: 161041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027511")]
		[Address(RVA = "0x22800A0", Offset = "0x227ECA0", VA = "0x1822800A0")]
		public ArchiveEndbookItemModel()
		{
		}

		// Token: 0x04037AF7 RID: 228087
		[Token(Token = "0x4037AF7")]
		[FieldOffset(Offset = "0x30")]
		public string endbookId;

		// Token: 0x04037AF8 RID: 228088
		[Token(Token = "0x4037AF8")]
		[FieldOffset(Offset = "0x38")]
		public string textId;

		// Token: 0x04037AF9 RID: 228089
		[Token(Token = "0x4037AF9")]
		[FieldOffset(Offset = "0x40")]
		public string textTitle;

		// Token: 0x04037AFA RID: 228090
		[Token(Token = "0x4037AFA")]
		[FieldOffset(Offset = "0x48")]
		public string unlockDesc;

		// Token: 0x04037AFB RID: 228091
		[Token(Token = "0x4037AFB")]
		[FieldOffset(Offset = "0x50")]
		public int sortOrder;

		// Token: 0x04037AFC RID: 228092
		[Token(Token = "0x4037AFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037AFD RID: 228093
		[Token(Token = "0x4037AFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037AFE RID: 228094
		[Token(Token = "0x4037AFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04037AFF RID: 228095
		[Token(Token = "0x4037AFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
