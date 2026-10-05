using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058CD RID: 22733
	[Token(Token = "0x20058CD")]
	public class CrossAppShareLayoutContentModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06021299 RID: 135833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021299")]
		[Address(RVA = "0x1B74300", Offset = "0x1B72F00", VA = "0x181B74300")]
		public CrossAppShareLayoutContentModel()
		{
		}

		// Token: 0x0402D2B1 RID: 185009
		[Token(Token = "0x402D2B1")]
		[FieldOffset(Offset = "0x18")]
		public List<CrossAppShareElementModelCollector> elementModels;

		// Token: 0x0402D2B2 RID: 185010
		[Token(Token = "0x402D2B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
