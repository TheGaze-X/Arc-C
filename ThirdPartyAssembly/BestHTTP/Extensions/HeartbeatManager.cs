using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.Extensions
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public sealed class HeartbeatManager
	{
		// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x53BF4C0", Offset = "0x53BE0C0", VA = "0x1853BF4C0")]
		public void Subscribe(IHeartbeat heartbeat)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x53BF5C0", Offset = "0x53BE1C0", VA = "0x1853BF5C0")]
		public void Unsubscribe(IHeartbeat heartbeat)
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x53BF690", Offset = "0x53BE290", VA = "0x1853BF690")]
		public void Update()
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x53BF920", Offset = "0x53BE520", VA = "0x1853BF920")]
		public HeartbeatManager()
		{
		}

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x10")]
		private List<IHeartbeat> Heartbeats;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0x18")]
		private IHeartbeat[] UpdateArray;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0x20")]
		private DateTime LastUpdate;
	}
}
