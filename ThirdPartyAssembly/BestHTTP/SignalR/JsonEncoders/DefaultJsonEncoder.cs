using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.JsonEncoders
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	public sealed class DefaultJsonEncoder : IJsonEncoder
	{
		// Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x53E8920", Offset = "0x53E7520", VA = "0x1853E8920", Slot = "4")]
		public string Encode(object obj)
		{
			return null;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x53E8930", Offset = "0x53E7530", VA = "0x1853E8930", Slot = "5")]
		public IDictionary<string, object> DecodeMessage(string json)
		{
			return null;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultJsonEncoder()
		{
		}
	}
}
