using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public abstract class XObject
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal XObject()
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B4 RID: 180
		[Token(Token = "0x17000023")]
		public abstract XmlNodeType NodeType { [Token(Token = "0x60000B4")] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public XElement Parent
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4F8D760", Offset = "0x4F8C360", VA = "0x184F8D760")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4F8D270", Offset = "0x4F8BE70", VA = "0x184F8D270")]
		private object AnnotationForSealedType(Type type)
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4F8D590", Offset = "0x4F8C190", VA = "0x184F8D590")]
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4F8D640", Offset = "0x4F8C240", VA = "0x184F8D640")]
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4F8D6F0", Offset = "0x4F8C2F0", VA = "0x184F8D6F0")]
		internal bool SkipNotify()
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4F8D3B0", Offset = "0x4F8BFB0", VA = "0x184F8D3B0")]
		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			return SaveOptions.None;
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x10")]
		internal XContainer parent;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x18")]
		internal object annotations;
	}
}
