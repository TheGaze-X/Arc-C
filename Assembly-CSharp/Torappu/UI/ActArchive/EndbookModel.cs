using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B81 RID: 27521
	[Token(Token = "0x2006B81")]
	public class EndbookModel : IHotfixable
	{
		// Token: 0x06027516 RID: 161046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027516")]
		[Address(RVA = "0x2289CA0", Offset = "0x22888A0", VA = "0x182289CA0")]
		public string GetDefaultEndID()
		{
			return null;
		}

		// Token: 0x06027517 RID: 161047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027517")]
		[Address(RVA = "0x2289E30", Offset = "0x2288A30", VA = "0x182289E30")]
		public void LoadData(string archiveId, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027518 RID: 161048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027518")]
		[Address(RVA = "0x228A950", Offset = "0x2289550", VA = "0x18228A950")]
		public EndbookModel()
		{
		}

		// Token: 0x04037B12 RID: 228114
		[Token(Token = "0x4037B12")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ArchiveEndbookItemModel> endbookItems;

		// Token: 0x04037B13 RID: 228115
		[Token(Token = "0x4037B13")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, ArchiveEndbookEndModel> endbookEnds;

		// Token: 0x04037B14 RID: 228116
		[Token(Token = "0x4037B14")]
		[FieldOffset(Offset = "0x20")]
		public bool showDetail;

		// Token: 0x04037B15 RID: 228117
		[Token(Token = "0x4037B15")]
		[FieldOffset(Offset = "0x24")]
		public int focusedEndIndex;

		// Token: 0x04037B16 RID: 228118
		[Token(Token = "0x4037B16")]
		[FieldOffset(Offset = "0x28")]
		public bool isInit;

		// Token: 0x04037B17 RID: 228119
		[Token(Token = "0x4037B17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultEndID;

		// Token: 0x04037B18 RID: 228120
		[Token(Token = "0x4037B18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037B19 RID: 228121
		[Token(Token = "0x4037B19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
