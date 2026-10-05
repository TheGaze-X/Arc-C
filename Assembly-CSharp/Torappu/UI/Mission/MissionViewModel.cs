using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004876 RID: 18550
	[Token(Token = "0x2004876")]
	public class MissionViewModel : IHotfixable
	{
		// Token: 0x0601C035 RID: 114741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C035")]
		[Address(RVA = "0x1570470", Offset = "0x156F070", VA = "0x181570470")]
		public MissionViewModel(int state_, int target_, int value_, List<MissionDisplayRewards> rewards, MissionData data_, [Optional] string backPath_, [Optional] string foldId_)
		{
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0601C036 RID: 114742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004296")]
		public string description
		{
			[Token(Token = "0x601C036")]
			[Address(RVA = "0x1570590", Offset = "0x156F190", VA = "0x181570590")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C037 RID: 114743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C037")]
		[Address(RVA = "0x1570100", Offset = "0x156ED00", VA = "0x181570100")]
		public static UIItemViewModel ChangeRewardDataType(MissionDisplayRewards data)
		{
			return null;
		}

		// Token: 0x0601C038 RID: 114744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C038")]
		[Address(RVA = "0x1570280", Offset = "0x156EE80", VA = "0x181570280")]
		public UIItemViewModel[] GetRewardPreviewItem()
		{
			return null;
		}

		// Token: 0x0601C039 RID: 114745 RVA: 0x000A6F08 File Offset: 0x000A5108
		[Token(Token = "0x601C039")]
		[Address(RVA = "0x1570190", Offset = "0x156ED90", VA = "0x181570190")]
		public bool CheckIfAbleToFinish()
		{
			return default(bool);
		}

		// Token: 0x0601C03A RID: 114746 RVA: 0x000A6F20 File Offset: 0x000A5120
		[Token(Token = "0x601C03A")]
		[Address(RVA = "0x1570200", Offset = "0x156EE00", VA = "0x181570200")]
		public float GetMissionProgress()
		{
			return 0f;
		}

		// Token: 0x040248C5 RID: 149701
		[Token(Token = "0x40248C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string missionText;

		// Token: 0x040248C6 RID: 149702
		[Token(Token = "0x40248C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string stringPath;

		// Token: 0x040248C7 RID: 149703
		[Token(Token = "0x40248C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MissionHoldingState state;

		// Token: 0x040248C8 RID: 149704
		[Token(Token = "0x40248C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int target;

		// Token: 0x040248C9 RID: 149705
		[Token(Token = "0x40248C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int value;

		// Token: 0x040248CA RID: 149706
		[Token(Token = "0x40248CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MissionData data;

		// Token: 0x040248CB RID: 149707
		[Token(Token = "0x40248CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<MissionDisplayRewards> rewardList;

		// Token: 0x040248CC RID: 149708
		[Token(Token = "0x40248CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string foldId;

		// Token: 0x040248CD RID: 149709
		[Token(Token = "0x40248CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040248CE RID: 149710
		[Token(Token = "0x40248CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x040248CF RID: 149711
		[Token(Token = "0x40248CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ChangeRewardDataType;

		// Token: 0x040248D0 RID: 149712
		[Token(Token = "0x40248D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRewardPreviewItem;

		// Token: 0x040248D1 RID: 149713
		[Token(Token = "0x40248D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfAbleToFinish;

		// Token: 0x040248D2 RID: 149714
		[Token(Token = "0x40248D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMissionProgress;
	}
}
