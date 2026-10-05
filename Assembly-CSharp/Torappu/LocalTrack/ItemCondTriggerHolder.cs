using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200208D RID: 8333
	[Token(Token = "0x200208D")]
	public class ItemCondTriggerHolder : PlayerTrackTriggerHolder<ItemCondTrigger>
	{
		// Token: 0x0600CD59 RID: 52569 RVA: 0x0004A058 File Offset: 0x00048258
		[Token(Token = "0x600CD59")]
		[Address(RVA = "0x3503470", Offset = "0x3502070", VA = "0x183503470", Slot = "10")]
		protected override bool CheckIfToTrigger(ItemCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD5A")]
		[Address(RVA = "0x3503540", Offset = "0x3502140", VA = "0x183503540", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x0004A070 File Offset: 0x00048270
		[Token(Token = "0x600CD5B")]
		[Address(RVA = "0x3503610", Offset = "0x3502210", VA = "0x183503610")]
		private bool _CheckIfItemCountSatisfied(string itemId, int targetCount, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD5C")]
		[Address(RVA = "0x35036F0", Offset = "0x35022F0", VA = "0x1835036F0")]
		public ItemCondTriggerHolder()
		{
		}

		// Token: 0x0400D8A7 RID: 55463
		[Token(Token = "0x400D8A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D8A8 RID: 55464
		[Token(Token = "0x400D8A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D8A9 RID: 55465
		[Token(Token = "0x400D8A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfItemCountSatisfied;

		// Token: 0x0400D8AA RID: 55466
		[Token(Token = "0x400D8AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
