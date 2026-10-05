using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FDB RID: 16347
	[Token(Token = "0x2003FDB")]
	public class PCKeySettingTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601954F RID: 103759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601954F")]
		[Address(RVA = "0x11FC7A0", Offset = "0x11FB3A0", VA = "0x1811FC7A0")]
		public void Render(int sequenceNum, bool isCurrNormal)
		{
		}

		// Token: 0x06019550 RID: 103760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019550")]
		[Address(RVA = "0x11FC6C0", Offset = "0x11FB2C0", VA = "0x1811FC6C0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06019551 RID: 103761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019551")]
		[Address(RVA = "0x11FC950", Offset = "0x11FB550", VA = "0x1811FC950")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019552 RID: 103762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019552")]
		[Address(RVA = "0x11FCA60", Offset = "0x11FB660", VA = "0x1811FCA60")]
		public PCKeySettingTabView()
		{
		}

		// Token: 0x0401F7E0 RID: 128992
		[Token(Token = "0x401F7E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _tabAnim;

		// Token: 0x0401F7E1 RID: 128993
		[Token(Token = "0x401F7E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isNormal;

		// Token: 0x0401F7E2 RID: 128994
		[Token(Token = "0x401F7E2")]
		[FieldOffset(Offset = "0x29")]
		private bool m_hasInited;

		// Token: 0x0401F7E3 RID: 128995
		[Token(Token = "0x401F7E3")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_switchTween;

		// Token: 0x0401F7E4 RID: 128996
		[Token(Token = "0x401F7E4")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedSequenceNum;

		// Token: 0x0401F7E5 RID: 128997
		[Token(Token = "0x401F7E5")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401F7E6 RID: 128998
		[Token(Token = "0x401F7E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F7E7 RID: 128999
		[Token(Token = "0x401F7E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401F7E8 RID: 129000
		[Token(Token = "0x401F7E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7E9 RID: 129001
		[Token(Token = "0x401F7E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
