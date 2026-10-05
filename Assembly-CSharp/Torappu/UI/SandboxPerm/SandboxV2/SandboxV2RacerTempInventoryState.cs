using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437B RID: 17275
	[Token(Token = "0x200437B")]
	public class SandboxV2RacerTempInventoryState : SandboxV2RacerInventoryBaseState, IHotfixable
	{
		// Token: 0x0601A866 RID: 108646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A866")]
		[Address(RVA = "0x13AD710", Offset = "0x13AC310", VA = "0x1813AD710", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A867 RID: 108647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A867")]
		[Address(RVA = "0x13AD770", Offset = "0x13AC370", VA = "0x1813AD770", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A868 RID: 108648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A868")]
		[Address(RVA = "0x13ADDD0", Offset = "0x13AC9D0", VA = "0x1813ADDD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A869 RID: 108649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A869")]
		[Address(RVA = "0x13ADAC0", Offset = "0x13AC6C0", VA = "0x1813ADAC0", Slot = "32")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A86A RID: 108650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86A")]
		[Address(RVA = "0x13ADEB0", Offset = "0x13ACAB0", VA = "0x1813ADEB0")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601A86B RID: 108651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86B")]
		[Address(RVA = "0x13ADF60", Offset = "0x13ACB60", VA = "0x1813ADF60")]
		private void _EventOnRacerCardClicked(string instId)
		{
		}

		// Token: 0x0601A86C RID: 108652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86C")]
		[Address(RVA = "0x13AE0A0", Offset = "0x13ACCA0", VA = "0x1813AE0A0")]
		private void _EventOnRegisterClicked()
		{
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86D")]
		[Address(RVA = "0x13AE410", Offset = "0x13AD010", VA = "0x1813AE410")]
		private void _EventOnReleaseAllClicked()
		{
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86E")]
		[Address(RVA = "0x13AEB10", Offset = "0x13AD710", VA = "0x1813AEB10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A86F")]
		[Address(RVA = "0x13AE710", Offset = "0x13AD310", VA = "0x1813AE710")]
		private void _HandleRegisterProceed(SandboxV2RacingRegisterResponse response)
		{
		}

		// Token: 0x0601A870 RID: 108656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A870")]
		[Address(RVA = "0x13AEC20", Offset = "0x13AD820", VA = "0x1813AEC20")]
		private void _ReleaseAllRacer()
		{
		}

		// Token: 0x0601A871 RID: 108657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A871")]
		[Address(RVA = "0x13AEA10", Offset = "0x13AD610", VA = "0x1813AEA10")]
		private void _HandleReleaseAllProceed(SandboxV2RacingReleaseResponse response)
		{
		}

		// Token: 0x0601A872 RID: 108658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A872")]
		[Address(RVA = "0x13AEF60", Offset = "0x13ADB60", VA = "0x1813AEF60")]
		public SandboxV2RacerTempInventoryState()
		{
		}

		// Token: 0x0601A873 RID: 108659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A873")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A874 RID: 108660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A874")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04021C1B RID: 138267
		[Token(Token = "0x4021C1B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RacerTempInventoryTopView _topView;

		// Token: 0x04021C1C RID: 138268
		[Token(Token = "0x4021C1C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2RacerTempInventoryListView _listView;

		// Token: 0x04021C1D RID: 138269
		[Token(Token = "0x4021C1D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2RacerTempInventoryInfoView _infoView;

		// Token: 0x04021C1E RID: 138270
		[Token(Token = "0x4021C1E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Sprite _imgReleaseIcon;

		// Token: 0x04021C1F RID: 138271
		[Token(Token = "0x4021C1F")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2RacerTempInventoryStateBean m_stateBean;

		// Token: 0x04021C20 RID: 138272
		[Token(Token = "0x4021C20")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04021C21 RID: 138273
		[Token(Token = "0x4021C21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04021C22 RID: 138274
		[Token(Token = "0x4021C22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04021C23 RID: 138275
		[Token(Token = "0x4021C23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021C24 RID: 138276
		[Token(Token = "0x4021C24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04021C25 RID: 138277
		[Token(Token = "0x4021C25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04021C26 RID: 138278
		[Token(Token = "0x4021C26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnRacerCardClicked;

		// Token: 0x04021C27 RID: 138279
		[Token(Token = "0x4021C27")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnRegisterClicked;

		// Token: 0x04021C28 RID: 138280
		[Token(Token = "0x4021C28")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnReleaseAllClicked;

		// Token: 0x04021C29 RID: 138281
		[Token(Token = "0x4021C29")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021C2A RID: 138282
		[Token(Token = "0x4021C2A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleRegisterProceed;

		// Token: 0x04021C2B RID: 138283
		[Token(Token = "0x4021C2B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReleaseAllRacer;

		// Token: 0x04021C2C RID: 138284
		[Token(Token = "0x4021C2C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleReleaseAllProceed;

		// Token: 0x04021C2D RID: 138285
		[Token(Token = "0x4021C2D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
