using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005539 RID: 21817
	[Token(Token = "0x2005539")]
	public class RoguelikeStashedTicketUseInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020158 RID: 131416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020158")]
		[Address(RVA = "0x1A3E700", Offset = "0x1A3D300", VA = "0x181A3E700")]
		public void Render(RoguelikeStashedTicketUseViewModel model)
		{
		}

		// Token: 0x06020159 RID: 131417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020159")]
		[Address(RVA = "0x1A3E9A0", Offset = "0x1A3D5A0", VA = "0x181A3E9A0")]
		public RoguelikeStashedTicketUseInfoView()
		{
		}

		// Token: 0x0402B557 RID: 177495
		[Token(Token = "0x402B557")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtCost;

		// Token: 0x0402B558 RID: 177496
		[Token(Token = "0x402B558")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtFuncDesc;

		// Token: 0x0402B559 RID: 177497
		[Token(Token = "0x402B559")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDetailDesc;

		// Token: 0x0402B55A RID: 177498
		[Token(Token = "0x402B55A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isViewInited;

		// Token: 0x0402B55B RID: 177499
		[Token(Token = "0x402B55B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B55C RID: 177500
		[Token(Token = "0x402B55C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
