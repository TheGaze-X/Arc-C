using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	internal class ResponseDescription
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x170003BF")]
		internal bool PositiveIntermediate
		{
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x51B4C60", Offset = "0x51B3860", VA = "0x1851B4C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x170003C0")]
		internal bool PositiveCompletion
		{
			[Token(Token = "0x6001273")]
			[Address(RVA = "0x51B4C40", Offset = "0x51B3840", VA = "0x1851B4C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x170003C1")]
		internal bool TransientFailure
		{
			[Token(Token = "0x6001274")]
			[Address(RVA = "0x51B4C80", Offset = "0x51B3880", VA = "0x1851B4C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x170003C2")]
		internal bool PermanentFailure
		{
			[Token(Token = "0x6001275")]
			[Address(RVA = "0x51B4C20", Offset = "0x51B3820", VA = "0x1851B4C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x170003C3")]
		internal bool InvalidStatusCode
		{
			[Token(Token = "0x6001276")]
			[Address(RVA = "0x51B4C00", Offset = "0x51B3800", VA = "0x1851B4C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x51B4B80", Offset = "0x51B3780", VA = "0x1851B4B80")]
		public ResponseDescription()
		{
		}

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x10")]
		internal bool Multiline;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x14")]
		internal int Status;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x18")]
		internal string StatusDescription;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x20")]
		internal StringBuilder StatusBuffer;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x28")]
		internal string StatusCodeString;
	}
}
