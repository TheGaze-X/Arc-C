using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B72 RID: 27506
	[Token(Token = "0x2006B72")]
	public class ArchiveEndbookDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060274D9 RID: 160985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274D9")]
		[Address(RVA = "0x227E710", Offset = "0x227D310", VA = "0x18227E710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060274DA RID: 160986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274DA")]
		[Address(RVA = "0x227E4B0", Offset = "0x227D0B0", VA = "0x18227E4B0")]
		public void Render(ArchiveEndbookItemModel viewModel, int index, bool isSelected)
		{
		}

		// Token: 0x060274DB RID: 160987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274DB")]
		[Address(RVA = "0x227E440", Offset = "0x227D040", VA = "0x18227E440")]
		public void OnItemClick()
		{
		}

		// Token: 0x060274DC RID: 160988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274DC")]
		[Address(RVA = "0x227E810", Offset = "0x227D410", VA = "0x18227E810")]
		public ArchiveEndbookDetailItemView()
		{
		}

		// Token: 0x04037A70 RID: 227952
		[Token(Token = "0x4037A70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04037A71 RID: 227953
		[Token(Token = "0x4037A71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037A72 RID: 227954
		[Token(Token = "0x4037A72")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04037A73 RID: 227955
		[Token(Token = "0x4037A73")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSelect;

		// Token: 0x04037A74 RID: 227956
		[Token(Token = "0x4037A74")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> onItemClicked;

		// Token: 0x04037A75 RID: 227957
		[Token(Token = "0x4037A75")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveEndbookDetailItemView.EndbookDetailSwitchTween m_swietchTween;

		// Token: 0x04037A76 RID: 227958
		[Token(Token = "0x4037A76")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04037A77 RID: 227959
		[Token(Token = "0x4037A77")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedIndex;

		// Token: 0x04037A78 RID: 227960
		[Token(Token = "0x4037A78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037A79 RID: 227961
		[Token(Token = "0x4037A79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037A7A RID: 227962
		[Token(Token = "0x4037A7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037A7B RID: 227963
		[Token(Token = "0x4037A7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B73 RID: 27507
		[Token(Token = "0x2006B73")]
		public class EndbookDetailSwitchTween : UISwitchTween
		{
			// Token: 0x060274DD RID: 160989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274DD")]
			[Address(RVA = "0x2289AE0", Offset = "0x22886E0", VA = "0x182289AE0")]
			public EndbookDetailSwitchTween(ArchiveEndbookDetailItemView closure)
			{
			}

			// Token: 0x060274DE RID: 160990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274DE")]
			[Address(RVA = "0x2289980", Offset = "0x2288580", VA = "0x182289980", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060274DF RID: 160991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274DF")]
			[Address(RVA = "0x2289820", Offset = "0x2288420", VA = "0x182289820", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x04037A7C RID: 227964
			[Token(Token = "0x4037A7C")]
			private const float SHOW_DURATION = 0.25f;

			// Token: 0x04037A7D RID: 227965
			[Token(Token = "0x4037A7D")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveEndbookDetailItemView m_closure;

			// Token: 0x04037A7E RID: 227966
			[Token(Token = "0x4037A7E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037A7F RID: 227967
			[Token(Token = "0x4037A7F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037A80 RID: 227968
			[Token(Token = "0x4037A80")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
