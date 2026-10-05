using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200199B RID: 6555
	[Token(Token = "0x200199B")]
	public class DIYMenuOverviewView : DIYBottomMenuTabStateView
	{
		// Token: 0x0600A4A6 RID: 42150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A6")]
		[Address(RVA = "0x31E1450", Offset = "0x31E0050", VA = "0x1831E1450", Slot = "7")]
		public override void OnValueChanged(DIYMenuProperty property)
		{
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A7")]
		[Address(RVA = "0x31E16B0", Offset = "0x31E02B0", VA = "0x1831E16B0")]
		public DIYMenuOverviewView()
		{
		}

		// Token: 0x04009BD3 RID: 39891
		[Token(Token = "0x4009BD3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _furnitureCount;

		// Token: 0x04009BD4 RID: 39892
		[Token(Token = "0x4009BD4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _themeCount;

		// Token: 0x04009BD5 RID: 39893
		[Token(Token = "0x4009BD5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _presetCount;

		// Token: 0x04009BD6 RID: 39894
		[Token(Token = "0x4009BD6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlThemeTrackpoint;

		// Token: 0x04009BD7 RID: 39895
		[Token(Token = "0x4009BD7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlFurnitureTrackpoint;

		// Token: 0x04009BD8 RID: 39896
		[Token(Token = "0x4009BD8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tabTrackpoint;

		// Token: 0x04009BD9 RID: 39897
		[Token(Token = "0x4009BD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009BDA RID: 39898
		[Token(Token = "0x4009BDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
