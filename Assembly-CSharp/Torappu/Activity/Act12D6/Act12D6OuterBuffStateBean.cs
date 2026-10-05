using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B0D RID: 31501
	[Token(Token = "0x2007B0D")]
	public class Act12D6OuterBuffStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602C1A6 RID: 180646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1A6")]
		[Address(RVA = "0x2810BA0", Offset = "0x280F7A0", VA = "0x182810BA0")]
		public void LoadData()
		{
		}

		// Token: 0x0602C1A7 RID: 180647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1A7")]
		[Address(RVA = "0x2810A90", Offset = "0x280F690", VA = "0x182810A90")]
		public PlayerOuterBuffData GetPlayerOuterBuffData(string buffId)
		{
			return null;
		}

		// Token: 0x0602C1A8 RID: 180648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1A8")]
		[Address(RVA = "0x2811160", Offset = "0x280FD60", VA = "0x182811160")]
		private RoguelikeOuterBuff _GenOuterBuffByLevel(int level, ActivityRoguelikeData.OuterBuffUnlockInfoData unlockInfos)
		{
			return null;
		}

		// Token: 0x0602C1A9 RID: 180649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1A9")]
		[Address(RVA = "0x2811370", Offset = "0x280FF70", VA = "0x182811370")]
		private PlayerOuterBuffData _GenPlayerOuterBuffData(int level, ActivityRoguelikeData.OuterBuffUnlockInfoData unlockInfos)
		{
			return null;
		}

		// Token: 0x0602C1AA RID: 180650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1AA")]
		[Address(RVA = "0x2811450", Offset = "0x2810050", VA = "0x182811450")]
		public Act12D6OuterBuffStateBean()
		{
		}

		// Token: 0x0403FF09 RID: 261897
		[Token(Token = "0x403FF09")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeOuterBuff> outerBuffs;

		// Token: 0x0403FF0A RID: 261898
		[Token(Token = "0x403FF0A")]
		private const int DEFAULT_BUFF_LEVEL = 0;

		// Token: 0x0403FF0B RID: 261899
		[Token(Token = "0x403FF0B")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, ActivityRoguelikeData.OuterBuffUnlockInfoData> m_unlockBuffInfos;

		// Token: 0x0403FF0C RID: 261900
		[Token(Token = "0x403FF0C")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, PlayerOuterBuffData> m_playerBuffInfos;

		// Token: 0x0403FF0D RID: 261901
		[Token(Token = "0x403FF0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403FF0E RID: 261902
		[Token(Token = "0x403FF0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerOuterBuffData;

		// Token: 0x0403FF0F RID: 261903
		[Token(Token = "0x403FF0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenOuterBuffByLevel;

		// Token: 0x0403FF10 RID: 261904
		[Token(Token = "0x403FF10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenPlayerOuterBuffData;

		// Token: 0x0403FF11 RID: 261905
		[Token(Token = "0x403FF11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
