using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x020070A4 RID: 28836
	[Token(Token = "0x20070A4")]
	public class BattleFinishRaftMapModel : ActMultiV3BattleFinishMapModel
	{
		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x06028FED RID: 167917 RVA: 0x000D4028 File Offset: 0x000D2228
		// (set) Token: 0x06028FEE RID: 167918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006134")]
		public int score
		{
			[Token(Token = "0x6028FED")]
			[Address(RVA = "0x24742C0", Offset = "0x2472EC0", VA = "0x1824742C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028FEE")]
			[Address(RVA = "0x2474390", Offset = "0x2472F90", VA = "0x182474390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x06028FEF RID: 167919 RVA: 0x000D4040 File Offset: 0x000D2240
		// (set) Token: 0x06028FF0 RID: 167920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006135")]
		public bool newRecord
		{
			[Token(Token = "0x6028FEF")]
			[Address(RVA = "0x2474260", Offset = "0x2472E60", VA = "0x182474260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028FF0")]
			[Address(RVA = "0x2474320", Offset = "0x2472F20", VA = "0x182474320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x06028FF1 RID: 167921 RVA: 0x000D4058 File Offset: 0x000D2258
		[Token(Token = "0x17006136")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028FF1")]
			[Address(RVA = "0x2474200", Offset = "0x2472E00", VA = "0x182474200", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028FF2 RID: 167922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FF2")]
		[Address(RVA = "0x2474020", Offset = "0x2472C20", VA = "0x182474020", Slot = "5")]
		public override void LoadData(ActMultiV3BattleFinishMapModel.Input input)
		{
		}

		// Token: 0x06028FF3 RID: 167923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FF3")]
		[Address(RVA = "0x2474160", Offset = "0x2472D60", VA = "0x182474160")]
		public BattleFinishRaftMapModel()
		{
		}

		// Token: 0x0403A840 RID: 239680
		[Token(Token = "0x403A840")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_score;

		// Token: 0x0403A841 RID: 239681
		[Token(Token = "0x403A841")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_score;

		// Token: 0x0403A842 RID: 239682
		[Token(Token = "0x403A842")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_newRecord;

		// Token: 0x0403A843 RID: 239683
		[Token(Token = "0x403A843")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_newRecord;

		// Token: 0x0403A844 RID: 239684
		[Token(Token = "0x403A844")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A845 RID: 239685
		[Token(Token = "0x403A845")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A846 RID: 239686
		[Token(Token = "0x403A846")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
