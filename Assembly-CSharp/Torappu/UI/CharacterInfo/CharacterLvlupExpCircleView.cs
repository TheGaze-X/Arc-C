using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F5D RID: 24413
	[Token(Token = "0x2005F5D")]
	public class CharacterLvlupExpCircleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023594 RID: 144788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023594")]
		[Address(RVA = "0x1DDCC60", Offset = "0x1DDB860", VA = "0x181DDCC60")]
		public void Render(CharacterLvlupViewModel viewModel)
		{
		}

		// Token: 0x06023595 RID: 144789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023595")]
		[Address(RVA = "0x1DDCED0", Offset = "0x1DDBAD0", VA = "0x181DDCED0")]
		public CharacterLvlupExpCircleView()
		{
		}

		// Token: 0x04030C92 RID: 199826
		[Token(Token = "0x4030C92")]
		private const float DURATION_SHOW = 0.1f;

		// Token: 0x04030C93 RID: 199827
		[Token(Token = "0x4030C93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04030C94 RID: 199828
		[Token(Token = "0x4030C94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCurrentProgress;

		// Token: 0x04030C95 RID: 199829
		[Token(Token = "0x4030C95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgAdditionProgress;

		// Token: 0x04030C96 RID: 199830
		[Token(Token = "0x4030C96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorNormalBkg;

		// Token: 0x04030C97 RID: 199831
		[Token(Token = "0x4030C97")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorScrollingBkg;

		// Token: 0x04030C98 RID: 199832
		[Token(Token = "0x4030C98")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_tween;

		// Token: 0x04030C99 RID: 199833
		[Token(Token = "0x4030C99")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedLevel;

		// Token: 0x04030C9A RID: 199834
		[Token(Token = "0x4030C9A")]
		[FieldOffset(Offset = "0x5C")]
		private float m_cachedAddProgress;

		// Token: 0x04030C9B RID: 199835
		[Token(Token = "0x4030C9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030C9C RID: 199836
		[Token(Token = "0x4030C9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
