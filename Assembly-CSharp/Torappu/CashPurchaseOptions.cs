using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200142F RID: 5167
	[Token(Token = "0x200142F")]
	public struct CashPurchaseOptions
	{
		// Token: 0x0600779A RID: 30618 RVA: 0x00035B50 File Offset: 0x00033D50
		[Token(Token = "0x600779A")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0400750E RID: 29966
		[Token(Token = "0x400750E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CashPurchaseOptions EMPTY;

		// Token: 0x0400750F RID: 29967
		[Token(Token = "0x400750F")]
		[FieldOffset(Offset = "0x0")]
		public string productId;

		// Token: 0x04007510 RID: 29968
		[Token(Token = "0x4007510")]
		[FieldOffset(Offset = "0x8")]
		public Action<PayConfirmOrderResponse> onPurchaseSuc;

		// Token: 0x04007511 RID: 29969
		[Token(Token = "0x4007511")]
		[FieldOffset(Offset = "0x10")]
		public Action<List<string>> onPendingOrders;
	}
}
