using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	internal class TypeSpec
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0000D920 File Offset: 0x0000BB20
		[Token(Token = "0x17000183")]
		internal bool HasModifiers
		{
			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x4D5CD30", Offset = "0x4D5B930", VA = "0x184D5CD30")]
		private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			return null;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x4D5D1A0", Offset = "0x4D5BDA0", VA = "0x184D5D1A0")]
		private System.Text.StringBuilder GetModifierString(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000184")]
		internal string DisplayFullName
		{
			[Token(Token = "0x60010C6")]
			[Address(RVA = "0x4D5EFF0", Offset = "0x4D5DBF0", VA = "0x184D5EFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x4D5E370", Offset = "0x4D5CF70", VA = "0x184D5E370")]
		internal static TypeSpec Parse(string typeName)
		{
			return null;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x4D5EF10", Offset = "0x4D5DB10", VA = "0x184D5EF10")]
		internal static string UnescapeInternalName(string displayName)
		{
			return null;
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x4D5E470", Offset = "0x4D5D070", VA = "0x184D5E470")]
		internal System.Type Resolve(System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> assemblyResolver, System.Func<System.Reflection.Assembly, string, bool, System.Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x4D5CBA0", Offset = "0x4D5B7A0", VA = "0x184D5CBA0")]
		private void AddName(string type_name)
		{
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x4D5CAF0", Offset = "0x4D5B6F0", VA = "0x184D5CAF0")]
		private void AddModifier(ModifierSpec md)
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x4D5EE70", Offset = "0x4D5DA70", VA = "0x184D5EE70")]
		private static void SkipSpace(string name, ref int pos)
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x4D5CC90", Offset = "0x4D5B890", VA = "0x184D5CC90")]
		private static void BoundCheck(int idx, string s)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x4D5CA70", Offset = "0x4D5B670", VA = "0x184D5CA70")]
		private static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			return null;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x4D5D3C0", Offset = "0x4D5BFC0", VA = "0x184D5D3C0")]
		private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			return null;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TypeSpec()
		{
		}

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x10")]
		private TypeIdentifier name;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x18")]
		private string assembly_name;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x20")]
		private System.Collections.Generic.List<TypeIdentifier> nested;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x28")]
		private System.Collections.Generic.List<TypeSpec> generic_params;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x30")]
		private System.Collections.Generic.List<ModifierSpec> modifier_spec;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x38")]
		private bool is_byref;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x40")]
		private string display_fullname;

		// Token: 0x020001D2 RID: 466
		[Token(Token = "0x20001D2")]
		[System.Flags]
		internal enum DisplayNameFormat
		{
			// Token: 0x0400097B RID: 2427
			[Token(Token = "0x400097B")]
			Default = 0,
			// Token: 0x0400097C RID: 2428
			[Token(Token = "0x400097C")]
			WANT_ASSEMBLY = 1,
			// Token: 0x0400097D RID: 2429
			[Token(Token = "0x400097D")]
			NO_MODIFIERS = 2
		}
	}
}
