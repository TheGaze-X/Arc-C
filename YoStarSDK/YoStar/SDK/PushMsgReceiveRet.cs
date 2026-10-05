using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class PushMsgReceiveRet
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PushMsgReceiveRet()
		{
		}

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x20")]
		public string NOTIFICATION_ID;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x28")]
		public string EXTRA;
	}
}
