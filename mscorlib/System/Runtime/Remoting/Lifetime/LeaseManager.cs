using System;
using System.Collections;
using System.Threading;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	internal class LeaseManager
	{
		// Token: 0x06001D73 RID: 7539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x4B7DE70", Offset = "0x4B7CA70", VA = "0x184B7DE70")]
		public void SetPollTime(System.TimeSpan timeSpan)
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x4B7E130", Offset = "0x4B7CD30", VA = "0x184B7E130")]
		public void TrackLifetime(ServerIdentity identity)
		{
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x4B7DF60", Offset = "0x4B7CB60", VA = "0x184B7DF60")]
		public void StartManager()
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x4B7E0F0", Offset = "0x4B7CCF0", VA = "0x184B7E0F0")]
		public void StopManager()
		{
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x4B7DBA0", Offset = "0x4B7C7A0", VA = "0x184B7DBA0")]
		public void ManageLeases(object state)
		{
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x4B7E3F0", Offset = "0x4B7CFF0", VA = "0x184B7E3F0")]
		public LeaseManager()
		{
		}

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.ArrayList _objects;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x18")]
		private System.Threading.Timer _timer;
	}
}
