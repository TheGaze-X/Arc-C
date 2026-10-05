using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003321 RID: 13089
	[Token(Token = "0x2003321")]
	public class UICharacterMenuState : UIStateNode
	{
		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x06014D06 RID: 85254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700314D")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014D06")]
			[Address(RVA = "0xD3C890", Offset = "0xD3B490", VA = "0x180D3C890")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x06014D07 RID: 85255 RVA: 0x00088A70 File Offset: 0x00086C70
		[Token(Token = "0x1700314E")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014D07")]
			[Address(RVA = "0xD3CB00", Offset = "0xD3B700", VA = "0x180D3CB00", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x06014D08 RID: 85256 RVA: 0x00088A88 File Offset: 0x00086C88
		[Token(Token = "0x1700314F")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014D08")]
			[Address(RVA = "0xD3CAA0", Offset = "0xD3B6A0", VA = "0x180D3CAA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x06014D09 RID: 85257 RVA: 0x00088AA0 File Offset: 0x00086CA0
		[Token(Token = "0x17003150")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014D09")]
			[Address(RVA = "0xD3CA40", Offset = "0xD3B640", VA = "0x180D3CA40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x06014D0A RID: 85258 RVA: 0x00088AB8 File Offset: 0x00086CB8
		[Token(Token = "0x17003151")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014D0A")]
			[Address(RVA = "0xD3C9E0", Offset = "0xD3B5E0", VA = "0x180D3C9E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x06014D0B RID: 85259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003152")]
		public UICharacterMenuPanel characterMenu
		{
			[Token(Token = "0x6014D0B")]
			[Address(RVA = "0xD3C910", Offset = "0xD3B510", VA = "0x180D3C910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x06014D0C RID: 85260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003153")]
		public Character character
		{
			[Token(Token = "0x6014D0C")]
			[Address(RVA = "0xD3C970", Offset = "0xD3B570", VA = "0x180D3C970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014D0D RID: 85261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D0D")]
		[Address(RVA = "0xD3C410", Offset = "0xD3B010", VA = "0x180D3C410")]
		public void Show(Character character)
		{
		}

		// Token: 0x06014D0E RID: 85262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D0E")]
		[Address(RVA = "0xD3BB30", Offset = "0xD3A730", VA = "0x180D3BB30")]
		public void OnCancelled(object arg)
		{
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D0F")]
		[Address(RVA = "0xD3C780", Offset = "0xD3B380", VA = "0x180D3C780")]
		private void _OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D10")]
		[Address(RVA = "0xD3C150", Offset = "0xD3AD50", VA = "0x180D3C150", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014D11 RID: 85265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D11")]
		[Address(RVA = "0xD3BC30", Offset = "0xD3A830", VA = "0x180D3BC30", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014D12 RID: 85266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D12")]
		[Address(RVA = "0xD3C2C0", Offset = "0xD3AEC0", VA = "0x180D3C2C0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014D13 RID: 85267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D13")]
		[Address(RVA = "0xD3BF20", Offset = "0xD3AB20", VA = "0x180D3BF20", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014D14 RID: 85268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D14")]
		[Address(RVA = "0xD3C390", Offset = "0xD3AF90", VA = "0x180D3C390")]
		public void ShowCharacterMenu(Character character)
		{
		}

		// Token: 0x06014D15 RID: 85269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D15")]
		[Address(RVA = "0xD3BAD0", Offset = "0xD3A6D0", VA = "0x180D3BAD0")]
		public void HideCharacterMenu()
		{
		}

		// Token: 0x06014D16 RID: 85270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D16")]
		[Address(RVA = "0xD3C620", Offset = "0xD3B220", VA = "0x180D3C620")]
		private void _DoShowCharacterMenu(Character character)
		{
		}

		// Token: 0x06014D17 RID: 85271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D17")]
		[Address(RVA = "0xD3C560", Offset = "0xD3B160", VA = "0x180D3C560")]
		private void _DoHideCharacterMenu()
		{
		}

		// Token: 0x06014D18 RID: 85272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D18")]
		[Address(RVA = "0xD3C830", Offset = "0xD3B430", VA = "0x180D3C830")]
		public UICharacterMenuState()
		{
		}

		// Token: 0x06014D19 RID: 85273 RVA: 0x00088AD0 File Offset: 0x00086CD0
		[Token(Token = "0x6014D19")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014D1A RID: 85274 RVA: 0x00088AE8 File Offset: 0x00086CE8
		[Token(Token = "0x6014D1A")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014D1B RID: 85275 RVA: 0x00088B00 File Offset: 0x00086D00
		[Token(Token = "0x6014D1B")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06014D1C RID: 85276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D1C")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014D1D RID: 85277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D1D")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014D1E RID: 85278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D1E")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018C09 RID: 101385
		[Token(Token = "0x4018C09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterMenuPanel _characterMenu;

		// Token: 0x04018C0A RID: 101386
		[Token(Token = "0x4018C0A")]
		[FieldOffset(Offset = "0x28")]
		private Tile m_rootTile;

		// Token: 0x04018C0B RID: 101387
		[Token(Token = "0x4018C0B")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Character> m_character;

		// Token: 0x04018C0C RID: 101388
		[Token(Token = "0x4018C0C")]
		[FieldOffset(Offset = "0x40")]
		private UICharacterMenuState.IUICharacterMenuPanel m_displayedMenuPanel;

		// Token: 0x04018C0D RID: 101389
		[Token(Token = "0x4018C0D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_slowMotionIsSet;

		// Token: 0x04018C0E RID: 101390
		[Token(Token = "0x4018C0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018C0F RID: 101391
		[Token(Token = "0x4018C0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018C10 RID: 101392
		[Token(Token = "0x4018C10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018C11 RID: 101393
		[Token(Token = "0x4018C11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018C12 RID: 101394
		[Token(Token = "0x4018C12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018C13 RID: 101395
		[Token(Token = "0x4018C13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_characterMenu;

		// Token: 0x04018C14 RID: 101396
		[Token(Token = "0x4018C14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04018C15 RID: 101397
		[Token(Token = "0x4018C15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04018C16 RID: 101398
		[Token(Token = "0x4018C16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCancelled;

		// Token: 0x04018C17 RID: 101399
		[Token(Token = "0x4018C17")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBottomMaskClicked;

		// Token: 0x04018C18 RID: 101400
		[Token(Token = "0x4018C18")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018C19 RID: 101401
		[Token(Token = "0x4018C19")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018C1A RID: 101402
		[Token(Token = "0x4018C1A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018C1B RID: 101403
		[Token(Token = "0x4018C1B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018C1C RID: 101404
		[Token(Token = "0x4018C1C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowCharacterMenu;

		// Token: 0x04018C1D RID: 101405
		[Token(Token = "0x4018C1D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideCharacterMenu;

		// Token: 0x04018C1E RID: 101406
		[Token(Token = "0x4018C1E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoShowCharacterMenu;

		// Token: 0x04018C1F RID: 101407
		[Token(Token = "0x4018C1F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DoHideCharacterMenu;

		// Token: 0x04018C20 RID: 101408
		[Token(Token = "0x4018C20")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003322 RID: 13090
		[Token(Token = "0x2003322")]
		public interface IUICharacterMenuPanel
		{
			// Token: 0x06014D1F RID: 85279
			[Token(Token = "0x6014D1F")]
			void Show(Character character);

			// Token: 0x06014D20 RID: 85280
			[Token(Token = "0x6014D20")]
			void Hide();
		}
	}
}
