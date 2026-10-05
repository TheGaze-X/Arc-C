using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004972 RID: 18802
	[Token(Token = "0x2004972")]
	public class MedalLittleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C568 RID: 116072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C568")]
		[Address(RVA = "0x15D5130", Offset = "0x15D3D30", VA = "0x1815D5130")]
		public void Render(string medalId)
		{
		}

		// Token: 0x0601C569 RID: 116073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C569")]
		[Address(RVA = "0x15D50A0", Offset = "0x15D3CA0", VA = "0x1815D50A0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C56A RID: 116074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C56A")]
		[Address(RVA = "0x15D5390", Offset = "0x15D3F90", VA = "0x1815D5390")]
		public MedalLittleItemView()
		{
		}

		// Token: 0x04025146 RID: 151878
		[Token(Token = "0x4025146")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _hasFlag;

		// Token: 0x04025147 RID: 151879
		[Token(Token = "0x4025147")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaObj;

		// Token: 0x04025148 RID: 151880
		[Token(Token = "0x4025148")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04025149 RID: 151881
		[Token(Token = "0x4025149")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0402514A RID: 151882
		[Token(Token = "0x402514A")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent toTargetEvent;

		// Token: 0x0402514B RID: 151883
		[Token(Token = "0x402514B")]
		[FieldOffset(Offset = "0x40")]
		private string m_cacheMedalId;

		// Token: 0x0402514C RID: 151884
		[Token(Token = "0x402514C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402514D RID: 151885
		[Token(Token = "0x402514D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402514E RID: 151886
		[Token(Token = "0x402514E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
