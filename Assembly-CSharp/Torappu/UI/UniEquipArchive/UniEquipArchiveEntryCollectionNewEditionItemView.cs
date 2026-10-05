using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BED RID: 15341
	[Token(Token = "0x2003BED")]
	public class UniEquipArchiveEntryCollectionNewEditionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018007 RID: 98311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018007")]
		[Address(RVA = "0x107D870", Offset = "0x107C470", VA = "0x18107D870")]
		public void Render(UniEquipArchiveEntryCollectionNewEditionItemViewModel itemViewModel)
		{
		}

		// Token: 0x06018008 RID: 98312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018008")]
		[Address(RVA = "0x107E2D0", Offset = "0x107CED0", VA = "0x18107E2D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018009 RID: 98313 RVA: 0x00098EB0 File Offset: 0x000970B0
		[Token(Token = "0x6018009")]
		[Address(RVA = "0x107E1F0", Offset = "0x107CDF0", VA = "0x18107E1F0")]
		private FadeSwitchTween.Builder _GetFadeBuilder(CanvasGroup canvasGroup)
		{
			return default(FadeSwitchTween.Builder);
		}

		// Token: 0x0601800A RID: 98314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601800A")]
		[Address(RVA = "0x107D780", Offset = "0x107C380", VA = "0x18107D780")]
		public void OnItemClick()
		{
		}

		// Token: 0x0601800B RID: 98315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601800B")]
		[Address(RVA = "0x107D690", Offset = "0x107C290", VA = "0x18107D690")]
		public void OnCharIconPartClick()
		{
		}

		// Token: 0x0601800C RID: 98316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601800C")]
		[Address(RVA = "0x107E480", Offset = "0x107D080", VA = "0x18107E480")]
		public UniEquipArchiveEntryCollectionNewEditionItemView()
		{
		}

		// Token: 0x0401D12D RID: 119085
		[Token(Token = "0x401D12D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgUniEquipIcon;

		// Token: 0x0401D12E RID: 119086
		[Token(Token = "0x401D12E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgUniEquipTypeIcon;

		// Token: 0x0401D12F RID: 119087
		[Token(Token = "0x401D12F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _txtUniEquipName;

		// Token: 0x0401D130 RID: 119088
		[Token(Token = "0x401D130")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Base-Equip")]
		private GameObject _panelSingleType;

		// Token: 0x0401D131 RID: 119089
		[Token(Token = "0x401D131")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Base-Equip")]
		private GameObject _panelMultiType;

		// Token: 0x0401D132 RID: 119090
		[Token(Token = "0x401D132")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _uniEquipSingleTypeDesc;

		// Token: 0x0401D133 RID: 119091
		[Token(Token = "0x401D133")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _uniEquipMultiTypeDesc;

		// Token: 0x0401D134 RID: 119092
		[Token(Token = "0x401D134")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _uniEquipMultiTypeDescImg;

		// Token: 0x0401D135 RID: 119093
		[Token(Token = "0x401D135")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgShining;

		// Token: 0x0401D136 RID: 119094
		[Token(Token = "0x401D136")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Base-Char")]
		private Image _imgCharIcon;

		// Token: 0x0401D137 RID: 119095
		[Token(Token = "0x401D137")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Base-Char")]
		private Text _txtCharName;

		// Token: 0x0401D138 RID: 119096
		[Token(Token = "0x401D138")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Base-Char")]
		private UIAtlasImage _imgCharColor;

		// Token: 0x0401D139 RID: 119097
		[Token(Token = "0x401D139")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Base-Char")]
		private GameObject _objCharDetailBtn;

		// Token: 0x0401D13A RID: 119098
		[Token(Token = "0x401D13A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Base-Char")]
		private float _charIconNotPhase2Alpha;

		// Token: 0x0401D13B RID: 119099
		[Token(Token = "0x401D13B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objCharPartClickBtn;

		// Token: 0x0401D13C RID: 119100
		[Token(Token = "0x401D13C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Base-Profession")]
		private Image _imgProfessionIcon;

		// Token: 0x0401D13D RID: 119101
		[Token(Token = "0x401D13D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Base-Profession")]
		private Image _imgSubProfessionIcon;

		// Token: 0x0401D13E RID: 119102
		[Token(Token = "0x401D13E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasNotOwnChar;

		// Token: 0x0401D13F RID: 119103
		[Token(Token = "0x401D13F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _canvasOwnCharNotPhase2;

		// Token: 0x0401D140 RID: 119104
		[Token(Token = "0x401D140")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _canvasOwnCharPhase2UnlockModule;

		// Token: 0x0401D141 RID: 119105
		[Token(Token = "0x401D141")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x0401D142 RID: 119106
		[Token(Token = "0x401D142")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedUniEquipId;

		// Token: 0x0401D143 RID: 119107
		[Token(Token = "0x401D143")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D144 RID: 119108
		[Token(Token = "0x401D144")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D145 RID: 119109
		[Token(Token = "0x401D145")]
		[FieldOffset(Offset = "0xE8")]
		private FadeSwitchTween m_tweenNotOwnChar;

		// Token: 0x0401D146 RID: 119110
		[Token(Token = "0x401D146")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_tweenOwnCharNotPhase2;

		// Token: 0x0401D147 RID: 119111
		[Token(Token = "0x401D147")]
		[FieldOffset(Offset = "0xF8")]
		private FadeSwitchTween m_tweenOwnCharPhase2UnlockModule;

		// Token: 0x0401D148 RID: 119112
		[Token(Token = "0x401D148")]
		private const float CHAR_FADE_ALPHA = 0.5f;

		// Token: 0x0401D149 RID: 119113
		[Token(Token = "0x401D149")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D14A RID: 119114
		[Token(Token = "0x401D14A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D14B RID: 119115
		[Token(Token = "0x401D14B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetFadeBuilder;

		// Token: 0x0401D14C RID: 119116
		[Token(Token = "0x401D14C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0401D14D RID: 119117
		[Token(Token = "0x401D14D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCharIconPartClick;

		// Token: 0x0401D14E RID: 119118
		[Token(Token = "0x401D14E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
