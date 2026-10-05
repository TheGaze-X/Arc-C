using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public abstract class InputProcessor<TValue> : InputProcessor where TValue : struct
	{
		// Token: 0x06000617 RID: 1559
		[Token(Token = "0x6000617")]
		public abstract TValue Process(TValue value, InputControl control);

		// Token: 0x06000618 RID: 1560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000618")]
		public override object ProcessAsObject(object value, InputControl control)
		{
			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		public unsafe override void Process(void* buffer, int bufferSize, InputControl control)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		protected InputProcessor()
		{
		}
	}
}
