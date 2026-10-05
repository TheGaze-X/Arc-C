using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207A RID: 8314
	[Token(Token = "0x200207A")]
	public class CarCondTriggerHolder : PlayerTrackTriggerHolder<CarCondTrigger>
	{
		// Token: 0x0600CD20 RID: 52512 RVA: 0x00049ED8 File Offset: 0x000480D8
		[Token(Token = "0x600CD20")]
		[Address(RVA = "0x34FBA50", Offset = "0x34FA650", VA = "0x1834FBA50", Slot = "10")]
		protected override bool CheckIfToTrigger(CarCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD21 RID: 52513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD21")]
		[Address(RVA = "0x34FBB10", Offset = "0x34FA710", VA = "0x1834FBB10", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x00049EF0 File Offset: 0x000480F0
		[Token(Token = "0x600CD22")]
		[Address(RVA = "0x34FBC00", Offset = "0x34FA800", VA = "0x1834FBC00")]
		private bool _CheckIfCarCompCountSatisfied(string compId, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD23")]
		[Address(RVA = "0x34FBCF0", Offset = "0x34FA8F0", VA = "0x1834FBCF0")]
		public CarCondTriggerHolder()
		{
		}

		// Token: 0x0400D860 RID: 55392
		[Token(Token = "0x400D860")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D861 RID: 55393
		[Token(Token = "0x400D861")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D862 RID: 55394
		[Token(Token = "0x400D862")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfCarCompCountSatisfied;

		// Token: 0x0400D863 RID: 55395
		[Token(Token = "0x400D863")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
