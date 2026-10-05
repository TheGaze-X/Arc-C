using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B04 RID: 27396
	[Token(Token = "0x2006B04")]
	public class ArchiveListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060272BE RID: 160446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272BE")]
		[Address(RVA = "0x2258550", Offset = "0x2257150", VA = "0x182258550")]
		public void SetTitleSprite(Sprite sprite)
		{
		}

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x060272BF RID: 160447 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060272C0 RID: 160448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C94")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60272BF")]
			[Address(RVA = "0x2258670", Offset = "0x2257270", VA = "0x182258670")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60272C0")]
			[Address(RVA = "0x22586D0", Offset = "0x22572D0", VA = "0x1822586D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060272C1 RID: 160449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272C1")]
		[Address(RVA = "0x2258250", Offset = "0x2256E50", VA = "0x182258250")]
		public void Render(string selectedItem, ArchiveItemModel itemModel, bool isInit)
		{
		}

		// Token: 0x060272C2 RID: 160450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272C2")]
		[Address(RVA = "0x2258100", Offset = "0x2256D00", VA = "0x182258100")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x060272C3 RID: 160451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272C3")]
		[Address(RVA = "0x2258610", Offset = "0x2257210", VA = "0x182258610")]
		public ArchiveListItemView()
		{
		}

		// Token: 0x0403768E RID: 226958
		[Token(Token = "0x403768E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Item Nodes")]
		private Image _nodeCurrent;

		// Token: 0x0403768F RID: 226959
		[Token(Token = "0x403768F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Item Nodes")]
		private Image _nodeCurrentArray;

		// Token: 0x04037690 RID: 226960
		[Token(Token = "0x4037690")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Item Nodes")]
		private GameObject _nodeNew;

		// Token: 0x04037691 RID: 226961
		[Token(Token = "0x4037691")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector2 _nodeCurrentArrayStartPos;

		// Token: 0x04037692 RID: 226962
		[Token(Token = "0x4037692")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector2 _nodeCurrentArrayEndPos;

		// Token: 0x04037693 RID: 226963
		[Token(Token = "0x4037693")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector3 _nodeCurrentStartScale;

		// Token: 0x04037694 RID: 226964
		[Token(Token = "0x4037694")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Canvas Groups")]
		private CanvasGroup _currNodeCanvasGroup;

		// Token: 0x04037695 RID: 226965
		[Token(Token = "0x4037695")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Canvas Groups")]
		private CanvasGroup _imgTitleNormalCanvasGroup;

		// Token: 0x04037696 RID: 226966
		[Token(Token = "0x4037696")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Canvas Groups")]
		private CanvasGroup _textTitleCanvasGroup;

		// Token: 0x04037697 RID: 226967
		[Token(Token = "0x4037697")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Image Title")]
		private Image _imgTitleNormal;

		// Token: 0x04037698 RID: 226968
		[Token(Token = "0x4037698")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Image Title")]
		private Image _imgTitleLocked;

		// Token: 0x04037699 RID: 226969
		[Token(Token = "0x4037699")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0403769A RID: 226970
		[Token(Token = "0x403769A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _picSelectBtn;

		// Token: 0x0403769B RID: 226971
		[Token(Token = "0x403769B")]
		[FieldOffset(Offset = "0x88")]
		private ArchiveItemModel m_cachedModel;

		// Token: 0x0403769C RID: 226972
		[Token(Token = "0x403769C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isFocus;

		// Token: 0x0403769D RID: 226973
		[Token(Token = "0x403769D")]
		[FieldOffset(Offset = "0x98")]
		private Sequence m_sequence;

		// Token: 0x0403769E RID: 226974
		[Token(Token = "0x403769E")]
		[FieldOffset(Offset = "0xA0")]
		private ArchiveListItemView.ArchiveListItemSwitchTween m_switchTween;

		// Token: 0x040376A0 RID: 226976
		[Token(Token = "0x40376A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetTitleSprite;

		// Token: 0x040376A1 RID: 226977
		[Token(Token = "0x40376A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040376A2 RID: 226978
		[Token(Token = "0x40376A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040376A3 RID: 226979
		[Token(Token = "0x40376A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040376A4 RID: 226980
		[Token(Token = "0x40376A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x040376A5 RID: 226981
		[Token(Token = "0x40376A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B05 RID: 27397
		[Token(Token = "0x2006B05")]
		private class ArchiveListItemSwitchTween : UISwitchTween
		{
			// Token: 0x060272C4 RID: 160452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272C4")]
			[Address(RVA = "0x2258080", Offset = "0x2256C80", VA = "0x182258080")]
			public ArchiveListItemSwitchTween(ArchiveListItemView closure)
			{
			}

			// Token: 0x060272C5 RID: 160453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60272C5")]
			[Address(RVA = "0x2257C40", Offset = "0x2256840", VA = "0x182257C40")]
			private Sequence _GenerateSequence(bool isFocus)
			{
				return null;
			}

			// Token: 0x060272C6 RID: 160454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60272C6")]
			[Address(RVA = "0x22577F0", Offset = "0x22563F0", VA = "0x1822577F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060272C7 RID: 160455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60272C7")]
			[Address(RVA = "0x2257890", Offset = "0x2256490", VA = "0x182257890", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060272C8 RID: 160456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272C8")]
			[Address(RVA = "0x22576B0", Offset = "0x22562B0", VA = "0x1822576B0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x060272C9 RID: 160457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272C9")]
			[Address(RVA = "0x2257750", Offset = "0x2256350", VA = "0x182257750", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x060272CA RID: 160458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272CA")]
			[Address(RVA = "0x2257930", Offset = "0x2256530", VA = "0x182257930", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060272CB RID: 160459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272CB")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x060272CC RID: 160460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272CC")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x060272CD RID: 160461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272CD")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040376A6 RID: 226982
			[Token(Token = "0x40376A6")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveListItemView m_closure;

			// Token: 0x040376A7 RID: 226983
			[Token(Token = "0x40376A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040376A8 RID: 226984
			[Token(Token = "0x40376A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GenerateSequence;

			// Token: 0x040376A9 RID: 226985
			[Token(Token = "0x40376A9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040376AA RID: 226986
			[Token(Token = "0x40376AA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040376AB RID: 226987
			[Token(Token = "0x40376AB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040376AC RID: 226988
			[Token(Token = "0x40376AC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x040376AD RID: 226989
			[Token(Token = "0x40376AD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
