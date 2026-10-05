using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005800 RID: 22528
	[Token(Token = "0x2005800")]
	public class RL03FocusForesightPlugin : RoguelikeFocusPlugin
	{
		// Token: 0x06020EDC RID: 134876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EDC")]
		[Address(RVA = "0x1B31CE0", Offset = "0x1B308E0", VA = "0x181B31CE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020EDD RID: 134877 RVA: 0x000B7D98 File Offset: 0x000B5F98
		[Token(Token = "0x6020EDD")]
		[Address(RVA = "0x1B31780", Offset = "0x1B30380", VA = "0x181B31780", Slot = "4")]
		public override bool Render(RoguelikeFocusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06020EDE RID: 134878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EDE")]
		[Address(RVA = "0x1B32690", Offset = "0x1B31290", VA = "0x181B32690")]
		private void _RenderHidePart(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x06020EDF RID: 134879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EDF")]
		[Address(RVA = "0x1B32320", Offset = "0x1B30F20", VA = "0x181B32320")]
		private void _RenderDetailPart(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x06020EE0 RID: 134880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE0")]
		[Address(RVA = "0x1B32050", Offset = "0x1B30C50", VA = "0x181B32050")]
		private void _RenderBattleDetailPart(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x06020EE1 RID: 134881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE1")]
		[Address(RVA = "0x1B32B10", Offset = "0x1B31710", VA = "0x181B32B10")]
		private void _RenderShopOrGiftPart(string topicId, List<string> itemList)
		{
		}

		// Token: 0x06020EE2 RID: 134882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE2")]
		[Address(RVA = "0x1B32D20", Offset = "0x1B31920", VA = "0x181B32D20")]
		private void _RenderText(string detailText)
		{
		}

		// Token: 0x06020EE3 RID: 134883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE3")]
		[Address(RVA = "0x1B31700", Offset = "0x1B30300", VA = "0x181B31700")]
		public void OpenTotemDetail()
		{
		}

		// Token: 0x06020EE4 RID: 134884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE4")]
		[Address(RVA = "0x1B31200", Offset = "0x1B2FE00", VA = "0x181B31200")]
		public void CloseTotemDetail()
		{
		}

		// Token: 0x06020EE5 RID: 134885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE5")]
		[Address(RVA = "0x1B31EC0", Offset = "0x1B30AC0", VA = "0x181B31EC0")]
		private void _LoadRewardItemViewPluginIfNecessary(string topicId)
		{
		}

		// Token: 0x06020EE6 RID: 134886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE6")]
		[Address(RVA = "0x1B312F0", Offset = "0x1B2FEF0", VA = "0x181B312F0")]
		public void OpenItemForesightPlugin(string topicId, List<string> totemList, string paramText, bool showOr)
		{
		}

		// Token: 0x06020EE7 RID: 134887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE7")]
		[Address(RVA = "0x1B31280", Offset = "0x1B2FE80", VA = "0x181B31280")]
		public void OnClick()
		{
		}

		// Token: 0x06020EE8 RID: 134888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EE8")]
		[Address(RVA = "0x1B32E60", Offset = "0x1B31A60", VA = "0x181B32E60")]
		public RL03FocusForesightPlugin()
		{
		}

		// Token: 0x0402CC4B RID: 183371
		[Token(Token = "0x402CC4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _detailPart;

		// Token: 0x0402CC4C RID: 183372
		[Token(Token = "0x402CC4C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _atlasIcon;

		// Token: 0x0402CC4D RID: 183373
		[Token(Token = "0x402CC4D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402CC4E RID: 183374
		[Token(Token = "0x402CC4E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _textPart;

		// Token: 0x0402CC4F RID: 183375
		[Token(Token = "0x402CC4F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x0402CC50 RID: 183376
		[Token(Token = "0x402CC50")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _listPart;

		// Token: 0x0402CC51 RID: 183377
		[Token(Token = "0x402CC51")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x0402CC52 RID: 183378
		[Token(Token = "0x402CC52")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _clickbutton;

		// Token: 0x0402CC53 RID: 183379
		[Token(Token = "0x402CC53")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _shiningLight;

		// Token: 0x0402CC54 RID: 183380
		[Token(Token = "0x402CC54")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _attachDetailPanel;

		// Token: 0x0402CC55 RID: 183381
		[Token(Token = "0x402CC55")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _attachIcon;

		// Token: 0x0402CC56 RID: 183382
		[Token(Token = "0x402CC56")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _detailTextPart;

		// Token: 0x0402CC57 RID: 183383
		[Token(Token = "0x402CC57")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _totemMorePart;

		// Token: 0x0402CC58 RID: 183384
		[Token(Token = "0x402CC58")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL03DetailItemView _itemView;

		// Token: 0x0402CC59 RID: 183385
		[Token(Token = "0x402CC59")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _totemButtonCont;

		// Token: 0x0402CC5A RID: 183386
		[Token(Token = "0x402CC5A")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action onClick;

		// Token: 0x0402CC5B RID: 183387
		[Token(Token = "0x402CC5B")]
		[FieldOffset(Offset = "0xA8")]
		private RL03FocusForesightPlugin.Adapter m_adapter;

		// Token: 0x0402CC5C RID: 183388
		[Token(Token = "0x402CC5C")]
		[FieldOffset(Offset = "0xB0")]
		private RL03TotemEffectAdapter m_descAdapter;

		// Token: 0x0402CC5D RID: 183389
		[Token(Token = "0x402CC5D")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x0402CC5E RID: 183390
		[Token(Token = "0x402CC5E")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_detailFade;

		// Token: 0x0402CC5F RID: 183391
		[Token(Token = "0x402CC5F")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_finder;

		// Token: 0x0402CC60 RID: 183392
		[Token(Token = "0x402CC60")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeRewardExtraInfoFactory m_foresightRewardExtraInfoFactory;

		// Token: 0x0402CC61 RID: 183393
		[Token(Token = "0x402CC61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CC62 RID: 183394
		[Token(Token = "0x402CC62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CC63 RID: 183395
		[Token(Token = "0x402CC63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderHidePart;

		// Token: 0x0402CC64 RID: 183396
		[Token(Token = "0x402CC64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDetailPart;

		// Token: 0x0402CC65 RID: 183397
		[Token(Token = "0x402CC65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBattleDetailPart;

		// Token: 0x0402CC66 RID: 183398
		[Token(Token = "0x402CC66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderShopOrGiftPart;

		// Token: 0x0402CC67 RID: 183399
		[Token(Token = "0x402CC67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderText;

		// Token: 0x0402CC68 RID: 183400
		[Token(Token = "0x402CC68")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenTotemDetail;

		// Token: 0x0402CC69 RID: 183401
		[Token(Token = "0x402CC69")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CloseTotemDetail;

		// Token: 0x0402CC6A RID: 183402
		[Token(Token = "0x402CC6A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadRewardItemViewPluginIfNecessary;

		// Token: 0x0402CC6B RID: 183403
		[Token(Token = "0x402CC6B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OpenItemForesightPlugin;

		// Token: 0x0402CC6C RID: 183404
		[Token(Token = "0x402CC6C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402CC6D RID: 183405
		[Token(Token = "0x402CC6D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005801 RID: 22529
		[Token(Token = "0x2005801")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004D51 RID: 19793
			// (get) Token: 0x06020EE9 RID: 134889 RVA: 0x000B7DB0 File Offset: 0x000B5FB0
			[Token(Token = "0x17004D51")]
			public override int count
			{
				[Token(Token = "0x6020EE9")]
				[Address(RVA = "0x1B2E640", Offset = "0x1B2D240", VA = "0x181B2E640", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020EEA RID: 134890 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020EEA")]
			[Address(RVA = "0x1B2E020", Offset = "0x1B2CC20", VA = "0x181B2E020", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020EEB RID: 134891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020EEB")]
			[Address(RVA = "0x1B2E570", Offset = "0x1B2D170", VA = "0x181B2E570")]
			public Adapter()
			{
			}

			// Token: 0x0402CC6E RID: 183406
			[Token(Token = "0x402CC6E")]
			[FieldOffset(Offset = "0x20")]
			private int ITEM_COUNT;

			// Token: 0x0402CC6F RID: 183407
			[Token(Token = "0x402CC6F")]
			[FieldOffset(Offset = "0x24")]
			public bool isTotem;

			// Token: 0x0402CC70 RID: 183408
			[Token(Token = "0x402CC70")]
			[FieldOffset(Offset = "0x28")]
			public List<RL03TotemViewModel> totemList;

			// Token: 0x0402CC71 RID: 183409
			[Token(Token = "0x402CC71")]
			[FieldOffset(Offset = "0x30")]
			public List<string> itemList;

			// Token: 0x0402CC72 RID: 183410
			[Token(Token = "0x402CC72")]
			[FieldOffset(Offset = "0x38")]
			public string topicId;

			// Token: 0x0402CC73 RID: 183411
			[Token(Token = "0x402CC73")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402CC74 RID: 183412
			[Token(Token = "0x402CC74")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402CC75 RID: 183413
			[Token(Token = "0x402CC75")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
