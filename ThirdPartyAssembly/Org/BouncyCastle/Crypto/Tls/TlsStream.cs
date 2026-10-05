using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	internal class TlsStream : Stream
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001702")]
		[Address(RVA = "0x5275620", Offset = "0x5274220", VA = "0x185275620")]
		internal TlsStream(TlsProtocol handler)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x1700032D")]
		public override bool CanRead
		{
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x5275690", Offset = "0x5274290", VA = "0x185275690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x1700032E")]
		public override bool CanSeek
		{
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x1700032F")]
		public override bool CanWrite
		{
			[Token(Token = "0x6001705")]
			[Address(RVA = "0x5275690", Offset = "0x5274290", VA = "0x185275690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x5275280", Offset = "0x5273E80", VA = "0x185275280", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001707")]
		[Address(RVA = "0x52752E0", Offset = "0x5273EE0", VA = "0x1852752E0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x17000330")]
		public override long Length
		{
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x52756E0", Offset = "0x52742E0", VA = "0x1852756E0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0000B5E0 File Offset: 0x000097E0
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000331")]
		public override long Position
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x5275730", Offset = "0x5274330", VA = "0x185275730", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x5275780", Offset = "0x5274380", VA = "0x185275780", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x600170B")]
		[Address(RVA = "0x52753D0", Offset = "0x5273FD0", VA = "0x1852753D0", Slot = "32")]
		public override int Read(byte[] buf, int off, int len)
		{
			return 0;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x5275320", Offset = "0x5273F20", VA = "0x185275320", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x5275450", Offset = "0x5274050", VA = "0x185275450", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x52754A0", Offset = "0x52740A0", VA = "0x1852754A0", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x52755A0", Offset = "0x52741A0", VA = "0x1852755A0", Slot = "35")]
		public override void Write(byte[] buf, int off, int len)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x52754F0", Offset = "0x52740F0", VA = "0x1852754F0", Slot = "37")]
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x28")]
		private readonly TlsProtocol handler;
	}
}
