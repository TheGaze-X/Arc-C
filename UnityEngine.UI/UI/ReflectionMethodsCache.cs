using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	internal class ReflectionMethodsCache
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5B6E7F0", Offset = "0x5B6D3F0", VA = "0x185B6E7F0")]
		public ReflectionMethodsCache()
		{
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public static ReflectionMethodsCache Singleton
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x5B6F7E0", Offset = "0x5B6E3E0", VA = "0x185B6F7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x10")]
		public ReflectionMethodsCache.Raycast3DCallback raycast3D;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x18")]
		public ReflectionMethodsCache.RaycastAllCallback raycast3DAll;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x20")]
		public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x28")]
		public ReflectionMethodsCache.Raycast2DCallback raycast2D;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x30")]
		public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x38")]
		public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600053E RID: 1342
		[Token(Token = "0x2000079")]
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000542 RID: 1346
		[Token(Token = "0x200007A")]
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000546 RID: 1350
		[Token(Token = "0x200007B")]
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600054A RID: 1354
		[Token(Token = "0x200007C")]
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600054E RID: 1358
		[Token(Token = "0x200007D")]
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000552 RID: 1362
		[Token(Token = "0x200007E")]
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i);
	}
}
