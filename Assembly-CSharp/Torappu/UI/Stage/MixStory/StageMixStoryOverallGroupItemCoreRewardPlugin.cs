using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A65 RID: 27237
	[Token(Token = "0x2006A65")]
	public class StageMixStoryOverallGroupItemCoreRewardPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x06026ECC RID: 159436 RVA: 0x000CCBE8 File Offset: 0x000CADE8
		[Token(Token = "0x17005BC5")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026ECC")]
			[Address(RVA = "0x2222A90", Offset = "0x2221690", VA = "0x182222A90", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026ECD RID: 159437 RVA: 0x000CCC00 File Offset: 0x000CAE00
		[Token(Token = "0x6026ECD")]
		[Address(RVA = "0x2222540", Offset = "0x2221140", VA = "0x182222540", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026ECE RID: 159438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ECE")]
		[Address(RVA = "0x22225E0", Offset = "0x22211E0", VA = "0x1822225E0", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026ECF RID: 159439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ECF")]
		[Address(RVA = "0x2222820", Offset = "0x2221420", VA = "0x182222820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026ED0 RID: 159440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ED0")]
		[Address(RVA = "0x22229F0", Offset = "0x22215F0", VA = "0x1822229F0")]
		public StageMixStoryOverallGroupItemCoreRewardPlugin()
		{
		}

		// Token: 0x040370F3 RID: 225523
		[Token(Token = "0x40370F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _coreRewardContainer;

		// Token: 0x040370F4 RID: 225524
		[Token(Token = "0x40370F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _coreRewardItemScale;

		// Token: 0x040370F5 RID: 225525
		[Token(Token = "0x40370F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _coreRewardNameText;

		// Token: 0x040370F6 RID: 225526
		[Token(Token = "0x40370F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _unclaimedTextColor;

		// Token: 0x040370F7 RID: 225527
		[Token(Token = "0x40370F7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _claimedTextColor;

		// Token: 0x040370F8 RID: 225528
		[Token(Token = "0x40370F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGroupSetter _colorSetter;

		// Token: 0x040370F9 RID: 225529
		[Token(Token = "0x40370F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _unclaimedSetColor;

		// Token: 0x040370FA RID: 225530
		[Token(Token = "0x40370FA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _claimedSetColor;

		// Token: 0x040370FB RID: 225531
		[Token(Token = "0x40370FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _unclaimedPanel;

		// Token: 0x040370FC RID: 225532
		[Token(Token = "0x40370FC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _claimedPanel;

		// Token: 0x040370FD RID: 225533
		[Token(Token = "0x40370FD")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_coreRewardItemCard;

		// Token: 0x040370FE RID: 225534
		[Token(Token = "0x40370FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x040370FF RID: 225535
		[Token(Token = "0x40370FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037100 RID: 225536
		[Token(Token = "0x4037100")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037101 RID: 225537
		[Token(Token = "0x4037101")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037102 RID: 225538
		[Token(Token = "0x4037102")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
