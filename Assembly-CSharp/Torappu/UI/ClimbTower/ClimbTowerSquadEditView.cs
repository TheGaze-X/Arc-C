using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D71 RID: 23921
	[Token(Token = "0x2005D71")]
	public class ClimbTowerSquadEditView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06022AAF RID: 141999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051C1")]
		public ClimbTowerSquadEditGroupItemView itemPrefab
		{
			[Token(Token = "0x6022AAF")]
			[Address(RVA = "0x1D36F30", Offset = "0x1D35B30", VA = "0x181D36F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x06022AB0 RID: 142000 RVA: 0x000BE578 File Offset: 0x000BC778
		[Token(Token = "0x170051C2")]
		public long gameStartTs
		{
			[Token(Token = "0x6022AB0")]
			[Address(RVA = "0x1D36ED0", Offset = "0x1D35AD0", VA = "0x181D36ED0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x06022AB1 RID: 142001 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022AB2 RID: 142002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051C3")]
		public Action<int> onCharSelect
		{
			[Token(Token = "0x6022AB1")]
			[Address(RVA = "0x1D36F90", Offset = "0x1D35B90", VA = "0x181D36F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022AB2")]
			[Address(RVA = "0x1D36FF0", Offset = "0x1D35BF0", VA = "0x181D36FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022AB3 RID: 142003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AB3")]
		[Address(RVA = "0x1D360D0", Offset = "0x1D34CD0", VA = "0x181D360D0")]
		public void Render(List<ClimbTowerSquadItemModel> charList, ClimbTowerSquadEditStateBean.FocusParams focusParams, ClimbTowerSquadItemModel focusCharModel, long gameStartTs, bool backFromStack)
		{
		}

		// Token: 0x06022AB4 RID: 142004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AB4")]
		[Address(RVA = "0x1D36DA0", Offset = "0x1D359A0", VA = "0x181D36DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022AB5 RID: 142005 RVA: 0x000BE590 File Offset: 0x000BC790
		[Token(Token = "0x6022AB5")]
		[Address(RVA = "0x1D36410", Offset = "0x1D35010", VA = "0x181D36410")]
		private static float _CalculateVisibleColumnInsideChild(Bounds elementBounds, float viewportMin)
		{
			return 0f;
		}

		// Token: 0x06022AB6 RID: 142006 RVA: 0x000BE5A8 File Offset: 0x000BC7A8
		[Token(Token = "0x6022AB6")]
		[Address(RVA = "0x1D36D00", Offset = "0x1D35900", VA = "0x181D36D00")]
		private static float _GetPositionInsideChild(float columnIndex)
		{
			return 0f;
		}

		// Token: 0x06022AB7 RID: 142007 RVA: 0x000BE5C0 File Offset: 0x000BC7C0
		[Token(Token = "0x6022AB7")]
		[Address(RVA = "0x1D36B70", Offset = "0x1D35770", VA = "0x181D36B70")]
		private float _GetPositionFromIndex(int viewIndex, float columnIndex)
		{
			return 0f;
		}

		// Token: 0x06022AB8 RID: 142008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AB8")]
		[Address(RVA = "0x1D36510", Offset = "0x1D35110", VA = "0x181D36510")]
		private void _FocusToCharCard(ClimbTowerSquadItemModel focusCharModel, bool fastMode)
		{
		}

		// Token: 0x06022AB9 RID: 142009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AB9")]
		[Address(RVA = "0x1D368C0", Offset = "0x1D354C0", VA = "0x181D368C0")]
		private void _FocusToPos(float pos, bool fastMode)
		{
		}

		// Token: 0x06022ABA RID: 142010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ABA")]
		[Address(RVA = "0x1D36020", Offset = "0x1D34C20", VA = "0x181D36020")]
		public void OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022ABB RID: 142011 RVA: 0x000BE5D8 File Offset: 0x000BC7D8
		[Token(Token = "0x6022ABB")]
		[Address(RVA = "0x1D35BF0", Offset = "0x1D347F0", VA = "0x181D35BF0")]
		public int GetCurrIndex(out float columnIndex)
		{
			return 0;
		}

		// Token: 0x06022ABC RID: 142012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ABC")]
		[Address(RVA = "0x1D36E70", Offset = "0x1D35A70", VA = "0x181D36E70")]
		public ClimbTowerSquadEditView()
		{
		}

		// Token: 0x0402FA55 RID: 195157
		[Token(Token = "0x402FA55")]
		private const float FOCUS_TWEEN_DURATION = 0.23f;

		// Token: 0x0402FA56 RID: 195158
		[Token(Token = "0x402FA56")]
		private const float CHAR_CARD_BOUNDS_MARGIN = 23f;

		// Token: 0x0402FA57 RID: 195159
		[Token(Token = "0x402FA57")]
		private const float GROUP_VIEW_ELEMENT_WIDTH = 118.6f;

		// Token: 0x0402FA58 RID: 195160
		[Token(Token = "0x402FA58")]
		private const float GROUP_VIEW_ELEMENT_SPACING = 12f;

		// Token: 0x0402FA59 RID: 195161
		[Token(Token = "0x402FA59")]
		private const float GROUP_VIEW_HEADER_WIDTH = 75f;

		// Token: 0x0402FA5A RID: 195162
		[Token(Token = "0x402FA5A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClimbTowerSquadEditGroupItemView _groupItemView;

		// Token: 0x0402FA5B RID: 195163
		[Token(Token = "0x402FA5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleSquadList;

		// Token: 0x0402FA5C RID: 195164
		[Token(Token = "0x402FA5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0402FA5D RID: 195165
		[Token(Token = "0x402FA5D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0402FA5E RID: 195166
		[Token(Token = "0x402FA5E")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerSquadEditRecylceAdapter m_adapter;

		// Token: 0x0402FA5F RID: 195167
		[Token(Token = "0x402FA5F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402FA60 RID: 195168
		[Token(Token = "0x402FA60")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x0402FA61 RID: 195169
		[Token(Token = "0x402FA61")]
		[FieldOffset(Offset = "0x50")]
		private long m_cachedGameStartTs;

		// Token: 0x0402FA63 RID: 195171
		[Token(Token = "0x402FA63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemPrefab;

		// Token: 0x0402FA64 RID: 195172
		[Token(Token = "0x402FA64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gameStartTs;

		// Token: 0x0402FA65 RID: 195173
		[Token(Token = "0x402FA65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FA66 RID: 195174
		[Token(Token = "0x402FA66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FA67 RID: 195175
		[Token(Token = "0x402FA67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FA68 RID: 195176
		[Token(Token = "0x402FA68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FA69 RID: 195177
		[Token(Token = "0x402FA69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalculateVisibleColumnInsideChild;

		// Token: 0x0402FA6A RID: 195178
		[Token(Token = "0x402FA6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPositionInsideChild;

		// Token: 0x0402FA6B RID: 195179
		[Token(Token = "0x402FA6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetPositionFromIndex;

		// Token: 0x0402FA6C RID: 195180
		[Token(Token = "0x402FA6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FocusToCharCard;

		// Token: 0x0402FA6D RID: 195181
		[Token(Token = "0x402FA6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FocusToPos;

		// Token: 0x0402FA6E RID: 195182
		[Token(Token = "0x402FA6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnProfessionClicked;

		// Token: 0x0402FA6F RID: 195183
		[Token(Token = "0x402FA6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCurrIndex;

		// Token: 0x0402FA70 RID: 195184
		[Token(Token = "0x402FA70")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
