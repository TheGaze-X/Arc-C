using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075BB RID: 30139
	[Token(Token = "0x20075BB")]
	public abstract class Act24sideMeldingSwitchTweenAbstractHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A6AB RID: 173739
		[Token(Token = "0x602A6AB")]
		public abstract void Init();

		// Token: 0x0602A6AC RID: 173740
		[Token(Token = "0x602A6AC")]
		public abstract void RefreshData(Act24sideMeldingViewModel model);

		// Token: 0x0602A6AD RID: 173741
		[Token(Token = "0x602A6AD")]
		public abstract void TryPauseInputProgressTweening();

		// Token: 0x0602A6AE RID: 173742
		[Token(Token = "0x602A6AE")]
		public abstract void TryQuickInputMeldings();

		// Token: 0x0602A6AF RID: 173743
		[Token(Token = "0x602A6AF")]
		public abstract void ResetGachaBoxTween(bool isShow);

		// Token: 0x0602A6B0 RID: 173744
		[Token(Token = "0x602A6B0")]
		public abstract void ResetProgressTween();

		// Token: 0x0602A6B1 RID: 173745
		[Token(Token = "0x602A6B1")]
		public abstract void PlayProgressTween();

		// Token: 0x0602A6B2 RID: 173746
		[Token(Token = "0x602A6B2")]
		public abstract void SetGachaBoxTween(bool isShow);

		// Token: 0x0602A6B3 RID: 173747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A6B3")]
		[Address(RVA = "0x2610A70", Offset = "0x260F670", VA = "0x182610A70")]
		protected Act24sideMeldingSwitchTweenAbstractHolder()
		{
		}

		// Token: 0x0403D0A9 RID: 250025
		[Token(Token = "0x403D0A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
