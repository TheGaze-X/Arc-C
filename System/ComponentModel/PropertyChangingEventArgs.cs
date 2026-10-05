using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x515F9E0", Offset = "0x515E5E0", VA = "0x18515F9E0")]
		public PropertyChangingEventArgs(string propertyName)
		{
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B9")]
		public virtual string PropertyName
		{
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
