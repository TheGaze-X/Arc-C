using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000216")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x6001550")]
			[Address(RVA = "0x4ADEF30", Offset = "0x4ADDB30", VA = "0x184ADEF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x4ADED60", Offset = "0x4ADD960", VA = "0x184ADED60")]
		public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x4ADEB80", Offset = "0x4ADD780", VA = "0x184ADEB80", Slot = "4")]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x4ADEBD0", Offset = "0x4ADD7D0", VA = "0x184ADEBD0", Slot = "5")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x17000217")]
		public override int Remaining
		{
			[Token(Token = "0x6001554")]
			[Address(RVA = "0x4ADEFD0", Offset = "0x4ADDBD0", VA = "0x184ADEFD0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x4ADEBF0", Offset = "0x4ADD7F0", VA = "0x184ADEBF0", Slot = "7")]
		public override void Reset()
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "9")]
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 0;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x4ADEC00", Offset = "0x4ADD800", VA = "0x184ADEC00")]
		private char TryBestFit(byte[] bytesCheck)
		{
			return '\0';
		}

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x20")]
		private char _cBestFit;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x24")]
		private int _iCount;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x28")]
		private int _iSize;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x30")]
		private InternalDecoderBestFitFallback _oFallback;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x0")]
		private static object s_InternalSyncObject;
	}
}
