using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005322 RID: 21282
	[Token(Token = "0x2005322")]
	public class RoguelikeMenuInitSquadWindow : RoguelikeMenuWindow<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x0601F65A RID: 128602 RVA: 0x000B1C48 File Offset: 0x000AFE48
		[Token(Token = "0x17004999")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F65A")]
			[Address(RVA = "0x1911DC0", Offset = "0x19109C0", VA = "0x181911DC0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F65B RID: 128603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F65B")]
		[Address(RVA = "0x1911980", Offset = "0x1910580", VA = "0x181911980", Slot = "10")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F65C RID: 128604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F65C")]
		[Address(RVA = "0x1911D50", Offset = "0x1910950", VA = "0x181911D50")]
		public RoguelikeMenuInitSquadWindow()
		{
		}

		// Token: 0x0402A35F RID: 172895
		[Token(Token = "0x402A35F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402A360 RID: 172896
		[Token(Token = "0x402A360")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402A361 RID: 172897
		[Token(Token = "0x402A361")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0402A362 RID: 172898
		[Token(Token = "0x402A362")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeMenuInitDifficultyView _diffView;

		// Token: 0x0402A363 RID: 172899
		[Token(Token = "0x402A363")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeRelicViewModel m_cachedModel;

		// Token: 0x0402A364 RID: 172900
		[Token(Token = "0x402A364")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedItemId;

		// Token: 0x0402A365 RID: 172901
		[Token(Token = "0x402A365")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A366 RID: 172902
		[Token(Token = "0x402A366")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A367 RID: 172903
		[Token(Token = "0x402A367")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
