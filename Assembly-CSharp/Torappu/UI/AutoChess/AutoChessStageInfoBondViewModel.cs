using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A8 RID: 25512
	[Token(Token = "0x20063A8")]
	public class AutoChessStageInfoBondViewModel : IComparable
	{
		// Token: 0x06024C78 RID: 150648 RVA: 0x000C56E8 File Offset: 0x000C38E8
		[Token(Token = "0x6024C78")]
		[Address(RVA = "0x1FA59D0", Offset = "0x1FA45D0", VA = "0x181FA59D0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06024C79 RID: 150649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C79")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessStageInfoBondViewModel()
		{
		}

		// Token: 0x0403366B RID: 210539
		[Token(Token = "0x403366B")]
		[FieldOffset(Offset = "0x10")]
		public bool isBondBanned;

		// Token: 0x0403366C RID: 210540
		[Token(Token = "0x403366C")]
		[FieldOffset(Offset = "0x18")]
		public string bondId;

		// Token: 0x0403366D RID: 210541
		[Token(Token = "0x403366D")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0403366E RID: 210542
		[Token(Token = "0x403366E")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0403366F RID: 210543
		[Token(Token = "0x403366F")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x04033670 RID: 210544
		[Token(Token = "0x4033670")]
		[FieldOffset(Offset = "0x38")]
		public bool isFirst;
	}
}
