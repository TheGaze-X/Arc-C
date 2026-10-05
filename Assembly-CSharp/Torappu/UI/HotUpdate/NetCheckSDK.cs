using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A82 RID: 19074
	[Token(Token = "0x2004A82")]
	public class NetCheckSDK : Singleton<NetCheckSDK>
	{
		// Token: 0x0601CAA8 RID: 117416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA8")]
		[Address(RVA = "0x162DBE0", Offset = "0x162C7E0", VA = "0x18162DBE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CAA9 RID: 117417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA9")]
		[Address(RVA = "0x162DA00", Offset = "0x162C600", VA = "0x18162DA00")]
		public void SetUserID(string uid)
		{
		}

		// Token: 0x0601CAAA RID: 117418 RVA: 0x000A9038 File Offset: 0x000A7238
		[Token(Token = "0x601CAAA")]
		[Address(RVA = "0x162D950", Offset = "0x162C550", VA = "0x18162D950")]
		public static bool EnableNetCheck()
		{
			return default(bool);
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAAB")]
		[Address(RVA = "0x162DCA0", Offset = "0x162C8A0", VA = "0x18162DCA0")]
		private NetCheckSDK()
		{
		}

		// Token: 0x040259EE RID: 154094
		[Token(Token = "0x40259EE")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isInited;

		// Token: 0x040259EF RID: 154095
		[Token(Token = "0x40259EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040259F0 RID: 154096
		[Token(Token = "0x40259F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetUserID;

		// Token: 0x040259F1 RID: 154097
		[Token(Token = "0x40259F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnableNetCheck;

		// Token: 0x040259F2 RID: 154098
		[Token(Token = "0x40259F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A83 RID: 19075
		[Token(Token = "0x2004A83")]
		private class IDParam : IHotfixable
		{
			// Token: 0x0601CAAC RID: 117420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CAAC")]
			[Address(RVA = "0x162D810", Offset = "0x162C410", VA = "0x18162D810")]
			public string ToJSON()
			{
				return null;
			}

			// Token: 0x0601CAAD RID: 117421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CAAD")]
			[Address(RVA = "0x162D8F0", Offset = "0x162C4F0", VA = "0x18162D8F0")]
			public IDParam()
			{
			}

			// Token: 0x040259F3 RID: 154099
			[Token(Token = "0x40259F3")]
			[FieldOffset(Offset = "0x10")]
			public string userId;

			// Token: 0x040259F4 RID: 154100
			[Token(Token = "0x40259F4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ToJSON;

			// Token: 0x040259F5 RID: 154101
			[Token(Token = "0x40259F5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
