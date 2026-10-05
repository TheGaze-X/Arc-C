using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007678 RID: 30328
	[Token(Token = "0x2007678")]
	public class Act20sideCartCompSelectStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0602AA90 RID: 174736 RVA: 0x000D9590 File Offset: 0x000D7790
		[Token(Token = "0x602AA90")]
		[Address(RVA = "0x266E740", Offset = "0x266D340", VA = "0x18266E740")]
		public bool GetChangeFlag()
		{
			return default(bool);
		}

		// Token: 0x0602AA91 RID: 174737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA91")]
		[Address(RVA = "0x266E7D0", Offset = "0x266D3D0", VA = "0x18266E7D0")]
		public void InitInfo(string actId, bool isExhib)
		{
		}

		// Token: 0x0602AA92 RID: 174738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA92")]
		[Address(RVA = "0x266EEF0", Offset = "0x266DAF0", VA = "0x18266EEF0")]
		public Act20sideCartCompSelectStateBean()
		{
		}

		// Token: 0x0403D6FA RID: 251642
		[Token(Token = "0x403D6FA")]
		private const CartComponents.CartAccessoryPos DEFAULT_SELECT_POS = CartComponents.CartAccessoryPos.ROOF;

		// Token: 0x0403D6FB RID: 251643
		[Token(Token = "0x403D6FB")]
		[FieldOffset(Offset = "0x18")]
		public Act20sideCartCompSelectProperty property;

		// Token: 0x0403D6FC RID: 251644
		[Token(Token = "0x403D6FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChangeFlag;

		// Token: 0x0403D6FD RID: 251645
		[Token(Token = "0x403D6FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403D6FE RID: 251646
		[Token(Token = "0x403D6FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
