using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public readonly struct AsyncLocalValueChangedArgs<T>
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700019C")]
		public T CurrentValue
		{
			[Token(Token = "0x6001198")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001199")]
		internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
		{
		}
	}
}
