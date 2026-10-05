using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C57 RID: 27735
	[Token(Token = "0x2006C57")]
	public class ArchiveTrapModel : IHotfixable
	{
		// Token: 0x06027972 RID: 162162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027972")]
		[Address(RVA = "0x22C68D0", Offset = "0x22C54D0", VA = "0x1822C68D0")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x06027973 RID: 162163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027973")]
		[Address(RVA = "0x22C69B0", Offset = "0x22C55B0", VA = "0x1822C69B0")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027974 RID: 162164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027974")]
		[Address(RVA = "0x22C7130", Offset = "0x22C5D30", VA = "0x1822C7130")]
		public ArchiveTrapModel()
		{
		}

		// Token: 0x0403825F RID: 229983
		[Token(Token = "0x403825F")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, TrapItemModel> trapItems;

		// Token: 0x04038260 RID: 229984
		[Token(Token = "0x4038260")]
		[FieldOffset(Offset = "0x18")]
		public string selectedTrapId;

		// Token: 0x04038261 RID: 229985
		[Token(Token = "0x4038261")]
		[FieldOffset(Offset = "0x20")]
		public int selectLineNum;

		// Token: 0x04038262 RID: 229986
		[Token(Token = "0x4038262")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x04038263 RID: 229987
		[Token(Token = "0x4038263")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038264 RID: 229988
		[Token(Token = "0x4038264")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
