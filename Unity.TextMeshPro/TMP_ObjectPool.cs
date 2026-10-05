using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal class TMP_ObjectPool<T> where T : new()
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000034B0 File Offset: 0x000016B0
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public int countAll
		{
			[Token(Token = "0x60003B7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000BB")]
		public int countActive
		{
			[Token(Token = "0x60003B9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x170000BC")]
		public int countInactive
		{
			[Token(Token = "0x60003BA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BB")]
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BC")]
		public T Get()
		{
			return null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		public void Release(T element)
		{
		}

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> m_Stack;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnGet;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnRelease;
	}
}
