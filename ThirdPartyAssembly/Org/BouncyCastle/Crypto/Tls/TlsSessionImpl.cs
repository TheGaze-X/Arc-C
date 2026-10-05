using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	internal class TlsSessionImpl : TlsSession
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x5274570", Offset = "0x5273170", VA = "0x185274570")]
		internal TlsSessionImpl(byte[] sessionID, SessionParameters sessionParameters)
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x5274420", Offset = "0x5273020", VA = "0x185274420", Slot = "8")]
		public virtual SessionParameters ExportSessionParameters()
		{
			return null;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032A")]
		public virtual byte[] SessionID
		{
			[Token(Token = "0x60016F3")]
			[Address(RVA = "0x5274730", Offset = "0x5273330", VA = "0x185274730", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x52744D0", Offset = "0x52730D0", VA = "0x1852744D0", Slot = "10")]
		public virtual void Invalidate()
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x1700032B")]
		public virtual bool IsResumable
		{
			[Token(Token = "0x60016F5")]
			[Address(RVA = "0x5274690", Offset = "0x5273290", VA = "0x185274690", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x10")]
		internal readonly byte[] mSessionID;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x18")]
		internal SessionParameters mSessionParameters;
	}
}
