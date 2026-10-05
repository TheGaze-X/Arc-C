using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B69 RID: 31593
	[Token(Token = "0x2007B69")]
	public class fsConfig
	{
		// Token: 0x0602C375 RID: 181109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C375")]
		[Address(RVA = "0x2822B80", Offset = "0x2821780", VA = "0x182822B80")]
		public fsConfig()
		{
		}

		// Token: 0x0404018F RID: 262543
		[Token(Token = "0x404018F")]
		[FieldOffset(Offset = "0x10")]
		public Type[] SerializeAttributes;

		// Token: 0x04040190 RID: 262544
		[Token(Token = "0x4040190")]
		[FieldOffset(Offset = "0x18")]
		public Type[] IgnoreSerializeAttributes;

		// Token: 0x04040191 RID: 262545
		[Token(Token = "0x4040191")]
		[FieldOffset(Offset = "0x20")]
		public fsMemberSerialization DefaultMemberSerialization;

		// Token: 0x04040192 RID: 262546
		[Token(Token = "0x4040192")]
		[FieldOffset(Offset = "0x28")]
		public Func<string, MemberInfo, string> GetJsonNameFromMemberName;

		// Token: 0x04040193 RID: 262547
		[Token(Token = "0x4040193")]
		[FieldOffset(Offset = "0x30")]
		public bool SerializeNonAutoProperties;

		// Token: 0x04040194 RID: 262548
		[Token(Token = "0x4040194")]
		[FieldOffset(Offset = "0x31")]
		public bool SerializeNonPublicSetProperties;

		// Token: 0x04040195 RID: 262549
		[Token(Token = "0x4040195")]
		[FieldOffset(Offset = "0x38")]
		public string CustomDateTimeFormatString;

		// Token: 0x04040196 RID: 262550
		[Token(Token = "0x4040196")]
		[FieldOffset(Offset = "0x40")]
		public bool Serialize64BitIntegerAsString;

		// Token: 0x04040197 RID: 262551
		[Token(Token = "0x4040197")]
		[FieldOffset(Offset = "0x41")]
		public bool SerializeEnumsAsInteger;
	}
}
