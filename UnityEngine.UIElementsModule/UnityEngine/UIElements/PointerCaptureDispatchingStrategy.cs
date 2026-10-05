using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	internal class PointerCaptureDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x5AE9300", Offset = "0x5AE7F00", VA = "0x185AE9300", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x5AE9340", Offset = "0x5AE7F40", VA = "0x185AE9340", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PointerCaptureDispatchingStrategy()
		{
		}
	}
}
