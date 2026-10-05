using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007264 RID: 29284
	[Token(Token = "0x2007264")]
	public class RuneInfo
	{
		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x060297DA RID: 169946 RVA: 0x000D5C78 File Offset: 0x000D3E78
		[Token(Token = "0x1700622F")]
		public bool isNewHand
		{
			[Token(Token = "0x60297DA")]
			[Address(RVA = "0x24EB330", Offset = "0x24E9F30", VA = "0x1824EB330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060297DB RID: 169947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuneInfo()
		{
		}

		// Token: 0x0403B49B RID: 242843
		[Token(Token = "0x403B49B")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x0403B49C RID: 242844
		[Token(Token = "0x403B49C")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403B49D RID: 242845
		[Token(Token = "0x403B49D")]
		[FieldOffset(Offset = "0x20")]
		public bool isAvailable;

		// Token: 0x0403B49E RID: 242846
		[Token(Token = "0x403B49E")]
		[FieldOffset(Offset = "0x21")]
		public bool isSelected;

		// Token: 0x0403B49F RID: 242847
		[Token(Token = "0x403B49F")]
		[FieldOffset(Offset = "0x22")]
		public bool isUnlock;

		// Token: 0x0403B4A0 RID: 242848
		[Token(Token = "0x403B4A0")]
		[FieldOffset(Offset = "0x23")]
		public bool isBanned;

		// Token: 0x0403B4A1 RID: 242849
		[Token(Token = "0x403B4A1")]
		[FieldOffset(Offset = "0x28")]
		public string conflictKey;

		// Token: 0x0403B4A2 RID: 242850
		[Token(Token = "0x403B4A2")]
		[FieldOffset(Offset = "0x30")]
		public int point;

		// Token: 0x0403B4A3 RID: 242851
		[Token(Token = "0x403B4A3")]
		[FieldOffset(Offset = "0x34")]
		public int sortId;

		// Token: 0x0403B4A4 RID: 242852
		[Token(Token = "0x403B4A4")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x0403B4A5 RID: 242853
		[Token(Token = "0x403B4A5")]
		[FieldOffset(Offset = "0x40")]
		public string description;
	}
}
