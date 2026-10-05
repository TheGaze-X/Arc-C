using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x02002895 RID: 10389
	[Token(Token = "0x2002895")]
	public class AudioEmitterLogInterface
	{
		// Token: 0x060114BA RID: 70842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114BA")]
		[Address(RVA = "0x91C8D0", Offset = "0x91B4D0", VA = "0x18091C8D0")]
		[Conditional("UNITY_EDITOR")]
		public static void EmitLog(string module, string subSignal, string eventName, Vector3 worldPosition)
		{
		}

		// Token: 0x060114BB RID: 70843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114BB")]
		[Address(RVA = "0x91C7C0", Offset = "0x91B3C0", VA = "0x18091C7C0")]
		[Conditional("UNITY_EDITOR")]
		public static void AddAudioLogDataAtLast(AudioChannel channel)
		{
		}

		// Token: 0x060114BC RID: 70844 RVA: 0x0006A8C0 File Offset: 0x00068AC0
		[Token(Token = "0x60114BC")]
		[Address(RVA = "0x91CA10", Offset = "0x91B610", VA = "0x18091CA10")]
		public static bool IsSystemEnabled()
		{
			return default(bool);
		}

		// Token: 0x060114BD RID: 70845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114BD")]
		[Address(RVA = "0x91CA60", Offset = "0x91B660", VA = "0x18091CA60")]
		public static void Reset()
		{
		}

		// Token: 0x060114BE RID: 70846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114BE")]
		[Address(RVA = "0x91CAF0", Offset = "0x91B6F0", VA = "0x18091CAF0")]
		private static AudioEmitterLogInterface.IHandler _GetHandler()
		{
			return null;
		}

		// Token: 0x060114BF RID: 70847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114BF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AudioEmitterLogInterface()
		{
		}

		// Token: 0x04013514 RID: 79124
		[Token(Token = "0x4013514")]
		public const string HANDLER_CLS_NAME = "Torappu.Battle.DevelopTools.AudioEmitterLogManager";

		// Token: 0x04013515 RID: 79125
		[Token(Token = "0x4013515")]
		[FieldOffset(Offset = "0x0")]
		private static AudioEmitterLogInterface.IHandler s_handler;

		// Token: 0x02002896 RID: 10390
		[Token(Token = "0x2002896")]
		public interface IHandler
		{
			// Token: 0x060114C0 RID: 70848
			[Token(Token = "0x60114C0")]
			void EmitLog(string module, string subSignal, string eventName, Vector3 worldPosition);

			// Token: 0x060114C1 RID: 70849
			[Token(Token = "0x60114C1")]
			void AddAudioLogDataAtLast(AudioChannel channel);

			// Token: 0x060114C2 RID: 70850
			[Token(Token = "0x60114C2")]
			void Clear();
		}
	}
}
