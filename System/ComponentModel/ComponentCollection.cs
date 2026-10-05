using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x51215E0", Offset = "0x51201E0", VA = "0x1851215E0")]
		public ComponentCollection(IComponent[] components)
		{
		}

		// Token: 0x170001B7 RID: 439
		[Token(Token = "0x170001B7")]
		public virtual IComponent this[string name]
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x5121700", Offset = "0x5120300", VA = "0x185121700", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B8 RID: 440
		[Token(Token = "0x170001B8")]
		public virtual IComponent this[int index]
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x5121650", Offset = "0x5120250", VA = "0x185121650", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x4C6AE90", Offset = "0x4C69A90", VA = "0x184C6AE90")]
		public void CopyTo(IComponent[] array, int index)
		{
		}
	}
}
