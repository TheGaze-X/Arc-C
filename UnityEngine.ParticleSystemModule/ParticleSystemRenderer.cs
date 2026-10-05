using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	public sealed class ParticleSystemRenderer : Renderer
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x59BC9A0", Offset = "0x59BB5A0", VA = "0x1859BC9A0")]
		[Obsolete("EnableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void EnableVertexStreams(ParticleSystemVertexStreams streams)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x59BC990", Offset = "0x59BB590", VA = "0x1859BC990")]
		[Obsolete("DisableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void DisableVertexStreams(ParticleSystemVertexStreams streams)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x59BC7B0", Offset = "0x59BB3B0", VA = "0x1859BC7B0")]
		[Obsolete("AreVertexStreamsEnabled is deprecated.Use GetActiveVertexStreams instead.", false)]
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x59BCA00", Offset = "0x59BB600", VA = "0x1859BCA00")]
		[Obsolete("GetEnabledVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			return ParticleSystemVertexStreams.None;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x59BCD10", Offset = "0x59BB910", VA = "0x1859BCD10")]
		[Obsolete("Internal_SetVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x59BCAB0", Offset = "0x59BB6B0", VA = "0x1859BCAB0")]
		[Obsolete("Internal_GetVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			return ParticleSystemVertexStreams.None;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001AB RID: 427
		[Token(Token = "0x17000097")]
		[NativeName("RenderAlignment")]
		public extern ParticleSystemRenderSpace alignment { [Token(Token = "0x60001AA")] [Address(RVA = "0x59BD570", Offset = "0x59BC170", VA = "0x1859BD570")] [MethodImpl(4096)] get; [Token(Token = "0x60001AB")] [Address(RVA = "0x59BDBB0", Offset = "0x59BC7B0", VA = "0x1859BDBB0")] [MethodImpl(4096)] set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001AC RID: 428
		// (set) Token: 0x060001AD RID: 429
		[Token(Token = "0x17000098")]
		public extern ParticleSystemRenderMode renderMode { [Token(Token = "0x60001AC")] [Address(RVA = "0x59BD9F0", Offset = "0x59BC5F0", VA = "0x1859BD9F0")] [MethodImpl(4096)] get; [Token(Token = "0x60001AD")] [Address(RVA = "0x59BE0D0", Offset = "0x59BCCD0", VA = "0x1859BE0D0")] [MethodImpl(4096)] set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001AE RID: 430
		// (set) Token: 0x060001AF RID: 431
		[Token(Token = "0x17000099")]
		public extern ParticleSystemMeshDistribution meshDistribution { [Token(Token = "0x60001AE")] [Address(RVA = "0x59BD850", Offset = "0x59BC450", VA = "0x1859BD850")] [MethodImpl(4096)] get; [Token(Token = "0x60001AF")] [Address(RVA = "0x59BDEB0", Offset = "0x59BCAB0", VA = "0x1859BDEB0")] [MethodImpl(4096)] set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001B0 RID: 432
		// (set) Token: 0x060001B1 RID: 433
		[Token(Token = "0x1700009A")]
		public extern ParticleSystemSortMode sortMode { [Token(Token = "0x60001B0")] [Address(RVA = "0x59BDAB0", Offset = "0x59BC6B0", VA = "0x1859BDAB0")] [MethodImpl(4096)] get; [Token(Token = "0x60001B1")] [Address(RVA = "0x59BE1B0", Offset = "0x59BCDB0", VA = "0x1859BE1B0")] [MethodImpl(4096)] set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B2 RID: 434
		// (set) Token: 0x060001B3 RID: 435
		[Token(Token = "0x1700009B")]
		public extern float lengthScale { [Token(Token = "0x60001B2")] [Address(RVA = "0x59BD750", Offset = "0x59BC350", VA = "0x1859BD750")] [MethodImpl(4096)] get; [Token(Token = "0x60001B3")] [Address(RVA = "0x59BDDD0", Offset = "0x59BC9D0", VA = "0x1859BDDD0")] [MethodImpl(4096)] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B4 RID: 436
		// (set) Token: 0x060001B5 RID: 437
		[Token(Token = "0x1700009C")]
		public extern float velocityScale { [Token(Token = "0x60001B4")] [Address(RVA = "0x59BDB70", Offset = "0x59BC770", VA = "0x1859BDB70")] [MethodImpl(4096)] get; [Token(Token = "0x60001B5")] [Address(RVA = "0x59BE290", Offset = "0x59BCE90", VA = "0x1859BE290")] [MethodImpl(4096)] set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B6 RID: 438
		// (set) Token: 0x060001B7 RID: 439
		[Token(Token = "0x1700009D")]
		public extern float cameraVelocityScale { [Token(Token = "0x60001B6")] [Address(RVA = "0x59BD5F0", Offset = "0x59BC1F0", VA = "0x1859BD5F0")] [MethodImpl(4096)] get; [Token(Token = "0x60001B7")] [Address(RVA = "0x59BDC40", Offset = "0x59BC840", VA = "0x1859BDC40")] [MethodImpl(4096)] set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B8 RID: 440
		// (set) Token: 0x060001B9 RID: 441
		[Token(Token = "0x1700009E")]
		public extern float normalDirection { [Token(Token = "0x60001B8")] [Address(RVA = "0x59BD910", Offset = "0x59BC510", VA = "0x1859BD910")] [MethodImpl(4096)] get; [Token(Token = "0x60001B9")] [Address(RVA = "0x59BDF90", Offset = "0x59BCB90", VA = "0x1859BDF90")] [MethodImpl(4096)] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001BA RID: 442
		// (set) Token: 0x060001BB RID: 443
		[Token(Token = "0x1700009F")]
		public extern float shadowBias { [Token(Token = "0x60001BA")] [Address(RVA = "0x59BDA70", Offset = "0x59BC670", VA = "0x1859BDA70")] [MethodImpl(4096)] get; [Token(Token = "0x60001BB")] [Address(RVA = "0x59BE160", Offset = "0x59BCD60", VA = "0x1859BE160")] [MethodImpl(4096)] set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001BC RID: 444
		// (set) Token: 0x060001BD RID: 445
		[Token(Token = "0x170000A0")]
		public extern float sortingFudge { [Token(Token = "0x60001BC")] [Address(RVA = "0x59BDAF0", Offset = "0x59BC6F0", VA = "0x1859BDAF0")] [MethodImpl(4096)] get; [Token(Token = "0x60001BD")] [Address(RVA = "0x59BE1F0", Offset = "0x59BCDF0", VA = "0x1859BE1F0")] [MethodImpl(4096)] set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001BE RID: 446
		// (set) Token: 0x060001BF RID: 447
		[Token(Token = "0x170000A1")]
		public extern float minParticleSize { [Token(Token = "0x60001BE")] [Address(RVA = "0x59BD8D0", Offset = "0x59BC4D0", VA = "0x1859BD8D0")] [MethodImpl(4096)] get; [Token(Token = "0x60001BF")] [Address(RVA = "0x59BDF40", Offset = "0x59BCB40", VA = "0x1859BDF40")] [MethodImpl(4096)] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001C0 RID: 448
		// (set) Token: 0x060001C1 RID: 449
		[Token(Token = "0x170000A2")]
		public extern float maxParticleSize { [Token(Token = "0x60001C0")] [Address(RVA = "0x59BD7D0", Offset = "0x59BC3D0", VA = "0x1859BD7D0")] [MethodImpl(4096)] get; [Token(Token = "0x60001C1")] [Address(RVA = "0x59BDE60", Offset = "0x59BCA60", VA = "0x1859BDE60")] [MethodImpl(4096)] set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		public Vector3 pivot
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x59BD9A0", Offset = "0x59BC5A0", VA = "0x1859BD9A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x59BE080", Offset = "0x59BCC80", VA = "0x1859BE080")]
			set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public Vector3 flip
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x59BD6C0", Offset = "0x59BC2C0", VA = "0x1859BD6C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x59BDD30", Offset = "0x59BC930", VA = "0x1859BDD30")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001C6 RID: 454
		// (set) Token: 0x060001C7 RID: 455
		[Token(Token = "0x170000A5")]
		public extern SpriteMaskInteraction maskInteraction { [Token(Token = "0x60001C6")] [Address(RVA = "0x59BD790", Offset = "0x59BC390", VA = "0x1859BD790")] [MethodImpl(4096)] get; [Token(Token = "0x60001C7")] [Address(RVA = "0x59BDE20", Offset = "0x59BCA20", VA = "0x1859BDE20")] [MethodImpl(4096)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001C8 RID: 456
		// (set) Token: 0x060001C9 RID: 457
		[Token(Token = "0x170000A6")]
		public extern Material trailMaterial { [Token(Token = "0x60001C8")] [Address(RVA = "0x59BDB30", Offset = "0x59BC730", VA = "0x1859BDB30")] [MethodImpl(4096)] get; [Token(Token = "0x60001C9")] [Address(RVA = "0x59BE240", Offset = "0x59BCE40", VA = "0x1859BE240")] [MethodImpl(4096)] set; }

		// Token: 0x170000A7 RID: 167
		// (set) Token: 0x060001CA RID: 458
		[Token(Token = "0x170000A7")]
		internal extern Material oldTrailMaterial { [Token(Token = "0x60001CA")] [Address(RVA = "0x59BDFE0", Offset = "0x59BCBE0", VA = "0x1859BDFE0")] [MethodImpl(4096)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CC RID: 460
		[Token(Token = "0x170000A8")]
		public extern bool enableGPUInstancing { [Token(Token = "0x60001CB")] [Address(RVA = "0x59BD630", Offset = "0x59BC230", VA = "0x1859BD630")] [MethodImpl(4096)] get; [Token(Token = "0x60001CC")] [Address(RVA = "0x59BDC90", Offset = "0x59BC890", VA = "0x1859BDC90")] [MethodImpl(4096)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001CD RID: 461
		// (set) Token: 0x060001CE RID: 462
		[Token(Token = "0x170000A9")]
		public extern bool allowRoll { [Token(Token = "0x60001CD")] [Address(RVA = "0x59BD5B0", Offset = "0x59BC1B0", VA = "0x1859BD5B0")] [MethodImpl(4096)] get; [Token(Token = "0x60001CE")] [Address(RVA = "0x59BDBF0", Offset = "0x59BC7F0", VA = "0x1859BDBF0")] [MethodImpl(4096)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CF RID: 463
		// (set) Token: 0x060001D0 RID: 464
		[Token(Token = "0x170000AA")]
		public extern bool freeformStretching { [Token(Token = "0x60001CF")] [Address(RVA = "0x59BD710", Offset = "0x59BC310", VA = "0x1859BD710")] [MethodImpl(4096)] get; [Token(Token = "0x60001D0")] [Address(RVA = "0x59BDD80", Offset = "0x59BC980", VA = "0x1859BDD80")] [MethodImpl(4096)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001D1 RID: 465
		// (set) Token: 0x060001D2 RID: 466
		[Token(Token = "0x170000AB")]
		public extern bool rotateWithStretchDirection { [Token(Token = "0x60001D1")] [Address(RVA = "0x59BDA30", Offset = "0x59BC630", VA = "0x1859BDA30")] [MethodImpl(4096)] get; [Token(Token = "0x60001D2")] [Address(RVA = "0x59BE110", Offset = "0x59BCD10", VA = "0x1859BE110")] [MethodImpl(4096)] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D3 RID: 467
		// (set) Token: 0x060001D4 RID: 468
		[Token(Token = "0x170000AC")]
		public extern Mesh mesh { [Token(Token = "0x60001D3")] [Address(RVA = "0x59BD890", Offset = "0x59BC490", VA = "0x1859BD890")] [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x60001D4")] [Address(RVA = "0x59BDEF0", Offset = "0x59BCAF0", VA = "0x1859BDEF0")] [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x59BCA60", Offset = "0x59BB660", VA = "0x1859BCA60")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		[RequiredByNativeCode]
		[MethodImpl(4096)]
		public extern int GetMeshes([NotNull("ArgumentNullException")] [Out] Mesh[] meshes);

		// Token: 0x060001D6 RID: 470
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x59BD470", Offset = "0x59BC070", VA = "0x1859BD470")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetMeshes([NotNull("ArgumentNullException")] Mesh[] meshes, int size);

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x59BD4D0", Offset = "0x59BC0D0", VA = "0x1859BD4D0")]
		public void SetMeshes(Mesh[] meshes)
		{
		}

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x59BCA10", Offset = "0x59BB610", VA = "0x1859BCA10")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern int GetMeshWeightings([NotNull("ArgumentNullException")] [Out] float[] weightings);

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x59BD3B0", Offset = "0x59BBFB0", VA = "0x1859BD3B0")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetMeshWeightings([NotNull("ArgumentNullException")] float[] weightings, int size);

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x59BD410", Offset = "0x59BC010", VA = "0x1859BD410")]
		public void SetMeshWeightings(float[] weightings)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001DB RID: 475
		[Token(Token = "0x170000AD")]
		public extern int meshCount { [Token(Token = "0x60001DB")] [Address(RVA = "0x59BD810", Offset = "0x59BC410", VA = "0x1859BD810")] [MethodImpl(4096)] get; }

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x59BC840", Offset = "0x59BB440", VA = "0x1859BC840")]
		public void BakeMesh(Mesh mesh, bool useTransform = false)
		{
		}

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x59BC7D0", Offset = "0x59BB3D0", VA = "0x1859BC7D0")]
		[MethodImpl(4096)]
		public extern void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false);

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x59BC8B0", Offset = "0x59BB4B0", VA = "0x1859BC8B0")]
		public void BakeTrailsMesh(Mesh mesh, bool useTransform = false)
		{
		}

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x59BC920", Offset = "0x59BB520", VA = "0x1859BC920")]
		[MethodImpl(4096)]
		public extern void BakeTrailsMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false);

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E0 RID: 480
		[Token(Token = "0x170000AE")]
		public extern int activeVertexStreamsCount { [Token(Token = "0x60001E0")] [Address(RVA = "0x59BD530", Offset = "0x59BC130", VA = "0x1859BD530")] [MethodImpl(4096)] get; }

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x59BD360", Offset = "0x59BBF60", VA = "0x1859BD360")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams);

		// Token: 0x060001E2 RID: 482
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x59BC9B0", Offset = "0x59BB5B0", VA = "0x1859BC9B0")]
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void GetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams);

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ParticleSystemRenderer()
		{
		}

		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x59BD950", Offset = "0x59BC550", VA = "0x1859BD950")]
		[MethodImpl(4096)]
		private extern void get_pivot_Injected(out Vector3 ret);

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x59BE030", Offset = "0x59BCC30", VA = "0x1859BE030")]
		[MethodImpl(4096)]
		private extern void set_pivot_Injected(ref Vector3 value);

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x59BD670", Offset = "0x59BC270", VA = "0x1859BD670")]
		[MethodImpl(4096)]
		private extern void get_flip_Injected(out Vector3 ret);

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x59BDCE0", Offset = "0x59BC8E0", VA = "0x1859BDCE0")]
		[MethodImpl(4096)]
		private extern void set_flip_Injected(ref Vector3 value);
	}
}
