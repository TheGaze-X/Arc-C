using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	internal sealed class RegexNode
	{
		// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x510DD00", Offset = "0x510C900", VA = "0x18510DD00")]
		public RegexNode(int type, RegexOptions options)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x510DD40", Offset = "0x510C940", VA = "0x18510DD40")]
		public RegexNode(int type, RegexOptions options, char ch)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x510DC10", Offset = "0x510C810", VA = "0x18510DC10")]
		public RegexNode(int type, RegexOptions options, string str)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x510DC60", Offset = "0x510C860", VA = "0x18510DC60")]
		public RegexNode(int type, RegexOptions options, int m)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x510DCB0", Offset = "0x510C8B0", VA = "0x18510DCB0")]
		public RegexNode(int type, RegexOptions options, int m, int n)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x510DC00", Offset = "0x510C800", VA = "0x18510DC00")]
		public bool UseOptionR()
		{
			return default(bool);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x510DAA0", Offset = "0x510C6A0", VA = "0x18510DAA0")]
		public RegexNode ReverseLeft()
		{
			return null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x510CCD0", Offset = "0x510B8D0", VA = "0x18510CCD0")]
		private void MakeRep(int type, int min, int max)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x510D840", Offset = "0x510C440", VA = "0x18510D840")]
		private RegexNode Reduce()
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x510DB10", Offset = "0x510C710", VA = "0x18510DB10")]
		private RegexNode StripEnation(int emptyType)
		{
			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x510D4A0", Offset = "0x510C0A0", VA = "0x18510D4A0")]
		private RegexNode ReduceGroup()
		{
			return null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x510D510", Offset = "0x510C110", VA = "0x18510D510")]
		private RegexNode ReduceRep()
		{
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x510D6D0", Offset = "0x510C2D0", VA = "0x18510D6D0")]
		private RegexNode ReduceSet()
		{
			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x510CCE0", Offset = "0x510B8E0", VA = "0x18510CCE0")]
		private RegexNode ReduceAlternation()
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x510D0E0", Offset = "0x510BCE0", VA = "0x18510D0E0")]
		private RegexNode ReduceConcatenation()
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x510CBB0", Offset = "0x510B7B0", VA = "0x18510CBB0")]
		public RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			return null;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x510CA20", Offset = "0x510B620", VA = "0x18510CA20")]
		public void AddChild(RegexNode newChild)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x510CB50", Offset = "0x510B750", VA = "0x18510CB50")]
		public RegexNode Child(int i)
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x510CB10", Offset = "0x510B710", VA = "0x18510CB10")]
		public int ChildCount()
		{
			return 0;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
		public int Type()
		{
			return 0;
		}

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x10")]
		public int NType;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x18")]
		public List<RegexNode> Children;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x20")]
		public string Str;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x28")]
		public char Ch;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x2C")]
		public int M;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x30")]
		public int N;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x34")]
		public readonly RegexOptions Options;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x38")]
		public RegexNode Next;
	}
}
