using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class LifetimeServices
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000369")]
		public static System.TimeSpan LeaseManagerPollTime
		{
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x4B7F990", Offset = "0x4B7E590", VA = "0x184B7F990")]
			get
			{
				return default(System.TimeSpan);
			}
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x4B7FAD0", Offset = "0x4B7E6D0", VA = "0x184B7FAD0")]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00012B28 File Offset: 0x00010D28
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public static System.TimeSpan LeaseTime
		{
			[Token(Token = "0x6001D80")]
			[Address(RVA = "0x4B7F9E0", Offset = "0x4B7E5E0", VA = "0x184B7F9E0")]
			get
			{
				return default(System.TimeSpan);
			}
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x4B7FB50", Offset = "0x4B7E750", VA = "0x184B7FB50")]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00012B40 File Offset: 0x00010D40
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public static System.TimeSpan RenewOnCallTime
		{
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x4B7FA30", Offset = "0x4B7E630", VA = "0x184B7FA30")]
			get
			{
				return default(System.TimeSpan);
			}
			[Token(Token = "0x6001D83")]
			[Address(RVA = "0x4B7FBB0", Offset = "0x4B7E7B0", VA = "0x184B7FBB0")]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		public static System.TimeSpan SponsorshipTimeout
		{
			[Token(Token = "0x6001D84")]
			[Address(RVA = "0x4B7FA80", Offset = "0x4B7E680", VA = "0x184B7FA80")]
			get
			{
				return default(System.TimeSpan);
			}
			[Token(Token = "0x6001D85")]
			[Address(RVA = "0x4B7FC10", Offset = "0x4B7E810", VA = "0x184B7FC10")]
			set
			{
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x4B7F790", Offset = "0x4B7E390", VA = "0x184B7F790")]
		internal static void TrackLifetime(ServerIdentity identity)
		{
		}

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.TimeSpan _leaseManagerPollTime;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.TimeSpan _leaseTime;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.TimeSpan _renewOnCallTime;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static System.TimeSpan _sponsorshipTimeout;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static LeaseManager _leaseManager;
	}
}
