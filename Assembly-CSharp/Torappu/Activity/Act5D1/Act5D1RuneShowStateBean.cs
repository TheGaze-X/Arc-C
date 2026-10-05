using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007263 RID: 29283
	[Token(Token = "0x2007263")]
	public class Act5D1RuneShowStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x060297D8 RID: 169944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D8")]
		[Address(RVA = "0x24E7520", Offset = "0x24E6120", VA = "0x1824E7520")]
		public void Apply(List<RuneShowInfo> inputShowList, bool iCannotUseBenefit)
		{
		}

		// Token: 0x060297D9 RID: 169945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D9")]
		[Address(RVA = "0x24E75C0", Offset = "0x24E61C0", VA = "0x1824E75C0")]
		public Act5D1RuneShowStateBean()
		{
		}

		// Token: 0x0403B497 RID: 242839
		[Token(Token = "0x403B497")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RuneShowInfo> runeShowList;

		// Token: 0x0403B498 RID: 242840
		[Token(Token = "0x403B498")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public bool cannotUseBenefit;

		// Token: 0x0403B499 RID: 242841
		[Token(Token = "0x403B499")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0403B49A RID: 242842
		[Token(Token = "0x403B49A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
