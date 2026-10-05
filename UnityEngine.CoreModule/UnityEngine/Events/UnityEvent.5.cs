using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[Serializable]
	public class UnityEvent<T0, T1, T2, T3> : UnityEventBase
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CED")]
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEE")]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return null;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CEF")]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return null;
		}

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
