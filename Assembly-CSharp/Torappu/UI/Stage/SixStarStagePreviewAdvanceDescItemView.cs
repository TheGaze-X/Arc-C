using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200682D RID: 26669
	[Token(Token = "0x200682D")]
	public class SixStarStagePreviewAdvanceDescItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026327 RID: 156455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026327")]
		[Address(RVA = "0x213BAF0", Offset = "0x213A6F0", VA = "0x18213BAF0")]
		public void Render(SixStarStagePreviewAdvanceDescItemViewModel viewModel)
		{
		}

		// Token: 0x06026328 RID: 156456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026328")]
		[Address(RVA = "0x213BC10", Offset = "0x213A810", VA = "0x18213BC10")]
		public SixStarStagePreviewAdvanceDescItemView()
		{
		}

		// Token: 0x04035D31 RID: 220465
		[Token(Token = "0x4035D31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtLevelNum;

		// Token: 0x04035D32 RID: 220466
		[Token(Token = "0x4035D32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04035D33 RID: 220467
		[Token(Token = "0x4035D33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x04035D34 RID: 220468
		[Token(Token = "0x4035D34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035D35 RID: 220469
		[Token(Token = "0x4035D35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
