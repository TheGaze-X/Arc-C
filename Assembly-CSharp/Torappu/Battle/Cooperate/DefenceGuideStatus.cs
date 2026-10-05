using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E2 RID: 9954
	[Token(Token = "0x20026E2")]
	[Serializable]
	public class DefenceGuideStatus
	{
		// Token: 0x0601030E RID: 66318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601030E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefenceGuideStatus()
		{
		}

		// Token: 0x0401217A RID: 74106
		[Token(Token = "0x401217A")]
		[FieldOffset(Offset = "0x10")]
		public int wave;

		// Token: 0x0401217B RID: 74107
		[Token(Token = "0x401217B")]
		[FieldOffset(Offset = "0x14")]
		public int damage;

		// Token: 0x0401217C RID: 74108
		[Token(Token = "0x401217C")]
		[FieldOffset(Offset = "0x18")]
		public int damagePct;

		// Token: 0x0401217D RID: 74109
		[Token(Token = "0x401217D")]
		[FieldOffset(Offset = "0x1C")]
		public bool bossKill;
	}
}
