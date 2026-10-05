using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EFF RID: 20223
	[Token(Token = "0x2004EFF")]
	public class FifthAnnivExploreMissionObjHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E26C RID: 123500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26C")]
		[Address(RVA = "0x17D5230", Offset = "0x17D3E30", VA = "0x1817D5230")]
		public void Render(FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel viewModel)
		{
		}

		// Token: 0x0601E26D RID: 123501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26D")]
		[Address(RVA = "0x17D5090", Offset = "0x17D3C90", VA = "0x1817D5090")]
		public void RegisCollectAll(UIStringEvent e)
		{
		}

		// Token: 0x0601E26E RID: 123502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26E")]
		[Address(RVA = "0x17D51B0", Offset = "0x17D3DB0", VA = "0x1817D51B0")]
		public void RegisMissionObjClicked(UIStringEvent e)
		{
		}

		// Token: 0x0601E26F RID: 123503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26F")]
		[Address(RVA = "0x17D5310", Offset = "0x17D3F10", VA = "0x1817D5310")]
		public FifthAnnivExploreMissionObjHolder()
		{
		}

		// Token: 0x04028232 RID: 164402
		[Token(Token = "0x4028232")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FifthAnnivExploreMissionObjView _view;

		// Token: 0x04028233 RID: 164403
		[Token(Token = "0x4028233")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _collectAllBtn;

		// Token: 0x04028234 RID: 164404
		[Token(Token = "0x4028234")]
		[FieldOffset(Offset = "0x28")]
		private UIStringEvent _onMissionObjClicked;

		// Token: 0x04028235 RID: 164405
		[Token(Token = "0x4028235")]
		[FieldOffset(Offset = "0x30")]
		private UIStringEvent _onCollectAllBtnClicked;

		// Token: 0x04028236 RID: 164406
		[Token(Token = "0x4028236")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028237 RID: 164407
		[Token(Token = "0x4028237")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisCollectAll;

		// Token: 0x04028238 RID: 164408
		[Token(Token = "0x4028238")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisMissionObjClicked;

		// Token: 0x04028239 RID: 164409
		[Token(Token = "0x4028239")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
