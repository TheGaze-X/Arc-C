using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007627 RID: 30247
	[Token(Token = "0x2007627")]
	public class Act20sideActivityController : TemplateActivityController
	{
		// Token: 0x0602A940 RID: 174400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A940")]
		[Address(RVA = "0x264E790", Offset = "0x264D390", VA = "0x18264E790", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A941 RID: 174401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A941")]
		[Address(RVA = "0x264F5F0", Offset = "0x264E1F0", VA = "0x18264F5F0")]
		private PlayerActivity.PlayerAct20SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602A942 RID: 174402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A942")]
		[Address(RVA = "0x264F1A0", Offset = "0x264DDA0", VA = "0x18264F1A0")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A943 RID: 174403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A943")]
		[Address(RVA = "0x264F4E0", Offset = "0x264E0E0", VA = "0x18264F4E0")]
		private TemplateActivityFavorViewModel _GeneFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A944 RID: 174404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A944")]
		[Address(RVA = "0x264F080", Offset = "0x264DC80", VA = "0x18264F080")]
		private TemplateActivityCoinViewModel _GenCoinStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A945 RID: 174405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A945")]
		[Address(RVA = "0x264EFA0", Offset = "0x264DBA0", VA = "0x18264EFA0")]
		private TemplateActivityViewModel _GenCartCompViewModel()
		{
			return null;
		}

		// Token: 0x0602A946 RID: 174406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A946")]
		[Address(RVA = "0x264F2B0", Offset = "0x264DEB0", VA = "0x18264F2B0")]
		private TemplateActivityZoneGroupViewModel _GenZoneViewModel()
		{
			return null;
		}

		// Token: 0x0602A947 RID: 174407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A947")]
		[Address(RVA = "0x264EE00", Offset = "0x264DA00", VA = "0x18264EE00")]
		private TemplateActivityMissionGroupViewModel _GenActivityMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A948 RID: 174408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A948")]
		[Address(RVA = "0x264F720", Offset = "0x264E320", VA = "0x18264F720")]
		public Act20sideActivityController()
		{
		}

		// Token: 0x0403D4D9 RID: 251097
		[Token(Token = "0x403D4D9")]
		private const string CART_COMP_VIEWMODEL = "act20side_cart_comp";

		// Token: 0x0403D4DA RID: 251098
		[Token(Token = "0x403D4DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403D4DB RID: 251099
		[Token(Token = "0x403D4DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403D4DC RID: 251100
		[Token(Token = "0x403D4DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403D4DD RID: 251101
		[Token(Token = "0x403D4DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GeneFavorStateViewModel;

		// Token: 0x0403D4DE RID: 251102
		[Token(Token = "0x403D4DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenCoinStateViewModel;

		// Token: 0x0403D4DF RID: 251103
		[Token(Token = "0x403D4DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenCartCompViewModel;

		// Token: 0x0403D4E0 RID: 251104
		[Token(Token = "0x403D4E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403D4E1 RID: 251105
		[Token(Token = "0x403D4E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenActivityMissionViewModel;

		// Token: 0x0403D4E2 RID: 251106
		[Token(Token = "0x403D4E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
