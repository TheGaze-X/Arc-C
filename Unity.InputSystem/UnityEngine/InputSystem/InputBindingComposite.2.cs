using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public abstract class InputBindingComposite<TValue> : InputBindingComposite where TValue : struct
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000137")]
		public override Type valueType
		{
			[Token(Token = "0x6000407")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x17000138")]
		public override int valueSizeInBytes
		{
			[Token(Token = "0x6000408")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000409 RID: 1033
		[Token(Token = "0x6000409")]
		public abstract TValue ReadValue(ref InputBindingCompositeContext context);

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040B")]
		public override object ReadValueAsObject(ref InputBindingCompositeContext context)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		protected InputBindingComposite()
		{
		}
	}
}
