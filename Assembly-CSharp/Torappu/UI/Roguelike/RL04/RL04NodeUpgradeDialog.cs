using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F1 RID: 22257
	[Token(Token = "0x20056F1")]
	public class RL04NodeUpgradeDialog : UICompDialog<RL04NodeUpgradeDialog.Input>
	{
		// Token: 0x06020A5A RID: 133722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A5A")]
		[Address(RVA = "0x1AC87F0", Offset = "0x1AC73F0", VA = "0x181AC87F0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06020A5B RID: 133723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A5B")]
		[Address(RVA = "0x1AC8860", Offset = "0x1AC7460", VA = "0x181AC8860", Slot = "18")]
		protected override void OnRender(RL04NodeUpgradeDialog.Input input)
		{
		}

		// Token: 0x06020A5C RID: 133724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A5C")]
		[Address(RVA = "0x1AC8D00", Offset = "0x1AC7900", VA = "0x181AC8D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020A5D RID: 133725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A5D")]
		[Address(RVA = "0x1AC8790", Offset = "0x1AC7390", VA = "0x181AC8790", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06020A5E RID: 133726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A5E")]
		[Address(RVA = "0x1AC8C40", Offset = "0x1AC7840", VA = "0x181AC8C40")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06020A5F RID: 133727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A5F")]
		[Address(RVA = "0x1AC8330", Offset = "0x1AC6F30", VA = "0x181AC8330")]
		public void EventOnBtnBackClick()
		{
		}

		// Token: 0x06020A60 RID: 133728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A60")]
		[Address(RVA = "0x1AC8420", Offset = "0x1AC7020", VA = "0x181AC8420")]
		public void EventOnBtnConfirm()
		{
		}

		// Token: 0x06020A61 RID: 133729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A61")]
		[Address(RVA = "0x1AC8E20", Offset = "0x1AC7A20", VA = "0x181AC8E20")]
		public RL04NodeUpgradeDialog()
		{
		}

		// Token: 0x06020A62 RID: 133730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A62")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06020A63 RID: 133731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A63")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402C48B RID: 181387
		[Token(Token = "0x402C48B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402C48C RID: 181388
		[Token(Token = "0x402C48C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0402C48D RID: 181389
		[Token(Token = "0x402C48D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RL04NodeUpgradeView _view;

		// Token: 0x0402C48E RID: 181390
		[Token(Token = "0x402C48E")]
		[FieldOffset(Offset = "0x88")]
		private RL04NodeUpgradeProp m_prop;

		// Token: 0x0402C48F RID: 181391
		[Token(Token = "0x402C48F")]
		[FieldOffset(Offset = "0x90")]
		private RL04NodeUpgradeConfig m_config;

		// Token: 0x0402C490 RID: 181392
		[Token(Token = "0x402C490")]
		[FieldOffset(Offset = "0x98")]
		private string m_topicId;

		// Token: 0x0402C491 RID: 181393
		[Token(Token = "0x402C491")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeEventType m_nodeType;

		// Token: 0x0402C492 RID: 181394
		[Token(Token = "0x402C492")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_hasInited;

		// Token: 0x0402C493 RID: 181395
		[Token(Token = "0x402C493")]
		[FieldOffset(Offset = "0xA5")]
		private bool m_isClosing;

		// Token: 0x0402C494 RID: 181396
		[Token(Token = "0x402C494")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C495 RID: 181397
		[Token(Token = "0x402C495")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C496 RID: 181398
		[Token(Token = "0x402C496")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C497 RID: 181399
		[Token(Token = "0x402C497")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402C498 RID: 181400
		[Token(Token = "0x402C498")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x0402C499 RID: 181401
		[Token(Token = "0x402C499")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnBackClick;

		// Token: 0x0402C49A RID: 181402
		[Token(Token = "0x402C49A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnConfirm;

		// Token: 0x0402C49B RID: 181403
		[Token(Token = "0x402C49B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056F2 RID: 22258
		[Token(Token = "0x20056F2")]
		public class Input
		{
			// Token: 0x06020A64 RID: 133732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020A64")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402C49C RID: 181404
			[Token(Token = "0x402C49C")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402C49D RID: 181405
			[Token(Token = "0x402C49D")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeEventType nodeType;
		}
	}
}
