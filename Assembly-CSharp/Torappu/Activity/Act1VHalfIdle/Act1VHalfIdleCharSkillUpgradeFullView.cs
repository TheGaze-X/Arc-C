using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007713 RID: 30483
	[Token(Token = "0x2007713")]
	public class Act1VHalfIdleCharSkillUpgradeFullView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AD32 RID: 175410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD32")]
		[Address(RVA = "0x269B080", Offset = "0x2699C80", VA = "0x18269B080")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602AD33 RID: 175411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD33")]
		[Address(RVA = "0x269B180", Offset = "0x2699D80", VA = "0x18269B180")]
		public Act1VHalfIdleCharSkillUpgradeFullView()
		{
		}

		// Token: 0x0403DB81 RID: 252801
		[Token(Token = "0x403DB81")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textSkillRank;

		// Token: 0x0403DB82 RID: 252802
		[Token(Token = "0x403DB82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlRank;

		// Token: 0x0403DB83 RID: 252803
		[Token(Token = "0x403DB83")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlSpecialized;

		// Token: 0x0403DB84 RID: 252804
		[Token(Token = "0x403DB84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB85 RID: 252805
		[Token(Token = "0x403DB85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
