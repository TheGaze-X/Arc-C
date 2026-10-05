using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003AB9 RID: 15033
	[Token(Token = "0x2003AB9")]
	public struct HiddenStageMissionToastParam
	{
		// Token: 0x0401CA4C RID: 117324
		[Token(Token = "0x401CA4C")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x0401CA4D RID: 117325
		[Token(Token = "0x401CA4D")]
		[FieldOffset(Offset = "0x8")]
		public List<HiddenStageMissionPushMsg> payloads;
	}
}
