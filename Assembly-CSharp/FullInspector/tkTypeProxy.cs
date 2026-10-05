using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C4D RID: 31821
	[Token(Token = "0x2007C4D")]
	public class tkTypeProxy<TFrom, TContextFrom, TTo, TContextTo> : tkControl<TTo, TContextTo>
	{
		// Token: 0x0602C7B5 RID: 182197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7B5")]
		public tkTypeProxy(tkControl<TFrom, TContextFrom> control)
		{
		}

		// Token: 0x0602C7B6 RID: 182198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7B6")]
		private static T Cast<T>(object val)
		{
			return null;
		}

		// Token: 0x0602C7B7 RID: 182199 RVA: 0x000E0478 File Offset: 0x000DE678
		[Token(Token = "0x602C7B7")]
		public override bool ShouldShow(TTo obj, TContextTo context, fiGraphMetadata metadata)
		{
			return default(bool);
		}

		// Token: 0x0602C7B8 RID: 182200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7B8")]
		protected override TTo DoEdit(Rect rect, TTo obj, TContextTo context, fiGraphMetadata metadata)
		{
			return null;
		}

		// Token: 0x0602C7B9 RID: 182201 RVA: 0x000E0490 File Offset: 0x000DE690
		[Token(Token = "0x602C7B9")]
		protected override float DoGetHeight(TTo obj, TContextTo context, fiGraphMetadata metadata)
		{
			return 0f;
		}

		// Token: 0x0404031E RID: 262942
		[Token(Token = "0x404031E")]
		[FieldOffset(Offset = "0x0")]
		private tkControl<TFrom, TContextFrom> _control;
	}
}
