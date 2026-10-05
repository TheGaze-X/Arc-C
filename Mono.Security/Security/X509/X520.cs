using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class X520
	{
		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public abstract class AttributeTypeAndValue
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x4A767F0", Offset = "0x4A753F0", VA = "0x184A767F0")]
			protected AttributeTypeAndValue(string oid, int upperBound)
			{
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x4A76840", Offset = "0x4A75440", VA = "0x184A76840")]
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			{
			}

			// Token: 0x1700004C RID: 76
			// (set) Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700004C")]
			public string Value
			{
				[Token(Token = "0x60000EA")]
				[Address(RVA = "0x4A768A0", Offset = "0x4A754A0", VA = "0x184A768A0")]
				set
				{
				}
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4A76470", Offset = "0x4A75070", VA = "0x184A76470")]
			internal ASN1 GetASN1(byte encoding)
			{
				return null;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x4A76460", Offset = "0x4A75060", VA = "0x184A76460")]
			internal ASN1 GetASN1()
			{
				return null;
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002520 File Offset: 0x00000720
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4A76780", Offset = "0x4A75380", VA = "0x184A76780")]
			private byte SelectBestEncoding()
			{
				return 0;
			}

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x10")]
			private string oid;

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x18")]
			private string attrValue;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0x20")]
			private int upperBound;

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x24")]
			private byte encoding;
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		public class CommonName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4A7A0D0", Offset = "0x4A78CD0", VA = "0x184A7A0D0")]
			public CommonName()
			{
			}
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public class SerialNumber : X520.AttributeTypeAndValue
		{
			// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x4A84120", Offset = "0x4A82D20", VA = "0x184A84120")]
			public SerialNumber()
			{
			}
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public class LocalityName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x4A7B780", Offset = "0x4A7A380", VA = "0x184A7B780")]
			public LocalityName()
			{
			}
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4A85320", Offset = "0x4A83F20", VA = "0x184A85320")]
			public StateOrProvinceName()
			{
			}
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public class OrganizationName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4A7B820", Offset = "0x4A7A420", VA = "0x184A7B820")]
			public OrganizationName()
			{
			}
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4A7B880", Offset = "0x4A7A480", VA = "0x184A7B880")]
			public OrganizationalUnitName()
			{
			}
		}

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public class EmailAddress : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4A7B150", Offset = "0x4A79D50", VA = "0x184A7B150")]
			public EmailAddress()
			{
			}
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public class DomainComponent : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x4A7B0F0", Offset = "0x4A79CF0", VA = "0x184A7B0F0")]
			public DomainComponent()
			{
			}
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public class UserId : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4A85440", Offset = "0x4A84040", VA = "0x184A85440")]
			public UserId()
			{
			}
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public class Oid : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4A7B7E0", Offset = "0x4A7A3E0", VA = "0x184A7B7E0")]
			public Oid(string oid)
			{
			}
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public class Title : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x4A853E0", Offset = "0x4A83FE0", VA = "0x184A853E0")]
			public Title()
			{
			}
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public class CountryName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x4A7A690", Offset = "0x4A79290", VA = "0x184A7A690")]
			public CountryName()
			{
			}
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public class DnQualifier : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x4A7B090", Offset = "0x4A79C90", VA = "0x184A7B090")]
			public DnQualifier()
			{
			}
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		public class Surname : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x4A85380", Offset = "0x4A83F80", VA = "0x184A85380")]
			public Surname()
			{
			}
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public class GivenName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x4A7B6C0", Offset = "0x4A7A2C0", VA = "0x184A7B6C0")]
			public GivenName()
			{
			}
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public class Initial : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x4A7B720", Offset = "0x4A7A320", VA = "0x184A7B720")]
			public Initial()
			{
			}
		}
	}
}
