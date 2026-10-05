using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005990 RID: 22928
	[Token(Token = "0x2005990")]
	public class CrisisV2AchievementRuneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060216C6 RID: 136902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C6")]
		[Address(RVA = "0x1BBC6B0", Offset = "0x1BBB2B0", VA = "0x181BBC6B0")]
		public void Render(CrisisV2AchievementRuneViewModel viewModel)
		{
		}

		// Token: 0x060216C7 RID: 136903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C7")]
		[Address(RVA = "0x1BBC7D0", Offset = "0x1BBB3D0", VA = "0x181BBC7D0")]
		public CrisisV2AchievementRuneItemView()
		{
		}

		// Token: 0x0402D975 RID: 186741
		[Token(Token = "0x402D975")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402D976 RID: 186742
		[Token(Token = "0x402D976")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0402D977 RID: 186743
		[Token(Token = "0x402D977")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402D978 RID: 186744
		[Token(Token = "0x402D978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D979 RID: 186745
		[Token(Token = "0x402D979")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
