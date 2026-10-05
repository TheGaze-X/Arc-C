using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public class Label : TextElement
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x5AB7540", Offset = "0x5AB6140", VA = "0x185AB7540")]
		public Label()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x5AB7480", Offset = "0x5AB6080", VA = "0x185AB7480")]
		public Label(string text)
		{
		}

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0200011F RID: 287
		[Token(Token = "0x200011F")]
		public new class UxmlFactory : UxmlFactory<Label, Label.UxmlTraits>
		{
			// Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x5ABD4A0", Offset = "0x5ABC0A0", VA = "0x185ABD4A0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x5ABE550", Offset = "0x5ABD150", VA = "0x185ABE550")]
			public UxmlTraits()
			{
			}
		}
	}
}
