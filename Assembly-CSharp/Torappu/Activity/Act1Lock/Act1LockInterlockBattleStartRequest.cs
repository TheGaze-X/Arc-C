using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007864 RID: 30820
	[Token(Token = "0x2007864")]
	public class Act1LockInterlockBattleStartRequest
	{
		// Token: 0x0602B32F RID: 176943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B32F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockInterlockBattleStartRequest()
		{
		}

		// Token: 0x0403E752 RID: 255826
		[Token(Token = "0x403E752")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403E753 RID: 255827
		[Token(Token = "0x403E753")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403E754 RID: 255828
		[Token(Token = "0x403E754")]
		[FieldOffset(Offset = "0x20")]
		public bool useSpecial;
	}
}
