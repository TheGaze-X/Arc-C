using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.ActMainSS
{
	// Token: 0x020070A7 RID: 28839
	[Token(Token = "0x20070A7")]
	public class ActMainSSEntryZoneViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029006 RID: 167942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029006")]
		[Address(RVA = "0x2471B50", Offset = "0x2470750", VA = "0x182471B50")]
		public ActMainSSEntryZoneViewModel(object param)
		{
		}

		// Token: 0x06029007 RID: 167943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029007")]
		[Address(RVA = "0x2471A40", Offset = "0x2470640", VA = "0x182471A40")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403A85F RID: 239711
		[Token(Token = "0x403A85F")]
		[FieldOffset(Offset = "0x20")]
		public string zoneId;

		// Token: 0x0403A860 RID: 239712
		[Token(Token = "0x403A860")]
		[FieldOffset(Offset = "0x28")]
		public ActMainSSEntryZoneViewModel.Status currStatus;

		// Token: 0x0403A861 RID: 239713
		[Token(Token = "0x403A861")]
		[FieldOffset(Offset = "0x30")]
		public string lockedTip;

		// Token: 0x0403A862 RID: 239714
		[Token(Token = "0x403A862")]
		[FieldOffset(Offset = "0x38")]
		public string lockedTipAfterRetro;

		// Token: 0x0403A863 RID: 239715
		[Token(Token = "0x403A863")]
		[FieldOffset(Offset = "0x40")]
		public string retroZoneId;

		// Token: 0x0403A864 RID: 239716
		[Token(Token = "0x403A864")]
		[FieldOffset(Offset = "0x48")]
		public int currPoint;

		// Token: 0x0403A865 RID: 239717
		[Token(Token = "0x403A865")]
		[FieldOffset(Offset = "0x4C")]
		public bool isEnd;

		// Token: 0x0403A866 RID: 239718
		[Token(Token = "0x403A866")]
		[FieldOffset(Offset = "0x50")]
		private DateTime m_endTime;

		// Token: 0x0403A867 RID: 239719
		[Token(Token = "0x403A867")]
		[FieldOffset(Offset = "0x58")]
		private string m_milestoneGroupId;

		// Token: 0x0403A868 RID: 239720
		[Token(Token = "0x403A868")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403A869 RID: 239721
		[Token(Token = "0x403A869")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x020070A8 RID: 28840
		[Token(Token = "0x20070A8")]
		public enum Status
		{
			// Token: 0x0403A86B RID: 239723
			[Token(Token = "0x403A86B")]
			LOCKED,
			// Token: 0x0403A86C RID: 239724
			[Token(Token = "0x403A86C")]
			UNLOCK,
			// Token: 0x0403A86D RID: 239725
			[Token(Token = "0x403A86D")]
			RETRO
		}

		// Token: 0x020070A9 RID: 28841
		[Token(Token = "0x20070A9")]
		public class Input
		{
			// Token: 0x06029008 RID: 167944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029008")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A86E RID: 239726
			[Token(Token = "0x403A86E")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo basicInfo;

			// Token: 0x0403A86F RID: 239727
			[Token(Token = "0x403A86F")]
			[FieldOffset(Offset = "0x88")]
			public List<ActivityZoneViewModel> zoneList;

			// Token: 0x0403A870 RID: 239728
			[Token(Token = "0x403A870")]
			[FieldOffset(Offset = "0x90")]
			public Dictionary<string, ActMainSSZoneAdditionData> zoneAdditionDataMap;
		}
	}
}
