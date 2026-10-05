using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x44B1420", Offset = "0x44B0020", VA = "0x1844B1420")]
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x5977BD0", Offset = "0x59767D0", VA = "0x185977BD0")]
		public void AddListener(UnityAction call)
		{
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x5978040", Offset = "0x5976C40", VA = "0x185978040")]
		public void RemoveListener(UnityAction call)
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x5977C90", Offset = "0x5976890", VA = "0x185977C90", Slot = "6")]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			return null;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x5977CF0", Offset = "0x59768F0", VA = "0x185977CF0", Slot = "7")]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			return null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x5977D60", Offset = "0x5976960", VA = "0x185977D60")]
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			return null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x5977DD0", Offset = "0x59769D0", VA = "0x185977DD0")]
		public void Invoke()
		{
		}

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x28")]
		private object[] m_InvokeArray;
	}
}
