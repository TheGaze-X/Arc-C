using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057DB RID: 22491
	[Token(Token = "0x20057DB")]
	public class RoguelikeInitChar : RoguelikeInitCardBase
	{
		// Token: 0x06020E59 RID: 134745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E59")]
		[Address(RVA = "0x1B38680", Offset = "0x1B37280", VA = "0x181B38680")]
		public void Setup(RoguelikeInitChar.Model model)
		{
		}

		// Token: 0x06020E5A RID: 134746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E5A")]
		[Address(RVA = "0x1B38D40", Offset = "0x1B37940", VA = "0x181B38D40")]
		public RoguelikeInitChar()
		{
		}

		// Token: 0x0402CB2B RID: 183083
		[Token(Token = "0x402CB2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0402CB2C RID: 183084
		[Token(Token = "0x402CB2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0402CB2D RID: 183085
		[Token(Token = "0x402CB2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402CB2E RID: 183086
		[Token(Token = "0x402CB2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _detailNode;

		// Token: 0x0402CB2F RID: 183087
		[Token(Token = "0x402CB2F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _emptyNode;

		// Token: 0x0402CB30 RID: 183088
		[Token(Token = "0x402CB30")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0402CB31 RID: 183089
		[Token(Token = "0x402CB31")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tags")]
		private GameObject _monthFlag;

		// Token: 0x0402CB32 RID: 183090
		[Token(Token = "0x402CB32")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tags")]
		private GameObject _asistantFlag;

		// Token: 0x0402CB33 RID: 183091
		[Token(Token = "0x402CB33")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tags")]
		private GameObject _randomFlag;

		// Token: 0x0402CB34 RID: 183092
		[Token(Token = "0x402CB34")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Tags")]
		private GameObject _tempFlag;

		// Token: 0x0402CB35 RID: 183093
		[Token(Token = "0x402CB35")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tags")]
		private GameObject _tempNpcFlag;

		// Token: 0x0402CB36 RID: 183094
		[Token(Token = "0x402CB36")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tags")]
		private RoguelikeInitMonthTag _month;

		// Token: 0x0402CB37 RID: 183095
		[Token(Token = "0x402CB37")]
		[FieldOffset(Offset = "0x88")]
		public RoguelikeInitChar.Model m_model;

		// Token: 0x0402CB38 RID: 183096
		[Token(Token = "0x402CB38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0402CB39 RID: 183097
		[Token(Token = "0x402CB39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057DC RID: 22492
		[Token(Token = "0x20057DC")]
		public struct Model
		{
			// Token: 0x0402CB3A RID: 183098
			[Token(Token = "0x402CB3A")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x0402CB3B RID: 183099
			[Token(Token = "0x402CB3B")]
			[FieldOffset(Offset = "0x8")]
			public string tmplId;

			// Token: 0x0402CB3C RID: 183100
			[Token(Token = "0x402CB3C")]
			[FieldOffset(Offset = "0x10")]
			public string skinId;

			// Token: 0x0402CB3D RID: 183101
			[Token(Token = "0x402CB3D")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeCharState type;

			// Token: 0x0402CB3E RID: 183102
			[Token(Token = "0x402CB3E")]
			[FieldOffset(Offset = "0x1C")]
			public bool isPlayerChar;

			// Token: 0x0402CB3F RID: 183103
			[Token(Token = "0x402CB3F")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeTopicMonthSquad monthSquad;
		}
	}
}
