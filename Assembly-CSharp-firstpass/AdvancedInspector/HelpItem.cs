using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class HelpItem : IEquatable<HelpItem>
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public HelpType Type
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return HelpType.None;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public string Message
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public HelpPosition Position
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return HelpPosition.After;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4F0450", Offset = "0x4EF050", VA = "0x1804F0450")]
		public HelpItem(HelpType type, string message)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4F04A0", Offset = "0x4EF0A0", VA = "0x1804F04A0")]
		public HelpItem(HelpType type, string message, HelpPosition position)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4F0410", Offset = "0x4EF010", VA = "0x1804F0410", Slot = "4")]
		public bool Equals(HelpItem help)
		{
			return default(bool);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4F0350", Offset = "0x4EEF50", VA = "0x1804F0350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x10")]
		private HelpType type;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x18")]
		private string message;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private HelpPosition position;
	}
}
