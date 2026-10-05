using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B14 RID: 23316
	[Token(Token = "0x2005B14")]
	public class QCShopLowUnlockPushMsg
	{
		// Token: 0x06021DE5 RID: 138725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DE5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopLowUnlockPushMsg()
		{
		}

		// Token: 0x0402E66C RID: 190060
		[Token(Token = "0x402E66C")]
		[FieldOffset(Offset = "0x10")]
		public List<string> groups;
	}
}
