using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	public class PropertyChangedEventArgs : EventArgs
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x515F970", Offset = "0x515E570", VA = "0x18515F970")]
		public PropertyChangedEventArgs(string propertyName)
		{
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public virtual string PropertyName
		{
			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
