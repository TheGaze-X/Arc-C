using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B2D RID: 27437
	[Token(Token = "0x2006B2D")]
	public class ArchiveChallengeBookListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x06027382 RID: 160642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027383 RID: 160643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CAD")]
		public ArchiveChallengeBookController controller
		{
			[Token(Token = "0x6027382")]
			[Address(RVA = "0x2267900", Offset = "0x2266500", VA = "0x182267900")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027383")]
			[Address(RVA = "0x2267960", Offset = "0x2266560", VA = "0x182267960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027384 RID: 160644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027384")]
		[Address(RVA = "0x22673D0", Offset = "0x2265FD0", VA = "0x1822673D0")]
		public void ItemClickEvent()
		{
		}

		// Token: 0x06027385 RID: 160645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027385")]
		[Address(RVA = "0x2267500", Offset = "0x2266100", VA = "0x182267500")]
		public void Render(ChallengeBookItemModel itemModel, bool selected, bool showSwitchTween)
		{
		}

		// Token: 0x06027386 RID: 160646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027386")]
		[Address(RVA = "0x22677A0", Offset = "0x22663A0", VA = "0x1822677A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027387 RID: 160647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027387")]
		[Address(RVA = "0x22678A0", Offset = "0x22664A0", VA = "0x1822678A0")]
		public ArchiveChallengeBookListItemView()
		{
		}

		// Token: 0x040377DC RID: 227292
		[Token(Token = "0x40377DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _nameTexts;

		// Token: 0x040377DD RID: 227293
		[Token(Token = "0x40377DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x040377DE RID: 227294
		[Token(Token = "0x40377DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x040377DF RID: 227295
		[Token(Token = "0x40377DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x040377E0 RID: 227296
		[Token(Token = "0x40377E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x040377E1 RID: 227297
		[Token(Token = "0x40377E1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _unselectedGroup;

		// Token: 0x040377E2 RID: 227298
		[Token(Token = "0x40377E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x040377E3 RID: 227299
		[Token(Token = "0x40377E3")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040377E4 RID: 227300
		[Token(Token = "0x40377E4")]
		[FieldOffset(Offset = "0x58")]
		private ArchiveChallengeBookListItemView.ArchiveChallengeBookListItemSwitchTween m_switchTween;

		// Token: 0x040377E5 RID: 227301
		[Token(Token = "0x40377E5")]
		[FieldOffset(Offset = "0x60")]
		private ChallengeBookItemModel m_cachedItem;

		// Token: 0x040377E7 RID: 227303
		[Token(Token = "0x40377E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040377E8 RID: 227304
		[Token(Token = "0x40377E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040377E9 RID: 227305
		[Token(Token = "0x40377E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ItemClickEvent;

		// Token: 0x040377EA RID: 227306
		[Token(Token = "0x40377EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040377EB RID: 227307
		[Token(Token = "0x40377EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040377EC RID: 227308
		[Token(Token = "0x40377EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B2E RID: 27438
		[Token(Token = "0x2006B2E")]
		private class ArchiveChallengeBookListItemSwitchTween : UISwitchTween
		{
			// Token: 0x06027388 RID: 160648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027388")]
			[Address(RVA = "0x2267350", Offset = "0x2265F50", VA = "0x182267350")]
			public ArchiveChallengeBookListItemSwitchTween(ArchiveChallengeBookListItemView closure)
			{
			}

			// Token: 0x06027389 RID: 160649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027389")]
			[Address(RVA = "0x2266DB0", Offset = "0x22659B0", VA = "0x182266DB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602738A RID: 160650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602738A")]
			[Address(RVA = "0x2266F60", Offset = "0x2265B60", VA = "0x182266F60", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602738B RID: 160651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602738B")]
			[Address(RVA = "0x2267190", Offset = "0x2265D90", VA = "0x182267190", Slot = "10")]
			protected override void ResetToState(bool show)
			{
			}

			// Token: 0x06027390 RID: 160656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027390")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040377ED RID: 227309
			[Token(Token = "0x40377ED")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveChallengeBookListItemView m_closure;

			// Token: 0x040377EE RID: 227310
			[Token(Token = "0x40377EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040377EF RID: 227311
			[Token(Token = "0x40377EF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040377F0 RID: 227312
			[Token(Token = "0x40377F0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040377F1 RID: 227313
			[Token(Token = "0x40377F1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
