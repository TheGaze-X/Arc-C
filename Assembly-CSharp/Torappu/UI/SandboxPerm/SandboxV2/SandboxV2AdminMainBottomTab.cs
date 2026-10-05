using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B2 RID: 16562
	[Token(Token = "0x20040B2")]
	public class SandboxV2AdminMainBottomTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000085 RID: 133
		// (add) Token: 0x060199F5 RID: 104949 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060199F6 RID: 104950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000085")]
		public event Action<SandboxV2AdminMainPanelType> eClick
		{
			[Token(Token = "0x60199F5")]
			[Address(RVA = "0x1273460", Offset = "0x1272060", VA = "0x181273460")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60199F6")]
			[Address(RVA = "0x1273740", Offset = "0x1272340", VA = "0x181273740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x060199F7 RID: 104951 RVA: 0x0009ED78 File Offset: 0x0009CF78
		[Token(Token = "0x17003D28")]
		public SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x60199F7")]
			[Address(RVA = "0x12736E0", Offset = "0x12722E0", VA = "0x1812736E0")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x060199F8 RID: 104952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199F8")]
		[Address(RVA = "0x12731A0", Offset = "0x1271DA0", VA = "0x1812731A0")]
		public void EventOnClick()
		{
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x060199F9 RID: 104953 RVA: 0x0009ED90 File Offset: 0x0009CF90
		// (set) Token: 0x060199FA RID: 104954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D29")]
		public bool active
		{
			[Token(Token = "0x60199F9")]
			[Address(RVA = "0x1273560", Offset = "0x1272160", VA = "0x181273560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60199FA")]
			[Address(RVA = "0x1273840", Offset = "0x1272440", VA = "0x181273840")]
			set
			{
			}
		}

		// Token: 0x060199FB RID: 104955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199FB")]
		[Address(RVA = "0x1273210", Offset = "0x1271E10", VA = "0x181273210")]
		public void TweenToSelect(SandboxV2AdminMainPanelType selType, float dur)
		{
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x060199FC RID: 104956 RVA: 0x0009EDA8 File Offset: 0x0009CFA8
		[Token(Token = "0x17003D2A")]
		public Vector2 anchoredPosition
		{
			[Token(Token = "0x60199FC")]
			[Address(RVA = "0x12735D0", Offset = "0x12721D0", VA = "0x1812735D0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060199FD RID: 104957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199FD")]
		[Address(RVA = "0x1273400", Offset = "0x1272000", VA = "0x181273400")]
		public SandboxV2AdminMainBottomTab()
		{
		}

		// Token: 0x04020027 RID: 131111
		[Token(Token = "0x4020027")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminMainPanelType _panelType;

		// Token: 0x04020028 RID: 131112
		[Token(Token = "0x4020028")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _graphic;

		// Token: 0x04020029 RID: 131113
		[Token(Token = "0x4020029")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_rt;

		// Token: 0x0402002A RID: 131114
		[Token(Token = "0x402002A")]
		[FieldOffset(Offset = "0x30")]
		private Tweener m_tween;

		// Token: 0x0402002C RID: 131116
		[Token(Token = "0x402002C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eClick;

		// Token: 0x0402002D RID: 131117
		[Token(Token = "0x402002D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eClick;

		// Token: 0x0402002E RID: 131118
		[Token(Token = "0x402002E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402002F RID: 131119
		[Token(Token = "0x402002F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04020030 RID: 131120
		[Token(Token = "0x4020030")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_active;

		// Token: 0x04020031 RID: 131121
		[Token(Token = "0x4020031")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_active;

		// Token: 0x04020032 RID: 131122
		[Token(Token = "0x4020032")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TweenToSelect;

		// Token: 0x04020033 RID: 131123
		[Token(Token = "0x4020033")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_anchoredPosition;

		// Token: 0x04020034 RID: 131124
		[Token(Token = "0x4020034")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
