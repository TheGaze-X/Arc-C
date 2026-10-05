using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200447A RID: 17530
	[Token(Token = "0x200447A")]
	public class RoguelikeTopicBankRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AC9E RID: 109726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC9E")]
		[Address(RVA = "0x13F0FB0", Offset = "0x13EFBB0", VA = "0x1813F0FB0")]
		public void Render(string topicId)
		{
		}

		// Token: 0x0601AC9F RID: 109727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC9F")]
		[Address(RVA = "0x13F1330", Offset = "0x13EFF30", VA = "0x1813F1330")]
		public RoguelikeTopicBankRewardView()
		{
		}

		// Token: 0x0402241F RID: 140319
		[Token(Token = "0x402241F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textAccumulatedCount;

		// Token: 0x04022420 RID: 140320
		[Token(Token = "0x4022420")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textAccumulatedCountShadow;

		// Token: 0x04022421 RID: 140321
		[Token(Token = "0x4022421")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RoguelikeTopicBankRewardView.TypePanelConfig> _countTypePanelConfigs;

		// Token: 0x04022422 RID: 140322
		[Token(Token = "0x4022422")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04022423 RID: 140323
		[Token(Token = "0x4022423")]
		[FieldOffset(Offset = "0x38")]
		private string m_topicId;

		// Token: 0x04022424 RID: 140324
		[Token(Token = "0x4022424")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicDetail m_topicData;

		// Token: 0x04022425 RID: 140325
		[Token(Token = "0x4022425")]
		[FieldOffset(Offset = "0x48")]
		private PlayerRoguelikeV2.OuterData.Bank m_outerBankData;

		// Token: 0x04022426 RID: 140326
		[Token(Token = "0x4022426")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicBankRewardView.Adapter m_adapter;

		// Token: 0x04022427 RID: 140327
		[Token(Token = "0x4022427")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022428 RID: 140328
		[Token(Token = "0x4022428")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200447B RID: 17531
		[Token(Token = "0x200447B")]
		[Serializable]
		private struct TypePanelConfig
		{
			// Token: 0x04022429 RID: 140329
			[Token(Token = "0x4022429")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeBankRewardCountType type;

			// Token: 0x0402242A RID: 140330
			[Token(Token = "0x402242A")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}

		// Token: 0x0200447C RID: 17532
		[Token(Token = "0x200447C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601ACA0 RID: 109728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACA0")]
			[Address(RVA = "0x13ED370", Offset = "0x13EBF70", VA = "0x1813ED370")]
			public Adapter(RoguelikeTopicBankRewardView closure)
			{
			}

			// Token: 0x17003FAB RID: 16299
			// (get) Token: 0x0601ACA1 RID: 109729 RVA: 0x000A35D8 File Offset: 0x000A17D8
			[Token(Token = "0x17003FAB")]
			public override int count
			{
				[Token(Token = "0x601ACA1")]
				[Address(RVA = "0x13ED490", Offset = "0x13EC090", VA = "0x1813ED490", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ACA2 RID: 109730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ACA2")]
			[Address(RVA = "0x13ECC50", Offset = "0x13EB850", VA = "0x1813ECC50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402242B RID: 140331
			[Token(Token = "0x402242B")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicBankRewardView m_closure;

			// Token: 0x0402242C RID: 140332
			[Token(Token = "0x402242C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402242D RID: 140333
			[Token(Token = "0x402242D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402242E RID: 140334
			[Token(Token = "0x402242E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
