using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200787A RID: 30842
	[Token(Token = "0x200787A")]
	public class Act1LockSquadPage : StateEnginePage
	{
		// Token: 0x0602B3A7 RID: 177063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3A7")]
		[Address(RVA = "0x2717900", Offset = "0x2716500", VA = "0x182717900")]
		public Act1LockSquadPage()
		{
		}

		// Token: 0x0403E7D8 RID: 255960
		[Token(Token = "0x403E7D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200787B RID: 30843
		[Token(Token = "0x200787B")]
		public class Params
		{
			// Token: 0x0602B3A8 RID: 177064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B3A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403E7D9 RID: 255961
			[Token(Token = "0x403E7D9")]
			[FieldOffset(Offset = "0x10")]
			public StageId stage;

			// Token: 0x0403E7DA RID: 255962
			[Token(Token = "0x403E7DA")]
			[FieldOffset(Offset = "0x28")]
			public int apCost;

			// Token: 0x0403E7DB RID: 255963
			[Token(Token = "0x403E7DB")]
			[FieldOffset(Offset = "0x30")]
			public string activityId;

			// Token: 0x0403E7DC RID: 255964
			[Token(Token = "0x403E7DC")]
			[FieldOffset(Offset = "0x38")]
			public ActivityInterlockData.InterlockStageType interlockStageType;

			// Token: 0x0403E7DD RID: 255965
			[Token(Token = "0x403E7DD")]
			[FieldOffset(Offset = "0x3C")]
			public bool isPractice;

			// Token: 0x0403E7DE RID: 255966
			[Token(Token = "0x403E7DE")]
			[FieldOffset(Offset = "0x3D")]
			public bool isAutoBattle;

			// Token: 0x0403E7DF RID: 255967
			[Token(Token = "0x403E7DF")]
			[FieldOffset(Offset = "0x40")]
			public List<RuneTable.PackedRuneData> runeList;

			// Token: 0x0403E7E0 RID: 255968
			[Token(Token = "0x403E7E0")]
			[FieldOffset(Offset = "0x48")]
			public BattleActivityMeta actMeta;
		}
	}
}
