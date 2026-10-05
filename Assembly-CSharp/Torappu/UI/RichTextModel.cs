using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200389A RID: 14490
	[Token(Token = "0x200389A")]
	public struct RichTextModel
	{
		// Token: 0x06016F04 RID: 93956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F04")]
		[Address(RVA = "0xF5B960", Offset = "0xF5A560", VA = "0x180F5B960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06016F05 RID: 93957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F05")]
		[Address(RVA = "0xF5BA00", Offset = "0xF5A600", VA = "0x180F5BA00")]
		private string _GenPrefix()
		{
			return null;
		}

		// Token: 0x06016F06 RID: 93958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F06")]
		[Address(RVA = "0xF5BBB0", Offset = "0xF5A7B0", VA = "0x180F5BBB0")]
		private string _GenSuffix()
		{
			return null;
		}

		// Token: 0x0401BAE0 RID: 113376
		[Token(Token = "0x401BAE0")]
		[FieldOffset(Offset = "0x0")]
		public int typeFlags;

		// Token: 0x0401BAE1 RID: 113377
		[Token(Token = "0x401BAE1")]
		[FieldOffset(Offset = "0x4")]
		public bool bold;

		// Token: 0x0401BAE2 RID: 113378
		[Token(Token = "0x401BAE2")]
		[FieldOffset(Offset = "0x5")]
		public bool italic;

		// Token: 0x0401BAE3 RID: 113379
		[Token(Token = "0x401BAE3")]
		[FieldOffset(Offset = "0x8")]
		public int size;

		// Token: 0x0401BAE4 RID: 113380
		[Token(Token = "0x401BAE4")]
		[FieldOffset(Offset = "0xC")]
		public Color color;

		// Token: 0x0401BAE5 RID: 113381
		[Token(Token = "0x401BAE5")]
		[FieldOffset(Offset = "0x20")]
		public string content;

		// Token: 0x0200389B RID: 14491
		[Token(Token = "0x200389B")]
		public enum StyleType
		{
			// Token: 0x0401BAE7 RID: 113383
			[Token(Token = "0x401BAE7")]
			BOLD = 1,
			// Token: 0x0401BAE8 RID: 113384
			[Token(Token = "0x401BAE8")]
			ITALIC,
			// Token: 0x0401BAE9 RID: 113385
			[Token(Token = "0x401BAE9")]
			SIZE = 4,
			// Token: 0x0401BAEA RID: 113386
			[Token(Token = "0x401BAEA")]
			COLOR = 8
		}
	}
}
