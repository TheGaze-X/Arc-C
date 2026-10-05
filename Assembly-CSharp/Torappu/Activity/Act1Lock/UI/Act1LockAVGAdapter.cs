using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007874 RID: 30836
	[Token(Token = "0x2007874")]
	public class Act1LockAVGAdapter : ExecutorComponent
	{
		// Token: 0x0602B381 RID: 177025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B381")]
		[Address(RVA = "0x2705FC0", Offset = "0x2704BC0", VA = "0x182705FC0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0602B382 RID: 177026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B382")]
		[Address(RVA = "0x2705F60", Offset = "0x2704B60", VA = "0x182705F60", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0602B383 RID: 177027 RVA: 0x000DB318 File Offset: 0x000D9518
		[Token(Token = "0x602B383")]
		[Address(RVA = "0x27062D0", Offset = "0x2704ED0", VA = "0x1827062D0")]
		private bool _ExecuteEnsureMapStatus(Command command)
		{
			return default(bool);
		}

		// Token: 0x0602B384 RID: 177028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B384")]
		[Address(RVA = "0x2706150", Offset = "0x2704D50", VA = "0x182706150")]
		public void InitAvgAdapter(Act1LockMapPage mapPage)
		{
		}

		// Token: 0x0602B385 RID: 177029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B385")]
		[Address(RVA = "0x2706220", Offset = "0x2704E20", VA = "0x182706220")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B386 RID: 177030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B386")]
		[Address(RVA = "0x27063D0", Offset = "0x2704FD0", VA = "0x1827063D0")]
		public Act1LockAVGAdapter()
		{
		}

		// Token: 0x0403E7B6 RID: 255926
		[Token(Token = "0x403E7B6")]
		[FieldOffset(Offset = "0x50")]
		private Act1LockMapPage m_cachedPage;

		// Token: 0x0403E7B7 RID: 255927
		[Token(Token = "0x403E7B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0403E7B8 RID: 255928
		[Token(Token = "0x403E7B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0403E7B9 RID: 255929
		[Token(Token = "0x403E7B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureMapStatus;

		// Token: 0x0403E7BA RID: 255930
		[Token(Token = "0x403E7BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitAvgAdapter;

		// Token: 0x0403E7BB RID: 255931
		[Token(Token = "0x403E7BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403E7BC RID: 255932
		[Token(Token = "0x403E7BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
