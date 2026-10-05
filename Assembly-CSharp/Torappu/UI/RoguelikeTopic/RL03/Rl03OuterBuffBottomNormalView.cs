using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C5 RID: 17861
	[Token(Token = "0x20045C5")]
	public class Rl03OuterBuffBottomNormalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B2CE RID: 111310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2CE")]
		[Address(RVA = "0x1454D30", Offset = "0x1453930", VA = "0x181454D30")]
		public void Render(Rl03OuterBuffViewModel viewModel, Rl03OuterBuffNormalNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601B2CF RID: 111311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2CF")]
		[Address(RVA = "0x1455080", Offset = "0x1453C80", VA = "0x181455080")]
		public Rl03OuterBuffBottomNormalView()
		{
		}

		// Token: 0x04023011 RID: 143377
		[Token(Token = "0x4023011")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _normalName;

		// Token: 0x04023012 RID: 143378
		[Token(Token = "0x4023012")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _normalDesc;

		// Token: 0x04023013 RID: 143379
		[Token(Token = "0x4023013")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUpgraded;

		// Token: 0x04023014 RID: 143380
		[Token(Token = "0x4023014")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x04023015 RID: 143381
		[Token(Token = "0x4023015")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNoCost;

		// Token: 0x04023016 RID: 143382
		[Token(Token = "0x4023016")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelInGame;

		// Token: 0x04023017 RID: 143383
		[Token(Token = "0x4023017")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04023018 RID: 143384
		[Token(Token = "0x4023018")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _enoughCost;

		// Token: 0x04023019 RID: 143385
		[Token(Token = "0x4023019")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _notEnoughCost;

		// Token: 0x0402301A RID: 143386
		[Token(Token = "0x402301A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402301B RID: 143387
		[Token(Token = "0x402301B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
