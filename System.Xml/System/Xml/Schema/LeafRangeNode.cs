using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	internal sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x17000203")]
		public decimal Max
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			get
			{
				return 0m;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x17000204")]
		public decimal Min
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return 0m;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000205")]
		public BitSet NextIteration
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x18")]
		private decimal min;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x28")]
		private decimal max;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x38")]
		private BitSet nextIteration;
	}
}
