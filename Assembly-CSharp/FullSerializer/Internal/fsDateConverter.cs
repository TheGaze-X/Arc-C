using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B85 RID: 31621
	[Token(Token = "0x2007B85")]
	public class fsDateConverter : fsConverter
	{
		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x0602C435 RID: 181301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067AB")]
		private string DateTimeFormatString
		{
			[Token(Token = "0x602C435")]
			[Address(RVA = "0x2825830", Offset = "0x2824430", VA = "0x182825830")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C436 RID: 181302 RVA: 0x000DEF18 File Offset: 0x000DD118
		[Token(Token = "0x602C436")]
		[Address(RVA = "0x2824D80", Offset = "0x2823980", VA = "0x182824D80", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C437 RID: 181303 RVA: 0x000DEF30 File Offset: 0x000DD130
		[Token(Token = "0x602C437")]
		[Address(RVA = "0x2825560", Offset = "0x2824160", VA = "0x182825560", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C438 RID: 181304 RVA: 0x000DEF48 File Offset: 0x000DD148
		[Token(Token = "0x602C438")]
		[Address(RVA = "0x2824E90", Offset = "0x2823A90", VA = "0x182824E90", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C439 RID: 181305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C439")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsDateConverter()
		{
		}

		// Token: 0x040401D5 RID: 262613
		[Token(Token = "0x40401D5")]
		private const string DefaultDateTimeFormatString = "o";

		// Token: 0x040401D6 RID: 262614
		[Token(Token = "0x40401D6")]
		private const string DateTimeOffsetFormatString = "o";
	}
}
