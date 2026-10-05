using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		protected event UnityAction<T1, T2> Delegate
		{
			[Token(Token = "0x6000C91")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C92")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C93")]
		public InvokableCall(object target, MethodInfo theFunction)
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C94")]
		public InvokableCall(UnityAction<T1, T2> action)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C95")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C96")]
		public void Invoke(T1 args0, T2 args1)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6000C97")]
		public override bool Find(object targetObj, MethodInfo method)
		{
			return default(bool);
		}
	}
}
