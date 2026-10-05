using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Preserve]
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4D7CE40", Offset = "0x4D7BA40", VA = "0x184D7CE40")]
		public PropertyChangingEventArgs(string propertyName)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000007")]
		public virtual string PropertyName
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
