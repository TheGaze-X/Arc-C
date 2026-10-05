using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004113 RID: 16659
	[Token(Token = "0x2004113")]
	public class SandboxV2BuildingDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019BFE RID: 105470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BFE")]
		[Address(RVA = "0x12969C0", Offset = "0x12955C0", VA = "0x1812969C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019BFF RID: 105471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BFF")]
		[Address(RVA = "0x12968B0", Offset = "0x12954B0", VA = "0x1812968B0")]
		public void SetParams(SandboxV2BuildingDetailPanel.Param param)
		{
		}

		// Token: 0x06019C00 RID: 105472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C00")]
		[Address(RVA = "0x1296550", Offset = "0x1295150", VA = "0x181296550")]
		public void Render(ISandboxV2BuildingDetail buildingDetailModel)
		{
		}

		// Token: 0x06019C01 RID: 105473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C01")]
		[Address(RVA = "0x1296B90", Offset = "0x1295790", VA = "0x181296B90")]
		public SandboxV2BuildingDetailPanel()
		{
		}

		// Token: 0x04020432 RID: 132146
		[Token(Token = "0x4020432")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ConstructTipType[] CONCERNED_TIPS;

		// Token: 0x04020433 RID: 132147
		[Token(Token = "0x4020433")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlTipList;

		// Token: 0x04020434 RID: 132148
		[Token(Token = "0x4020434")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04020435 RID: 132149
		[Token(Token = "0x4020435")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlEmptyTip;

		// Token: 0x04020436 RID: 132150
		[Token(Token = "0x4020436")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04020437 RID: 132151
		[Token(Token = "0x4020437")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEmptyTip;

		// Token: 0x04020438 RID: 132152
		[Token(Token = "0x4020438")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x04020439 RID: 132153
		[Token(Token = "0x4020439")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tip Type")]
		private SandboxV2BuildingTipView _tipViewPrefab;

		// Token: 0x0402043A RID: 132154
		[Token(Token = "0x402043A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tip Type")]
		private float _tipViewHeight;

		// Token: 0x0402043B RID: 132155
		[Token(Token = "0x402043B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tip Type")]
		private SandboxV2BuildingInfoView _infoViewPrefab;

		// Token: 0x0402043C RID: 132156
		[Token(Token = "0x402043C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tip Type")]
		private float _infoViewHeightWithoutTitle;

		// Token: 0x0402043D RID: 132157
		[Token(Token = "0x402043D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Group("Tip Type")]
		private float _infoViewHeightWithTitle;

		// Token: 0x0402043E RID: 132158
		[Token(Token = "0x402043E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0402043F RID: 132159
		[Token(Token = "0x402043F")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2BuildingDetailPanel.Adapter m_adapter;

		// Token: 0x04020440 RID: 132160
		[Token(Token = "0x4020440")]
		[FieldOffset(Offset = "0x78")]
		private ISandboxV2BuildingDetail m_cachedBuildingDetailModel;

		// Token: 0x04020441 RID: 132161
		[Token(Token = "0x4020441")]
		[FieldOffset(Offset = "0x80")]
		private Action<SandboxV2ConstructTipType> m_onClicked;

		// Token: 0x04020442 RID: 132162
		[Token(Token = "0x4020442")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020443 RID: 132163
		[Token(Token = "0x4020443")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x04020444 RID: 132164
		[Token(Token = "0x4020444")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020445 RID: 132165
		[Token(Token = "0x4020445")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004114 RID: 16660
		[Token(Token = "0x2004114")]
		public struct Param
		{
			// Token: 0x04020446 RID: 132166
			[Token(Token = "0x4020446")]
			[FieldOffset(Offset = "0x0")]
			public Color bkgColor;

			// Token: 0x04020447 RID: 132167
			[Token(Token = "0x4020447")]
			[FieldOffset(Offset = "0x10")]
			public Action<SandboxV2ConstructTipType> onClicked;
		}

		// Token: 0x02004115 RID: 16661
		[Token(Token = "0x2004115")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06019C03 RID: 105475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C03")]
			[Address(RVA = "0x128BD10", Offset = "0x128A910", VA = "0x18128BD10")]
			public Adapter(SandboxV2BuildingDetailPanel closure)
			{
			}

			// Token: 0x06019C04 RID: 105476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C04")]
			[Address(RVA = "0x128B750", Offset = "0x128A350", VA = "0x18128B750")]
			public void RebuildList()
			{
			}

			// Token: 0x06019C05 RID: 105477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019C05")]
			[Address(RVA = "0x128AE90", Offset = "0x1289A90", VA = "0x18128AE90", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x04020448 RID: 132168
			[Token(Token = "0x4020448")]
			[FieldOffset(Offset = "0x18")]
			private SandboxV2BuildingDetailPanel m_closure;

			// Token: 0x04020449 RID: 132169
			[Token(Token = "0x4020449")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402044A RID: 132170
			[Token(Token = "0x402044A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x0402044B RID: 132171
			[Token(Token = "0x402044B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}
