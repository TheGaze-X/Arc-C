using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001088 RID: 4232
	[Token(Token = "0x2001088")]
	[Serializable]
	public class EquipTypeTextId
	{
		// Token: 0x06006E16 RID: 28182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EquipTypeTextId()
		{
		}

		// Token: 0x04005A54 RID: 23124
		[Token(Token = "0x4005A54")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleEquipType type;

		// Token: 0x04005A55 RID: 23125
		[Token(Token = "0x4005A55")]
		[FieldOffset(Offset = "0x18")]
		public string textId;
	}
}
