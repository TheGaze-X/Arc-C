using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	internal class NavigationEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x5AE8DF0", Offset = "0x5AE79F0", VA = "0x185AE8DF0", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x5AE8E30", Offset = "0x5AE7A30", VA = "0x185AE8E30", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NavigationEventDispatchingStrategy()
		{
		}
	}
}
