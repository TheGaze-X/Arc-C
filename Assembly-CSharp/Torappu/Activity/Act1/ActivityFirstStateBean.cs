using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.Mission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B5E RID: 31582
	[Token(Token = "0x2007B5E")]
	public class ActivityFirstStateBean : ActivityStageSingleComponent, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0602C347 RID: 181063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C347")]
		[Address(RVA = "0x281EA00", Offset = "0x281D600", VA = "0x18281EA00")]
		public void InitMissionData()
		{
		}

		// Token: 0x0602C348 RID: 181064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C348")]
		[Address(RVA = "0x281ED30", Offset = "0x281D930", VA = "0x18281ED30")]
		public void InitState(string activityId)
		{
		}

		// Token: 0x0602C349 RID: 181065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C349")]
		[Address(RVA = "0x281EDF0", Offset = "0x281D9F0", VA = "0x18281EDF0")]
		public ActivityFirstStateBean()
		{
		}

		// Token: 0x0404015B RID: 262491
		[Token(Token = "0x404015B")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<MissionViewModel> missionList;

		// Token: 0x0404015C RID: 262492
		[Token(Token = "0x404015C")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public List<ActivityShopData> cacheShopList;

		// Token: 0x0404015D RID: 262493
		[Token(Token = "0x404015D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ActivityShopData cacheData;

		// Token: 0x0404015E RID: 262494
		[Token(Token = "0x404015E")]
		[FieldOffset(Offset = "0x38")]
		public ActivityFirstMapProperty mapProperty;

		// Token: 0x0404015F RID: 262495
		[Token(Token = "0x404015F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitMissionData;

		// Token: 0x04040160 RID: 262496
		[Token(Token = "0x4040160")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitState;

		// Token: 0x04040161 RID: 262497
		[Token(Token = "0x4040161")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
