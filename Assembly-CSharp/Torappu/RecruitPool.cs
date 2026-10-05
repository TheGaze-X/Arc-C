using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001064 RID: 4196
	[Token(Token = "0x2001064")]
	[Serializable]
	public class RecruitPool : BasedRecruitPool
	{
		// Token: 0x06006DEF RID: 28143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecruitPool()
		{
		}

		// Token: 0x04005942 RID: 22850
		[Token(Token = "0x4005942")]
		[FieldOffset(Offset = "0x18")]
		public RecruitPool.RecruitTime[] recruitTimeTable;

		// Token: 0x02001065 RID: 4197
		[Token(Token = "0x2001065")]
		[Serializable]
		public class RecruitTime
		{
			// Token: 0x06006DF0 RID: 28144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitTime()
			{
			}

			// Token: 0x04005943 RID: 22851
			[Token(Token = "0x4005943")]
			[FieldOffset(Offset = "0x10")]
			public int timeLength;

			// Token: 0x04005944 RID: 22852
			[Token(Token = "0x4005944")]
			[FieldOffset(Offset = "0x14")]
			public int recruitPrice;
		}
	}
}
