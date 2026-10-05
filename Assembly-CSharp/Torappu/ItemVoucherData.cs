using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000785 RID: 1925
	[Token(Token = "0x2000785")]
	public class ItemVoucherData
	{
		// Token: 0x060063FD RID: 25597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x1EEAEE0", Offset = "0x1EE9AE0", VA = "0x181EEAEE0")]
		public List<ItemVoucherViewModel> GetList()
		{
			return null;
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemVoucherData()
		{
		}

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x10")]
		public string voucherId;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x18")]
		public int pickNum;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x20")]
		public string picId;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemVoucherPool> pool;
	}
}
