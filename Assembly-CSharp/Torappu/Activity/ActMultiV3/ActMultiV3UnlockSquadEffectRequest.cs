using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC5 RID: 28357
	[Token(Token = "0x2006EC5")]
	public class ActMultiV3UnlockSquadEffectRequest
	{
		// Token: 0x0602853C RID: 165180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602853C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3UnlockSquadEffectRequest()
		{
		}

		// Token: 0x04039515 RID: 234773
		[Token(Token = "0x4039515")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039516 RID: 234774
		[Token(Token = "0x4039516")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;
	}
}
