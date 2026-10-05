using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007424 RID: 29732
	[Token(Token = "0x2007424")]
	public class Act3D0MileStoneViewModel
	{
		// Token: 0x06029F8B RID: 171915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F8B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0MileStoneViewModel()
		{
		}

		// Token: 0x0403C2CB RID: 246475
		[Token(Token = "0x403C2CB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403C2CC RID: 246476
		[Token(Token = "0x403C2CC")]
		[FieldOffset(Offset = "0x18")]
		public Act3D0MileStoneViewModel.State state;

		// Token: 0x0403C2CD RID: 246477
		[Token(Token = "0x403C2CD")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		// Token: 0x0403C2CE RID: 246478
		[Token(Token = "0x403C2CE")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;

		// Token: 0x0403C2CF RID: 246479
		[Token(Token = "0x403C2CF")]
		[FieldOffset(Offset = "0x28")]
		public int orderId;

		// Token: 0x02007425 RID: 29733
		[Token(Token = "0x2007425")]
		public enum State
		{
			// Token: 0x0403C2D1 RID: 246481
			[Token(Token = "0x403C2D1")]
			FINISH,
			// Token: 0x0403C2D2 RID: 246482
			[Token(Token = "0x403C2D2")]
			AVAIL,
			// Token: 0x0403C2D3 RID: 246483
			[Token(Token = "0x403C2D3")]
			NOTAVAIL
		}
	}
}
