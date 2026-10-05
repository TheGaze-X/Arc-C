using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public static class Flags
	{
		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		public const BindingFlags AnyVisibility = BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		public const BindingFlags InstancePublic = BindingFlags.Instance | BindingFlags.Public;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		public const BindingFlags InstancePrivate = BindingFlags.Instance | BindingFlags.NonPublic;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		public const BindingFlags InstanceAnyVisibility = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		public const BindingFlags StaticPublic = BindingFlags.Static | BindingFlags.Public;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		public const BindingFlags StaticPrivate = BindingFlags.Static | BindingFlags.NonPublic;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		public const BindingFlags StaticAnyVisibility = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		public const BindingFlags InstancePublicDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		public const BindingFlags InstancePrivateDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const BindingFlags InstanceAnyDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		public const BindingFlags StaticPublicDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		public const BindingFlags StaticPrivateDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		public const BindingFlags StaticAnyDeclaredOnly = BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		public const BindingFlags StaticInstanceAnyVisibility = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		public const BindingFlags AllMembers = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
	}
}
