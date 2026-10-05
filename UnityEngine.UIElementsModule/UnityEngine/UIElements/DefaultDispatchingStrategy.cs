using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	internal class DefaultDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5AD7F70", Offset = "0x5AD6B70", VA = "0x185AD7F70", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5AD8000", Offset = "0x5AD6C00", VA = "0x185AD8000", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultDispatchingStrategy()
		{
		}
	}
}
