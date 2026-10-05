using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005370 RID: 21360
	[Token(Token = "0x2005370")]
	public class RoguelikePendingCommonCompDialogState : PopupFadeState, ICompDialogCallBack
	{
		// Token: 0x0601F7C7 RID: 128967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7C7")]
		[Address(RVA = "0x192E730", Offset = "0x192D330", VA = "0x18192E730", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F7C8 RID: 128968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C8")]
		[Address(RVA = "0x192E850", Offset = "0x192D450", VA = "0x18192E850", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F7C9 RID: 128969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C9")]
		[Address(RVA = "0x192EB70", Offset = "0x192D770", VA = "0x18192EB70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F7CA RID: 128970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7CA")]
		[Address(RVA = "0x192ECC0", Offset = "0x192D8C0", VA = "0x18192ECC0")]
		private void _OpenCompDialog(RoguelikePendingCommonCompDialogState.DialogParam param)
		{
		}

		// Token: 0x0601F7CB RID: 128971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7CB")]
		[Address(RVA = "0x192E790", Offset = "0x192D390", VA = "0x18192E790", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601F7CC RID: 128972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7CC")]
		[Address(RVA = "0x192EEA0", Offset = "0x192DAA0", VA = "0x18192EEA0")]
		public RoguelikePendingCommonCompDialogState()
		{
		}

		// Token: 0x0601F7CD RID: 128973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7CD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402A5D9 RID: 173529
		[Token(Token = "0x402A5D9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402A5DA RID: 173530
		[Token(Token = "0x402A5DA")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeDungeonController m_controller;

		// Token: 0x0402A5DB RID: 173531
		[Token(Token = "0x402A5DB")]
		[FieldOffset(Offset = "0x80")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402A5DC RID: 173532
		[Token(Token = "0x402A5DC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInit;

		// Token: 0x0402A5DD RID: 173533
		[Token(Token = "0x402A5DD")]
		[FieldOffset(Offset = "0x8C")]
		private int m_dialogInstId;

		// Token: 0x0402A5DE RID: 173534
		[Token(Token = "0x402A5DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A5DF RID: 173535
		[Token(Token = "0x402A5DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A5E0 RID: 173536
		[Token(Token = "0x402A5E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A5E1 RID: 173537
		[Token(Token = "0x402A5E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenCompDialog;

		// Token: 0x0402A5E2 RID: 173538
		[Token(Token = "0x402A5E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402A5E3 RID: 173539
		[Token(Token = "0x402A5E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005371 RID: 21361
		[Token(Token = "0x2005371")]
		public class DialogParam
		{
			// Token: 0x0601F7CE RID: 128974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F7CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DialogParam()
			{
			}

			// Token: 0x0402A5E4 RID: 173540
			[Token(Token = "0x402A5E4")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeMenuAdapter menuAdapter;

			// Token: 0x0402A5E5 RID: 173541
			[Token(Token = "0x402A5E5")]
			[FieldOffset(Offset = "0x18")]
			public string dialogPath;

			// Token: 0x0402A5E6 RID: 173542
			[Token(Token = "0x402A5E6")]
			[FieldOffset(Offset = "0x20")]
			public object input;

			// Token: 0x0402A5E7 RID: 173543
			[Token(Token = "0x402A5E7")]
			[FieldOffset(Offset = "0x28")]
			public Type dialogType;
		}

		// Token: 0x02005372 RID: 21362
		[Token(Token = "0x2005372")]
		public class EmitParam
		{
			// Token: 0x0601F7CF RID: 128975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F7CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmitParam()
			{
			}

			// Token: 0x0402A5E8 RID: 173544
			[Token(Token = "0x402A5E8")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikePlayerEventType eventType;

			// Token: 0x0402A5E9 RID: 173545
			[Token(Token = "0x402A5E9")]
			[FieldOffset(Offset = "0x18")]
			public Action<RoguelikePendingCommonCompDialogState.DialogParam> openDialog;
		}

		// Token: 0x02005373 RID: 21363
		[Token(Token = "0x2005373")]
		private class CompBuilder : UICompDialogMgr.CompBaseBuilder
		{
			// Token: 0x0601F7D0 RID: 128976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F7D0")]
			[Address(RVA = "0x19212D0", Offset = "0x191FED0", VA = "0x1819212D0", Slot = "4")]
			public override object GetInput()
			{
				return null;
			}

			// Token: 0x0601F7D1 RID: 128977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F7D1")]
			[Address(RVA = "0x1921330", Offset = "0x191FF30", VA = "0x181921330")]
			public CompBuilder()
			{
			}

			// Token: 0x0402A5EA RID: 173546
			[Token(Token = "0x402A5EA")]
			[FieldOffset(Offset = "0x18")]
			public object input;

			// Token: 0x0402A5EB RID: 173547
			[Token(Token = "0x402A5EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetInput;

			// Token: 0x0402A5EC RID: 173548
			[Token(Token = "0x402A5EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
