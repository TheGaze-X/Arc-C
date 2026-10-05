using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	[Serializable]
	public class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		public void AddListener(UnityAction<T0, T1> call)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		public void RemoveListener(UnityAction<T0, T1> call)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE1")]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE2")]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return null;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE3")]
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action)
		{
			return null;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE4")]
		public void Invoke(T0 arg0, T1 arg1)
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
