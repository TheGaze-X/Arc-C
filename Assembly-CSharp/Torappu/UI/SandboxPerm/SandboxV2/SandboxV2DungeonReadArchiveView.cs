using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B9 RID: 16825
	[Token(Token = "0x20041B9")]
	public class SandboxV2DungeonReadArchiveView : DataBinder<SandboxV2DungeonReadArchiveProp>
	{
		// Token: 0x06019F23 RID: 106275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F23")]
		[Address(RVA = "0x12E3210", Offset = "0x12E1E10", VA = "0x1812E3210", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonReadArchiveProp property)
		{
		}

		// Token: 0x06019F24 RID: 106276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F24")]
		[Address(RVA = "0x12E39B0", Offset = "0x12E25B0", VA = "0x1812E39B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019F25 RID: 106277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F25")]
		[Address(RVA = "0x12E3180", Offset = "0x12E1D80", VA = "0x1812E3180")]
		public void OnBgClick()
		{
		}

		// Token: 0x06019F26 RID: 106278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F26")]
		[Address(RVA = "0x12E3A20", Offset = "0x12E2620", VA = "0x1812E3A20")]
		public SandboxV2DungeonReadArchiveView()
		{
		}

		// Token: 0x04020AB4 RID: 133812
		[Token(Token = "0x4020AB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2DungeonReadArchiveCurDayItemView _curDayInfoItemView;

		// Token: 0x04020AB5 RID: 133813
		[Token(Token = "0x4020AB5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtReadArchiveTips;

		// Token: 0x04020AB6 RID: 133814
		[Token(Token = "0x4020AB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _backExitToggle;

		// Token: 0x04020AB7 RID: 133815
		[Token(Token = "0x4020AB7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<SandboxV2DungeonReadArchiveItemListView> _archiveItemListViews;

		// Token: 0x04020AB8 RID: 133816
		[Token(Token = "0x4020AB8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04020AB9 RID: 133817
		[Token(Token = "0x4020AB9")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020ABA RID: 133818
		[Token(Token = "0x4020ABA")]
		[FieldOffset(Offset = "0x58")]
		private string m_archiveTipsFormat;

		// Token: 0x04020ABB RID: 133819
		[Token(Token = "0x4020ABB")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2DungeonReadArchiveItemListView _targetListView;

		// Token: 0x04020ABC RID: 133820
		[Token(Token = "0x4020ABC")]
		[FieldOffset(Offset = "0x68")]
		private bool m_panelInited;

		// Token: 0x04020ABD RID: 133821
		[Token(Token = "0x4020ABD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020ABE RID: 133822
		[Token(Token = "0x4020ABE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020ABF RID: 133823
		[Token(Token = "0x4020ABF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBgClick;

		// Token: 0x04020AC0 RID: 133824
		[Token(Token = "0x4020AC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
