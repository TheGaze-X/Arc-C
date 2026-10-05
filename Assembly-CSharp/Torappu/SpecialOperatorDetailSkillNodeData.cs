using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200133A RID: 4922
	[Token(Token = "0x200133A")]
	public class SpecialOperatorDetailSkillNodeData
	{
		// Token: 0x060072F7 RID: 29431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorDetailSkillNodeData()
		{
		}

		// Token: 0x04006D31 RID: 27953
		[Token(Token = "0x4006D31")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006D32 RID: 27954
		[Token(Token = "0x4006D32")]
		[FieldOffset(Offset = "0x18")]
		public string skillKey;

		// Token: 0x04006D33 RID: 27955
		[Token(Token = "0x4006D33")]
		[FieldOffset(Offset = "0x20")]
		public int skillLevel;

		// Token: 0x04006D34 RID: 27956
		[Token(Token = "0x4006D34")]
		[FieldOffset(Offset = "0x24")]
		public int skillSpLevel;
	}
}
