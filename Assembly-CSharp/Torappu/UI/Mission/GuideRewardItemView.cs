using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200486B RID: 18539
	[Token(Token = "0x200486B")]
	public abstract class GuideRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BFFD RID: 114685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFFD")]
		[Address(RVA = "0x154D540", Offset = "0x154C140", VA = "0x18154D540")]
		public void RenderView(GuideMissionGroupModel groupModel, bool isToDo)
		{
		}

		// Token: 0x0601BFFE RID: 114686
		[Token(Token = "0x601BFFE")]
		protected abstract void OnRender();

		// Token: 0x0601BFFF RID: 114687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFFF")]
		[Address(RVA = "0x154D660", Offset = "0x154C260", VA = "0x18154D660")]
		protected GuideRewardItemView()
		{
		}

		// Token: 0x0402485C RID: 149596
		[Token(Token = "0x402485C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _maskPartGo;

		// Token: 0x0402485D RID: 149597
		[Token(Token = "0x402485D")]
		[FieldOffset(Offset = "0x20")]
		protected GuideMissionGroupModel m_groupModel;

		// Token: 0x0402485E RID: 149598
		[Token(Token = "0x402485E")]
		[FieldOffset(Offset = "0x28")]
		protected bool m_isToDo;

		// Token: 0x0402485F RID: 149599
		[Token(Token = "0x402485F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04024860 RID: 149600
		[Token(Token = "0x4024860")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
