using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC2 RID: 28354
	[Token(Token = "0x2006EC2")]
	public class ActMultiV3JoinTeamRequest
	{
		// Token: 0x0602853A RID: 165178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602853A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3JoinTeamRequest()
		{
		}

		// Token: 0x0403950B RID: 234763
		[Token(Token = "0x403950B")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403950C RID: 234764
		[Token(Token = "0x403950C")]
		[FieldOffset(Offset = "0x18")]
		public string teamId;
	}
}
