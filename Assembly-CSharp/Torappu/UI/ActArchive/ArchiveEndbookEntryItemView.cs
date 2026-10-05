using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B74 RID: 27508
	[Token(Token = "0x2006B74")]
	public class ArchiveEndbookEntryItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060274E0 RID: 160992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E0")]
		[Address(RVA = "0x227EA30", Offset = "0x227D630", VA = "0x18227EA30")]
		public void Render(ArchiveEndbookEntryItemView.Param param)
		{
		}

		// Token: 0x060274E1 RID: 160993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E1")]
		[Address(RVA = "0x227F200", Offset = "0x227DE00", VA = "0x18227F200")]
		private void _RereshWithFocusPage(float pageIndex)
		{
		}

		// Token: 0x060274E2 RID: 160994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E2")]
		[Address(RVA = "0x227F090", Offset = "0x227DC90", VA = "0x18227F090")]
		private void _OnFocusPageChanged(float pageIndex)
		{
		}

		// Token: 0x060274E3 RID: 160995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E3")]
		[Address(RVA = "0x227EF20", Offset = "0x227DB20", VA = "0x18227EF20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060274E4 RID: 160996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E4")]
		[Address(RVA = "0x227F110", Offset = "0x227DD10", VA = "0x18227F110")]
		private void _PlaySwitchAnim(float position)
		{
		}

		// Token: 0x060274E5 RID: 160997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E5")]
		[Address(RVA = "0x227E9B0", Offset = "0x227D5B0", VA = "0x18227E9B0")]
		public void OnItemClick()
		{
		}

		// Token: 0x060274E6 RID: 160998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274E6")]
		[Address(RVA = "0x227F390", Offset = "0x227DF90", VA = "0x18227F390")]
		public ArchiveEndbookEntryItemView()
		{
		}

		// Token: 0x04037A81 RID: 227969
		[Token(Token = "0x4037A81")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _cardImg;

		// Token: 0x04037A82 RID: 227970
		[Token(Token = "0x4037A82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _cardTitleImg;

		// Token: 0x04037A83 RID: 227971
		[Token(Token = "0x4037A83")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x04037A84 RID: 227972
		[Token(Token = "0x4037A84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04037A85 RID: 227973
		[Token(Token = "0x4037A85")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04037A86 RID: 227974
		[Token(Token = "0x4037A86")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _collectSlider;

		// Token: 0x04037A87 RID: 227975
		[Token(Token = "0x4037A87")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelAllCollect;

		// Token: 0x04037A88 RID: 227976
		[Token(Token = "0x4037A88")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _behindLineFrontRect;

		// Token: 0x04037A89 RID: 227977
		[Token(Token = "0x4037A89")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _behindLineBackRect;

		// Token: 0x04037A8A RID: 227978
		[Token(Token = "0x4037A8A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _backCanvasGroup;

		// Token: 0x04037A8B RID: 227979
		[Token(Token = "0x4037A8B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _titleCanvasGroup;

		// Token: 0x04037A8C RID: 227980
		[Token(Token = "0x4037A8C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _circleCanvasGroup;

		// Token: 0x04037A8D RID: 227981
		[Token(Token = "0x4037A8D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _cardCanvasGroup;

		// Token: 0x04037A8E RID: 227982
		[Token(Token = "0x4037A8E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _lockCardCanvasGroup;

		// Token: 0x04037A8F RID: 227983
		[Token(Token = "0x4037A8F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelLeft;

		// Token: 0x04037A90 RID: 227984
		[Token(Token = "0x4037A90")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelRight;

		// Token: 0x04037A91 RID: 227985
		[Token(Token = "0x4037A91")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x04037A92 RID: 227986
		[Token(Token = "0x4037A92")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04037A93 RID: 227987
		[Token(Token = "0x4037A93")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _animDuration;

		// Token: 0x04037A94 RID: 227988
		[Token(Token = "0x4037A94")]
		[FieldOffset(Offset = "0xB8")]
		private Action<int> m_onItemClick;

		// Token: 0x04037A95 RID: 227989
		[Token(Token = "0x4037A95")]
		[FieldOffset(Offset = "0xC0")]
		private int m_cachedIndex;

		// Token: 0x04037A96 RID: 227990
		[Token(Token = "0x4037A96")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_isInited;

		// Token: 0x04037A97 RID: 227991
		[Token(Token = "0x4037A97")]
		[FieldOffset(Offset = "0xC8")]
		private float m_cachedWidth;

		// Token: 0x04037A98 RID: 227992
		[Token(Token = "0x4037A98")]
		[FieldOffset(Offset = "0xD0")]
		private ArchiveEndbookEntryItemView.EndbookSwitchTween m_switchTween;

		// Token: 0x04037A99 RID: 227993
		[Token(Token = "0x4037A99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037A9A RID: 227994
		[Token(Token = "0x4037A9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RereshWithFocusPage;

		// Token: 0x04037A9B RID: 227995
		[Token(Token = "0x4037A9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFocusPageChanged;

		// Token: 0x04037A9C RID: 227996
		[Token(Token = "0x4037A9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037A9D RID: 227997
		[Token(Token = "0x4037A9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnim;

		// Token: 0x04037A9E RID: 227998
		[Token(Token = "0x4037A9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037A9F RID: 227999
		[Token(Token = "0x4037A9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B75 RID: 27509
		[Token(Token = "0x2006B75")]
		public struct Param
		{
			// Token: 0x04037AA0 RID: 228000
			[Token(Token = "0x4037AA0")]
			[FieldOffset(Offset = "0x0")]
			public ArchiveEndbookEntryItemView prefab;

			// Token: 0x04037AA1 RID: 228001
			[Token(Token = "0x4037AA1")]
			[FieldOffset(Offset = "0x8")]
			public Sprite cardSprite;

			// Token: 0x04037AA2 RID: 228002
			[Token(Token = "0x4037AA2")]
			[FieldOffset(Offset = "0x10")]
			public Sprite cardTitleSprite;

			// Token: 0x04037AA3 RID: 228003
			[Token(Token = "0x4037AA3")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClick;

			// Token: 0x04037AA4 RID: 228004
			[Token(Token = "0x4037AA4")]
			[FieldOffset(Offset = "0x20")]
			public bool unlocked;

			// Token: 0x04037AA5 RID: 228005
			[Token(Token = "0x4037AA5")]
			[FieldOffset(Offset = "0x21")]
			public bool hasNew;

			// Token: 0x04037AA6 RID: 228006
			[Token(Token = "0x4037AA6")]
			[FieldOffset(Offset = "0x24")]
			public float collectPercent;

			// Token: 0x04037AA7 RID: 228007
			[Token(Token = "0x4037AA7")]
			[FieldOffset(Offset = "0x28")]
			public int pageIndex;

			// Token: 0x04037AA8 RID: 228008
			[Token(Token = "0x4037AA8")]
			[FieldOffset(Offset = "0x2C")]
			public float focusedPage;

			// Token: 0x04037AA9 RID: 228009
			[Token(Token = "0x4037AA9")]
			[FieldOffset(Offset = "0x30")]
			public bool isLast;
		}

		// Token: 0x02006B76 RID: 27510
		[Token(Token = "0x2006B76")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ArchiveEndbookEntryItemView>
		{
			// Token: 0x060274E7 RID: 160999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274E7")]
			[Address(RVA = "0x228F3F0", Offset = "0x228DFF0", VA = "0x18228F3F0")]
			public VirtualView(ArchiveEndbookEntryItemView.Param param)
			{
			}

			// Token: 0x060274E8 RID: 161000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274E8")]
			[Address(RVA = "0x228EF80", Offset = "0x228DB80", VA = "0x18228EF80", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060274E9 RID: 161001 RVA: 0x000CDFB0 File Offset: 0x000CC1B0
			[Token(Token = "0x60274E9")]
			[Address(RVA = "0x228EFF0", Offset = "0x228DBF0", VA = "0x18228EFF0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060274EA RID: 161002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274EA")]
			[Address(RVA = "0x228F1F0", Offset = "0x228DDF0", VA = "0x18228F1F0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060274EB RID: 161003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274EB")]
			[Address(RVA = "0x228F2A0", Offset = "0x228DEA0", VA = "0x18228F2A0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060274EC RID: 161004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274EC")]
			[Address(RVA = "0x228F300", Offset = "0x228DF00", VA = "0x18228F300")]
			public void UpdateFocusPage(float pageIndex)
			{
			}

			// Token: 0x060274ED RID: 161005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274ED")]
			[Address(RVA = "0x228F0C0", Offset = "0x228DCC0", VA = "0x18228F0C0")]
			public void OnFocusPageChange(float pageIndex)
			{
			}

			// Token: 0x04037AAA RID: 228010
			[Token(Token = "0x4037AAA")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveEndbookEntryItemView.Param m_param;

			// Token: 0x04037AAB RID: 228011
			[Token(Token = "0x4037AAB")]
			[FieldOffset(Offset = "0x58")]
			private float m_curFocusPage;

			// Token: 0x04037AAC RID: 228012
			[Token(Token = "0x4037AAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037AAD RID: 228013
			[Token(Token = "0x4037AAD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04037AAE RID: 228014
			[Token(Token = "0x4037AAE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04037AAF RID: 228015
			[Token(Token = "0x4037AAF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04037AB0 RID: 228016
			[Token(Token = "0x4037AB0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04037AB1 RID: 228017
			[Token(Token = "0x4037AB1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateFocusPage;

			// Token: 0x04037AB2 RID: 228018
			[Token(Token = "0x4037AB2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnFocusPageChange;
		}

		// Token: 0x02006B77 RID: 27511
		[Token(Token = "0x2006B77")]
		public class EndbookSwitchTween : UISwitchTween
		{
			// Token: 0x060274EE RID: 161006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274EE")]
			[Address(RVA = "0x228AF70", Offset = "0x2289B70", VA = "0x18228AF70")]
			public EndbookSwitchTween(ArchiveEndbookEntryItemView closure)
			{
			}

			// Token: 0x060274EF RID: 161007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274EF")]
			[Address(RVA = "0x228AC30", Offset = "0x2289830", VA = "0x18228AC30", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060274F0 RID: 161008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274F0")]
			[Address(RVA = "0x228AAC0", Offset = "0x22896C0", VA = "0x18228AAC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060274F1 RID: 161009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274F1")]
			[Address(RVA = "0x228ADB0", Offset = "0x22899B0", VA = "0x18228ADB0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060274F2 RID: 161010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274F2")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04037AB3 RID: 228019
			[Token(Token = "0x4037AB3")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveEndbookEntryItemView m_closure;

			// Token: 0x04037AB4 RID: 228020
			[Token(Token = "0x4037AB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037AB5 RID: 228021
			[Token(Token = "0x4037AB5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037AB6 RID: 228022
			[Token(Token = "0x4037AB6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037AB7 RID: 228023
			[Token(Token = "0x4037AB7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
