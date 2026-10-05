using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6E RID: 27246
	[Token(Token = "0x2006A6E")]
	public class StageMixStoryStorylineItemLastVisitedPlugin : StageMixStoryStorylineItemPlugin
	{
		// Token: 0x06026EF0 RID: 159472 RVA: 0x000CCD50 File Offset: 0x000CAF50
		[Token(Token = "0x6026EF0")]
		[Address(RVA = "0x2224570", Offset = "0x2223170", VA = "0x182224570", Slot = "6")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EF1 RID: 159473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EF1")]
		[Address(RVA = "0x22245F0", Offset = "0x22231F0", VA = "0x1822245F0", Slot = "7")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EF2 RID: 159474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EF2")]
		[Address(RVA = "0x2224650", Offset = "0x2223250", VA = "0x182224650")]
		public StageMixStoryStorylineItemLastVisitedPlugin()
		{
		}

		// Token: 0x0403712C RID: 225580
		[Token(Token = "0x403712C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403712D RID: 225581
		[Token(Token = "0x403712D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403712E RID: 225582
		[Token(Token = "0x403712E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
