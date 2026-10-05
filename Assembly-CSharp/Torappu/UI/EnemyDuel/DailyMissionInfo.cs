using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F77 RID: 20343
	[Token(Token = "0x2004F77")]
	public class DailyMissionInfo
	{
		// Token: 0x0601E412 RID: 123922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E412")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DailyMissionInfo()
		{
		}

		// Token: 0x040285DC RID: 165340
		[Token(Token = "0x40285DC")]
		[FieldOffset(Offset = "0x10")]
		public int add;

		// Token: 0x040285DD RID: 165341
		[Token(Token = "0x40285DD")]
		[FieldOffset(Offset = "0x14")]
		public int reward;
	}
}
