using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200208B RID: 8331
	[Token(Token = "0x200208B")]
	public class FurnitureAcquireCondTriggerHolder : PlayerTrackTriggerHolder<FurnitureAcquireCondTrigger>
	{
		// Token: 0x0600CD53 RID: 52563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD53")]
		[Address(RVA = "0x34FF540", Offset = "0x34FE140", VA = "0x1834FF540", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD54 RID: 52564 RVA: 0x0004A028 File Offset: 0x00048228
		[Token(Token = "0x600CD54")]
		[Address(RVA = "0x34FF630", Offset = "0x34FE230", VA = "0x1834FF630")]
		private int _GetFurnitureCount(string furnitureId, PlayerDataModel data)
		{
			return 0;
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x0004A040 File Offset: 0x00048240
		[Token(Token = "0x600CD55")]
		[Address(RVA = "0x34FF470", Offset = "0x34FE070", VA = "0x1834FF470", Slot = "10")]
		protected override bool CheckIfToTrigger(FurnitureAcquireCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD56 RID: 52566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD56")]
		[Address(RVA = "0x34FF710", Offset = "0x34FE310", VA = "0x1834FF710")]
		public FurnitureAcquireCondTriggerHolder()
		{
		}

		// Token: 0x0400D89F RID: 55455
		[Token(Token = "0x400D89F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D8A0 RID: 55456
		[Token(Token = "0x400D8A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetFurnitureCount;

		// Token: 0x0400D8A1 RID: 55457
		[Token(Token = "0x400D8A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D8A2 RID: 55458
		[Token(Token = "0x400D8A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
