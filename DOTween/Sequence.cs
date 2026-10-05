using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using Il2CppDummyDll;

namespace DG.Tweening
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public sealed class Sequence : Tween
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x3728250", Offset = "0x3726E50", VA = "0x183728250")]
		internal Sequence()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3727770", Offset = "0x3726370", VA = "0x183727770")]
		internal static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x37274D0", Offset = "0x37260D0", VA = "0x1837274D0")]
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x3726F90", Offset = "0x3725B90", VA = "0x183726F90")]
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3727690", Offset = "0x3726290", VA = "0x183727690")]
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3727400", Offset = "0x3726000", VA = "0x183727400")]
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3728140", Offset = "0x3726D40", VA = "0x183728140", Slot = "6")]
		internal override float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3727CC0", Offset = "0x37268C0", VA = "0x183727CC0", Slot = "4")]
		internal override void Reset()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3728170", Offset = "0x3726D70", VA = "0x183728170", Slot = "5")]
		internal override bool Validate()
		{
			return default(bool);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3728130", Offset = "0x3726D30", VA = "0x183728130", Slot = "7")]
		internal override bool Startup()
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3726F70", Offset = "0x3725B70", VA = "0x183726F70", Slot = "8")]
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return default(bool);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3727EC0", Offset = "0x3726AC0", VA = "0x183727EC0")]
		internal static void Setup(Sequence s)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x37278B0", Offset = "0x37264B0", VA = "0x1837278B0")]
		internal static bool DoStartup(Sequence s)
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3726FD0", Offset = "0x3725BD0", VA = "0x183726FD0")]
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			return default(bool);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3726780", Offset = "0x3725380", VA = "0x183726780")]
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			return default(bool);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3727FF0", Offset = "0x3726BF0", VA = "0x183727FF0")]
		private static void StableSortSequencedObjs(List<ABSSequentiable> list)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3727C60", Offset = "0x3726860", VA = "0x183727C60")]
		private static bool IsAnyCallbackSet(Sequence s)
		{
			return default(bool);
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x120")]
		internal readonly List<Tween> sequencedTweens;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<ABSSequentiable> _sequencedObjs;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x130")]
		internal float lastTweenInsertTime;
	}
}
