using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D6 RID: 30934
	[Token(Token = "0x20078D6")]
	public class Act1LockSquadViewModel : SquadGroupViewModel
	{
		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x0602B60E RID: 177678 RVA: 0x000DBAB0 File Offset: 0x000D9CB0
		// (set) Token: 0x0602B60F RID: 177679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006591")]
		public bool IsSpecialDefendInOtherStage
		{
			[Token(Token = "0x602B60E")]
			[Address(RVA = "0x2759630", Offset = "0x2758230", VA = "0x182759630")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B60F")]
			[Address(RVA = "0x2759690", Offset = "0x2758290", VA = "0x182759690")]
			set
			{
			}
		}

		// Token: 0x0602B610 RID: 177680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B610")]
		[Address(RVA = "0x27590E0", Offset = "0x2757CE0", VA = "0x1827590E0")]
		public void LoadDataFromInterLockData(PlayerActivity.PlayerInterlockActivity interlockData, string stageId, ActivityInterlockData.InterlockStageType stageType)
		{
		}

		// Token: 0x0602B611 RID: 177681 RVA: 0x000DBAC8 File Offset: 0x000D9CC8
		[Token(Token = "0x602B611")]
		[Address(RVA = "0x27593D0", Offset = "0x2757FD0", VA = "0x1827593D0")]
		public bool RestrictSquadMembers(HashSet<int> defendInstIdSet)
		{
			return default(bool);
		}

		// Token: 0x0602B612 RID: 177682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B612")]
		[Address(RVA = "0x2758F60", Offset = "0x2757B60", VA = "0x182758F60", Slot = "4")]
		protected override SquadFriendData GeneSquadFriendData(PredefinedAssistData predefinedAssistData)
		{
			return null;
		}

		// Token: 0x0602B613 RID: 177683 RVA: 0x000DBAE0 File Offset: 0x000D9CE0
		[Token(Token = "0x602B613")]
		[Address(RVA = "0x2759080", Offset = "0x2757C80", VA = "0x182759080")]
		public bool IsAutoBattle()
		{
			return default(bool);
		}

		// Token: 0x0602B614 RID: 177684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B614")]
		[Address(RVA = "0x27595D0", Offset = "0x27581D0", VA = "0x1827595D0")]
		public Act1LockSquadViewModel()
		{
		}

		// Token: 0x0602B615 RID: 177685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B615")]
		[Address(RVA = "0x27595C0", Offset = "0x27581C0", VA = "0x1827595C0")]
		private SquadFriendData <>xLuaBaseProxy_GeneSquadFriendData(PredefinedAssistData P0)
		{
			return null;
		}

		// Token: 0x0403EBAE RID: 256942
		[Token(Token = "0x403EBAE")]
		private const int INTERLOCK_SQUAD_NUM = 1;

		// Token: 0x0403EBAF RID: 256943
		[Token(Token = "0x403EBAF")]
		[FieldOffset(Offset = "0x40")]
		private bool m_specialDefendInOtherStage;

		// Token: 0x0403EBB0 RID: 256944
		[Token(Token = "0x403EBB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsSpecialDefendInOtherStage;

		// Token: 0x0403EBB1 RID: 256945
		[Token(Token = "0x403EBB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_IsSpecialDefendInOtherStage;

		// Token: 0x0403EBB2 RID: 256946
		[Token(Token = "0x403EBB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadDataFromInterLockData;

		// Token: 0x0403EBB3 RID: 256947
		[Token(Token = "0x403EBB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RestrictSquadMembers;

		// Token: 0x0403EBB4 RID: 256948
		[Token(Token = "0x403EBB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GeneSquadFriendData;

		// Token: 0x0403EBB5 RID: 256949
		[Token(Token = "0x403EBB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsAutoBattle;

		// Token: 0x0403EBB6 RID: 256950
		[Token(Token = "0x403EBB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
