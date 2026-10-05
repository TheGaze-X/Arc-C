using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007996 RID: 31126
	[Token(Token = "0x2007996")]
	public class Act1ArcadeStageSelectBadgeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BAB7 RID: 178871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB7")]
		[Address(RVA = "0x278CAA0", Offset = "0x278B6A0", VA = "0x18278CAA0")]
		public void Render(string actId, Act1ArcadeBadgeBookItemViewModel badgeItemViewModel, ILoadAsset assetLoader, bool showTierShow)
		{
		}

		// Token: 0x0602BAB8 RID: 178872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB8")]
		[Address(RVA = "0x278CBB0", Offset = "0x278B7B0", VA = "0x18278CBB0")]
		private void _TryRefreshBadgeIcon(string actId, Act1ArcadeBadgeBookItemViewModel badgeItemViewModel, Act1ArcadeBadgeBookItemTierViewModel tierModer, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602BAB9 RID: 178873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB9")]
		[Address(RVA = "0x278CD50", Offset = "0x278B950", VA = "0x18278CD50")]
		public Act1ArcadeStageSelectBadgeItemView()
		{
		}

		// Token: 0x0403F2CB RID: 258763
		[Token(Token = "0x403F2CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _badgeIcon;

		// Token: 0x0403F2CC RID: 258764
		[Token(Token = "0x403F2CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _badgeTier;

		// Token: 0x0403F2CD RID: 258765
		[Token(Token = "0x403F2CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403F2CE RID: 258766
		[Token(Token = "0x403F2CE")]
		[FieldOffset(Offset = "0x30")]
		private int m_catchedTier;

		// Token: 0x0403F2CF RID: 258767
		[Token(Token = "0x403F2CF")]
		[FieldOffset(Offset = "0x38")]
		private string m_catchedBadgeId;

		// Token: 0x0403F2D0 RID: 258768
		[Token(Token = "0x403F2D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F2D1 RID: 258769
		[Token(Token = "0x403F2D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRefreshBadgeIcon;

		// Token: 0x0403F2D2 RID: 258770
		[Token(Token = "0x403F2D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
