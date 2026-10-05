using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045CC RID: 17868
	[Token(Token = "0x20045CC")]
	public class Rl03OuterBuffLine : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B2EF RID: 111343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2EF")]
		[Address(RVA = "0x1457760", Offset = "0x1456360", VA = "0x181457760")]
		public void Init(bool isActive)
		{
		}

		// Token: 0x0601B2F0 RID: 111344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2F0")]
		[Address(RVA = "0x1457850", Offset = "0x1456450", VA = "0x181457850")]
		public void Render(bool isActive, Rl03OuterBuffLine.Direction direction, float delay)
		{
		}

		// Token: 0x0601B2F1 RID: 111345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2F1")]
		[Address(RVA = "0x1457AC0", Offset = "0x14566C0", VA = "0x181457AC0")]
		public Rl03OuterBuffLine()
		{
		}

		// Token: 0x0402305C RID: 143452
		[Token(Token = "0x402305C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x0402305D RID: 143453
		[Token(Token = "0x402305D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _toBuffId;

		// Token: 0x0402305E RID: 143454
		[Token(Token = "0x402305E")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x0402305F RID: 143455
		[Token(Token = "0x402305F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isActive;

		// Token: 0x04023060 RID: 143456
		[Token(Token = "0x4023060")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023061 RID: 143457
		[Token(Token = "0x4023061")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023062 RID: 143458
		[Token(Token = "0x4023062")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045CD RID: 17869
		[Token(Token = "0x20045CD")]
		public enum Direction
		{
			// Token: 0x04023064 RID: 143460
			[Token(Token = "0x4023064")]
			FORWARD,
			// Token: 0x04023065 RID: 143461
			[Token(Token = "0x4023065")]
			BACKWARD
		}
	}
}
