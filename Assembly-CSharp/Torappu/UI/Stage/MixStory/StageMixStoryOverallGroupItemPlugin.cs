using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A69 RID: 27241
	[Token(Token = "0x2006A69")]
	public abstract class StageMixStoryOverallGroupItemPlugin : MonoBehaviour, IHotfixable, IStageMixStoryStorySetPlugin, IStageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x06026EDD RID: 159453
		[Token(Token = "0x17005BC9")]
		public abstract StageMixStoryOverallView.OverallDisplayFeature presentingFeature { [Token(Token = "0x6026EDD")] get; }

		// Token: 0x06026EDE RID: 159454
		[Token(Token = "0x6026EDE")]
		public abstract bool IsValid(StageStorylineStorySetViewModel model);

		// Token: 0x06026EDF RID: 159455
		[Token(Token = "0x6026EDF")]
		public abstract void Render(StageStorylineStorySetViewModel model);

		// Token: 0x06026EE0 RID: 159456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EE0")]
		[Address(RVA = "0x2223220", Offset = "0x2221E20", VA = "0x182223220")]
		protected StageMixStoryOverallGroupItemPlugin()
		{
		}

		// Token: 0x04037111 RID: 225553
		[Token(Token = "0x4037111")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
