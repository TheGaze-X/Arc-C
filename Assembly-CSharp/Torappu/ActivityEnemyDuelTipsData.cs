using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000E0B")]
	public class ActivityEnemyDuelTipsData
	{
		// Token: 0x06006ADE RID: 27358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelTipsData()
		{
		}

		// Token: 0x04004AE9 RID: 19177
		[Token(Token = "0x4004AE9")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004AEA RID: 19178
		[Token(Token = "0x4004AEA")]
		[FieldOffset(Offset = "0x18")]
		public string txt;

		// Token: 0x04004AEB RID: 19179
		[Token(Token = "0x4004AEB")]
		[FieldOffset(Offset = "0x20")]
		public int weight;

		// Token: 0x04004AEC RID: 19180
		[Token(Token = "0x4004AEC")]
		[FieldOffset(Offset = "0x28")]
		public List<string> modeIds;
	}
}
