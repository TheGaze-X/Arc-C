using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005639 RID: 22073
	[Token(Token = "0x2005639")]
	public class RL05CandleToastView : UINotifyView<RL05CandleToastView.Param>
	{
		// Token: 0x0602063E RID: 132670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602063E")]
		[Address(RVA = "0x1A74800", Offset = "0x1A73400", VA = "0x181A74800", Slot = "9")]
		protected override void Render(RL05CandleToastView.Param param)
		{
		}

		// Token: 0x0602063F RID: 132671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602063F")]
		[Address(RVA = "0x1A748D0", Offset = "0x1A734D0", VA = "0x181A748D0")]
		public RL05CandleToastView()
		{
		}

		// Token: 0x0402BD89 RID: 179593
		[Token(Token = "0x402BD89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _candleText;

		// Token: 0x0402BD8A RID: 179594
		[Token(Token = "0x402BD8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD8B RID: 179595
		[Token(Token = "0x402BD8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200563A RID: 22074
		[Token(Token = "0x200563A")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020640 RID: 132672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020640")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402BD8C RID: 179596
			[Token(Token = "0x402BD8C")]
			[FieldOffset(Offset = "0x10")]
			public string text;
		}
	}
}
