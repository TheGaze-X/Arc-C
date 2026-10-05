using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004613 RID: 17939
	[Token(Token = "0x2004613")]
	public class RL02OuterBuffLineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B43F RID: 111679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B43F")]
		[Address(RVA = "0x149D3E0", Offset = "0x149BFE0", VA = "0x18149D3E0")]
		public void Render(PolarPoint fromPos, PolarPoint toPos, bool isUnlock)
		{
		}

		// Token: 0x0601B440 RID: 111680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B440")]
		[Address(RVA = "0x149D620", Offset = "0x149C220", VA = "0x18149D620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B441 RID: 111681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B441")]
		[Address(RVA = "0x149D740", Offset = "0x149C340", VA = "0x18149D740")]
		public RL02OuterBuffLineItemView()
		{
		}

		// Token: 0x040232F2 RID: 144114
		[Token(Token = "0x40232F2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL02OuterBuffCurve _curve;

		// Token: 0x040232F3 RID: 144115
		[Token(Token = "0x40232F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _curveLockedColor;

		// Token: 0x040232F4 RID: 144116
		[Token(Token = "0x40232F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _curveUnlockColor;

		// Token: 0x040232F5 RID: 144117
		[Token(Token = "0x40232F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _curveFadetime;

		// Token: 0x040232F6 RID: 144118
		[Token(Token = "0x40232F6")]
		[FieldOffset(Offset = "0x48")]
		private RL02OuterBuffLineItemView.CurveColorSwitchTween m_curveSwitchTween;

		// Token: 0x040232F7 RID: 144119
		[Token(Token = "0x40232F7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040232F8 RID: 144120
		[Token(Token = "0x40232F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040232F9 RID: 144121
		[Token(Token = "0x40232F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040232FA RID: 144122
		[Token(Token = "0x40232FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004614 RID: 17940
		[Token(Token = "0x2004614")]
		private class CurveColorSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x0601B442 RID: 111682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B442")]
			[Address(RVA = "0x1496110", Offset = "0x1494D10", VA = "0x181496110")]
			public CurveColorSwitchTween(RL02OuterBuffLineItemView closure)
			{
			}

			// Token: 0x0601B443 RID: 111683 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B443")]
			[Address(RVA = "0x1495E60", Offset = "0x1494A60", VA = "0x181495E60", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B444 RID: 111684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B444")]
			[Address(RVA = "0x1495F40", Offset = "0x1494B40", VA = "0x181495F40", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B445 RID: 111685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B445")]
			[Address(RVA = "0x1496020", Offset = "0x1494C20", VA = "0x181496020", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B446 RID: 111686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B446")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040232FB RID: 144123
			[Token(Token = "0x40232FB")]
			[FieldOffset(Offset = "0x48")]
			private RL02OuterBuffLineItemView m_closure;

			// Token: 0x040232FC RID: 144124
			[Token(Token = "0x40232FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040232FD RID: 144125
			[Token(Token = "0x40232FD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040232FE RID: 144126
			[Token(Token = "0x40232FE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040232FF RID: 144127
			[Token(Token = "0x40232FF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
