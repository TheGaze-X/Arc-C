using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B88 RID: 31624
	[Token(Token = "0x2007B88")]
	public class fsForwardConverter : fsConverter
	{
		// Token: 0x0602C449 RID: 181321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C449")]
		[Address(RVA = "0x2829280", Offset = "0x2827E80", VA = "0x182829280")]
		public fsForwardConverter(fsForwardAttribute attribute)
		{
		}

		// Token: 0x0602C44A RID: 181322 RVA: 0x000DF050 File Offset: 0x000DD250
		[Token(Token = "0x602C44A")]
		[Address(RVA = "0x28289F0", Offset = "0x28275F0", VA = "0x1828289F0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C44B RID: 181323 RVA: 0x000DF068 File Offset: 0x000DD268
		[Token(Token = "0x602C44B")]
		[Address(RVA = "0x2828AD0", Offset = "0x28276D0", VA = "0x182828AD0")]
		private fsResult GetProperty(object instance, out fsMetaProperty property)
		{
			return default(fsResult);
		}

		// Token: 0x0602C44C RID: 181324 RVA: 0x000DF080 File Offset: 0x000DD280
		[Token(Token = "0x602C44C")]
		[Address(RVA = "0x2829000", Offset = "0x2827C00", VA = "0x182829000", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C44D RID: 181325 RVA: 0x000DF098 File Offset: 0x000DD298
		[Token(Token = "0x602C44D")]
		[Address(RVA = "0x2828CD0", Offset = "0x28278D0", VA = "0x182828CD0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C44E RID: 181326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C44E")]
		[Address(RVA = "0x2828A50", Offset = "0x2827650", VA = "0x182828A50", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x040401D7 RID: 262615
		[Token(Token = "0x40401D7")]
		[FieldOffset(Offset = "0x18")]
		private string _memberName;
	}
}
