using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057EA RID: 22506
	[Token(Token = "0x20057EA")]
	public class RoguelikeInitRecruit : RoguelikeInitCardBase
	{
		// Token: 0x06020E8F RID: 134799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E8F")]
		[Address(RVA = "0x1B40B30", Offset = "0x1B3F730", VA = "0x181B40B30")]
		public void Setup(int idx, RoguelikeInitRecruit.Model model)
		{
		}

		// Token: 0x06020E90 RID: 134800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E90")]
		[Address(RVA = "0x1B40AB0", Offset = "0x1B3F6B0", VA = "0x181B40AB0")]
		public void EventOnSelectPressed()
		{
		}

		// Token: 0x06020E91 RID: 134801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E91")]
		[Address(RVA = "0x1B41040", Offset = "0x1B3FC40", VA = "0x181B41040")]
		public RoguelikeInitRecruit()
		{
		}

		// Token: 0x0402CB9F RID: 183199
		[Token(Token = "0x402CB9F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _contentRoot;

		// Token: 0x0402CBA0 RID: 183200
		[Token(Token = "0x402CBA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _recruitNode;

		// Token: 0x0402CBA1 RID: 183201
		[Token(Token = "0x402CBA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402CBA2 RID: 183202
		[Token(Token = "0x402CBA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0402CBA3 RID: 183203
		[Token(Token = "0x402CBA3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0402CBA4 RID: 183204
		[Token(Token = "0x402CBA4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _underTexImage;

		// Token: 0x0402CBA5 RID: 183205
		[Token(Token = "0x402CBA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x0402CBA6 RID: 183206
		[Token(Token = "0x402CBA6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _bottomTips;

		// Token: 0x0402CBA7 RID: 183207
		[Token(Token = "0x402CBA7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _enableHintObject;

		// Token: 0x0402CBA8 RID: 183208
		[Token(Token = "0x402CBA8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _continueHintObject;

		// Token: 0x0402CBA9 RID: 183209
		[Token(Token = "0x402CBA9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeInitChar _charPrefab;

		// Token: 0x0402CBAA RID: 183210
		[Token(Token = "0x402CBAA")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeInitChar m_charCard;

		// Token: 0x0402CBAB RID: 183211
		[Token(Token = "0x402CBAB")]
		[FieldOffset(Offset = "0x88")]
		private int m_index;

		// Token: 0x0402CBAC RID: 183212
		[Token(Token = "0x402CBAC")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Action<int> selectCallback;

		// Token: 0x0402CBAD RID: 183213
		[Token(Token = "0x402CBAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0402CBAE RID: 183214
		[Token(Token = "0x402CBAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSelectPressed;

		// Token: 0x0402CBAF RID: 183215
		[Token(Token = "0x402CBAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057EB RID: 22507
		[Token(Token = "0x20057EB")]
		public struct Model
		{
			// Token: 0x0402CBB0 RID: 183216
			[Token(Token = "0x402CBB0")]
			[FieldOffset(Offset = "0x0")]
			public string title;

			// Token: 0x0402CBB1 RID: 183217
			[Token(Token = "0x402CBB1")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x0402CBB2 RID: 183218
			[Token(Token = "0x402CBB2")]
			[FieldOffset(Offset = "0x10")]
			public Sprite iconSprite;

			// Token: 0x0402CBB3 RID: 183219
			[Token(Token = "0x402CBB3")]
			[FieldOffset(Offset = "0x18")]
			public Sprite underTexSprite;

			// Token: 0x0402CBB4 RID: 183220
			[Token(Token = "0x402CBB4")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikeV2.CurrentData.Recruit.State state;

			// Token: 0x0402CBB5 RID: 183221
			[Token(Token = "0x402CBB5")]
			[FieldOffset(Offset = "0x24")]
			public bool hasActived;

			// Token: 0x0402CBB6 RID: 183222
			[Token(Token = "0x402CBB6")]
			[FieldOffset(Offset = "0x28")]
			public RoguelikeInitChar.Model charModel;
		}
	}
}
