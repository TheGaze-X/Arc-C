using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9F")]
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA0")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA1")]
		public override void Invoke(T arg0)
		{
		}

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x0")]
		private readonly T m_Arg1;
	}
}
