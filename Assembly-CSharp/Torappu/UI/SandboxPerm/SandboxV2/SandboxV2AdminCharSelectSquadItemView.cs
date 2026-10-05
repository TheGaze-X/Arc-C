using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200402E RID: 16430
	[Token(Token = "0x200402E")]
	public class SandboxV2AdminCharSelectSquadItemView : SandboxV2AdminCharSelectAbstractRightItemView
	{
		// Token: 0x060196E5 RID: 104165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E5")]
		[Address(RVA = "0x121CC30", Offset = "0x121B830", VA = "0x18121CC30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196E6 RID: 104166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E6")]
		[Address(RVA = "0x121C9E0", Offset = "0x121B5E0", VA = "0x18121C9E0", Slot = "4")]
		public override void RenderView(int position, SandboxV2CharViewModel charViewModel)
		{
		}

		// Token: 0x060196E7 RID: 104167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E7")]
		[Address(RVA = "0x121C8E0", Offset = "0x121B4E0", VA = "0x18121C8E0")]
		public void HandleOnClick(int instId)
		{
		}

		// Token: 0x060196E8 RID: 104168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E8")]
		[Address(RVA = "0x121CD00", Offset = "0x121B900", VA = "0x18121CD00")]
		public SandboxV2AdminCharSelectSquadItemView()
		{
		}

		// Token: 0x0401FAAE RID: 129710
		[Token(Token = "0x401FAAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2CharRepoCharItemView _itemView;

		// Token: 0x0401FAAF RID: 129711
		[Token(Token = "0x401FAAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401FAB0 RID: 129712
		[Token(Token = "0x401FAB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedPart;

		// Token: 0x0401FAB1 RID: 129713
		[Token(Token = "0x401FAB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectIndex;

		// Token: 0x0401FAB2 RID: 129714
		[Token(Token = "0x401FAB2")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FAB3 RID: 129715
		[Token(Token = "0x401FAB3")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2CharRepoCharItemView m_itemView;

		// Token: 0x0401FAB4 RID: 129716
		[Token(Token = "0x401FAB4")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401FAB5 RID: 129717
		[Token(Token = "0x401FAB5")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2CharViewModel m_viewModel;

		// Token: 0x0401FAB6 RID: 129718
		[Token(Token = "0x401FAB6")]
		[FieldOffset(Offset = "0x60")]
		private int m_position;

		// Token: 0x0401FAB7 RID: 129719
		[Token(Token = "0x401FAB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FAB8 RID: 129720
		[Token(Token = "0x401FAB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FAB9 RID: 129721
		[Token(Token = "0x401FAB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleOnClick;

		// Token: 0x0401FABA RID: 129722
		[Token(Token = "0x401FABA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
