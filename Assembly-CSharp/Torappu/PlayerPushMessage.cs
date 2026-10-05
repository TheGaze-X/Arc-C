using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	public class PlayerPushMessage
	{
		// Token: 0x06006243 RID: 25155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006243")]
		[Address(RVA = "0x1DF05D0", Offset = "0x1DEF1D0", VA = "0x181DF05D0")]
		public static PlayerPushMessage CreateFromJSON(JObjectWrapper jObj)
		{
			return null;
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006244")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerPushMessage()
		{
		}

		// Token: 0x04002D9D RID: 11677
		[Token(Token = "0x4002D9D")]
		public const string PUSH_MSG_FIELD = "pushMessage";

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0x18")]
		public JObject payload;
	}
}
