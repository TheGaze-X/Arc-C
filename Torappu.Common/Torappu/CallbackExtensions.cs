using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public static class CallbackExtensions
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		public static Output NullableInvoke<Output>(this Func<Output> callback)
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		public static Output NullableInvoke<Input, Output>(this Func<Input, Output> callback, Input input)
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x54DAED0", Offset = "0x54D9AD0", VA = "0x1854DAED0")]
		public static void NullableInvoke(this Action callback)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000086")]
		public static void NullableInvoke<Input>(this Action<Input> callback, Input input)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000087")]
		public static void NullableInvoke<P1, P2>(this Action<P1, P2> callback, P1 p1, P2 p2)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000088")]
		public static void NullableInvoke<P1, P2, P3>(this Action<P1, P2, P3> callback, P1 p1, P2 p2, P3 p3)
		{
		}
	}
}
