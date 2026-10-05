using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007637 RID: 30263
	[Token(Token = "0x2007637")]
	public class RetroEntertainCompBattleStartConfig : StartBattleServiceConfig<RetroCarCompetitionStartRequest, RetroCarCompetitionStartResponse>
	{
		// Token: 0x0602A995 RID: 174485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A995")]
		[Address(RVA = "0x26658E0", Offset = "0x26644E0", VA = "0x1826658E0")]
		public RetroEntertainCompBattleStartConfig(string retroId, string stageId, PlayerCartInfo.Cart car)
		{
		}

		// Token: 0x0602A996 RID: 174486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A996")]
		[Address(RVA = "0x2665820", Offset = "0x2664420", VA = "0x182665820", Slot = "5")]
		protected override RetroCarCompetitionStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x0602A997 RID: 174487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006432")]
		protected override string serviceCode
		{
			[Token(Token = "0x602A997")]
			[Address(RVA = "0x26659B0", Offset = "0x26645B0", VA = "0x1826659B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0403D556 RID: 251222
		[Token(Token = "0x403D556")]
		[FieldOffset(Offset = "0x10")]
		private string m_retroId;

		// Token: 0x0403D557 RID: 251223
		[Token(Token = "0x403D557")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403D558 RID: 251224
		[Token(Token = "0x403D558")]
		[FieldOffset(Offset = "0x20")]
		private PlayerCartInfo.Cart m_car;

		// Token: 0x0403D559 RID: 251225
		[Token(Token = "0x403D559")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403D55A RID: 251226
		[Token(Token = "0x403D55A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x0403D55B RID: 251227
		[Token(Token = "0x403D55B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
