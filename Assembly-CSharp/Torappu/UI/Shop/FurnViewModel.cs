using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC6 RID: 23238
	[Token(Token = "0x2005AC6")]
	public class FurnViewModel : IComparable<FurnViewModel>
	{
		// Token: 0x06021C73 RID: 138355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C73")]
		[Address(RVA = "0x1C31140", Offset = "0x1C2FD40", VA = "0x181C31140")]
		public string GetGoodId()
		{
			return null;
		}

		// Token: 0x06021C74 RID: 138356 RVA: 0x000BB410 File Offset: 0x000B9610
		[Token(Token = "0x6021C74")]
		[Address(RVA = "0x1C31180", Offset = "0x1C2FD80", VA = "0x181C31180")]
		public int GetSortId()
		{
			return 0;
		}

		// Token: 0x06021C75 RID: 138357 RVA: 0x000BB428 File Offset: 0x000B9628
		[Token(Token = "0x6021C75")]
		[Address(RVA = "0x1C30FC0", Offset = "0x1C2FBC0", VA = "0x181C30FC0")]
		public bool AlreadyHave()
		{
			return default(bool);
		}

		// Token: 0x06021C76 RID: 138358 RVA: 0x000BB440 File Offset: 0x000B9640
		[Token(Token = "0x6021C76")]
		[Address(RVA = "0x1C31000", Offset = "0x1C2FC00", VA = "0x181C31000", Slot = "4")]
		public int CompareTo(FurnViewModel other)
		{
			return 0;
		}

		// Token: 0x06021C77 RID: 138359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C77")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FurnViewModel()
		{
		}

		// Token: 0x0402E3BB RID: 189371
		[Token(Token = "0x402E3BB")]
		[FieldOffset(Offset = "0x10")]
		public bool isGood;

		// Token: 0x0402E3BC RID: 189372
		[Token(Token = "0x402E3BC")]
		[FieldOffset(Offset = "0x18")]
		public FurnGoodViewModel good;

		// Token: 0x0402E3BD RID: 189373
		[Token(Token = "0x402E3BD")]
		[FieldOffset(Offset = "0x20")]
		public FurnGroupViewModel group;
	}
}
