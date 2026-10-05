using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu.Network
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public struct MsgBundle<T> : IMsgBundle, IMsgBundleWithPopulation
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C47")]
		public string Serialize(JsonSerializerSettings setting)
		{
			return null;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C48")]
		public string Serialize(JObject population, JsonSerializerSettings setting)
		{
			return null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C49")]
		public void Deserialize(string text, JsonSerializerSettings setting)
		{
		}

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x0")]
		public T data;
	}
}
