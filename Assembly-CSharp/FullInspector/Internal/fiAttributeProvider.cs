using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C7A RID: 31866
	[Token(Token = "0x2007C7A")]
	public class fiAttributeProvider : MemberInfo
	{
		// Token: 0x0602C852 RID: 182354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C852")]
		[Address(RVA = "0x2866800", Offset = "0x2865400", VA = "0x182866800")]
		public static MemberInfo Create(params object[] attributes)
		{
			return null;
		}

		// Token: 0x0602C853 RID: 182355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C853")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		private fiAttributeProvider(object[] attributes)
		{
		}

		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x0602C854 RID: 182356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006836")]
		public override Type DeclaringType
		{
			[Token(Token = "0x602C854")]
			[Address(RVA = "0x2866A70", Offset = "0x2865670", VA = "0x182866A70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x0602C855 RID: 182357 RVA: 0x000E0820 File Offset: 0x000DEA20
		[Token(Token = "0x17006837")]
		public override MemberTypes MemberType
		{
			[Token(Token = "0x602C855")]
			[Address(RVA = "0x2866AC0", Offset = "0x28656C0", VA = "0x182866AC0", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x0602C856 RID: 182358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006838")]
		public override string Name
		{
			[Token(Token = "0x602C856")]
			[Address(RVA = "0x2866B10", Offset = "0x2865710", VA = "0x182866B10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x0602C857 RID: 182359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006839")]
		public override Type ReflectedType
		{
			[Token(Token = "0x602C857")]
			[Address(RVA = "0x2866B60", Offset = "0x2865760", VA = "0x182866B60", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C858 RID: 182360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C858")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x0602C859 RID: 182361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C859")]
		[Address(RVA = "0x2866870", Offset = "0x2865470", VA = "0x182866870", Slot = "14")]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x0602C85A RID: 182362 RVA: 0x000E0838 File Offset: 0x000DEA38
		[Token(Token = "0x602C85A")]
		[Address(RVA = "0x2866970", Offset = "0x2865570", VA = "0x182866970", Slot = "12")]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x0404035F RID: 263007
		[Token(Token = "0x404035F")]
		[FieldOffset(Offset = "0x10")]
		private readonly object[] _attributes;
	}
}
