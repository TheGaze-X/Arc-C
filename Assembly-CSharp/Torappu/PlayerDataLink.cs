using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000C17 RID: 3095
	[Token(Token = "0x2000C17")]
	public class PlayerDataLink : IPlayerDataLink
	{
		// Token: 0x060068E8 RID: 26856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x200BD80", Offset = "0x200A980", VA = "0x18200BD80", Slot = "4")]
		public JsonSerializerSettings GetPlayerDataSerializerSetting()
		{
			return null;
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerDataLink()
		{
		}
	}
}
