using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>>
	{
		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		public void AppendTo(ref BasicNode<T> first)
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124A")]
		public BasicNode()
		{
		}

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x0")]
		public BasicNode<T> next;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x0")]
		public T data;
	}
}
