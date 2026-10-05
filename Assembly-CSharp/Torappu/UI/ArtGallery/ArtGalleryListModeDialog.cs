using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200660C RID: 26124
	[Token(Token = "0x200660C")]
	public class ArtGalleryListModeDialog<TGroupSetViewModel> : UICompDialog<ArtGalleryDisplayTabDialogCommonInput> where TGroupSetViewModel : IArtGalleryListModeGroupSetViewModel, new()
	{
		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x0602586D RID: 153709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058A1")]
		protected ArtGalleryListModeListView listView
		{
			[Token(Token = "0x602586D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x0602586E RID: 153710 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602586F RID: 153711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058A2")]
		protected TGroupSetViewModel cachedViewModel
		{
			[Token(Token = "0x602586E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602586F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x06025870 RID: 153712 RVA: 0x000C81C0 File Offset: 0x000C63C0
		// (set) Token: 0x06025871 RID: 153713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058A3")]
		protected IArtGalleryListModeGroupSetViewModel.GroupViewModelInput cachedGroupViewModelInput
		{
			[Token(Token = "0x6025870")]
			[CompilerGenerated]
			get
			{
				return default(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput);
			}
			[Token(Token = "0x6025871")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025872 RID: 153714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025872")]
		protected override void OnRender(ArtGalleryDisplayTabDialogCommonInput input)
		{
		}

		// Token: 0x06025873 RID: 153715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025873")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06025874 RID: 153716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025874")]
		protected void RenderListView(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput, ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam, bool forceRebuild = false)
		{
		}

		// Token: 0x06025875 RID: 153717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025875")]
		protected void TryUpdateListView(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput)
		{
		}

		// Token: 0x06025876 RID: 153718 RVA: 0x000C81D8 File Offset: 0x000C63D8
		[Token(Token = "0x6025876")]
		protected virtual bool CheckIsNeedRefreshList(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput)
		{
			return default(bool);
		}

		// Token: 0x06025877 RID: 153719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025877")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025878 RID: 153720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025878")]
		public ArtGalleryListModeDialog()
		{
		}

		// Token: 0x04034B62 RID: 215906
		[Token(Token = "0x4034B62")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ArtGalleryListModeListView _listView;

		// Token: 0x04034B63 RID: 215907
		[Token(Token = "0x4034B63")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIAnimationLocation _entryAnimationLocation;

		// Token: 0x04034B64 RID: 215908
		[Token(Token = "0x4034B64")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIAnimationLocation _leaveAnimationLocation;

		// Token: 0x04034B67 RID: 215911
		[Token(Token = "0x4034B67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_listView;

		// Token: 0x04034B68 RID: 215912
		[Token(Token = "0x4034B68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedViewModel;

		// Token: 0x04034B69 RID: 215913
		[Token(Token = "0x4034B69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_cachedViewModel;

		// Token: 0x04034B6A RID: 215914
		[Token(Token = "0x4034B6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedGroupViewModelInput;

		// Token: 0x04034B6B RID: 215915
		[Token(Token = "0x4034B6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_cachedGroupViewModelInput;

		// Token: 0x04034B6C RID: 215916
		[Token(Token = "0x4034B6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04034B6D RID: 215917
		[Token(Token = "0x4034B6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04034B6E RID: 215918
		[Token(Token = "0x4034B6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderListView;

		// Token: 0x04034B6F RID: 215919
		[Token(Token = "0x4034B6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryUpdateListView;

		// Token: 0x04034B70 RID: 215920
		[Token(Token = "0x4034B70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIsNeedRefreshList;

		// Token: 0x04034B71 RID: 215921
		[Token(Token = "0x4034B71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034B72 RID: 215922
		[Token(Token = "0x4034B72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200660D RID: 26125
		[Token(Token = "0x200660D")]
		private class ArtGalleryDialogSwitchTween : UISwitchTween
		{
			// Token: 0x06025879 RID: 153721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025879")]
			public ArtGalleryDialogSwitchTween(UIAnimationLocation entryAnimationLocation, UIAnimationLocation leaveAnimationLocation)
			{
			}

			// Token: 0x0602587A RID: 153722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602587A")]
			private UIAnimationTween _GenAnimationTween(UIAnimationLocation animationLocation)
			{
				return null;
			}

			// Token: 0x0602587B RID: 153723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602587B")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602587C RID: 153724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602587C")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x04034B73 RID: 215923
			[Token(Token = "0x4034B73")]
			[FieldOffset(Offset = "0x0")]
			private UIAnimationLocation m_entryAnimationLocation;

			// Token: 0x04034B74 RID: 215924
			[Token(Token = "0x4034B74")]
			[FieldOffset(Offset = "0x0")]
			private UIAnimationLocation m_leaveAnimationLocation;

			// Token: 0x04034B75 RID: 215925
			[Token(Token = "0x4034B75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034B76 RID: 215926
			[Token(Token = "0x4034B76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__GenAnimationTween;

			// Token: 0x04034B77 RID: 215927
			[Token(Token = "0x4034B77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04034B78 RID: 215928
			[Token(Token = "0x4034B78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
