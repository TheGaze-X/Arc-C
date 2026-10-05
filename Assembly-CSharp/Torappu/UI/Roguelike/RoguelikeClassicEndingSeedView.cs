using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B1 RID: 21169
	[Token(Token = "0x20052B1")]
	public class RoguelikeClassicEndingSeedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F39E RID: 127902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F39E")]
		[Address(RVA = "0x18E3AC0", Offset = "0x18E26C0", VA = "0x1818E3AC0")]
		public void DoRender(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x0601F39F RID: 127903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F39F")]
		[Address(RVA = "0x18E3CD0", Offset = "0x18E28D0", VA = "0x1818E3CD0")]
		private IEnumerator _ApplyInAnim()
		{
			return null;
		}

		// Token: 0x0601F3A0 RID: 127904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3A0")]
		[Address(RVA = "0x18E3C60", Offset = "0x18E2860", VA = "0x1818E3C60")]
		public void OnCopySeed()
		{
		}

		// Token: 0x0601F3A1 RID: 127905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3A1")]
		[Address(RVA = "0x18E3D80", Offset = "0x18E2980", VA = "0x1818E3D80")]
		public RoguelikeClassicEndingSeedView()
		{
		}

		// Token: 0x04029EDD RID: 171741
		[Token(Token = "0x4029EDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _seedEntryAnim;

		// Token: 0x04029EDE RID: 171742
		[Token(Token = "0x4029EDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _seedText;

		// Token: 0x04029EDF RID: 171743
		[Token(Token = "0x4029EDF")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_entryTween;

		// Token: 0x04029EE0 RID: 171744
		[Token(Token = "0x4029EE0")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasPlayedEntryAnim;

		// Token: 0x04029EE1 RID: 171745
		[Token(Token = "0x4029EE1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action onCopySeed;

		// Token: 0x04029EE2 RID: 171746
		[Token(Token = "0x4029EE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04029EE3 RID: 171747
		[Token(Token = "0x4029EE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04029EE4 RID: 171748
		[Token(Token = "0x4029EE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCopySeed;

		// Token: 0x04029EE5 RID: 171749
		[Token(Token = "0x4029EE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
