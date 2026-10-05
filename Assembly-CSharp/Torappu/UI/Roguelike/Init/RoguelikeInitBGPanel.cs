using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Init.Style;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057DA RID: 22490
	[Token(Token = "0x20057DA")]
	public class RoguelikeInitBGPanel : RoguelikeInitPanel
	{
		// Token: 0x06020E54 RID: 134740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E54")]
		[Address(RVA = "0x1B34F20", Offset = "0x1B33B20", VA = "0x181B34F20", Slot = "7")]
		public override void OnValueChanged(RoguelikeInitModelProperty property)
		{
		}

		// Token: 0x06020E55 RID: 134741 RVA: 0x000B7B58 File Offset: 0x000B5D58
		[Token(Token = "0x6020E55")]
		[Address(RVA = "0x1B35540", Offset = "0x1B34140", VA = "0x181B35540")]
		private float _CurPrg()
		{
			return 0f;
		}

		// Token: 0x06020E56 RID: 134742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E56")]
		[Address(RVA = "0x1B355F0", Offset = "0x1B341F0", VA = "0x181B355F0")]
		private void _SetPrg(float v)
		{
		}

		// Token: 0x06020E57 RID: 134743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E57")]
		[Address(RVA = "0x1B356B0", Offset = "0x1B342B0", VA = "0x181B356B0")]
		private void _UpdatePoint()
		{
		}

		// Token: 0x06020E58 RID: 134744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E58")]
		[Address(RVA = "0x1B35880", Offset = "0x1B34480", VA = "0x181B35880")]
		public RoguelikeInitBGPanel()
		{
		}

		// Token: 0x0402CB1E RID: 183070
		[Token(Token = "0x402CB1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stepTitleLabel;

		// Token: 0x0402CB1F RID: 183071
		[Token(Token = "0x402CB1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _stepPrgAnimDur;

		// Token: 0x0402CB20 RID: 183072
		[Token(Token = "0x402CB20")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Scrollbar _stepPrg;

		// Token: 0x0402CB21 RID: 183073
		[Token(Token = "0x402CB21")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _stepPoints;

		// Token: 0x0402CB22 RID: 183074
		[Token(Token = "0x402CB22")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeInitStyle m_style;

		// Token: 0x0402CB23 RID: 183075
		[Token(Token = "0x402CB23")]
		[FieldOffset(Offset = "0x48")]
		private int m_step;

		// Token: 0x0402CB24 RID: 183076
		[Token(Token = "0x402CB24")]
		[FieldOffset(Offset = "0x4C")]
		private int m_maxStep;

		// Token: 0x0402CB25 RID: 183077
		[Token(Token = "0x402CB25")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_tweener;

		// Token: 0x0402CB26 RID: 183078
		[Token(Token = "0x402CB26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402CB27 RID: 183079
		[Token(Token = "0x402CB27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CurPrg;

		// Token: 0x0402CB28 RID: 183080
		[Token(Token = "0x402CB28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetPrg;

		// Token: 0x0402CB29 RID: 183081
		[Token(Token = "0x402CB29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdatePoint;

		// Token: 0x0402CB2A RID: 183082
		[Token(Token = "0x402CB2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
