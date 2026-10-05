using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A50 RID: 10832
	[Token(Token = "0x2002A50")]
	public class ConstructPlaceAnimal : ConstructOp
	{
		// Token: 0x06011FA9 RID: 73641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FA9")]
		[Address(RVA = "0x9FF3F0", Offset = "0x9FDFF0", VA = "0x1809FF3F0", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FAA RID: 73642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FAA")]
		[Address(RVA = "0x9FF4C0", Offset = "0x9FE0C0", VA = "0x1809FF4C0")]
		public ConstructPlaceAnimal()
		{
		}

		// Token: 0x06011FAB RID: 73643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FAB")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144C6 RID: 83142
		[Token(Token = "0x40144C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataNullable;

		// Token: 0x040144C7 RID: 83143
		[Token(Token = "0x40144C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
