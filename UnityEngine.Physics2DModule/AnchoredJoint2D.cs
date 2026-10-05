using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
	public class AnchoredJoint2D : Joint2D
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x17000029")]
		public Vector2 connectedAnchor
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x59C2650", Offset = "0x59C1250", VA = "0x1859C2650")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600009B RID: 155
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x59C2600", Offset = "0x59C1200", VA = "0x1859C2600")]
		[MethodImpl(4096)]
		private extern void get_connectedAnchor_Injected(out Vector2 ret);
	}
}
