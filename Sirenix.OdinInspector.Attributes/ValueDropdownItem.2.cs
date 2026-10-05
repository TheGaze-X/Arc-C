using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public struct ValueDropdownItem<T> : IValueDropdownItem
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		public ValueDropdownItem(string text, T value)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019C")]
		private string GetText()
		{
			return null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019D")]
		private object GetValue()
		{
			return null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019E")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
