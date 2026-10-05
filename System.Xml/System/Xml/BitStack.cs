using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	internal class BitStack
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4F73E90", Offset = "0x4F72A90", VA = "0x184F73E90")]
		public BitStack()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4F73C90", Offset = "0x4F72890", VA = "0x184F73C90")]
		public void PushBit(bool bit)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4F73BF0", Offset = "0x4F727F0", VA = "0x184F73BF0")]
		public bool PopBit()
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4F73BE0", Offset = "0x4F727E0", VA = "0x184F73BE0")]
		public bool PeekBit()
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4F73DB0", Offset = "0x4F729B0", VA = "0x184F73DB0")]
		private void PushCurr()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4F73C50", Offset = "0x4F72850", VA = "0x184F73C50")]
		private void PopCurr()
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		private uint[] bitStack;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		private int stackPos;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1C")]
		private uint curr;
	}
}
