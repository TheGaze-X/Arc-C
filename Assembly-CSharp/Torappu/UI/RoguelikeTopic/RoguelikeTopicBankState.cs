using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200447D RID: 17533
	[Token(Token = "0x200447D")]
	public class RoguelikeTopicBankState : PopupFadeState
	{
		// Token: 0x0601ACA3 RID: 109731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACA3")]
		[Address(RVA = "0x13F1390", Offset = "0x13EFF90", VA = "0x1813F1390", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ACA4 RID: 109732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACA4")]
		[Address(RVA = "0x13F13F0", Offset = "0x13EFFF0", VA = "0x1813F13F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ACA5 RID: 109733 RVA: 0x000A35F0 File Offset: 0x000A17F0
		[Token(Token = "0x601ACA5")]
		[Address(RVA = "0x13F1780", Offset = "0x13F0380", VA = "0x1813F1780")]
		private int _GetDeposit()
		{
			return 0;
		}

		// Token: 0x0601ACA6 RID: 109734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACA6")]
		[Address(RVA = "0x13F17F0", Offset = "0x13F03F0", VA = "0x1813F17F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACA7 RID: 109735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACA7")]
		[Address(RVA = "0x13F1940", Offset = "0x13F0540", VA = "0x1813F1940")]
		private void _UpdateNpcDialog(RoguelikeGameShopDialogType dialogType)
		{
		}

		// Token: 0x0601ACA8 RID: 109736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACA8")]
		[Address(RVA = "0x13F1A10", Offset = "0x13F0610", VA = "0x1813F1A10")]
		public RoguelikeTopicBankState()
		{
		}

		// Token: 0x0601ACA9 RID: 109737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACA9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402242F RID: 140335
		[Token(Token = "0x402242F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rewardViewParent;

		// Token: 0x04022430 RID: 140336
		[Token(Token = "0x4022430")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeTopicBankRewardView _rewardViewPrefab;

		// Token: 0x04022431 RID: 140337
		[Token(Token = "0x4022431")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeNpcDialogView _dialogView;

		// Token: 0x04022432 RID: 140338
		[Token(Token = "0x4022432")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDeposit;

		// Token: 0x04022433 RID: 140339
		[Token(Token = "0x4022433")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04022434 RID: 140340
		[Token(Token = "0x4022434")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeTopicBankRewardView m_rewardView;

		// Token: 0x04022435 RID: 140341
		[Token(Token = "0x4022435")]
		[FieldOffset(Offset = "0xA0")]
		private string m_topicId;

		// Token: 0x04022436 RID: 140342
		[Token(Token = "0x4022436")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeGameShopDialogProp m_dialogProp;

		// Token: 0x04022437 RID: 140343
		[Token(Token = "0x4022437")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022438 RID: 140344
		[Token(Token = "0x4022438")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022439 RID: 140345
		[Token(Token = "0x4022439")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetDeposit;

		// Token: 0x0402243A RID: 140346
		[Token(Token = "0x402243A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402243B RID: 140347
		[Token(Token = "0x402243B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateNpcDialog;

		// Token: 0x0402243C RID: 140348
		[Token(Token = "0x402243C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
