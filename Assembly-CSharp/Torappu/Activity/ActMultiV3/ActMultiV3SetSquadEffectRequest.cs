using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC7 RID: 28359
	[Token(Token = "0x2006EC7")]
	public class ActMultiV3SetSquadEffectRequest
	{
		// Token: 0x0602853E RID: 165182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602853E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SetSquadEffectRequest()
		{
		}

		// Token: 0x04039517 RID: 234775
		[Token(Token = "0x4039517")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039518 RID: 234776
		[Token(Token = "0x4039518")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x04039519 RID: 234777
		[Token(Token = "0x4039519")]
		[FieldOffset(Offset = "0x20")]
		public string buffId;
	}
}
