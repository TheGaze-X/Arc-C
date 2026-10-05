using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000227")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x4AFAEA0", Offset = "0x4AF9AA0", VA = "0x184AFAEA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x4AFACD0", Offset = "0x4AF98D0", VA = "0x184AFACD0")]
		public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x4AFA860", Offset = "0x4AF9460", VA = "0x184AFA860", Slot = "4")]
		public override bool Fallback(char charUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x4AFA970", Offset = "0x4AF9570", VA = "0x184AFA970", Slot = "5")]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			return default(bool);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x4AFAB90", Offset = "0x4AF9790", VA = "0x184AFAB90", Slot = "6")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x4AFABB0", Offset = "0x4AF97B0", VA = "0x184AFABB0", Slot = "7")]
		public override bool MovePrevious()
		{
			return default(bool);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x17000228")]
		public override int Remaining
		{
			[Token(Token = "0x60015A6")]
			[Address(RVA = "0x4AFAF40", Offset = "0x4AF9B40", VA = "0x184AFAF40", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x4AFABD0", Offset = "0x4AF97D0", VA = "0x184AFABD0", Slot = "9")]
		public override void Reset()
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x4AFABF0", Offset = "0x4AF97F0", VA = "0x184AFABF0")]
		private char TryBestFit(char cUnknown)
		{
			return '\0';
		}

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x30")]
		private char _cBestFit;

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x38")]
		private InternalEncoderBestFitFallback _oFallback;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x40")]
		private int _iCount;

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x44")]
		private int _iSize;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x0")]
		private static object s_InternalSyncObject;
	}
}
