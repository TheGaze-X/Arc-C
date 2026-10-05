using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[NativeHeader("Modules/Physics/BoxCollider.h")]
	[RequiredByNativeCode]
	public class BoxCollider : Collider
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x1700001A")]
		public Vector3 center
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x59C6EA0", Offset = "0x59C5AA0", VA = "0x1859C6EA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x1700001B")]
		public Vector3 size
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x59C6F40", Offset = "0x59C5B40", VA = "0x1859C6F40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600006A RID: 106
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59C6E50", Offset = "0x59C5A50", VA = "0x1859C6E50")]
		[MethodImpl(4096)]
		private extern void get_center_Injected(out Vector3 ret);

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59C6EF0", Offset = "0x59C5AF0", VA = "0x1859C6EF0")]
		[MethodImpl(4096)]
		private extern void get_size_Injected(out Vector3 ret);
	}
}
