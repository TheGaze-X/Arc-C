using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005783 RID: 22403
	[Token(Token = "0x2005783")]
	public class RL02MenuDiceObject : RoguelikeMenuObject<RL02DiceViewModel>
	{
		// Token: 0x06020C89 RID: 134281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C89")]
		[Address(RVA = "0x1B232F0", Offset = "0x1B21EF0", VA = "0x181B232F0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x06020C8A RID: 134282 RVA: 0x000B7498 File Offset: 0x000B5698
		[Token(Token = "0x17004CDF")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020C8A")]
			[Address(RVA = "0x1B23660", Offset = "0x1B22260", VA = "0x181B23660", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020C8B RID: 134283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C8B")]
		[Address(RVA = "0x1B23400", Offset = "0x1B22000", VA = "0x181B23400", Slot = "16")]
		public override void Render(RL02DiceViewModel viewModel)
		{
		}

		// Token: 0x06020C8C RID: 134284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C8C")]
		[Address(RVA = "0x1B23590", Offset = "0x1B22190", VA = "0x181B23590")]
		public RL02MenuDiceObject()
		{
		}

		// Token: 0x06020C8D RID: 134285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C8D")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402C873 RID: 182387
		[Token(Token = "0x402C873")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0402C874 RID: 182388
		[Token(Token = "0x402C874")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _diceIcon;

		// Token: 0x0402C875 RID: 182389
		[Token(Token = "0x402C875")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _diceIconAtlas;

		// Token: 0x0402C876 RID: 182390
		[Token(Token = "0x402C876")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL02MenuDiceObject.AtlasConfig[] _diceIconConfig;

		// Token: 0x0402C877 RID: 182391
		[Token(Token = "0x402C877")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, string> m_diceIconNameDict;

		// Token: 0x0402C878 RID: 182392
		[Token(Token = "0x402C878")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedFaceNum;

		// Token: 0x0402C879 RID: 182393
		[Token(Token = "0x402C879")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C87A RID: 182394
		[Token(Token = "0x402C87A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C87B RID: 182395
		[Token(Token = "0x402C87B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C87C RID: 182396
		[Token(Token = "0x402C87C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005784 RID: 22404
		[Token(Token = "0x2005784")]
		[Serializable]
		private struct AtlasConfig
		{
			// Token: 0x0402C87D RID: 182397
			[Token(Token = "0x402C87D")]
			[FieldOffset(Offset = "0x0")]
			public int faceNum;

			// Token: 0x0402C87E RID: 182398
			[Token(Token = "0x402C87E")]
			[FieldOffset(Offset = "0x8")]
			public string atlasName;
		}
	}
}
