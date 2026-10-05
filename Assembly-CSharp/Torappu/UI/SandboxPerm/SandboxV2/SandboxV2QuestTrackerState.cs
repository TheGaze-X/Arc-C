using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421C RID: 16924
	[Token(Token = "0x200421C")]
	public class SandboxV2QuestTrackerState : SandboxV2TrackerState, IValueMsgReceiver
	{
		// Token: 0x0601A1B6 RID: 106934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B6")]
		[Address(RVA = "0x130D460", Offset = "0x130C060", VA = "0x18130D460", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A1B7 RID: 106935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A1B7")]
		[Address(RVA = "0x130D400", Offset = "0x130C000", VA = "0x18130D400", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A1B8 RID: 106936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B8")]
		[Address(RVA = "0x130D8C0", Offset = "0x130C4C0", VA = "0x18130D8C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1B9 RID: 106937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B9")]
		[Address(RVA = "0x130DE40", Offset = "0x130CA40", VA = "0x18130DE40")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A1BA RID: 106938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BA")]
		[Address(RVA = "0x130DF40", Offset = "0x130CB40", VA = "0x18130DF40")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601A1BB RID: 106939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BB")]
		[Address(RVA = "0x130D7D0", Offset = "0x130C3D0", VA = "0x18130D7D0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A1BC RID: 106940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BC")]
		[Address(RVA = "0x130D960", Offset = "0x130C560", VA = "0x18130D960")]
		private void _OnItemSelect(string selectedId)
		{
		}

		// Token: 0x0601A1BD RID: 106941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BD")]
		[Address(RVA = "0x130DBE0", Offset = "0x130C7E0", VA = "0x18130DBE0")]
		private void _OpenArchive()
		{
		}

		// Token: 0x0601A1BE RID: 106942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BE")]
		[Address(RVA = "0x130E0F0", Offset = "0x130CCF0", VA = "0x18130E0F0")]
		public SandboxV2QuestTrackerState()
		{
		}

		// Token: 0x0601A1BF RID: 106943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1BF")]
		[Address(RVA = "0x1304000", Offset = "0x1302C00", VA = "0x181304000")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020EED RID: 134893
		[Token(Token = "0x4020EED")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04020EEE RID: 134894
		[Token(Token = "0x4020EEE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2QuestTrackerView _view;

		// Token: 0x04020EEF RID: 134895
		[Token(Token = "0x4020EEF")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04020EF0 RID: 134896
		[Token(Token = "0x4020EF0")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x04020EF1 RID: 134897
		[Token(Token = "0x4020EF1")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2QuestTrackerProperty m_property;

		// Token: 0x04020EF2 RID: 134898
		[Token(Token = "0x4020EF2")]
		[NonSerialized]
		public const int ON_ITEM_SELECT = 0;

		// Token: 0x04020EF3 RID: 134899
		[Token(Token = "0x4020EF3")]
		[NonSerialized]
		public const int ON_OPEN_ARCHIVE = 1;

		// Token: 0x04020EF4 RID: 134900
		[Token(Token = "0x4020EF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020EF5 RID: 134901
		[Token(Token = "0x4020EF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020EF6 RID: 134902
		[Token(Token = "0x4020EF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020EF7 RID: 134903
		[Token(Token = "0x4020EF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04020EF8 RID: 134904
		[Token(Token = "0x4020EF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04020EF9 RID: 134905
		[Token(Token = "0x4020EF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020EFA RID: 134906
		[Token(Token = "0x4020EFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemSelect;

		// Token: 0x04020EFB RID: 134907
		[Token(Token = "0x4020EFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenArchive;

		// Token: 0x04020EFC RID: 134908
		[Token(Token = "0x4020EFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
