using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005792 RID: 22418
	[Token(Token = "0x2005792")]
	public class RL02MenuDiceWindow : RoguelikeMenuWindow<RL02DiceViewModel>
	{
		// Token: 0x06020CC0 RID: 134336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC0")]
		[Address(RVA = "0x1B23A00", Offset = "0x1B22600", VA = "0x181B23A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x06020CC1 RID: 134337 RVA: 0x000B7558 File Offset: 0x000B5758
		[Token(Token = "0x17004CE2")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020CC1")]
			[Address(RVA = "0x1B23BD0", Offset = "0x1B227D0", VA = "0x181B23BD0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020CC2 RID: 134338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CC2")]
		[Address(RVA = "0x1B236C0", Offset = "0x1B222C0", VA = "0x181B236C0", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020CC3 RID: 134339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC3")]
		[Address(RVA = "0x1B23720", Offset = "0x1B22320", VA = "0x181B23720", Slot = "8")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x06020CC4 RID: 134340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC4")]
		[Address(RVA = "0x1B237A0", Offset = "0x1B223A0", VA = "0x181B237A0", Slot = "10")]
		public override void Render(RL02DiceViewModel viewModel)
		{
		}

		// Token: 0x06020CC5 RID: 134341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC5")]
		[Address(RVA = "0x1B23B00", Offset = "0x1B22700", VA = "0x181B23B00")]
		public RL02MenuDiceWindow()
		{
		}

		// Token: 0x06020CC6 RID: 134342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CC6")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020CC7 RID: 134343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CC7")]
		[Address(RVA = "0x19153E0", Offset = "0x1913FE0", VA = "0x1819153E0")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402C8EA RID: 182506
		[Token(Token = "0x402C8EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _dictDesc;

		// Token: 0x0402C8EB RID: 182507
		[Token(Token = "0x402C8EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _diceIcon;

		// Token: 0x0402C8EC RID: 182508
		[Token(Token = "0x402C8EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _diceIconAtlas;

		// Token: 0x0402C8ED RID: 182509
		[Token(Token = "0x402C8ED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL02MenuDiceWindow.AtlasConfig[] _diceIconConfig;

		// Token: 0x0402C8EE RID: 182510
		[Token(Token = "0x402C8EE")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, string> m_diceIconNameDict;

		// Token: 0x0402C8EF RID: 182511
		[Token(Token = "0x402C8EF")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedFaceNum;

		// Token: 0x0402C8F0 RID: 182512
		[Token(Token = "0x402C8F0")]
		[FieldOffset(Offset = "0x54")]
		private bool m_inited;

		// Token: 0x0402C8F1 RID: 182513
		[Token(Token = "0x402C8F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C8F2 RID: 182514
		[Token(Token = "0x402C8F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C8F3 RID: 182515
		[Token(Token = "0x402C8F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402C8F4 RID: 182516
		[Token(Token = "0x402C8F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402C8F5 RID: 182517
		[Token(Token = "0x402C8F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C8F6 RID: 182518
		[Token(Token = "0x402C8F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005793 RID: 22419
		[Token(Token = "0x2005793")]
		[Serializable]
		private struct AtlasConfig
		{
			// Token: 0x0402C8F7 RID: 182519
			[Token(Token = "0x402C8F7")]
			[FieldOffset(Offset = "0x0")]
			public int faceNum;

			// Token: 0x0402C8F8 RID: 182520
			[Token(Token = "0x402C8F8")]
			[FieldOffset(Offset = "0x8")]
			public string atlasName;
		}
	}
}
