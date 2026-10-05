using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	[Serializable]
	public struct Scene
	{
		// Token: 0x06000CF7 RID: 3319
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x596C780", Offset = "0x596B380", VA = "0x18596C780")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern bool IsValidInternal(int sceneHandle);

		// Token: 0x06000CF8 RID: 3320
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x596C390", Offset = "0x596AF90", VA = "0x18596C390")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern string GetPathInternal(int sceneHandle);

		// Token: 0x06000CF9 RID: 3321
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x596C350", Offset = "0x596AF50", VA = "0x18596C350")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern string GetNameInternal(int sceneHandle);

		// Token: 0x06000CFA RID: 3322
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x596C310", Offset = "0x596AF10", VA = "0x18596C310")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern bool GetIsLoadedInternal(int sceneHandle);

		// Token: 0x06000CFB RID: 3323
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x596C3D0", Offset = "0x596AFD0", VA = "0x18596C3D0")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern int GetRootCountInternal(int sceneHandle);

		// Token: 0x06000CFC RID: 3324
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x596C410", Offset = "0x596B010", VA = "0x18596C410")]
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x1700029D")]
		public int handle
		{
			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x596C7C0", Offset = "0x596B3C0", VA = "0x18596C7C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029E")]
		public string path
		{
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x596C880", Offset = "0x596B480", VA = "0x18596C880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029F")]
		public string name
		{
			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x596C840", Offset = "0x596B440", VA = "0x18596C840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x170002A0")]
		public bool isLoaded
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x596C800", Offset = "0x596B400", VA = "0x18596C800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x170002A1")]
		public int rootCount
		{
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x596C8C0", Offset = "0x596B4C0", VA = "0x18596C8C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x596C6B0", Offset = "0x596B2B0", VA = "0x18596C6B0")]
		public GameObject[] GetRootGameObjects()
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x596C450", Offset = "0x596B050", VA = "0x18596C450")]
		public void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x596C290", Offset = "0x596AE90", VA = "0x18596C290", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int m_Handle;
	}
}
