using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044E1 RID: 17633
	[Token(Token = "0x20044E1")]
	public class RoguelikeTopicMonthSquadRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AEC7 RID: 110279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC7")]
		[Address(RVA = "0x1412700", Offset = "0x1411300", VA = "0x181412700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AEC8 RID: 110280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC8")]
		[Address(RVA = "0x14122B0", Offset = "0x1410EB0", VA = "0x1814122B0")]
		public void Render(RoguelikeTopicMonthSquadRewardView.Input input)
		{
		}

		// Token: 0x0601AEC9 RID: 110281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC9")]
		[Address(RVA = "0x1412830", Offset = "0x1411430", VA = "0x181412830")]
		private void _RenderTopic(string topicId, RoguelikeTopicMonthSquadRewardView.Input input)
		{
		}

		// Token: 0x0601AECA RID: 110282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AECA")]
		[Address(RVA = "0x1412AF0", Offset = "0x14116F0", VA = "0x181412AF0")]
		public RoguelikeTopicMonthSquadRewardView()
		{
		}

		// Token: 0x0402285D RID: 141405
		[Token(Token = "0x402285D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0402285E RID: 141406
		[Token(Token = "0x402285E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textBpPointCount;

		// Token: 0x0402285F RID: 141407
		[Token(Token = "0x402285F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconBpPoint;

		// Token: 0x04022860 RID: 141408
		[Token(Token = "0x4022860")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgReceivedLight;

		// Token: 0x04022861 RID: 141409
		[Token(Token = "0x4022861")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBpCountBg;

		// Token: 0x04022862 RID: 141410
		[Token(Token = "0x4022862")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textReceiveBpDesc;

		// Token: 0x04022863 RID: 141411
		[Token(Token = "0x4022863")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBpMax;

		// Token: 0x04022864 RID: 141412
		[Token(Token = "0x4022864")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _fullPart;

		// Token: 0x04022865 RID: 141413
		[Token(Token = "0x4022865")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x04022866 RID: 141414
		[Token(Token = "0x4022866")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasBp;

		// Token: 0x04022867 RID: 141415
		[Token(Token = "0x4022867")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasItems;

		// Token: 0x04022868 RID: 141416
		[Token(Token = "0x4022868")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlAwardReceived;

		// Token: 0x04022869 RID: 141417
		[Token(Token = "0x4022869")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicMonthSquadRewardView.Adapter m_listAdapter;

		// Token: 0x0402286A RID: 141418
		[Token(Token = "0x402286A")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicMonthSquadRewardView.Input m_cachedInput;

		// Token: 0x0402286B RID: 141419
		[Token(Token = "0x402286B")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedTopicId;

		// Token: 0x0402286C RID: 141420
		[Token(Token = "0x402286C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0402286D RID: 141421
		[Token(Token = "0x402286D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402286E RID: 141422
		[Token(Token = "0x402286E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402286F RID: 141423
		[Token(Token = "0x402286F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTopic;

		// Token: 0x04022870 RID: 141424
		[Token(Token = "0x4022870")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044E2 RID: 17634
		[Token(Token = "0x20044E2")]
		public class Input
		{
			// Token: 0x0601AECB RID: 110283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AECB")]
			[Address(RVA = "0x1401AE0", Offset = "0x14006E0", VA = "0x181401AE0")]
			public Input()
			{
			}

			// Token: 0x04022871 RID: 141425
			[Token(Token = "0x4022871")]
			[FieldOffset(Offset = "0x10")]
			public bool showAwardReceived;

			// Token: 0x04022872 RID: 141426
			[Token(Token = "0x4022872")]
			[FieldOffset(Offset = "0x11")]
			public bool showBpMax;

			// Token: 0x04022873 RID: 141427
			[Token(Token = "0x4022873")]
			[FieldOffset(Offset = "0x12")]
			public bool bpAlreadyMax;

			// Token: 0x04022874 RID: 141428
			[Token(Token = "0x4022874")]
			[FieldOffset(Offset = "0x13")]
			public bool showFullStored;

			// Token: 0x04022875 RID: 141429
			[Token(Token = "0x4022875")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;

			// Token: 0x04022876 RID: 141430
			[Token(Token = "0x4022876")]
			[FieldOffset(Offset = "0x20")]
			public int bpPointCount;

			// Token: 0x04022877 RID: 141431
			[Token(Token = "0x4022877")]
			[FieldOffset(Offset = "0x28")]
			public List<ItemBundle> rewardItems;

			// Token: 0x04022878 RID: 141432
			[Token(Token = "0x4022878")]
			[FieldOffset(Offset = "0x30")]
			public Color colorTheme;

			// Token: 0x04022879 RID: 141433
			[Token(Token = "0x4022879")]
			[FieldOffset(Offset = "0x40")]
			public bool enableDropRoute;
		}

		// Token: 0x020044E3 RID: 17635
		[Token(Token = "0x20044E3")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AECC RID: 110284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AECC")]
			[Address(RVA = "0x1401120", Offset = "0x13FFD20", VA = "0x181401120")]
			public Adapter(RoguelikeTopicMonthSquadRewardView closure)
			{
			}

			// Token: 0x17003FE2 RID: 16354
			// (get) Token: 0x0601AECD RID: 110285 RVA: 0x000A3998 File Offset: 0x000A1B98
			[Token(Token = "0x17003FE2")]
			public override int count
			{
				[Token(Token = "0x601AECD")]
				[Address(RVA = "0x1401210", Offset = "0x13FFE10", VA = "0x181401210", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AECE RID: 110286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AECE")]
			[Address(RVA = "0x1400CC0", Offset = "0x13FF8C0", VA = "0x181400CC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402287A RID: 141434
			[Token(Token = "0x402287A")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicMonthSquadRewardView m_closure;

			// Token: 0x0402287B RID: 141435
			[Token(Token = "0x402287B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402287C RID: 141436
			[Token(Token = "0x402287C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402287D RID: 141437
			[Token(Token = "0x402287D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
