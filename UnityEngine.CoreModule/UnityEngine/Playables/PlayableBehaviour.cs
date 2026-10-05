using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	[RequiredByNativeCode]
	[Serializable]
	public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayableBehaviour()
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public virtual void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public virtual void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public virtual void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x5981930", Offset = "0x5980530", VA = "0x185981930", Slot = "21")]
		public virtual object Clone()
		{
			return null;
		}
	}
}
