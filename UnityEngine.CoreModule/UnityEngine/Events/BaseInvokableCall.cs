using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	internal abstract class BaseInvokableCall
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BaseInvokableCall()
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x5958E40", Offset = "0x5957A40", VA = "0x185958E40")]
		protected BaseInvokableCall(object target, MethodInfo function)
		{
		}

		// Token: 0x06000C7F RID: 3199
		[Token(Token = "0x6000C7F")]
		public abstract void Invoke(object[] args);

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		protected static void ThrowOnInvalidArg<T>(object arg)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5958CD0", Offset = "0x59578D0", VA = "0x185958CD0")]
		protected static bool AllowInvoke(Delegate @delegate)
		{
			return default(bool);
		}

		// Token: 0x06000C82 RID: 3202
		[Token(Token = "0x6000C82")]
		public abstract bool Find(object targetObj, MethodInfo method);
	}
}
