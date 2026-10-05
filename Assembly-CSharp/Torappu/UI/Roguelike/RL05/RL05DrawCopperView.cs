using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200558D RID: 21901
	[Token(Token = "0x200558D")]
	public class RL05DrawCopperView : AbstractRoguelikeDrawCopperView
	{
		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x060202BC RID: 131772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060202BD RID: 131773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B7A")]
		public override Action onConfirmDrawPending
		{
			[Token(Token = "0x60202BC")]
			[Address(RVA = "0x1A50760", Offset = "0x1A4F360", VA = "0x181A50760", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60202BD")]
			[Address(RVA = "0x1A507C0", Offset = "0x1A4F3C0", VA = "0x181A507C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060202BE RID: 131774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202BE")]
		[Address(RVA = "0x1A50570", Offset = "0x1A4F170", VA = "0x181A50570", Slot = "10")]
		protected override void _Render(RoguelikeDrawCopperViewModel model)
		{
		}

		// Token: 0x060202BF RID: 131775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202BF")]
		[Address(RVA = "0x1A50700", Offset = "0x1A4F300", VA = "0x181A50700")]
		public RL05DrawCopperView()
		{
		}

		// Token: 0x0402B780 RID: 178048
		[Token(Token = "0x402B780")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05EventDrawCopperView _eventDrawCopperViewPrefab;

		// Token: 0x0402B781 RID: 178049
		[Token(Token = "0x402B781")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _eventDrawContent;

		// Token: 0x0402B782 RID: 178050
		[Token(Token = "0x402B782")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0402B783 RID: 178051
		[Token(Token = "0x402B783")]
		[FieldOffset(Offset = "0x38")]
		private RL05EventDrawCopperView m_eventDrawCopperView;

		// Token: 0x0402B784 RID: 178052
		[Token(Token = "0x402B784")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B786 RID: 178054
		[Token(Token = "0x402B786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onConfirmDrawPending;

		// Token: 0x0402B787 RID: 178055
		[Token(Token = "0x402B787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onConfirmDrawPending;

		// Token: 0x0402B788 RID: 178056
		[Token(Token = "0x402B788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402B789 RID: 178057
		[Token(Token = "0x402B789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
