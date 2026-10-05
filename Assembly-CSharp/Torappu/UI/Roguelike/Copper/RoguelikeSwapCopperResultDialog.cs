using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x0200589F RID: 22687
	[Token(Token = "0x200589F")]
	public class RoguelikeSwapCopperResultDialog : UICompDialog<RoguelikeSwapCopperResultDialog.Option>
	{
		// Token: 0x06021209 RID: 135689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021209")]
		[Address(RVA = "0x1B816C0", Offset = "0x1B802C0", VA = "0x181B816C0", Slot = "18")]
		protected override void OnRender(RoguelikeSwapCopperResultDialog.Option input)
		{
		}

		// Token: 0x0602120A RID: 135690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602120A")]
		[Address(RVA = "0x1B81480", Offset = "0x1B80080", VA = "0x181B81480", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602120B RID: 135691 RVA: 0x000B8AA0 File Offset: 0x000B6CA0
		[Token(Token = "0x602120B")]
		[Address(RVA = "0x1B82170", Offset = "0x1B80D70", VA = "0x181B82170")]
		private Color _GetColorFromLucky(RoguelikeCopperLuckyLevel luckyLevel)
		{
			return default(Color);
		}

		// Token: 0x0602120C RID: 135692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602120C")]
		[Address(RVA = "0x1B82280", Offset = "0x1B80E80", VA = "0x181B82280")]
		private void _RenderCopperItem(bool isNew)
		{
		}

		// Token: 0x0602120D RID: 135693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602120D")]
		[Address(RVA = "0x1B814E0", Offset = "0x1B800E0", VA = "0x181B814E0")]
		public void OnClickBackButton()
		{
		}

		// Token: 0x0602120E RID: 135694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602120E")]
		[Address(RVA = "0x1B815B0", Offset = "0x1B801B0", VA = "0x181B815B0")]
		public void OnClickSkipButton()
		{
		}

		// Token: 0x0602120F RID: 135695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602120F")]
		[Address(RVA = "0x1B825A0", Offset = "0x1B811A0", VA = "0x181B825A0")]
		public RoguelikeSwapCopperResultDialog()
		{
		}

		// Token: 0x06021212 RID: 135698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021212")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402D1AF RID: 184751
		[Token(Token = "0x402D1AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402D1B0 RID: 184752
		[Token(Token = "0x402D1B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _hideOldAnimLocation;

		// Token: 0x0402D1B1 RID: 184753
		[Token(Token = "0x402D1B1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _copperItemHolder;

		// Token: 0x0402D1B2 RID: 184754
		[Token(Token = "0x402D1B2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _showNewAnimLocation;

		// Token: 0x0402D1B3 RID: 184755
		[Token(Token = "0x402D1B3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _backFrameHolder;

		// Token: 0x0402D1B4 RID: 184756
		[Token(Token = "0x402D1B4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _copperCardScale;

		// Token: 0x0402D1B5 RID: 184757
		[Token(Token = "0x402D1B5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _newCopperName;

		// Token: 0x0402D1B6 RID: 184758
		[Token(Token = "0x402D1B6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _luckyIcon;

		// Token: 0x0402D1B7 RID: 184759
		[Token(Token = "0x402D1B7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _swapDescOldCopperName;

		// Token: 0x0402D1B8 RID: 184760
		[Token(Token = "0x402D1B8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _swapDescNewCopperName;

		// Token: 0x0402D1B9 RID: 184761
		[Token(Token = "0x402D1B9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<RoguelikeSwapCopperResultDialog.NameColorGroup> _nameColorGroups;

		// Token: 0x0402D1BA RID: 184762
		[Token(Token = "0x402D1BA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _skipPanelGo;

		// Token: 0x0402D1BB RID: 184763
		[Token(Token = "0x402D1BB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _skipHideDelay;

		// Token: 0x0402D1BC RID: 184764
		[Token(Token = "0x402D1BC")]
		[FieldOffset(Offset = "0xE8")]
		private Sequence m_displaySequence;

		// Token: 0x0402D1BD RID: 184765
		[Token(Token = "0x402D1BD")]
		[FieldOffset(Offset = "0xF0")]
		private RoguelikeSwapCopperResultDialog.Option m_cachedInput;

		// Token: 0x0402D1BE RID: 184766
		[Token(Token = "0x402D1BE")]
		[FieldOffset(Offset = "0xF8")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402D1BF RID: 184767
		[Token(Token = "0x402D1BF")]
		[FieldOffset(Offset = "0x100")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402D1C0 RID: 184768
		[Token(Token = "0x402D1C0")]
		[FieldOffset(Offset = "0x108")]
		private RoguelikeGameCopperItemViewModel m_oldCopperItemViewModel;

		// Token: 0x0402D1C1 RID: 184769
		[Token(Token = "0x402D1C1")]
		[FieldOffset(Offset = "0x110")]
		private RoguelikeGameCopperItemViewModel m_newCopperItemViewModel;

		// Token: 0x0402D1C2 RID: 184770
		[Token(Token = "0x402D1C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402D1C3 RID: 184771
		[Token(Token = "0x402D1C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402D1C4 RID: 184772
		[Token(Token = "0x402D1C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetColorFromLucky;

		// Token: 0x0402D1C5 RID: 184773
		[Token(Token = "0x402D1C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCopperItem;

		// Token: 0x0402D1C6 RID: 184774
		[Token(Token = "0x402D1C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickBackButton;

		// Token: 0x0402D1C7 RID: 184775
		[Token(Token = "0x402D1C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickSkipButton;

		// Token: 0x0402D1C8 RID: 184776
		[Token(Token = "0x402D1C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058A0 RID: 22688
		[Token(Token = "0x20058A0")]
		[Serializable]
		public class NameColorGroup
		{
			// Token: 0x06021213 RID: 135699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021213")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NameColorGroup()
			{
			}

			// Token: 0x0402D1C9 RID: 184777
			[Token(Token = "0x402D1C9")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeCopperLuckyLevel luckyLevel;

			// Token: 0x0402D1CA RID: 184778
			[Token(Token = "0x402D1CA")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}

		// Token: 0x020058A1 RID: 22689
		[Token(Token = "0x20058A1")]
		public class Option
		{
			// Token: 0x06021214 RID: 135700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021214")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0402D1CB RID: 184779
			[Token(Token = "0x402D1CB")]
			[FieldOffset(Offset = "0x10")]
			public string oldCopperId;

			// Token: 0x0402D1CC RID: 184780
			[Token(Token = "0x402D1CC")]
			[FieldOffset(Offset = "0x18")]
			public string newCopperId;

			// Token: 0x0402D1CD RID: 184781
			[Token(Token = "0x402D1CD")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;
		}
	}
}
