using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004028 RID: 16424
	[Token(Token = "0x2004028")]
	public class SandboxV2CharSelectLogisticsRightItemView : SandboxV2AdminCharSelectAbstractRightItemView
	{
		// Token: 0x060196C1 RID: 104129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C1")]
		[Address(RVA = "0x121FA60", Offset = "0x121E660", VA = "0x18121FA60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196C2 RID: 104130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C2")]
		[Address(RVA = "0x121F710", Offset = "0x121E310", VA = "0x18121F710", Slot = "4")]
		public override void RenderView(int position, SandboxV2CharViewModel charViewModel)
		{
		}

		// Token: 0x060196C3 RID: 104131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C3")]
		[Address(RVA = "0x121F960", Offset = "0x121E560", VA = "0x18121F960")]
		private void _HandleOnClick(int instId)
		{
		}

		// Token: 0x060196C4 RID: 104132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C4")]
		[Address(RVA = "0x121FB30", Offset = "0x121E730", VA = "0x18121FB30")]
		public SandboxV2CharSelectLogisticsRightItemView()
		{
		}

		// Token: 0x0401FA3D RID: 129597
		[Token(Token = "0x401FA3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2CharRepoAbstractItemView _itemView;

		// Token: 0x0401FA3E RID: 129598
		[Token(Token = "0x401FA3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401FA3F RID: 129599
		[Token(Token = "0x401FA3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedPart;

		// Token: 0x0401FA40 RID: 129600
		[Token(Token = "0x401FA40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectIndex;

		// Token: 0x0401FA41 RID: 129601
		[Token(Token = "0x401FA41")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA42 RID: 129602
		[Token(Token = "0x401FA42")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2CharRepoAbstractItemView m_itemView;

		// Token: 0x0401FA43 RID: 129603
		[Token(Token = "0x401FA43")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401FA44 RID: 129604
		[Token(Token = "0x401FA44")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2CharViewModel m_viewModel;

		// Token: 0x0401FA45 RID: 129605
		[Token(Token = "0x401FA45")]
		[FieldOffset(Offset = "0x60")]
		private int m_position;

		// Token: 0x0401FA46 RID: 129606
		[Token(Token = "0x401FA46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA47 RID: 129607
		[Token(Token = "0x401FA47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FA48 RID: 129608
		[Token(Token = "0x401FA48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleOnClick;

		// Token: 0x0401FA49 RID: 129609
		[Token(Token = "0x401FA49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
