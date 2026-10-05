using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004505 RID: 17669
	[Token(Token = "0x2004505")]
	public class RoguelikeCommonOuterBuffNodeSocket : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0601AF64 RID: 110436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004002")]
		public List<RoguelikeCommonOuterBuffNodeSocket.LineGroup> fromLines
		{
			[Token(Token = "0x601AF64")]
			[Address(RVA = "0x141F1D0", Offset = "0x141DDD0", VA = "0x18141F1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0601AF65 RID: 110437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004003")]
		public List<RoguelikeCommonOuterBuffNodeSocket.LineGroup> lines
		{
			[Token(Token = "0x601AF65")]
			[Address(RVA = "0x141F230", Offset = "0x141DE30", VA = "0x18141F230")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF66")]
		[Address(RVA = "0x141EC90", Offset = "0x141D890", VA = "0x18141EC90")]
		public void Init(bool isActive)
		{
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF67")]
		[Address(RVA = "0x141EEA0", Offset = "0x141DAA0", VA = "0x18141EEA0")]
		public void Render(bool isActive, float delay)
		{
		}

		// Token: 0x0601AF68 RID: 110440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF68")]
		[Address(RVA = "0x141F0E0", Offset = "0x141DCE0", VA = "0x18141F0E0")]
		public RoguelikeCommonOuterBuffNodeSocket()
		{
		}

		// Token: 0x0402299A RID: 141722
		[Token(Token = "0x402299A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x0402299B RID: 141723
		[Token(Token = "0x402299B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffNodeSocket.LineGroup> _fromLines;

		// Token: 0x0402299C RID: 141724
		[Token(Token = "0x402299C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffNodeSocket.LineGroup> _lines;

		// Token: 0x0402299D RID: 141725
		[Token(Token = "0x402299D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _animLength;

		// Token: 0x0402299E RID: 141726
		[Token(Token = "0x402299E")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0402299F RID: 141727
		[Token(Token = "0x402299F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isActive;

		// Token: 0x040229A0 RID: 141728
		[Token(Token = "0x40229A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fromLines;

		// Token: 0x040229A1 RID: 141729
		[Token(Token = "0x40229A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lines;

		// Token: 0x040229A2 RID: 141730
		[Token(Token = "0x40229A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040229A3 RID: 141731
		[Token(Token = "0x40229A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229A4 RID: 141732
		[Token(Token = "0x40229A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004506 RID: 17670
		[Token(Token = "0x2004506")]
		[Serializable]
		public struct LineGroup
		{
			// Token: 0x040229A5 RID: 141733
			[Token(Token = "0x40229A5")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeCommonOuterBuffLine.Direction direction;

			// Token: 0x040229A6 RID: 141734
			[Token(Token = "0x40229A6")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeCommonOuterBuffLine line;
		}
	}
}
