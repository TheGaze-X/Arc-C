using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010ED RID: 4333
	[Token(Token = "0x20010ED")]
	public class MedalExpireTime : ITimeValidInfo
	{
		// Token: 0x06006E95 RID: 28309 RVA: 0x000321C0 File Offset: 0x000303C0
		[Token(Token = "0x6006E95")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x000321D8 File Offset: 0x000303D8
		[Token(Token = "0x6006E96")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x000321F0 File Offset: 0x000303F0
		[Token(Token = "0x6006E97")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
		public virtual bool ShouldSerializetype()
		{
			return default(bool);
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E98")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MedalExpireTime()
		{
		}

		// Token: 0x04005CE3 RID: 23779
		[Token(Token = "0x4005CE3")]
		[FieldOffset(Offset = "0x10")]
		public long start;

		// Token: 0x04005CE4 RID: 23780
		[Token(Token = "0x4005CE4")]
		[FieldOffset(Offset = "0x18")]
		public long end;

		// Token: 0x04005CE5 RID: 23781
		[Token(Token = "0x4005CE5")]
		[FieldOffset(Offset = "0x20")]
		public MedalExpireType type;
	}
}
