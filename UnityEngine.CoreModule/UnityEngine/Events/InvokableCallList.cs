using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.Events
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	internal class InvokableCallList
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x595ED20", Offset = "0x595D920", VA = "0x18595ED20")]
		public void AddPersistentInvokableCall(BaseInvokableCall call)
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x595ECC0", Offset = "0x595D8C0", VA = "0x18595ECC0")]
		public void AddListener(BaseInvokableCall call)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x595EFD0", Offset = "0x595DBD0", VA = "0x18595EFD0")]
		public void RemoveListener(object targetObj, MethodInfo method)
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x595EE50", Offset = "0x595DA50", VA = "0x18595EE50")]
		public void Clear()
		{
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x595ED80", Offset = "0x595D980", VA = "0x18595ED80")]
		public void ClearPersistent()
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x595EF20", Offset = "0x595DB20", VA = "0x18595EF20")]
		public List<BaseInvokableCall> PrepareInvoke()
		{
			return null;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x595F260", Offset = "0x595DE60", VA = "0x18595F260")]
		public InvokableCallList()
		{
		}

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<BaseInvokableCall> m_PersistentCalls;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<BaseInvokableCall> m_RuntimeCalls;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x20")]
		private List<BaseInvokableCall> m_ExecutingCalls;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_NeedsUpdate;
	}
}
