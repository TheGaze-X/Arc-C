using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A5A RID: 27226
	[Token(Token = "0x2006A5A")]
	public class StageMixStoryMainlineSplitView : StageMixStoryLocationItem<StageStorylineMainlineSplitLocationViewModel>
	{
		// Token: 0x06026E87 RID: 159367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E87")]
		[Address(RVA = "0x2222120", Offset = "0x2220D20", VA = "0x182222120", Slot = "4")]
		public override void OnSetInfo(StageStorylineMainlineSplitLocationViewModel splitLocation)
		{
		}

		// Token: 0x06026E88 RID: 159368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E88")]
		[Address(RVA = "0x2222320", Offset = "0x2220F20", VA = "0x182222320")]
		private void _Render(StageStorylineMainlineSplitLocationViewModel splitLocation)
		{
		}

		// Token: 0x06026E89 RID: 159369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E89")]
		[Address(RVA = "0x22224D0", Offset = "0x22210D0", VA = "0x1822224D0")]
		public StageMixStoryMainlineSplitView()
		{
		}

		// Token: 0x0403707A RID: 225402
		[Token(Token = "0x403707A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDynImage _splitIconImage;

		// Token: 0x0403707B RID: 225403
		[Token(Token = "0x403707B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _splitSubNameText;

		// Token: 0x0403707C RID: 225404
		[Token(Token = "0x403707C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _width;

		// Token: 0x0403707D RID: 225405
		[Token(Token = "0x403707D")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedSplitIconId;

		// Token: 0x0403707E RID: 225406
		[Token(Token = "0x403707E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSetInfo;

		// Token: 0x0403707F RID: 225407
		[Token(Token = "0x403707F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04037080 RID: 225408
		[Token(Token = "0x4037080")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A5B RID: 27227
		[Token(Token = "0x2006A5B")]
		public class VirtualView : StageMixStoryLocationVirtualView<StageMixStoryMainlineSplitView, StageStorylineMainlineSplitLocationViewModel>
		{
			// Token: 0x06026E8A RID: 159370 RVA: 0x000CCA50 File Offset: 0x000CAC50
			[Token(Token = "0x6026E8A")]
			[Address(RVA = "0x2230790", Offset = "0x222F390", VA = "0x182230790", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06026E8B RID: 159371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E8B")]
			[Address(RVA = "0x2230BE0", Offset = "0x222F7E0", VA = "0x182230BE0")]
			public VirtualView()
			{
			}

			// Token: 0x04037081 RID: 225409
			[Token(Token = "0x4037081")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04037082 RID: 225410
			[Token(Token = "0x4037082")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
