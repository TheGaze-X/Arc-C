using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B90 RID: 19344
	[Token(Token = "0x2004B90")]
	public class MissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x0601D1AA RID: 119210 RVA: 0x000AA778 File Offset: 0x000A8978
		[Token(Token = "0x17004476")]
		public bool isShow
		{
			[Token(Token = "0x601D1AA")]
			[Address(RVA = "0x16AC420", Offset = "0x16AB020", VA = "0x1816AC420", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x0601D1AB RID: 119211 RVA: 0x000AA790 File Offset: 0x000A8990
		[Token(Token = "0x17004477")]
		public int finishedMissionNum
		{
			[Token(Token = "0x601D1AB")]
			[Address(RVA = "0x16AC3C0", Offset = "0x16AAFC0", VA = "0x1816AC3C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D1AC RID: 119212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D1AC")]
		[Address(RVA = "0x16AB7D0", Offset = "0x16AA3D0", VA = "0x1816AB7D0")]
		private IEnumerable<MissionPlayerState> MissionEnumeratorCombination(params Dictionary<string, MissionPlayerState>[] enumerators)
		{
			return null;
		}

		// Token: 0x0601D1AD RID: 119213 RVA: 0x000AA7A8 File Offset: 0x000A89A8
		[Token(Token = "0x601D1AD")]
		[Address(RVA = "0x16AB890", Offset = "0x16AA490", VA = "0x1816AB890")]
		private bool RewardAllGet(string key)
		{
			return default(bool);
		}

		// Token: 0x0601D1AE RID: 119214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1AE")]
		[Address(RVA = "0x16ABA40", Offset = "0x16AA640", VA = "0x1816ABA40", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1AF RID: 119215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1AF")]
		[Address(RVA = "0x16AC360", Offset = "0x16AAF60", VA = "0x1816AC360")]
		public MissionTrackPointModel()
		{
		}

		// Token: 0x04026323 RID: 156451
		[Token(Token = "0x4026323")]
		[FieldOffset(Offset = "0x10")]
		private int m_finishedMissionNum;

		// Token: 0x04026324 RID: 156452
		[Token(Token = "0x4026324")]
		[FieldOffset(Offset = "0x14")]
		private bool m_isUnlocked;

		// Token: 0x04026325 RID: 156453
		[Token(Token = "0x4026325")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026326 RID: 156454
		[Token(Token = "0x4026326")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_finishedMissionNum;

		// Token: 0x04026327 RID: 156455
		[Token(Token = "0x4026327")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_MissionEnumeratorCombination;

		// Token: 0x04026328 RID: 156456
		[Token(Token = "0x4026328")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RewardAllGet;

		// Token: 0x04026329 RID: 156457
		[Token(Token = "0x4026329")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402632A RID: 156458
		[Token(Token = "0x402632A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
