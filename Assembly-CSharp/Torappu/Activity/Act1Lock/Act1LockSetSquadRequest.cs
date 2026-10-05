using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007860 RID: 30816
	[Token(Token = "0x2007860")]
	public class Act1LockSetSquadRequest
	{
		// Token: 0x0602B32B RID: 176939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B32B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockSetSquadRequest()
		{
		}

		// Token: 0x0403E74C RID: 255820
		[Token(Token = "0x403E74C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403E74D RID: 255821
		[Token(Token = "0x403E74D")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403E74E RID: 255822
		[Token(Token = "0x403E74E")]
		[FieldOffset(Offset = "0x20")]
		public RequestSquadSlot[] squad;
	}
}
