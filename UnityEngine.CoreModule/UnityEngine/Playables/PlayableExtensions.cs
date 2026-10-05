using System;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	public static class PlayableExtensions
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x6000EB6")]
		public static bool IsValid<U>(this U playable) where U : struct, IPlayable
		{
			return default(bool);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x6000EB7")]
		public static PlayableGraph GetGraph<U>(this U playable) where U : struct, IPlayable
		{
			return default(PlayableGraph);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x6000EB8")]
		public static PlayState GetPlayState<U>(this U playable) where U : struct, IPlayable
		{
			return PlayState.Paused;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB9")]
		public static void Play<U>(this U playable) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBA")]
		public static void Pause<U>(this U playable) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBB")]
		public static void SetSpeed<U>(this U playable, double value) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6000EBC")]
		public static double GetSpeed<U>(this U playable) where U : struct, IPlayable
		{
			return 0.0;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBD")]
		public static void SetDuration<U>(this U playable, double value) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000EBE")]
		public static double GetDuration<U>(this U playable) where U : struct, IPlayable
		{
			return 0.0;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBF")]
		public static void SetTime<U>(this U playable, double value) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x6000EC0")]
		public static double GetTime<U>(this U playable) where U : struct, IPlayable
		{
			return 0.0;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x6000EC1")]
		public static double GetPreviousTime<U>(this U playable) where U : struct, IPlayable
		{
			return 0.0;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x6000EC2")]
		public static bool IsDone<U>(this U playable) where U : struct, IPlayable
		{
			return default(bool);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		public static void SetPropagateSetTime<U>(this U playable, bool value) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		public static void SetInputCount<U>(this U playable, int value) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000EC5")]
		public static int GetInputCount<U>(this U playable) where U : struct, IPlayable
		{
			return 0;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6000EC6")]
		public static Playable GetInput<U>(this U playable, int inputPort) where U : struct, IPlayable
		{
			return default(Playable);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC7")]
		public static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : struct, IPlayable
		{
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC8")]
		public static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : struct, IPlayable where V : struct, IPlayable
		{
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000EC9")]
		public static float GetInputWeight<U>(this U playable, int inputIndex) where U : struct, IPlayable
		{
			return 0f;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECA")]
		public static void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : struct, IPlayable
		{
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000ECB")]
		internal static DirectorWrapMode GetTimeWrapMode<U>(this U playable) where U : struct, IPlayable
		{
			return DirectorWrapMode.Hold;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECC")]
		internal static void SetTimeWrapMode<U>(this U playable, DirectorWrapMode value) where U : struct, IPlayable
		{
		}
	}
}
