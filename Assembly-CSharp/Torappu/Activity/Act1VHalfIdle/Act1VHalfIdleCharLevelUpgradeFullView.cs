using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200770B RID: 30475
	[Token(Token = "0x200770B")]
	public class Act1VHalfIdleCharLevelUpgradeFullView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602ACFE RID: 175358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACFE")]
		[Address(RVA = "0x2696180", Offset = "0x2694D80", VA = "0x182696180")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602ACFF RID: 175359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACFF")]
		[Address(RVA = "0x2696280", Offset = "0x2694E80", VA = "0x182696280")]
		public Act1VHalfIdleCharLevelUpgradeFullView()
		{
		}

		// Token: 0x0403DB20 RID: 252704
		[Token(Token = "0x403DB20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textMaxLevel;

		// Token: 0x0403DB21 RID: 252705
		[Token(Token = "0x403DB21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgElite;

		// Token: 0x0403DB22 RID: 252706
		[Token(Token = "0x403DB22")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedEliteId;

		// Token: 0x0403DB23 RID: 252707
		[Token(Token = "0x403DB23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB24 RID: 252708
		[Token(Token = "0x403DB24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
