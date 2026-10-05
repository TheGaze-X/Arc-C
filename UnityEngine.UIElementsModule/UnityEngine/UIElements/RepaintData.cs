using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	internal class RepaintData
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000045")]
		public Matrix4x4 currentOffset
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1ECB250", Offset = "0x1EC9E50", VA = "0x181ECB250")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x17000046")]
		public Rect currentWorldClip
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x56E8DA0", Offset = "0x56E79A0", VA = "0x1856E8DA0")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public Event repaintEvent
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5A3B150", Offset = "0x5A39D50", VA = "0x185A3B150")]
		public RepaintData()
		{
		}
	}
}
