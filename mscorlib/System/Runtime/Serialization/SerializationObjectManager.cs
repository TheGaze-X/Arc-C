using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	public sealed class SerializationObjectManager
	{
		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x4BAF210", Offset = "0x4BADE10", VA = "0x184BAF210")]
		public SerializationObjectManager(StreamingContext context)
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x4BAF060", Offset = "0x4BADC60", VA = "0x184BAF060")]
		public void RegisterObject(object obj)
		{
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x4BAF030", Offset = "0x4BADC30", VA = "0x184BAF030")]
		public void RaiseOnSerializedEvent()
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x4BAEF90", Offset = "0x4BADB90", VA = "0x184BAEF90")]
		private void AddOnSerialized(object obj)
		{
		}

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Collections.Generic.Dictionary<object, object> _objectSeenTable;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x18")]
		private readonly StreamingContext _context;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x28")]
		private SerializationEventHandler _onSerializedHandler;
	}
}
