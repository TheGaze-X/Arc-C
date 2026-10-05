using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007664 RID: 30308
	[Token(Token = "0x2007664")]
	public class Act20sideCartShowStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AA0B RID: 174603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA0B")]
		[Address(RVA = "0x2655F20", Offset = "0x2654B20", VA = "0x182655F20")]
		public void InitData()
		{
		}

		// Token: 0x0602AA0C RID: 174604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA0C")]
		[Address(RVA = "0x2656610", Offset = "0x2655210", VA = "0x182656610")]
		public Act20sideCartShowStateBean()
		{
		}

		// Token: 0x0403D64B RID: 251467
		[Token(Token = "0x403D64B")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403D64C RID: 251468
		[Token(Token = "0x403D64C")]
		[FieldOffset(Offset = "0x18")]
		public bool isRetro;

		// Token: 0x0403D64D RID: 251469
		[Token(Token = "0x403D64D")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<CartComponents.CartAccessoryPos, CartCompViewModel> compsOnCar;

		// Token: 0x0403D64E RID: 251470
		[Token(Token = "0x403D64E")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CartCompViewModel> cartCompList;

		// Token: 0x0403D64F RID: 251471
		[Token(Token = "0x403D64F")]
		[FieldOffset(Offset = "0x30")]
		public PlayerCartInfo.Cart currentCart;

		// Token: 0x0403D650 RID: 251472
		[Token(Token = "0x403D650")]
		[FieldOffset(Offset = "0x38")]
		public bool spStageUnlocked;

		// Token: 0x0403D651 RID: 251473
		[Token(Token = "0x403D651")]
		[FieldOffset(Offset = "0x3C")]
		public int spStageUnlockCount;

		// Token: 0x0403D652 RID: 251474
		[Token(Token = "0x403D652")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403D653 RID: 251475
		[Token(Token = "0x403D653")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
