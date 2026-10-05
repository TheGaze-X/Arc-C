using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015F3 RID: 5619
	[Token(Token = "0x20015F3")]
	[LuaCallCSharp(GenFlag.No)]
	public static class Util
	{
		// Token: 0x06007F51 RID: 32593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F51")]
		[Address(RVA = "0x28A30D0", Offset = "0x28A1CD0", VA = "0x1828A30D0")]
		public static string Format(string fmt, params object[] args)
		{
			return null;
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x00038040 File Offset: 0x00036240
		[Token(Token = "0x6007F52")]
		[Address(RVA = "0x28A2EE0", Offset = "0x28A1AE0", VA = "0x1828A2EE0")]
		public static Color FormatColorFromData(string colorStr)
		{
			return default(Color);
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F53")]
		[Address(RVA = "0x28A4060", Offset = "0x28A2C60", VA = "0x1828A4060")]
		public static void SetColorWithoutAlpha(Graphic graphic, Color color)
		{
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F54")]
		[Address(RVA = "0x28A40E0", Offset = "0x28A2CE0", VA = "0x1828A40E0")]
		public static void SetGraphicAlpha(Graphic graphic, float alpha)
		{
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F55")]
		[Address(RVA = "0x28A3C10", Offset = "0x28A2810", VA = "0x1828A3C10")]
		public static void OpenUrl(string url)
		{
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F56")]
		[Address(RVA = "0x28A3740", Offset = "0x28A2340", VA = "0x1828A3740")]
		public static string GetUid()
		{
			return null;
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F57")]
		[Address(RVA = "0x28A4150", Offset = "0x28A2D50", VA = "0x1828A4150")]
		public static void SetNativeClipboard(string content)
		{
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x00038058 File Offset: 0x00036258
		[Token(Token = "0x6007F58")]
		[Address(RVA = "0x28A4250", Offset = "0x28A2E50", VA = "0x1828A4250")]
		public static bool TryExtractInviteCode(string inputStr, out string code)
		{
			return default(bool);
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x00038070 File Offset: 0x00036270
		[Token(Token = "0x6007F59")]
		[Address(RVA = "0x28A2B00", Offset = "0x28A1700", VA = "0x1828A2B00")]
		public static bool CheckIfInviteCodeValid(string code)
		{
			return default(bool);
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00038088 File Offset: 0x00036288
		[Token(Token = "0x6007F5A")]
		[Address(RVA = "0x28A37A0", Offset = "0x28A23A0", VA = "0x1828A37A0")]
		public static bool IsDestroyed(object obj)
		{
			return default(bool);
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F5B")]
		[Address(RVA = "0x28A2FD0", Offset = "0x28A1BD0", VA = "0x1828A2FD0")]
		public static string FormatNumberWithUnit(long number)
		{
			return null;
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F5C")]
		[Address(RVA = "0x28A3080", Offset = "0x28A1C80", VA = "0x1828A3080")]
		public static string FormatTimeDelta(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x000380A0 File Offset: 0x000362A0
		[Token(Token = "0x6007F5D")]
		[Address(RVA = "0x28A3FC0", Offset = "0x28A2BC0", VA = "0x1828A3FC0")]
		public static int Range(int min, int max)
		{
			return 0;
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x000380B8 File Offset: 0x000362B8
		[Token(Token = "0x6007F5E")]
		[Address(RVA = "0x28A3FB0", Offset = "0x28A2BB0", VA = "0x1828A3FB0")]
		public static float RangeFloat(float min, float max)
		{
			return 0f;
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F5F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void Log(string message)
		{
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F60")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void LogWarning(string message)
		{
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F61")]
		[Address(RVA = "0x28A3880", Offset = "0x28A2480", VA = "0x1828A3880")]
		public static void LogError(string message)
		{
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F62")]
		[Address(RVA = "0x28A38F0", Offset = "0x28A24F0", VA = "0x1828A38F0")]
		public static void LogHotfixError(string message)
		{
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F63")]
		[Address(RVA = "0x28A2ED0", Offset = "0x28A1AD0", VA = "0x1828A2ED0")]
		public static GameObject FindGlobalGameObject(string name)
		{
			return null;
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F64")]
		[Address(RVA = "0x28A2E90", Offset = "0x28A1A90", VA = "0x1828A2E90")]
		public static Transform FindChild(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F65")]
		[Address(RVA = "0x28A2EC0", Offset = "0x28A1AC0", VA = "0x1828A2EC0")]
		public static Transform FindDeepChild(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F66")]
		[Address(RVA = "0x28A2EB0", Offset = "0x28A1AB0", VA = "0x1828A2EB0")]
		public static Transform FindDeepChildContainsSubString(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F67")]
		[Address(RVA = "0x28A33D0", Offset = "0x28A1FD0", VA = "0x1828A33D0")]
		public static Component GetComponent(GameObject go, string component)
		{
			return null;
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F68")]
		[Address(RVA = "0x28A3390", Offset = "0x28A1F90", VA = "0x1828A3390")]
		public static Component GetComponentInChildren(GameObject go, Type componentType)
		{
			return null;
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F69")]
		[Address(RVA = "0x28A33B0", Offset = "0x28A1FB0", VA = "0x1828A33B0")]
		public static Component GetComponentInParent(GameObject go, Type componentType)
		{
			return null;
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6A")]
		[Address(RVA = "0x28A3FD0", Offset = "0x28A2BD0", VA = "0x1828A3FD0")]
		public static void SetActiveIfNecessary(GameObject gameObject, bool isActive)
		{
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6B")]
		[Address(RVA = "0x28A2C00", Offset = "0x28A1800", VA = "0x1828A2C00")]
		public static void ClearAllChildren(Transform parent)
		{
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F6C")]
		[Address(RVA = "0x28A2CC0", Offset = "0x28A18C0", VA = "0x1828A2CC0")]
		public static LuaTable ConvertJObjectToLuaTable(JObject jObj)
		{
			return null;
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x000380D0 File Offset: 0x000362D0
		[Token(Token = "0x6007F6D")]
		[Address(RVA = "0x28A4200", Offset = "0x28A2E00", VA = "0x1828A4200")]
		public static long ToTimeStamp(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x000380E8 File Offset: 0x000362E8
		[Token(Token = "0x6007F6E")]
		[Address(RVA = "0x28A41B0", Offset = "0x28A2DB0", VA = "0x1828A41B0")]
		public static DateTime ToDateTime(long ts)
		{
			return default(DateTime);
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F6F")]
		[Address(RVA = "0x28A2F50", Offset = "0x28A1B50", VA = "0x1828A2F50")]
		public static string FormatDateTimeyyyyMMddHHmm(long ts)
		{
			return null;
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x00038100 File Offset: 0x00036300
		[Token(Token = "0x6007F70")]
		[Address(RVA = "0x28A3450", Offset = "0x28A2050", VA = "0x1828A3450")]
		public static long GetCurrentTs()
		{
			return 0L;
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F71")]
		[Address(RVA = "0x28A29C0", Offset = "0x28A15C0", VA = "0x1828A29C0")]
		public static void AlignRectTransToPos(RectTransform trans, Vector3 pos)
		{
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F72")]
		[Address(RVA = "0x28A35C0", Offset = "0x28A21C0", VA = "0x1828A35C0")]
		public static string GetStringRes(string key)
		{
			return null;
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F73")]
		[Address(RVA = "0x28A3490", Offset = "0x28A2090", VA = "0x1828A3490")]
		public static string GetI18NText(string textId)
		{
			return null;
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x00038118 File Offset: 0x00036318
		[Token(Token = "0x6007F74")]
		[Address(RVA = "0x28A33F0", Offset = "0x28A1FF0", VA = "0x1828A33F0")]
		public static long GetCurrentTicks()
		{
			return 0L;
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F75")]
		[Address(RVA = "0x28A2A40", Offset = "0x28A1640", VA = "0x1828A2A40")]
		public static void BindPlayerDataListener(ILuaPlayerData luaPlayerData)
		{
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F76")]
		[Address(RVA = "0x28A3550", Offset = "0x28A2150", VA = "0x1828A3550")]
		public static string GetLoginInfoHash()
		{
			return null;
		}

		// Token: 0x06007F77 RID: 32631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F77")]
		[Address(RVA = "0x28A3030", Offset = "0x28A1C30", VA = "0x1828A3030")]
		public static string FormatRichTextFromData(string rawStr)
		{
			return null;
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F78")]
		[Address(RVA = "0x28A3830", Offset = "0x28A2430", VA = "0x1828A3830")]
		public static UIItemViewModel LoadItemFromItemBundle(ISharedItemModel sharedModel)
		{
			return null;
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F79")]
		[Address(RVA = "0x28A3500", Offset = "0x28A2100", VA = "0x1828A3500")]
		public static string GetItemName(string itemId)
		{
			return null;
		}

		// Token: 0x06007F7A RID: 32634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F7A")]
		[Address(RVA = "0x28A4160", Offset = "0x28A2D60", VA = "0x1828A4160")]
		public static void StartMiniWebApplication(MiniWebApplication.Params param)
		{
		}

		// Token: 0x06007F7B RID: 32635 RVA: 0x00038130 File Offset: 0x00036330
		[Token(Token = "0x6007F7B")]
		[Address(RVA = "0x28A3C20", Offset = "0x28A2820", VA = "0x1828A3C20")]
		public static bool OpenWebVideoPlayer(string videoId)
		{
			return default(bool);
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F7C")]
		[Address(RVA = "0x28A30E0", Offset = "0x28A1CE0", VA = "0x1828A30E0")]
		public static List<MissionData> GenerateActMissionListByActId(string actId)
		{
			return null;
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F7D")]
		[Address(RVA = "0x28A3B10", Offset = "0x28A2710", VA = "0x1828A3B10")]
		public static void OpenCrossAppSharePage(CrossAppSharePage.InputParam input)
		{
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F7E")]
		[Address(RVA = "0x28A3820", Offset = "0x28A2420", VA = "0x1828A3820")]
		public static string LoadCrossAppShareMissionId(string actId)
		{
			return null;
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x00038148 File Offset: 0x00036348
		[Token(Token = "0x6007F7F")]
		[Address(RVA = "0x28A2A50", Offset = "0x28A1650", VA = "0x1828A2A50")]
		public static bool CheckCrossDaysAndResync()
		{
			return default(bool);
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F80")]
		[Address(RVA = "0x28A3E80", Offset = "0x28A2A80", VA = "0x1828A3E80")]
		public static void PlayAvgBackWithMusic(string avgOperation)
		{
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F81")]
		[Address(RVA = "0x28A3D50", Offset = "0x28A2950", VA = "0x1828A3D50")]
		public static void PlayAvgBackToHomeScene(string avgOperation)
		{
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F82")]
		[Address(RVA = "0x28A2E80", Offset = "0x28A1A80", VA = "0x1828A2E80")]
		public static UIAssetLoader.Assets CreateLuaAssets(int instGroupId)
		{
			return null;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F83")]
		[Address(RVA = "0x28A42B0", Offset = "0x28A2EB0", VA = "0x1828A42B0")]
		public static void UnloadLuaAssets(UIAssetLoader.Assets assets)
		{
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F84")]
		[Address(RVA = "0x28A3960", Offset = "0x28A2560", VA = "0x1828A3960")]
		public static Image LuaControllerOnlyLoadChrIllust(CharUISkinStruct skin, UIAssetLoader.Assets assets, [Optional] Transform parent)
		{
			return null;
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F85")]
		[Address(RVA = "0x28A37F0", Offset = "0x28A23F0", VA = "0x1828A37F0")]
		public static UICharacterIllust LoadChrIllust(IUICharacterIllustLoader illustLoader, CharUISkinStruct skin, RectTransform content)
		{
			return null;
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F86")]
		[Address(RVA = "0x28A3840", Offset = "0x28A2440", VA = "0x1828A3840")]
		public static UICharacterIllust LoadStaticChrIllust(IUICharacterIllustLoader illustLoader, CharUISkinStruct skin, RectTransform content)
		{
			return null;
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F87")]
		[Address(RVA = "0x28A35B0", Offset = "0x28A21B0", VA = "0x1828A35B0")]
		public static Sprite GetPlayerAvatarSprite(AvatarInfo avatarInfo)
		{
			return null;
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00038160 File Offset: 0x00036360
		[Token(Token = "0x6007F88")]
		[Address(RVA = "0x28A3320", Offset = "0x28A1F20", VA = "0x1828A3320")]
		public static PlayerAvatarQuery GetAvatarQueryFromPlayerStatus(IPlayerStatus playerStatus)
		{
			return default(PlayerAvatarQuery);
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F89")]
		[Address(RVA = "0x28A2DD0", Offset = "0x28A19D0", VA = "0x1828A2DD0")]
		public static AvatarInfo CreateAvatarInfo(string typeStr, string id)
		{
			return null;
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8A")]
		[Address(RVA = "0x28A41A0", Offset = "0x28A2DA0", VA = "0x1828A41A0")]
		public static void TextToast(string content, float delay = 0f, bool useDeduplicate = true)
		{
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8B")]
		[Address(RVA = "0x28A4190", Offset = "0x28A2D90", VA = "0x1828A4190")]
		public static void TextToast(string content, bool useDeduplicate)
		{
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8C")]
		[Address(RVA = "0x28A3870", Offset = "0x28A2470", VA = "0x1828A3870")]
		public static void LockToast(string text, float delay = 0f)
		{
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F8D")]
		[Address(RVA = "0x28A42D0", Offset = "0x28A2ED0", VA = "0x1828A42D0")]
		public static void UnlockToast(string text, float delay = 0f)
		{
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00038178 File Offset: 0x00036378
		[Token(Token = "0x6007F8E")]
		[Address(RVA = "0x28A2B50", Offset = "0x28A1750", VA = "0x1828A2B50")]
		public static bool CheckTrack(string type, string id)
		{
			return default(bool);
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x00038190 File Offset: 0x00036390
		[Token(Token = "0x6007F8F")]
		[Address(RVA = "0x28A2BB0", Offset = "0x28A17B0", VA = "0x1828A2BB0")]
		public static bool CheckTracksByType(string type)
		{
			return default(bool);
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F90")]
		[Address(RVA = "0x28A2C10", Offset = "0x28A1810", VA = "0x1828A2C10")]
		public static void ConsumeTrack(string type, string id)
		{
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F91")]
		[Address(RVA = "0x28A2C70", Offset = "0x28A1870", VA = "0x1828A2C70")]
		public static void ConsumeTracksByType(string type)
		{
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x000381A8 File Offset: 0x000363A8
		[Token(Token = "0x6007F92")]
		[Address(RVA = "0x28A2AA0", Offset = "0x28A16A0", VA = "0x1828A2AA0")]
		public static bool CheckHasActivityNewInvite(string id)
		{
			return default(bool);
		}

		// Token: 0x04008108 RID: 33032
		[Token(Token = "0x4008108")]
		private const string MESSAGE_FORMAT = "[LUA] {0}";
	}
}
