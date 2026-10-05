using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006674 RID: 26228
	[Token(Token = "0x2006674")]
	public class HandBookCharStoryUnlockState : PopupFloatState
	{
		// Token: 0x06025A88 RID: 154248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A88")]
		[Address(RVA = "0x2092060", Offset = "0x2090C60", VA = "0x182092060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025A89 RID: 154249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A89")]
		[Address(RVA = "0x20920C0", Offset = "0x2090CC0", VA = "0x1820920C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025A8A RID: 154250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A8A")]
		[Address(RVA = "0x2092190", Offset = "0x2090D90", VA = "0x182092190")]
		private void _RenderView()
		{
		}

		// Token: 0x06025A8B RID: 154251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A8B")]
		[Address(RVA = "0x20923B0", Offset = "0x2090FB0", VA = "0x1820923B0")]
		private void _SetTopMenuActive(bool isActive)
		{
		}

		// Token: 0x06025A8C RID: 154252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A8C")]
		[Address(RVA = "0x2091E20", Offset = "0x2090A20", VA = "0x182091E20")]
		public void CloseAndShowItem()
		{
		}

		// Token: 0x06025A8D RID: 154253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A8D")]
		[Address(RVA = "0x2092630", Offset = "0x2091230", VA = "0x182092630")]
		public HandBookCharStoryUnlockState()
		{
		}

		// Token: 0x06025A8E RID: 154254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A8E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04034E6D RID: 216685
		[Token(Token = "0x4034E6D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookCharStoryUnlockStateBean _stateBean;

		// Token: 0x04034E6E RID: 216686
		[Token(Token = "0x4034E6E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04034E6F RID: 216687
		[Token(Token = "0x4034E6F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x04034E70 RID: 216688
		[Token(Token = "0x4034E70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034E71 RID: 216689
		[Token(Token = "0x4034E71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034E72 RID: 216690
		[Token(Token = "0x4034E72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04034E73 RID: 216691
		[Token(Token = "0x4034E73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetTopMenuActive;

		// Token: 0x04034E74 RID: 216692
		[Token(Token = "0x4034E74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CloseAndShowItem;

		// Token: 0x04034E75 RID: 216693
		[Token(Token = "0x4034E75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
