using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076BD RID: 30397
	[Token(Token = "0x20076BD")]
	public class Act1VHalfIdleBattleStartServiceConfig : StartBattleServiceConfig<Act1VHalfIdleBattleStartRequest, Act1VHalfIdleBattleStartResponse>
	{
		// Token: 0x0602AC01 RID: 175105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC01")]
		[Address(RVA = "0x2682210", Offset = "0x2680E10", VA = "0x182682210")]
		public Act1VHalfIdleBattleStartServiceConfig(BattleStartParam input)
		{
		}

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x0602AC02 RID: 175106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006469")]
		protected override string serviceCode
		{
			[Token(Token = "0x602AC02")]
			[Address(RVA = "0x2682390", Offset = "0x2680F90", VA = "0x182682390", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AC03 RID: 175107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC03")]
		[Address(RVA = "0x2681F50", Offset = "0x2680B50", VA = "0x182681F50", Slot = "5")]
		protected override Act1VHalfIdleBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403D994 RID: 252308
		[Token(Token = "0x403D994")]
		[FieldOffset(Offset = "0x10")]
		private BattleStartParam m_param;

		// Token: 0x0403D995 RID: 252309
		[Token(Token = "0x403D995")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403D996 RID: 252310
		[Token(Token = "0x403D996")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403D997 RID: 252311
		[Token(Token = "0x403D997")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
