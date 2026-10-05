using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UDatasdk.Event
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class UDatasdkEvent
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private UDatasdkEvent()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000060")]
		public static UDatasdkEvent Instance
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x55C7DE0", Offset = "0x55C69E0", VA = "0x1855C7DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event ReportEventDelegate ReportEventEvent
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x55C7D40", Offset = "0x55C6940", VA = "0x1855C7D40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x55C7F60", Offset = "0x55C6B60", VA = "0x1855C7F60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event InitDelegate InitEvent
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x55C7CA0", Offset = "0x55C68A0", VA = "0x1855C7CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x55C7EC0", Offset = "0x55C6AC0", VA = "0x1855C7EC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x55C7B80", Offset = "0x55C6780", VA = "0x1855C7B80")]
		public void HandleInitNotify(InitRet ret)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x55C7C10", Offset = "0x55C6810", VA = "0x1855C7C10")]
		public void HandleReportEventNotify(ReportEventRet ret)
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x0")]
		private static UDatasdkEvent instance;
	}
}
