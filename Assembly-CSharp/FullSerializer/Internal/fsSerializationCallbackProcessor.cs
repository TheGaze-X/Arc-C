using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B91 RID: 31633
	[Token(Token = "0x2007B91")]
	public class fsSerializationCallbackProcessor : fsObjectProcessor
	{
		// Token: 0x0602C489 RID: 181385 RVA: 0x000DF488 File Offset: 0x000DD688
		[Token(Token = "0x602C489")]
		[Address(RVA = "0x28362B0", Offset = "0x2834EB0", VA = "0x1828362B0", Slot = "4")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C48A RID: 181386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C48A")]
		[Address(RVA = "0x2836680", Offset = "0x2835280", VA = "0x182836680", Slot = "5")]
		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C48B RID: 181387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C48B")]
		[Address(RVA = "0x28363F0", Offset = "0x2834FF0", VA = "0x1828363F0", Slot = "6")]
		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C48C RID: 181388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C48C")]
		[Address(RVA = "0x28364B0", Offset = "0x28350B0", VA = "0x1828364B0", Slot = "8")]
		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C48D RID: 181389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C48D")]
		[Address(RVA = "0x2836350", Offset = "0x2834F50", VA = "0x182836350", Slot = "9")]
		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C48E RID: 181390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C48E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsSerializationCallbackProcessor()
		{
		}
	}
}
