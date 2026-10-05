using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FC8 RID: 20424
	[Token(Token = "0x2004FC8")]
	public class EnemyDuelBetSkipButton : AbstractEnemyDuelBetButton
	{
		// Token: 0x0601E546 RID: 124230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E546")]
		[Address(RVA = "0x17FA310", Offset = "0x17F8F10", VA = "0x1817FA310")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E547 RID: 124231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E547")]
		[Address(RVA = "0x17FA070", Offset = "0x17F8C70", VA = "0x1817FA070", Slot = "4")]
		protected override void SetSelected(AbstractEnemyDuelBetButton.ShowType showType, bool isInit)
		{
		}

		// Token: 0x0601E548 RID: 124232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E548")]
		[Address(RVA = "0x17F9F30", Offset = "0x17F8B30", VA = "0x1817F9F30")]
		public void OnClicked()
		{
		}

		// Token: 0x0601E549 RID: 124233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E549")]
		[Address(RVA = "0x17FA420", Offset = "0x17F9020", VA = "0x1817FA420")]
		public EnemyDuelBetSkipButton()
		{
		}

		// Token: 0x0402884F RID: 165967
		[Token(Token = "0x402884F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x04028850 RID: 165968
		[Token(Token = "0x4028850")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSkip;

		// Token: 0x04028851 RID: 165969
		[Token(Token = "0x4028851")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _textSkipColorNormal;

		// Token: 0x04028852 RID: 165970
		[Token(Token = "0x4028852")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _textSkipColorMasked;

		// Token: 0x04028853 RID: 165971
		[Token(Token = "0x4028853")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x04028854 RID: 165972
		[Token(Token = "0x4028854")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _btnSkipSpriteNormal;

		// Token: 0x04028855 RID: 165973
		[Token(Token = "0x4028855")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _btnSkipSpriteMasked;

		// Token: 0x04028856 RID: 165974
		[Token(Token = "0x4028856")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgBtn;

		// Token: 0x04028857 RID: 165975
		[Token(Token = "0x4028857")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_selectedTween;

		// Token: 0x04028858 RID: 165976
		[Token(Token = "0x4028858")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04028859 RID: 165977
		[Token(Token = "0x4028859")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402885A RID: 165978
		[Token(Token = "0x402885A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402885B RID: 165979
		[Token(Token = "0x402885B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x0402885C RID: 165980
		[Token(Token = "0x402885C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0402885D RID: 165981
		[Token(Token = "0x402885D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
