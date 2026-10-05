using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002704 RID: 9988
	[Token(Token = "0x2002704")]
	public struct AutoChessBroadcastMsg
	{
		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06010434 RID: 66612 RVA: 0x00063618 File Offset: 0x00061818
		[Token(Token = "0x17002389")]
		public bool isEmtpy
		{
			[Token(Token = "0x6010434")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040122C4 RID: 74436
		[Token(Token = "0x40122C4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AutoChessBroadcastMsg Empty;

		// Token: 0x040122C5 RID: 74437
		[Token(Token = "0x40122C5")]
		[FieldOffset(Offset = "0x0")]
		public string content;

		// Token: 0x040122C6 RID: 74438
		[Token(Token = "0x40122C6")]
		[FieldOffset(Offset = "0x8")]
		public int priority;
	}
}
