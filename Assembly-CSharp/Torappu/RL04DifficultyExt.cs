using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001203 RID: 4611
	[Token(Token = "0x2001203")]
	public class RL04DifficultyExt
	{
		// Token: 0x06006FF9 RID: 28665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL04DifficultyExt()
		{
		}

		// Token: 0x04006336 RID: 25398
		[Token(Token = "0x4006336")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x04006337 RID: 25399
		[Token(Token = "0x4006337")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x04006338 RID: 25400
		[Token(Token = "0x4006338")]
		[FieldOffset(Offset = "0x18")]
		public string leftDisasterDesc;

		// Token: 0x04006339 RID: 25401
		[Token(Token = "0x4006339")]
		[FieldOffset(Offset = "0x20")]
		public string leftOverweightDesc;

		// Token: 0x0400633A RID: 25402
		[Token(Token = "0x400633A")]
		[FieldOffset(Offset = "0x28")]
		public string relicDevLevel;

		// Token: 0x0400633B RID: 25403
		[Token(Token = "0x400633B")]
		[FieldOffset(Offset = "0x30")]
		public string weightStatusLimitDesc;

		// Token: 0x0400633C RID: 25404
		[Token(Token = "0x400633C")]
		[FieldOffset(Offset = "0x38")]
		public string[] buffs;

		// Token: 0x0400633D RID: 25405
		[Token(Token = "0x400633D")]
		[FieldOffset(Offset = "0x40")]
		public string[] buffDesc;
	}
}
