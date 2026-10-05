using System;
using Il2CppDummyDll;
using Torappu.Activity.Act17side;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act21side
{
	// Token: 0x0200761F RID: 30239
	[Token(Token = "0x200761F")]
	public class Act21sideActivityController : TemplateActivityController
	{
		// Token: 0x0602A926 RID: 174374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A926")]
		[Address(RVA = "0x265B0C0", Offset = "0x2659CC0", VA = "0x18265B0C0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602A927 RID: 174375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A927")]
		[Address(RVA = "0x265BE10", Offset = "0x265AA10", VA = "0x18265BE10")]
		private PlayerActivity.PlayerAct21SideActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602A928 RID: 174376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A928")]
		[Address(RVA = "0x265BB80", Offset = "0x265A780", VA = "0x18265BB80")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602A929 RID: 174377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A929")]
		[Address(RVA = "0x265BA70", Offset = "0x265A670", VA = "0x18265BA70")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602A92A RID: 174378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A92A")]
		[Address(RVA = "0x265B950", Offset = "0x265A550", VA = "0x18265B950")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602A92B RID: 174379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A92B")]
		[Address(RVA = "0x265BC90", Offset = "0x265A890", VA = "0x18265BC90")]
		private Act21sideActivityZoneGroupViewModel _GenMapViewModel()
		{
			return null;
		}

		// Token: 0x0602A92C RID: 174380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A92C")]
		[Address(RVA = "0x265B7B0", Offset = "0x265A3B0", VA = "0x18265B7B0")]
		private TemplateActivityMissionGroupViewModel _GenActivityMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602A92D RID: 174381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A92D")]
		[Address(RVA = "0x265BF40", Offset = "0x265AB40", VA = "0x18265BF40")]
		public Act21sideActivityController()
		{
		}

		// Token: 0x0403D4AC RID: 251052
		[Token(Token = "0x403D4AC")]
		private const string MAP_PARAM = "act21side_map";

		// Token: 0x0403D4AD RID: 251053
		[Token(Token = "0x403D4AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403D4AE RID: 251054
		[Token(Token = "0x403D4AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403D4AF RID: 251055
		[Token(Token = "0x403D4AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403D4B0 RID: 251056
		[Token(Token = "0x403D4B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403D4B1 RID: 251057
		[Token(Token = "0x403D4B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403D4B2 RID: 251058
		[Token(Token = "0x403D4B2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenMapViewModel;

		// Token: 0x0403D4B3 RID: 251059
		[Token(Token = "0x403D4B3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenActivityMissionViewModel;

		// Token: 0x0403D4B4 RID: 251060
		[Token(Token = "0x403D4B4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
