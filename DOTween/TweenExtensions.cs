using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public static class TweenExtensions
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3733FA0", Offset = "0x3732BA0", VA = "0x183733FA0")]
		public static void Complete(this Tween t)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x37340D0", Offset = "0x3732CD0", VA = "0x1837340D0")]
		public static void Complete(this Tween t, bool withCallbacks)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x37344A0", Offset = "0x37330A0", VA = "0x1837344A0")]
		public static void Done(this Tween t)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3734970", Offset = "0x3733570", VA = "0x183734970")]
		public static void Flip(this Tween t)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3734AA0", Offset = "0x37336A0", VA = "0x183734AA0")]
		public static void ForceInit(this Tween t)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x3734F40", Offset = "0x3733B40", VA = "0x183734F40")]
		public static void Goto(this Tween t, float to, bool andPlay = false)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3734F20", Offset = "0x3733B20", VA = "0x183734F20")]
		public static void GotoWithCallbacks(this Tween t, float to, bool andPlay = false)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3734300", Offset = "0x3732F00", VA = "0x183734300")]
		private static void DoGoto(Tween t, float to, bool andPlay, bool withCallbacks)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x37351F0", Offset = "0x3733DF0", VA = "0x1837351F0")]
		public static void Kill(this Tween t, bool complete = false)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x37353B0", Offset = "0x3733FB0", VA = "0x1837353B0")]
		public static void ManualUpdate(this Tween t, float deltaTime, float unscaledDeltaTime)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A3")]
		public static T Pause<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A4")]
		public static T Play<T>(this T t) where T : Tween
		{
			return null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3735B40", Offset = "0x3734740", VA = "0x183735B40")]
		public static void PlayBackwards(this Tween t)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3735C70", Offset = "0x3734870", VA = "0x183735C70")]
		public static void PlayForward(this Tween t)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3735DA0", Offset = "0x37349A0", VA = "0x183735DA0")]
		public static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3735F10", Offset = "0x3734B10", VA = "0x183735F10")]
		public static void Rewind(this Tween t, bool includeDelay = true)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3736060", Offset = "0x3734C60", VA = "0x183736060")]
		public static void SmoothRewind(this Tween t)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3736190", Offset = "0x3734D90", VA = "0x183736190")]
		public static void TogglePause(this Tween t)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3734BD0", Offset = "0x37337D0", VA = "0x183734BD0")]
		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x37362C0", Offset = "0x3734EC0", VA = "0x1837362C0")]
		public static YieldInstruction WaitForCompletion(this Tween t)
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3736670", Offset = "0x3735270", VA = "0x183736670")]
		public static YieldInstruction WaitForRewind(this Tween t)
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3736490", Offset = "0x3735090", VA = "0x183736490")]
		public static YieldInstruction WaitForKill(this Tween t)
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x37363A0", Offset = "0x3734FA0", VA = "0x1837363A0")]
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3736570", Offset = "0x3735170", VA = "0x183736570")]
		public static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3736750", Offset = "0x3735350", VA = "0x183736750")]
		public static Coroutine WaitForStart(this Tween t)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3734220", Offset = "0x3732E20", VA = "0x183734220")]
		public static int CompletedLoops(this Tween t)
		{
			return 0;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3734290", Offset = "0x3732E90", VA = "0x183734290")]
		public static float Delay(this Tween t)
		{
			return 0f;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x37346A0", Offset = "0x37332A0", VA = "0x1837346A0")]
		public static float ElapsedDelay(this Tween t)
		{
			return 0f;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x37345F0", Offset = "0x37331F0", VA = "0x1837345F0")]
		public static float Duration(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x37348C0", Offset = "0x37334C0", VA = "0x1837348C0")]
		public static float Elapsed(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x37347E0", Offset = "0x37333E0", VA = "0x1837347E0")]
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x3734710", Offset = "0x3733310", VA = "0x183734710")]
		public static float ElapsedDirectionalPercentage(this Tween t)
		{
			return 0f;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3734F60", Offset = "0x3733B60", VA = "0x183734F60")]
		public static bool IsActive(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3734F70", Offset = "0x3733B70", VA = "0x183734F70")]
		public static bool IsBackwards(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x37350C0", Offset = "0x3733CC0", VA = "0x1837350C0")]
		public static bool IsLoopingOrExecutingBackwards(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3734FE0", Offset = "0x3733BE0", VA = "0x183734FE0")]
		public static bool IsComplete(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3735050", Offset = "0x3733C50", VA = "0x183735050")]
		public static bool IsInitialized(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3735180", Offset = "0x3733D80", VA = "0x183735180")]
		public static bool IsPlaying(this Tween t)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3735340", Offset = "0x3733F40", VA = "0x183735340")]
		public static int Loops(this Tween t)
		{
			return 0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3735710", Offset = "0x3734310", VA = "0x183735710")]
		public static Vector3 PathGetPoint(this Tween t, float pathPercentage)
		{
			return default(Vector3);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3735520", Offset = "0x3734120", VA = "0x183735520")]
		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x3735950", Offset = "0x3734550", VA = "0x183735950")]
		public static float PathLength(this Tween t)
		{
			return 0f;
		}
	}
}
