using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B9F RID: 31647
	[Token(Token = "0x2007B9F")]
	public static class fsTypeCache
	{
		// Token: 0x0602C4E8 RID: 181480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4E8")]
		[Address(RVA = "0x2875F00", Offset = "0x2874B00", VA = "0x182875F00")]
		private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		// Token: 0x0602C4E9 RID: 181481 RVA: 0x000DF6F8 File Offset: 0x000DD8F8
		[Token(Token = "0x602C4E9")]
		[Address(RVA = "0x2876190", Offset = "0x2874D90", VA = "0x182876190")]
		private static bool TryDirectTypeLookup(string assemblyName, string typeName, out Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C4EA RID: 181482 RVA: 0x000DF710 File Offset: 0x000DD910
		[Token(Token = "0x602C4EA")]
		[Address(RVA = "0x28762E0", Offset = "0x2874EE0", VA = "0x1828762E0")]
		private static bool TryIndirectTypeLookup(string typeName, out Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C4EB RID: 181483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4EB")]
		[Address(RVA = "0x28760E0", Offset = "0x2874CE0", VA = "0x1828760E0")]
		public static void Reset()
		{
		}

		// Token: 0x0602C4EC RID: 181484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4EC")]
		[Address(RVA = "0x2875EB0", Offset = "0x2874AB0", VA = "0x182875EB0")]
		public static Type GetType(string name)
		{
			return null;
		}

		// Token: 0x0602C4ED RID: 181485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4ED")]
		[Address(RVA = "0x2875BA0", Offset = "0x28747A0", VA = "0x182875BA0")]
		public static Type GetType(string name, string assemblyHint)
		{
			return null;
		}

		// Token: 0x040401FA RID: 262650
		[Token(Token = "0x40401FA")]
		[ThreadStatic]
		private static Dictionary<string, Type> _cachedTypes;

		// Token: 0x040401FB RID: 262651
		[Token(Token = "0x40401FB")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Assembly> _assembliesByName;

		// Token: 0x040401FC RID: 262652
		[Token(Token = "0x40401FC")]
		[FieldOffset(Offset = "0x8")]
		private static List<Assembly> _assembliesByIndex;

		// Token: 0x040401FD RID: 262653
		[Token(Token = "0x40401FD")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Assembly, Dictionary<string, Type>> _fullname2TypesInAssemblies;
	}
}
