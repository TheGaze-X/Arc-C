using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003553 RID: 13651
	[Token(Token = "0x2003553")]
	[RequireComponent(typeof(ThreeStateToggle))]
	public class UICharacterSortTypePanelItem : UICharacterSortCommonItem
	{
		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x06015C07 RID: 89095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015C08 RID: 89096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033AA")]
		public Action<CharacterSortType> onSortTypeChanged
		{
			[Token(Token = "0x6015C07")]
			[Address(RVA = "0xE57CB0", Offset = "0xE568B0", VA = "0x180E57CB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6015C08")]
			[Address(RVA = "0xE57D10", Offset = "0xE56910", VA = "0x180E57D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06015C09 RID: 89097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C09")]
		[Address(RVA = "0xE576D0", Offset = "0xE562D0", VA = "0x180E576D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C0A RID: 89098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C0A")]
		[Address(RVA = "0xE577D0", Offset = "0xE563D0", VA = "0x180E577D0")]
		private void _OnToggleClick(ThreeStateToggle.State state)
		{
		}

		// Token: 0x06015C0B RID: 89099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C0B")]
		[Address(RVA = "0xE56E50", Offset = "0xE55A50", VA = "0x180E56E50", Slot = "4")]
		public override void RenderSortItem(CharacterSortTypePair sortPair, bool lightMode)
		{
		}

		// Token: 0x06015C0C RID: 89100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C0C")]
		[Address(RVA = "0xE56CA0", Offset = "0xE558A0", VA = "0x180E56CA0", Slot = "5")]
		public override void NotifySortTypeChanged(CharacterSortType sortType)
		{
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x06015C0D RID: 89101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033AB")]
		public UICharacterHandbookStageCountItem countItem
		{
			[Token(Token = "0x6015C0D")]
			[Address(RVA = "0xE57C50", Offset = "0xE56850", VA = "0x180E57C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015C0E RID: 89102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C0E")]
		[Address(RVA = "0xE57610", Offset = "0xE56210", VA = "0x180E57610")]
		private void _GenHandbookStageCountItem()
		{
		}

		// Token: 0x06015C0F RID: 89103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C0F")]
		[Address(RVA = "0xE57320", Offset = "0xE55F20", VA = "0x180E57320")]
		private void _ChangeColor(ThreeStateToggle.State state)
		{
		}

		// Token: 0x06015C10 RID: 89104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C10")]
		[Address(RVA = "0xE57140", Offset = "0xE55D40", VA = "0x180E57140")]
		private void _ChangeCntItemColor(Color txtColor, Color bgColor)
		{
		}

		// Token: 0x06015C11 RID: 89105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C11")]
		[Address(RVA = "0xE578E0", Offset = "0xE564E0", VA = "0x180E578E0")]
		private UICharacterSortTypePanelItem.SortItemColorStyle _TryGetColorStyle(ThreeStateToggle.State state)
		{
			return null;
		}

		// Token: 0x06015C12 RID: 89106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C12")]
		[Address(RVA = "0xE57B00", Offset = "0xE56700", VA = "0x180E57B00")]
		private string _TryGetStyleId(ThreeStateToggle.State state)
		{
			return null;
		}

		// Token: 0x06015C13 RID: 89107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C13")]
		[Address(RVA = "0xE57BB0", Offset = "0xE567B0", VA = "0x180E57BB0")]
		public UICharacterSortTypePanelItem()
		{
		}

		// Token: 0x0401A262 RID: 107106
		[Token(Token = "0x401A262")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("sort type when first clicked")]
		private CharacterSortType _firstSortType;

		// Token: 0x0401A263 RID: 107107
		[Token(Token = "0x401A263")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("sort type when clicked again")]
		private CharacterSortType _secondSortType;

		// Token: 0x0401A264 RID: 107108
		[Token(Token = "0x401A264")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _sortTitle;

		// Token: 0x0401A265 RID: 107109
		[Token(Token = "0x401A265")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _sortIcon;

		// Token: 0x0401A266 RID: 107110
		[Token(Token = "0x401A266")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _sortIconBg;

		// Token: 0x0401A267 RID: 107111
		[Token(Token = "0x401A267")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("color style")]
		private UICharacterSortTypePanelItem.SortItemColorStyle[] _colorStyles;

		// Token: 0x0401A268 RID: 107112
		[Token(Token = "0x401A268")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lightMask;

		// Token: 0x0401A269 RID: 107113
		[Token(Token = "0x401A269")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _countContainer;

		// Token: 0x0401A26A RID: 107114
		[Token(Token = "0x401A26A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICharacterHandbookStageCountItem _countPrefab;

		// Token: 0x0401A26B RID: 107115
		[Token(Token = "0x401A26B")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A26C RID: 107116
		[Token(Token = "0x401A26C")]
		[FieldOffset(Offset = "0x60")]
		private UICharacterHandbookStageCountItem m_countItem;

		// Token: 0x0401A26D RID: 107117
		[Token(Token = "0x401A26D")]
		[FieldOffset(Offset = "0x68")]
		private ThreeStateToggle m_toggle;

		// Token: 0x0401A26E RID: 107118
		[Token(Token = "0x401A26E")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0401A26F RID: 107119
		[Token(Token = "0x401A26F")]
		private const string UNSELECTED_COLOR_ID = "unselected";

		// Token: 0x0401A270 RID: 107120
		[Token(Token = "0x401A270")]
		private const string SELECTED_COLOR_ID = "selected";

		// Token: 0x0401A272 RID: 107122
		[Token(Token = "0x401A272")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSortTypeChanged;

		// Token: 0x0401A273 RID: 107123
		[Token(Token = "0x401A273")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSortTypeChanged;

		// Token: 0x0401A274 RID: 107124
		[Token(Token = "0x401A274")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A275 RID: 107125
		[Token(Token = "0x401A275")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggleClick;

		// Token: 0x0401A276 RID: 107126
		[Token(Token = "0x401A276")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderSortItem;

		// Token: 0x0401A277 RID: 107127
		[Token(Token = "0x401A277")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifySortTypeChanged;

		// Token: 0x0401A278 RID: 107128
		[Token(Token = "0x401A278")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_countItem;

		// Token: 0x0401A279 RID: 107129
		[Token(Token = "0x401A279")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenHandbookStageCountItem;

		// Token: 0x0401A27A RID: 107130
		[Token(Token = "0x401A27A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ChangeColor;

		// Token: 0x0401A27B RID: 107131
		[Token(Token = "0x401A27B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ChangeCntItemColor;

		// Token: 0x0401A27C RID: 107132
		[Token(Token = "0x401A27C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryGetColorStyle;

		// Token: 0x0401A27D RID: 107133
		[Token(Token = "0x401A27D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetStyleId;

		// Token: 0x0401A27E RID: 107134
		[Token(Token = "0x401A27E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003554 RID: 13652
		[Token(Token = "0x2003554")]
		[Serializable]
		private class SortItemColorStyle
		{
			// Token: 0x06015C14 RID: 89108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C14")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SortItemColorStyle()
			{
			}

			// Token: 0x0401A27F RID: 107135
			[Token(Token = "0x401A27F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string styleId;

			// Token: 0x0401A280 RID: 107136
			[Token(Token = "0x401A280")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Color iconColor;

			// Token: 0x0401A281 RID: 107137
			[Token(Token = "0x401A281")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public Color iconBgColor;

			// Token: 0x0401A282 RID: 107138
			[Token(Token = "0x401A282")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Color textColor;

			// Token: 0x0401A283 RID: 107139
			[Token(Token = "0x401A283")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			public Color cntBgColor;

			// Token: 0x0401A284 RID: 107140
			[Token(Token = "0x401A284")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Color cntTextColor;
		}
	}
}
