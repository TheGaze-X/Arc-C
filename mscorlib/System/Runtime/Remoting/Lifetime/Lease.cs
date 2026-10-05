using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	internal class Lease : System.MarshalByRefObject, ILease
	{
		// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x4B7F5C0", Offset = "0x4B7E1C0", VA = "0x184B7F5C0")]
		public Lease()
		{
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[Token(Token = "0x17000366")]
		public System.TimeSpan CurrentLeaseTime
		{
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0x4B7F730", Offset = "0x4B7E330", VA = "0x184B7F730", Slot = "6")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x17000367")]
		public LeaseState CurrentState
		{
			[Token(Token = "0x6001D67")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "7")]
			get
			{
				return LeaseState.Null;
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x4B7E7C0", Offset = "0x4B7D3C0", VA = "0x184B7E7C0")]
		public void Activate()
		{
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x17000368")]
		public System.TimeSpan RenewOnCallTime
		{
			[Token(Token = "0x6001D69")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "8")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x4B7F1D0", Offset = "0x4B7DDD0", VA = "0x184B7F1D0", Slot = "9")]
		public System.TimeSpan Renew(System.TimeSpan renewalTime)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x4B7F2A0", Offset = "0x4B7DEA0", VA = "0x184B7F2A0", Slot = "10")]
		public void Unregister(ISponsor obj)
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x4B7F410", Offset = "0x4B7E010", VA = "0x184B7F410")]
		internal void UpdateState()
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x4B7E7D0", Offset = "0x4B7D3D0", VA = "0x184B7E7D0")]
		private void CheckNextSponsor()
		{
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x4B7EBC0", Offset = "0x4B7D7C0", VA = "0x184B7EBC0")]
		private void ProcessSponsorResponse(object state, bool timedOut)
		{
		}

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x18")]
		private System.DateTime _leaseExpireTime;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x20")]
		private LeaseState _currentState;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x28")]
		private System.TimeSpan _initialLeaseTime;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x30")]
		private System.TimeSpan _renewOnCallTime;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x38")]
		private System.TimeSpan _sponsorshipTimeout;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x40")]
		private System.Collections.ArrayList _sponsors;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x48")]
		private System.Collections.Queue _renewingSponsors;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x50")]
		private Lease.RenewalDelegate _renewalDelegate;

		// Token: 0x02000385 RID: 901
		// (Invoke) Token: 0x06001D70 RID: 7536
		[Token(Token = "0x2000385")]
		private delegate System.TimeSpan RenewalDelegate(ILease lease);
	}
}
