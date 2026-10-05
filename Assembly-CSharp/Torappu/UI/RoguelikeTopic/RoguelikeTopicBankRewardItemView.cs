using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004478 RID: 17528
	[Token(Token = "0x2004478")]
	public class RoguelikeTopicBankRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AC9B RID: 109723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC9B")]
		[Address(RVA = "0x13F0A70", Offset = "0x13EF670", VA = "0x1813F0A70")]
		public void Render(int position, int totalCount, RoguelikeTopicBankReward bankRewardData, PlayerRoguelikeV2.OuterData.Bank outerBankData, RoguelikeBankRewardCountType countType)
		{
		}

		// Token: 0x0601AC9C RID: 109724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC9C")]
		[Address(RVA = "0x13F0F50", Offset = "0x13EFB50", VA = "0x1813F0F50")]
		public RoguelikeTopicBankRewardItemView()
		{
		}

		// Token: 0x0402240A RID: 140298
		[Token(Token = "0x402240A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDepositTarget;

		// Token: 0x0402240B RID: 140299
		[Token(Token = "0x402240B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402240C RID: 140300
		[Token(Token = "0x402240C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402240D RID: 140301
		[Token(Token = "0x402240D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgLineUp;

		// Token: 0x0402240E RID: 140302
		[Token(Token = "0x402240E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgLineDown;

		// Token: 0x0402240F RID: 140303
		[Token(Token = "0x402240F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgLock;

		// Token: 0x04022410 RID: 140304
		[Token(Token = "0x4022410")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgUnlock;

		// Token: 0x04022411 RID: 140305
		[Token(Token = "0x4022411")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgComplete;

		// Token: 0x04022412 RID: 140306
		[Token(Token = "0x4022412")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgShadow;

		// Token: 0x04022413 RID: 140307
		[Token(Token = "0x4022413")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _bgActive;

		// Token: 0x04022414 RID: 140308
		[Token(Token = "0x4022414")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _bgInactive;

		// Token: 0x04022415 RID: 140309
		[Token(Token = "0x4022415")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBankRewardItemView.RoguelikeTopicBankRewardStyelConfig _styleConfig;

		// Token: 0x04022416 RID: 140310
		[Token(Token = "0x4022416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022417 RID: 140311
		[Token(Token = "0x4022417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004479 RID: 17529
		[Token(Token = "0x2004479")]
		[Serializable]
		public class RoguelikeTopicBankRewardStyelConfig
		{
			// Token: 0x0601AC9D RID: 109725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeTopicBankRewardStyelConfig()
			{
			}

			// Token: 0x04022418 RID: 140312
			[Token(Token = "0x4022418")]
			[FieldOffset(Offset = "0x10")]
			public Color colorInactiveTextDesc;

			// Token: 0x04022419 RID: 140313
			[Token(Token = "0x4022419")]
			[FieldOffset(Offset = "0x20")]
			public Color colorActiveTextDesc;

			// Token: 0x0402241A RID: 140314
			[Token(Token = "0x402241A")]
			[FieldOffset(Offset = "0x30")]
			public Color colorInactiveLine;

			// Token: 0x0402241B RID: 140315
			[Token(Token = "0x402241B")]
			[FieldOffset(Offset = "0x40")]
			public Color colorActiveLine;

			// Token: 0x0402241C RID: 140316
			[Token(Token = "0x402241C")]
			[FieldOffset(Offset = "0x50")]
			public Sprite spriteWithdrawal;

			// Token: 0x0402241D RID: 140317
			[Token(Token = "0x402241D")]
			[FieldOffset(Offset = "0x58")]
			public Sprite spriteAddShopSlot;

			// Token: 0x0402241E RID: 140318
			[Token(Token = "0x402241E")]
			[FieldOffset(Offset = "0x60")]
			public Sprite spriteRelic;
		}
	}
}
