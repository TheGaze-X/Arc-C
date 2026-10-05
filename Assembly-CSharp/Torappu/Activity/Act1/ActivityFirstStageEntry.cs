using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B3E RID: 31550
	[Token(Token = "0x2007B3E")]
	public class ActivityFirstStageEntry : ActivityStageSingleComponent
	{
		// Token: 0x0602C2A4 RID: 180900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A4")]
		[Address(RVA = "0x2816FB0", Offset = "0x2815BB0", VA = "0x182816FB0")]
		public void InitData()
		{
		}

		// Token: 0x0602C2A5 RID: 180901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A5")]
		[Address(RVA = "0x2816B80", Offset = "0x2815780", VA = "0x182816B80")]
		public void EventOnButtonClicked()
		{
		}

		// Token: 0x0602C2A6 RID: 180902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A6")]
		[Address(RVA = "0x2816CC0", Offset = "0x28158C0", VA = "0x182816CC0")]
		public void EventOnMissionShopClicked()
		{
		}

		// Token: 0x0602C2A7 RID: 180903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A7")]
		[Address(RVA = "0x2816C20", Offset = "0x2815820", VA = "0x182816C20")]
		public void EventOnDetailClicked()
		{
		}

		// Token: 0x0602C2A8 RID: 180904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A8")]
		[Address(RVA = "0x2816D60", Offset = "0x2815960", VA = "0x182816D60")]
		public void EventOnToZoneMapClicked()
		{
		}

		// Token: 0x0602C2A9 RID: 180905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A9")]
		[Address(RVA = "0x2816E20", Offset = "0x2815A20", VA = "0x182816E20")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0602C2AA RID: 180906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2AA")]
		[Address(RVA = "0x2817B50", Offset = "0x2816750", VA = "0x182817B50")]
		private static string _FormatEndTime(DateTime endTime)
		{
			return null;
		}

		// Token: 0x0602C2AB RID: 180907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2AB")]
		[Address(RVA = "0x2817DD0", Offset = "0x28169D0", VA = "0x182817DD0")]
		public ActivityFirstStageEntry()
		{
		}

		// Token: 0x0404005F RID: 262239
		[Token(Token = "0x404005F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _maskDetail;

		// Token: 0x04040060 RID: 262240
		[Token(Token = "0x4040060")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x04040061 RID: 262241
		[Token(Token = "0x4040061")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeBar;

		// Token: 0x04040062 RID: 262242
		[Token(Token = "0x4040062")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _timeRemain;

		// Token: 0x04040063 RID: 262243
		[Token(Token = "0x4040063")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _mapAbleState;

		// Token: 0x04040064 RID: 262244
		[Token(Token = "0x4040064")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _mapDisableState;

		// Token: 0x04040065 RID: 262245
		[Token(Token = "0x4040065")]
		[FieldOffset(Offset = "0x50")]
		private DateTime m_cacheEndTime;

		// Token: 0x04040066 RID: 262246
		[Token(Token = "0x4040066")]
		[FieldOffset(Offset = "0x58")]
		private ActivityBasicInfo m_cacheBasicInfo;

		// Token: 0x04040067 RID: 262247
		[Token(Token = "0x4040067")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04040068 RID: 262248
		[Token(Token = "0x4040068")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnButtonClicked;

		// Token: 0x04040069 RID: 262249
		[Token(Token = "0x4040069")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMissionShopClicked;

		// Token: 0x0404006A RID: 262250
		[Token(Token = "0x404006A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnDetailClicked;

		// Token: 0x0404006B RID: 262251
		[Token(Token = "0x404006B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnToZoneMapClicked;

		// Token: 0x0404006C RID: 262252
		[Token(Token = "0x404006C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0404006D RID: 262253
		[Token(Token = "0x404006D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FormatEndTime;

		// Token: 0x0404006E RID: 262254
		[Token(Token = "0x404006E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
