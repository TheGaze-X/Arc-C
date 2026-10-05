using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	internal class KeyboardEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x5AE1660", Offset = "0x5AE0260", VA = "0x185AE1660", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x5AE16A0", Offset = "0x5AE02A0", VA = "0x185AE16A0", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeyboardEventDispatchingStrategy()
		{
		}
	}
}
