using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200137F RID: 4991
	[Token(Token = "0x200137F")]
	[Serializable]
	public class StorylineMainlineData
	{
		// Token: 0x0600735B RID: 29531 RVA: 0x00033480 File Offset: 0x00031680
		[Token(Token = "0x600735B")]
		[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
		public bool ShouldSerializezoneId()
		{
			return default(bool);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x00033498 File Offset: 0x00031698
		[Token(Token = "0x600735C")]
		[Address(RVA = "0x20086A0", Offset = "0x20072A0", VA = "0x1820086A0")]
		public bool ShouldSerializeretroId()
		{
			return default(bool);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineMainlineData()
		{
		}

		// Token: 0x04006EC5 RID: 28357
		[Token(Token = "0x4006EC5")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04006EC6 RID: 28358
		[Token(Token = "0x4006EC6")]
		[FieldOffset(Offset = "0x18")]
		public string retroId;

		// Token: 0x04006EC7 RID: 28359
		[Token(Token = "0x4006EC7")]
		[FieldOffset(Offset = "0x20")]
		public string decoImageId;

		// Token: 0x04006EC8 RID: 28360
		[Token(Token = "0x4006EC8")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04006EC9 RID: 28361
		[Token(Token = "0x4006EC9")]
		[FieldOffset(Offset = "0x30")]
		public string backgroundId;

		// Token: 0x04006ECA RID: 28362
		[Token(Token = "0x4006ECA")]
		[FieldOffset(Offset = "0x38")]
		public List<string> tags;
	}
}
