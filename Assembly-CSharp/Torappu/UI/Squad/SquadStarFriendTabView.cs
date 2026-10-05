using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E38 RID: 15928
	[Token(Token = "0x2003E38")]
	public class SquadStarFriendTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x06018C06 RID: 101382 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C07 RID: 101383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF0")]
		public Action<bool> onClick
		{
			[Token(Token = "0x6018C06")]
			[Address(RVA = "0x1180080", Offset = "0x117EC80", VA = "0x181180080")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6018C07")]
			[Address(RVA = "0x11800E0", Offset = "0x117ECE0", VA = "0x1811800E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06018C08 RID: 101384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C08")]
		[Address(RVA = "0x117FD60", Offset = "0x117E960", VA = "0x18117FD60")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x06018C09 RID: 101385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C09")]
		[Address(RVA = "0x117FCA0", Offset = "0x117E8A0", VA = "0x18117FCA0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06018C0A RID: 101386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0A")]
		[Address(RVA = "0x117FF00", Offset = "0x117EB00", VA = "0x18117FF00")]
		private void _InitIfNot(bool isSelected)
		{
		}

		// Token: 0x06018C0B RID: 101387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0B")]
		[Address(RVA = "0x1180020", Offset = "0x117EC20", VA = "0x181180020")]
		public SquadStarFriendTabView()
		{
		}

		// Token: 0x0401E698 RID: 124568
		[Token(Token = "0x401E698")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0401E69A RID: 124570
		[Token(Token = "0x401E69A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_cacheSelected;

		// Token: 0x0401E69B RID: 124571
		[Token(Token = "0x401E69B")]
		[FieldOffset(Offset = "0x38")]
		private UISwitchTween m_switchTween;

		// Token: 0x0401E69C RID: 124572
		[Token(Token = "0x401E69C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0401E69D RID: 124573
		[Token(Token = "0x401E69D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401E69E RID: 124574
		[Token(Token = "0x401E69E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401E69F RID: 124575
		[Token(Token = "0x401E69F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E6A0 RID: 124576
		[Token(Token = "0x401E6A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401E6A1 RID: 124577
		[Token(Token = "0x401E6A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E6A2 RID: 124578
		[Token(Token = "0x401E6A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
