using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F71 RID: 3953
	[Token(Token = "0x2000F71")]
	public class SpCharMissionData
	{
		// Token: 0x06006CA1 RID: 27809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpCharMissionData()
		{
		}

		// Token: 0x040053ED RID: 21485
		[Token(Token = "0x40053ED")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x040053EE RID: 21486
		[Token(Token = "0x40053EE")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;

		// Token: 0x040053EF RID: 21487
		[Token(Token = "0x40053EF")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x040053F0 RID: 21488
		[Token(Token = "0x40053F0")]
		[FieldOffset(Offset = "0x24")]
		public SpCharMissionCondType condType;

		// Token: 0x040053F1 RID: 21489
		[Token(Token = "0x40053F1")]
		[FieldOffset(Offset = "0x28")]
		public List<string> param;

		// Token: 0x040053F2 RID: 21490
		[Token(Token = "0x40053F2")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemBundle> rewards;
	}
}
