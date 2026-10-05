using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public class InertiaTickHandler : IScrollTickHandler
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x5B89F70", Offset = "0x5B88B70", VA = "0x185B89F70")]
		public InertiaTickHandler(InertiaTickHandler.Option option, IScrollNormalizedPosition scrollNormalizedPosition)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000041B8 File Offset: 0x000023B8
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000170")]
		public Vector2 OutputDelta
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1692370", Offset = "0x1690F70", VA = "0x181692370")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1692850", Offset = "0x1691450", VA = "0x181692850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x17000171")]
		public float damping
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x5B89FE0", Offset = "0x5B88BE0", VA = "0x185B89FE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x17000172")]
		public float maxVelocity
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x5B8A040", Offset = "0x5B88C40", VA = "0x185B8A040")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x17000173")]
		public float duration
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x5B8A000", Offset = "0x5B88C00", VA = "0x185B8A000")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x17000174")]
		public Ease ease
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x5B8A020", Offset = "0x5B88C20", VA = "0x185B8A020")]
			get
			{
				return Ease.Unset;
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x5B89AD0", Offset = "0x5B886D0", VA = "0x185B89AD0", Slot = "7")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x5B897D0", Offset = "0x5B883D0", VA = "0x185B897D0", Slot = "5")]
		public void AddVelocity(Vector2 acceleration)
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x5B89A20", Offset = "0x5B88620", VA = "0x185B89A20", Slot = "6")]
		public void Interrupt()
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x5B89980", Offset = "0x5B88580", VA = "0x185B89980")]
		public void Damp(float factor)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x5B899D0", Offset = "0x5B885D0", VA = "0x185B899D0", Slot = "4")]
		public void Init(Action<Vector2> onMove)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x5B89AB0", Offset = "0x5B886B0", VA = "0x185B89AB0", Slot = "8")]
		public bool IsScrolling()
		{
			return default(bool);
		}

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x10")]
		private IScrollNormalizedPosition m_scrollNormalizedPosition;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		private float m_defaultDamping;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x1C")]
		private float m_defaultMaxVelocity;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x20")]
		private float m_defaultDuration;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		private const float Epsilon = 0.0001f;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x24")]
		private Ease m_defaultEase;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 m_currentVelocity;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 m_velocity;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x38")]
		private float m_decayElapsed;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x40")]
		private EaseFunction m_easeFunction;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x50")]
		private InertiaTickHandler.Option m_option;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x58")]
		private Action<Vector2> m_onMove;

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		[Serializable]
		public class Option
		{
			// Token: 0x0600059F RID: 1439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x10")]
			public bool useCustomize;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x14")]
			public float damping;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x18")]
			public float maxVelocity;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x1C")]
			public float sensity;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x20")]
			public Ease ease;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x24")]
			public float duration;
		}
	}
}
