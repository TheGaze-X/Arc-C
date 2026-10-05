using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C77 RID: 7287
	[Token(Token = "0x2001C77")]
	public class BuildingStationCharacterSortFilterPanelBinder : DataBinder<StationCharGroupProperty>, IHotfixable
	{
		// Token: 0x0600B513 RID: 46355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B513")]
		[Address(RVA = "0x32EC730", Offset = "0x32EB330", VA = "0x1832EC730", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B514")]
		[Address(RVA = "0x32ECCA0", Offset = "0x32EB8A0", VA = "0x1832ECCA0")]
		private void _UpdateValidSubProfs(Dictionary<int, StationCharViewModel> charCards, ListDict<int, StationCharViewModel> selectedChars)
		{
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B515")]
		[Address(RVA = "0x32ECAE0", Offset = "0x32EB6E0", VA = "0x1832ECAE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B516")]
		[Address(RVA = "0x32ECF30", Offset = "0x32EBB30", VA = "0x1832ECF30")]
		public BuildingStationCharacterSortFilterPanelBinder()
		{
		}

		// Token: 0x0400B10F RID: 45327
		[Token(Token = "0x400B10F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelHolder;

		// Token: 0x0400B110 RID: 45328
		[Token(Token = "0x400B110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterSortFilterPanel _panelPrefab;

		// Token: 0x0400B111 RID: 45329
		[Token(Token = "0x400B111")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterMessage _onFilterEvent;

		// Token: 0x0400B112 RID: 45330
		[Token(Token = "0x400B112")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterShowMessage _onFilterShowEvent;

		// Token: 0x0400B113 RID: 45331
		[Token(Token = "0x400B113")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0400B114 RID: 45332
		[Token(Token = "0x400B114")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0400B115 RID: 45333
		[Token(Token = "0x400B115")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedInitSeq;

		// Token: 0x0400B116 RID: 45334
		[Token(Token = "0x400B116")]
		[FieldOffset(Offset = "0x50")]
		private UICharacterSortFilterPanel m_sortFilterPanel;

		// Token: 0x0400B117 RID: 45335
		[Token(Token = "0x400B117")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<string> m_cachedValidSubProf;

		// Token: 0x0400B118 RID: 45336
		[Token(Token = "0x400B118")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B119 RID: 45337
		[Token(Token = "0x400B119")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateValidSubProfs;

		// Token: 0x0400B11A RID: 45338
		[Token(Token = "0x400B11A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B11B RID: 45339
		[Token(Token = "0x400B11B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
