using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A71 RID: 27249
	[Token(Token = "0x2006A71")]
	public class StageMixStoryStorylineItemTrackPointPlugin : StageMixStoryStorylineItemPlugin
	{
		// Token: 0x06026EF9 RID: 159481 RVA: 0x000CCD80 File Offset: 0x000CAF80
		[Token(Token = "0x6026EF9")]
		[Address(RVA = "0x2225150", Offset = "0x2223D50", VA = "0x182225150", Slot = "6")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EFA RID: 159482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EFA")]
		[Address(RVA = "0x22251D0", Offset = "0x2223DD0", VA = "0x1822251D0", Slot = "7")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EFB RID: 159483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EFB")]
		[Address(RVA = "0x2225300", Offset = "0x2223F00", VA = "0x182225300")]
		public StageMixStoryStorylineItemTrackPointPlugin()
		{
		}

		// Token: 0x04037133 RID: 225587
		[Token(Token = "0x4037133")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _trackPointHolder;

		// Token: 0x04037134 RID: 225588
		[Token(Token = "0x4037134")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_trackPointInstance;

		// Token: 0x04037135 RID: 225589
		[Token(Token = "0x4037135")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037136 RID: 225590
		[Token(Token = "0x4037136")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037137 RID: 225591
		[Token(Token = "0x4037137")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
