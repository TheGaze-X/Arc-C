using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F54 RID: 24404
	[Token(Token = "0x2005F54")]
	public class CharacterInfoIllustHolder : DataBinder<CharInfoGroupProperty>, IHotfixable
	{
		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06023553 RID: 144723 RVA: 0x000C0930 File Offset: 0x000BEB30
		[Token(Token = "0x17005388")]
		private bool m_haveLeft
		{
			[Token(Token = "0x6023553")]
			[Address(RVA = "0x1DD8AB0", Offset = "0x1DD76B0", VA = "0x181DD8AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x06023554 RID: 144724 RVA: 0x000C0948 File Offset: 0x000BEB48
		[Token(Token = "0x17005389")]
		private bool m_haveRight
		{
			[Token(Token = "0x6023554")]
			[Address(RVA = "0x1DD8B10", Offset = "0x1DD7710", VA = "0x181DD8B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023555 RID: 144725 RVA: 0x000C0960 File Offset: 0x000BEB60
		[Token(Token = "0x6023555")]
		[Address(RVA = "0x1DD8500", Offset = "0x1DD7100", VA = "0x181DD8500")]
		private bool _EnsurePrefab(int index, out CharacterInfoIllustItem item)
		{
			return default(bool);
		}

		// Token: 0x06023556 RID: 144726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023556")]
		[Address(RVA = "0x1DD8280", Offset = "0x1DD6E80", VA = "0x181DD8280", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x06023557 RID: 144727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023557")]
		[Address(RVA = "0x1DD8340", Offset = "0x1DD6F40", VA = "0x181DD8340")]
		public void Render()
		{
		}

		// Token: 0x06023558 RID: 144728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023558")]
		[Address(RVA = "0x1DD86A0", Offset = "0x1DD72A0", VA = "0x181DD86A0")]
		private void _RefreshPos(float pos)
		{
		}

		// Token: 0x06023559 RID: 144729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023559")]
		[Address(RVA = "0x1DD88A0", Offset = "0x1DD74A0", VA = "0x181DD88A0")]
		private void _RefreshSingleViewModel(int viewI, CharacterInfoIllustItem item)
		{
		}

		// Token: 0x0602355A RID: 144730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602355A")]
		[Address(RVA = "0x1DD7E90", Offset = "0x1DD6A90", VA = "0x181DD7E90")]
		public void OnDrag(int pos, bool isDragging)
		{
		}

		// Token: 0x0602355B RID: 144731 RVA: 0x000C0978 File Offset: 0x000BEB78
		[Token(Token = "0x602355B")]
		[Address(RVA = "0x1DD8400", Offset = "0x1DD7000", VA = "0x181DD8400")]
		private int _ClampPos(int pos)
		{
			return 0;
		}

		// Token: 0x0602355C RID: 144732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602355C")]
		[Address(RVA = "0x1DD8040", Offset = "0x1DD6C40", VA = "0x181DD8040")]
		public void OnEndDrag(int pos)
		{
		}

		// Token: 0x0602355D RID: 144733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602355D")]
		[Address(RVA = "0x1DD80D0", Offset = "0x1DD6CD0", VA = "0x181DD80D0")]
		public void OnRelease(int pos)
		{
		}

		// Token: 0x0602355E RID: 144734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602355E")]
		[Address(RVA = "0x1DD89D0", Offset = "0x1DD75D0", VA = "0x181DD89D0")]
		public CharacterInfoIllustHolder()
		{
		}

		// Token: 0x04030C14 RID: 199700
		[Token(Token = "0x4030C14")]
		private const int MAX_ONSIDE_COUNT = 1;

		// Token: 0x04030C15 RID: 199701
		[Token(Token = "0x4030C15")]
		private const int MAX_COUNT = 3;

		// Token: 0x04030C16 RID: 199702
		[Token(Token = "0x4030C16")]
		[FieldOffset(Offset = "0x20")]
		public float MAX_DRAG_DIS;

		// Token: 0x04030C17 RID: 199703
		[Token(Token = "0x4030C17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04030C18 RID: 199704
		[Token(Token = "0x4030C18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoIllustItem _item;

		// Token: 0x04030C19 RID: 199705
		[Token(Token = "0x4030C19")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _onDetailShow;

		// Token: 0x04030C1A RID: 199706
		[Token(Token = "0x4030C1A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIIntEvent _onDataApply;

		// Token: 0x04030C1B RID: 199707
		[Token(Token = "0x4030C1B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onDetailHide;

		// Token: 0x04030C1C RID: 199708
		[Token(Token = "0x4030C1C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _dragPart;

		// Token: 0x04030C1D RID: 199709
		[Token(Token = "0x4030C1D")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<int, CharacterInfoIllustItem> m_items;

		// Token: 0x04030C1E RID: 199710
		[Token(Token = "0x4030C1E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_ableToDrag;

		// Token: 0x04030C1F RID: 199711
		[Token(Token = "0x4030C1F")]
		[FieldOffset(Offset = "0x61")]
		private bool m_isDraggingNeedChangeState;

		// Token: 0x04030C20 RID: 199712
		[Token(Token = "0x4030C20")]
		[FieldOffset(Offset = "0x64")]
		private int m_currentFocusIndex;

		// Token: 0x04030C21 RID: 199713
		[Token(Token = "0x4030C21")]
		[FieldOffset(Offset = "0x68")]
		private List<CharacterInfoHolderBean.CharViewModel> m_viewModelList;

		// Token: 0x04030C22 RID: 199714
		[Token(Token = "0x4030C22")]
		[FieldOffset(Offset = "0x70")]
		private int m_currentMiddleIndex;

		// Token: 0x04030C23 RID: 199715
		[Token(Token = "0x4030C23")]
		[FieldOffset(Offset = "0x74")]
		private int m_newMiddleIndex;

		// Token: 0x04030C24 RID: 199716
		[Token(Token = "0x4030C24")]
		[FieldOffset(Offset = "0x78")]
		private int m_newFocusIndex;

		// Token: 0x04030C25 RID: 199717
		[Token(Token = "0x4030C25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_haveLeft;

		// Token: 0x04030C26 RID: 199718
		[Token(Token = "0x4030C26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_m_haveRight;

		// Token: 0x04030C27 RID: 199719
		[Token(Token = "0x4030C27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsurePrefab;

		// Token: 0x04030C28 RID: 199720
		[Token(Token = "0x4030C28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030C29 RID: 199721
		[Token(Token = "0x4030C29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030C2A RID: 199722
		[Token(Token = "0x4030C2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshPos;

		// Token: 0x04030C2B RID: 199723
		[Token(Token = "0x4030C2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshSingleViewModel;

		// Token: 0x04030C2C RID: 199724
		[Token(Token = "0x4030C2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04030C2D RID: 199725
		[Token(Token = "0x4030C2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClampPos;

		// Token: 0x04030C2E RID: 199726
		[Token(Token = "0x4030C2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04030C2F RID: 199727
		[Token(Token = "0x4030C2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRelease;

		// Token: 0x04030C30 RID: 199728
		[Token(Token = "0x4030C30")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
