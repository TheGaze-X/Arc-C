using System;
using System.Collections.Generic;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	public class BattleTweenMgr
	{
		// Token: 0x06004CAA RID: 19626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x1787250", Offset = "0x1785E50", VA = "0x181787250")]
		public BattleTweenMgr(int preloadSize = 0)
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x1787180", Offset = "0x1785D80", VA = "0x181787180")]
		public BattleTweenMgr.Tween To(FP startValue, Action<FP> func, FP endValue, FP duration)
		{
			return null;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0x1786F70", Offset = "0x1785B70", VA = "0x181786F70")]
		public BattleTweenMgr.Tween To(Vector2 startPos, Action<Vector2> func, Vector2 endPos, FP duration)
		{
			return null;
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAD")]
		[Address(RVA = "0x1786E30", Offset = "0x1785A30", VA = "0x181786E30")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAE")]
		[Address(RVA = "0x1786D20", Offset = "0x1785920", VA = "0x181786D20")]
		public void Reset()
		{
		}

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x10")]
		private ObjectPool<BattleTweenMgr.Tween> m_tweenPool;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x18")]
		private List<BattleTweenMgr.Tween> m_tweenList;

		// Token: 0x0200048A RID: 1162
		[Token(Token = "0x200048A")]
		public class Tween : ITweenHandler, IReusable
		{
			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x06004CAF RID: 19631 RVA: 0x0002D348 File Offset: 0x0002B548
			[Token(Token = "0x170001E9")]
			public bool isPlaying
			{
				[Token(Token = "0x6004CAF")]
				[Address(RVA = "0x1796D30", Offset = "0x1795930", VA = "0x181796D30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x0002D360 File Offset: 0x0002B560
			[Token(Token = "0x170001EA")]
			public bool isStopped
			{
				[Token(Token = "0x6004CB0")]
				[Address(RVA = "0x1796D40", Offset = "0x1795940", VA = "0x181796D40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x0002D378 File Offset: 0x0002B578
			// (set) Token: 0x06004CB2 RID: 19634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170001EB")]
			private BattleTweenMgr.Tween.State state
			{
				[Token(Token = "0x6004CB1")]
				[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
				get
				{
					return BattleTweenMgr.Tween.State.NONE;
				}
				[Token(Token = "0x6004CB2")]
				[Address(RVA = "0x1796D50", Offset = "0x1795950", VA = "0x181796D50")]
				set
				{
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x0002D390 File Offset: 0x0002B590
			// (set) Token: 0x06004CB4 RID: 19636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170001EC")]
			public FP timeScale
			{
				[Token(Token = "0x6004CB3")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return default(FP);
				}
				[Token(Token = "0x6004CB4")]
				[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
				set
				{
				}
			}

			// Token: 0x06004CB5 RID: 19637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB5")]
			[Address(RVA = "0x17964A0", Offset = "0x17950A0", VA = "0x1817964A0")]
			public void Init(FP startValue, Action<FP> func, FP endValue, FP duration)
			{
			}

			// Token: 0x06004CB6 RID: 19638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB6")]
			[Address(RVA = "0x1796560", Offset = "0x1795160", VA = "0x181796560")]
			public void Init(Vector2 startPos, Action<Vector2> func, Vector2 endPos, FP duration)
			{
			}

			// Token: 0x06004CB7 RID: 19639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB7")]
			[Address(RVA = "0x17968C0", Offset = "0x17954C0", VA = "0x1817968C0")]
			public void Tick(FP deltaTime)
			{
			}

			// Token: 0x06004CB8 RID: 19640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB8")]
			[Address(RVA = "0x1796760", Offset = "0x1795360", VA = "0x181796760", Slot = "6")]
			public void OnAllocate()
			{
			}

			// Token: 0x06004CB9 RID: 19641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CB9")]
			[Address(RVA = "0x17967B0", Offset = "0x17953B0", VA = "0x1817967B0", Slot = "7")]
			public void OnRecycle()
			{
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
			[Token(Token = "0x6004CBA")]
			[Address(RVA = "0x17966F0", Offset = "0x17952F0", VA = "0x1817966F0", Slot = "4")]
			public bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06004CBB RID: 19643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CBB")]
			[Address(RVA = "0x1796700", Offset = "0x1795300", VA = "0x181796700", Slot = "5")]
			public void Kill(bool complete)
			{
			}

			// Token: 0x06004CBC RID: 19644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBC")]
			[Address(RVA = "0x17967E0", Offset = "0x17953E0", VA = "0x1817967E0")]
			public BattleTweenMgr.Tween Play()
			{
				return null;
			}

			// Token: 0x06004CBD RID: 19645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBD")]
			[Address(RVA = "0x1796860", Offset = "0x1795460", VA = "0x181796860")]
			public BattleTweenMgr.Tween SetDelay(FP delay)
			{
				return null;
			}

			// Token: 0x06004CBE RID: 19646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBE")]
			[Address(RVA = "0x1796870", Offset = "0x1795470", VA = "0x181796870")]
			public BattleTweenMgr.Tween SetEase(Interpolator.EaseType easeType)
			{
				return null;
			}

			// Token: 0x06004CBF RID: 19647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x17967C0", Offset = "0x17953C0", VA = "0x1817967C0")]
			public BattleTweenMgr.Tween OnStop(Action onKill)
			{
				return null;
			}

			// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CC0")]
			[Address(RVA = "0x1796CC0", Offset = "0x17958C0", VA = "0x181796CC0")]
			private void _OnComplete()
			{
			}

			// Token: 0x06004CC1 RID: 19649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CC1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Tween()
			{
			}

			// Token: 0x04001088 RID: 4232
			[Token(Token = "0x4001088")]
			[FieldOffset(Offset = "0x10")]
			private Action<FP> m_onUpdate;

			// Token: 0x04001089 RID: 4233
			[Token(Token = "0x4001089")]
			[FieldOffset(Offset = "0x18")]
			private Action m_onKill;

			// Token: 0x0400108A RID: 4234
			[Token(Token = "0x400108A")]
			[FieldOffset(Offset = "0x20")]
			private FP m_startValue;

			// Token: 0x0400108B RID: 4235
			[Token(Token = "0x400108B")]
			[FieldOffset(Offset = "0x28")]
			private FP m_endValue;

			// Token: 0x0400108C RID: 4236
			[Token(Token = "0x400108C")]
			[FieldOffset(Offset = "0x30")]
			private FP m_duration;

			// Token: 0x0400108D RID: 4237
			[Token(Token = "0x400108D")]
			[FieldOffset(Offset = "0x38")]
			private FP m_timeScale;

			// Token: 0x0400108E RID: 4238
			[Token(Token = "0x400108E")]
			[FieldOffset(Offset = "0x40")]
			private Interpolator.EasingFunction m_easeFunc;

			// Token: 0x0400108F RID: 4239
			[Token(Token = "0x400108F")]
			[FieldOffset(Offset = "0x48")]
			private FP m_delayTime;

			// Token: 0x04001090 RID: 4240
			[Token(Token = "0x4001090")]
			[FieldOffset(Offset = "0x50")]
			private FP m_accumTime;

			// Token: 0x04001091 RID: 4241
			[Token(Token = "0x4001091")]
			[FieldOffset(Offset = "0x58")]
			private BattleTweenMgr.Tween.State m_state;

			// Token: 0x04001092 RID: 4242
			[Token(Token = "0x4001092")]
			[FieldOffset(Offset = "0x60")]
			private BattleTweenMgr.Tween.Vector2Bundle m_vec2Bundle;

			// Token: 0x0200048B RID: 1163
			[Token(Token = "0x200048B")]
			private enum State : byte
			{
				// Token: 0x04001094 RID: 4244
				[Token(Token = "0x4001094")]
				NONE,
				// Token: 0x04001095 RID: 4245
				[Token(Token = "0x4001095")]
				INITED,
				// Token: 0x04001096 RID: 4246
				[Token(Token = "0x4001096")]
				PLAYING,
				// Token: 0x04001097 RID: 4247
				[Token(Token = "0x4001097")]
				STOPPED
			}

			// Token: 0x0200048C RID: 1164
			[Token(Token = "0x200048C")]
			private class Vector2Bundle
			{
				// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004CC3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Vector2Bundle()
				{
				}

				// Token: 0x04001098 RID: 4248
				[Token(Token = "0x4001098")]
				[FieldOffset(Offset = "0x10")]
				public Action<Vector2> onUpdate;

				// Token: 0x04001099 RID: 4249
				[Token(Token = "0x4001099")]
				[FieldOffset(Offset = "0x18")]
				public Vector2 startPos;

				// Token: 0x0400109A RID: 4250
				[Token(Token = "0x400109A")]
				[FieldOffset(Offset = "0x20")]
				public Vector2 endPos;
			}
		}
	}
}
