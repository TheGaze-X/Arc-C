using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048CE RID: 18638
	[Token(Token = "0x20048CE")]
	public class MiniActTrialRewardItemModel : IHotfixable
	{
		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0601C1D5 RID: 115157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042C6")]
		public string actId
		{
			[Token(Token = "0x601C1D5")]
			[Address(RVA = "0x159B6D0", Offset = "0x159A2D0", VA = "0x18159B6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0601C1D6 RID: 115158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042C7")]
		public ItemBundle itemBundle
		{
			[Token(Token = "0x601C1D6")]
			[Address(RVA = "0x159B730", Offset = "0x159A330", VA = "0x18159B730")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0601C1D7 RID: 115159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042C8")]
		public string rewardId
		{
			[Token(Token = "0x601C1D7")]
			[Address(RVA = "0x159B800", Offset = "0x159A400", VA = "0x18159B800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x0601C1D8 RID: 115160 RVA: 0x000A7478 File Offset: 0x000A5678
		[Token(Token = "0x170042C9")]
		public bool meetCond
		{
			[Token(Token = "0x601C1D8")]
			[Address(RVA = "0x159B7A0", Offset = "0x159A3A0", VA = "0x18159B7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0601C1D9 RID: 115161 RVA: 0x000A7490 File Offset: 0x000A5690
		[Token(Token = "0x170042CA")]
		public int targetCount
		{
			[Token(Token = "0x601C1D9")]
			[Address(RVA = "0x159B870", Offset = "0x159A470", VA = "0x18159B870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0601C1DA RID: 115162 RVA: 0x000A74A8 File Offset: 0x000A56A8
		[Token(Token = "0x170042CB")]
		public Color themeColor
		{
			[Token(Token = "0x601C1DA")]
			[Address(RVA = "0x159B8E0", Offset = "0x159A4E0", VA = "0x18159B8E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601C1DB RID: 115163 RVA: 0x000A74C0 File Offset: 0x000A56C0
		[Token(Token = "0x601C1DB")]
		[Address(RVA = "0x159B410", Offset = "0x159A010", VA = "0x18159B410")]
		public bool IsGot()
		{
			return default(bool);
		}

		// Token: 0x0601C1DC RID: 115164 RVA: 0x000A74D8 File Offset: 0x000A56D8
		[Token(Token = "0x601C1DC")]
		[Address(RVA = "0x159B3A0", Offset = "0x1599FA0", VA = "0x18159B3A0")]
		public bool CanCollect()
		{
			return default(bool);
		}

		// Token: 0x0601C1DD RID: 115165 RVA: 0x000A74F0 File Offset: 0x000A56F0
		[Token(Token = "0x601C1DD")]
		[Address(RVA = "0x159B500", Offset = "0x159A100", VA = "0x18159B500")]
		public bool IsItemAvail()
		{
			return default(bool);
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1DE")]
		[Address(RVA = "0x159B590", Offset = "0x159A190", VA = "0x18159B590")]
		public void LoadData(string actId, MiniActTrialData.MiniActTrialRewardData rewardData, bool isGot, bool meetCondition, string themeColor)
		{
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1DF")]
		[Address(RVA = "0x159B670", Offset = "0x159A270", VA = "0x18159B670")]
		public MiniActTrialRewardItemModel()
		{
		}

		// Token: 0x04024C20 RID: 150560
		[Token(Token = "0x4024C20")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04024C21 RID: 150561
		[Token(Token = "0x4024C21")]
		[FieldOffset(Offset = "0x18")]
		private MiniActTrialData.MiniActTrialRewardData m_rewardData;

		// Token: 0x04024C22 RID: 150562
		[Token(Token = "0x4024C22")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isGot;

		// Token: 0x04024C23 RID: 150563
		[Token(Token = "0x4024C23")]
		[FieldOffset(Offset = "0x21")]
		private bool m_meetCondition;

		// Token: 0x04024C24 RID: 150564
		[Token(Token = "0x4024C24")]
		[FieldOffset(Offset = "0x28")]
		private string m_themeColor;

		// Token: 0x04024C25 RID: 150565
		[Token(Token = "0x4024C25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04024C26 RID: 150566
		[Token(Token = "0x4024C26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemBundle;

		// Token: 0x04024C27 RID: 150567
		[Token(Token = "0x4024C27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rewardId;

		// Token: 0x04024C28 RID: 150568
		[Token(Token = "0x4024C28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_meetCond;

		// Token: 0x04024C29 RID: 150569
		[Token(Token = "0x4024C29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_targetCount;

		// Token: 0x04024C2A RID: 150570
		[Token(Token = "0x4024C2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x04024C2B RID: 150571
		[Token(Token = "0x4024C2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsGot;

		// Token: 0x04024C2C RID: 150572
		[Token(Token = "0x4024C2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CanCollect;

		// Token: 0x04024C2D RID: 150573
		[Token(Token = "0x4024C2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsItemAvail;

		// Token: 0x04024C2E RID: 150574
		[Token(Token = "0x4024C2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024C2F RID: 150575
		[Token(Token = "0x4024C2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
