using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C77 RID: 31863
	[Token(Token = "0x2007C77")]
	public abstract class fiBaseAnimValue<T>
	{
		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x0602C83D RID: 182333 RVA: 0x000E0790 File Offset: 0x000DE990
		[Token(Token = "0x17006830")]
		public bool isAnimating
		{
			[Token(Token = "0x602C83D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x0602C83E RID: 182334 RVA: 0x000E07A8 File Offset: 0x000DE9A8
		[Token(Token = "0x17006831")]
		protected float lerpPosition
		{
			[Token(Token = "0x602C83E")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x0602C83F RID: 182335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006832")]
		protected T start
		{
			[Token(Token = "0x602C83F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x0602C840 RID: 182336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C841 RID: 182337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006833")]
		public T target
		{
			[Token(Token = "0x602C840")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C841")]
			set
			{
			}
		}

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x0602C842 RID: 182338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C843 RID: 182339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006834")]
		public T value
		{
			[Token(Token = "0x602C842")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C843")]
			set
			{
			}
		}

		// Token: 0x0602C844 RID: 182340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C844")]
		protected fiBaseAnimValue(T value)
		{
		}

		// Token: 0x0602C845 RID: 182341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C845")]
		private static T2 Clamp<T2>(T2 val, T2 min, T2 max) where T2 : IComparable<T2>
		{
			return null;
		}

		// Token: 0x0602C846 RID: 182342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C846")]
		protected void BeginAnimating(T newTarget, T newStart)
		{
		}

		// Token: 0x0602C847 RID: 182343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C847")]
		private void Update()
		{
		}

		// Token: 0x0602C848 RID: 182344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C848")]
		private void UpdateLerpPosition()
		{
		}

		// Token: 0x0602C849 RID: 182345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C849")]
		protected void StopAnim(T newValue)
		{
		}

		// Token: 0x0602C84A RID: 182346
		[Token(Token = "0x602C84A")]
		protected abstract T GetValue();

		// Token: 0x04040357 RID: 262999
		[Token(Token = "0x4040357")]
		[FieldOffset(Offset = "0x0")]
		private double m_LerpPosition;

		// Token: 0x04040358 RID: 263000
		[Token(Token = "0x4040358")]
		[FieldOffset(Offset = "0x0")]
		public float speed;

		// Token: 0x04040359 RID: 263001
		[Token(Token = "0x4040359")]
		[FieldOffset(Offset = "0x0")]
		private T m_Start;

		// Token: 0x0404035A RID: 263002
		[Token(Token = "0x404035A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T m_Target;

		// Token: 0x0404035B RID: 263003
		[Token(Token = "0x404035B")]
		[FieldOffset(Offset = "0x0")]
		private double m_LastTime;

		// Token: 0x0404035C RID: 263004
		[Token(Token = "0x404035C")]
		[FieldOffset(Offset = "0x0")]
		private bool m_Animating;
	}
}
