using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Float;
using Torappu.Building.UI.Trading;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CB0 RID: 7344
	[Token(Token = "0x2001CB0")]
	public class SelectedRoomDetailViewModel
	{
		// Token: 0x0600B5F6 RID: 46582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SelectedRoomDetailViewModel()
		{
		}

		// Token: 0x0400B2B1 RID: 45745
		[Token(Token = "0x400B2B1")]
		[FieldOffset(Offset = "0x10")]
		public ManufactInfoViewModel manuModel;

		// Token: 0x0400B2B2 RID: 45746
		[Token(Token = "0x400B2B2")]
		[FieldOffset(Offset = "0x18")]
		public ControlRoomViewModel controlModel;

		// Token: 0x0400B2B3 RID: 45747
		[Token(Token = "0x400B2B3")]
		[FieldOffset(Offset = "0x20")]
		public PowerRoomViewModel powerModel;

		// Token: 0x0400B2B4 RID: 45748
		[Token(Token = "0x400B2B4")]
		[FieldOffset(Offset = "0x28")]
		public TRoomViewModel tradingModel;
	}
}
