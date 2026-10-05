using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421B RID: 16923
	[Token(Token = "0x200421B")]
	public class SandboxV2OtherTrackerState : SandboxV2TrackerState, IValueMsgReceiver
	{
		// Token: 0x0601A1AD RID: 106925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1AD")]
		[Address(RVA = "0x130AFF0", Offset = "0x1309BF0", VA = "0x18130AFF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A1AE RID: 106926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A1AE")]
		[Address(RVA = "0x130AF90", Offset = "0x1309B90", VA = "0x18130AF90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A1AF RID: 106927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1AF")]
		[Address(RVA = "0x130B480", Offset = "0x130A080", VA = "0x18130B480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1B0 RID: 106928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B0")]
		[Address(RVA = "0x130B7F0", Offset = "0x130A3F0", VA = "0x18130B7F0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A1B1 RID: 106929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B1")]
		[Address(RVA = "0x130B8F0", Offset = "0x130A4F0", VA = "0x18130B8F0")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601A1B2 RID: 106930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B2")]
		[Address(RVA = "0x130B3B0", Offset = "0x1309FB0", VA = "0x18130B3B0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A1B3 RID: 106931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B3")]
		[Address(RVA = "0x130B570", Offset = "0x130A170", VA = "0x18130B570")]
		private void _OnItemSelect(string selectedId)
		{
		}

		// Token: 0x0601A1B4 RID: 106932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B4")]
		[Address(RVA = "0x130BAA0", Offset = "0x130A6A0", VA = "0x18130BAA0")]
		public SandboxV2OtherTrackerState()
		{
		}

		// Token: 0x0601A1B5 RID: 106933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1B5")]
		[Address(RVA = "0x1304000", Offset = "0x1302C00", VA = "0x181304000")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020EDF RID: 134879
		[Token(Token = "0x4020EDF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04020EE0 RID: 134880
		[Token(Token = "0x4020EE0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2OtherTrackerView _view;

		// Token: 0x04020EE1 RID: 134881
		[Token(Token = "0x4020EE1")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04020EE2 RID: 134882
		[Token(Token = "0x4020EE2")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x04020EE3 RID: 134883
		[Token(Token = "0x4020EE3")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2OtherTrackerViewModelProperty m_property;

		// Token: 0x04020EE4 RID: 134884
		[Token(Token = "0x4020EE4")]
		[NonSerialized]
		public const int ON_ITEM_SELECT = 0;

		// Token: 0x04020EE5 RID: 134885
		[Token(Token = "0x4020EE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020EE6 RID: 134886
		[Token(Token = "0x4020EE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020EE7 RID: 134887
		[Token(Token = "0x4020EE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020EE8 RID: 134888
		[Token(Token = "0x4020EE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04020EE9 RID: 134889
		[Token(Token = "0x4020EE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04020EEA RID: 134890
		[Token(Token = "0x4020EEA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020EEB RID: 134891
		[Token(Token = "0x4020EEB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemSelect;

		// Token: 0x04020EEC RID: 134892
		[Token(Token = "0x4020EEC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
