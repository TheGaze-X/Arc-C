using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001138 RID: 4408
	[Token(Token = "0x2001138")]
	[Serializable]
	public class RetroActData
	{
		// Token: 0x06006F0E RID: 28430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroActData()
		{
		}

		// Token: 0x04005E73 RID: 24179
		[Token(Token = "0x4005E73")]
		[FieldOffset(Offset = "0x10")]
		public string retroId;

		// Token: 0x04005E74 RID: 24180
		[Token(Token = "0x4005E74")]
		[FieldOffset(Offset = "0x18")]
		public RetroType type;

		// Token: 0x04005E75 RID: 24181
		[Token(Token = "0x4005E75")]
		[FieldOffset(Offset = "0x20")]
		public string[] linkedActId;

		// Token: 0x04005E76 RID: 24182
		[Token(Token = "0x4005E76")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x04005E77 RID: 24183
		[Token(Token = "0x4005E77")]
		[FieldOffset(Offset = "0x30")]
		public long trailStartTime;

		// Token: 0x04005E78 RID: 24184
		[Token(Token = "0x4005E78")]
		[FieldOffset(Offset = "0x38")]
		public int index;

		// Token: 0x04005E79 RID: 24185
		[Token(Token = "0x4005E79")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x04005E7A RID: 24186
		[Token(Token = "0x4005E7A")]
		[FieldOffset(Offset = "0x48")]
		public bool haveTrail;

		// Token: 0x04005E7B RID: 24187
		[Token(Token = "0x4005E7B")]
		[FieldOffset(Offset = "0x50")]
		public string customActId;

		// Token: 0x04005E7C RID: 24188
		[Token(Token = "0x4005E7C")]
		[FieldOffset(Offset = "0x58")]
		public ActivityType customActType;

		// Token: 0x04005E7D RID: 24189
		[Token(Token = "0x4005E7D")]
		[FieldOffset(Offset = "0x60")]
		public string trapDomainId;
	}
}
