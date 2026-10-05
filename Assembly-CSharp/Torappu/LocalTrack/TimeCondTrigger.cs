using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200209A RID: 8346
	[Token(Token = "0x200209A")]
	public class TimeCondTrigger : TrackTrigger, ITrackWithTypeVersion, IComparable
	{
		// Token: 0x0600CD81 RID: 52609 RVA: 0x0004A130 File Offset: 0x00048330
		[Token(Token = "0x600CD81")]
		[Address(RVA = "0x35056F0", Offset = "0x35042F0", VA = "0x1835056F0", Slot = "5")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x0004A148 File Offset: 0x00048348
		[Token(Token = "0x600CD82")]
		[Address(RVA = "0x3505870", Offset = "0x3504470", VA = "0x183505870", Slot = "4")]
		public long GetTypeVersion()
		{
			return 0L;
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x0004A160 File Offset: 0x00048360
		[Token(Token = "0x600CD83")]
		[Address(RVA = "0x35058D0", Offset = "0x35044D0", VA = "0x1835058D0")]
		public bool IsValid(long lastTs, long curTs)
		{
			return default(bool);
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD84")]
		[Address(RVA = "0x3505990", Offset = "0x3504590", VA = "0x183505990")]
		public TimeCondTrigger()
		{
		}

		// Token: 0x0400D8CF RID: 55503
		[Token(Token = "0x400D8CF")]
		[FieldOffset(Offset = "0x20")]
		public long updateTs;

		// Token: 0x0400D8D0 RID: 55504
		[Token(Token = "0x400D8D0")]
		[FieldOffset(Offset = "0x28")]
		public long timeout;

		// Token: 0x0400D8D1 RID: 55505
		[Token(Token = "0x400D8D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0400D8D2 RID: 55506
		[Token(Token = "0x400D8D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTypeVersion;

		// Token: 0x0400D8D3 RID: 55507
		[Token(Token = "0x400D8D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0400D8D4 RID: 55508
		[Token(Token = "0x400D8D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
