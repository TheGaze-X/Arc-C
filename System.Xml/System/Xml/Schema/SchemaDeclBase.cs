using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	internal abstract class SchemaDeclBase
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5008440", Offset = "0x5007040", VA = "0x185008440")]
		protected SchemaDeclBase(XmlQualifiedName name, string prefix)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x50081F0", Offset = "0x5006DF0", VA = "0x1850081F0")]
		protected SchemaDeclBase()
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CB")]
		internal XmlQualifiedName Name
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CC")]
		internal string Prefix
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x5008550", Offset = "0x5007150", VA = "0x185008550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000056D0 File Offset: 0x000038D0
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CD")]
		internal bool IsDeclaredInExternal
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000056E8 File Offset: 0x000038E8
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CE")]
		internal SchemaDeclBase.Use Presence
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return SchemaDeclBase.Use.Default;
			}
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x170002CF RID: 719
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CF")]
		internal XmlSchemaType SchemaType
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D0")]
		internal XmlSchemaDatatype Datatype
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5008390", Offset = "0x5006F90", VA = "0x185008390")]
		internal void AddValue(string value)
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		internal List<string> Values
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D2")]
		internal string DefaultValueRaw
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x5008500", Offset = "0x5007100", VA = "0x185008500")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D3")]
		internal object DefaultValueTyped
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x10")]
		protected XmlQualifiedName name;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x18")]
		protected string prefix;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x20")]
		protected bool isDeclaredInExternal;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x24")]
		protected SchemaDeclBase.Use presence;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x28")]
		protected XmlSchemaType schemaType;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x30")]
		protected XmlSchemaDatatype datatype;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x38")]
		protected string defaultValueRaw;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x40")]
		protected object defaultValueTyped;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x48")]
		protected long maxLength;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x50")]
		protected long minLength;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x58")]
		protected List<string> values;

		// Token: 0x02000130 RID: 304
		[Token(Token = "0x2000130")]
		internal enum Use
		{
			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			Default,
			// Token: 0x04000531 RID: 1329
			[Token(Token = "0x4000531")]
			Required,
			// Token: 0x04000532 RID: 1330
			[Token(Token = "0x4000532")]
			Implied,
			// Token: 0x04000533 RID: 1331
			[Token(Token = "0x4000533")]
			Fixed,
			// Token: 0x04000534 RID: 1332
			[Token(Token = "0x4000534")]
			RequiredFixed
		}
	}
}
