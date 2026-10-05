using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x59C52D0", Offset = "0x59C3ED0", VA = "0x1859C52D0")]
		public PhysicsMaterial2D()
		{
		}

		// Token: 0x0600009D RID: 157
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x59C5280", Offset = "0x59C3E80", VA = "0x1859C5280")]
		[NativeMethod("Create_Binding")]
		[MethodImpl(4096)]
		private static extern void Create_Internal([Writable] PhysicsMaterial2D scriptMaterial, string name);

		// Token: 0x1700002A RID: 42
		// (set) Token: 0x0600009E RID: 158
		[Token(Token = "0x1700002A")]
		public extern float bounciness { [Token(Token = "0x600009E")] [Address(RVA = "0x59C5340", Offset = "0x59C3F40", VA = "0x1859C5340")] [MethodImpl(4096)] set; }

		// Token: 0x1700002B RID: 43
		// (set) Token: 0x0600009F RID: 159
		[Token(Token = "0x1700002B")]
		public extern float friction { [Token(Token = "0x600009F")] [Address(RVA = "0x59C5390", Offset = "0x59C3F90", VA = "0x1859C5390")] [MethodImpl(4096)] set; }
	}
}
