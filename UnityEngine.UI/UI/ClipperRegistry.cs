using System;
using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class ClipperRegistry
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5A087C0", Offset = "0x5A073C0", VA = "0x185A087C0")]
		protected ClipperRegistry()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public static ClipperRegistry instance
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x5A08850", Offset = "0x5A07450", VA = "0x185A08850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5A08530", Offset = "0x5A07130", VA = "0x185A08530")]
		public void Cull()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5A086F0", Offset = "0x5A072F0", VA = "0x185A086F0")]
		public static void Register(IClipper c)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5A08760", Offset = "0x5A07360", VA = "0x185A08760")]
		public static void Unregister(IClipper c)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5A08690", Offset = "0x5A07290", VA = "0x185A08690")]
		public static void Disable(IClipper c)
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		private static ClipperRegistry s_Instance;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private readonly IndexedSet<IClipper> m_Clippers;
	}
}
