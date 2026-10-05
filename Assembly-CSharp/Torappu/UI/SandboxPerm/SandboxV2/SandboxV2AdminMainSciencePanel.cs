using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040CF RID: 16591
	[Token(Token = "0x20040CF")]
	public class SandboxV2AdminMainSciencePanel : SandboxV2AdminMainTabPanel
	{
		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x06019A96 RID: 105110 RVA: 0x0009EF10 File Offset: 0x0009D110
		[Token(Token = "0x17003D36")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x6019A96")]
			[Address(RVA = "0x127FE10", Offset = "0x127EA10", VA = "0x18127FE10", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x06019A97 RID: 105111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D37")]
		public override string topTitle
		{
			[Token(Token = "0x6019A97")]
			[Address(RVA = "0x127FE70", Offset = "0x127EA70", VA = "0x18127FE70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019A98 RID: 105112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A98")]
		[Address(RVA = "0x127F750", Offset = "0x127E350", VA = "0x18127F750", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x06019A99 RID: 105113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A99")]
		[Address(RVA = "0x127F830", Offset = "0x127E430", VA = "0x18127F830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A9A RID: 105114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A9A")]
		[Address(RVA = "0x127FC60", Offset = "0x127E860", VA = "0x18127FC60")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x06019A9B RID: 105115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A9B")]
		[Address(RVA = "0x127F3D0", Offset = "0x127DFD0", VA = "0x18127F3D0")]
		private void EventOnNodeDevelop(string nodeId)
		{
		}

		// Token: 0x06019A9C RID: 105116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A9C")]
		[Address(RVA = "0x127FAB0", Offset = "0x127E6B0", VA = "0x18127FAB0")]
		private void _OnScienceUnlockRespond(SandboxV2ScienceUnlockResponse resp)
		{
		}

		// Token: 0x06019A9D RID: 105117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A9D")]
		[Address(RVA = "0x127FDB0", Offset = "0x127E9B0", VA = "0x18127FDB0")]
		public SandboxV2AdminMainSciencePanel()
		{
		}

		// Token: 0x04020141 RID: 131393
		[Token(Token = "0x4020141")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminMainScienceView _contentView;

		// Token: 0x04020142 RID: 131394
		[Token(Token = "0x4020142")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2AdminMainScienceTypeSelectView _selectView;

		// Token: 0x04020143 RID: 131395
		[Token(Token = "0x4020143")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminMainScienceDetailView _detailView;

		// Token: 0x04020144 RID: 131396
		[Token(Token = "0x4020144")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2AdminMainScienceTopBarView _topbarView;

		// Token: 0x04020145 RID: 131397
		[Token(Token = "0x4020145")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2AdminMainSciencePanelModelProperty m_property;

		// Token: 0x04020146 RID: 131398
		[Token(Token = "0x4020146")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedTopicId;

		// Token: 0x04020147 RID: 131399
		[Token(Token = "0x4020147")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x04020148 RID: 131400
		[Token(Token = "0x4020148")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x04020149 RID: 131401
		[Token(Token = "0x4020149")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0402014A RID: 131402
		[Token(Token = "0x402014A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402014B RID: 131403
		[Token(Token = "0x402014B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0402014C RID: 131404
		[Token(Token = "0x402014C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnNodeDevelop;

		// Token: 0x0402014D RID: 131405
		[Token(Token = "0x402014D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnScienceUnlockRespond;

		// Token: 0x0402014E RID: 131406
		[Token(Token = "0x402014E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
