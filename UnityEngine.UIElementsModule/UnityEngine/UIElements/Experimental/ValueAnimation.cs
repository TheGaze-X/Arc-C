using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	public sealed class ValueAnimation<T> : IValueAnimationUpdate
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0000B880 File Offset: 0x00009A80
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000547")]
		public int durationMs
		{
			[Token(Token = "0x600155E")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600155F")]
			set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000548")]
		public Func<float, float> easingCurve
		{
			[Token(Token = "0x6001560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001561")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0000B898 File Offset: 0x00009A98
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000549")]
		public bool isRunning
		{
			[Token(Token = "0x6001562")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001563")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public Action onAnimationCompleted
		{
			[Token(Token = "0x6001564")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001565")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054B")]
		public bool autoRecycle
		{
			[Token(Token = "0x6001566")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001567")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054C")]
		private bool recycled
		{
			[Token(Token = "0x6001568")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001569")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054D")]
		private VisualElement owner
		{
			[Token(Token = "0x600156A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600156B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054E")]
		public Action<VisualElement, T> valueUpdated
		{
			[Token(Token = "0x600156C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600156D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054F")]
		public Func<VisualElement, T> initialValue
		{
			[Token(Token = "0x600156E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600156F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000550")]
		public Func<T, T, float, T> interpolator
		{
			[Token(Token = "0x6001570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001571")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000551")]
		public T from
		{
			[Token(Token = "0x6001572")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001573")]
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public T to
		{
			[Token(Token = "0x6001574")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001575")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001576")]
		public ValueAnimation()
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001577")]
		public void Start()
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		public void Stop()
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		public void Recycle()
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		private void Tick(long currentTimeMs)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157B")]
		private void SetDefaultValues()
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		private void Unregister()
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		private void Register()
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157E")]
		internal void SetOwner(VisualElement e)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		private void CheckNotRecycled()
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001580")]
		public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator)
		{
			return null;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001581")]
		public ValueAnimation<T> KeepAlive()
		{
			return null;
		}

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x0")]
		private long m_StartTimeMs;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x0")]
		private int m_DurationMs;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<ValueAnimation<T>> sObjectPool;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x0")]
		private T _from;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x0")]
		private bool fromValueSet;
	}
}
