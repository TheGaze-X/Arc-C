using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CC0 RID: 19648
	[Token(Token = "0x2004CC0")]
	public class GroceryHomeLaunchPanelGoodGroupModel : IHotfixable, IComparable
	{
		// Token: 0x0601D6FF RID: 120575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6FF")]
		[Address(RVA = "0x16F56C0", Offset = "0x16F42C0", VA = "0x1816F56C0")]
		public void LoadData(Act27SideData.Act27SideGoodLaunchData launchData, Dictionary<string, Act27SideData.Act27SideGoodData> goodMap)
		{
		}

		// Token: 0x0601D700 RID: 120576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D700")]
		[Address(RVA = "0x16F5A80", Offset = "0x16F4680", VA = "0x1816F5A80")]
		public void RefreshPlayeyData(PlayerActivity.PlayerAct27SideActivity playerData, long curTs, long endTs)
		{
		}

		// Token: 0x0601D701 RID: 120577 RVA: 0x000AB6F0 File Offset: 0x000A98F0
		[Token(Token = "0x601D701")]
		[Address(RVA = "0x16F55C0", Offset = "0x16F41C0", VA = "0x1816F55C0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601D702 RID: 120578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D702")]
		[Address(RVA = "0x16F5CC0", Offset = "0x16F48C0", VA = "0x1816F5CC0")]
		public GroceryHomeLaunchPanelGoodGroupModel()
		{
		}

		// Token: 0x04026CB1 RID: 158897
		[Token(Token = "0x4026CB1")]
		private const string START_TIME_FORMAT = "{0}.{1}";

		// Token: 0x04026CB2 RID: 158898
		[Token(Token = "0x4026CB2")]
		[FieldOffset(Offset = "0x10")]
		public List<GroceryHomeGoodItemModel> goodModelList;

		// Token: 0x04026CB3 RID: 158899
		[Token(Token = "0x4026CB3")]
		[FieldOffset(Offset = "0x18")]
		public GroceryHomeLaunchPanelGoodGroupModel.Status status;

		// Token: 0x04026CB4 RID: 158900
		[Token(Token = "0x4026CB4")]
		[FieldOffset(Offset = "0x20")]
		public string unlockDesc;

		// Token: 0x04026CB5 RID: 158901
		[Token(Token = "0x4026CB5")]
		[FieldOffset(Offset = "0x28")]
		public string groupGoodNameDesc;

		// Token: 0x04026CB6 RID: 158902
		[Token(Token = "0x4026CB6")]
		[FieldOffset(Offset = "0x30")]
		public string startTimeDesc;

		// Token: 0x04026CB7 RID: 158903
		[Token(Token = "0x4026CB7")]
		[FieldOffset(Offset = "0x38")]
		public long startTs;

		// Token: 0x04026CB8 RID: 158904
		[Token(Token = "0x4026CB8")]
		[FieldOffset(Offset = "0x40")]
		public string groupId;

		// Token: 0x04026CB9 RID: 158905
		[Token(Token = "0x4026CB9")]
		[FieldOffset(Offset = "0x48")]
		private string m_bindStageId;

		// Token: 0x04026CBA RID: 158906
		[Token(Token = "0x4026CBA")]
		[FieldOffset(Offset = "0x50")]
		private string m_bindStageCode;

		// Token: 0x04026CBB RID: 158907
		[Token(Token = "0x4026CBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026CBC RID: 158908
		[Token(Token = "0x4026CBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayeyData;

		// Token: 0x04026CBD RID: 158909
		[Token(Token = "0x4026CBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04026CBE RID: 158910
		[Token(Token = "0x4026CBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CC1 RID: 19649
		[Token(Token = "0x2004CC1")]
		public enum Status
		{
			// Token: 0x04026CC0 RID: 158912
			[Token(Token = "0x4026CC0")]
			STAGE_LOCKED,
			// Token: 0x04026CC1 RID: 158913
			[Token(Token = "0x4026CC1")]
			TIME_LOCKED,
			// Token: 0x04026CC2 RID: 158914
			[Token(Token = "0x4026CC2")]
			UNLOCKED,
			// Token: 0x04026CC3 RID: 158915
			[Token(Token = "0x4026CC3")]
			OUTDATED
		}
	}
}
