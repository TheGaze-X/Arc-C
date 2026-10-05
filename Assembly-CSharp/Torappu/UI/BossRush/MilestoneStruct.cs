using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006180 RID: 24960
	[Token(Token = "0x2006180")]
	public struct MilestoneStruct
	{
		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x06024014 RID: 147476 RVA: 0x000C2BC8 File Offset: 0x000C0DC8
		[Token(Token = "0x170054FC")]
		public float expPercentage
		{
			[Token(Token = "0x6024014")]
			[Address(RVA = "0x1EB1770", Offset = "0x1EB0370", VA = "0x181EB1770")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04032053 RID: 204883
		[Token(Token = "0x4032053")]
		[FieldOffset(Offset = "0x0")]
		public int currentLv;

		// Token: 0x04032054 RID: 204884
		[Token(Token = "0x4032054")]
		[FieldOffset(Offset = "0x4")]
		public int currentExp;

		// Token: 0x04032055 RID: 204885
		[Token(Token = "0x4032055")]
		[FieldOffset(Offset = "0x8")]
		public int totalExp;

		// Token: 0x04032056 RID: 204886
		[Token(Token = "0x4032056")]
		[FieldOffset(Offset = "0xC")]
		public bool isMaxLevel;

		// Token: 0x04032057 RID: 204887
		[Token(Token = "0x4032057")]
		[FieldOffset(Offset = "0x0")]
		public static MilestoneStruct DEFAULT;
	}
}
