using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E9 RID: 16617
	[Token(Token = "0x20040E9")]
	public class SandboxV2AdminMainWorkbenchPanel : SandboxV2AdminMainTabPanel
	{
		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x06019B37 RID: 105271 RVA: 0x0009F1C8 File Offset: 0x0009D3C8
		[Token(Token = "0x17003D50")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x6019B37")]
			[Address(RVA = "0x1290D10", Offset = "0x128F910", VA = "0x181290D10", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x06019B38 RID: 105272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D51")]
		public override string topTitle
		{
			[Token(Token = "0x6019B38")]
			[Address(RVA = "0x1290D70", Offset = "0x128F970", VA = "0x181290D70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019B39 RID: 105273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B39")]
		[Address(RVA = "0x1290610", Offset = "0x128F210", VA = "0x181290610", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x06019B3A RID: 105274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B3A")]
		[Address(RVA = "0x12906D0", Offset = "0x128F2D0", VA = "0x1812906D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019B3B RID: 105275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B3B")]
		[Address(RVA = "0x1290A70", Offset = "0x128F670", VA = "0x181290A70")]
		private void _ItemSelectEvent(int index)
		{
		}

		// Token: 0x06019B3C RID: 105276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B3C")]
		[Address(RVA = "0x1290C00", Offset = "0x128F800", VA = "0x181290C00")]
		private void _SetFilterCanMakeEvent()
		{
		}

		// Token: 0x06019B3D RID: 105277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B3D")]
		[Address(RVA = "0x1290CB0", Offset = "0x128F8B0", VA = "0x181290CB0")]
		public SandboxV2AdminMainWorkbenchPanel()
		{
		}

		// Token: 0x04020273 RID: 131699
		[Token(Token = "0x4020273")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminMainWorkbenchTypeSelectorView _leftTypeView;

		// Token: 0x04020274 RID: 131700
		[Token(Token = "0x4020274")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2WorkbenchView _workbenchView;

		// Token: 0x04020275 RID: 131701
		[Token(Token = "0x4020275")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04020276 RID: 131702
		[Token(Token = "0x4020276")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminMainWorkbenchPanelModelProperty m_prop;

		// Token: 0x04020277 RID: 131703
		[Token(Token = "0x4020277")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x04020278 RID: 131704
		[Token(Token = "0x4020278")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x04020279 RID: 131705
		[Token(Token = "0x4020279")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0402027A RID: 131706
		[Token(Token = "0x402027A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402027B RID: 131707
		[Token(Token = "0x402027B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ItemSelectEvent;

		// Token: 0x0402027C RID: 131708
		[Token(Token = "0x402027C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetFilterCanMakeEvent;

		// Token: 0x0402027D RID: 131709
		[Token(Token = "0x402027D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
