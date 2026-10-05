using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	internal class RecordStream
	{
		// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x524EA70", Offset = "0x524D670", VA = "0x18524EA70")]
		internal RecordStream(TlsProtocol handler, Stream input, Stream output)
		{
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x524DE60", Offset = "0x524CA60", VA = "0x18524DE60", Slot = "4")]
		internal virtual void Init(TlsContext context)
		{
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x524DE50", Offset = "0x524CA50", VA = "0x18524DE50", Slot = "5")]
		internal virtual int GetPlaintextLimit()
		{
			return 0;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x524E580", Offset = "0x524D180", VA = "0x18524E580", Slot = "6")]
		internal virtual void SetPlaintextLimit(int plaintextLimit)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E9")]
		internal virtual ProtocolVersion ReadVersion
		{
			[Token(Token = "0x600150A")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600150B")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150C")]
		[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340", Slot = "9")]
		internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
		{
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x906A90", Offset = "0x905690", VA = "0x180906A90", Slot = "10")]
		internal virtual void SetRestrictReadVersion(bool enabled)
		{
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x524E540", Offset = "0x524D140", VA = "0x18524E540", Slot = "11")]
		internal virtual void SetPendingConnectionState(TlsCompression tlsCompression, TlsCipher tlsCipher)
		{
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x524E4B0", Offset = "0x524D0B0", VA = "0x18524E4B0", Slot = "12")]
		internal virtual void SentWriteCipherSpec()
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x524E390", Offset = "0x524CF90", VA = "0x18524E390", Slot = "13")]
		internal virtual void ReceivedReadCipherSpec()
		{
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x524DCE0", Offset = "0x524C8E0", VA = "0x18524DCE0", Slot = "14")]
		internal virtual void FinaliseHandshake()
		{
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x524E0E0", Offset = "0x524CCE0", VA = "0x18524E0E0", Slot = "15")]
		internal virtual bool ReadRecord()
		{
			return default(bool);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x524D9F0", Offset = "0x524C5F0", VA = "0x18524D9F0", Slot = "16")]
		internal virtual byte[] DecodeAndVerify(byte type, Stream input, int len)
		{
			return null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x524E620", Offset = "0x524D220", VA = "0x18524E620", Slot = "17")]
		internal virtual void WriteRecord(byte type, byte[] plaintext, int plaintextOffset, int plaintextLength)
		{
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x524E010", Offset = "0x524CC10", VA = "0x18524E010", Slot = "18")]
		internal virtual void NotifyHelloComplete()
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		internal virtual TlsHandshakeHash HandshakeHash
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x524E070", Offset = "0x524CC70", VA = "0x18524E070", Slot = "20")]
		internal virtual TlsHandshakeHash PrepareToFinish()
		{
			return null;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x524E5A0", Offset = "0x524D1A0", VA = "0x18524E5A0", Slot = "21")]
		internal virtual void UpdateHandshakeData(byte[] message, int offset, int len)
		{
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x524E420", Offset = "0x524D020", VA = "0x18524E420", Slot = "22")]
		internal virtual void SafeClose()
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x524DD80", Offset = "0x524C980", VA = "0x18524DD80", Slot = "23")]
		internal virtual void Flush()
		{
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x524DDC0", Offset = "0x524C9C0", VA = "0x18524DDC0")]
		private byte[] GetBufferContents()
		{
			return null;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x524D980", Offset = "0x524C580", VA = "0x18524D980")]
		private static void CheckType(byte type, byte alertDescription)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x524D920", Offset = "0x524C520", VA = "0x18524D920")]
		private static void CheckLength(int length, int limit, byte alertDescription)
		{
		}

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		private const int DEFAULT_PLAINTEXT_LIMIT = 16384;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		internal const int TLS_HEADER_SIZE = 5;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		internal const int TLS_HEADER_TYPE_OFFSET = 0;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		internal const int TLS_HEADER_VERSION_OFFSET = 1;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		internal const int TLS_HEADER_LENGTH_OFFSET = 3;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x10")]
		private TlsProtocol mHandler;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x18")]
		private Stream mInput;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x20")]
		private Stream mOutput;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x28")]
		private TlsCompression mPendingCompression;

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x30")]
		private TlsCompression mReadCompression;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x38")]
		private TlsCompression mWriteCompression;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x40")]
		private TlsCipher mPendingCipher;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x48")]
		private TlsCipher mReadCipher;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x50")]
		private TlsCipher mWriteCipher;

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x58")]
		private long mReadSeqNo;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x60")]
		private long mWriteSeqNo;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x68")]
		private MemoryStream mBuffer;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x70")]
		private TlsHandshakeHash mHandshakeHash;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x78")]
		private ProtocolVersion mReadVersion;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x80")]
		private ProtocolVersion mWriteVersion;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x88")]
		private bool mRestrictReadVersion;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x8C")]
		private int mPlaintextLimit;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x90")]
		private int mCompressedLimit;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x94")]
		private int mCiphertextLimit;
	}
}
