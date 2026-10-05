using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE9 RID: 28393
	[Token(Token = "0x2006EE9")]
	public class ActMultiV3CommitAlbumRequest
	{
		// Token: 0x0602856F RID: 165231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602856F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3CommitAlbumRequest()
		{
		}

		// Token: 0x04039573 RID: 234867
		[Token(Token = "0x4039573")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039574 RID: 234868
		[Token(Token = "0x4039574")]
		[FieldOffset(Offset = "0x18")]
		public string weekRewardId;
	}
}
