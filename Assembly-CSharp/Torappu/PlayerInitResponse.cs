using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	public abstract class PlayerInitResponse : IPlayerPushMsgResponse
	{
		// Token: 0x0600623B RID: 25147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623B")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
		public List<PlayerPushMessage> AchievePushMessages()
		{
			return null;
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623C")]
		[Address(RVA = "0x1DF0540", Offset = "0x1DEF140", VA = "0x181DF0540")]
		protected PlayerInitResponse()
		{
		}

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x10")]
		public JObject user;

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "pushMessage")]
		public List<PlayerPushMessage> pushMessage;
	}
}
