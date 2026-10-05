using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x200050D")]
	[System.Serializable]
	[StructLayout(0)]
	public class ParameterInfo : ICustomAttributeProvider, System.Runtime.Serialization.IObjectReference, System.Runtime.InteropServices._ParameterInfo
	{
		// Token: 0x060024D3 RID: 9427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ParameterInfo()
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00014AC0 File Offset: 0x00012CC0
		[Token(Token = "0x170004D9")]
		public virtual ParameterAttributes Attributes
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "8")]
			get
			{
				return ParameterAttributes.None;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004DA")]
		public virtual MemberInfo Member
		{
			[Token(Token = "0x60024D5")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004DB")]
		public virtual string Name
		{
			[Token(Token = "0x60024D6")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004DC")]
		public virtual System.Type ParameterType
		{
			[Token(Token = "0x60024D7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[Token(Token = "0x170004DD")]
		public virtual int Position
		{
			[Token(Token = "0x60024D8")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x00014AF0 File Offset: 0x00012CF0
		[Token(Token = "0x170004DE")]
		public bool IsIn
		{
			[Token(Token = "0x60024D9")]
			[Address(RVA = "0x4BDBB80", Offset = "0x4BDA780", VA = "0x184BDBB80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x170004DF")]
		public bool IsOptional
		{
			[Token(Token = "0x60024DA")]
			[Address(RVA = "0x4BDBBC0", Offset = "0x4BDA7C0", VA = "0x184BDBBC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x170004E0")]
		public bool IsOut
		{
			[Token(Token = "0x60024DB")]
			[Address(RVA = "0x4BDBC00", Offset = "0x4BDA800", VA = "0x184BDBC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004E1")]
		public virtual object DefaultValue
		{
			[Token(Token = "0x60024DC")]
			[Address(RVA = "0x4BDBB50", Offset = "0x4BDA750", VA = "0x184BDBB50", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x4BDB9F0", Offset = "0x4BDA5F0", VA = "0x184BDB9F0", Slot = "14")]
		public virtual bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x4BDB500", Offset = "0x4BDA100", VA = "0x184BDB500", Slot = "15")]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x4BDB530", Offset = "0x4BDA130", VA = "0x184BDB530", Slot = "16")]
		public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x4BDB5F0", Offset = "0x4BDA1F0", VA = "0x184BDB5F0", Slot = "7")]
		public object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return null;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x4BDBAA0", Offset = "0x4BDA6A0", VA = "0x184BDBAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected ParameterAttributes AttrsImpl;

		// Token: 0x0400152A RID: 5418
		[Token(Token = "0x400152A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected System.Type ClassImpl;

		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected object DefaultValueImpl;

		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected MemberInfo MemberImpl;

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string NameImpl;

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected int PositionImpl;

		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		private const int MetadataToken_ParamDef = 134217728;
	}
}
