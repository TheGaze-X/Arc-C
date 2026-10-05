using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060AF RID: 24751
	[Token(Token = "0x20060AF")]
	public class CarvingShopBuyCardRequest
	{
		// Token: 0x06023CBF RID: 146623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CBF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarvingShopBuyCardRequest()
		{
		}

		// Token: 0x04031A21 RID: 203297
		[Token(Token = "0x4031A21")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04031A22 RID: 203298
		[Token(Token = "0x4031A22")]
		[FieldOffset(Offset = "0x18")]
		public int slot;
	}
}
