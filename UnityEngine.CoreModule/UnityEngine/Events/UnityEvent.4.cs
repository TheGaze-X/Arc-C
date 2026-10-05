using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE7")]
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE8")]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CE9")]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return null;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEA")]
		public void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
		}

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
