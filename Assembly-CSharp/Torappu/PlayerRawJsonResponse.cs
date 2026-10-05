using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu.Network;

namespace Torappu
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	public class PlayerRawJsonResponse : ICustomizedBundleData, IPlayerPushMsgResponse
	{
		// Token: 0x0600623D RID: 25149 RVA: 0x00030270 File Offset: 0x0002E470
		[Token(Token = "0x600623D")]
		[Address(RVA = "0x1DF08E0", Offset = "0x1DEF4E0", VA = "0x181DF08E0")]
		public PlayerDataDelta ConsumePlayerDataDelta()
		{
			return default(PlayerDataDelta);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623E")]
		[Address(RVA = "0x1DF06C0", Offset = "0x1DEF2C0", VA = "0x181DF06C0", Slot = "6")]
		public List<PlayerPushMessage> AchievePushMessages()
		{
			return null;
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623F")]
		[Address(RVA = "0x1DF09E0", Offset = "0x1DEF5E0", VA = "0x181DF09E0", Slot = "5")]
		public void Deserialize(string data, JsonSerializerSettings setting)
		{
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006240")]
		[Address(RVA = "0x1DF0A70", Offset = "0x1DEF670", VA = "0x181DF0A70", Slot = "4")]
		public string Serialize(JsonSerializerSettings setting)
		{
			return null;
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006241")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerRawJsonResponse()
		{
		}

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0x10")]
		public JObject content;
	}
}
