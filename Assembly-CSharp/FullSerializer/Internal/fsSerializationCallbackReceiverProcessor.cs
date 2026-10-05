using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B92 RID: 31634
	[Token(Token = "0x2007B92")]
	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor
	{
		// Token: 0x0602C48F RID: 181391 RVA: 0x000DF4A0 File Offset: 0x000DD6A0
		[Token(Token = "0x602C48F")]
		[Address(RVA = "0x2836720", Offset = "0x2835320", VA = "0x182836720", Slot = "4")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C490 RID: 181392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C490")]
		[Address(RVA = "0x2836860", Offset = "0x2835460", VA = "0x182836860", Slot = "5")]
		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C491 RID: 181393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C491")]
		[Address(RVA = "0x28367C0", Offset = "0x28353C0", VA = "0x1828367C0", Slot = "9")]
		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C492 RID: 181394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C492")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsSerializationCallbackReceiverProcessor()
		{
		}
	}
}
