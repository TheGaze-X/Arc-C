using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	internal class BasicNodePool<T> : LinkedPool<BasicNode<T>>
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		private static void Reset(BasicNode<T> node)
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600124C")]
		private static BasicNode<T> Create()
		{
			return null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		public BasicNodePool()
		{
		}
	}
}
