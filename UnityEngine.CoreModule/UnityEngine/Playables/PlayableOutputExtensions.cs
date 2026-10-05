using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	public static class PlayableOutputExtensions
	{
		// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F34")]
		public static void SetReferenceObject<U>(this U output, Object value) where U : struct, IPlayableOutput
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F35")]
		public static void SetUserData<U>(this U output, Object value) where U : struct, IPlayableOutput
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x6000F36")]
		public static Playable GetSourcePlayable<U>(this U output) where U : struct, IPlayableOutput
		{
			return default(Playable);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F37")]
		public static void SetSourcePlayable<U, V>(this U output, V value, int port) where U : struct, IPlayableOutput where V : struct, IPlayable
		{
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x6000F38")]
		public static int GetSourceOutputPort<U>(this U output) where U : struct, IPlayableOutput
		{
			return 0;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F39")]
		public static void SetWeight<U>(this U output, float value) where U : struct, IPlayableOutput
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		public static void PushNotification<U>(this U output, Playable origin, INotification notification, [Optional] object context) where U : struct, IPlayableOutput
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3B")]
		public static void AddNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : struct, IPlayableOutput
		{
		}
	}
}
