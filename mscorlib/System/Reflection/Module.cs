using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	[System.Serializable]
	[StructLayout(0)]
	public abstract class Module : ICustomAttributeProvider, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Module
	{
		// Token: 0x060024C1 RID: 9409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Module()
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004D5")]
		public virtual Assembly Assembly
		{
			[Token(Token = "0x60024C2")]
			[Address(RVA = "0x4BDB160", Offset = "0x4BD9D60", VA = "0x184BDB160", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004D6")]
		public virtual string FullyQualifiedName
		{
			[Token(Token = "0x60024C3")]
			[Address(RVA = "0x4BDB190", Offset = "0x4BD9D90", VA = "0x184BDB190", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x170004D7")]
		public virtual System.Guid ModuleVersionId
		{
			[Token(Token = "0x60024C4")]
			[Address(RVA = "0x4BDB1C0", Offset = "0x4BD9DC0", VA = "0x184BDB1C0", Slot = "10")]
			get
			{
				return default(System.Guid);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004D8")]
		public virtual string ScopeName
		{
			[Token(Token = "0x60024C5")]
			[Address(RVA = "0x4BDB1F0", Offset = "0x4BD9DF0", VA = "0x184BDB1F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x4BDB030", Offset = "0x4BD9C30", VA = "0x184BDB030", Slot = "12")]
		public virtual bool IsResource()
		{
			return default(bool);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x4BDB000", Offset = "0x4BD9C00", VA = "0x184BDB000", Slot = "13")]
		public virtual bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x4BDAF50", Offset = "0x4BD9B50", VA = "0x184BDAF50", Slot = "14")]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x4BDAF20", Offset = "0x4BD9B20", VA = "0x184BDAF20", Slot = "15")]
		public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x4BDAFD0", Offset = "0x4BD9BD0", VA = "0x184BDAFD0", Slot = "16")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool operator ==(Module left, Module right)
		{
			return default(bool);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x78A370", Offset = "0x788F70", VA = "0x18078A370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x4BDAD90", Offset = "0x4BD9990", VA = "0x184BDAD90")]
		private static bool FilterTypeNameImpl(System.Type cls, object filterCriteria)
		{
			return default(bool);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x4BDABC0", Offset = "0x4BD97C0", VA = "0x184BDABC0")]
		private static bool FilterTypeNameIgnoreCaseImpl(System.Type cls, object filterCriteria)
		{
			return default(bool);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x4BDAF80", Offset = "0x4BD9B80", VA = "0x184BDAF80", Slot = "17")]
		internal virtual System.Guid GetModuleVersionId()
		{
			return default(System.Guid);
		}

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypeFilter FilterTypeName;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly TypeFilter FilterTypeNameIgnoreCase;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
	}
}
