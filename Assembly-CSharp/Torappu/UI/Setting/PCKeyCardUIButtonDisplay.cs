using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD0 RID: 16336
	[Token(Token = "0x2003FD0")]
	[RequireComponent(typeof(UIButton))]
	public class PCKeyCardUIButtonDisplay : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019529 RID: 103721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019529")]
		[Address(RVA = "0x11F8640", Offset = "0x11F7240", VA = "0x1811F8640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601952A RID: 103722 RVA: 0x0009DBC0 File Offset: 0x0009BDC0
		[Token(Token = "0x601952A")]
		[Address(RVA = "0x11F8D30", Offset = "0x11F7930", VA = "0x1811F8D30")]
		private bool _ShouldDisplayKeyCard(KeyBoardVirtualButtonConfig config)
		{
			return default(bool);
		}

		// Token: 0x0601952B RID: 103723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601952B")]
		[Address(RVA = "0x11F8560", Offset = "0x11F7160", VA = "0x1811F8560")]
		private void _Cleanup()
		{
		}

		// Token: 0x0601952C RID: 103724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601952C")]
		[Address(RVA = "0x11F8500", Offset = "0x11F7100", VA = "0x1811F8500")]
		private void OnEnable()
		{
		}

		// Token: 0x0601952D RID: 103725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601952D")]
		[Address(RVA = "0x11F83E0", Offset = "0x11F6FE0", VA = "0x1811F83E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601952E RID: 103726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601952E")]
		[Address(RVA = "0x11F8DF0", Offset = "0x11F79F0", VA = "0x1811F8DF0")]
		public PCKeyCardUIButtonDisplay()
		{
		}

		// Token: 0x0401F78E RID: 128910
		[Token(Token = "0x401F78E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _cardHolder;

		// Token: 0x0401F78F RID: 128911
		[Token(Token = "0x401F78F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x0401F790 RID: 128912
		[Token(Token = "0x401F790")]
		[FieldOffset(Offset = "0x28")]
		private PCKeyCard m_keyCard;

		// Token: 0x0401F791 RID: 128913
		[Token(Token = "0x401F791")]
		[FieldOffset(Offset = "0x30")]
		private UIButton m_button;

		// Token: 0x0401F792 RID: 128914
		[Token(Token = "0x401F792")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401F793 RID: 128915
		[Token(Token = "0x401F793")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F794 RID: 128916
		[Token(Token = "0x401F794")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShouldDisplayKeyCard;

		// Token: 0x0401F795 RID: 128917
		[Token(Token = "0x401F795")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Cleanup;

		// Token: 0x0401F796 RID: 128918
		[Token(Token = "0x401F796")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401F797 RID: 128919
		[Token(Token = "0x401F797")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F798 RID: 128920
		[Token(Token = "0x401F798")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
