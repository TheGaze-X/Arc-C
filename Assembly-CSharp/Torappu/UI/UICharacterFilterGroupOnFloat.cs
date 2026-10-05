using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003535 RID: 13621
	[Token(Token = "0x2003535")]
	public class UICharacterFilterGroupOnFloat : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x06015B5D RID: 88925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015B5E RID: 88926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003394")]
		[Inspect]
		public CharacterFilterViewModel filterModel
		{
			[Token(Token = "0x6015B5D")]
			[Address(RVA = "0xE4E4F0", Offset = "0xE4D0F0", VA = "0x180E4E4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015B5E")]
			[Address(RVA = "0xE4E550", Offset = "0xE4D150", VA = "0x180E4E550")]
			set
			{
			}
		}

		// Token: 0x06015B5F RID: 88927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B5F")]
		[Address(RVA = "0xE4D700", Offset = "0xE4C300", VA = "0x180E4D700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015B60 RID: 88928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B60")]
		[Address(RVA = "0xE4D490", Offset = "0xE4C090", VA = "0x180E4D490")]
		public void OnFilterChanged(CharacterFilterElement filter, bool isSelected)
		{
		}

		// Token: 0x06015B61 RID: 88929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B61")]
		[Address(RVA = "0xE4DC50", Offset = "0xE4C850", VA = "0x180E4DC50")]
		private void _ProcessSingleFilterMode(CharacterFilterElement filter, bool isSelected)
		{
		}

		// Token: 0x06015B62 RID: 88930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B62")]
		[Address(RVA = "0xE4D9A0", Offset = "0xE4C5A0", VA = "0x180E4D9A0")]
		private void _ProcessMultiFilterMode(CharacterFilterElement filter, bool isSelected)
		{
		}

		// Token: 0x06015B63 RID: 88931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B63")]
		[Address(RVA = "0xE4E170", Offset = "0xE4CD70", VA = "0x180E4E170")]
		private void _UpdateData2UI()
		{
		}

		// Token: 0x06015B64 RID: 88932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B64")]
		[Address(RVA = "0xE4D940", Offset = "0xE4C540", VA = "0x180E4D940")]
		private void _LayoutRebuilt()
		{
		}

		// Token: 0x06015B65 RID: 88933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B65")]
		[Address(RVA = "0xE4DDC0", Offset = "0xE4C9C0", VA = "0x180E4DDC0")]
		private void _TryUpdateArrow()
		{
		}

		// Token: 0x06015B66 RID: 88934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B66")]
		[Address(RVA = "0xE4E3F0", Offset = "0xE4CFF0", VA = "0x180E4E3F0")]
		public UICharacterFilterGroupOnFloat()
		{
		}

		// Token: 0x0401A147 RID: 106823
		[Token(Token = "0x401A147")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterFilterItemOnFloat[] _filterItems;

		// Token: 0x0401A148 RID: 106824
		[Token(Token = "0x401A148")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _filterSelectArrow;

		// Token: 0x0401A149 RID: 106825
		[Token(Token = "0x401A149")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _arrowImg;

		// Token: 0x0401A14A RID: 106826
		[Token(Token = "0x401A14A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UILayoutDimensionListener _girdLayoutListener;

		// Token: 0x0401A14B RID: 106827
		[Token(Token = "0x401A14B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _singleMode;

		// Token: 0x0401A14C RID: 106828
		[Token(Token = "0x401A14C")]
		[FieldOffset(Offset = "0x40")]
		private CharacterFilterViewModel m_filterModel;

		// Token: 0x0401A14D RID: 106829
		[Token(Token = "0x401A14D")]
		[FieldOffset(Offset = "0x48")]
		private List<CharacterFilterIdent> m_filterIdents;

		// Token: 0x0401A14E RID: 106830
		[Token(Token = "0x401A14E")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401A14F RID: 106831
		[Token(Token = "0x401A14F")]
		[FieldOffset(Offset = "0x51")]
		private bool m_layoutBuilt;

		// Token: 0x0401A150 RID: 106832
		[Token(Token = "0x401A150")]
		[FieldOffset(Offset = "0x52")]
		private bool m_hasSelectArrow;

		// Token: 0x0401A151 RID: 106833
		[Token(Token = "0x401A151")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<CharacterFilterViewModel> onFilterCallback;

		// Token: 0x0401A152 RID: 106834
		[Token(Token = "0x401A152")]
		[FieldOffset(Offset = "0x60")]
		private Tweener m_arrowTw;

		// Token: 0x0401A153 RID: 106835
		[Token(Token = "0x401A153")]
		[FieldOffset(Offset = "0x68")]
		private Tweener m_arrowHideTw;

		// Token: 0x0401A154 RID: 106836
		[Token(Token = "0x401A154")]
		[FieldOffset(Offset = "0x70")]
		private Tweener m_arrowShowTw;

		// Token: 0x0401A155 RID: 106837
		[Token(Token = "0x401A155")]
		[FieldOffset(Offset = "0x78")]
		private int m_currentFilterIdx;

		// Token: 0x0401A156 RID: 106838
		[Token(Token = "0x401A156")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterModel;

		// Token: 0x0401A157 RID: 106839
		[Token(Token = "0x401A157")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_filterModel;

		// Token: 0x0401A158 RID: 106840
		[Token(Token = "0x401A158")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A159 RID: 106841
		[Token(Token = "0x401A159")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFilterChanged;

		// Token: 0x0401A15A RID: 106842
		[Token(Token = "0x401A15A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ProcessSingleFilterMode;

		// Token: 0x0401A15B RID: 106843
		[Token(Token = "0x401A15B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ProcessMultiFilterMode;

		// Token: 0x0401A15C RID: 106844
		[Token(Token = "0x401A15C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateData2UI;

		// Token: 0x0401A15D RID: 106845
		[Token(Token = "0x401A15D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LayoutRebuilt;

		// Token: 0x0401A15E RID: 106846
		[Token(Token = "0x401A15E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryUpdateArrow;

		// Token: 0x0401A15F RID: 106847
		[Token(Token = "0x401A15F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
