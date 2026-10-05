using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008FB RID: 2299
	[Token(Token = "0x20008FB")]
	public class PlayerCharPatch
	{
		// Token: 0x060065D3 RID: 26067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharPatch()
		{
		}

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x18")]
		public int defaultSkillIndex;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCharSkill[] skills;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x28")]
		public string currentEquip;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, PlayerCharEquipInfo> equip;
	}
}
