using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001384 RID: 4996
	[Token(Token = "0x2001384")]
	[Serializable]
	public class StoryReadTipsData
	{
		// Token: 0x06007367 RID: 29543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007367")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReadTipsData()
		{
		}

		// Token: 0x04006EDD RID: 28381
		[Token(Token = "0x4006EDD")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04006EDE RID: 28382
		[Token(Token = "0x4006EDE")]
		[FieldOffset(Offset = "0x18")]
		public string picId;

		// Token: 0x04006EDF RID: 28383
		[Token(Token = "0x4006EDF")]
		[FieldOffset(Offset = "0x20")]
		public string mainText;

		// Token: 0x04006EE0 RID: 28384
		[Token(Token = "0x4006EE0")]
		[FieldOffset(Offset = "0x28")]
		public string confirmText;

		// Token: 0x04006EE1 RID: 28385
		[Token(Token = "0x4006EE1")]
		[FieldOffset(Offset = "0x30")]
		public bool isAll;

		// Token: 0x04006EE2 RID: 28386
		[Token(Token = "0x4006EE2")]
		[FieldOffset(Offset = "0x38")]
		public List<string> stageIdList;
	}
}
