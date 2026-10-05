using System;
using System.Security;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	internal static class UnsafeNclNativeMethods
	{
		// Token: 0x020002F8 RID: 760
		[Token(Token = "0x20002F8")]
		internal static class HttpApi
		{
			// Token: 0x04000B82 RID: 2946
			[Token(Token = "0x4000B82")]
			[FieldOffset(Offset = "0x0")]
			private static string[] m_Strings;

			// Token: 0x020002F9 RID: 761
			[Token(Token = "0x20002F9")]
			internal static class HTTP_REQUEST_HEADER_ID
			{
				// Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001516")]
				[Address(RVA = "0x5071950", Offset = "0x5070550", VA = "0x185071950")]
				internal static string ToString(int position)
				{
					return null;
				}

				// Token: 0x04000B83 RID: 2947
				[Token(Token = "0x4000B83")]
				[FieldOffset(Offset = "0x0")]
				private static string[] m_Strings;
			}
		}

		// Token: 0x020002FA RID: 762
		[Token(Token = "0x20002FA")]
		internal static class SecureStringHelper
		{
			// Token: 0x06001518 RID: 5400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x50813D0", Offset = "0x507FFD0", VA = "0x1850813D0")]
			internal static string CreateString(SecureString secureString)
			{
				return null;
			}

			// Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001519")]
			[Address(RVA = "0x5081310", Offset = "0x507FF10", VA = "0x185081310")]
			internal static SecureString CreateSecureString(string plainString)
			{
				return null;
			}
		}
	}
}
