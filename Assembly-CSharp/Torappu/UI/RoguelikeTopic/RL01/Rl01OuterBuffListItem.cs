using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004647 RID: 17991
	[Token(Token = "0x2004647")]
	public class Rl01OuterBuffListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x0601B51A RID: 111898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004114")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601B51A")]
			[Address(RVA = "0x14A4DA0", Offset = "0x14A39A0", VA = "0x1814A4DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B51B RID: 111899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B51B")]
		[Address(RVA = "0x14A4990", Offset = "0x14A3590", VA = "0x1814A4990")]
		public void Render(RoguelikeTopicOuterBuffListItemModel model, bool isInit)
		{
		}

		// Token: 0x0601B51C RID: 111900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B51C")]
		[Address(RVA = "0x14A4B30", Offset = "0x14A3730", VA = "0x1814A4B30")]
		private void _ShowBuffUpgradeEffect()
		{
		}

		// Token: 0x0601B51D RID: 111901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B51D")]
		[Address(RVA = "0x14A4D40", Offset = "0x14A3940", VA = "0x1814A4D40")]
		public Rl01OuterBuffListItem()
		{
		}

		// Token: 0x040234A5 RID: 144549
		[Token(Token = "0x40234A5")]
		public const float FADE_IN_DURATION = 0.08f;

		// Token: 0x040234A6 RID: 144550
		[Token(Token = "0x40234A6")]
		public const float WAIT_DURATION = 1.56f;

		// Token: 0x040234A7 RID: 144551
		[Token(Token = "0x40234A7")]
		public const float FADE_OUT_DURATION = 0.8f;

		// Token: 0x040234A8 RID: 144552
		[Token(Token = "0x40234A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040234A9 RID: 144553
		[Token(Token = "0x40234A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textBuffName;

		// Token: 0x040234AA RID: 144554
		[Token(Token = "0x40234AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBuffValue;

		// Token: 0x040234AB RID: 144555
		[Token(Token = "0x40234AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasBkgLight;

		// Token: 0x040234AC RID: 144556
		[Token(Token = "0x40234AC")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedDisplayValue;

		// Token: 0x040234AD RID: 144557
		[Token(Token = "0x40234AD")]
		[FieldOffset(Offset = "0x40")]
		private Sequence m_sequence;

		// Token: 0x040234AE RID: 144558
		[Token(Token = "0x40234AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x040234AF RID: 144559
		[Token(Token = "0x40234AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040234B0 RID: 144560
		[Token(Token = "0x40234B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowBuffUpgradeEffect;

		// Token: 0x040234B1 RID: 144561
		[Token(Token = "0x40234B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
