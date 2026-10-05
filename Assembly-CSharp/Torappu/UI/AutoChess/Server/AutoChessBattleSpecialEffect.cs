using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006438 RID: 25656
	[Token(Token = "0x2006438")]
	public class AutoChessBattleSpecialEffect : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024ED0 RID: 151248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED0")]
		[Address(RVA = "0x1FC8720", Offset = "0x1FC7320", VA = "0x181FC8720", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ED1 RID: 151249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED1")]
		[Address(RVA = "0x1FC8800", Offset = "0x1FC7400", VA = "0x181FC8800")]
		public AutoChessBattleSpecialEffect()
		{
		}

		// Token: 0x04033A71 RID: 211569
		[Token(Token = "0x4033A71")]
		[FieldOffset(Offset = "0x10")]
		public int effectInstId;

		// Token: 0x04033A72 RID: 211570
		[Token(Token = "0x4033A72")]
		[FieldOffset(Offset = "0x18")]
		public string effectId;

		// Token: 0x04033A73 RID: 211571
		[Token(Token = "0x4033A73")]
		[FieldOffset(Offset = "0x20")]
		public List<int> affectedUidIndex;

		// Token: 0x04033A74 RID: 211572
		[Token(Token = "0x4033A74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A75 RID: 211573
		[Token(Token = "0x4033A75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
