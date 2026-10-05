using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200692D RID: 26925
	[Token(Token = "0x200692D")]
	public abstract class StageRewardPreviewPluginView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x06026902 RID: 157954 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026903 RID: 157955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B0C")]
		public Action onRewardDetail
		{
			[Token(Token = "0x6026902")]
			[Address(RVA = "0x21B72D0", Offset = "0x21B5ED0", VA = "0x1821B72D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026903")]
			[Address(RVA = "0x21B7330", Offset = "0x21B5F30", VA = "0x1821B7330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026904 RID: 157956
		[Token(Token = "0x6026904")]
		public abstract void Render(StageViewModel selectedStage);

		// Token: 0x06026905 RID: 157957
		[Token(Token = "0x6026905")]
		public abstract void Dispose();

		// Token: 0x06026906 RID: 157958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026906")]
		[Address(RVA = "0x21B7160", Offset = "0x21B5D60", VA = "0x1821B7160")]
		public void EventOnRewardDetail()
		{
		}

		// Token: 0x06026907 RID: 157959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026907")]
		[Address(RVA = "0x21B7270", Offset = "0x21B5E70", VA = "0x1821B7270")]
		protected StageRewardPreviewPluginView()
		{
		}

		// Token: 0x04036641 RID: 222785
		[Token(Token = "0x4036641")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRewardDetail;

		// Token: 0x04036642 RID: 222786
		[Token(Token = "0x4036642")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRewardDetail;

		// Token: 0x04036643 RID: 222787
		[Token(Token = "0x4036643")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRewardDetail;

		// Token: 0x04036644 RID: 222788
		[Token(Token = "0x4036644")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
