using System;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal class TrackEventService : BaseService
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private TrackEventService()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x55C21F0", Offset = "0x55C0DF0", VA = "0x1855C21F0")]
		public TrackEventService(string url)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x55C1F80", Offset = "0x55C0B80", VA = "0x1855C1F80")]
		public void TrackEvent(string data, BaseService.callBack<BaseRet> callBack)
		{
		}
	}
}
