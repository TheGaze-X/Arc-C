using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Fx;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003203 RID: 12803
	[Token(Token = "0x2003203")]
	public abstract class Effect : BasicEffect, IEffectSource, IReusableObject, IReusable, IPtrObject, IHotfixable
	{
		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x060144E7 RID: 83175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060144E8 RID: 83176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700300D")]
		public string effectKey
		{
			[Token(Token = "0x60144E7")]
			[Address(RVA = "0xC8D460", Offset = "0xC8C060", VA = "0x180C8D460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60144E8")]
			[Address(RVA = "0xC8DC40", Offset = "0xC8C840", VA = "0x180C8DC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x060144E9 RID: 83177 RVA: 0x00086640 File Offset: 0x00084840
		// (set) Token: 0x060144EA RID: 83178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700300E")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x60144E9")]
			[Address(RVA = "0xC8D910", Offset = "0xC8C510", VA = "0x180C8D910")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x60144EA")]
			[Address(RVA = "0xC8DEB0", Offset = "0xC8CAB0", VA = "0x180C8DEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x060144EB RID: 83179 RVA: 0x00086658 File Offset: 0x00084858
		// (set) Token: 0x060144EC RID: 83180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700300F")]
		public uint instanceUid
		{
			[Token(Token = "0x60144EB")]
			[Address(RVA = "0xC8D520", Offset = "0xC8C120", VA = "0x180C8D520", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60144EC")]
			[Address(RVA = "0xC8DCC0", Offset = "0xC8C8C0", VA = "0x180C8DCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x060144ED RID: 83181
		[Token(Token = "0x17003010")]
		public abstract bool allowAutoReuse { [Token(Token = "0x60144ED")] get; }

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x060144EE RID: 83182
		[Token(Token = "0x17003011")]
		public abstract int preloadCnt { [Token(Token = "0x60144EE")] get; }

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x060144EF RID: 83183
		[Token(Token = "0x17003012")]
		protected abstract Effect.SpawnLocation spawnLocation { [Token(Token = "0x60144EF")] get; }

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x060144F0 RID: 83184
		[Token(Token = "0x17003013")]
		protected abstract bool useBodyDirection { [Token(Token = "0x60144F0")] get; }

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x060144F1 RID: 83185
		[Token(Token = "0x17003014")]
		protected abstract bool holdByOwner { [Token(Token = "0x60144F1")] get; }

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x060144F2 RID: 83186 RVA: 0x00086670 File Offset: 0x00084870
		[Token(Token = "0x17003015")]
		protected virtual bool overwriteHeight
		{
			[Token(Token = "0x60144F2")]
			[Address(RVA = "0xC8D850", Offset = "0xC8C450", VA = "0x180C8D850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x060144F3 RID: 83187 RVA: 0x00086688 File Offset: 0x00084888
		[Token(Token = "0x17003016")]
		protected virtual float heightOffset
		{
			[Token(Token = "0x60144F3")]
			[Address(RVA = "0xC8D4C0", Offset = "0xC8C0C0", VA = "0x180C8D4C0", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x060144F4 RID: 83188 RVA: 0x000866A0 File Offset: 0x000848A0
		[Token(Token = "0x17003017")]
		protected virtual float delayToPlay
		{
			[Token(Token = "0x60144F4")]
			[Address(RVA = "0xC8D3A0", Offset = "0xC8BFA0", VA = "0x180C8D3A0", Slot = "15")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x060144F5 RID: 83189 RVA: 0x000866B8 File Offset: 0x000848B8
		[Token(Token = "0x17003018")]
		protected internal virtual float delayToRecycle
		{
			[Token(Token = "0x60144F5")]
			[Address(RVA = "0xC8D400", Offset = "0xC8C000", VA = "0x180C8D400", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x060144F6 RID: 83190 RVA: 0x000866D0 File Offset: 0x000848D0
		[Token(Token = "0x17003019")]
		protected virtual bool randomPlayDelay
		{
			[Token(Token = "0x60144F6")]
			[Address(RVA = "0xC8D970", Offset = "0xC8C570", VA = "0x180C8D970", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x060144F7 RID: 83191 RVA: 0x000866E8 File Offset: 0x000848E8
		[Token(Token = "0x1700301A")]
		protected virtual bool usePlaybackSpeed
		{
			[Token(Token = "0x60144F7")]
			[Address(RVA = "0xC8DBE0", Offset = "0xC8C7E0", VA = "0x180C8DBE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x060144F8 RID: 83192 RVA: 0x00086700 File Offset: 0x00084900
		[Token(Token = "0x1700301B")]
		protected virtual float limitedPlaybackSpeed
		{
			[Token(Token = "0x60144F8")]
			[Address(RVA = "0xC8D6D0", Offset = "0xC8C2D0", VA = "0x180C8D6D0", Slot = "19")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x060144F9 RID: 83193 RVA: 0x00086718 File Offset: 0x00084918
		[Token(Token = "0x1700301C")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug", Priority = 10)]
		protected bool isFinished
		{
			[Token(Token = "0x60144F9")]
			[Address(RVA = "0xC8D580", Offset = "0xC8C180", VA = "0x180C8D580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x060144FA RID: 83194 RVA: 0x00086730 File Offset: 0x00084930
		// (set) Token: 0x060144FB RID: 83195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700301D")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		public bool isPaused
		{
			[Token(Token = "0x60144FA")]
			[Address(RVA = "0xC8D640", Offset = "0xC8C240", VA = "0x180C8D640")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60144FB")]
			[Address(RVA = "0xC8DD30", Offset = "0xC8C930", VA = "0x180C8DD30")]
			set
			{
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x060144FC RID: 83196 RVA: 0x00086748 File Offset: 0x00084948
		[Token(Token = "0x1700301E")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		public bool isPausedByOthers
		{
			[Token(Token = "0x60144FC")]
			[Address(RVA = "0xC8D5E0", Offset = "0xC8C1E0", VA = "0x180C8D5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x060144FD RID: 83197 RVA: 0x00086760 File Offset: 0x00084960
		// (set) Token: 0x060144FE RID: 83198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700301F")]
		protected float playbackSpeed
		{
			[Token(Token = "0x60144FD")]
			[Address(RVA = "0xC8D8B0", Offset = "0xC8C4B0", VA = "0x180C8D8B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60144FE")]
			[Address(RVA = "0xC8DE40", Offset = "0xC8CA40", VA = "0x180C8DE40")]
			set
			{
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x060144FF RID: 83199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003020")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		protected Transform bodyTransform
		{
			[Token(Token = "0x60144FF")]
			[Address(RVA = "0xC8D340", Offset = "0xC8BF40", VA = "0x180C8D340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06014500 RID: 83200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003021")]
		protected TrailRenderer[] trailRenderers
		{
			[Token(Token = "0x6014500")]
			[Address(RVA = "0xC8D9D0", Offset = "0xC8C5D0", VA = "0x180C8D9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06014501 RID: 83201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003022")]
		protected float[] originTrailTimes
		{
			[Token(Token = "0x6014501")]
			[Address(RVA = "0xC8D7F0", Offset = "0xC8C3F0", VA = "0x180C8D7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06014502 RID: 83202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003023")]
		protected float[] originTrailMinVertexDistances
		{
			[Token(Token = "0x6014502")]
			[Address(RVA = "0xC8D790", Offset = "0xC8C390", VA = "0x180C8D790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06014503 RID: 83203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003024")]
		public FxLODSetting lodSetting
		{
			[Token(Token = "0x6014503")]
			[Address(RVA = "0xC8D730", Offset = "0xC8C330", VA = "0x180C8D730")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014504 RID: 83204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014504")]
		[Address(RVA = "0xC8A5D0", Offset = "0xC891D0", VA = "0x180C8A5D0")]
		public void Play(Entity entity, Vector3 direction, float playbackSpeed)
		{
		}

		// Token: 0x06014505 RID: 83205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014505")]
		[Address(RVA = "0xC8A450", Offset = "0xC89050", VA = "0x180C8A450")]
		public void Play(float playbackSpeed)
		{
		}

		// Token: 0x06014506 RID: 83206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014506")]
		[Address(RVA = "0xC8AB30", Offset = "0xC89730", VA = "0x180C8AB30")]
		public void Play(Vector3 direction, float playbackSpeed, bool useOverwriteHeight = false)
		{
		}

		// Token: 0x06014507 RID: 83207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014507")]
		[Address(RVA = "0xC8A810", Offset = "0xC89410", VA = "0x180C8A810")]
		public void Play(ILocatable locatable, Vector3 direction, float playbackSpeed, [Optional] Entity owner)
		{
		}

		// Token: 0x06014508 RID: 83208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014508")]
		[Address(RVA = "0xC88FE0", Offset = "0xC87BE0", VA = "0x180C88FE0")]
		public void FinishMe(bool immediately = false)
		{
		}

		// Token: 0x06014509 RID: 83209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014509")]
		[Address(RVA = "0xC89FB0", Offset = "0xC88BB0", VA = "0x180C89FB0", Slot = "20")]
		protected virtual void OnFinish()
		{
		}

		// Token: 0x0601450A RID: 83210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450A")]
		[Address(RVA = "0xC89930", Offset = "0xC88530", VA = "0x180C89930", Slot = "21")]
		protected virtual void OnBeforePlay()
		{
		}

		// Token: 0x0601450B RID: 83211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450B")]
		[Address(RVA = "0xC896F0", Offset = "0xC882F0", VA = "0x180C896F0", Slot = "22")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x0601450C RID: 83212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450C")]
		[Address(RVA = "0xC8A1B0", Offset = "0xC88DB0", VA = "0x180C8A1B0", Slot = "23")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x0601450D RID: 83213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450D")]
		[Address(RVA = "0xC894C0", Offset = "0xC880C0", VA = "0x180C894C0", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601450E RID: 83214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450E")]
		[Address(RVA = "0xC886B0", Offset = "0xC872B0", VA = "0x180C886B0", Slot = "24")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0601450F RID: 83215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601450F")]
		[Address(RVA = "0xC8CC70", Offset = "0xC8B870", VA = "0x180C8CC70")]
		private void _UpdateSubDelay()
		{
		}

		// Token: 0x06014510 RID: 83216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014510")]
		[Address(RVA = "0xC89B90", Offset = "0xC88790", VA = "0x180C89B90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014511 RID: 83217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014511")]
		[Address(RVA = "0xC89D60", Offset = "0xC88960", VA = "0x180C89D60", Slot = "25")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06014512 RID: 83218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014512")]
		[Address(RVA = "0xC88C70", Offset = "0xC87870", VA = "0x180C88C70", Slot = "26")]
		public virtual void FaceTo(Vector3 direction)
		{
		}

		// Token: 0x06014513 RID: 83219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014513")]
		[Address(RVA = "0xC89240", Offset = "0xC87E40", VA = "0x180C89240", Slot = "27")]
		public virtual void Flip(bool flip)
		{
		}

		// Token: 0x06014514 RID: 83220 RVA: 0x00086778 File Offset: 0x00084978
		[Token(Token = "0x6014514")]
		[Address(RVA = "0xC88A20", Offset = "0xC87620", VA = "0x180C88A20", Slot = "28")]
		public virtual Vector3 BodyDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06014515 RID: 83221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014515")]
		[Address(RVA = "0xC88B90", Offset = "0xC87790", VA = "0x180C88B90", Slot = "29")]
		protected virtual void DoPlay()
		{
		}

		// Token: 0x06014516 RID: 83222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014516")]
		[Address(RVA = "0xC8AE50", Offset = "0xC89A50", VA = "0x180C8AE50", Slot = "30")]
		protected virtual void UpdatePlaybackSpeed(float playbackSpeed)
		{
		}

		// Token: 0x06014517 RID: 83223 RVA: 0x00086790 File Offset: 0x00084990
		[Token(Token = "0x6014517")]
		[Address(RVA = "0xC8AD80", Offset = "0xC89980", VA = "0x180C8AD80")]
		protected bool SetPaused(bool value)
		{
			return default(bool);
		}

		// Token: 0x06014518 RID: 83224 RVA: 0x000867A8 File Offset: 0x000849A8
		[Token(Token = "0x6014518")]
		[Address(RVA = "0xC8ACB0", Offset = "0xC898B0", VA = "0x180C8ACB0")]
		public bool SetPausedByOthers(bool value)
		{
			return default(bool);
		}

		// Token: 0x06014519 RID: 83225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014519")]
		[Address(RVA = "0xC8A010", Offset = "0xC88C10", VA = "0x180C8A010", Slot = "31")]
		protected virtual void OnPausedUpdated(bool originIsPaused)
		{
		}

		// Token: 0x0601451A RID: 83226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451A")]
		[Address(RVA = "0xC88AB0", Offset = "0xC876B0", VA = "0x180C88AB0", Slot = "32")]
		protected virtual void ClearTrailRenderers()
		{
		}

		// Token: 0x0601451B RID: 83227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451B")]
		[Address(RVA = "0xC8C4F0", Offset = "0xC8B0F0", VA = "0x180C8C4F0")]
		private void _PlayInternal(Vector3 direction, float playbackSpeed)
		{
		}

		// Token: 0x0601451C RID: 83228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451C")]
		[Address(RVA = "0xC8C3D0", Offset = "0xC8AFD0", VA = "0x180C8C3D0")]
		private void _LimitedPlaybackSpeed(ref float playbackSpeed)
		{
		}

		// Token: 0x0601451D RID: 83229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451D")]
		[Address(RVA = "0xC8CA10", Offset = "0xC8B610", VA = "0x180C8CA10")]
		private void _SetOwner(Entity entity)
		{
		}

		// Token: 0x0601451E RID: 83230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451E")]
		[Address(RVA = "0xC8B0F0", Offset = "0xC89CF0", VA = "0x180C8B0F0")]
		private void _InitLocationFromEntity(Entity entity)
		{
		}

		// Token: 0x0601451F RID: 83231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601451F")]
		[Address(RVA = "0xC8CAB0", Offset = "0xC8B6B0", VA = "0x180C8CAB0")]
		private void _SetPosAndRotToMountPoint(Entity entity, MountPoint mountPoint)
		{
		}

		// Token: 0x06014520 RID: 83232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014520")]
		[Address(RVA = "0xC8C940", Offset = "0xC8B540", VA = "0x180C8C940")]
		private void _SetEffectLikeCameraEffect()
		{
		}

		// Token: 0x06014521 RID: 83233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014521")]
		[Address(RVA = "0xC8BF40", Offset = "0xC8AB40", VA = "0x180C8BF40")]
		private void _InitLocation(bool useOverwriteHeight = false)
		{
		}

		// Token: 0x06014522 RID: 83234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014522")]
		[Address(RVA = "0xC8B030", Offset = "0xC89C30", VA = "0x180C8B030")]
		private IEnumerator _DelayToActiveGameObject(Effect.SubFXDelay config)
		{
			return null;
		}

		// Token: 0x06014523 RID: 83235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014523")]
		[Address(RVA = "0xC88D40", Offset = "0xC87940", VA = "0x180C88D40")]
		public static void FinishEffects(IList<ObjectPtr<Effect>> effects)
		{
		}

		// Token: 0x06014524 RID: 83236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014524")]
		[Address(RVA = "0xC89600", Offset = "0xC88200", VA = "0x180C89600")]
		public List<LineRenderer> GetLineRenderers()
		{
			return null;
		}

		// Token: 0x06014525 RID: 83237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014525")]
		[Address(RVA = "0xC8D200", Offset = "0xC8BE00", VA = "0x180C8D200")]
		protected Effect()
		{
		}

		// Token: 0x04017EF6 RID: 98038
		[Token(Token = "0x4017EF6")]
		private const string CHILD_NAME_BODY_TRANSFORM = "body";

		// Token: 0x04017EF7 RID: 98039
		[Token(Token = "0x4017EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x04017EF8 RID: 98040
		[Token(Token = "0x4017EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private Transform _bodyTransofrm;

		// Token: 0x04017EF9 RID: 98041
		[Token(Token = "0x4017EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Effect.SubFXDelayConfig> _subFXDelayConfigs;

		// Token: 0x04017EFA RID: 98042
		[Token(Token = "0x4017EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ObjectPtr<Entity> m_owner;

		// Token: 0x04017EFB RID: 98043
		[Token(Token = "0x4017EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Effect.Behaviour[] m_behaviours;

		// Token: 0x04017EFC RID: 98044
		[Token(Token = "0x4017EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected bool m_isStarted;

		// Token: 0x04017EFD RID: 98045
		[Token(Token = "0x4017EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_isFinished;

		// Token: 0x04017EFE RID: 98046
		[Token(Token = "0x4017EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool m_isPaused;

		// Token: 0x04017EFF RID: 98047
		[Token(Token = "0x4017EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		private bool m_isPausedByOthers;

		// Token: 0x04017F00 RID: 98048
		[Token(Token = "0x4017F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_playbackSpeed;

		// Token: 0x04017F01 RID: 98049
		[Token(Token = "0x4017F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected TrailRenderer[] m_trailRenderers;

		// Token: 0x04017F02 RID: 98050
		[Token(Token = "0x4017F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<LineRenderer> m_lineRenderers;

		// Token: 0x04017F03 RID: 98051
		[Token(Token = "0x4017F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] m_originTrailTimes;

		// Token: 0x04017F04 RID: 98052
		[Token(Token = "0x4017F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] m_originTrailMinVertexDistances;

		// Token: 0x04017F05 RID: 98053
		[Token(Token = "0x4017F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Coroutine m_coroutine;

		// Token: 0x04017F06 RID: 98054
		[Token(Token = "0x4017F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Effect.Behaviour> m_pauseByBehaviours;

		// Token: 0x04017F09 RID: 98057
		[Token(Token = "0x4017F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FxDelay m_mainFxDelay;

		// Token: 0x04017F0A RID: 98058
		[Token(Token = "0x4017F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ListDict<Transform, Effect.SubFXDelay> m_subFxDelayConfig;

		// Token: 0x04017F0B RID: 98059
		[Token(Token = "0x4017F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FxLODSetting m_lodSetting;

		// Token: 0x04017F0D RID: 98061
		[Token(Token = "0x4017F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effectKey;

		// Token: 0x04017F0E RID: 98062
		[Token(Token = "0x4017F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_effectKey;

		// Token: 0x04017F0F RID: 98063
		[Token(Token = "0x4017F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x04017F10 RID: 98064
		[Token(Token = "0x4017F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_playerSide;

		// Token: 0x04017F11 RID: 98065
		[Token(Token = "0x4017F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x04017F12 RID: 98066
		[Token(Token = "0x4017F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x04017F13 RID: 98067
		[Token(Token = "0x4017F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x04017F14 RID: 98068
		[Token(Token = "0x4017F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x04017F15 RID: 98069
		[Token(Token = "0x4017F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_delayToPlay;

		// Token: 0x04017F16 RID: 98070
		[Token(Token = "0x4017F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x04017F17 RID: 98071
		[Token(Token = "0x4017F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_randomPlayDelay;

		// Token: 0x04017F18 RID: 98072
		[Token(Token = "0x4017F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_usePlaybackSpeed;

		// Token: 0x04017F19 RID: 98073
		[Token(Token = "0x4017F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_limitedPlaybackSpeed;

		// Token: 0x04017F1A RID: 98074
		[Token(Token = "0x4017F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isFinished;

		// Token: 0x04017F1B RID: 98075
		[Token(Token = "0x4017F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isPaused;

		// Token: 0x04017F1C RID: 98076
		[Token(Token = "0x4017F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_isPaused;

		// Token: 0x04017F1D RID: 98077
		[Token(Token = "0x4017F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isPausedByOthers;

		// Token: 0x04017F1E RID: 98078
		[Token(Token = "0x4017F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_playbackSpeed;

		// Token: 0x04017F1F RID: 98079
		[Token(Token = "0x4017F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_playbackSpeed;

		// Token: 0x04017F20 RID: 98080
		[Token(Token = "0x4017F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_bodyTransform;

		// Token: 0x04017F21 RID: 98081
		[Token(Token = "0x4017F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_trailRenderers;

		// Token: 0x04017F22 RID: 98082
		[Token(Token = "0x4017F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_originTrailTimes;

		// Token: 0x04017F23 RID: 98083
		[Token(Token = "0x4017F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_originTrailMinVertexDistances;

		// Token: 0x04017F24 RID: 98084
		[Token(Token = "0x4017F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_lodSetting;

		// Token: 0x04017F25 RID: 98085
		[Token(Token = "0x4017F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04017F26 RID: 98086
		[Token(Token = "0x4017F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1_Play;

		// Token: 0x04017F27 RID: 98087
		[Token(Token = "0x4017F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix2_Play;

		// Token: 0x04017F28 RID: 98088
		[Token(Token = "0x4017F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix3_Play;

		// Token: 0x04017F29 RID: 98089
		[Token(Token = "0x4017F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_FinishMe;

		// Token: 0x04017F2A RID: 98090
		[Token(Token = "0x4017F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04017F2B RID: 98091
		[Token(Token = "0x4017F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnBeforePlay;

		// Token: 0x04017F2C RID: 98092
		[Token(Token = "0x4017F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04017F2D RID: 98093
		[Token(Token = "0x4017F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04017F2E RID: 98094
		[Token(Token = "0x4017F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04017F2F RID: 98095
		[Token(Token = "0x4017F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04017F30 RID: 98096
		[Token(Token = "0x4017F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__UpdateSubDelay;

		// Token: 0x04017F31 RID: 98097
		[Token(Token = "0x4017F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04017F32 RID: 98098
		[Token(Token = "0x4017F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04017F33 RID: 98099
		[Token(Token = "0x4017F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_FaceTo;

		// Token: 0x04017F34 RID: 98100
		[Token(Token = "0x4017F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_Flip;

		// Token: 0x04017F35 RID: 98101
		[Token(Token = "0x4017F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_BodyDirection;

		// Token: 0x04017F36 RID: 98102
		[Token(Token = "0x4017F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_DoPlay;

		// Token: 0x04017F37 RID: 98103
		[Token(Token = "0x4017F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04017F38 RID: 98104
		[Token(Token = "0x4017F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x04017F39 RID: 98105
		[Token(Token = "0x4017F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_SetPausedByOthers;

		// Token: 0x04017F3A RID: 98106
		[Token(Token = "0x4017F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnPausedUpdated;

		// Token: 0x04017F3B RID: 98107
		[Token(Token = "0x4017F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_ClearTrailRenderers;

		// Token: 0x04017F3C RID: 98108
		[Token(Token = "0x4017F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__PlayInternal;

		// Token: 0x04017F3D RID: 98109
		[Token(Token = "0x4017F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__LimitedPlaybackSpeed;

		// Token: 0x04017F3E RID: 98110
		[Token(Token = "0x4017F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__SetOwner;

		// Token: 0x04017F3F RID: 98111
		[Token(Token = "0x4017F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__InitLocationFromEntity;

		// Token: 0x04017F40 RID: 98112
		[Token(Token = "0x4017F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__SetPosAndRotToMountPoint;

		// Token: 0x04017F41 RID: 98113
		[Token(Token = "0x4017F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__SetEffectLikeCameraEffect;

		// Token: 0x04017F42 RID: 98114
		[Token(Token = "0x4017F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__InitLocation;

		// Token: 0x04017F43 RID: 98115
		[Token(Token = "0x4017F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__DelayToActiveGameObject;

		// Token: 0x04017F44 RID: 98116
		[Token(Token = "0x4017F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_FinishEffects;

		// Token: 0x04017F45 RID: 98117
		[Token(Token = "0x4017F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_GetLineRenderers;

		// Token: 0x04017F46 RID: 98118
		[Token(Token = "0x4017F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003204 RID: 12804
		[Token(Token = "0x2003204")]
		public class Behaviour : MonoBehaviour, IHotfixable
		{
			// Token: 0x17003025 RID: 12325
			// (get) Token: 0x06014526 RID: 83238 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014527 RID: 83239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003025")]
			private protected Effect effect
			{
				[Token(Token = "0x6014526")]
				[Address(RVA = "0xC856C0", Offset = "0xC842C0", VA = "0x180C856C0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6014527")]
				[Address(RVA = "0xC85BD0", Offset = "0xC847D0", VA = "0x180C85BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003026 RID: 12326
			// (get) Token: 0x06014528 RID: 83240 RVA: 0x000867C0 File Offset: 0x000849C0
			[Token(Token = "0x17003026")]
			protected ObjectPtr<Entity> owner
			{
				[Token(Token = "0x6014528")]
				[Address(RVA = "0xC85940", Offset = "0xC84540", VA = "0x180C85940")]
				get
				{
					return default(ObjectPtr<Entity>);
				}
			}

			// Token: 0x17003027 RID: 12327
			// (get) Token: 0x06014529 RID: 83241 RVA: 0x000867D8 File Offset: 0x000849D8
			[Token(Token = "0x17003027")]
			protected Effect.SpawnLocation spawnLocation
			{
				[Token(Token = "0x6014529")]
				[Address(RVA = "0xC85B00", Offset = "0xC84700", VA = "0x180C85B00")]
				get
				{
					return Effect.SpawnLocation.NONE;
				}
			}

			// Token: 0x17003028 RID: 12328
			// (get) Token: 0x0601452A RID: 83242 RVA: 0x000867F0 File Offset: 0x000849F0
			// (set) Token: 0x0601452B RID: 83243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003028")]
			protected bool isPaused
			{
				[Token(Token = "0x601452A")]
				[Address(RVA = "0xC85890", Offset = "0xC84490", VA = "0x180C85890")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601452B")]
				[Address(RVA = "0xC85C50", Offset = "0xC84850", VA = "0x180C85C50")]
				set
				{
				}
			}

			// Token: 0x17003029 RID: 12329
			// (get) Token: 0x0601452C RID: 83244 RVA: 0x00086808 File Offset: 0x00084A08
			[Token(Token = "0x17003029")]
			protected float playbackSpeed
			{
				[Token(Token = "0x601452C")]
				[Address(RVA = "0xC85A10", Offset = "0xC84610", VA = "0x180C85A10")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700302A RID: 12330
			// (get) Token: 0x0601452D RID: 83245 RVA: 0x00086820 File Offset: 0x00084A20
			[Token(Token = "0x1700302A")]
			public bool isFinished
			{
				[Token(Token = "0x601452D")]
				[Address(RVA = "0xC85720", Offset = "0xC84320", VA = "0x180C85720")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601452E RID: 83246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601452E")]
			[Address(RVA = "0xC85180", Offset = "0xC83D80", VA = "0x180C85180", Slot = "4")]
			public virtual void Init(Effect effect)
			{
			}

			// Token: 0x0601452F RID: 83247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601452F")]
			[Address(RVA = "0xC82030", Offset = "0xC80C30", VA = "0x180C82030", Slot = "5")]
			public virtual void OnPlay()
			{
			}

			// Token: 0x06014530 RID: 83248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014530")]
			[Address(RVA = "0xC81FD0", Offset = "0xC80BD0", VA = "0x180C81FD0", Slot = "6")]
			public virtual void OnFinish()
			{
			}

			// Token: 0x06014531 RID: 83249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014531")]
			[Address(RVA = "0xC852F0", Offset = "0xC83EF0", VA = "0x180C852F0", Slot = "7")]
			public virtual void OnRecycle()
			{
			}

			// Token: 0x06014532 RID: 83250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014532")]
			[Address(RVA = "0xC85230", Offset = "0xC83E30", VA = "0x180C85230", Slot = "8")]
			public virtual void OnPaused(bool paused)
			{
			}

			// Token: 0x06014533 RID: 83251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014533")]
			[Address(RVA = "0xC85290", Offset = "0xC83E90", VA = "0x180C85290", Slot = "9")]
			public virtual void OnPostImport()
			{
			}

			// Token: 0x06014534 RID: 83252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014534")]
			[Address(RVA = "0xC85350", Offset = "0xC83F50", VA = "0x180C85350")]
			protected void SetBehaviourPause(bool paused)
			{
			}

			// Token: 0x06014535 RID: 83253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014535")]
			[Address(RVA = "0xC84F80", Offset = "0xC83B80", VA = "0x180C84F80")]
			protected void FaceTo(Vector3 direction)
			{
			}

			// Token: 0x06014536 RID: 83254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014536")]
			[Address(RVA = "0xC85090", Offset = "0xC83C90", VA = "0x180C85090")]
			protected void Flip(bool flip)
			{
			}

			// Token: 0x06014537 RID: 83255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014537")]
			[Address(RVA = "0xC85660", Offset = "0xC84260", VA = "0x180C85660")]
			public Behaviour()
			{
			}

			// Token: 0x04017F48 RID: 98120
			[Token(Token = "0x4017F48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_effect;

			// Token: 0x04017F49 RID: 98121
			[Token(Token = "0x4017F49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_effect;

			// Token: 0x04017F4A RID: 98122
			[Token(Token = "0x4017F4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x04017F4B RID: 98123
			[Token(Token = "0x4017F4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_spawnLocation;

			// Token: 0x04017F4C RID: 98124
			[Token(Token = "0x4017F4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isPaused;

			// Token: 0x04017F4D RID: 98125
			[Token(Token = "0x4017F4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_isPaused;

			// Token: 0x04017F4E RID: 98126
			[Token(Token = "0x4017F4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_playbackSpeed;

			// Token: 0x04017F4F RID: 98127
			[Token(Token = "0x4017F4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_isFinished;

			// Token: 0x04017F50 RID: 98128
			[Token(Token = "0x4017F50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04017F51 RID: 98129
			[Token(Token = "0x4017F51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnPlay;

			// Token: 0x04017F52 RID: 98130
			[Token(Token = "0x4017F52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnFinish;

			// Token: 0x04017F53 RID: 98131
			[Token(Token = "0x4017F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x04017F54 RID: 98132
			[Token(Token = "0x4017F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnPaused;

			// Token: 0x04017F55 RID: 98133
			[Token(Token = "0x4017F55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnPostImport;

			// Token: 0x04017F56 RID: 98134
			[Token(Token = "0x4017F56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_SetBehaviourPause;

			// Token: 0x04017F57 RID: 98135
			[Token(Token = "0x4017F57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_FaceTo;

			// Token: 0x04017F58 RID: 98136
			[Token(Token = "0x4017F58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_Flip;

			// Token: 0x04017F59 RID: 98137
			[Token(Token = "0x4017F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003205 RID: 12805
		[Token(Token = "0x2003205")]
		public enum SpawnLocation
		{
			// Token: 0x04017F5B RID: 98139
			[Token(Token = "0x4017F5B")]
			NONE,
			// Token: 0x04017F5C RID: 98140
			[Token(Token = "0x4017F5C")]
			FOOT_POINT,
			// Token: 0x04017F5D RID: 98141
			[Token(Token = "0x4017F5D")]
			HIT_POINT,
			// Token: 0x04017F5E RID: 98142
			[Token(Token = "0x4017F5E")]
			MUZZLE_POINT,
			// Token: 0x04017F5F RID: 98143
			[Token(Token = "0x4017F5F")]
			HEAD_POINT,
			// Token: 0x04017F60 RID: 98144
			[Token(Token = "0x4017F60")]
			GROUND_CENTER,
			// Token: 0x04017F61 RID: 98145
			[Token(Token = "0x4017F61")]
			MUZZLE_POINT_WITHOUT_ROTATION,
			// Token: 0x04017F62 RID: 98146
			[Token(Token = "0x4017F62")]
			GROUND_CENTER_WITH_ZERO_HEIGHT,
			// Token: 0x04017F63 RID: 98147
			[Token(Token = "0x4017F63")]
			MP_SPECIAL_0,
			// Token: 0x04017F64 RID: 98148
			[Token(Token = "0x4017F64")]
			MP_SPECIAL_1,
			// Token: 0x04017F65 RID: 98149
			[Token(Token = "0x4017F65")]
			MP_SPECIAL_2,
			// Token: 0x04017F66 RID: 98150
			[Token(Token = "0x4017F66")]
			MP_SPECIAL_3,
			// Token: 0x04017F67 RID: 98151
			[Token(Token = "0x4017F67")]
			CAMERA,
			// Token: 0x04017F68 RID: 98152
			[Token(Token = "0x4017F68")]
			MP_SPECIAL_4,
			// Token: 0x04017F69 RID: 98153
			[Token(Token = "0x4017F69")]
			MP_SPECIAL_5,
			// Token: 0x04017F6A RID: 98154
			[Token(Token = "0x4017F6A")]
			MP_SPECIAL_6,
			// Token: 0x04017F6B RID: 98155
			[Token(Token = "0x4017F6B")]
			MP_SPECIAL_7,
			// Token: 0x04017F6C RID: 98156
			[Token(Token = "0x4017F6C")]
			TILE_CENTER,
			// Token: 0x04017F6D RID: 98157
			[Token(Token = "0x4017F6D")]
			MP_SPECIAL_8,
			// Token: 0x04017F6E RID: 98158
			[Token(Token = "0x4017F6E")]
			MP_SPECIAL_9,
			// Token: 0x04017F6F RID: 98159
			[Token(Token = "0x4017F6F")]
			MP_SPECIAL_10,
			// Token: 0x04017F70 RID: 98160
			[Token(Token = "0x4017F70")]
			MP_SPECIAL_11,
			// Token: 0x04017F71 RID: 98161
			[Token(Token = "0x4017F71")]
			MP_SPECIAL_12,
			// Token: 0x04017F72 RID: 98162
			[Token(Token = "0x4017F72")]
			MP_SPECIAL_13,
			// Token: 0x04017F73 RID: 98163
			[Token(Token = "0x4017F73")]
			MP_SPECIAL_14,
			// Token: 0x04017F74 RID: 98164
			[Token(Token = "0x4017F74")]
			MP_SPECIAL_15,
			// Token: 0x04017F75 RID: 98165
			[Token(Token = "0x4017F75")]
			GROUND_CENTER_WITH_TILE_HEIGHT
		}

		// Token: 0x02003206 RID: 12806
		[Token(Token = "0x2003206")]
		[Serializable]
		private class SubFXDelayConfig
		{
			// Token: 0x06014538 RID: 83256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014538")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SubFXDelayConfig()
			{
			}

			// Token: 0x04017F76 RID: 98166
			[Token(Token = "0x4017F76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x04017F77 RID: 98167
			[Token(Token = "0x4017F77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float delayTime;
		}

		// Token: 0x02003207 RID: 12807
		[Token(Token = "0x2003207")]
		private class SubFXDelay
		{
			// Token: 0x06014539 RID: 83257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014539")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SubFXDelay()
			{
			}

			// Token: 0x04017F78 RID: 98168
			[Token(Token = "0x4017F78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Effect.SubFXDelayConfig data;

			// Token: 0x04017F79 RID: 98169
			[Token(Token = "0x4017F79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float delayRuntime;

			// Token: 0x04017F7A RID: 98170
			[Token(Token = "0x4017F7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Coroutine coroutine;
		}
	}
}
