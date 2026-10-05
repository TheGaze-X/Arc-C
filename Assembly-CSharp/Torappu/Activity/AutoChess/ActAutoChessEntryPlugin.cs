using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070EF RID: 28911
	[Token(Token = "0x20070EF")]
	public class ActAutoChessEntryPlugin : TemplateActivityCommonPlugin, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x0602918F RID: 168335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602918F")]
		[Address(RVA = "0x2480BB0", Offset = "0x247F7B0", VA = "0x182480BB0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029190 RID: 168336 RVA: 0x000D4760 File Offset: 0x000D2960
		[Token(Token = "0x6029190")]
		[Address(RVA = "0x24804B0", Offset = "0x247F0B0", VA = "0x1824804B0", Slot = "6")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x06029191 RID: 168337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029191")]
		[Address(RVA = "0x24810C0", Offset = "0x247FCC0", VA = "0x1824810C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029192 RID: 168338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029192")]
		[Address(RVA = "0x2480FA0", Offset = "0x247FBA0", VA = "0x182480FA0")]
		private ActAutoChessEntryViewModel _GetActViewModel()
		{
			return null;
		}

		// Token: 0x06029193 RID: 168339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029193")]
		[Address(RVA = "0x24809D0", Offset = "0x247F5D0", VA = "0x1824809D0")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x06029194 RID: 168340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029194")]
		[Address(RVA = "0x2480770", Offset = "0x247F370", VA = "0x182480770")]
		public void EventOnHandbookClicked()
		{
		}

		// Token: 0x06029195 RID: 168341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029195")]
		[Address(RVA = "0x2480640", Offset = "0x247F240", VA = "0x182480640")]
		public void EventOnDailyMissionClicked()
		{
		}

		// Token: 0x06029196 RID: 168342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029196")]
		[Address(RVA = "0x24808A0", Offset = "0x247F4A0", VA = "0x1824808A0")]
		public void EventOnRewardClicked()
		{
		}

		// Token: 0x06029197 RID: 168343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029197")]
		[Address(RVA = "0x2480570", Offset = "0x247F170", VA = "0x182480570")]
		public void EventOnAchievementClicked()
		{
		}

		// Token: 0x06029198 RID: 168344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029198")]
		[Address(RVA = "0x24811B0", Offset = "0x247FDB0", VA = "0x1824811B0")]
		public ActAutoChessEntryPlugin()
		{
		}

		// Token: 0x0403AA82 RID: 240258
		[Token(Token = "0x403AA82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _shopBlockedVariant;

		// Token: 0x0403AA83 RID: 240259
		[Token(Token = "0x403AA83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _shopClosedVariant;

		// Token: 0x0403AA84 RID: 240260
		[Token(Token = "0x403AA84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _handbookClosedVariant;

		// Token: 0x0403AA85 RID: 240261
		[Token(Token = "0x403AA85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rewardClosedVariant;

		// Token: 0x0403AA86 RID: 240262
		[Token(Token = "0x403AA86")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIActTrackPoint _trackShop;

		// Token: 0x0403AA87 RID: 240263
		[Token(Token = "0x403AA87")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIActTrackPoint _trackHandbook;

		// Token: 0x0403AA88 RID: 240264
		[Token(Token = "0x403AA88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelDailyMissionComplete;

		// Token: 0x0403AA89 RID: 240265
		[Token(Token = "0x403AA89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _sliderDaily;

		// Token: 0x0403AA8A RID: 240266
		[Token(Token = "0x403AA8A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgMedal;

		// Token: 0x0403AA8B RID: 240267
		[Token(Token = "0x403AA8B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textMedalCount;

		// Token: 0x0403AA8C RID: 240268
		[Token(Token = "0x403AA8C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _alertRaycastTarget;

		// Token: 0x0403AA8D RID: 240269
		[Token(Token = "0x403AA8D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403AA8E RID: 240270
		[Token(Token = "0x403AA8E")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403AA8F RID: 240271
		[Token(Token = "0x403AA8F")]
		[FieldOffset(Offset = "0x98")]
		private ILoadAsset m_loader;

		// Token: 0x0403AA90 RID: 240272
		[Token(Token = "0x403AA90")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_shopTrack;

		// Token: 0x0403AA91 RID: 240273
		[Token(Token = "0x403AA91")]
		[FieldOffset(Offset = "0xA8")]
		private TrackPointViewProperty m_handBookTrack;

		// Token: 0x0403AA92 RID: 240274
		[Token(Token = "0x403AA92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403AA93 RID: 240275
		[Token(Token = "0x403AA93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x0403AA94 RID: 240276
		[Token(Token = "0x403AA94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AA95 RID: 240277
		[Token(Token = "0x403AA95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetActViewModel;

		// Token: 0x0403AA96 RID: 240278
		[Token(Token = "0x403AA96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x0403AA97 RID: 240279
		[Token(Token = "0x403AA97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnHandbookClicked;

		// Token: 0x0403AA98 RID: 240280
		[Token(Token = "0x403AA98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnDailyMissionClicked;

		// Token: 0x0403AA99 RID: 240281
		[Token(Token = "0x403AA99")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnRewardClicked;

		// Token: 0x0403AA9A RID: 240282
		[Token(Token = "0x403AA9A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnAchievementClicked;

		// Token: 0x0403AA9B RID: 240283
		[Token(Token = "0x403AA9B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070F0 RID: 28912
		[Token(Token = "0x20070F0")]
		private struct TrackInput
		{
			// Token: 0x0403AA9C RID: 240284
			[Token(Token = "0x403AA9C")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0403AA9D RID: 240285
			[Token(Token = "0x403AA9D")]
			[FieldOffset(Offset = "0x8")]
			public bool forceHide;
		}

		// Token: 0x020070F1 RID: 28913
		[Token(Token = "0x20070F1")]
		private class ShopTrackModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700615F RID: 24927
			// (get) Token: 0x06029199 RID: 168345 RVA: 0x000D4778 File Offset: 0x000D2978
			// (set) Token: 0x0602919A RID: 168346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700615F")]
			public bool isShow
			{
				[Token(Token = "0x6029199")]
				[Address(RVA = "0x2490D00", Offset = "0x248F900", VA = "0x182490D00", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602919A")]
				[Address(RVA = "0x2490D60", Offset = "0x248F960", VA = "0x182490D60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602919B RID: 168347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602919B")]
			[Address(RVA = "0x2490B60", Offset = "0x248F760", VA = "0x182490B60", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602919C RID: 168348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602919C")]
			[Address(RVA = "0x2490CA0", Offset = "0x248F8A0", VA = "0x182490CA0")]
			public ShopTrackModel()
			{
			}

			// Token: 0x0403AA9F RID: 240287
			[Token(Token = "0x403AA9F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AAA0 RID: 240288
			[Token(Token = "0x403AAA0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AAA1 RID: 240289
			[Token(Token = "0x403AAA1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AAA2 RID: 240290
			[Token(Token = "0x403AAA2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020070F2 RID: 28914
		[Token(Token = "0x20070F2")]
		private class HandbookTrackModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17006160 RID: 24928
			// (get) Token: 0x0602919D RID: 168349 RVA: 0x000D4790 File Offset: 0x000D2990
			// (set) Token: 0x0602919E RID: 168350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006160")]
			public bool isShow
			{
				[Token(Token = "0x602919D")]
				[Address(RVA = "0x24901C0", Offset = "0x248EDC0", VA = "0x1824901C0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602919E")]
				[Address(RVA = "0x2490220", Offset = "0x248EE20", VA = "0x182490220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602919F RID: 168351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602919F")]
			[Address(RVA = "0x248FE30", Offset = "0x248EA30", VA = "0x18248FE30", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060291A0 RID: 168352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60291A0")]
			[Address(RVA = "0x2490160", Offset = "0x248ED60", VA = "0x182490160")]
			public HandbookTrackModel()
			{
			}

			// Token: 0x0403AAA4 RID: 240292
			[Token(Token = "0x403AAA4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AAA5 RID: 240293
			[Token(Token = "0x403AAA5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AAA6 RID: 240294
			[Token(Token = "0x403AAA6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AAA7 RID: 240295
			[Token(Token = "0x403AAA7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
