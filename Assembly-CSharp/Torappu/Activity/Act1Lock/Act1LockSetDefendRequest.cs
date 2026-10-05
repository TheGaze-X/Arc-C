using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007862 RID: 30818
	[Token(Token = "0x2007862")]
	public class Act1LockSetDefendRequest
	{
		// Token: 0x0602B32D RID: 176941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B32D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1LockSetDefendRequest()
		{
		}

		// Token: 0x0403E74F RID: 255823
		[Token(Token = "0x403E74F")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403E750 RID: 255824
		[Token(Token = "0x403E750")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403E751 RID: 255825
		[Token(Token = "0x403E751")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefend;
	}
}
