using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AFF RID: 27391
	[Token(Token = "0x2006AFF")]
	public class ArchiveActivityEntryModel : IHotfixable
	{
		// Token: 0x060272AB RID: 160427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272AB")]
		[Address(RVA = "0x2252FF0", Offset = "0x2251BF0", VA = "0x182252FF0")]
		public void LoadData(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060272AC RID: 160428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272AC")]
		[Address(RVA = "0x2253380", Offset = "0x2251F80", VA = "0x182253380")]
		public ArchiveActivityEntryModel()
		{
		}

		// Token: 0x04037677 RID: 226935
		[Token(Token = "0x4037677")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<ActArchiveType, ActArchiveCompInfo> cachedItemData;

		// Token: 0x04037678 RID: 226936
		[Token(Token = "0x4037678")]
		[FieldOffset(Offset = "0x18")]
		public string musicId;

		// Token: 0x04037679 RID: 226937
		[Token(Token = "0x4037679")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403767A RID: 226938
		[Token(Token = "0x403767A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
