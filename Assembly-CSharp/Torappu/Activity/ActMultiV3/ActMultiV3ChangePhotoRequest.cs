using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE7 RID: 28391
	[Token(Token = "0x2006EE7")]
	public class ActMultiV3ChangePhotoRequest
	{
		// Token: 0x0602856D RID: 165229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602856D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3ChangePhotoRequest()
		{
		}

		// Token: 0x0403956F RID: 234863
		[Token(Token = "0x403956F")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039570 RID: 234864
		[Token(Token = "0x4039570")]
		[FieldOffset(Offset = "0x18")]
		public string weekRewardId;

		// Token: 0x04039571 RID: 234865
		[Token(Token = "0x4039571")]
		[FieldOffset(Offset = "0x20")]
		public string templateId;

		// Token: 0x04039572 RID: 234866
		[Token(Token = "0x4039572")]
		[FieldOffset(Offset = "0x28")]
		public string photoInstId;
	}
}
