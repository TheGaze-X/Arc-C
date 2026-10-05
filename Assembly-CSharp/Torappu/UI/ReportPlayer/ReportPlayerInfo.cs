using System;
using Il2CppDummyDll;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046E2 RID: 18146
	[Token(Token = "0x20046E2")]
	public struct ReportPlayerInfo
	{
		// Token: 0x04023A32 RID: 145970
		[Token(Token = "0x4023A32")]
		[FieldOffset(Offset = "0x0")]
		public string uid;

		// Token: 0x04023A33 RID: 145971
		[Token(Token = "0x4023A33")]
		[FieldOffset(Offset = "0x8")]
		public string nickName;

		// Token: 0x04023A34 RID: 145972
		[Token(Token = "0x4023A34")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04023A35 RID: 145973
		[Token(Token = "0x4023A35")]
		[FieldOffset(Offset = "0x18")]
		public PlayerAvatarQuery query;
	}
}
