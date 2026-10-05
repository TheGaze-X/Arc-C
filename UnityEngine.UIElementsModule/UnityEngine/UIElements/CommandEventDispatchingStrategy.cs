using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	internal class CommandEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x5AD7AF0", Offset = "0x5AD66F0", VA = "0x185AD7AF0", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x5AD7B30", Offset = "0x5AD6730", VA = "0x185AD7B30", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommandEventDispatchingStrategy()
		{
		}
	}
}
