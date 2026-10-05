using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004379 RID: 17273
	[Token(Token = "0x2004379")]
	public class SandboxV2RacerTempInventoryInfoView : DataBinder<SandboxV2RacerTempInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A85F RID: 108639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A85F")]
		[Address(RVA = "0x13ACED0", Offset = "0x13ABAD0", VA = "0x1813ACED0", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerTempInventoryProperty property)
		{
		}

		// Token: 0x0601A860 RID: 108640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A860")]
		[Address(RVA = "0x13ACE40", Offset = "0x13ABA40", VA = "0x1813ACE40")]
		public void EventOnReleaseAllClicked()
		{
		}

		// Token: 0x0601A861 RID: 108641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A861")]
		[Address(RVA = "0x13ACDB0", Offset = "0x13AB9B0", VA = "0x1813ACDB0")]
		public void EventOnRegisterClicked()
		{
		}

		// Token: 0x0601A862 RID: 108642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A862")]
		[Address(RVA = "0x13AD0C0", Offset = "0x13ABCC0", VA = "0x1813AD0C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A863 RID: 108643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A863")]
		[Address(RVA = "0x13AD190", Offset = "0x13ABD90", VA = "0x1813AD190")]
		public SandboxV2RacerTempInventoryInfoView()
		{
		}

		// Token: 0x04021C0C RID: 138252
		[Token(Token = "0x4021C0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2RacerInventoryDetailView _prefabDetail;

		// Token: 0x04021C0D RID: 138253
		[Token(Token = "0x4021C0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _containerDetail;

		// Token: 0x04021C0E RID: 138254
		[Token(Token = "0x4021C0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelReleaseAllBtn;

		// Token: 0x04021C0F RID: 138255
		[Token(Token = "0x4021C0F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRegisterBtn;

		// Token: 0x04021C10 RID: 138256
		[Token(Token = "0x4021C10")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04021C11 RID: 138257
		[Token(Token = "0x4021C11")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2RacerInventoryDetailView m_detailView;

		// Token: 0x04021C12 RID: 138258
		[Token(Token = "0x4021C12")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021C13 RID: 138259
		[Token(Token = "0x4021C13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021C14 RID: 138260
		[Token(Token = "0x4021C14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnReleaseAllClicked;

		// Token: 0x04021C15 RID: 138261
		[Token(Token = "0x4021C15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRegisterClicked;

		// Token: 0x04021C16 RID: 138262
		[Token(Token = "0x4021C16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021C17 RID: 138263
		[Token(Token = "0x4021C17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
