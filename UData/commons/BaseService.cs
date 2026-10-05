using System;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal class BaseService
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BaseService()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		protected void MainThreadCall<T>(BaseService.callBack<T> callBack, T ret)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		protected void LoomMainThreadCall<T>(BaseService.callBack<T> callBack, T ret)
		{
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x10")]
		protected string sdkUrl;

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001EC RID: 492
		[Token(Token = "0x2000032")]
		public delegate void callBack<T>(T response);
	}
}
