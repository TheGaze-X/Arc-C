using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063BB RID: 25531
	[Token(Token = "0x20063BB")]
	public class AutoChessCharSelectDetailView : TemplateCharSelectDetailViewBase<AutoChessCharSelectDetailViewModel>, AutoChessCharSelectDetailPanel.ICtrl
	{
		// Token: 0x06024CF0 RID: 150768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CF0")]
		[Address(RVA = "0x1FB85E0", Offset = "0x1FB71E0", VA = "0x181FB85E0", Slot = "11")]
		protected override void OnRenderViewModel()
		{
		}

		// Token: 0x06024CF1 RID: 150769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CF1")]
		[Address(RVA = "0x1FB88A0", Offset = "0x1FB74A0", VA = "0x181FB88A0", Slot = "12")]
		public void SwitchGold(bool isGold)
		{
		}

		// Token: 0x06024CF2 RID: 150770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CF2")]
		[Address(RVA = "0x1FB87E0", Offset = "0x1FB73E0", VA = "0x181FB87E0", Slot = "13")]
		public void SelectSkill(string skillId)
		{
		}

		// Token: 0x06024CF3 RID: 150771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CF3")]
		[Address(RVA = "0x1FB8720", Offset = "0x1FB7320", VA = "0x181FB8720", Slot = "14")]
		public void SelectEquip(string equipId)
		{
		}

		// Token: 0x06024CF4 RID: 150772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CF4")]
		[Address(RVA = "0x1FB8AA0", Offset = "0x1FB76A0", VA = "0x181FB8AA0")]
		public AutoChessCharSelectDetailView()
		{
		}

		// Token: 0x0403375E RID: 210782
		[Token(Token = "0x403375E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessCharSelectDetailPanel _detailPanelPrefab;

		// Token: 0x0403375F RID: 210783
		[Token(Token = "0x403375F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _detailContainer;

		// Token: 0x04033760 RID: 210784
		[Token(Token = "0x4033760")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessCharSelectDetailPanel m_detailPanel;

		// Token: 0x04033761 RID: 210785
		[Token(Token = "0x4033761")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x04033762 RID: 210786
		[Token(Token = "0x4033762")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SwitchGold;

		// Token: 0x04033763 RID: 210787
		[Token(Token = "0x4033763")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x04033764 RID: 210788
		[Token(Token = "0x4033764")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectEquip;

		// Token: 0x04033765 RID: 210789
		[Token(Token = "0x4033765")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
