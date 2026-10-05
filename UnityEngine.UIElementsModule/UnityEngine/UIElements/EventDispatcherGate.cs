using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5A2D740", Offset = "0x5A2C340", VA = "0x185A2D740")]
		public EventDispatcherGate(EventDispatcher d)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5A2D5C0", Offset = "0x5A2C1C0", VA = "0x185A2D5C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5A2D650", Offset = "0x5A2C250", VA = "0x185A2D650", Slot = "5")]
		public bool Equals(EventDispatcherGate other)
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5A2D660", Offset = "0x5A2C260", VA = "0x185A2D660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5A2D6F0", Offset = "0x5A2C2F0", VA = "0x185A2D6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private readonly EventDispatcher m_Dispatcher;
	}
}
