using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006AA1 RID: 27297
	[Token(Token = "0x2006AA1")]
	public class StageMixStoryStorySetKvIconView : StageMixStoryStorySetCommonIconView
	{
		// Token: 0x060270C8 RID: 159944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270C8")]
		[Address(RVA = "0x2245440", Offset = "0x2244040", VA = "0x182245440", Slot = "4")]
		protected override string _GetIconId(StageStorylineStorySetViewModel storySet)
		{
			return null;
		}

		// Token: 0x060270C9 RID: 159945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270C9")]
		[Address(RVA = "0x22454C0", Offset = "0x22440C0", VA = "0x1822454C0", Slot = "5")]
		protected override string _LoadSpritePath(ILoadAsset assets, string iconId)
		{
			return null;
		}

		// Token: 0x060270CA RID: 159946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270CA")]
		[Address(RVA = "0x2245560", Offset = "0x2244160", VA = "0x182245560")]
		public StageMixStoryStorySetKvIconView()
		{
		}

		// Token: 0x0403742F RID: 226351
		[Token(Token = "0x403742F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIconId;

		// Token: 0x04037430 RID: 226352
		[Token(Token = "0x4037430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSpritePath;

		// Token: 0x04037431 RID: 226353
		[Token(Token = "0x4037431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
