using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Network
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public struct RespMsgBundle<T> : IMsgBundle
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00008264 File Offset: 0x00006464
		[Token(Token = "0x6000C4C")]
		private static bool _IsCustomizedBundle()
		{
			return default(bool);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4D")]
		public string Serialize(JsonSerializerSettings setting)
		{
			return null;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C4E")]
		public void Deserialize(string text, JsonSerializerSettings setting)
		{
		}

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x0")]
		public T data;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x0")]
		public object meta;
	}
}
