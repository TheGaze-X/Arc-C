using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A59 RID: 27225
	[Token(Token = "0x2006A59")]
	public abstract class StageMixStoryLocationItem<ViewModel> : MonoBehaviour, IHotfixable where ViewModel : StageStorylineLocationViewModel
	{
		// Token: 0x06026E84 RID: 159364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E84")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026E85 RID: 159365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E85")]
		public virtual void OnSetInfo(ViewModel locationViewModel)
		{
		}

		// Token: 0x06026E86 RID: 159366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E86")]
		protected StageMixStoryLocationItem()
		{
		}

		// Token: 0x04037076 RID: 225398
		[Token(Token = "0x4037076")]
		[FieldOffset(Offset = "0x0")]
		protected ILoadAsset assets;

		// Token: 0x04037077 RID: 225399
		[Token(Token = "0x4037077")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037078 RID: 225400
		[Token(Token = "0x4037078")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSetInfo;

		// Token: 0x04037079 RID: 225401
		[Token(Token = "0x4037079")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
