using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C98")]
		public InvokableCall(object target, MethodInfo theFunction)
		{
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C99")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9A")]
		public void Invoke(T1 args0, T2 args1, T3 args2)
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x6000C9B")]
		public override bool Find(object targetObj, MethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityAction<T1, T2, T3> Delegate;
	}
}
