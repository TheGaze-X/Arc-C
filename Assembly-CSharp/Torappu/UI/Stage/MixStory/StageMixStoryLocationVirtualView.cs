using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A58 RID: 27224
	[Token(Token = "0x2006A58")]
	public abstract class StageMixStoryLocationVirtualView<ViewType, ViewModel> : UIRecycleLayoutAdapter.VirtualView<ViewType> where ViewType : StageMixStoryLocationItem<ViewModel> where ViewModel : StageStorylineLocationViewModel
	{
		// Token: 0x06026E80 RID: 159360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E80")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x06026E81 RID: 159361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E81")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x06026E82 RID: 159362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E82")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x06026E83 RID: 159363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E83")]
		protected StageMixStoryLocationVirtualView()
		{
		}

		// Token: 0x04037070 RID: 225392
		[Token(Token = "0x4037070")]
		[FieldOffset(Offset = "0x0")]
		public ViewType singleView;

		// Token: 0x04037071 RID: 225393
		[Token(Token = "0x4037071")]
		[FieldOffset(Offset = "0x0")]
		public ViewModel viewModel;

		// Token: 0x04037072 RID: 225394
		[Token(Token = "0x4037072")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04037073 RID: 225395
		[Token(Token = "0x4037073")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04037074 RID: 225396
		[Token(Token = "0x4037074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04037075 RID: 225397
		[Token(Token = "0x4037075")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
