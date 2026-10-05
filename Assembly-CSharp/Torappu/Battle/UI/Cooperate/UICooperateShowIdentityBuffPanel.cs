using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033EE RID: 13294
	[Token(Token = "0x20033EE")]
	public class UICooperateShowIdentityBuffPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601536C RID: 86892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601536C")]
		[Address(RVA = "0xDA9350", Offset = "0xDA7F50", VA = "0x180DA9350")]
		public void RenderPanel(UICooperateShowIdentityBuffPanel.IdentityRenderData selfRD, UICooperateShowIdentityBuffPanel.IdentityRenderData oppositeRD, bool isInversed, string gmColor)
		{
		}

		// Token: 0x0601536D RID: 86893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601536D")]
		[Address(RVA = "0xDA92B0", Offset = "0xDA7EB0", VA = "0x180DA92B0")]
		public void PlayAnim(Action callback)
		{
		}

		// Token: 0x0601536E RID: 86894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601536E")]
		[Address(RVA = "0xDA9740", Offset = "0xDA8340", VA = "0x180DA9740")]
		public void RunAnim(FP deltaTime)
		{
		}

		// Token: 0x0601536F RID: 86895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601536F")]
		[Address(RVA = "0xDA9AA0", Offset = "0xDA86A0", VA = "0x180DA9AA0")]
		private void _PlayAnimation(UIAnimationLocation animLocation)
		{
		}

		// Token: 0x06015370 RID: 86896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015370")]
		[Address(RVA = "0xDAA1A0", Offset = "0xDA8DA0", VA = "0x180DAA1A0")]
		private void _SetGameModeRenderData(string gameModeColor)
		{
		}

		// Token: 0x06015371 RID: 86897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015371")]
		[Address(RVA = "0xDAA100", Offset = "0xDA8D00", VA = "0x180DAA100")]
		private void _RenderSelfIdentity(string name)
		{
		}

		// Token: 0x06015372 RID: 86898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015372")]
		[Address(RVA = "0xDAA060", Offset = "0xDA8C60", VA = "0x180DAA060")]
		private void _RenderOppositeIdentity(string name)
		{
		}

		// Token: 0x06015373 RID: 86899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015373")]
		[Address(RVA = "0xDA9EB0", Offset = "0xDA8AB0", VA = "0x180DA9EB0")]
		private void _RenderConstIdentity(string selfColor, Sprite selfIdentityIcon, string oppositeColor, Sprite oppositeIdentityIcon)
		{
		}

		// Token: 0x06015374 RID: 86900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015374")]
		[Address(RVA = "0xDA9950", Offset = "0xDA8550", VA = "0x180DA9950")]
		private void _OnSetInverseText()
		{
		}

		// Token: 0x06015375 RID: 86901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015375")]
		[Address(RVA = "0xDA9A30", Offset = "0xDA8630", VA = "0x180DA9A30")]
		private void _OnTimerStopped()
		{
		}

		// Token: 0x06015376 RID: 86902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015376")]
		[Address(RVA = "0xDAA290", Offset = "0xDA8E90", VA = "0x180DAA290")]
		public UICooperateShowIdentityBuffPanel()
		{
		}

		// Token: 0x04019564 RID: 103780
		[Token(Token = "0x4019564")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _selfIdentityTitle;

		// Token: 0x04019565 RID: 103781
		[Token(Token = "0x4019565")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _oppositeIdentityTitle;

		// Token: 0x04019566 RID: 103782
		[Token(Token = "0x4019566")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _selfIdentityIcon;

		// Token: 0x04019567 RID: 103783
		[Token(Token = "0x4019567")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _oppositeIdentityIcon;

		// Token: 0x04019568 RID: 103784
		[Token(Token = "0x4019568")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _selfIdentityChangeColor;

		// Token: 0x04019569 RID: 103785
		[Token(Token = "0x4019569")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _oppositeIdentityChangeColor;

		// Token: 0x0401956A RID: 103786
		[Token(Token = "0x401956A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _gameModeColor;

		// Token: 0x0401956B RID: 103787
		[Token(Token = "0x401956B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _normalAnim;

		// Token: 0x0401956C RID: 103788
		[Token(Token = "0x401956C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _inverseAnim;

		// Token: 0x0401956D RID: 103789
		[Token(Token = "0x401956D")]
		private const float INVERSE_TIMER_PERIOD = 1f;

		// Token: 0x0401956E RID: 103790
		[Token(Token = "0x401956E")]
		private const float STOP_TIMER_PERIOD = 3f;

		// Token: 0x0401956F RID: 103791
		[Token(Token = "0x401956F")]
		[FieldOffset(Offset = "0x70")]
		private Action m_callback;

		// Token: 0x04019570 RID: 103792
		[Token(Token = "0x4019570")]
		[FieldOffset(Offset = "0x78")]
		private Sequence m_sequence;

		// Token: 0x04019571 RID: 103793
		[Token(Token = "0x4019571")]
		[FieldOffset(Offset = "0x80")]
		private FP m_curTime;

		// Token: 0x04019572 RID: 103794
		[Token(Token = "0x4019572")]
		[FieldOffset(Offset = "0x88")]
		private UICooperateShowIdentityBuffPanel.IdentityRenderData m_selfRD;

		// Token: 0x04019573 RID: 103795
		[Token(Token = "0x4019573")]
		[FieldOffset(Offset = "0x90")]
		private UICooperateShowIdentityBuffPanel.IdentityRenderData m_oppositeRD;

		// Token: 0x04019574 RID: 103796
		[Token(Token = "0x4019574")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInversed;

		// Token: 0x04019575 RID: 103797
		[Token(Token = "0x4019575")]
		[FieldOffset(Offset = "0xA0")]
		private List<UICooperateShowIdentityBuffPanel.InverseCallbackData> m_inverseCallbackData;

		// Token: 0x04019576 RID: 103798
		[Token(Token = "0x4019576")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderPanel;

		// Token: 0x04019577 RID: 103799
		[Token(Token = "0x4019577")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04019578 RID: 103800
		[Token(Token = "0x4019578")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RunAnim;

		// Token: 0x04019579 RID: 103801
		[Token(Token = "0x4019579")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnimation;

		// Token: 0x0401957A RID: 103802
		[Token(Token = "0x401957A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetGameModeRenderData;

		// Token: 0x0401957B RID: 103803
		[Token(Token = "0x401957B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSelfIdentity;

		// Token: 0x0401957C RID: 103804
		[Token(Token = "0x401957C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderOppositeIdentity;

		// Token: 0x0401957D RID: 103805
		[Token(Token = "0x401957D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderConstIdentity;

		// Token: 0x0401957E RID: 103806
		[Token(Token = "0x401957E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnSetInverseText;

		// Token: 0x0401957F RID: 103807
		[Token(Token = "0x401957F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTimerStopped;

		// Token: 0x04019580 RID: 103808
		[Token(Token = "0x4019580")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033EF RID: 13295
		[Token(Token = "0x20033EF")]
		public class IdentityRenderData
		{
			// Token: 0x06015378 RID: 86904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015378")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IdentityRenderData()
			{
			}

			// Token: 0x04019581 RID: 103809
			[Token(Token = "0x4019581")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04019582 RID: 103810
			[Token(Token = "0x4019582")]
			[FieldOffset(Offset = "0x18")]
			public string color;

			// Token: 0x04019583 RID: 103811
			[Token(Token = "0x4019583")]
			[FieldOffset(Offset = "0x20")]
			public Sprite iconSprite;
		}

		// Token: 0x020033F0 RID: 13296
		[Token(Token = "0x20033F0")]
		public class InverseCallbackData
		{
			// Token: 0x06015379 RID: 86905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015379")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InverseCallbackData()
			{
			}

			// Token: 0x04019584 RID: 103812
			[Token(Token = "0x4019584")]
			[FieldOffset(Offset = "0x10")]
			public FP progress;

			// Token: 0x04019585 RID: 103813
			[Token(Token = "0x4019585")]
			[FieldOffset(Offset = "0x18")]
			public Action callBack;
		}
	}
}
