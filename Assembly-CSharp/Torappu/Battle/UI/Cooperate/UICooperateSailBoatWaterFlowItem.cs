using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200341D RID: 13341
	[Token(Token = "0x200341D")]
	[Serializable]
	public class UICooperateSailBoatWaterFlowItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015523 RID: 87331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015523")]
		[Address(RVA = "0xDDAA60", Offset = "0xDD9660", VA = "0x180DDAA60")]
		public void UpdateWaterForceLevel(int level, bool isFastMode)
		{
		}

		// Token: 0x06015524 RID: 87332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015524")]
		[Address(RVA = "0xDDAD70", Offset = "0xDD9970", VA = "0x180DDAD70")]
		private void _SampleClipAtBegin()
		{
		}

		// Token: 0x06015525 RID: 87333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015525")]
		[Address(RVA = "0xDDA9D0", Offset = "0xDD95D0", VA = "0x180DDA9D0")]
		public void ResetAnim()
		{
		}

		// Token: 0x06015526 RID: 87334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015526")]
		[Address(RVA = "0xDDAE20", Offset = "0xDD9A20", VA = "0x180DDAE20")]
		public UICooperateSailBoatWaterFlowItem()
		{
		}

		// Token: 0x040197F4 RID: 104436
		[Token(Token = "0x40197F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _maskShowAnim;

		// Token: 0x040197F5 RID: 104437
		[Token(Token = "0x40197F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x040197F6 RID: 104438
		[Token(Token = "0x40197F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _slowLoopAnim;

		// Token: 0x040197F7 RID: 104439
		[Token(Token = "0x40197F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _fastLoopAnim;

		// Token: 0x040197F8 RID: 104440
		[Token(Token = "0x40197F8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _arrows;

		// Token: 0x040197F9 RID: 104441
		[Token(Token = "0x40197F9")]
		[FieldOffset(Offset = "0x60")]
		private int m_curLevel;

		// Token: 0x040197FA RID: 104442
		[Token(Token = "0x40197FA")]
		[FieldOffset(Offset = "0x68")]
		private Sequence m_sequenceTween;

		// Token: 0x040197FB RID: 104443
		[Token(Token = "0x40197FB")]
		private const float INSERT_LOOP_ANIM_TIME = 0.41f;

		// Token: 0x040197FC RID: 104444
		[Token(Token = "0x40197FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateWaterForceLevel;

		// Token: 0x040197FD RID: 104445
		[Token(Token = "0x40197FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SampleClipAtBegin;

		// Token: 0x040197FE RID: 104446
		[Token(Token = "0x40197FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x040197FF RID: 104447
		[Token(Token = "0x40197FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
