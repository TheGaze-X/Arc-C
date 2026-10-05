using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[RequiredByNativeCode]
	[Serializable]
	public abstract class VFXSpawnerCallbacks : ScriptableObject
	{
		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected VFXSpawnerCallbacks()
		{
		}
	}
}
