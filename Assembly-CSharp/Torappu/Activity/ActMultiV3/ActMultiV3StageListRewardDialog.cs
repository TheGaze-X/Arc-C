using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF9 RID: 28665
	[Token(Token = "0x2006FF9")]
	public class ActMultiV3StageListRewardDialog : UICompDialog<ActMultiV3StageListRewardDialog.Options>
	{
		// Token: 0x06028B2F RID: 166703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B2F")]
		[Address(RVA = "0x2410B70", Offset = "0x240F770", VA = "0x182410B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B30 RID: 166704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B30")]
		[Address(RVA = "0x24109A0", Offset = "0x240F5A0", VA = "0x1824109A0", Slot = "18")]
		protected override void OnRender(ActMultiV3StageListRewardDialog.Options input)
		{
		}

		// Token: 0x06028B31 RID: 166705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B31")]
		[Address(RVA = "0x2410CC0", Offset = "0x240F8C0", VA = "0x182410CC0")]
		private void _Render()
		{
		}

		// Token: 0x06028B32 RID: 166706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B32")]
		[Address(RVA = "0x2410940", Offset = "0x240F540", VA = "0x182410940", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06028B33 RID: 166707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B33")]
		[Address(RVA = "0x2410880", Offset = "0x240F480", VA = "0x182410880")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06028B34 RID: 166708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B34")]
		[Address(RVA = "0x2410F70", Offset = "0x240FB70", VA = "0x182410F70")]
		public ActMultiV3StageListRewardDialog()
		{
		}

		// Token: 0x06028B35 RID: 166709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B35")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403A01D RID: 237597
		[Token(Token = "0x403A01D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x0403A01E RID: 237598
		[Token(Token = "0x403A01E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgItemIconSmall;

		// Token: 0x0403A01F RID: 237599
		[Token(Token = "0x403A01F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgSeasonIcon;

		// Token: 0x0403A020 RID: 237600
		[Token(Token = "0x403A020")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ActMultiV3StageListRewardDialog.DiffItem[] _diffItems;

		// Token: 0x0403A021 RID: 237601
		[Token(Token = "0x403A021")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0403A022 RID: 237602
		[Token(Token = "0x403A022")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0403A023 RID: 237603
		[Token(Token = "0x403A023")]
		[FieldOffset(Offset = "0xA0")]
		private ActMultiV3StageListRewardDialog.ViewModel m_viewModel;

		// Token: 0x0403A024 RID: 237604
		[Token(Token = "0x403A024")]
		[FieldOffset(Offset = "0xA8")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0403A025 RID: 237605
		[Token(Token = "0x403A025")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A026 RID: 237606
		[Token(Token = "0x403A026")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A027 RID: 237607
		[Token(Token = "0x403A027")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403A028 RID: 237608
		[Token(Token = "0x403A028")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403A029 RID: 237609
		[Token(Token = "0x403A029")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0403A02A RID: 237610
		[Token(Token = "0x403A02A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FFA RID: 28666
		[Token(Token = "0x2006FFA")]
		public class Options
		{
			// Token: 0x06028B36 RID: 166710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B36")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0403A02B RID: 237611
			[Token(Token = "0x403A02B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02006FFB RID: 28667
		[Token(Token = "0x2006FFB")]
		public class DiffViewModel : IHotfixable
		{
			// Token: 0x06028B37 RID: 166711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B37")]
			[Address(RVA = "0x24194F0", Offset = "0x24180F0", VA = "0x1824194F0")]
			public DiffViewModel()
			{
			}

			// Token: 0x0403A02C RID: 237612
			[Token(Token = "0x403A02C")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapDiffType diffType;

			// Token: 0x0403A02D RID: 237613
			[Token(Token = "0x403A02D")]
			[FieldOffset(Offset = "0x18")]
			public string diffName;

			// Token: 0x0403A02E RID: 237614
			[Token(Token = "0x403A02E")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3StarRewardData> starRewardData;

			// Token: 0x0403A02F RID: 237615
			[Token(Token = "0x403A02F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006FFC RID: 28668
		[Token(Token = "0x2006FFC")]
		public class ViewModel : IHotfixable
		{
			// Token: 0x06028B38 RID: 166712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B38")]
			[Address(RVA = "0x241A870", Offset = "0x2419470", VA = "0x18241A870")]
			public void LoadData(string actId)
			{
			}

			// Token: 0x06028B39 RID: 166713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B39")]
			[Address(RVA = "0x241AD30", Offset = "0x2419930", VA = "0x18241AD30")]
			public ViewModel()
			{
			}

			// Token: 0x0403A030 RID: 237616
			[Token(Token = "0x403A030")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, ActMultiV3StageListRewardDialog.DiffViewModel> diffViewModels;

			// Token: 0x0403A031 RID: 237617
			[Token(Token = "0x403A031")]
			[FieldOffset(Offset = "0x18")]
			public string tokenItemId;

			// Token: 0x0403A032 RID: 237618
			[Token(Token = "0x403A032")]
			[FieldOffset(Offset = "0x20")]
			public string actId;

			// Token: 0x0403A033 RID: 237619
			[Token(Token = "0x403A033")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403A034 RID: 237620
			[Token(Token = "0x403A034")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006FFD RID: 28669
		[Token(Token = "0x2006FFD")]
		[Serializable]
		private class DiffItem : IHotfixable
		{
			// Token: 0x1700601A RID: 24602
			// (get) Token: 0x06028B3A RID: 166714 RVA: 0x000D2B28 File Offset: 0x000D0D28
			[Token(Token = "0x1700601A")]
			public int diffType
			{
				[Token(Token = "0x6028B3A")]
				[Address(RVA = "0x2419490", Offset = "0x2418090", VA = "0x182419490")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028B3B RID: 166715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B3B")]
			[Address(RVA = "0x2419100", Offset = "0x2417D00", VA = "0x182419100")]
			public void Render(string actId, ActMultiV3StageListRewardDialog.DiffViewModel diffViewModel)
			{
			}

			// Token: 0x06028B3C RID: 166716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B3C")]
			[Address(RVA = "0x2419430", Offset = "0x2418030", VA = "0x182419430")]
			public DiffItem()
			{
			}

			// Token: 0x0403A035 RID: 237621
			[Token(Token = "0x403A035")]
			private const string REWARD_COUNT_FORMAT = "+{0}";

			// Token: 0x0403A036 RID: 237622
			[Token(Token = "0x403A036")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ActMultiV3MapDiffType _diffType;

			// Token: 0x0403A037 RID: 237623
			[Token(Token = "0x403A037")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textDiffName;

			// Token: 0x0403A038 RID: 237624
			[Token(Token = "0x403A038")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<Image> _imgIcons;

			// Token: 0x0403A039 RID: 237625
			[Token(Token = "0x403A039")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<Text> _textRewards;

			// Token: 0x0403A03A RID: 237626
			[Token(Token = "0x403A03A")]
			[FieldOffset(Offset = "0x30")]
			private UICompDialogFinder m_dialogFinder;

			// Token: 0x0403A03B RID: 237627
			[Token(Token = "0x403A03B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_diffType;

			// Token: 0x0403A03C RID: 237628
			[Token(Token = "0x403A03C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403A03D RID: 237629
			[Token(Token = "0x403A03D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
