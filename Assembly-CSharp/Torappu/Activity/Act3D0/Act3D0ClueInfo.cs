using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200741D RID: 29725
	[Token(Token = "0x200741D")]
	public class Act3D0ClueInfo : IComparable<Act3D0ClueInfo>
	{
		// Token: 0x06029F7F RID: 171903 RVA: 0x000D7118 File Offset: 0x000D5318
		[Token(Token = "0x6029F7F")]
		[Address(RVA = "0x173B1B0", Offset = "0x1739DB0", VA = "0x18173B1B0", Slot = "4")]
		public int CompareTo(Act3D0ClueInfo other)
		{
			return 0;
		}

		// Token: 0x06029F80 RID: 171904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F80")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0ClueInfo()
		{
		}

		// Token: 0x0403C2A2 RID: 246434
		[Token(Token = "0x403C2A2")]
		[FieldOffset(Offset = "0x10")]
		public Act3D0ClueInfo.State state;

		// Token: 0x0403C2A3 RID: 246435
		[Token(Token = "0x403C2A3")]
		[FieldOffset(Offset = "0x18")]
		public string ImgId;

		// Token: 0x0403C2A4 RID: 246436
		[Token(Token = "0x403C2A4")]
		[FieldOffset(Offset = "0x20")]
		public int orderId;

		// Token: 0x0403C2A5 RID: 246437
		[Token(Token = "0x403C2A5")]
		[FieldOffset(Offset = "0x28")]
		public string clueId;

		// Token: 0x0200741E RID: 29726
		[Token(Token = "0x200741E")]
		public enum State
		{
			// Token: 0x0403C2A7 RID: 246439
			[Token(Token = "0x403C2A7")]
			GET,
			// Token: 0x0403C2A8 RID: 246440
			[Token(Token = "0x403C2A8")]
			NOTGET
		}
	}
}
