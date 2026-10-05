using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200604E RID: 24654
	[Token(Token = "0x200604E")]
	public class CarvingTopInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023A60 RID: 146016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A60")]
		[Address(RVA = "0x1E514F0", Offset = "0x1E500F0", VA = "0x181E514F0")]
		public void Render(CarvingTopInfoViewModel model)
		{
		}

		// Token: 0x06023A61 RID: 146017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A61")]
		[Address(RVA = "0x1E51750", Offset = "0x1E50350", VA = "0x181E51750")]
		public CarvingTopInfoView()
		{
		}

		// Token: 0x0403160A RID: 202250
		[Token(Token = "0x403160A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _viewMissionBtn;

		// Token: 0x0403160B RID: 202251
		[Token(Token = "0x403160B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _curRoundText;

		// Token: 0x0403160C RID: 202252
		[Token(Token = "0x403160C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _roundModeToggle;

		// Token: 0x0403160D RID: 202253
		[Token(Token = "0x403160D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _targetScore;

		// Token: 0x0403160E RID: 202254
		[Token(Token = "0x403160E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403160F RID: 202255
		[Token(Token = "0x403160F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
