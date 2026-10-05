using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SDK;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ACF RID: 19151
	[Token(Token = "0x2004ACF")]
	public class GameUpdateContext
	{
		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x0601CC17 RID: 117783 RVA: 0x000A96C8 File Offset: 0x000A78C8
		// (set) Token: 0x0601CC18 RID: 117784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043DB")]
		public bool complete
		{
			[Token(Token = "0x601CC17")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601CC18")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x0601CC19 RID: 117785 RVA: 0x000A96E0 File Offset: 0x000A78E0
		// (set) Token: 0x0601CC1A RID: 117786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043DC")]
		public int code
		{
			[Token(Token = "0x601CC19")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601CC1A")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601CC1B RID: 117787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC1B")]
		[Address(RVA = "0x16219D0", Offset = "0x16205D0", VA = "0x1816219D0")]
		public void CompleteWithCode(int pCode)
		{
		}

		// Token: 0x0601CC1C RID: 117788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC1C")]
		[Address(RVA = "0x16219E0", Offset = "0x16205E0", VA = "0x1816219E0")]
		public void UncompleteWithCode(int pCode)
		{
		}

		// Token: 0x0601CC1D RID: 117789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC1D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameUpdateContext()
		{
		}

		// Token: 0x04025BD6 RID: 154582
		[Token(Token = "0x4025BD6")]
		[FieldOffset(Offset = "0x10")]
		public long taskId;

		// Token: 0x04025BD7 RID: 154583
		[Token(Token = "0x4025BD7")]
		[FieldOffset(Offset = "0x18")]
		public string errorInfo;

		// Token: 0x04025BD8 RID: 154584
		[Token(Token = "0x4025BD8")]
		[FieldOffset(Offset = "0x20")]
		public string logError;

		// Token: 0x04025BD9 RID: 154585
		[Token(Token = "0x4025BD9")]
		[FieldOffset(Offset = "0x28")]
		public bool needClear;

		// Token: 0x04025BDA RID: 154586
		[Token(Token = "0x4025BDA")]
		[FieldOffset(Offset = "0x30")]
		public HGLatestGameInfo gameInfo;
	}
}
