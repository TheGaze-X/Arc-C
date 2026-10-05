using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD7 RID: 7639
	[Token(Token = "0x2001DD7")]
	public class PowerRoomViewModel : IHotfixable
	{
		// Token: 0x0600BC6E RID: 48238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6E")]
		[Address(RVA = "0x33984E0", Offset = "0x33970E0", VA = "0x1833984E0")]
		public void LoadData(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600BC6F RID: 48239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6F")]
		[Address(RVA = "0x33986B0", Offset = "0x33972B0", VA = "0x1833986B0")]
		public PowerRoomViewModel()
		{
		}

		// Token: 0x0400BC7A RID: 48250
		[Token(Token = "0x400BC7A")]
		[FieldOffset(Offset = "0x10")]
		public int totalPower;

		// Token: 0x0400BC7B RID: 48251
		[Token(Token = "0x400BC7B")]
		[FieldOffset(Offset = "0x14")]
		public int providedPower;

		// Token: 0x0400BC7C RID: 48252
		[Token(Token = "0x400BC7C")]
		[FieldOffset(Offset = "0x18")]
		public float baseBuffSpeed;

		// Token: 0x0400BC7D RID: 48253
		[Token(Token = "0x400BC7D")]
		[FieldOffset(Offset = "0x1C")]
		public float specBuffSpeed;

		// Token: 0x0400BC7E RID: 48254
		[Token(Token = "0x400BC7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400BC7F RID: 48255
		[Token(Token = "0x400BC7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
