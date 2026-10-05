using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E1F RID: 24095
	[Token(Token = "0x2005E1F")]
	public class CharSelectCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022EA1 RID: 143009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA1")]
		[Address(RVA = "0x1D66310", Offset = "0x1D64F10", VA = "0x181D66310")]
		public void RenderCard(int selectedIndex, CharacterCardViewModel cardModel, bool showSelectOrder, CharacterSortType sortType)
		{
		}

		// Token: 0x06022EA2 RID: 143010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA2")]
		[Address(RVA = "0x1D66630", Offset = "0x1D65230", VA = "0x181D66630")]
		public void RenderPlugin(CharSelectCardMaskPlugin maskPluginPrefab, CharSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x170052C3 RID: 21187
		// (set) Token: 0x06022EA3 RID: 143011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052C3")]
		public Action<int> onClick
		{
			[Token(Token = "0x6022EA3")]
			[Address(RVA = "0x1D66BD0", Offset = "0x1D657D0", VA = "0x181D66BD0")]
			set
			{
			}
		}

		// Token: 0x06022EA4 RID: 143012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA4")]
		[Address(RVA = "0x1D66740", Offset = "0x1D65340", VA = "0x181D66740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022EA5 RID: 143013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA5")]
		[Address(RVA = "0x1D66940", Offset = "0x1D65540", VA = "0x181D66940")]
		private void _InitPluginIfNot(CharSelectCardMaskPlugin prefab, CharSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x06022EA6 RID: 143014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA6")]
		[Address(RVA = "0x1D66B60", Offset = "0x1D65760", VA = "0x181D66B60")]
		public CharSelectCardView()
		{
		}

		// Token: 0x0403016F RID: 196975
		[Token(Token = "0x403016F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The container for the character card")]
		private Transform _characterContainer;

		// Token: 0x04030170 RID: 196976
		[Token(Token = "0x4030170")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04030171 RID: 196977
		[Token(Token = "0x4030171")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _selectOrder;

		// Token: 0x04030172 RID: 196978
		[Token(Token = "0x4030172")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _charCardScaler;

		// Token: 0x04030173 RID: 196979
		[Token(Token = "0x4030173")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Plugin")]
		private RectTransform _maskPluginContainer;

		// Token: 0x04030174 RID: 196980
		[Token(Token = "0x4030174")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("SortInfo")]
		private RectTransform _sortInfoContainer;

		// Token: 0x04030175 RID: 196981
		[Token(Token = "0x4030175")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("SortInfo")]
		private UICharacterSortInfoPanel _sortInfoPrefab;

		// Token: 0x04030176 RID: 196982
		[Token(Token = "0x4030176")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public string pageName;

		// Token: 0x04030177 RID: 196983
		[Token(Token = "0x4030177")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterCardPanel m_cardPanel;

		// Token: 0x04030178 RID: 196984
		[Token(Token = "0x4030178")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04030179 RID: 196985
		[Token(Token = "0x4030179")]
		[FieldOffset(Offset = "0x68")]
		private CharacterCardViewModel m_cardModel;

		// Token: 0x0403017A RID: 196986
		[Token(Token = "0x403017A")]
		[FieldOffset(Offset = "0x70")]
		private int m_pluginPrefabId;

		// Token: 0x0403017B RID: 196987
		[Token(Token = "0x403017B")]
		[FieldOffset(Offset = "0x78")]
		private CharSelectCardMaskPlugin m_pluginInst;

		// Token: 0x0403017C RID: 196988
		[Token(Token = "0x403017C")]
		[FieldOffset(Offset = "0x80")]
		private UICharacterSortInfoPanel m_sortInfoInst;

		// Token: 0x0403017D RID: 196989
		[Token(Token = "0x403017D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0403017E RID: 196990
		[Token(Token = "0x403017E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderPlugin;

		// Token: 0x0403017F RID: 196991
		[Token(Token = "0x403017F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04030180 RID: 196992
		[Token(Token = "0x4030180")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030181 RID: 196993
		[Token(Token = "0x4030181")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitPluginIfNot;

		// Token: 0x04030182 RID: 196994
		[Token(Token = "0x4030182")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
