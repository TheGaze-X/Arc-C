using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	public abstract class EncodingProvider
	{
		// Token: 0x060015F3 RID: 5619
		[Token(Token = "0x60015F3")]
		public abstract Encoding GetEncoding(string name);

		// Token: 0x060015F4 RID: 5620
		[Token(Token = "0x60015F4")]
		public abstract Encoding GetEncoding(int codepage);

		// Token: 0x060015F5 RID: 5621 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x4AFA660", Offset = "0x4AF9260", VA = "0x184AFA660", Slot = "6")]
		public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return null;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x4AFA430", Offset = "0x4AF9030", VA = "0x184AFA430")]
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			return null;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x4AFA540", Offset = "0x4AF9140", VA = "0x184AFA540")]
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			return null;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x4AFA300", Offset = "0x4AF8F00", VA = "0x184AFA300")]
		internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			return null;
		}

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x0")]
		private static object s_InternalSyncObject;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x8")]
		private static EncodingProvider[] s_providers;
	}
}
