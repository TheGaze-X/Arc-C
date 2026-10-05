using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016E0 RID: 5856
	[Token(Token = "0x20016E0")]
	public class UnifiedServiceNetCoreMock : UnifiedServiceNetCore
	{
		// Token: 0x06009455 RID: 37973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009455")]
		[Address(RVA = "0x2B40730", Offset = "0x2B3F330", VA = "0x182B40730", Slot = "5")]
		protected override void OnConnectTo(string host, int port)
		{
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009456")]
		[Address(RVA = "0x2B407C0", Offset = "0x2B3F3C0", VA = "0x182B407C0", Slot = "6")]
		protected override void OnDisConnect()
		{
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009457")]
		[Address(RVA = "0x2B40820", Offset = "0x2B3F420", VA = "0x182B40820")]
		public UnifiedServiceNetCoreMock()
		{
		}

		// Token: 0x04008A5B RID: 35419
		[Token(Token = "0x4008A5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConnectTo;

		// Token: 0x04008A5C RID: 35420
		[Token(Token = "0x4008A5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisConnect;

		// Token: 0x04008A5D RID: 35421
		[Token(Token = "0x4008A5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
