using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A61 RID: 27233
	[Token(Token = "0x2006A61")]
	public class StageMixStoryStorylineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x06026EBD RID: 159421 RVA: 0x000CCBB8 File Offset: 0x000CADB8
		[Token(Token = "0x17005BC3")]
		public UIAnimationLocation focusAnimation
		{
			[Token(Token = "0x6026EBD")]
			[Address(RVA = "0x22260B0", Offset = "0x2224CB0", VA = "0x1822260B0")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x06026EBE RID: 159422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EBE")]
		[Address(RVA = "0x22253A0", Offset = "0x2223FA0", VA = "0x1822253A0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06026EBF RID: 159423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EBF")]
		[Address(RVA = "0x2225620", Offset = "0x2224220", VA = "0x182225620")]
		private void _Render(StageStorylineViewModel model, StageMixStoryStorylineItemSyncHandler handler)
		{
		}

		// Token: 0x06026EC0 RID: 159424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EC0")]
		[Address(RVA = "0x2225520", Offset = "0x2224120", VA = "0x182225520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026EC1 RID: 159425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EC1")]
		[Address(RVA = "0x2225AE0", Offset = "0x22246E0", VA = "0x182225AE0")]
		private void _UpdateFocusState(StageStorylineViewModel model, StageMixStoryStorylineItemSyncHandler handler)
		{
		}

		// Token: 0x06026EC2 RID: 159426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EC2")]
		[Address(RVA = "0x2225ED0", Offset = "0x2224AD0", VA = "0x182225ED0")]
		private void _UpdateTrackPointState(StageStorylineViewModel model)
		{
		}

		// Token: 0x06026EC3 RID: 159427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EC3")]
		[Address(RVA = "0x2226050", Offset = "0x2224C50", VA = "0x182226050")]
		public StageMixStoryStorylineView()
		{
		}

		// Token: 0x040370D0 RID: 225488
		[Token(Token = "0x40370D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _mainlinePanel;

		// Token: 0x040370D1 RID: 225489
		[Token(Token = "0x40370D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _otherPanel;

		// Token: 0x040370D2 RID: 225490
		[Token(Token = "0x40370D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _logoImage;

		// Token: 0x040370D3 RID: 225491
		[Token(Token = "0x40370D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIDynImage _abbrIconImage;

		// Token: 0x040370D4 RID: 225492
		[Token(Token = "0x40370D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Text> _nameTexts;

		// Token: 0x040370D5 RID: 225493
		[Token(Token = "0x40370D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _trackPointHolder;

		// Token: 0x040370D6 RID: 225494
		[Token(Token = "0x40370D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _size;

		// Token: 0x040370D7 RID: 225495
		[Token(Token = "0x40370D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _focusAnimation;

		// Token: 0x040370D8 RID: 225496
		[Token(Token = "0x40370D8")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_finder;

		// Token: 0x040370D9 RID: 225497
		[Token(Token = "0x40370D9")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x040370DA RID: 225498
		[Token(Token = "0x40370DA")]
		[FieldOffset(Offset = "0x78")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x040370DB RID: 225499
		[Token(Token = "0x40370DB")]
		[FieldOffset(Offset = "0x80")]
		private AnimationWrapper m_wrapper;

		// Token: 0x040370DC RID: 225500
		[Token(Token = "0x40370DC")]
		[FieldOffset(Offset = "0x88")]
		private float m_focusDuration;

		// Token: 0x040370DD RID: 225501
		[Token(Token = "0x40370DD")]
		[FieldOffset(Offset = "0x90")]
		private UIAnimationTween m_focusTween;

		// Token: 0x040370DE RID: 225502
		[Token(Token = "0x40370DE")]
		[FieldOffset(Offset = "0x98")]
		private GameObject m_focusEffectInstance;

		// Token: 0x040370DF RID: 225503
		[Token(Token = "0x40370DF")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_trackPoint;

		// Token: 0x040370E0 RID: 225504
		[Token(Token = "0x40370E0")]
		[FieldOffset(Offset = "0xA8")]
		private StageStorylineViewModel m_cachedModel;

		// Token: 0x040370E1 RID: 225505
		[Token(Token = "0x40370E1")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_focused;

		// Token: 0x040370E2 RID: 225506
		[Token(Token = "0x40370E2")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedLogoId;

		// Token: 0x040370E3 RID: 225507
		[Token(Token = "0x40370E3")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedAbbrIconId;

		// Token: 0x040370E4 RID: 225508
		[Token(Token = "0x40370E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusAnimation;

		// Token: 0x040370E5 RID: 225509
		[Token(Token = "0x40370E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x040370E6 RID: 225510
		[Token(Token = "0x40370E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040370E7 RID: 225511
		[Token(Token = "0x40370E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040370E8 RID: 225512
		[Token(Token = "0x40370E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateFocusState;

		// Token: 0x040370E9 RID: 225513
		[Token(Token = "0x40370E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTrackPointState;

		// Token: 0x040370EA RID: 225514
		[Token(Token = "0x40370EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A62 RID: 27234
		[Token(Token = "0x2006A62")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<StageMixStoryStorylineView>
		{
			// Token: 0x06026EC4 RID: 159428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026EC4")]
			[Address(RVA = "0x22309A0", Offset = "0x222F5A0", VA = "0x1822309A0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06026EC5 RID: 159429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026EC5")]
			[Address(RVA = "0x2230A30", Offset = "0x222F630", VA = "0x182230A30", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06026EC6 RID: 159430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026EC6")]
			[Address(RVA = "0x2230560", Offset = "0x222F160", VA = "0x182230560", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06026EC7 RID: 159431 RVA: 0x000CCBD0 File Offset: 0x000CADD0
			[Token(Token = "0x6026EC7")]
			[Address(RVA = "0x2230720", Offset = "0x222F320", VA = "0x182230720", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06026EC8 RID: 159432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026EC8")]
			[Address(RVA = "0x2230B70", Offset = "0x222F770", VA = "0x182230B70")]
			public VirtualView()
			{
			}

			// Token: 0x040370EB RID: 225515
			[Token(Token = "0x40370EB")]
			[FieldOffset(Offset = "0x20")]
			public StageMixStoryStorylineView prefab;

			// Token: 0x040370EC RID: 225516
			[Token(Token = "0x40370EC")]
			[FieldOffset(Offset = "0x28")]
			public StageStorylineViewModel model;

			// Token: 0x040370ED RID: 225517
			[Token(Token = "0x40370ED")]
			[FieldOffset(Offset = "0x30")]
			public StageMixStoryStorylineItemSyncHandler handler;

			// Token: 0x040370EE RID: 225518
			[Token(Token = "0x40370EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040370EF RID: 225519
			[Token(Token = "0x40370EF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x040370F0 RID: 225520
			[Token(Token = "0x40370F0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040370F1 RID: 225521
			[Token(Token = "0x40370F1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x040370F2 RID: 225522
			[Token(Token = "0x40370F2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
