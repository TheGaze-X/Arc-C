using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007636 RID: 30262
	[Token(Token = "0x2007636")]
	public class EntertainCompBattleStartConfig : StartBattleServiceConfig<CarCompetitionStartRequest, CarCompetitionStartResponse>
	{
		// Token: 0x0602A992 RID: 174482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A992")]
		[Address(RVA = "0x26644B0", Offset = "0x26630B0", VA = "0x1826644B0")]
		public EntertainCompBattleStartConfig(string actId, string stageId, PlayerCartInfo.Cart car)
		{
		}

		// Token: 0x0602A993 RID: 174483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A993")]
		[Address(RVA = "0x26643F0", Offset = "0x2662FF0", VA = "0x1826643F0", Slot = "5")]
		protected override CarCompetitionStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x0602A994 RID: 174484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006431")]
		protected override string serviceCode
		{
			[Token(Token = "0x602A994")]
			[Address(RVA = "0x2664580", Offset = "0x2663180", VA = "0x182664580", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0403D550 RID: 251216
		[Token(Token = "0x403D550")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x0403D551 RID: 251217
		[Token(Token = "0x403D551")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403D552 RID: 251218
		[Token(Token = "0x403D552")]
		[FieldOffset(Offset = "0x20")]
		private PlayerCartInfo.Cart m_car;

		// Token: 0x0403D553 RID: 251219
		[Token(Token = "0x403D553")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403D554 RID: 251220
		[Token(Token = "0x403D554")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x0403D555 RID: 251221
		[Token(Token = "0x403D555")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
