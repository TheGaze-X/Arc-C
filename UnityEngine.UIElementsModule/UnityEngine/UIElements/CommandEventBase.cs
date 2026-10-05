using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent where T : CommandEventBase<T>, new()
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		public string commandName
		{
			[Token(Token = "0x6000AEB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEC")]
			protected set
			{
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AED")]
		protected override void Init()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEE")]
		private void LocalInit()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AEF")]
		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AF0")]
		public static T GetPooled(string commandName)
		{
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF1")]
		protected CommandEventBase()
		{
		}

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x0")]
		private string m_CommandName;
	}
}
