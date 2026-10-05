using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal class ClampedDragger<T> : Clickable where T : IComparable<T>
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action dragging
		{
			[Token(Token = "0x6000030")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000031")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action draggingEnded
		{
			[Token(Token = "0x6000032")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public ClampedDragger<T>.DragDirection dragDirection
		{
			[Token(Token = "0x6000034")]
			[CompilerGenerated]
			get
			{
				return ClampedDragger.DragDirection.None;
			}
			[Token(Token = "0x6000035")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		private BaseSlider<T> slider
		{
			[Token(Token = "0x6000036")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Vector2 startMousePosition
		{
			[Token(Token = "0x6000037")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000038")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x1700000D")]
		public Vector2 delta
		{
			[Token(Token = "0x6000039")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		[Flags]
		public enum DragDirection
		{
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			None = 0,
			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			LowToHigh = 1,
			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			HighToLow = 2,
			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			Free = 4
		}
	}
}
