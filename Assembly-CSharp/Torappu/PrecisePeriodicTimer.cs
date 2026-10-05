using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x2000567")]
	public class PrecisePeriodicTimer : PeriodicTimer
	{
		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x0002ED88 File Offset: 0x0002CF88
		[Token(Token = "0x17000CA8")]
		public override bool isReady
		{
			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x1AF7C40", Offset = "0x1AF6840", VA = "0x181AF7C40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0x1AF7B90", Offset = "0x1AF6790", VA = "0x181AF7B90")]
		public PrecisePeriodicTimer()
		{
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x1AF6EC0", Offset = "0x1AF5AC0", VA = "0x181AF6EC0")]
		public PrecisePeriodicTimer(FP periodTime)
		{
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x1AF7AF0", Offset = "0x1AF66F0", VA = "0x181AF7AF0", Slot = "5")]
		public override bool Update(FP deltaTime)
		{
			return default(bool);
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x1AF7920", Offset = "0x1AF6520", VA = "0x181AF7920", Slot = "7")]
		public override bool Next()
		{
			return default(bool);
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x1AF79D0", Offset = "0x1AF65D0", VA = "0x181AF79D0")]
		public int UpdateMultiple(FP deltaTime)
		{
			return 0;
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x1AF7850", Offset = "0x1AF6450", VA = "0x181AF7850")]
		public bool NextMultiple(int count)
		{
			return default(bool);
		}
	}
}
