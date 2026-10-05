using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F8F RID: 24463
	[Token(Token = "0x2005F8F")]
	public class CharacterInfoPotentialView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023642 RID: 144962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023642")]
		[Address(RVA = "0x1E01E00", Offset = "0x1E00A00", VA = "0x181E01E00")]
		public void Render(CharacterInfoPotentialViewModel model, UIPage page)
		{
		}

		// Token: 0x06023643 RID: 144963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023643")]
		[Address(RVA = "0x1E02230", Offset = "0x1E00E30", VA = "0x181E02230")]
		public void ShowPotentialLvlUpAnim(CharacterInfoPotentialViewModel model)
		{
		}

		// Token: 0x06023644 RID: 144964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023644")]
		[Address(RVA = "0x1E01D20", Offset = "0x1E00920", VA = "0x181E01D20")]
		public void OnSelect(int index)
		{
		}

		// Token: 0x06023645 RID: 144965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023645")]
		[Address(RVA = "0x1E01BA0", Offset = "0x1E007A0", VA = "0x181E01BA0")]
		public void OnClick()
		{
		}

		// Token: 0x06023646 RID: 144966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023646")]
		[Address(RVA = "0x1E02A60", Offset = "0x1E01660", VA = "0x181E02A60")]
		private void _RefreshPotentialImg()
		{
		}

		// Token: 0x06023647 RID: 144967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023647")]
		[Address(RVA = "0x1E023B0", Offset = "0x1E00FB0", VA = "0x181E023B0")]
		private List<int> _GenerateIconRankList()
		{
			return null;
		}

		// Token: 0x06023648 RID: 144968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023648")]
		[Address(RVA = "0x1E02750", Offset = "0x1E01350", VA = "0x181E02750")]
		private void _RefreshLvlUpView(CharacterInfoPotentialViewModel model)
		{
		}

		// Token: 0x06023649 RID: 144969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023649")]
		[Address(RVA = "0x1E02C00", Offset = "0x1E01800", VA = "0x181E02C00")]
		private void _RenderItemDesc()
		{
		}

		// Token: 0x0602364A RID: 144970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602364A")]
		[Address(RVA = "0x1E02590", Offset = "0x1E01190", VA = "0x181E02590")]
		private CharacterInfoPotentialLevelUpItem _GetSelectItem()
		{
			return null;
		}

		// Token: 0x0602364B RID: 144971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602364B")]
		[Address(RVA = "0x1E02620", Offset = "0x1E01220", VA = "0x181E02620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602364C RID: 144972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602364C")]
		[Address(RVA = "0x1E02D50", Offset = "0x1E01950", VA = "0x181E02D50")]
		private void _ShowActivityPotential(bool isShow)
		{
		}

		// Token: 0x0602364D RID: 144973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602364D")]
		[Address(RVA = "0x1E02DF0", Offset = "0x1E019F0", VA = "0x181E02DF0")]
		public CharacterInfoPotentialView()
		{
		}

		// Token: 0x04030E3C RID: 200252
		[Token(Token = "0x4030E3C")]
		private const string ANIM_SHOW_KEY = "char_potential_anim_show";

		// Token: 0x04030E3D RID: 200253
		[Token(Token = "0x4030E3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x04030E3E RID: 200254
		[Token(Token = "0x4030E3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoPotentialIconLayout _potentialIconLayout;

		// Token: 0x04030E3F RID: 200255
		[Token(Token = "0x4030E3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _potentialTextContent;

		// Token: 0x04030E40 RID: 200256
		[Token(Token = "0x4030E40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lvl up")]
		private TwoStateToggle _toggleFullVoucher;

		// Token: 0x04030E41 RID: 200257
		[Token(Token = "0x4030E41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lvl up")]
		private TwoStateToggle _toggleCommonItem;

		// Token: 0x04030E42 RID: 200258
		[Token(Token = "0x4030E42")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Lvl up")]
		private CharacterInfoPotentialLevelUpItem _charItem;

		// Token: 0x04030E43 RID: 200259
		[Token(Token = "0x4030E43")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Lvl up")]
		private CharacterInfoPotentialLevelUpItem _commonItem;

		// Token: 0x04030E44 RID: 200260
		[Token(Token = "0x4030E44")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Lvl up")]
		private CharacterInfoPotentialLevelUpItem _voucherItem;

		// Token: 0x04030E45 RID: 200261
		[Token(Token = "0x4030E45")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Lvl up")]
		private UIStringEvent _onItemClick;

		// Token: 0x04030E46 RID: 200262
		[Token(Token = "0x4030E46")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Lvl up")]
		private UIStringEvent _onVoucherClick;

		// Token: 0x04030E47 RID: 200263
		[Token(Token = "0x4030E47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Lvl up")]
		private Text _textItemDesc;

		// Token: 0x04030E48 RID: 200264
		[Token(Token = "0x4030E48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Lvl up")]
		private CharacterInfoActivityPotentialItemView _activityItem;

		// Token: 0x04030E49 RID: 200265
		[Token(Token = "0x4030E49")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Lvl up")]
		private GameObject _panelPotentialBtn;

		// Token: 0x04030E4A RID: 200266
		[Token(Token = "0x4030E4A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Lvl up")]
		private GameObject _mixedHintPanel;

		// Token: 0x04030E4B RID: 200267
		[Token(Token = "0x4030E4B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Anim")]
		private Text _textPotentialLvlCurr;

		// Token: 0x04030E4C RID: 200268
		[Token(Token = "0x4030E4C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Anim")]
		private Text _textPotentialLvlPrev;

		// Token: 0x04030E4D RID: 200269
		[Token(Token = "0x4030E4D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Anim")]
		private Image _imgPotentialCurrent;

		// Token: 0x04030E4E RID: 200270
		[Token(Token = "0x4030E4E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Anim")]
		private Image _imgPotentialPrev;

		// Token: 0x04030E4F RID: 200271
		[Token(Token = "0x4030E4F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Anim")]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04030E50 RID: 200272
		[Token(Token = "0x4030E50")]
		[FieldOffset(Offset = "0xB0")]
		private UICharacterIllust m_illust;

		// Token: 0x04030E51 RID: 200273
		[Token(Token = "0x4030E51")]
		[FieldOffset(Offset = "0xB8")]
		private CharacterInfoPotentialView.Adapter m_potentialTextAdapter;

		// Token: 0x04030E52 RID: 200274
		[Token(Token = "0x4030E52")]
		[FieldOffset(Offset = "0xC0")]
		private int m_index;

		// Token: 0x04030E53 RID: 200275
		[Token(Token = "0x4030E53")]
		[FieldOffset(Offset = "0xC4")]
		private int m_rank;

		// Token: 0x04030E54 RID: 200276
		[Token(Token = "0x4030E54")]
		[FieldOffset(Offset = "0xC8")]
		private UISwitchTween.TweenWrapper m_tweenWrapper;

		// Token: 0x04030E55 RID: 200277
		[Token(Token = "0x4030E55")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x04030E56 RID: 200278
		[Token(Token = "0x4030E56")]
		[FieldOffset(Offset = "0xD8")]
		private CharacterData.PotentialRank[] m_potentialRanks;

		// Token: 0x04030E57 RID: 200279
		[Token(Token = "0x4030E57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030E58 RID: 200280
		[Token(Token = "0x4030E58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowPotentialLvlUpAnim;

		// Token: 0x04030E59 RID: 200281
		[Token(Token = "0x4030E59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x04030E5A RID: 200282
		[Token(Token = "0x4030E5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04030E5B RID: 200283
		[Token(Token = "0x4030E5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshPotentialImg;

		// Token: 0x04030E5C RID: 200284
		[Token(Token = "0x4030E5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateIconRankList;

		// Token: 0x04030E5D RID: 200285
		[Token(Token = "0x4030E5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshLvlUpView;

		// Token: 0x04030E5E RID: 200286
		[Token(Token = "0x4030E5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderItemDesc;

		// Token: 0x04030E5F RID: 200287
		[Token(Token = "0x4030E5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetSelectItem;

		// Token: 0x04030E60 RID: 200288
		[Token(Token = "0x4030E60")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030E61 RID: 200289
		[Token(Token = "0x4030E61")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowActivityPotential;

		// Token: 0x04030E62 RID: 200290
		[Token(Token = "0x4030E62")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F90 RID: 24464
		[Token(Token = "0x2005F90")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700539B RID: 21403
			// (get) Token: 0x0602364E RID: 144974 RVA: 0x000C0B28 File Offset: 0x000BED28
			[Token(Token = "0x1700539B")]
			public override int count
			{
				[Token(Token = "0x602364E")]
				[Address(RVA = "0x1DFE080", Offset = "0x1DFCC80", VA = "0x181DFE080", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602364F RID: 144975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602364F")]
			[Address(RVA = "0x1DFDDF0", Offset = "0x1DFC9F0", VA = "0x181DFDDF0")]
			public Adapter(CharacterInfoPotentialView closure)
			{
			}

			// Token: 0x06023650 RID: 144976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023650")]
			[Address(RVA = "0x1DFD480", Offset = "0x1DFC080", VA = "0x181DFD480", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04030E63 RID: 200291
			[Token(Token = "0x4030E63")]
			[FieldOffset(Offset = "0x20")]
			private CharacterInfoPotentialView m_closure;

			// Token: 0x04030E64 RID: 200292
			[Token(Token = "0x4030E64")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030E65 RID: 200293
			[Token(Token = "0x4030E65")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030E66 RID: 200294
			[Token(Token = "0x4030E66")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
