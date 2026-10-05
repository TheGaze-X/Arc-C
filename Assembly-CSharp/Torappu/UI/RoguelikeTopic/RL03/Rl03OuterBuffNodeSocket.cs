using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D1 RID: 17873
	[Token(Token = "0x20045D1")]
	public class Rl03OuterBuffNodeSocket : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0601B303 RID: 111363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040C3")]
		public List<Rl03OuterBuffNodeSocket.LineGroup> fromLines
		{
			[Token(Token = "0x601B303")]
			[Address(RVA = "0x14582C0", Offset = "0x1456EC0", VA = "0x1814582C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0601B304 RID: 111364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040C4")]
		public List<Rl03OuterBuffNodeSocket.LineGroup> lines
		{
			[Token(Token = "0x601B304")]
			[Address(RVA = "0x1458320", Offset = "0x1456F20", VA = "0x181458320")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B305 RID: 111365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B305")]
		[Address(RVA = "0x1457D70", Offset = "0x1456970", VA = "0x181457D70")]
		public void Init(bool isActive)
		{
		}

		// Token: 0x0601B306 RID: 111366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B306")]
		[Address(RVA = "0x1457F90", Offset = "0x1456B90", VA = "0x181457F90")]
		public void Render(bool isActive, float delay)
		{
		}

		// Token: 0x0601B307 RID: 111367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B307")]
		[Address(RVA = "0x14581D0", Offset = "0x1456DD0", VA = "0x1814581D0")]
		public Rl03OuterBuffNodeSocket()
		{
		}

		// Token: 0x04023076 RID: 143478
		[Token(Token = "0x4023076")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x04023077 RID: 143479
		[Token(Token = "0x4023077")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Rl03OuterBuffNodeSocket.LineGroup> _fromLines;

		// Token: 0x04023078 RID: 143480
		[Token(Token = "0x4023078")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Rl03OuterBuffNodeSocket.LineGroup> _lines;

		// Token: 0x04023079 RID: 143481
		[Token(Token = "0x4023079")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _animLength;

		// Token: 0x0402307A RID: 143482
		[Token(Token = "0x402307A")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0402307B RID: 143483
		[Token(Token = "0x402307B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isActive;

		// Token: 0x0402307C RID: 143484
		[Token(Token = "0x402307C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fromLines;

		// Token: 0x0402307D RID: 143485
		[Token(Token = "0x402307D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lines;

		// Token: 0x0402307E RID: 143486
		[Token(Token = "0x402307E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402307F RID: 143487
		[Token(Token = "0x402307F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023080 RID: 143488
		[Token(Token = "0x4023080")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045D2 RID: 17874
		[Token(Token = "0x20045D2")]
		[Serializable]
		public struct LineGroup
		{
			// Token: 0x04023081 RID: 143489
			[Token(Token = "0x4023081")]
			[FieldOffset(Offset = "0x0")]
			public Rl03OuterBuffLine.Direction direction;

			// Token: 0x04023082 RID: 143490
			[Token(Token = "0x4023082")]
			[FieldOffset(Offset = "0x8")]
			public Rl03OuterBuffLine line;
		}
	}
}
