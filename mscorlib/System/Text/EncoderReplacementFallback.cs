using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	[System.Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060015D5 RID: 5589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x4AF7E50", Offset = "0x4AF6A50", VA = "0x184AF7E50")]
		public EncoderReplacementFallback()
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x4AF7E90", Offset = "0x4AF6A90", VA = "0x184AF7E90")]
		internal EncoderReplacementFallback(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x4AF7DF0", Offset = "0x4AF69F0", VA = "0x184AF7DF0", Slot = "6")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x4AF7F50", Offset = "0x4AF6B50", VA = "0x184AF7F50")]
		public EncoderReplacementFallback(string replacement)
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000232")]
		public string DefaultString
		{
			[Token(Token = "0x60015D9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x4AF7CF0", Offset = "0x4AF68F0", VA = "0x184AF7CF0", Slot = "4")]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Token(Token = "0x17000233")]
		public override int MaxCharCount
		{
			[Token(Token = "0x60015DB")]
			[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x4AF7D80", Offset = "0x4AF6980", VA = "0x184AF7D80", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x10")]
		private string _strDefault;
	}
}
