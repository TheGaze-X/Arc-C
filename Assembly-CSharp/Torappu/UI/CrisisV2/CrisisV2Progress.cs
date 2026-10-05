using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005962 RID: 22882
	[Token(Token = "0x2005962")]
	public struct CrisisV2Progress
	{
		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x060215A4 RID: 136612 RVA: 0x000B9A78 File Offset: 0x000B7C78
		[Token(Token = "0x17004E54")]
		public bool isFull
		{
			[Token(Token = "0x60215A4")]
			[Address(RVA = "0x1B2E700", Offset = "0x1B2D300", VA = "0x181B2E700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x060215A5 RID: 136613 RVA: 0x000B9A90 File Offset: 0x000B7C90
		[Token(Token = "0x17004E55")]
		public float progress
		{
			[Token(Token = "0x60215A5")]
			[Address(RVA = "0x1BB90A0", Offset = "0x1BB7CA0", VA = "0x181BB90A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0402D7AB RID: 186283
		[Token(Token = "0x402D7AB")]
		[FieldOffset(Offset = "0x0")]
		public int current;

		// Token: 0x0402D7AC RID: 186284
		[Token(Token = "0x402D7AC")]
		[FieldOffset(Offset = "0x4")]
		public int total;
	}
}
