using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007562 RID: 30050
	[Token(Token = "0x2007562")]
	public class Act24sideBattleFinishMeldingDropInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x0602A507 RID: 173319 RVA: 0x000D8030 File Offset: 0x000D6230
		[Token(Token = "0x170063A1")]
		public bool rendering
		{
			[Token(Token = "0x602A507")]
			[Address(RVA = "0x25F42A0", Offset = "0x25F2EA0", VA = "0x1825F42A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A508 RID: 173320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A508")]
		[Address(RVA = "0x25F4180", Offset = "0x25F2D80", VA = "0x1825F4180")]
		public void Render(Act24sideBattleFinishMeldingDropViewModel viewModel)
		{
		}

		// Token: 0x0602A509 RID: 173321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A509")]
		[Address(RVA = "0x25F4230", Offset = "0x25F2E30", VA = "0x1825F4230")]
		public Act24sideBattleFinishMeldingDropInfoView()
		{
		}

		// Token: 0x0403CD84 RID: 249220
		[Token(Token = "0x403CD84")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _frame;

		// Token: 0x0403CD85 RID: 249221
		[Token(Token = "0x403CD85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeinDur;

		// Token: 0x0403CD86 RID: 249222
		[Token(Token = "0x403CD86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act24sideBattleFinishMeldingDropInfoItemView _dropInfoView;

		// Token: 0x0403CD87 RID: 249223
		[Token(Token = "0x403CD87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rendering;

		// Token: 0x0403CD88 RID: 249224
		[Token(Token = "0x403CD88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CD89 RID: 249225
		[Token(Token = "0x403CD89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
