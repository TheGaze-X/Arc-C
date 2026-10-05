using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006716 RID: 26390
	[Token(Token = "0x2006716")]
	public class HandBookV2OtherForceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DE0 RID: 155104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE0")]
		[Address(RVA = "0x20E6920", Offset = "0x20E5520", VA = "0x1820E6920")]
		public void OnClick()
		{
		}

		// Token: 0x06025DE1 RID: 155105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE1")]
		[Address(RVA = "0x20E69C0", Offset = "0x20E55C0", VA = "0x1820E69C0")]
		public void RenderView(HandBookV2GroupForceViewModel viewModel)
		{
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE2")]
		[Address(RVA = "0x20E6CB0", Offset = "0x20E58B0", VA = "0x1820E6CB0")]
		public HandBookV2OtherForceView()
		{
		}

		// Token: 0x04035422 RID: 218146
		[Token(Token = "0x4035422")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapAlphaDotView _dotView;

		// Token: 0x04035423 RID: 218147
		[Token(Token = "0x4035423")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x04035424 RID: 218148
		[Token(Token = "0x4035424")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _forceName;

		// Token: 0x04035425 RID: 218149
		[Token(Token = "0x4035425")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _forceName2;

		// Token: 0x04035426 RID: 218150
		[Token(Token = "0x4035426")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _leftPart;

		// Token: 0x04035427 RID: 218151
		[Token(Token = "0x4035427")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightPart;

		// Token: 0x04035428 RID: 218152
		[Token(Token = "0x4035428")]
		[FieldOffset(Offset = "0x48")]
		private HandBookV2GroupForceViewModel m_viewModel;

		// Token: 0x04035429 RID: 218153
		[Token(Token = "0x4035429")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIStringEvent onForceClick;

		// Token: 0x0403542A RID: 218154
		[Token(Token = "0x403542A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403542B RID: 218155
		[Token(Token = "0x403542B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403542C RID: 218156
		[Token(Token = "0x403542C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
