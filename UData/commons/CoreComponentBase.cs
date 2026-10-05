using System;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal class CoreComponentBase
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x55ACC80", Offset = "0x55AB880", VA = "0x1855ACC80")]
		protected CoreComponentBase(string sdkUrl)
		{
		}

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		protected CommonService commonService;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		protected TrackEventService trackEventService;

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001D0 RID: 464
		[Token(Token = "0x200002F")]
		public delegate void callBack<T>(T response);
	}
}
