using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013F6 RID: 5110
	[Token(Token = "0x20013F6")]
	public struct ModifiedSharedCharData
	{
		// Token: 0x040071FE RID: 29182
		[Token(Token = "0x40071FE")]
		[FieldOffset(Offset = "0x0")]
		public SharedCharData charData;

		// Token: 0x040071FF RID: 29183
		[Token(Token = "0x40071FF")]
		[FieldOffset(Offset = "0x8")]
		public bool isSkillLevelLimited;

		// Token: 0x04007200 RID: 29184
		[Token(Token = "0x4007200")]
		[FieldOffset(Offset = "0x9")]
		public bool isEquipLimited;

		// Token: 0x04007201 RID: 29185
		[Token(Token = "0x4007201")]
		[FieldOffset(Offset = "0x10")]
		public List<bool> isSkillUnlocked;

		// Token: 0x04007202 RID: 29186
		[Token(Token = "0x4007202")]
		[FieldOffset(Offset = "0x18")]
		public List<bool> isSkillLimited;
	}
}
