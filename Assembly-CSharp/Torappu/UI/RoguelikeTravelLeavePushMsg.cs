using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B1E RID: 15134
	[Token(Token = "0x2003B1E")]
	public class RoguelikeTravelLeavePushMsg
	{
		// Token: 0x06017D15 RID: 97557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D15")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTravelLeavePushMsg()
		{
		}

		// Token: 0x0401CC4E RID: 117838
		[Token(Token = "0x401CC4E")]
		[FieldOffset(Offset = "0x10")]
		public List<string> charList;

		// Token: 0x0401CC4F RID: 117839
		[Token(Token = "0x401CC4F")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelikeV2.CurrentData.Troop.ExpedType type;
	}
}
