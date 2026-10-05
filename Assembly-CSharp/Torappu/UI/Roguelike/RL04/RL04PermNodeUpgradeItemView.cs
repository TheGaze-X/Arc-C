using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005700 RID: 22272
	[Token(Token = "0x2005700")]
	public class RL04PermNodeUpgradeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020AB3 RID: 133811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AB3")]
		[Address(RVA = "0x1ACE030", Offset = "0x1ACCC30", VA = "0x181ACE030")]
		public void Render(RL04PermNodeUpgradeItemView.Input input)
		{
		}

		// Token: 0x06020AB4 RID: 133812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AB4")]
		[Address(RVA = "0x1ACE440", Offset = "0x1ACD040", VA = "0x181ACE440")]
		public RL04PermNodeUpgradeItemView()
		{
		}

		// Token: 0x0402C547 RID: 181575
		[Token(Token = "0x402C547")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgTopLine;

		// Token: 0x0402C548 RID: 181576
		[Token(Token = "0x402C548")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBottomLine;

		// Token: 0x0402C549 RID: 181577
		[Token(Token = "0x402C549")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgDescBg;

		// Token: 0x0402C54A RID: 181578
		[Token(Token = "0x402C54A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorInactiveBg;

		// Token: 0x0402C54B RID: 181579
		[Token(Token = "0x402C54B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C54C RID: 181580
		[Token(Token = "0x402C54C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorInactiveDesc;

		// Token: 0x0402C54D RID: 181581
		[Token(Token = "0x402C54D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorActiveDesc;

		// Token: 0x0402C54E RID: 181582
		[Token(Token = "0x402C54E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _lockStatusPart;

		// Token: 0x0402C54F RID: 181583
		[Token(Token = "0x402C54F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _unlockStatusPart;

		// Token: 0x0402C550 RID: 181584
		[Token(Token = "0x402C550")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _todoStatusPart;

		// Token: 0x0402C551 RID: 181585
		[Token(Token = "0x402C551")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _imgUnlockStatusBg;

		// Token: 0x0402C552 RID: 181586
		[Token(Token = "0x402C552")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgToDoLockIcon;

		// Token: 0x0402C553 RID: 181587
		[Token(Token = "0x402C553")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _bgToDoGo;

		// Token: 0x0402C554 RID: 181588
		[Token(Token = "0x402C554")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _costPartGo;

		// Token: 0x0402C555 RID: 181589
		[Token(Token = "0x402C555")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textCostCount;

		// Token: 0x0402C556 RID: 181590
		[Token(Token = "0x402C556")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C557 RID: 181591
		[Token(Token = "0x402C557")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005701 RID: 22273
		[Token(Token = "0x2005701")]
		public class Input
		{
			// Token: 0x06020AB5 RID: 133813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020AB5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402C558 RID: 181592
			[Token(Token = "0x402C558")]
			[FieldOffset(Offset = "0x10")]
			public int position;

			// Token: 0x0402C559 RID: 181593
			[Token(Token = "0x402C559")]
			[FieldOffset(Offset = "0x18")]
			public RL04PermNodeUpgradeItemModel permItemModel;

			// Token: 0x0402C55A RID: 181594
			[Token(Token = "0x402C55A")]
			[FieldOffset(Offset = "0x20")]
			public RL04NodeUpgradeConfig styleConfig;

			// Token: 0x0402C55B RID: 181595
			[Token(Token = "0x402C55B")]
			[FieldOffset(Offset = "0x28")]
			public bool isPrevUnlock;

			// Token: 0x0402C55C RID: 181596
			[Token(Token = "0x402C55C")]
			[FieldOffset(Offset = "0x29")]
			public bool isCurrToDo;

			// Token: 0x0402C55D RID: 181597
			[Token(Token = "0x402C55D")]
			[FieldOffset(Offset = "0x2A")]
			public bool showCost;
		}
	}
}
