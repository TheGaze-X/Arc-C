using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200562E RID: 22062
	[Token(Token = "0x200562E")]
	public class RL05SpecialZoneNodeView : RL05SpecialZoneNodeViewBase
	{
		// Token: 0x06020612 RID: 132626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020612")]
		[Address(RVA = "0x1A86830", Offset = "0x1A85430", VA = "0x181A86830", Slot = "6")]
		public override void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x06020613 RID: 132627 RVA: 0x000B5A70 File Offset: 0x000B3C70
		[Token(Token = "0x6020613")]
		[Address(RVA = "0x1A867B0", Offset = "0x1A853B0", VA = "0x181A867B0", Slot = "7")]
		public override Color GetSelectableColor()
		{
			return default(Color);
		}

		// Token: 0x06020614 RID: 132628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020614")]
		[Address(RVA = "0x1A86F50", Offset = "0x1A85B50", VA = "0x181A86F50")]
		private void _RenderEmpty()
		{
		}

		// Token: 0x06020615 RID: 132629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020615")]
		[Address(RVA = "0x1A870B0", Offset = "0x1A85CB0", VA = "0x181A870B0")]
		private void _RenderLocked()
		{
		}

		// Token: 0x06020616 RID: 132630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020616")]
		[Address(RVA = "0x1A866F0", Offset = "0x1A852F0", VA = "0x181A866F0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06020617 RID: 132631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020617")]
		[Address(RVA = "0x1A87210", Offset = "0x1A85E10", VA = "0x181A87210")]
		public RL05SpecialZoneNodeView()
		{
		}

		// Token: 0x06020618 RID: 132632 RVA: 0x000B5A88 File Offset: 0x000B3C88
		[Token(Token = "0x6020618")]
		[Address(RVA = "0x1A86ED0", Offset = "0x1A85AD0", VA = "0x181A86ED0")]
		private Color <>xLuaBaseProxy_GetSelectableColor()
		{
			return default(Color);
		}

		// Token: 0x0402BD57 RID: 179543
		[Token(Token = "0x402BD57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Res")]
		private RL05SpecialZoneNodeViewData _viewData;

		// Token: 0x0402BD58 RID: 179544
		[Token(Token = "0x402BD58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Res")]
		private Sprite _lockedIcon;

		// Token: 0x0402BD59 RID: 179545
		[Token(Token = "0x402BD59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("NameColor")]
		private Color _invalidNameBkgColor;

		// Token: 0x0402BD5A RID: 179546
		[Token(Token = "0x402BD5A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("NameColor")]
		private Color _lockedNameBkgColor;

		// Token: 0x0402BD5B RID: 179547
		[Token(Token = "0x402BD5B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402BD5C RID: 179548
		[Token(Token = "0x402BD5C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _battleFlag;

		// Token: 0x0402BD5D RID: 179549
		[Token(Token = "0x402BD5D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _nameBkg;

		// Token: 0x0402BD5E RID: 179550
		[Token(Token = "0x402BD5E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402BD5F RID: 179551
		[Token(Token = "0x402BD5F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _clickHotSpot;

		// Token: 0x0402BD60 RID: 179552
		[Token(Token = "0x402BD60")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _repeatableEffContainer;

		// Token: 0x0402BD61 RID: 179553
		[Token(Token = "0x402BD61")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeDungeonNode m_cachedNode;

		// Token: 0x0402BD62 RID: 179554
		[Token(Token = "0x402BD62")]
		private const string INVALID_ICON_SUFFIX = "_invalid";

		// Token: 0x0402BD63 RID: 179555
		[Token(Token = "0x402BD63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD64 RID: 179556
		[Token(Token = "0x402BD64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSelectableColor;

		// Token: 0x0402BD65 RID: 179557
		[Token(Token = "0x402BD65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEmpty;

		// Token: 0x0402BD66 RID: 179558
		[Token(Token = "0x402BD66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderLocked;

		// Token: 0x0402BD67 RID: 179559
		[Token(Token = "0x402BD67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402BD68 RID: 179560
		[Token(Token = "0x402BD68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
