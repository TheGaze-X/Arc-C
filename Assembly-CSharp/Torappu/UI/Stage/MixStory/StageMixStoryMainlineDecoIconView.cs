using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A8C RID: 27276
	[Token(Token = "0x2006A8C")]
	public class StageMixStoryMainlineDecoIconView : StageMixStoryStorySetCommonIconView
	{
		// Token: 0x0602706D RID: 159853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602706D")]
		[Address(RVA = "0x223FCC0", Offset = "0x223E8C0", VA = "0x18223FCC0", Slot = "4")]
		protected override string _GetIconId(StageStorylineStorySetViewModel storySet)
		{
			return null;
		}

		// Token: 0x0602706E RID: 159854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602706E")]
		[Address(RVA = "0x223FDD0", Offset = "0x223E9D0", VA = "0x18223FDD0", Slot = "5")]
		protected override string _LoadSpritePath(ILoadAsset assets, string iconId)
		{
			return null;
		}

		// Token: 0x0602706F RID: 159855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602706F")]
		[Address(RVA = "0x223FE70", Offset = "0x223EA70", VA = "0x18223FE70")]
		public StageMixStoryMainlineDecoIconView()
		{
		}

		// Token: 0x0403736B RID: 226155
		[Token(Token = "0x403736B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIconId;

		// Token: 0x0403736C RID: 226156
		[Token(Token = "0x403736C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSpritePath;

		// Token: 0x0403736D RID: 226157
		[Token(Token = "0x403736D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
