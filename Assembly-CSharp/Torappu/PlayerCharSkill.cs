using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	[Serializable]
	public class PlayerCharSkill
	{
		// Token: 0x060065BC RID: 26044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharSkill()
		{
		}

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[FieldOffset(Offset = "0x10")]
		[JsonConverter(typeof(BoolToIntJsonConverter))]
		public bool unlock;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x18")]
		public string skillId;

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x20")]
		public int specializeLevel;
	}
}
