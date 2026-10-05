using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public struct TimerState : IEquatable<TimerState>
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public long start
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002C58 File Offset: 0x00000E58
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public long now
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000085")]
		public long deltaTime
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x5A3B930", Offset = "0x5A3A530", VA = "0x185A3B930")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x5A3B800", Offset = "0x5A3A400", VA = "0x185A3B800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x5A3B7D0", Offset = "0x5A3A3D0", VA = "0x185A3B7D0", Slot = "4")]
		public bool Equals(TimerState other)
		{
			return default(bool);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x5A3B8B0", Offset = "0x5A3A4B0", VA = "0x185A3B8B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
