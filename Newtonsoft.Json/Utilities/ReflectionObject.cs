using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Preserve]
	internal class ReflectionObject
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000091")]
		public ObjectConstructor<object> Creator
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000092")]
		public IDictionary<string, ReflectionMember> Members
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4D91DA0", Offset = "0x4D909A0", VA = "0x184D91DA0")]
		public ReflectionObject()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4D91C80", Offset = "0x4D90880", VA = "0x184D91C80")]
		public object GetValue(object target, string member)
		{
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4D91D10", Offset = "0x4D90910", VA = "0x184D91D10")]
		public void SetValue(object target, string member, object value)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4D91C20", Offset = "0x4D90820", VA = "0x184D91C20")]
		public Type GetType(string member)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4D91210", Offset = "0x4D8FE10", VA = "0x184D91210")]
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4D91220", Offset = "0x4D8FE20", VA = "0x184D91220")]
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			return null;
		}
	}
}
