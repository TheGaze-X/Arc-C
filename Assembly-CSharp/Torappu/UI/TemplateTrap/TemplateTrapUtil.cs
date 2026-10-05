using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D35 RID: 15669
	[Token(Token = "0x2003D35")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class TemplateTrapUtil
	{
		// Token: 0x0601869D RID: 99997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601869D")]
		[Address(RVA = "0x10FEC00", Offset = "0x10FD800", VA = "0x1810FEC00")]
		public static string GetLocalTrackType(string domainId)
		{
			return null;
		}

		// Token: 0x0601869E RID: 99998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601869E")]
		[Address(RVA = "0x10FF050", Offset = "0x10FDC50", VA = "0x1810FF050")]
		public static string GetTrapViewId(string domainId)
		{
			return null;
		}

		// Token: 0x0601869F RID: 99999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601869F")]
		[Address(RVA = "0x10FEE80", Offset = "0x10FDA80", VA = "0x1810FEE80")]
		public static PlayerTemplateTrap.Domin GetTemplateTrapInfo(string domainId)
		{
			return null;
		}

		// Token: 0x060186A0 RID: 100000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186A0")]
		[Address(RVA = "0x10FEF90", Offset = "0x10FDB90", VA = "0x1810FEF90")]
		public static TemplateTrapView GetTemplateTrapViewPrefab(string groupId, bool isRetro, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060186A1 RID: 100001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186A1")]
		[Address(RVA = "0x10FF4B0", Offset = "0x10FE0B0", VA = "0x1810FF4B0")]
		private static TemplateTrapView _GetTemplateTrapViewPrefabForActivity(string groupId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060186A2 RID: 100002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186A2")]
		[Address(RVA = "0x10FF7D0", Offset = "0x10FE3D0", VA = "0x1810FF7D0")]
		private static TemplateTrapView _GetTemplateTrapViewPrefabForRetro(string groupId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060186A3 RID: 100003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186A3")]
		[Address(RVA = "0x10FEC90", Offset = "0x10FD890", VA = "0x1810FEC90")]
		public static RuneTable.PackedRuneData GetPackedRuneDataByTrapId(string domainId, string trapId)
		{
			return null;
		}

		// Token: 0x060186A4 RID: 100004 RVA: 0x0009A578 File Offset: 0x00098778
		[Token(Token = "0x60186A4")]
		[Address(RVA = "0x10FF3E0", Offset = "0x10FDFE0", VA = "0x1810FF3E0")]
		public static bool NeedTrapTrackPoint(string domainId, string trapId)
		{
			return default(bool);
		}

		// Token: 0x060186A5 RID: 100005 RVA: 0x0009A590 File Offset: 0x00098790
		[Token(Token = "0x60186A5")]
		[Address(RVA = "0x10FF2A0", Offset = "0x10FDEA0", VA = "0x1810FF2A0")]
		public static bool NeedAllTrapTrackPoint(string domainId, List<string> trapIds)
		{
			return default(bool);
		}

		// Token: 0x060186A6 RID: 100006 RVA: 0x0009A5A8 File Offset: 0x000987A8
		[Token(Token = "0x60186A6")]
		[Address(RVA = "0x10FF1D0", Offset = "0x10FDDD0", VA = "0x1810FF1D0")]
		public static bool NeedAllTrapTrackPoint(string domainId)
		{
			return default(bool);
		}

		// Token: 0x060186A7 RID: 100007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186A7")]
		[Address(RVA = "0x10FE5A0", Offset = "0x10FD1A0", VA = "0x1810FE5A0")]
		public static void ConsumeTrapUpdateTrackPoint(string domainId, string trapId)
		{
		}

		// Token: 0x060186A8 RID: 100008 RVA: 0x0009A5C0 File Offset: 0x000987C0
		[Token(Token = "0x60186A8")]
		[Address(RVA = "0x10FE380", Offset = "0x10FCF80", VA = "0x1810FE380")]
		public static bool CheckCurrentSelectIsSameAsSquad(ListDict<string, TemplateTrapViewModel> list, string domainId)
		{
			return default(bool);
		}

		// Token: 0x060186A9 RID: 100009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186A9")]
		[Address(RVA = "0x10FF0C0", Offset = "0x10FDCC0", VA = "0x1810FF0C0")]
		public static Sprite LoadCommonTemplateTrapSprite(string domainId, string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060186AA RID: 100010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186AA")]
		[Address(RVA = "0x10FE670", Offset = "0x10FD270", VA = "0x1810FE670")]
		public static List<string> GetCurrentStageTrapList(string stageId, bool isAutoMode, bool isRetro, out bool availFlag, out string groupId, out string domainId)
		{
			return null;
		}

		// Token: 0x0401DDDE RID: 122334
		[Token(Token = "0x401DDDE")]
		public const string TEMPLATE_TRAP_STATE_VIEW = "{0}_trap_state_view";

		// Token: 0x0401DDDF RID: 122335
		[Token(Token = "0x401DDDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetLocalTrackType;

		// Token: 0x0401DDE0 RID: 122336
		[Token(Token = "0x401DDE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTrapViewId;

		// Token: 0x0401DDE1 RID: 122337
		[Token(Token = "0x401DDE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTemplateTrapInfo;

		// Token: 0x0401DDE2 RID: 122338
		[Token(Token = "0x401DDE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTemplateTrapViewPrefab;

		// Token: 0x0401DDE3 RID: 122339
		[Token(Token = "0x401DDE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTemplateTrapViewPrefabForActivity;

		// Token: 0x0401DDE4 RID: 122340
		[Token(Token = "0x401DDE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTemplateTrapViewPrefabForRetro;

		// Token: 0x0401DDE5 RID: 122341
		[Token(Token = "0x401DDE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPackedRuneDataByTrapId;

		// Token: 0x0401DDE6 RID: 122342
		[Token(Token = "0x401DDE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NeedTrapTrackPoint;

		// Token: 0x0401DDE7 RID: 122343
		[Token(Token = "0x401DDE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NeedAllTrapTrackPoint;

		// Token: 0x0401DDE8 RID: 122344
		[Token(Token = "0x401DDE8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_NeedAllTrapTrackPoint;

		// Token: 0x0401DDE9 RID: 122345
		[Token(Token = "0x401DDE9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ConsumeTrapUpdateTrackPoint;

		// Token: 0x0401DDEA RID: 122346
		[Token(Token = "0x401DDEA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckCurrentSelectIsSameAsSquad;

		// Token: 0x0401DDEB RID: 122347
		[Token(Token = "0x401DDEB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadCommonTemplateTrapSprite;

		// Token: 0x0401DDEC RID: 122348
		[Token(Token = "0x401DDEC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCurrentStageTrapList;
	}
}
