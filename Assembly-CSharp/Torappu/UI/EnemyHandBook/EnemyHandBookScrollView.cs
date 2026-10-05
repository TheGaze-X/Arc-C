using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F35 RID: 20277
	[Token(Token = "0x2004F35")]
	public class EnemyHandBookScrollView : DataBinder<EnemyHandBookShowProperty>
	{
		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x0601E337 RID: 123703 RVA: 0x000ADCE8 File Offset: 0x000ABEE8
		// (set) Token: 0x0601E338 RID: 123704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046CE")]
		public bool needScroll
		{
			[Token(Token = "0x601E337")]
			[Address(RVA = "0x17EAEF0", Offset = "0x17E9AF0", VA = "0x1817EAEF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E338")]
			[Address(RVA = "0x17EAFB0", Offset = "0x17E9BB0", VA = "0x1817EAFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x0601E339 RID: 123705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E33A RID: 123706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046CF")]
		public Action<string> onSelectedChanged
		{
			[Token(Token = "0x601E339")]
			[Address(RVA = "0x17EAF50", Offset = "0x17E9B50", VA = "0x1817EAF50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E33A")]
			[Address(RVA = "0x17EB020", Offset = "0x17E9C20", VA = "0x1817EB020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E33B RID: 123707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E33B")]
		[Address(RVA = "0x17EA2B0", Offset = "0x17E8EB0", VA = "0x1817EA2B0", Slot = "7")]
		public override void OnValueChanged(EnemyHandBookShowProperty property)
		{
		}

		// Token: 0x0601E33C RID: 123708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E33C")]
		[Address(RVA = "0x17EACF0", Offset = "0x17E98F0", VA = "0x1817EACF0")]
		private void _ScrollToSelection(int selectIndex, bool shufflePatchFlag)
		{
		}

		// Token: 0x0601E33D RID: 123709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E33D")]
		[Address(RVA = "0x17EAB20", Offset = "0x17E9720", VA = "0x1817EAB20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E33E RID: 123710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E33E")]
		[Address(RVA = "0x17EABD0", Offset = "0x17E97D0", VA = "0x1817EABD0")]
		private void _OnItemClick(string id)
		{
		}

		// Token: 0x0601E33F RID: 123711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E33F")]
		[Address(RVA = "0x17EAE80", Offset = "0x17E9A80", VA = "0x1817EAE80")]
		public EnemyHandBookScrollView()
		{
		}

		// Token: 0x040283EF RID: 164847
		[Token(Token = "0x40283EF")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x040283F0 RID: 164848
		[Token(Token = "0x40283F0")]
		private const int SLIDE_MAX_ROW = 5;

		// Token: 0x040283F1 RID: 164849
		[Token(Token = "0x40283F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyHandBookScrollListAdapter _listAdapter;

		// Token: 0x040283F2 RID: 164850
		[Token(Token = "0x40283F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x040283F3 RID: 164851
		[Token(Token = "0x40283F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnemyHandBookDetailView _detailView;

		// Token: 0x040283F4 RID: 164852
		[Token(Token = "0x40283F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _layoutGroup;

		// Token: 0x040283F5 RID: 164853
		[Token(Token = "0x40283F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x040283F6 RID: 164854
		[Token(Token = "0x40283F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _emptyView;

		// Token: 0x040283F7 RID: 164855
		[Token(Token = "0x40283F7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040283F8 RID: 164856
		[Token(Token = "0x40283F8")]
		[FieldOffset(Offset = "0x54")]
		private int m_rowCount;

		// Token: 0x040283F9 RID: 164857
		[Token(Token = "0x40283F9")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_cachedTween;

		// Token: 0x040283FA RID: 164858
		[Token(Token = "0x40283FA")]
		[FieldOffset(Offset = "0x60")]
		private EnemyHandbookShuffleViewModel.ShufflePatch m_patch;

		// Token: 0x040283FD RID: 164861
		[Token(Token = "0x40283FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needScroll;

		// Token: 0x040283FE RID: 164862
		[Token(Token = "0x40283FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_needScroll;

		// Token: 0x040283FF RID: 164863
		[Token(Token = "0x40283FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSelectedChanged;

		// Token: 0x04028400 RID: 164864
		[Token(Token = "0x4028400")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSelectedChanged;

		// Token: 0x04028401 RID: 164865
		[Token(Token = "0x4028401")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028402 RID: 164866
		[Token(Token = "0x4028402")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ScrollToSelection;

		// Token: 0x04028403 RID: 164867
		[Token(Token = "0x4028403")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028404 RID: 164868
		[Token(Token = "0x4028404")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04028405 RID: 164869
		[Token(Token = "0x4028405")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
