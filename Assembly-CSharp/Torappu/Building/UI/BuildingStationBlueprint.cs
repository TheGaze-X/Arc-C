using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B1B RID: 6939
	[Token(Token = "0x2001B1B")]
	[RequireComponent(typeof(RectTransform))]
	public class BuildingStationBlueprint : DataBinder<StationBPProperty>
	{
		// Token: 0x0600AEC3 RID: 44739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC3")]
		[Address(RVA = "0x3292A20", Offset = "0x3291620", VA = "0x183292A20")]
		public void SetInitSlotStyle(StationBPSlotStyle style)
		{
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC4")]
		[Address(RVA = "0x3292840", Offset = "0x3291440", VA = "0x183292840", Slot = "7")]
		public override void OnValueChanged(StationBPProperty property)
		{
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x00043338 File Offset: 0x00041538
		[Token(Token = "0x600AEC5")]
		[Address(RVA = "0x32927B0", Offset = "0x32913B0", VA = "0x1832927B0")]
		public Vector2 GridToPixel(GridPosition grid)
		{
			return default(Vector2);
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC6")]
		[Address(RVA = "0x3292BD0", Offset = "0x32917D0", VA = "0x183292BD0")]
		private void _Init(StationBPViewModel viewModel)
		{
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC7")]
		[Address(RVA = "0x3293100", Offset = "0x3291D00", VA = "0x183293100")]
		private void _UpdateContent(StationBPViewModel viewModel)
		{
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC8")]
		[Address(RVA = "0x3292A90", Offset = "0x3291690", VA = "0x183292A90")]
		private void _CalcGridUnit(StationBPViewModel viewModel)
		{
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC9")]
		[Address(RVA = "0x3293270", Offset = "0x3291E70", VA = "0x183293270")]
		public BuildingStationBlueprint()
		{
		}

		// Token: 0x0400A7D2 RID: 42962
		[Token(Token = "0x400A7D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _slotContainer;

		// Token: 0x0400A7D3 RID: 42963
		[Token(Token = "0x400A7D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingStationBPSlot _slotPrefab;

		// Token: 0x0400A7D4 RID: 42964
		[Token(Token = "0x400A7D4")]
		[FieldOffset(Offset = "0x30")]
		private List<BuildingStationBPSlot> m_slotViews;

		// Token: 0x0400A7D5 RID: 42965
		[Token(Token = "0x400A7D5")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_gridUnit;

		// Token: 0x0400A7D6 RID: 42966
		[Token(Token = "0x400A7D6")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0400A7D7 RID: 42967
		[Token(Token = "0x400A7D7")]
		[FieldOffset(Offset = "0x44")]
		private StationBPSlotStyle m_initSlotStyle;

		// Token: 0x0400A7D8 RID: 42968
		[Token(Token = "0x400A7D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInitSlotStyle;

		// Token: 0x0400A7D9 RID: 42969
		[Token(Token = "0x400A7D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A7DA RID: 42970
		[Token(Token = "0x400A7DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GridToPixel;

		// Token: 0x0400A7DB RID: 42971
		[Token(Token = "0x400A7DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400A7DC RID: 42972
		[Token(Token = "0x400A7DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A7DD RID: 42973
		[Token(Token = "0x400A7DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalcGridUnit;

		// Token: 0x0400A7DE RID: 42974
		[Token(Token = "0x400A7DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
