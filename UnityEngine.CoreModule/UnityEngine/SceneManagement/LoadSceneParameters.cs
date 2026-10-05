using System;
using Il2CppDummyDll;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	[Serializable]
	public struct LoadSceneParameters
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x595F830", Offset = "0x595E430", VA = "0x18595F830")]
		public LoadSceneParameters(LoadSceneMode mode)
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LoadSceneMode m_LoadSceneMode;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
