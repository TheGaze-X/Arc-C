using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006389 RID: 25481
	[Token(Token = "0x2006389")]
	public class AutoChessStageInfoAVGAdapter : ExecutorComponent, IHotfixable
	{
		// Token: 0x06024C10 RID: 150544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C10")]
		[Address(RVA = "0x1FA4C80", Offset = "0x1FA3880", VA = "0x181FA4C80", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06024C11 RID: 150545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C11")]
		[Address(RVA = "0x1FA4C20", Offset = "0x1FA3820", VA = "0x181FA4C20", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06024C12 RID: 150546 RVA: 0x000C5658 File Offset: 0x000C3858
		[Token(Token = "0x6024C12")]
		[Address(RVA = "0x1FA4E10", Offset = "0x1FA3A10", VA = "0x181FA4E10")]
		private bool _OnFocusStageInfoItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x06024C13 RID: 150547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C13")]
		[Address(RVA = "0x1FA4BC0", Offset = "0x1FA37C0", VA = "0x181FA4BC0")]
		public void EventOnFocusComplete()
		{
		}

		// Token: 0x06024C14 RID: 150548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C14")]
		[Address(RVA = "0x1FA4F60", Offset = "0x1FA3B60", VA = "0x181FA4F60")]
		public AutoChessStageInfoAVGAdapter()
		{
		}

		// Token: 0x04033597 RID: 210327
		[Token(Token = "0x4033597")]
		private const string PARAM_FOCUS_ITEM_TYPE = "itemType";

		// Token: 0x04033598 RID: 210328
		[Token(Token = "0x4033598")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033599 RID: 210329
		[Token(Token = "0x4033599")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0403359A RID: 210330
		[Token(Token = "0x403359A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0403359B RID: 210331
		[Token(Token = "0x403359B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFocusStageInfoItem;

		// Token: 0x0403359C RID: 210332
		[Token(Token = "0x403359C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFocusComplete;

		// Token: 0x0403359D RID: 210333
		[Token(Token = "0x403359D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
