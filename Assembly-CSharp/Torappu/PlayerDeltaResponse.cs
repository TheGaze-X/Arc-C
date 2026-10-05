using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	public abstract class PlayerDeltaResponse : IPlayerPushMsgResponse
	{
		// Token: 0x06006238 RID: 25144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006238")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
		public List<PlayerPushMessage> AchievePushMessages()
		{
			return null;
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006239")]
		[Address(RVA = "0x1DF04B0", Offset = "0x1DEF0B0", VA = "0x181DF04B0")]
		protected PlayerDeltaResponse()
		{
		}

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "playerDataDelta")]
		public PlayerDataDelta playerDataDelta;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "pushMessage")]
		public List<PlayerPushMessage> pushMessage;
	}
}
