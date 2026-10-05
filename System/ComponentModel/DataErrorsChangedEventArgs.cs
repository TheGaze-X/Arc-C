using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public class DataErrorsChangedEventArgs : EventArgs
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x5159D00", Offset = "0x5158900", VA = "0x185159D00")]
		public DataErrorsChangedEventArgs(string propertyName)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		public virtual string PropertyName
		{
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
