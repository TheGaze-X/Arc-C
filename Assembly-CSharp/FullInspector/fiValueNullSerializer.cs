using System;
using FullInspector.Internal;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BFB RID: 31739
	[Token(Token = "0x2007BFB")]
	public abstract class fiValueNullSerializer<T> : fiValueProxyEditor, fiIValueProxyAPI
	{
		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x0602C685 RID: 181893 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C686 RID: 181894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006808")]
		private object Value
		{
			[Token(Token = "0x602C685")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C686")]
			set
			{
			}
		}

		// Token: 0x0602C687 RID: 181895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C687")]
		private void SaveState()
		{
		}

		// Token: 0x0602C688 RID: 181896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C688")]
		private void LoadState()
		{
		}

		// Token: 0x0602C689 RID: 181897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C689")]
		protected fiValueNullSerializer()
		{
		}

		// Token: 0x0404029D RID: 262813
		[Token(Token = "0x404029D")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
