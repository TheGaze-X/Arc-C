using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004149 RID: 16713
	[Token(Token = "0x2004149")]
	public class SandboxV2BasementBuildingDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D0B RID: 105739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0B")]
		[Address(RVA = "0x12A0BD0", Offset = "0x129F7D0", VA = "0x1812A0BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D0C RID: 105740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0C")]
		[Address(RVA = "0x12A09C0", Offset = "0x129F5C0", VA = "0x1812A09C0")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x06019D0D RID: 105741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0D")]
		[Address(RVA = "0x12A0CE0", Offset = "0x129F8E0", VA = "0x1812A0CE0")]
		public SandboxV2BasementBuildingDetailView()
		{
		}

		// Token: 0x04020660 RID: 132704
		[Token(Token = "0x4020660")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _buildingDetailHolder;

		// Token: 0x04020661 RID: 132705
		[Token(Token = "0x4020661")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2BuildingDetailPanel _prefabBuildingDetail;

		// Token: 0x04020662 RID: 132706
		[Token(Token = "0x4020662")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _detailPanelBkgColor;

		// Token: 0x04020663 RID: 132707
		[Token(Token = "0x4020663")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04020664 RID: 132708
		[Token(Token = "0x4020664")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2BuildingDetailPanel m_buildingDetail;

		// Token: 0x04020665 RID: 132709
		[Token(Token = "0x4020665")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020666 RID: 132710
		[Token(Token = "0x4020666")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020667 RID: 132711
		[Token(Token = "0x4020667")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
