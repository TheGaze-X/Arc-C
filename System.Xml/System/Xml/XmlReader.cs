using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlReader : IDisposable
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public virtual XmlReaderSettings Settings
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FE RID: 510
		[Token(Token = "0x1700004F")]
		public abstract XmlNodeType NodeType { [Token(Token = "0x60001FE")] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public virtual string Name
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x4F84540", Offset = "0x4F83140", VA = "0x184F84540", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000200 RID: 512
		[Token(Token = "0x17000051")]
		public abstract string LocalName { [Token(Token = "0x6000200")] get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000201 RID: 513
		[Token(Token = "0x17000052")]
		public abstract string NamespaceURI { [Token(Token = "0x6000201")] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000202 RID: 514
		[Token(Token = "0x17000053")]
		public abstract string Prefix { [Token(Token = "0x6000202")] get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000203 RID: 515
		[Token(Token = "0x17000054")]
		public abstract string Value { [Token(Token = "0x6000203")] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000204 RID: 516
		[Token(Token = "0x17000055")]
		public abstract string BaseURI { [Token(Token = "0x6000204")] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000205 RID: 517
		[Token(Token = "0x17000056")]
		public abstract bool IsEmptyElement { [Token(Token = "0x6000205")] get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000057")]
		public virtual bool IsDefault
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public virtual IXmlSchemaInfo SchemaInfo
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4F846C0", Offset = "0x4F832C0", VA = "0x184F846C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000208 RID: 520
		[Token(Token = "0x6000208")]
		public abstract bool MoveToAttribute(string name);

		// Token: 0x06000209 RID: 521
		[Token(Token = "0x6000209")]
		public abstract bool MoveToFirstAttribute();

		// Token: 0x0600020A RID: 522
		[Token(Token = "0x600020A")]
		public abstract bool MoveToNextAttribute();

		// Token: 0x0600020B RID: 523
		[Token(Token = "0x600020B")]
		public abstract bool MoveToElement();

		// Token: 0x0600020C RID: 524
		[Token(Token = "0x600020C")]
		public abstract bool ReadAttributeValue();

		// Token: 0x0600020D RID: 525
		[Token(Token = "0x600020D")]
		public abstract bool Read();

		// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public virtual void Close()
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020F RID: 527
		[Token(Token = "0x17000059")]
		public abstract ReadState ReadState { [Token(Token = "0x600020F")] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000210 RID: 528
		[Token(Token = "0x1700005A")]
		public abstract XmlNameTable NameTable { [Token(Token = "0x6000210")] get; }

		// Token: 0x06000211 RID: 529
		[Token(Token = "0x6000211")]
		public abstract string LookupNamespace(string prefix);

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x1700005B")]
		public virtual bool CanResolveEntity
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000213 RID: 531
		[Token(Token = "0x6000213")]
		public abstract void ResolveEntity();

		// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4F84420", Offset = "0x4F83020", VA = "0x184F84420", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4F84460", Offset = "0x4F83060", VA = "0x184F84460", Slot = "28")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		internal virtual IDtdInfo DtdInfo
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4F84360", Offset = "0x4F82F60", VA = "0x184F84360")]
		internal static int CalcBufferSize(Stream input)
		{
			return 0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlReader()
		{
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		private static uint IsTextualNodeBitmap;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x4")]
		private static uint CanReadContentAsBitmap;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x8")]
		private static uint HasValueBitmap;
	}
}
