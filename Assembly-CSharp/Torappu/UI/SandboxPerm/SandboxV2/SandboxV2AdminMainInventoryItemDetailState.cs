using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A2 RID: 16546
	[Token(Token = "0x20040A2")]
	public class SandboxV2AdminMainInventoryItemDetailState : PopupFloatState
	{
		// Token: 0x06019999 RID: 104857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019999")]
		[Address(RVA = "0x12497D0", Offset = "0x12483D0", VA = "0x1812497D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601999A RID: 104858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601999A")]
		[Address(RVA = "0x1249830", Offset = "0x1248430", VA = "0x181249830", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601999B RID: 104859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601999B")]
		[Address(RVA = "0x1249750", Offset = "0x1248350", VA = "0x181249750")]
		public void EventBack()
		{
		}

		// Token: 0x0601999C RID: 104860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601999C")]
		[Address(RVA = "0x12498A0", Offset = "0x12484A0", VA = "0x1812498A0")]
		public SandboxV2AdminMainInventoryItemDetailState()
		{
		}

		// Token: 0x0601999D RID: 104861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601999D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401FF92 RID: 130962
		[Token(Token = "0x401FF92")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminMainInventoryItemDetailView _view;

		// Token: 0x0401FF93 RID: 130963
		[Token(Token = "0x401FF93")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminMainInventoryItemDetailStateBean m_stateBean;

		// Token: 0x0401FF94 RID: 130964
		[Token(Token = "0x401FF94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401FF95 RID: 130965
		[Token(Token = "0x401FF95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401FF96 RID: 130966
		[Token(Token = "0x401FF96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventBack;

		// Token: 0x0401FF97 RID: 130967
		[Token(Token = "0x401FF97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
