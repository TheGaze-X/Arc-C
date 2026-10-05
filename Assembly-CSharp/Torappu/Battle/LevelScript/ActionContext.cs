using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200282E RID: 10286
	[Token(Token = "0x200282E")]
	public class ActionContext : ParamBlackboard
	{
		// Token: 0x060111EF RID: 70127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111EF")]
		[Address(RVA = "0x901830", Offset = "0x900430", VA = "0x180901830")]
		public static ActionContext NewContext()
		{
			return null;
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F0")]
		[Address(RVA = "0x9019D0", Offset = "0x9005D0", VA = "0x1809019D0", Slot = "8")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F1")]
		[Address(RVA = "0x9017A0", Offset = "0x9003A0", VA = "0x1809017A0")]
		public void AddExecutor(ActionExecutor executor)
		{
		}

		// Token: 0x060111F2 RID: 70130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F2")]
		[Address(RVA = "0x901940", Offset = "0x900540", VA = "0x180901940")]
		public void OnActionExecutorStart(ActionExecutor executor)
		{
		}

		// Token: 0x060111F3 RID: 70131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F3")]
		[Address(RVA = "0x901D90", Offset = "0x900990", VA = "0x180901D90")]
		public void SetupNodeBinding(LevelScriptRuntime map)
		{
		}

		// Token: 0x060111F4 RID: 70132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F4")]
		[Address(RVA = "0x901CF0", Offset = "0x9008F0", VA = "0x180901CF0")]
		public void SetActionMap(LevelScriptRuntime value)
		{
		}

		// Token: 0x060111F5 RID: 70133 RVA: 0x00069768 File Offset: 0x00067968
		[Token(Token = "0x60111F5")]
		public bool TryGetGetter<T>(int id, out PureGetter<T> getter)
		{
			return default(bool);
		}

		// Token: 0x060111F6 RID: 70134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F6")]
		[Address(RVA = "0x901DC0", Offset = "0x9009C0", VA = "0x180901DC0")]
		private void _DoParamBind(LevelScriptRuntime data)
		{
		}

		// Token: 0x060111F7 RID: 70135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111F7")]
		[Address(RVA = "0x9024B0", Offset = "0x9010B0", VA = "0x1809024B0")]
		public ActionContext()
		{
		}

		// Token: 0x040132F8 RID: 78584
		[Token(Token = "0x40132F8")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x040132F9 RID: 78585
		[Token(Token = "0x40132F9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<ObjectPtr<ActionExecutor>> DOUBLE_BUFFER_SET;

		// Token: 0x040132FA RID: 78586
		[Token(Token = "0x40132FA")]
		[FieldOffset(Offset = "0x20")]
		public LevelScriptRuntime levelScriptRuntime;

		// Token: 0x040132FB RID: 78587
		[Token(Token = "0x40132FB")]
		[FieldOffset(Offset = "0x28")]
		private List<IParamBindable> m_paramList;

		// Token: 0x040132FC RID: 78588
		[Token(Token = "0x40132FC")]
		[FieldOffset(Offset = "0x30")]
		public HashSet<ObjectPtr<ActionExecutor>> executorPtrSet;

		// Token: 0x040132FD RID: 78589
		[Token(Token = "0x40132FD")]
		[FieldOffset(Offset = "0x38")]
		public ObjectPtr<ActionExecutor> currentActionExecutor;
	}
}
