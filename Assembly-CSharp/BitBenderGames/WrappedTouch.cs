using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	public class WrappedTouch
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C6")]
		public Vector3 Position
		{
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x1698C60", Offset = "0x1697860", VA = "0x181698C60")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004B7F")]
			[Address(RVA = "0x1698C80", Offset = "0x1697880", VA = "0x181698C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x0002CF10 File Offset: 0x0002B110
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C7")]
		public int FingerId
		{
			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004B81")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B82")]
		[Address(RVA = "0x1698C40", Offset = "0x1697840", VA = "0x181698C40")]
		public WrappedTouch()
		{
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B83")]
		[Address(RVA = "0x1698B90", Offset = "0x1697790", VA = "0x181698B90")]
		public static WrappedTouch FromTouch(Touch touch)
		{
			return null;
		}
	}
}
