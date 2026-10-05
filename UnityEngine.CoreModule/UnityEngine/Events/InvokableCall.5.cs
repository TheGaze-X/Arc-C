using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9C")]
		public InvokableCall(object target, MethodInfo theFunction)
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9D")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x6000C9E")]
		public override bool Find(object targetObj, MethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityAction<T1, T2, T3, T4> Delegate;
	}
}
