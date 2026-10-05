using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		private event UnityAction Delegate
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x595F5C0", Offset = "0x595E1C0", VA = "0x18595F5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x595F660", Offset = "0x595E260", VA = "0x18595F660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x595F3C0", Offset = "0x595DFC0", VA = "0x18595F3C0")]
		public InvokableCall(object target, MethodInfo theFunction)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x595F390", Offset = "0x595DF90", VA = "0x18595F390")]
		public InvokableCall(UnityAction action)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x595F350", Offset = "0x595DF50", VA = "0x18595F350", Slot = "4")]
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x595F350", Offset = "0x595DF50", VA = "0x18595F350")]
		public void Invoke()
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x3FD1A80", Offset = "0x3FD0680", VA = "0x183FD1A80", Slot = "5")]
		public override bool Find(object targetObj, MethodInfo method)
		{
			return default(bool);
		}
	}
}
