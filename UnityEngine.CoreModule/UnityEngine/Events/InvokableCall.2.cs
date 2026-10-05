using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000C8A RID: 3210 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		protected event UnityAction<T1> Delegate
		{
			[Token(Token = "0x6000C8A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C8B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8C")]
		public InvokableCall(object target, MethodInfo theFunction)
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8D")]
		public InvokableCall(UnityAction<T1> action)
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8E")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8F")]
		public virtual void Invoke(T1 args0)
		{
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000C90")]
		public override bool Find(object targetObj, MethodInfo method)
		{
			return default(bool);
		}
	}
}
