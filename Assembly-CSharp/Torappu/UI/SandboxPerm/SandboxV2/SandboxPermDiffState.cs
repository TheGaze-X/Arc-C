using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004017 RID: 16407
	[Token(Token = "0x2004017")]
	public class SandboxPermDiffState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06019682 RID: 104066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019682")]
		[Address(RVA = "0x1215E20", Offset = "0x1214A20", VA = "0x181215E20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019683 RID: 104067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019683")]
		[Address(RVA = "0x1215E80", Offset = "0x1214A80", VA = "0x181215E80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019684 RID: 104068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019684")]
		[Address(RVA = "0x1216090", Offset = "0x1214C90", VA = "0x181216090", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019685 RID: 104069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019685")]
		[Address(RVA = "0x1216160", Offset = "0x1214D60", VA = "0x181216160")]
		public void SendSwitchExploreModeService(int mode)
		{
		}

		// Token: 0x06019686 RID: 104070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019686")]
		[Address(RVA = "0x1216410", Offset = "0x1215010", VA = "0x181216410")]
		private void _OnExploreModeServiceCallback(int mode)
		{
		}

		// Token: 0x06019687 RID: 104071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019687")]
		[Address(RVA = "0x12166A0", Offset = "0x12152A0", VA = "0x1812166A0")]
		public SandboxPermDiffState()
		{
		}

		// Token: 0x06019688 RID: 104072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019688")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401F9BE RID: 129470
		[Token(Token = "0x401F9BE")]
		[NonSerialized]
		public const int MSG_CONFIRM_CLICKED = 1;

		// Token: 0x0401F9BF RID: 129471
		[Token(Token = "0x401F9BF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxPermDiffStateBean _stateBean;

		// Token: 0x0401F9C0 RID: 129472
		[Token(Token = "0x401F9C0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxPermDiffView _diffView;

		// Token: 0x0401F9C1 RID: 129473
		[Token(Token = "0x401F9C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _dismissButton;

		// Token: 0x0401F9C2 RID: 129474
		[Token(Token = "0x401F9C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F9C3 RID: 129475
		[Token(Token = "0x401F9C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F9C4 RID: 129476
		[Token(Token = "0x401F9C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401F9C5 RID: 129477
		[Token(Token = "0x401F9C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendSwitchExploreModeService;

		// Token: 0x0401F9C6 RID: 129478
		[Token(Token = "0x401F9C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnExploreModeServiceCallback;

		// Token: 0x0401F9C7 RID: 129479
		[Token(Token = "0x401F9C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
