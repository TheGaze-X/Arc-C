using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200701C RID: 28700
	[Token(Token = "0x200701C")]
	public class ActMultiV3TrainingRoomViewModel : IHotfixable
	{
		// Token: 0x06028BBC RID: 166844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028BBC")]
		[Address(RVA = "0x24173F0", Offset = "0x2415FF0", VA = "0x1824173F0")]
		private ActMultiV3MapModeData _GetMapModeDataByModeType(ActMultiV3MapModeType modeType, Dictionary<string, ActMultiV3MapModeData> mapModeData)
		{
			return null;
		}

		// Token: 0x06028BBD RID: 166845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BBD")]
		[Address(RVA = "0x2416C30", Offset = "0x2415830", VA = "0x182416C30")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028BBE RID: 166846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BBE")]
		[Address(RVA = "0x2417350", Offset = "0x2415F50", VA = "0x182417350")]
		public void SetSelectedMode(int mode)
		{
		}

		// Token: 0x06028BBF RID: 166847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BBF")]
		[Address(RVA = "0x24175B0", Offset = "0x24161B0", VA = "0x1824175B0")]
		public ActMultiV3TrainingRoomViewModel()
		{
		}

		// Token: 0x0403A150 RID: 237904
		[Token(Token = "0x403A150")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403A151 RID: 237905
		[Token(Token = "0x403A151")]
		[FieldOffset(Offset = "0x18")]
		public int initSeqNum;

		// Token: 0x0403A152 RID: 237906
		[Token(Token = "0x403A152")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<int, ActMultiV3TrainingRoomModeViewModel> modeList;

		// Token: 0x0403A153 RID: 237907
		[Token(Token = "0x403A153")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> modeStarCount;

		// Token: 0x0403A154 RID: 237908
		[Token(Token = "0x403A154")]
		[FieldOffset(Offset = "0x30")]
		public ActMultiV3MapModeType selectedModeType;

		// Token: 0x0403A155 RID: 237909
		[Token(Token = "0x403A155")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetMapModeDataByModeType;

		// Token: 0x0403A156 RID: 237910
		[Token(Token = "0x403A156")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A157 RID: 237911
		[Token(Token = "0x403A157")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedMode;

		// Token: 0x0403A158 RID: 237912
		[Token(Token = "0x403A158")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
