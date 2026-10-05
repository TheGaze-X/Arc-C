using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public abstract class EventDescriptor : MemberDescriptor
	{
		// Token: 0x06000A7A RID: 2682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x5145BC0", Offset = "0x51447C0", VA = "0x185145BC0")]
		protected EventDescriptor(string name, Attribute[] attrs)
		{
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x5145BE0", Offset = "0x51447E0", VA = "0x185145BE0")]
		protected EventDescriptor(MemberDescriptor descr)
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x5145BD0", Offset = "0x51447D0", VA = "0x185145BD0")]
		protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A7D RID: 2685
		[Token(Token = "0x17000212")]
		public abstract Type ComponentType { [Token(Token = "0x6000A7D")] get; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000A7E RID: 2686
		[Token(Token = "0x17000213")]
		public abstract Type EventType { [Token(Token = "0x6000A7E")] get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000A7F RID: 2687
		[Token(Token = "0x17000214")]
		public abstract bool IsMulticast { [Token(Token = "0x6000A7F")] get; }

		// Token: 0x06000A80 RID: 2688
		[Token(Token = "0x6000A80")]
		public abstract void AddEventHandler(object component, Delegate value);

		// Token: 0x06000A81 RID: 2689
		[Token(Token = "0x6000A81")]
		public abstract void RemoveEventHandler(object component, Delegate value);
	}
}
