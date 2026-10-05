using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED6 RID: 20182
	[Token(Token = "0x2004ED6")]
	public class FifthAnnivExploreMapEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E1CC RID: 123340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1CC")]
		[Address(RVA = "0x17CEF50", Offset = "0x17CDB50", VA = "0x1817CEF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E1CD RID: 123341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1CD")]
		[Address(RVA = "0x17CED70", Offset = "0x17CD970", VA = "0x1817CED70")]
		public void Play(bool skipEntry)
		{
		}

		// Token: 0x0601E1CE RID: 123342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1CE")]
		[Address(RVA = "0x17CF020", Offset = "0x17CDC20", VA = "0x1817CF020")]
		public FifthAnnivExploreMapEffect()
		{
		}

		// Token: 0x0402811B RID: 164123
		[Token(Token = "0x402811B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation[] _animEntryMap;

		// Token: 0x0402811C RID: 164124
		[Token(Token = "0x402811C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation[] _animLoopMap;

		// Token: 0x0402811D RID: 164125
		[Token(Token = "0x402811D")]
		[FieldOffset(Offset = "0x28")]
		private UITwoStepAnimation m_player;

		// Token: 0x0402811E RID: 164126
		[Token(Token = "0x402811E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402811F RID: 164127
		[Token(Token = "0x402811F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04028120 RID: 164128
		[Token(Token = "0x4028120")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
