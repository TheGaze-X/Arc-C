using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	[AssetFileNameExtension("playable", new string[]
	{

	})]
	[RequiredByNativeCode]
	[Serializable]
	public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
	{
		// Token: 0x06000E9E RID: 3742
		[Token(Token = "0x6000E9E")]
		public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x170002F6")]
		public virtual double duration
		{
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x5981890", Offset = "0x5980490", VA = "0x185981890", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F7")]
		public virtual IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x59818E0", Offset = "0x59804E0", VA = "0x1859818E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x59816F0", Offset = "0x59802F0", VA = "0x1859816F0")]
		[RequiredByNativeCode]
		internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x5981830", Offset = "0x5980430", VA = "0x185981830")]
		[RequiredByNativeCode]
		internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected PlayableAsset()
		{
		}
	}
}
