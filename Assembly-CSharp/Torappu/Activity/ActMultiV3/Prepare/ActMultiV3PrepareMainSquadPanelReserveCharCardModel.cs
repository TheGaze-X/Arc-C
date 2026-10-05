using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007077 RID: 28791
	[Token(Token = "0x2007077")]
	public class ActMultiV3PrepareMainSquadPanelReserveCharCardModel : IHotfixable
	{
		// Token: 0x06028E3C RID: 167484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E3C")]
		[Address(RVA = "0x245AD70", Offset = "0x2459970", VA = "0x18245AD70")]
		public ActMultiV3PrepareMainSquadPanelReserveCharCardModel()
		{
		}

		// Token: 0x0403A53B RID: 238907
		[Token(Token = "0x403A53B")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3PrepareMainSmallCharCardModel cardModel;

		// Token: 0x0403A53C RID: 238908
		[Token(Token = "0x403A53C")]
		[FieldOffset(Offset = "0x18")]
		public bool visible;

		// Token: 0x0403A53D RID: 238909
		[Token(Token = "0x403A53D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
