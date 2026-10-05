using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A7 RID: 30119
	[Token(Token = "0x20075A7")]
	public class Act24sideMeldingGoodGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x0602A616 RID: 173590 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A617 RID: 173591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063B7")]
		public string gachaBoxId
		{
			[Token(Token = "0x602A616")]
			[Address(RVA = "0x260B440", Offset = "0x260A040", VA = "0x18260B440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A617")]
			[Address(RVA = "0x260B4C0", Offset = "0x260A0C0", VA = "0x18260B4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A618 RID: 173592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A618")]
		[Address(RVA = "0x260A600", Offset = "0x2609200", VA = "0x18260A600")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x0602A619 RID: 173593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A619")]
		[Address(RVA = "0x260A690", Offset = "0x2609290", VA = "0x18260A690")]
		public void Render(Act24sideMeldingGoodGroupViewModel groupViewModel)
		{
		}

		// Token: 0x0602A61A RID: 173594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A61A")]
		[Address(RVA = "0x260AAA0", Offset = "0x26096A0", VA = "0x18260AAA0")]
		public void TryScrollToRemainCountRarePart()
		{
		}

		// Token: 0x0602A61B RID: 173595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A61B")]
		[Address(RVA = "0x260AEF0", Offset = "0x2609AF0", VA = "0x18260AEF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A61C RID: 173596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A61C")]
		[Address(RVA = "0x260AD90", Offset = "0x2609990", VA = "0x18260AD90")]
		private void _InitDicDisplayLayoutStatus()
		{
		}

		// Token: 0x0602A61D RID: 173597 RVA: 0x000D8330 File Offset: 0x000D6530
		[Token(Token = "0x602A61D")]
		[Address(RVA = "0x260B070", Offset = "0x2609C70", VA = "0x18260B070")]
		private bool _IsAllDisplayLayouted()
		{
			return default(bool);
		}

		// Token: 0x0602A61E RID: 173598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A61E")]
		[Address(RVA = "0x260ACD0", Offset = "0x26098D0", VA = "0x18260ACD0")]
		private IEnumerator _CoTryScrollToRemainCountRarePart()
		{
			return null;
		}

		// Token: 0x0602A61F RID: 173599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A61F")]
		[Address(RVA = "0x260B200", Offset = "0x2609E00", VA = "0x18260B200")]
		private void _OnDisplayGridPostLayout(Act24SideData.MeldingGoodDisplayType displayType)
		{
		}

		// Token: 0x0602A620 RID: 173600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A620")]
		[Address(RVA = "0x260B370", Offset = "0x2609F70", VA = "0x18260B370")]
		public Act24sideMeldingGoodGroupView()
		{
		}

		// Token: 0x0403CF9B RID: 249755
		[Token(Token = "0x403CF9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0403CF9C RID: 249756
		[Token(Token = "0x403CF9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VerticalLayoutGroup _layout;

		// Token: 0x0403CF9D RID: 249757
		[Token(Token = "0x403CF9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectLayout;

		// Token: 0x0403CF9E RID: 249758
		[Token(Token = "0x403CF9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0403CF9F RID: 249759
		[Token(Token = "0x403CF9F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403CFA0 RID: 249760
		[Token(Token = "0x403CFA0")]
		[FieldOffset(Offset = "0x40")]
		private Act24sideMeldingGoodGroupViewModel m_model;

		// Token: 0x0403CFA1 RID: 249761
		[Token(Token = "0x403CFA1")]
		[FieldOffset(Offset = "0x48")]
		private Act24sideMeldingGoodGroupView.Adapter m_adapter;

		// Token: 0x0403CFA2 RID: 249762
		[Token(Token = "0x403CFA2")]
		[FieldOffset(Offset = "0x50")]
		private UISwitchTween.TweenWrapper m_focusTween;

		// Token: 0x0403CFA3 RID: 249763
		[Token(Token = "0x403CFA3")]
		[FieldOffset(Offset = "0x58")]
		private int m_layoutTopSpace;

		// Token: 0x0403CFA4 RID: 249764
		[Token(Token = "0x403CFA4")]
		[FieldOffset(Offset = "0x5C")]
		private int m_layoutDownSpace;

		// Token: 0x0403CFA5 RID: 249765
		[Token(Token = "0x403CFA5")]
		[FieldOffset(Offset = "0x60")]
		private float m_layoutSpace;

		// Token: 0x0403CFA6 RID: 249766
		[Token(Token = "0x403CFA6")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isDicDisplayLayoutInited;

		// Token: 0x0403CFA7 RID: 249767
		[Token(Token = "0x403CFA7")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<Act24SideData.MeldingGoodDisplayType, bool> m_dicDisplayLayoutStatus;

		// Token: 0x0403CFA8 RID: 249768
		[Token(Token = "0x403CFA8")]
		[FieldOffset(Offset = "0x70")]
		private UIPage m_page;

		// Token: 0x0403CFA9 RID: 249769
		[Token(Token = "0x403CFA9")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_corScrollToProperRare;

		// Token: 0x0403CFAA RID: 249770
		[Token(Token = "0x403CFAA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float SCROLL_SPEED;

		// Token: 0x0403CFAC RID: 249772
		[Token(Token = "0x403CFAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gachaBoxId;

		// Token: 0x0403CFAD RID: 249773
		[Token(Token = "0x403CFAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_gachaBoxId;

		// Token: 0x0403CFAE RID: 249774
		[Token(Token = "0x403CFAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403CFAF RID: 249775
		[Token(Token = "0x403CFAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CFB0 RID: 249776
		[Token(Token = "0x403CFB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryScrollToRemainCountRarePart;

		// Token: 0x0403CFB1 RID: 249777
		[Token(Token = "0x403CFB1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CFB2 RID: 249778
		[Token(Token = "0x403CFB2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitDicDisplayLayoutStatus;

		// Token: 0x0403CFB3 RID: 249779
		[Token(Token = "0x403CFB3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__IsAllDisplayLayouted;

		// Token: 0x0403CFB4 RID: 249780
		[Token(Token = "0x403CFB4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CoTryScrollToRemainCountRarePart;

		// Token: 0x0403CFB5 RID: 249781
		[Token(Token = "0x403CFB5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDisplayGridPostLayout;

		// Token: 0x0403CFB6 RID: 249782
		[Token(Token = "0x403CFB6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075A8 RID: 30120
		[Token(Token = "0x20075A8")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A624 RID: 173604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A624")]
			[Address(RVA = "0x261B320", Offset = "0x2619F20", VA = "0x18261B320")]
			public Adapter(Act24sideMeldingGoodGroupView closure)
			{
			}

			// Token: 0x170063B8 RID: 25528
			// (get) Token: 0x0602A625 RID: 173605 RVA: 0x000D8360 File Offset: 0x000D6560
			[Token(Token = "0x170063B8")]
			public override int count
			{
				[Token(Token = "0x602A625")]
				[Address(RVA = "0x261B470", Offset = "0x261A070", VA = "0x18261B470", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A626 RID: 173606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A626")]
			[Address(RVA = "0x261AF80", Offset = "0x2619B80", VA = "0x18261AF80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CFB7 RID: 249783
			[Token(Token = "0x403CFB7")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideMeldingGoodGroupView m_closure;

			// Token: 0x0403CFB8 RID: 249784
			[Token(Token = "0x403CFB8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CFB9 RID: 249785
			[Token(Token = "0x403CFB9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CFBA RID: 249786
			[Token(Token = "0x403CFBA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
