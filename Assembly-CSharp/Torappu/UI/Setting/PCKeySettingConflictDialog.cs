using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD1 RID: 16337
	[Token(Token = "0x2003FD1")]
	public class PCKeySettingConflictDialog : UICompDialog<PCKeySettingConflictDialog.Input>, IHotfixable
	{
		// Token: 0x0601952F RID: 103727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601952F")]
		[Address(RVA = "0x11F9C80", Offset = "0x11F8880", VA = "0x1811F9C80", Slot = "18")]
		protected override void OnRender(PCKeySettingConflictDialog.Input input)
		{
		}

		// Token: 0x06019530 RID: 103728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019530")]
		[Address(RVA = "0x11FA300", Offset = "0x11F8F00", VA = "0x1811FA300")]
		private KeyItem _GetKeyItem(string keyId)
		{
			return null;
		}

		// Token: 0x06019531 RID: 103729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019531")]
		[Address(RVA = "0x11FA3B0", Offset = "0x11F8FB0", VA = "0x1811FA3B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019532 RID: 103730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019532")]
		[Address(RVA = "0x11FA280", Offset = "0x11F8E80", VA = "0x1811FA280")]
		private void _ForceRebuildLayout()
		{
		}

		// Token: 0x06019533 RID: 103731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019533")]
		[Address(RVA = "0x11F9BD0", Offset = "0x11F87D0", VA = "0x1811F9BD0")]
		public void OnConfirmExchangeClicked()
		{
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019534")]
		[Address(RVA = "0x11F9B20", Offset = "0x11F8720", VA = "0x1811F9B20")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019535")]
		[Address(RVA = "0x11FA490", Offset = "0x11F9090", VA = "0x1811FA490")]
		public PCKeySettingConflictDialog()
		{
		}

		// Token: 0x0401F799 RID: 128921
		[Token(Token = "0x401F799")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _conflictFuncName;

		// Token: 0x0401F79A RID: 128922
		[Token(Token = "0x401F79A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _keyCardHolder;

		// Token: 0x0401F79B RID: 128923
		[Token(Token = "0x401F79B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0401F79C RID: 128924
		[Token(Token = "0x401F79C")]
		[FieldOffset(Offset = "0x88")]
		private PCKeyCard m_keyCard;

		// Token: 0x0401F79D RID: 128925
		[Token(Token = "0x401F79D")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0401F79E RID: 128926
		[Token(Token = "0x401F79E")]
		[FieldOffset(Offset = "0x98")]
		private PCKeySettingConflictDialog.Input m_cachedInput;

		// Token: 0x0401F79F RID: 128927
		[Token(Token = "0x401F79F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F7A0 RID: 128928
		[Token(Token = "0x401F7A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetKeyItem;

		// Token: 0x0401F7A1 RID: 128929
		[Token(Token = "0x401F7A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7A2 RID: 128930
		[Token(Token = "0x401F7A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ForceRebuildLayout;

		// Token: 0x0401F7A3 RID: 128931
		[Token(Token = "0x401F7A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmExchangeClicked;

		// Token: 0x0401F7A4 RID: 128932
		[Token(Token = "0x401F7A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0401F7A5 RID: 128933
		[Token(Token = "0x401F7A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FD2 RID: 16338
		[Token(Token = "0x2003FD2")]
		public class Input
		{
			// Token: 0x06019536 RID: 103734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019536")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401F7A6 RID: 128934
			[Token(Token = "0x401F7A6")]
			[FieldOffset(Offset = "0x10")]
			public KeyBoardVirtualButtonConfig selectInfo;

			// Token: 0x0401F7A7 RID: 128935
			[Token(Token = "0x401F7A7")]
			[FieldOffset(Offset = "0x18")]
			public KeyBoardVirtualButtonConfig conflictInfo;

			// Token: 0x0401F7A8 RID: 128936
			[Token(Token = "0x401F7A8")]
			[FieldOffset(Offset = "0x20")]
			public string conflictName;

			// Token: 0x0401F7A9 RID: 128937
			[Token(Token = "0x401F7A9")]
			[FieldOffset(Offset = "0x28")]
			public string pressedKeyId;
		}

		// Token: 0x02003FD3 RID: 16339
		[Token(Token = "0x2003FD3")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06019537 RID: 103735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019537")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(PCKeySettingConflictDialog closure)
			{
			}

			// Token: 0x06019538 RID: 103736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019538")]
			[Address(RVA = "0x11F8290", Offset = "0x11F6E90", VA = "0x1811F8290", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401F7AA RID: 128938
			[Token(Token = "0x401F7AA")]
			[FieldOffset(Offset = "0x10")]
			private PCKeySettingConflictDialog m_closure;
		}
	}
}
