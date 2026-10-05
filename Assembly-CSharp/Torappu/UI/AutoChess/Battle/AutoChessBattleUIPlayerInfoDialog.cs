using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064DC RID: 25820
	[Token(Token = "0x20064DC")]
	public class AutoChessBattleUIPlayerInfoDialog : UICompDialog<AutoChessBattleUIPlayerInfoDialog.Input>
	{
		// Token: 0x06025196 RID: 151958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025196")]
		[Address(RVA = "0x201FFD0", Offset = "0x201EBD0", VA = "0x18201FFD0", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIPlayerInfoDialog.Input input)
		{
		}

		// Token: 0x06025197 RID: 151959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025197")]
		[Address(RVA = "0x2020490", Offset = "0x201F090", VA = "0x182020490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025198 RID: 151960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025198")]
		[Address(RVA = "0x2020740", Offset = "0x201F340", VA = "0x182020740")]
		private void _RenderMode(AutoChessHUDBandInfoModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x06025199 RID: 151961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025199")]
		[Address(RVA = "0x20205D0", Offset = "0x201F1D0", VA = "0x1820205D0")]
		private void _RenderBand(AutoChessHUDBandInfoModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602519A RID: 151962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602519A")]
		[Address(RVA = "0x2020900", Offset = "0x201F500", VA = "0x182020900")]
		public AutoChessBattleUIPlayerInfoDialog()
		{
		}

		// Token: 0x04033FB4 RID: 212916
		[Token(Token = "0x4033FB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x04033FB5 RID: 212917
		[Token(Token = "0x4033FB5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _modeNameText;

		// Token: 0x04033FB6 RID: 212918
		[Token(Token = "0x4033FB6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgModeBg;

		// Token: 0x04033FB7 RID: 212919
		[Token(Token = "0x4033FB7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgBandIcon;

		// Token: 0x04033FB8 RID: 212920
		[Token(Token = "0x4033FB8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _bandNameText;

		// Token: 0x04033FB9 RID: 212921
		[Token(Token = "0x4033FB9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _bandDescText;

		// Token: 0x04033FBA RID: 212922
		[Token(Token = "0x4033FBA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _absentBondContent;

		// Token: 0x04033FBB RID: 212923
		[Token(Token = "0x4033FBB")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x04033FBC RID: 212924
		[Token(Token = "0x4033FBC")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033FBD RID: 212925
		[Token(Token = "0x4033FBD")]
		[FieldOffset(Offset = "0xC0")]
		private AutoChessBattleUIPlayerInfoDialog.AbsenseBondAdapter m_absenseBondAdapter;

		// Token: 0x04033FBE RID: 212926
		[Token(Token = "0x4033FBE")]
		[FieldOffset(Offset = "0xC8")]
		private List<AutoChessBannedBondItemModel> m_cachedBannedBondModelList;

		// Token: 0x04033FBF RID: 212927
		[Token(Token = "0x4033FBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033FC0 RID: 212928
		[Token(Token = "0x4033FC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033FC1 RID: 212929
		[Token(Token = "0x4033FC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMode;

		// Token: 0x04033FC2 RID: 212930
		[Token(Token = "0x4033FC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBand;

		// Token: 0x04033FC3 RID: 212931
		[Token(Token = "0x4033FC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064DD RID: 25821
		[Token(Token = "0x20064DD")]
		private class AbsenseBondAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602519B RID: 151963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602519B")]
			[Address(RVA = "0x200E8B0", Offset = "0x200D4B0", VA = "0x18200E8B0")]
			public AbsenseBondAdapter(AutoChessBattleUIPlayerInfoDialog closure)
			{
			}

			// Token: 0x17005783 RID: 22403
			// (get) Token: 0x0602519C RID: 151964 RVA: 0x000C6720 File Offset: 0x000C4920
			[Token(Token = "0x17005783")]
			public override int count
			{
				[Token(Token = "0x602519C")]
				[Address(RVA = "0x200E930", Offset = "0x200D530", VA = "0x18200E930", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602519D RID: 151965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602519D")]
			[Address(RVA = "0x200E730", Offset = "0x200D330", VA = "0x18200E730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033FC4 RID: 212932
			[Token(Token = "0x4033FC4")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBattleUIPlayerInfoDialog m_closure;

			// Token: 0x04033FC5 RID: 212933
			[Token(Token = "0x4033FC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033FC6 RID: 212934
			[Token(Token = "0x4033FC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033FC7 RID: 212935
			[Token(Token = "0x4033FC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020064DE RID: 25822
		[Token(Token = "0x20064DE")]
		public class Input
		{
			// Token: 0x0602519E RID: 151966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602519E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033FC8 RID: 212936
			[Token(Token = "0x4033FC8")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBattleUIPlayerInfoViewModel model;
		}
	}
}
