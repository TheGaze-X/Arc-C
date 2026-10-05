using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EDA RID: 28378
	[Token(Token = "0x2006EDA")]
	public class ActMultiV3BattleStartRequest
	{
		// Token: 0x0602855E RID: 165214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602855E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3BattleStartRequest()
		{
		}

		// Token: 0x04039556 RID: 234838
		[Token(Token = "0x4039556")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039557 RID: 234839
		[Token(Token = "0x4039557")]
		[FieldOffset(Offset = "0x18")]
		public string sceneId;
	}
}
