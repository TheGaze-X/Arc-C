using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079C9 RID: 31177
	[Token(Token = "0x20079C9")]
	public struct Act13SideArchiveStageUnlockCond : IHotfixable
	{
		// Token: 0x0602BBAA RID: 179114 RVA: 0x000DD028 File Offset: 0x000DB228
		[Token(Token = "0x602BBAA")]
		[Address(RVA = "0x2798090", Offset = "0x2796C90", VA = "0x182798090")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0602BBAB RID: 179115 RVA: 0x000DD040 File Offset: 0x000DB240
		[Token(Token = "0x602BBAB")]
		[Address(RVA = "0x2797F40", Offset = "0x2796B40", VA = "0x182797F40")]
		public static Act13SideArchiveStageUnlockCond Create(Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return default(Act13SideArchiveStageUnlockCond);
		}

		// Token: 0x0403F437 RID: 259127
		[Token(Token = "0x403F437")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act13SideArchiveStageUnlockCond EMPTY;

		// Token: 0x0403F438 RID: 259128
		[Token(Token = "0x403F438")]
		[FieldOffset(Offset = "0x0")]
		public string stageId;

		// Token: 0x0403F439 RID: 259129
		[Token(Token = "0x403F439")]
		[FieldOffset(Offset = "0x8")]
		public Act13SideArchiveStageUnlockCond.UnlockType stageUnlockType;

		// Token: 0x0403F43A RID: 259130
		[Token(Token = "0x403F43A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0403F43B RID: 259131
		[Token(Token = "0x403F43B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x020079CA RID: 31178
		[Token(Token = "0x20079CA")]
		public enum UnlockType
		{
			// Token: 0x0403F43D RID: 259133
			[Token(Token = "0x403F43D")]
			PLAYED,
			// Token: 0x0403F43E RID: 259134
			[Token(Token = "0x403F43E")]
			PASSED
		}
	}
}
