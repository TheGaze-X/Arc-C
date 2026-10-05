using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004899 RID: 18585
	[Token(Token = "0x2004899")]
	public class MainMissionTaskLoopAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x0601C0C4 RID: 114884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0C4")]
		[Address(RVA = "0x15673E0", Offset = "0x1565FE0", VA = "0x1815673E0")]
		public void NotifyRebuild()
		{
		}

		// Token: 0x0601C0C5 RID: 114885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0C5")]
		[Address(RVA = "0x1567020", Offset = "0x1565C20", VA = "0x181567020", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x0601C0C6 RID: 114886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0C6")]
		[Address(RVA = "0x1567500", Offset = "0x1566100", VA = "0x181567500")]
		public MainMissionTaskLoopAdapter()
		{
		}

		// Token: 0x040249ED RID: 149997
		[Token(Token = "0x40249ED")]
		[FieldOffset(Offset = "0x18")]
		public List<MainMissionTask.VirtualView> m_virtualViewList;

		// Token: 0x040249EE RID: 149998
		[Token(Token = "0x40249EE")]
		[FieldOffset(Offset = "0x20")]
		public MainMissionTask taskPrefab;

		// Token: 0x040249EF RID: 149999
		[Token(Token = "0x40249EF")]
		[FieldOffset(Offset = "0x28")]
		public MainMissionLockedTask lockedTaskPrefab;

		// Token: 0x040249F0 RID: 150000
		[Token(Token = "0x40249F0")]
		[FieldOffset(Offset = "0x30")]
		public MissionModel.BranchWrappedGroup wrappedModel;

		// Token: 0x040249F1 RID: 150001
		[Token(Token = "0x40249F1")]
		[FieldOffset(Offset = "0x38")]
		public UIStringEvent onSpreadFold;

		// Token: 0x040249F2 RID: 150002
		[Token(Token = "0x40249F2")]
		[FieldOffset(Offset = "0x40")]
		public UIStringEvent onHideFold;

		// Token: 0x040249F3 RID: 150003
		[Token(Token = "0x40249F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyRebuild;

		// Token: 0x040249F4 RID: 150004
		[Token(Token = "0x40249F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x040249F5 RID: 150005
		[Token(Token = "0x40249F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
