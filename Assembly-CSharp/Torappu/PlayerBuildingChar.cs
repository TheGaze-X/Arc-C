using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	public class PlayerBuildingChar
	{
		// Token: 0x060066F8 RID: 26360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0x1EF14D0", Offset = "0x1EF00D0", VA = "0x181EF14D0")]
		public PlayerBuildingChar()
		{
		}

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04003806 RID: 14342
		[Token(Token = "0x4003806")]
		[FieldOffset(Offset = "0x18")]
		public DateTime lastApAddTime;

		// Token: 0x04003807 RID: 14343
		[Token(Token = "0x4003807")]
		[FieldOffset(Offset = "0x20")]
		public long ap;

		// Token: 0x04003808 RID: 14344
		[Token(Token = "0x4003808")]
		[FieldOffset(Offset = "0x28")]
		public string roomSlotId;

		// Token: 0x04003809 RID: 14345
		[Token(Token = "0x4003809")]
		[FieldOffset(Offset = "0x30")]
		public int index;

		// Token: 0x0400380A RID: 14346
		[Token(Token = "0x400380A")]
		[FieldOffset(Offset = "0x34")]
		public int changeScale;

		// Token: 0x0400380B RID: 14347
		[Token(Token = "0x400380B")]
		[FieldOffset(Offset = "0x38")]
		public PlayerBuildingChar.BubbleContainer bubble;

		// Token: 0x0400380C RID: 14348
		[Token(Token = "0x400380C")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty(PropertyName = "skin")]
		public string skinIdInVisit;

		// Token: 0x02000A3A RID: 2618
		[Token(Token = "0x2000A3A")]
		public class BubbleContainer
		{
			// Token: 0x060066F9 RID: 26361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066F9")]
			[Address(RVA = "0x1EE7060", Offset = "0x1EE5C60", VA = "0x181EE7060")]
			public BubbleContainer()
			{
			}

			// Token: 0x0400380D RID: 14349
			[Token(Token = "0x400380D")]
			[FieldOffset(Offset = "0x10")]
			public PlayerBuildingCharBubble normal;

			// Token: 0x0400380E RID: 14350
			[Token(Token = "0x400380E")]
			[FieldOffset(Offset = "0x18")]
			public PlayerBuildingCharBubble assist;

			// Token: 0x0400380F RID: 14351
			[Token(Token = "0x400380F")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "private")]
			public PlayerBuildingCharBubble privateBubble;
		}
	}
}
