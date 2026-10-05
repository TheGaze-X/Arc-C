using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005721 RID: 22305
	[Token(Token = "0x2005721")]
	public class RL04TravelLeaveToastView : RoguelikeTravelLeaveToastView
	{
		// Token: 0x06020B11 RID: 133905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B11")]
		[Address(RVA = "0x1B16430", Offset = "0x1B15030", VA = "0x181B16430", Slot = "9")]
		protected override void Render(RoguelikeTravelLeaveToastView.Param param)
		{
		}

		// Token: 0x06020B12 RID: 133906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B12")]
		[Address(RVA = "0x1B16520", Offset = "0x1B15120", VA = "0x181B16520")]
		private string _GenDesc(RoguelikeTravelLeaveToastView.Param param)
		{
			return null;
		}

		// Token: 0x06020B13 RID: 133907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B13")]
		[Address(RVA = "0x1B16890", Offset = "0x1B15490", VA = "0x181B16890")]
		public RL04TravelLeaveToastView()
		{
		}

		// Token: 0x0402C5E0 RID: 181728
		[Token(Token = "0x402C5E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C5E1 RID: 181729
		[Token(Token = "0x402C5E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _travelIcon;

		// Token: 0x0402C5E2 RID: 181730
		[Token(Token = "0x402C5E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _expedIcon;

		// Token: 0x0402C5E3 RID: 181731
		[Token(Token = "0x402C5E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5E4 RID: 181732
		[Token(Token = "0x402C5E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenDesc;

		// Token: 0x0402C5E5 RID: 181733
		[Token(Token = "0x402C5E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
