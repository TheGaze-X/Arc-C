using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	public sealed class AsyncLocal<T> : IAsyncLocal
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001194")]
		public AsyncLocal(System.Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
		{
		}

		// Token: 0x1700019B RID: 411
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019B")]
		public T Value
		{
			[Token(Token = "0x6001195")]
			set
			{
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001196")]
		private void OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
		{
		}

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x0")]
		private readonly System.Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
	}
}
