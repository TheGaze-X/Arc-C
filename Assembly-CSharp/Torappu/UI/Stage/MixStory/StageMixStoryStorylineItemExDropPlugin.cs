using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6D RID: 27245
	[Token(Token = "0x2006A6D")]
	public class StageMixStoryStorylineItemExDropPlugin : StageMixStoryStorylineItemPlugin
	{
		// Token: 0x06026EED RID: 159469 RVA: 0x000CCD38 File Offset: 0x000CAF38
		[Token(Token = "0x6026EED")]
		[Address(RVA = "0x2224290", Offset = "0x2222E90", VA = "0x182224290", Slot = "6")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EEE RID: 159470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EEE")]
		[Address(RVA = "0x2224330", Offset = "0x2222F30", VA = "0x182224330", Slot = "7")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EEF RID: 159471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EEF")]
		[Address(RVA = "0x22244D0", Offset = "0x22230D0", VA = "0x1822244D0")]
		public StageMixStoryStorylineItemExDropPlugin()
		{
		}

		// Token: 0x04037127 RID: 225575
		[Token(Token = "0x4037127")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _exDropColor;

		// Token: 0x04037128 RID: 225576
		[Token(Token = "0x4037128")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedExDropGroupId;

		// Token: 0x04037129 RID: 225577
		[Token(Token = "0x4037129")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403712A RID: 225578
		[Token(Token = "0x403712A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403712B RID: 225579
		[Token(Token = "0x403712B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
