using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B69 RID: 19305
	[Token(Token = "0x2004B69")]
	public class HomeCheckInViewModel : IHotfixable
	{
		// Token: 0x0601D0ED RID: 119021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0ED")]
		[Address(RVA = "0x169B8F0", Offset = "0x169A4F0", VA = "0x18169B8F0")]
		public void LoadData()
		{
		}

		// Token: 0x0601D0EE RID: 119022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0EE")]
		[Address(RVA = "0x169BC40", Offset = "0x169A840", VA = "0x18169BC40")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601D0EF RID: 119023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0EF")]
		[Address(RVA = "0x169BCB0", Offset = "0x169A8B0", VA = "0x18169BCB0")]
		public HomeCheckInViewModel()
		{
		}

		// Token: 0x040261E2 RID: 156130
		[Token(Token = "0x40261E2")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x040261E3 RID: 156131
		[Token(Token = "0x40261E3")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x040261E4 RID: 156132
		[Token(Token = "0x40261E4")]
		[FieldOffset(Offset = "0x20")]
		public List<MonthlySignInData> commonCheckInItemList;

		// Token: 0x040261E5 RID: 156133
		[Token(Token = "0x40261E5")]
		[FieldOffset(Offset = "0x28")]
		public ProgressCheckInViewModel progressViewModel;

		// Token: 0x040261E6 RID: 156134
		[Token(Token = "0x40261E6")]
		[FieldOffset(Offset = "0x30")]
		public int currCheckInIndex;

		// Token: 0x040261E7 RID: 156135
		[Token(Token = "0x40261E7")]
		[FieldOffset(Offset = "0x34")]
		public int focusIndex;

		// Token: 0x040261E8 RID: 156136
		[Token(Token = "0x40261E8")]
		[FieldOffset(Offset = "0x38")]
		public bool isItemGained;

		// Token: 0x040261E9 RID: 156137
		[Token(Token = "0x40261E9")]
		[FieldOffset(Offset = "0x39")]
		public bool isJustCheckIn;

		// Token: 0x040261EA RID: 156138
		[Token(Token = "0x40261EA")]
		[FieldOffset(Offset = "0x3A")]
		public bool showProgressGPDetail;

		// Token: 0x040261EB RID: 156139
		[Token(Token = "0x40261EB")]
		[FieldOffset(Offset = "0x3B")]
		public bool isLongTermCheckInOpen;

		// Token: 0x040261EC RID: 156140
		[Token(Token = "0x40261EC")]
		[FieldOffset(Offset = "0x3C")]
		public bool isLongTermCheckInCanReceive;

		// Token: 0x040261ED RID: 156141
		[Token(Token = "0x40261ED")]
		[FieldOffset(Offset = "0x3D")]
		public bool showLongTermCheckInTrackPoint;

		// Token: 0x040261EE RID: 156142
		[Token(Token = "0x40261EE")]
		[FieldOffset(Offset = "0x40")]
		private string m_groupId;

		// Token: 0x040261EF RID: 156143
		[Token(Token = "0x40261EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040261F0 RID: 156144
		[Token(Token = "0x40261F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040261F1 RID: 156145
		[Token(Token = "0x40261F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
