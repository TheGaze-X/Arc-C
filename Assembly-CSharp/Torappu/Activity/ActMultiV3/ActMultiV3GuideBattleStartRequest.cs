using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED4 RID: 28372
	[Token(Token = "0x2006ED4")]
	public class ActMultiV3GuideBattleStartRequest
	{
		// Token: 0x0602854D RID: 165197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602854D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3GuideBattleStartRequest()
		{
		}

		// Token: 0x04039547 RID: 234823
		[Token(Token = "0x4039547")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039548 RID: 234824
		[Token(Token = "0x4039548")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;
	}
}
