using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E4E RID: 20046
	[Token(Token = "0x2004E4E")]
	public class FireworkSavePlateSlotRequest
	{
		// Token: 0x0601DECD RID: 122573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DECD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FireworkSavePlateSlotRequest()
		{
		}

		// Token: 0x04027B89 RID: 162697
		[Token(Token = "0x4027B89")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04027B8A RID: 162698
		[Token(Token = "0x4027B8A")]
		[FieldOffset(Offset = "0x18")]
		public List<FireworkData.PlateSlotData> slots;
	}
}
