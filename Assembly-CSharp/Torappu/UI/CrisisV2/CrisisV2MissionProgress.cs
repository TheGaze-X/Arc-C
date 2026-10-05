using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005961 RID: 22881
	[Token(Token = "0x2005961")]
	public struct CrisisV2MissionProgress
	{
		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x060215A0 RID: 136608 RVA: 0x000B9A30 File Offset: 0x000B7C30
		[Token(Token = "0x17004E51")]
		public int totalCnt
		{
			[Token(Token = "0x60215A0")]
			[Address(RVA = "0x1BB7E20", Offset = "0x1BB6A20", VA = "0x181BB7E20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x060215A1 RID: 136609 RVA: 0x000B9A48 File Offset: 0x000B7C48
		[Token(Token = "0x17004E52")]
		public bool hasComplete
		{
			[Token(Token = "0x60215A1")]
			[Address(RVA = "0x6144A0", Offset = "0x6130A0", VA = "0x1806144A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x060215A2 RID: 136610 RVA: 0x000B9A60 File Offset: 0x000B7C60
		[Token(Token = "0x17004E53")]
		public bool allClaimed
		{
			[Token(Token = "0x60215A2")]
			[Address(RVA = "0x1BB7E10", Offset = "0x1BB6A10", VA = "0x181BB7E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060215A3 RID: 136611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215A3")]
		[Address(RVA = "0x1BB7E00", Offset = "0x1BB6A00", VA = "0x181BB7E00")]
		public void Clear()
		{
		}

		// Token: 0x0402D7A8 RID: 186280
		[Token(Token = "0x402D7A8")]
		[FieldOffset(Offset = "0x0")]
		public int incompleteCnt;

		// Token: 0x0402D7A9 RID: 186281
		[Token(Token = "0x402D7A9")]
		[FieldOffset(Offset = "0x4")]
		public int completeCnt;

		// Token: 0x0402D7AA RID: 186282
		[Token(Token = "0x402D7AA")]
		[FieldOffset(Offset = "0x8")]
		public int claimedCnt;
	}
}
