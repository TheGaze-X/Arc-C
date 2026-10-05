using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	[System.Serializable]
	internal sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		// Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x4ADF180", Offset = "0x4ADDD80", VA = "0x184ADF180")]
		internal InternalDecoderBestFitFallback(Encoding encoding)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x4ADEFE0", Offset = "0x4ADDBE0", VA = "0x184ADEFE0", Slot = "4")]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x17000215")]
		public override int MaxCharCount
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x4ADF040", Offset = "0x4ADDC40", VA = "0x184ADF040", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x4ADF130", Offset = "0x4ADDD30", VA = "0x184ADF130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x20")]
		internal char _cReplacement;
	}
}
