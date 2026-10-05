using System;
using System.Threading;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	internal class CoreComponent : CoreComponentBase
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x55C82A0", Offset = "0x55C6EA0", VA = "0x1855C82A0")]
		public CoreComponent(string sdkUrl)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x55C80A0", Offset = "0x55C6CA0", VA = "0x1855C80A0")]
		public void Init(CoreComponentBase.callBack<InitRet> callBack)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x55C81B0", Offset = "0x55C6DB0", VA = "0x1855C81B0")]
		public void ReportEventData(CoreComponentBase.callBack<ReportEventRet> callBack)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x55C8170", Offset = "0x55C6D70", VA = "0x1855C8170")]
		private void ReleaseLock()
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x20")]
		private SemaphoreSlim trackLock;
	}
}
