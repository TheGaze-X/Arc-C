using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005193 RID: 20883
	[Token(Token = "0x2005193")]
	public class ExpeditionReturnDialogSingleData : IHotfixable
	{
		// Token: 0x0601EDB1 RID: 126385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB1")]
		[Address(RVA = "0x189ED30", Offset = "0x189D930", VA = "0x18189ED30")]
		public void LoadData(UIRoguelikeExpeditionReturnDialogBase.Options options, PlayerRoguelikeV2.CurrentData.ExpeditionReturn.Char returnChar)
		{
		}

		// Token: 0x0601EDB2 RID: 126386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB2")]
		[Address(RVA = "0x189EF80", Offset = "0x189DB80", VA = "0x18189EF80")]
		public ExpeditionReturnDialogSingleData()
		{
		}

		// Token: 0x04029641 RID: 169537
		[Token(Token = "0x4029641")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04029642 RID: 169538
		[Token(Token = "0x4029642")]
		[FieldOffset(Offset = "0x18")]
		public string instId;

		// Token: 0x04029643 RID: 169539
		[Token(Token = "0x4029643")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x04029644 RID: 169540
		[Token(Token = "0x4029644")]
		[FieldOffset(Offset = "0x28")]
		public string charName;

		// Token: 0x04029645 RID: 169541
		[Token(Token = "0x4029645")]
		[FieldOffset(Offset = "0x30")]
		public bool isUpgrade;

		// Token: 0x04029646 RID: 169542
		[Token(Token = "0x4029646")]
		[FieldOffset(Offset = "0x31")]
		public bool isCandle;

		// Token: 0x04029647 RID: 169543
		[Token(Token = "0x4029647")]
		[FieldOffset(Offset = "0x34")]
		public PlayerRoguelikeV2.CurrentData.Troop.ExpedType expedType;

		// Token: 0x04029648 RID: 169544
		[Token(Token = "0x4029648")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemBundle> rewards;

		// Token: 0x04029649 RID: 169545
		[Token(Token = "0x4029649")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402964A RID: 169546
		[Token(Token = "0x402964A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
