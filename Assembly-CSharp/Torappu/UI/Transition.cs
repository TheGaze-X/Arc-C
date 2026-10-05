using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200368C RID: 13964
	[Token(Token = "0x200368C")]
	public class Transition : IHotfixable
	{
		// Token: 0x06016355 RID: 90965 RVA: 0x0008FFB8 File Offset: 0x0008E1B8
		[Token(Token = "0x6016355")]
		[Address(RVA = "0xE9D8B0", Offset = "0xE9C4B0", VA = "0x180E9D8B0")]
		public static bool IsSideIn(TransitionType type)
		{
			return default(bool);
		}

		// Token: 0x06016356 RID: 90966 RVA: 0x0008FFD0 File Offset: 0x0008E1D0
		[Token(Token = "0x6016356")]
		[Address(RVA = "0xE9D910", Offset = "0xE9C510", VA = "0x180E9D910")]
		public static bool IsSideOut(TransitionType type)
		{
			return default(bool);
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x06016357 RID: 90967 RVA: 0x0008FFE8 File Offset: 0x0008E1E8
		[Token(Token = "0x17003563")]
		public bool IsRunning
		{
			[Token(Token = "0x6016357")]
			[Address(RVA = "0xE9E4D0", Offset = "0xE9D0D0", VA = "0x180E9E4D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x00090000 File Offset: 0x0008E200
		[Token(Token = "0x6016358")]
		[Address(RVA = "0xE9DB70", Offset = "0xE9C770", VA = "0x180E9DB70")]
		public bool StartTransition(State fromState, State toState, Action<State, State> onTransitionEnd, bool isFastMode)
		{
			return default(bool);
		}

		// Token: 0x06016359 RID: 90969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016359")]
		[Address(RVA = "0xE9DA60", Offset = "0xE9C660", VA = "0x180E9DA60")]
		public void ResetDynamicActions()
		{
		}

		// Token: 0x0601635A RID: 90970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635A")]
		[Address(RVA = "0xE9D680", Offset = "0xE9C280", VA = "0x180E9D680", Slot = "4")]
		public virtual void AddStaticAction(ITransAction action)
		{
		}

		// Token: 0x0601635B RID: 90971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635B")]
		[Address(RVA = "0xE9D710", Offset = "0xE9C310", VA = "0x180E9D710", Slot = "5")]
		public virtual void AddStaticActions(ITransAction[] actions)
		{
		}

		// Token: 0x0601635C RID: 90972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635C")]
		[Address(RVA = "0xE9D7D0", Offset = "0xE9C3D0", VA = "0x180E9D7D0")]
		public void AppendDynamicAction(ITransAction action)
		{
		}

		// Token: 0x0601635D RID: 90973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635D")]
		[Address(RVA = "0xE9D970", Offset = "0xE9C570", VA = "0x180E9D970")]
		public void PrependDynamicAction(ITransAction action)
		{
		}

		// Token: 0x0601635E RID: 90974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635E")]
		[Address(RVA = "0xE9DEB0", Offset = "0xE9CAB0", VA = "0x180E9DEB0")]
		private void _DequeueActionAndExec()
		{
		}

		// Token: 0x0601635F RID: 90975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601635F")]
		[Address(RVA = "0xE9E310", Offset = "0xE9CF10", VA = "0x180E9E310")]
		private void _OnParallelActionFinish()
		{
		}

		// Token: 0x06016360 RID: 90976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016360")]
		[Address(RVA = "0xE9E370", Offset = "0xE9CF70", VA = "0x180E9E370")]
		private void _OnSequentialActionFinish()
		{
		}

		// Token: 0x06016361 RID: 90977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016361")]
		[Address(RVA = "0xE9E2A0", Offset = "0xE9CEA0", VA = "0x180E9E2A0")]
		private void _NotifyAnActionEnd()
		{
		}

		// Token: 0x06016362 RID: 90978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016362")]
		[Address(RVA = "0xE9E170", Offset = "0xE9CD70", VA = "0x180E9E170")]
		private void _FinishTransition()
		{
		}

		// Token: 0x06016363 RID: 90979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016363")]
		[Address(RVA = "0xE9E3E0", Offset = "0xE9CFE0", VA = "0x180E9E3E0")]
		public Transition()
		{
		}

		// Token: 0x0401AB01 RID: 109313
		[Token(Token = "0x401AB01")]
		[FieldOffset(Offset = "0x10")]
		protected List<ITransAction> m_staticActionSlot;

		// Token: 0x0401AB02 RID: 109314
		[Token(Token = "0x401AB02")]
		[FieldOffset(Offset = "0x18")]
		protected List<ITransAction> m_dynamicActionSlot;

		// Token: 0x0401AB03 RID: 109315
		[Token(Token = "0x401AB03")]
		[FieldOffset(Offset = "0x20")]
		private Queue<ITransAction> m_runningActions;

		// Token: 0x0401AB04 RID: 109316
		[Token(Token = "0x401AB04")]
		[FieldOffset(Offset = "0x28")]
		private Action<State, State> m_transitionEndListener;

		// Token: 0x0401AB05 RID: 109317
		[Token(Token = "0x401AB05")]
		[FieldOffset(Offset = "0x30")]
		private State m_fromState;

		// Token: 0x0401AB06 RID: 109318
		[Token(Token = "0x401AB06")]
		[FieldOffset(Offset = "0x38")]
		private State m_toState;

		// Token: 0x0401AB07 RID: 109319
		[Token(Token = "0x401AB07")]
		[FieldOffset(Offset = "0x40")]
		private int m_liveActionCounter;

		// Token: 0x0401AB08 RID: 109320
		[Token(Token = "0x401AB08")]
		[FieldOffset(Offset = "0x44")]
		private TransitionType m_transType;

		// Token: 0x0401AB09 RID: 109321
		[Token(Token = "0x401AB09")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isFastMode;

		// Token: 0x0401AB0A RID: 109322
		[Token(Token = "0x401AB0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsSideIn;

		// Token: 0x0401AB0B RID: 109323
		[Token(Token = "0x401AB0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsSideOut;

		// Token: 0x0401AB0C RID: 109324
		[Token(Token = "0x401AB0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IsRunning;

		// Token: 0x0401AB0D RID: 109325
		[Token(Token = "0x401AB0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StartTransition;

		// Token: 0x0401AB0E RID: 109326
		[Token(Token = "0x401AB0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetDynamicActions;

		// Token: 0x0401AB0F RID: 109327
		[Token(Token = "0x401AB0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddStaticAction;

		// Token: 0x0401AB10 RID: 109328
		[Token(Token = "0x401AB10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddStaticActions;

		// Token: 0x0401AB11 RID: 109329
		[Token(Token = "0x401AB11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AppendDynamicAction;

		// Token: 0x0401AB12 RID: 109330
		[Token(Token = "0x401AB12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PrependDynamicAction;

		// Token: 0x0401AB13 RID: 109331
		[Token(Token = "0x401AB13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DequeueActionAndExec;

		// Token: 0x0401AB14 RID: 109332
		[Token(Token = "0x401AB14")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnParallelActionFinish;

		// Token: 0x0401AB15 RID: 109333
		[Token(Token = "0x401AB15")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSequentialActionFinish;

		// Token: 0x0401AB16 RID: 109334
		[Token(Token = "0x401AB16")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__NotifyAnActionEnd;

		// Token: 0x0401AB17 RID: 109335
		[Token(Token = "0x401AB17")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FinishTransition;

		// Token: 0x0401AB18 RID: 109336
		[Token(Token = "0x401AB18")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
