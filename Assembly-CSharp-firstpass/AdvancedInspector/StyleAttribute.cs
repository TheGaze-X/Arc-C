using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class StyleAttribute : Attribute
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public string Style
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public bool Label
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4F4D60", Offset = "0x4F3960", VA = "0x1804F4D60")]
		public StyleAttribute(string style)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4F4DE0", Offset = "0x4F39E0", VA = "0x1804F4DE0")]
		public StyleAttribute(string style, bool label)
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		private string style;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		private bool label;
	}
}
