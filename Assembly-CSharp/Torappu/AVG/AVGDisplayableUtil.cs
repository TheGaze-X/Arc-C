using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E4F RID: 7759
	[Token(Token = "0x2001E4F")]
	public class AVGDisplayableUtil : IHotfixable
	{
		// Token: 0x0600BFE3 RID: 49123 RVA: 0x00046B90 File Offset: 0x00044D90
		[Token(Token = "0x600BFE3")]
		[Address(RVA = "0x33DD0E0", Offset = "0x33DBCE0", VA = "0x1833DD0E0")]
		public static AVGDisplayableType GenTypeFromRaw(string rawType)
		{
			return AVGDisplayableType.NONE;
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x00046BA8 File Offset: 0x00044DA8
		[Token(Token = "0x600BFE4")]
		[Address(RVA = "0x33DD610", Offset = "0x33DC210", VA = "0x1833DD610")]
		private static AVGDisplayableType _GenTypeFromAlias(string rawAlias)
		{
			return AVGDisplayableType.NONE;
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x00046BC0 File Offset: 0x00044DC0
		[Token(Token = "0x600BFE5")]
		[Address(RVA = "0x33DCFB0", Offset = "0x33DBBB0", VA = "0x1833DCFB0")]
		public static AVGDisplaySlot GenSlotFromRaw(string rawSlot)
		{
			return AVGDisplaySlot.NONE;
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x00046BD8 File Offset: 0x00044DD8
		[Token(Token = "0x600BFE6")]
		[Address(RVA = "0x33DD540", Offset = "0x33DC140", VA = "0x1833DD540")]
		private static AVGDisplaySlot _GenSlotFromAlias(string rawAlias)
		{
			return AVGDisplaySlot.NONE;
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFE7")]
		[Address(RVA = "0x33DD430", Offset = "0x33DC030", VA = "0x1833DD430")]
		public static string GetPrefabPathByType(AVGDisplayableType type, string name)
		{
			return null;
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFE8")]
		[Address(RVA = "0x33DD2A0", Offset = "0x33DBEA0", VA = "0x1833DD2A0")]
		public static ParticleEffect GenerateParticleEffect(ParticleEffect prefab, Transform container, AVGControllerSceneCanvas canvasEnum, int layer)
		{
			return null;
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE9")]
		[Address(RVA = "0x33DD770", Offset = "0x33DC370", VA = "0x1833DD770")]
		private static void _ProcessTimescale(Transform effectInstTrans)
		{
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEA")]
		[Address(RVA = "0x33DD9C0", Offset = "0x33DC5C0", VA = "0x1833DD9C0")]
		public AVGDisplayableUtil()
		{
		}

		// Token: 0x0400C13E RID: 49470
		[Token(Token = "0x400C13E")]
		private const string ANIMATE_TEXT_ALIAS = "animetext";

		// Token: 0x0400C13F RID: 49471
		[Token(Token = "0x400C13F")]
		private const string SPINE_TEXT_ALIAS = "spine";

		// Token: 0x0400C140 RID: 49472
		[Token(Token = "0x400C140")]
		private const string EFFECT_TEXT_ALIAS = "effect";

		// Token: 0x0400C141 RID: 49473
		[Token(Token = "0x400C141")]
		private const string BGEFFECT_TEXT_ALIAS = "bgeffect";

		// Token: 0x0400C142 RID: 49474
		[Token(Token = "0x400C142")]
		private const string BG_TEXT_ALIAS = "bg";

		// Token: 0x0400C143 RID: 49475
		[Token(Token = "0x400C143")]
		private const string ANIMATED_KV_TEXT_ALIAS = "animekv";

		// Token: 0x0400C144 RID: 49476
		[Token(Token = "0x400C144")]
		private const string BG_OVERLAY_ALIAS = "bgover";

		// Token: 0x0400C145 RID: 49477
		[Token(Token = "0x400C145")]
		private const string CHAR_OVERLAY_ALIAS = "charover";

		// Token: 0x0400C146 RID: 49478
		[Token(Token = "0x400C146")]
		private const string CG_OVERLAY_ALIAS = "cgover";

		// Token: 0x0400C147 RID: 49479
		[Token(Token = "0x400C147")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenTypeFromRaw;

		// Token: 0x0400C148 RID: 49480
		[Token(Token = "0x400C148")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenTypeFromAlias;

		// Token: 0x0400C149 RID: 49481
		[Token(Token = "0x400C149")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenSlotFromRaw;

		// Token: 0x0400C14A RID: 49482
		[Token(Token = "0x400C14A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenSlotFromAlias;

		// Token: 0x0400C14B RID: 49483
		[Token(Token = "0x400C14B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPrefabPathByType;

		// Token: 0x0400C14C RID: 49484
		[Token(Token = "0x400C14C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateParticleEffect;

		// Token: 0x0400C14D RID: 49485
		[Token(Token = "0x400C14D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessTimescale;

		// Token: 0x0400C14E RID: 49486
		[Token(Token = "0x400C14E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
