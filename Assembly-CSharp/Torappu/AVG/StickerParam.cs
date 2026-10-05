using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EDB RID: 7899
	[Token(Token = "0x2001EDB")]
	public struct StickerParam
	{
		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x0600C417 RID: 50199 RVA: 0x00047FA0 File Offset: 0x000461A0
		[Token(Token = "0x1700176C")]
		public bool IsEmpty
		{
			[Token(Token = "0x600C417")]
			[Address(RVA = "0x2203A50", Offset = "0x2202650", VA = "0x182203A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400C689 RID: 50825
		[Token(Token = "0x400C689")]
		[FieldOffset(Offset = "0x0")]
		public float xPos;

		// Token: 0x0400C68A RID: 50826
		[Token(Token = "0x400C68A")]
		[FieldOffset(Offset = "0x4")]
		public float yPos;

		// Token: 0x0400C68B RID: 50827
		[Token(Token = "0x400C68B")]
		[FieldOffset(Offset = "0x8")]
		public float width;

		// Token: 0x0400C68C RID: 50828
		[Token(Token = "0x400C68C")]
		[FieldOffset(Offset = "0xC")]
		public int textSize;

		// Token: 0x0400C68D RID: 50829
		[Token(Token = "0x400C68D")]
		[FieldOffset(Offset = "0x10")]
		public string alignment;

		// Token: 0x0400C68E RID: 50830
		[Token(Token = "0x400C68E")]
		[FieldOffset(Offset = "0x18")]
		public string textContent;

		// Token: 0x0400C68F RID: 50831
		[Token(Token = "0x400C68F")]
		[FieldOffset(Offset = "0x20")]
		public bool isMultiline;

		// Token: 0x0400C690 RID: 50832
		[Token(Token = "0x400C690")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		// Token: 0x0400C691 RID: 50833
		[Token(Token = "0x400C691")]
		[FieldOffset(Offset = "0x28")]
		public float delay;
	}
}
