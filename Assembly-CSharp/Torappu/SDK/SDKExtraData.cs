using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.SDK
{
	// Token: 0x02001507 RID: 5383
	[Token(Token = "0x2001507")]
	public struct SDKExtraData
	{
		// Token: 0x06007BB4 RID: 31668 RVA: 0x00037260 File Offset: 0x00035460
		[Token(Token = "0x6007BB4")]
		[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x00037278 File Offset: 0x00035478
		[Token(Token = "0x6007BB5")]
		[Address(RVA = "0x273F020", Offset = "0x273DC20", VA = "0x18273F020")]
		public static SDKExtraData FromJson(string jsonStr)
		{
			return default(SDKExtraData);
		}

		// Token: 0x04007A38 RID: 31288
		[Token(Token = "0x4007A38")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SDKExtraData EMPTY;

		// Token: 0x04007A39 RID: 31289
		[Token(Token = "0x4007A39")]
		[FieldOffset(Offset = "0x0")]
		public SDKExtraType code;

		// Token: 0x04007A3A RID: 31290
		[Token(Token = "0x4007A3A")]
		[FieldOffset(Offset = "0x8")]
		public JObject msg;
	}
}
