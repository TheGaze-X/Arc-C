using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008A9 RID: 2217
	[Token(Token = "0x20008A9")]
	public class SquadFormationRequest
	{
		// Token: 0x06006553 RID: 25939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006553")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SquadFormationRequest()
		{
		}

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x10")]
		public string squadId;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x18")]
		public RequestSquadSlot[] slots;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(BoolToIntJsonConverter))]
		public bool changeSkill;
	}
}
