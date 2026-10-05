using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001381 RID: 4993
	[Token(Token = "0x2001381")]
	[Serializable]
	public class StorylineCollectData
	{
		// Token: 0x06007364 RID: 29540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007364")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineCollectData()
		{
		}

		// Token: 0x04006ED3 RID: 28371
		[Token(Token = "0x4006ED3")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x04006ED4 RID: 28372
		[Token(Token = "0x4006ED4")]
		[FieldOffset(Offset = "0x18")]
		public string backgroundId;
	}
}
