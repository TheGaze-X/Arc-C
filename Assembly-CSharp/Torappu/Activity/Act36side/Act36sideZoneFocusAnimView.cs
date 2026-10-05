using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007460 RID: 29792
	[Token(Token = "0x2007460")]
	public class Act36sideZoneFocusAnimView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A06F RID: 172143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A06F")]
		[Address(RVA = "0x25A0690", Offset = "0x259F290", VA = "0x1825A0690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x0602A070 RID: 172144 RVA: 0x000D7460 File Offset: 0x000D5660
		// (set) Token: 0x0602A071 RID: 172145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006323")]
		public bool isShow
		{
			[Token(Token = "0x602A070")]
			[Address(RVA = "0x25A0A20", Offset = "0x259F620", VA = "0x1825A0A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A071")]
			[Address(RVA = "0x25A0AA0", Offset = "0x259F6A0", VA = "0x1825A0AA0")]
			set
			{
			}
		}

		// Token: 0x0602A072 RID: 172146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A072")]
		[Address(RVA = "0x25A0600", Offset = "0x259F200", VA = "0x1825A0600")]
		public void Reset(bool isShow)
		{
		}

		// Token: 0x0602A073 RID: 172147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A073")]
		[Address(RVA = "0x25A0970", Offset = "0x259F570", VA = "0x1825A0970")]
		public Act36sideZoneFocusAnimView()
		{
		}

		// Token: 0x0403C49E RID: 246942
		[Token(Token = "0x403C49E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403C49F RID: 246943
		[Token(Token = "0x403C49F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _exitAnim;

		// Token: 0x0403C4A0 RID: 246944
		[Token(Token = "0x403C4A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<UIAnimationLocation> _loopAnims;

		// Token: 0x0403C4A1 RID: 246945
		[Token(Token = "0x403C4A1")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403C4A2 RID: 246946
		[Token(Token = "0x403C4A2")]
		[FieldOffset(Offset = "0x48")]
		private UIBiAnimClipSwitchTween m_focusAnimTween;

		// Token: 0x0403C4A3 RID: 246947
		[Token(Token = "0x403C4A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C4A4 RID: 246948
		[Token(Token = "0x403C4A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403C4A5 RID: 246949
		[Token(Token = "0x403C4A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403C4A6 RID: 246950
		[Token(Token = "0x403C4A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0403C4A7 RID: 246951
		[Token(Token = "0x403C4A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
