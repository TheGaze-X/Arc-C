using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	public class HandBookAddonStageBattleStartRequest
	{
		// Token: 0x060063D5 RID: 25557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookAddonStageBattleStartRequest()
		{
		}

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x28")]
		[JsonConverter(typeof(StringEnumConverter))]
		public StageType stageType;
	}
}
