using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007134 RID: 28980
	[Token(Token = "0x2007134")]
	public class ActAutoChessRewardInfoState : PopupFloatState, IHotfixable
	{
		// Token: 0x06029255 RID: 168533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029255")]
		[Address(RVA = "0x248C9D0", Offset = "0x248B5D0", VA = "0x18248C9D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029256 RID: 168534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029256")]
		[Address(RVA = "0x248CA30", Offset = "0x248B630", VA = "0x18248CA30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029257 RID: 168535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029257")]
		[Address(RVA = "0x248C950", Offset = "0x248B550", VA = "0x18248C950")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06029258 RID: 168536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029258")]
		[Address(RVA = "0x248CBD0", Offset = "0x248B7D0", VA = "0x18248CBD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029259 RID: 168537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029259")]
		[Address(RVA = "0x248CC70", Offset = "0x248B870", VA = "0x18248CC70")]
		public ActAutoChessRewardInfoState()
		{
		}

		// Token: 0x0602925A RID: 168538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403AC39 RID: 240697
		[Token(Token = "0x403AC39")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActAutoChessRewardInfoView _infoView;

		// Token: 0x0403AC3A RID: 240698
		[Token(Token = "0x403AC3A")]
		[FieldOffset(Offset = "0x78")]
		private ActAutoChessRewardInfoStateBean m_stateBean;

		// Token: 0x0403AC3B RID: 240699
		[Token(Token = "0x403AC3B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403AC3C RID: 240700
		[Token(Token = "0x403AC3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AC3D RID: 240701
		[Token(Token = "0x403AC3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AC3E RID: 240702
		[Token(Token = "0x403AC3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0403AC3F RID: 240703
		[Token(Token = "0x403AC3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AC40 RID: 240704
		[Token(Token = "0x403AC40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
