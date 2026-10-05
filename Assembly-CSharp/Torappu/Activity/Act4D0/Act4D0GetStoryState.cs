using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200727C RID: 29308
	[Token(Token = "0x200727C")]
	public class Act4D0GetStoryState : PopupFloatState
	{
		// Token: 0x06029825 RID: 170021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029825")]
		[Address(RVA = "0x24DC2F0", Offset = "0x24DAEF0", VA = "0x1824DC2F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029826 RID: 170022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029826")]
		[Address(RVA = "0x24DC350", Offset = "0x24DAF50", VA = "0x1824DC350", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029827 RID: 170023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029827")]
		[Address(RVA = "0x24DC510", Offset = "0x24DB110", VA = "0x1824DC510")]
		public Act4D0GetStoryState()
		{
		}

		// Token: 0x06029828 RID: 170024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029828")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B4F5 RID: 242933
		[Token(Token = "0x403B4F5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act4D0GetStoryStateBean _statebean;

		// Token: 0x0403B4F6 RID: 242934
		[Token(Token = "0x403B4F6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _charImage;

		// Token: 0x0403B4F7 RID: 242935
		[Token(Token = "0x403B4F7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _storyName;

		// Token: 0x0403B4F8 RID: 242936
		[Token(Token = "0x403B4F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B4F9 RID: 242937
		[Token(Token = "0x403B4F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B4FA RID: 242938
		[Token(Token = "0x403B4FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
