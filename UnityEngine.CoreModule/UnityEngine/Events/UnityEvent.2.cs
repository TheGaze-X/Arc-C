using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD5")]
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD6")]
		public void AddListener(UnityAction<T0> call)
		{
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD7")]
		public void RemoveListener(UnityAction<T0> call)
		{
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CD8")]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return null;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CD9")]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return null;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CDA")]
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			return null;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDB")]
		public void Invoke(T0 arg0)
		{
		}

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
