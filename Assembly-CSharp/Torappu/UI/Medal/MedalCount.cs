using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A2 RID: 18850
	[Token(Token = "0x20049A2")]
	public struct MedalCount
	{
		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x0601C669 RID: 116329 RVA: 0x000A82A0 File Offset: 0x000A64A0
		// (set) Token: 0x0601C66A RID: 116330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700433D")]
		public int getCount
		{
			[Token(Token = "0x601C669")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x601C66A")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x0601C66B RID: 116331 RVA: 0x000A82B8 File Offset: 0x000A64B8
		// (set) Token: 0x0601C66C RID: 116332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700433E")]
		public int totalCount
		{
			[Token(Token = "0x601C66B")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x601C66C")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x0601C66D RID: 116333 RVA: 0x000A82D0 File Offset: 0x000A64D0
		// (set) Token: 0x0601C66E RID: 116334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700433F")]
		public int achievedHiddenCount
		{
			[Token(Token = "0x601C66D")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x601C66E")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601C66F RID: 116335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C66F")]
		[Address(RVA = "0x15E9F10", Offset = "0x15E8B10", VA = "0x1815E9F10")]
		public void AddMedal(bool isMedalGotten, bool isMedalHidden)
		{
		}

		// Token: 0x0402533D RID: 152381
		[Token(Token = "0x402533D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MedalCount EMPTY;
	}
}
