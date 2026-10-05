using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036FA RID: 14074
	[Token(Token = "0x20036FA")]
	public abstract class UIProceduralTween<TClip> : IHotfixable where TClip : IProceduralClip
	{
		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x06016591 RID: 91537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016592 RID: 91538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A9")]
		public Tween handler
		{
			[Token(Token = "0x6016591")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6016592")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06016593 RID: 91539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016593")]
		public void Play(IList<TClip> clips, UIProceduralTween<TClip>.PlayOptions options)
		{
		}

		// Token: 0x06016594 RID: 91540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016594")]
		public void Kill()
		{
		}

		// Token: 0x06016595 RID: 91541 RVA: 0x00090AB0 File Offset: 0x0008ECB0
		[Token(Token = "0x6016595")]
		private int _ScanLength(IList<TClip> items)
		{
			return 0;
		}

		// Token: 0x06016596 RID: 91542 RVA: 0x00090AC8 File Offset: 0x0008ECC8
		[Token(Token = "0x6016596")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x06016597 RID: 91543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016597")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x06016598 RID: 91544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016598")]
		private void _SampleEnd()
		{
		}

		// Token: 0x06016599 RID: 91545
		[Token(Token = "0x6016599")]
		protected abstract void SampleClip(TClip clip, int localIndex);

		// Token: 0x0601659A RID: 91546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601659A")]
		protected virtual void OnClipPlayed(TClip clip)
		{
		}

		// Token: 0x0601659B RID: 91547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601659B")]
		protected UIProceduralTween()
		{
		}

		// Token: 0x0401AE1F RID: 110111
		[Token(Token = "0x401AE1F")]
		[FieldOffset(Offset = "0x0")]
		private IList<TClip> m_clips;

		// Token: 0x0401AE20 RID: 110112
		[Token(Token = "0x401AE20")]
		[FieldOffset(Offset = "0x0")]
		private int m_clipCount;

		// Token: 0x0401AE21 RID: 110113
		[Token(Token = "0x401AE21")]
		[FieldOffset(Offset = "0x0")]
		private int m_playingClipIndex;

		// Token: 0x0401AE22 RID: 110114
		[Token(Token = "0x401AE22")]
		[FieldOffset(Offset = "0x0")]
		private TClip m_playingClip;

		// Token: 0x0401AE23 RID: 110115
		[Token(Token = "0x401AE23")]
		[FieldOffset(Offset = "0x0")]
		private int m_lengthOfAllClips;

		// Token: 0x0401AE24 RID: 110116
		[Token(Token = "0x401AE24")]
		[FieldOffset(Offset = "0x0")]
		private int m_lengthOfPlayedClips;

		// Token: 0x0401AE25 RID: 110117
		[Token(Token = "0x401AE25")]
		[FieldOffset(Offset = "0x0")]
		private float m_playPosition;

		// Token: 0x0401AE27 RID: 110119
		[Token(Token = "0x401AE27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x0401AE28 RID: 110120
		[Token(Token = "0x401AE28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_handler;

		// Token: 0x0401AE29 RID: 110121
		[Token(Token = "0x401AE29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401AE2A RID: 110122
		[Token(Token = "0x401AE2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Kill;

		// Token: 0x0401AE2B RID: 110123
		[Token(Token = "0x401AE2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ScanLength;

		// Token: 0x0401AE2C RID: 110124
		[Token(Token = "0x401AE2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401AE2D RID: 110125
		[Token(Token = "0x401AE2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0401AE2E RID: 110126
		[Token(Token = "0x401AE2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SampleEnd;

		// Token: 0x0401AE2F RID: 110127
		[Token(Token = "0x401AE2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClipPlayed;

		// Token: 0x0401AE30 RID: 110128
		[Token(Token = "0x401AE30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020036FB RID: 14075
		[Token(Token = "0x20036FB")]
		public struct PlayOptions
		{
			// Token: 0x0401AE31 RID: 110129
			[Token(Token = "0x401AE31")]
			[FieldOffset(Offset = "0x0")]
			public float duration;

			// Token: 0x0401AE32 RID: 110130
			[Token(Token = "0x401AE32")]
			[FieldOffset(Offset = "0x0")]
			public Ease ease;
		}
	}
}
