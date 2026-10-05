using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A4 RID: 16548
	[Token(Token = "0x20040A4")]
	public class SandboxV2AdminMainInventoryItemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x060199A6 RID: 104870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060199A7 RID: 104871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D19")]
		public string topicId
		{
			[Token(Token = "0x60199A6")]
			[Address(RVA = "0x124AED0", Offset = "0x1249AD0", VA = "0x18124AED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60199A7")]
			[Address(RVA = "0x124AF30", Offset = "0x1249B30", VA = "0x18124AF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060199A8 RID: 104872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199A8")]
		[Address(RVA = "0x1249A70", Offset = "0x1248670", VA = "0x181249A70")]
		public void Render(SandboxV2AdminMainInventoryItemDetailStateBean stateBean)
		{
		}

		// Token: 0x060199A9 RID: 104873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199A9")]
		[Address(RVA = "0x124AA00", Offset = "0x1249600", VA = "0x18124AA00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060199AA RID: 104874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199AA")]
		[Address(RVA = "0x1249F10", Offset = "0x1248B10", VA = "0x181249F10")]
		private void _FlushCard(SandboxV2AdminMainInventoryItemModel itemModel)
		{
		}

		// Token: 0x060199AB RID: 104875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199AB")]
		[Address(RVA = "0x124A220", Offset = "0x1248E20", VA = "0x18124A220")]
		private void _FlushFood(SandboxV2FoodVariantInfo foodVarInfo)
		{
		}

		// Token: 0x060199AC RID: 104876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199AC")]
		[Address(RVA = "0x124A660", Offset = "0x1249260", VA = "0x18124A660")]
		private void _FlushTag(SandboxPermItemData itemData)
		{
		}

		// Token: 0x060199AD RID: 104877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199AD")]
		[Address(RVA = "0x124AD60", Offset = "0x1249960", VA = "0x18124AD60")]
		private void _UpdateBtnState()
		{
		}

		// Token: 0x060199AE RID: 104878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199AE")]
		[Address(RVA = "0x124AB70", Offset = "0x1249770", VA = "0x18124AB70")]
		private IEnumerator _SwitchToItem(int idxOffset)
		{
			return null;
		}

		// Token: 0x060199AF RID: 104879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199AF")]
		[Address(RVA = "0x1249DE0", Offset = "0x12489E0", VA = "0x181249DE0")]
		private void _ClearSwitchCoroutine()
		{
		}

		// Token: 0x060199B0 RID: 104880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199B0")]
		[Address(RVA = "0x124AC30", Offset = "0x1249830", VA = "0x18124AC30")]
		private void _TryStartSwitch()
		{
		}

		// Token: 0x060199B1 RID: 104881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199B1")]
		[Address(RVA = "0x1249A00", Offset = "0x1248600", VA = "0x181249A00")]
		public void EventPreItem()
		{
		}

		// Token: 0x060199B2 RID: 104882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199B2")]
		[Address(RVA = "0x1249990", Offset = "0x1248590", VA = "0x181249990")]
		public void EventNextItem()
		{
		}

		// Token: 0x060199B3 RID: 104883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199B3")]
		[Address(RVA = "0x124AE70", Offset = "0x1249A70", VA = "0x18124AE70")]
		public SandboxV2AdminMainInventoryItemDetailView()
		{
		}

		// Token: 0x0401FFA3 RID: 130979
		[Token(Token = "0x401FFA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _cardCanvas;

		// Token: 0x0401FFA4 RID: 130980
		[Token(Token = "0x401FFA4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardRt;

		// Token: 0x0401FFA5 RID: 130981
		[Token(Token = "0x401FFA5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _preBtn;

		// Token: 0x0401FFA6 RID: 130982
		[Token(Token = "0x401FFA6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _nextBtn;

		// Token: 0x0401FFA7 RID: 130983
		[Token(Token = "0x401FFA7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0401FFA8 RID: 130984
		[Token(Token = "0x401FFA8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _countNode;

		// Token: 0x0401FFA9 RID: 130985
		[Token(Token = "0x401FFA9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x0401FFAA RID: 130986
		[Token(Token = "0x401FFAA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _usageLabel;

		// Token: 0x0401FFAB RID: 130987
		[Token(Token = "0x401FFAB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _descLabel;

		// Token: 0x0401FFAC RID: 130988
		[Token(Token = "0x401FFAC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _approachLabel;

		// Token: 0x0401FFAD RID: 130989
		[Token(Token = "0x401FFAD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("FOOD_STATUS_BAR")]
		private GameObject _foodStatusBar;

		// Token: 0x0401FFAE RID: 130990
		[Token(Token = "0x401FFAE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("FOOD_STATUS_BAR")]
		private Text _foodTime;

		// Token: 0x0401FFAF RID: 130991
		[Token(Token = "0x401FFAF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("FOOD_STATUS_BAR")]
		private Image[] _attribIconList;

		// Token: 0x0401FFB0 RID: 130992
		[Token(Token = "0x401FFB0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("TRAP_TAG")]
		private GameObject _trapTagBar;

		// Token: 0x0401FFB1 RID: 130993
		[Token(Token = "0x401FFB1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("TRAP_TAG")]
		private Image _trapTagBg;

		// Token: 0x0401FFB2 RID: 130994
		[Token(Token = "0x401FFB2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("TRAP_TAG")]
		private Text _trapTagName;

		// Token: 0x0401FFB3 RID: 130995
		[Token(Token = "0x401FFB3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0401FFB4 RID: 130996
		[Token(Token = "0x401FFB4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0401FFB5 RID: 130997
		[Token(Token = "0x401FFB5")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x0401FFB6 RID: 130998
		[Token(Token = "0x401FFB6")]
		[FieldOffset(Offset = "0xB0")]
		private int m_currShowIdx;

		// Token: 0x0401FFB7 RID: 130999
		[Token(Token = "0x401FFB7")]
		[FieldOffset(Offset = "0xB8")]
		private List<SandboxV2AdminMainInventoryItemModel> m_itemList;

		// Token: 0x0401FFB8 RID: 131000
		[Token(Token = "0x401FFB8")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_switchCoroutine;

		// Token: 0x0401FFB9 RID: 131001
		[Token(Token = "0x401FFB9")]
		[FieldOffset(Offset = "0xC8")]
		private int m_targetOffset;

		// Token: 0x0401FFBA RID: 131002
		[Token(Token = "0x401FFBA")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401FFBB RID: 131003
		[Token(Token = "0x401FFBB")]
		private const float POSX_OFFSET = 50f;

		// Token: 0x0401FFBC RID: 131004
		[Token(Token = "0x401FFBC")]
		private const float FADE_DUR = 0.3f;

		// Token: 0x0401FFBE RID: 131006
		[Token(Token = "0x401FFBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401FFBF RID: 131007
		[Token(Token = "0x401FFBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0401FFC0 RID: 131008
		[Token(Token = "0x401FFC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FFC1 RID: 131009
		[Token(Token = "0x401FFC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FFC2 RID: 131010
		[Token(Token = "0x401FFC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FlushCard;

		// Token: 0x0401FFC3 RID: 131011
		[Token(Token = "0x401FFC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FlushFood;

		// Token: 0x0401FFC4 RID: 131012
		[Token(Token = "0x401FFC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FlushTag;

		// Token: 0x0401FFC5 RID: 131013
		[Token(Token = "0x401FFC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateBtnState;

		// Token: 0x0401FFC6 RID: 131014
		[Token(Token = "0x401FFC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchToItem;

		// Token: 0x0401FFC7 RID: 131015
		[Token(Token = "0x401FFC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearSwitchCoroutine;

		// Token: 0x0401FFC8 RID: 131016
		[Token(Token = "0x401FFC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryStartSwitch;

		// Token: 0x0401FFC9 RID: 131017
		[Token(Token = "0x401FFC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventPreItem;

		// Token: 0x0401FFCA RID: 131018
		[Token(Token = "0x401FFCA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventNextItem;

		// Token: 0x0401FFCB RID: 131019
		[Token(Token = "0x401FFCB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
