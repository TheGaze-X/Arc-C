using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public struct ValueDropdownItem : IValueDropdownItem
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		public ValueDropdownItem(string text, object value)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4E1C5E0", Offset = "0x4E1B1E0", VA = "0x184E1C5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "4")]
		private string GetText()
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		private object GetValue()
		{
			return null;
		}

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x8")]
		public object Value;
	}
}
