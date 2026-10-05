using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DB7 RID: 28087
	[Token(Token = "0x2006DB7")]
	public class ActivityCommonCheckinViewModel : IHotfixable
	{
		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x06027FE7 RID: 163815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E7F")]
		public DefaultCheckInData.DynamicCheckInData dynCheckinData
		{
			[Token(Token = "0x6027FE7")]
			[Address(RVA = "0x233AC80", Offset = "0x2339880", VA = "0x18233AC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x06027FE8 RID: 163816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E80")]
		public Dictionary<string, DefaultCheckInData.OptionInfo> dynOptionInfoDict
		{
			[Token(Token = "0x6027FE8")]
			[Address(RVA = "0x233ACE0", Offset = "0x23398E0", VA = "0x18233ACE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x06027FE9 RID: 163817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E81")]
		public Dictionary<string, List<ItemBundle>> dynOptionRewardItemDict
		{
			[Token(Token = "0x6027FE9")]
			[Address(RVA = "0x233AD50", Offset = "0x2339950", VA = "0x18233AD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x06027FEA RID: 163818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E82")]
		public Dictionary<string, DefaultCheckInData.DynCheckInDailyInfo> dynCheckInDict
		{
			[Token(Token = "0x6027FEA")]
			[Address(RVA = "0x233AC10", Offset = "0x2339810", VA = "0x18233AC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x06027FEB RID: 163819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E83")]
		public List<DefaultCheckInData.ExtraCheckinDailyInfo> extraCheckInList
		{
			[Token(Token = "0x6027FEB")]
			[Address(RVA = "0x233ADC0", Offset = "0x23399C0", VA = "0x18233ADC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027FEC RID: 163820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FEC")]
		[Address(RVA = "0x233A250", Offset = "0x2338E50", VA = "0x18233A250")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06027FED RID: 163821 RVA: 0x000D0488 File Offset: 0x000CE688
		[Token(Token = "0x6027FED")]
		[Address(RVA = "0x233AAD0", Offset = "0x23396D0", VA = "0x18233AAD0")]
		private static long _GetApItemOutTime(Dictionary<string, long> apSupplyOutOfDateDict)
		{
			return 0L;
		}

		// Token: 0x06027FEE RID: 163822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027FEE")]
		[Address(RVA = "0x233A6C0", Offset = "0x23392C0", VA = "0x18233A6C0")]
		private static string _GeneOpenTimeStr(string actId)
		{
			return null;
		}

		// Token: 0x06027FEF RID: 163823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FEF")]
		[Address(RVA = "0x233AB80", Offset = "0x2339780", VA = "0x18233AB80")]
		public ActivityCommonCheckinViewModel()
		{
		}

		// Token: 0x04038B2C RID: 232236
		[Token(Token = "0x4038B2C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04038B2D RID: 232237
		[Token(Token = "0x4038B2D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, DefaultCheckInData.CheckInDailyInfo> normalCheckinDict;

		// Token: 0x04038B2E RID: 232238
		[Token(Token = "0x4038B2E")]
		[FieldOffset(Offset = "0x20")]
		public long apOutTimeStamp;

		// Token: 0x04038B2F RID: 232239
		[Token(Token = "0x4038B2F")]
		[FieldOffset(Offset = "0x28")]
		public string openTimeStr;

		// Token: 0x04038B30 RID: 232240
		[Token(Token = "0x4038B30")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerCheckinOnlyTypeActivity playerInfo;

		// Token: 0x04038B31 RID: 232241
		[Token(Token = "0x4038B31")]
		[FieldOffset(Offset = "0x38")]
		public bool isWithDynCheckin;

		// Token: 0x04038B32 RID: 232242
		[Token(Token = "0x4038B32")]
		[FieldOffset(Offset = "0x39")]
		public bool needDynViewByPlayerData;

		// Token: 0x04038B33 RID: 232243
		[Token(Token = "0x4038B33")]
		[FieldOffset(Offset = "0x40")]
		public DefaultCheckInData.DynCheckInDailyInfo currentCheckinInfo;

		// Token: 0x04038B34 RID: 232244
		[Token(Token = "0x4038B34")]
		[FieldOffset(Offset = "0x48")]
		private DefaultCheckInData.DynamicCheckInData m_dynamicCheckInData;

		// Token: 0x04038B35 RID: 232245
		[Token(Token = "0x4038B35")]
		[FieldOffset(Offset = "0x50")]
		private List<DefaultCheckInData.ExtraCheckinDailyInfo> m_extraCheckinList;

		// Token: 0x04038B36 RID: 232246
		[Token(Token = "0x4038B36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dynCheckinData;

		// Token: 0x04038B37 RID: 232247
		[Token(Token = "0x4038B37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dynOptionInfoDict;

		// Token: 0x04038B38 RID: 232248
		[Token(Token = "0x4038B38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dynOptionRewardItemDict;

		// Token: 0x04038B39 RID: 232249
		[Token(Token = "0x4038B39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dynCheckInDict;

		// Token: 0x04038B3A RID: 232250
		[Token(Token = "0x4038B3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_extraCheckInList;

		// Token: 0x04038B3B RID: 232251
		[Token(Token = "0x4038B3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038B3C RID: 232252
		[Token(Token = "0x4038B3C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetApItemOutTime;

		// Token: 0x04038B3D RID: 232253
		[Token(Token = "0x4038B3D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GeneOpenTimeStr;

		// Token: 0x04038B3E RID: 232254
		[Token(Token = "0x4038B3E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
