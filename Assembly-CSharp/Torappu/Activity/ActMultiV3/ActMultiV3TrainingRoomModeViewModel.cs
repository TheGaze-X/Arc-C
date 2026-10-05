using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200701B RID: 28699
	[Token(Token = "0x200701B")]
	public class ActMultiV3TrainingRoomModeViewModel : IHotfixable, IComparable<ActMultiV3TrainingRoomModeViewModel>
	{
		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x06028BB8 RID: 166840 RVA: 0x000D2CA8 File Offset: 0x000D0EA8
		[Token(Token = "0x17006027")]
		public bool locked
		{
			[Token(Token = "0x6028BB8")]
			[Address(RVA = "0x2415E60", Offset = "0x2414A60", VA = "0x182415E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028BB9 RID: 166841 RVA: 0x000D2CC0 File Offset: 0x000D0EC0
		[Token(Token = "0x6028BB9")]
		[Address(RVA = "0x2415BE0", Offset = "0x24147E0", VA = "0x182415BE0", Slot = "4")]
		public int CompareTo(ActMultiV3TrainingRoomModeViewModel other)
		{
			return 0;
		}

		// Token: 0x06028BBA RID: 166842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BBA")]
		[Address(RVA = "0x2415CC0", Offset = "0x24148C0", VA = "0x182415CC0")]
		public void LoadTrainingStageData(ActMultiV3Data actData)
		{
		}

		// Token: 0x06028BBB RID: 166843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BBB")]
		[Address(RVA = "0x2415E00", Offset = "0x2414A00", VA = "0x182415E00")]
		public ActMultiV3TrainingRoomModeViewModel()
		{
		}

		// Token: 0x0403A140 RID: 237888
		[Token(Token = "0x403A140")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x0403A141 RID: 237889
		[Token(Token = "0x403A141")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x0403A142 RID: 237890
		[Token(Token = "0x403A142")]
		[FieldOffset(Offset = "0x20")]
		public string modeTypeName;

		// Token: 0x0403A143 RID: 237891
		[Token(Token = "0x403A143")]
		[FieldOffset(Offset = "0x28")]
		public long modeOpenTs;

		// Token: 0x0403A144 RID: 237892
		[Token(Token = "0x403A144")]
		[FieldOffset(Offset = "0x30")]
		public string unlockModeId;

		// Token: 0x0403A145 RID: 237893
		[Token(Token = "0x403A145")]
		[FieldOffset(Offset = "0x38")]
		public int unlockModeStar;

		// Token: 0x0403A146 RID: 237894
		[Token(Token = "0x403A146")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;

		// Token: 0x0403A147 RID: 237895
		[Token(Token = "0x403A147")]
		[FieldOffset(Offset = "0x40")]
		public bool isNormalMode;

		// Token: 0x0403A148 RID: 237896
		[Token(Token = "0x403A148")]
		[FieldOffset(Offset = "0x48")]
		public string modeColor;

		// Token: 0x0403A149 RID: 237897
		[Token(Token = "0x403A149")]
		[FieldOffset(Offset = "0x50")]
		public bool lockedByTime;

		// Token: 0x0403A14A RID: 237898
		[Token(Token = "0x403A14A")]
		[FieldOffset(Offset = "0x51")]
		public bool lockedByStar;

		// Token: 0x0403A14B RID: 237899
		[Token(Token = "0x403A14B")]
		[FieldOffset(Offset = "0x58")]
		public string stageId;

		// Token: 0x0403A14C RID: 237900
		[Token(Token = "0x403A14C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_locked;

		// Token: 0x0403A14D RID: 237901
		[Token(Token = "0x403A14D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403A14E RID: 237902
		[Token(Token = "0x403A14E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadTrainingStageData;

		// Token: 0x0403A14F RID: 237903
		[Token(Token = "0x403A14F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
