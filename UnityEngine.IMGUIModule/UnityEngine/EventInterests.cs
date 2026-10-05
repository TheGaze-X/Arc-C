using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	internal struct EventInterests
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public bool wantsMouseMove
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public bool wantsMouseEnterLeaveWindow
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x217A7B0", Offset = "0x21793B0", VA = "0x18217A7B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x3188710", Offset = "0x3187310", VA = "0x183188710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000018")]
		public readonly bool wantsLessLayoutEvents
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5989D00", Offset = "0x5988900", VA = "0x185989D00")]
		public bool WantsEvent(EventType type)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5989D20", Offset = "0x5988920", VA = "0x185989D20")]
		public bool WantsLayoutPass(EventType type)
		{
			return default(bool);
		}
	}
}
