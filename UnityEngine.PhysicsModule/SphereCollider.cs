using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/SphereCollider.h")]
	public class SphereCollider : Collider
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x1700001C")]
		public Vector3 center
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x59CB820", Offset = "0x59CA420", VA = "0x1859CB820")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109
		[Token(Token = "0x1700001D")]
		public extern float radius { [Token(Token = "0x600006D")] [Address(RVA = "0x59CB870", Offset = "0x59CA470", VA = "0x1859CB870")] [MethodImpl(4096)] get; }

		// Token: 0x0600006E RID: 110
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x59CB7D0", Offset = "0x59CA3D0", VA = "0x1859CB7D0")]
		[MethodImpl(4096)]
		private extern void get_center_Injected(out Vector3 ret);
	}
}
