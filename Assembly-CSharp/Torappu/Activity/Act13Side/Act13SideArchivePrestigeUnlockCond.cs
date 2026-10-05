using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079C8 RID: 31176
	[Token(Token = "0x20079C8")]
	public struct Act13SideArchivePrestigeUnlockCond : IHotfixable
	{
		// Token: 0x0602BBA7 RID: 179111 RVA: 0x000DCFF8 File Offset: 0x000DB1F8
		[Token(Token = "0x602BBA7")]
		[Address(RVA = "0x2797EC0", Offset = "0x2796AC0", VA = "0x182797EC0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0602BBA8 RID: 179112 RVA: 0x000DD010 File Offset: 0x000DB210
		[Token(Token = "0x602BBA8")]
		[Address(RVA = "0x2797CE0", Offset = "0x27968E0", VA = "0x182797CE0")]
		public static Act13SideArchivePrestigeUnlockCond Create(Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return default(Act13SideArchivePrestigeUnlockCond);
		}

		// Token: 0x0403F432 RID: 259122
		[Token(Token = "0x403F432")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act13SideArchivePrestigeUnlockCond EMPTY;

		// Token: 0x0403F433 RID: 259123
		[Token(Token = "0x403F433")]
		[FieldOffset(Offset = "0x0")]
		public Act13SideData.PrestigeRank orgRank;

		// Token: 0x0403F434 RID: 259124
		[Token(Token = "0x403F434")]
		[FieldOffset(Offset = "0x8")]
		public string orgName;

		// Token: 0x0403F435 RID: 259125
		[Token(Token = "0x403F435")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0403F436 RID: 259126
		[Token(Token = "0x403F436")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
