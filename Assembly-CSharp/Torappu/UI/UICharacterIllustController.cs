using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Gacha;
using Torappu.Resource;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034E5 RID: 13541
	[Token(Token = "0x20034E5")]
	public class UICharacterIllustController : SingletonMonoBehaviour<UICharacterIllustController>, ISingletonNotAutoCreate
	{
		// Token: 0x06015945 RID: 88389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015945")]
		[Address(RVA = "0xE09AD0", Offset = "0xE086D0", VA = "0x180E09AD0", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x06015946 RID: 88390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015946")]
		[Address(RVA = "0xE0B460", Offset = "0xE0A060", VA = "0x180E0B460")]
		private void Update()
		{
		}

		// Token: 0x06015947 RID: 88391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015947")]
		[Address(RVA = "0xE0ADA0", Offset = "0xE099A0", VA = "0x180E0ADA0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06015948 RID: 88392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015948")]
		[Address(RVA = "0xE0DAA0", Offset = "0xE0C6A0", VA = "0x180E0DAA0")]
		private void _OnSettingChanged(SettingConstVars.SettingType settingType)
		{
		}

		// Token: 0x06015949 RID: 88393 RVA: 0x0008CAA8 File Offset: 0x0008ACA8
		[Token(Token = "0x6015949")]
		[Address(RVA = "0xE0A0C0", Offset = "0xE08CC0", VA = "0x180E0A0C0")]
		public UICharacterIllustController.Config GetConfig()
		{
			return default(UICharacterIllustController.Config);
		}

		// Token: 0x0601594A RID: 88394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594A")]
		[Address(RVA = "0xE0C6C0", Offset = "0xE0B2C0", VA = "0x180E0C6C0")]
		private UICharacterIllust _GachaOnlyLoadChrIllust(AbstractAssetLoader assetLoader, GachaController.CharacterConfig config, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601594B RID: 88395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594B")]
		[Address(RVA = "0xE0C9E0", Offset = "0xE0B5E0", VA = "0x180E0C9E0")]
		private UICharacterIllust _GachaOnlyLoadChrStaticIllust(AbstractAssetLoader assetLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601594C RID: 88396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594C")]
		[Address(RVA = "0xE0BE60", Offset = "0xE0AA60", VA = "0x180E0BE60")]
		private UICharacterIllust _BattleFinishOnlyLoadChrStaticIllust(CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601594D RID: 88397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594D")]
		[Address(RVA = "0xE0CD10", Offset = "0xE0B910", VA = "0x180E0CD10")]
		private UICharacterIllust _HomeOnlyLoadChrIllust(UICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601594E RID: 88398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594E")]
		[Address(RVA = "0xE0E860", Offset = "0xE0D460", VA = "0x180E0E860")]
		private UICharacterIllust _SkinShopOnlyLoadChrIllust(UICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601594F RID: 88399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601594F")]
		[Address(RVA = "0xE0D3D0", Offset = "0xE0BFD0", VA = "0x180E0D3D0")]
		private UICharacterIllust _LoadChrIllust(IUICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015950 RID: 88400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015950")]
		[Address(RVA = "0xE0D140", Offset = "0xE0BD40", VA = "0x180E0D140")]
		private UICharacterIllust _LoadChrDynamicIllust(CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015951 RID: 88401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015951")]
		[Address(RVA = "0xE0D530", Offset = "0xE0C130", VA = "0x180E0D530")]
		private UICharacterIllust _LoadChrStaticIllust(IUICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015952 RID: 88402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015952")]
		[Address(RVA = "0xE0D860", Offset = "0xE0C460", VA = "0x180E0D860")]
		private UICharacterIllust _LoadNpcStaticIllust(UICharacterIllustController.NPCConfig npcConfig)
		{
			return null;
		}

		// Token: 0x06015953 RID: 88403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015953")]
		[Address(RVA = "0xE0E290", Offset = "0xE0CE90", VA = "0x180E0E290")]
		private void _RefreshConfig()
		{
		}

		// Token: 0x06015954 RID: 88404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015954")]
		[Address(RVA = "0xE0B810", Offset = "0xE0A410", VA = "0x180E0B810")]
		private void _ActivateIllust(UICharacterIllust targetIllust, bool fastMode)
		{
		}

		// Token: 0x06015955 RID: 88405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015955")]
		[Address(RVA = "0xE0C160", Offset = "0xE0AD60", VA = "0x180E0C160")]
		private void _ChangeDynIllustTarget(UICharacterIllust targetIllust)
		{
		}

		// Token: 0x06015956 RID: 88406 RVA: 0x0008CAC0 File Offset: 0x0008ACC0
		[Token(Token = "0x6015956")]
		[Address(RVA = "0xE0CE70", Offset = "0xE0BA70", VA = "0x180E0CE70")]
		private bool _IsActiveIllust(UICharacterIllust illust)
		{
			return default(bool);
		}

		// Token: 0x06015957 RID: 88407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015957")]
		[Address(RVA = "0xE0BDC0", Offset = "0xE0A9C0", VA = "0x180E0BDC0")]
		private void _AddIllustRef(UICharacterIllust illust)
		{
		}

		// Token: 0x06015958 RID: 88408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015958")]
		[Address(RVA = "0xE0E480", Offset = "0xE0D080", VA = "0x180E0E480")]
		private void _RemoveIllustRef(UICharacterIllust illust)
		{
		}

		// Token: 0x06015959 RID: 88409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015959")]
		[Address(RVA = "0xE0E550", Offset = "0xE0D150", VA = "0x180E0E550")]
		private void _RemoveInvalidIllustRef()
		{
		}

		// Token: 0x0601595A RID: 88410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601595A")]
		[Address(RVA = "0xE0E100", Offset = "0xE0CD00", VA = "0x180E0E100")]
		private void _PostProcessOnRemove()
		{
		}

		// Token: 0x0601595B RID: 88411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601595B")]
		[Address(RVA = "0xE0E690", Offset = "0xE0D290", VA = "0x180E0E690")]
		private void _ResumeDynInstanceIfNecessary()
		{
		}

		// Token: 0x0601595C RID: 88412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601595C")]
		[Address(RVA = "0xE0DD50", Offset = "0xE0C950", VA = "0x180E0DD50")]
		private void _PauseDynInstanceIfNecessary()
		{
		}

		// Token: 0x0601595D RID: 88413 RVA: 0x0008CAD8 File Offset: 0x0008ACD8
		[Token(Token = "0x601595D")]
		[Address(RVA = "0xE0C390", Offset = "0xE0AF90", VA = "0x180E0C390")]
		private bool _ContainsTarget(string targetIllustId)
		{
			return default(bool);
		}

		// Token: 0x0601595E RID: 88414 RVA: 0x0008CAF0 File Offset: 0x0008ACF0
		[Token(Token = "0x601595E")]
		[Address(RVA = "0xE0CFE0", Offset = "0xE0BBE0", VA = "0x180E0CFE0")]
		private bool _IsStaticTarget(string targetIllustId)
		{
			return default(bool);
		}

		// Token: 0x0601595F RID: 88415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601595F")]
		[Address(RVA = "0xE0B680", Offset = "0xE0A280", VA = "0x180E0B680")]
		private void _ActivateIllustImmediately()
		{
		}

		// Token: 0x06015960 RID: 88416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015960")]
		[Address(RVA = "0xE0B5D0", Offset = "0xE0A1D0", VA = "0x180E0B5D0")]
		private IEnumerator _ActivateIllustCoroutine()
		{
			return null;
		}

		// Token: 0x06015961 RID: 88417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015961")]
		[Address(RVA = "0xE0DB20", Offset = "0xE0C720", VA = "0x180E0DB20")]
		private void _PauseDynIllustByDynEntrance(bool pause)
		{
		}

		// Token: 0x06015962 RID: 88418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015962")]
		[Address(RVA = "0xE0DF20", Offset = "0xE0CB20", VA = "0x180E0DF20")]
		private void _PlayStartByDynEntrance(CharUISkinStruct skin)
		{
		}

		// Token: 0x06015963 RID: 88419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015963")]
		[Address(RVA = "0xE0C4E0", Offset = "0xE0B0E0", VA = "0x180E0C4E0")]
		private void _FetchDynIllustList(List<UICharacterDynIllust> outputList)
		{
		}

		// Token: 0x06015964 RID: 88420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015964")]
		[Address(RVA = "0xE09F00", Offset = "0xE08B00", VA = "0x180E09F00")]
		public static UICharacterIllust GachaOnlyLoadChrIllust(AbstractAssetLoader assetLoader, GachaController.CharacterConfig config, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015965 RID: 88421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015965")]
		[Address(RVA = "0xE09C50", Offset = "0xE08850", VA = "0x180E09C50")]
		public static UICharacterIllust BattleFinishOnlyLoadChrStaticIllust(CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015966 RID: 88422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015966")]
		[Address(RVA = "0xE0A310", Offset = "0xE08F10", VA = "0x180E0A310")]
		public static UICharacterIllust HomeOnlyLoadChrIllust(UICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015967 RID: 88423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015967")]
		[Address(RVA = "0xE0B1C0", Offset = "0xE09DC0", VA = "0x180E0B1C0")]
		public static UICharacterIllust SkinShopOnlyLoadChrIllust(UICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015968 RID: 88424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015968")]
		[Address(RVA = "0xE0A610", Offset = "0xE09210", VA = "0x180E0A610")]
		public static UICharacterIllust LoadChrIllust(IUICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06015969 RID: 88425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015969")]
		[Address(RVA = "0xE0A8B0", Offset = "0xE094B0", VA = "0x180E0A8B0")]
		public static UICharacterIllust LoadChrStaticIllust(IUICharacterIllustLoader staticIllustLoader, CharUISkinStruct skin, RectTransform parent)
		{
			return null;
		}

		// Token: 0x0601596A RID: 88426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601596A")]
		[Address(RVA = "0xE0AA40", Offset = "0xE09640", VA = "0x180E0AA40")]
		public static UICharacterIllust LoadNpcStaticIllust(UICharacterIllustController.NPCConfig config)
		{
			return null;
		}

		// Token: 0x0601596B RID: 88427 RVA: 0x0008CB08 File Offset: 0x0008AD08
		[Token(Token = "0x601596B")]
		[Address(RVA = "0xE0A140", Offset = "0xE08D40", VA = "0x180E0A140")]
		public static UICharacterIllustController.Config GetIllustConfig()
		{
			return default(UICharacterIllustController.Config);
		}

		// Token: 0x0601596C RID: 88428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601596C")]
		[Address(RVA = "0xE0AF60", Offset = "0xE09B60", VA = "0x180E0AF60")]
		public static void PauseDynIllustByDynEntrance(bool pause)
		{
		}

		// Token: 0x0601596D RID: 88429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601596D")]
		[Address(RVA = "0xE0B080", Offset = "0xE09C80", VA = "0x180E0B080")]
		public static void PlayStartByDynEntrance(CharUISkinStruct skin)
		{
		}

		// Token: 0x0601596E RID: 88430 RVA: 0x0008CB20 File Offset: 0x0008AD20
		[Token(Token = "0x601596E")]
		[Address(RVA = "0xE0A5B0", Offset = "0xE091B0", VA = "0x180E0A5B0")]
		public static bool HomeOnlyUseDynIllust(UICharacterIllustController.LoadStrategy strategy)
		{
			return default(bool);
		}

		// Token: 0x0601596F RID: 88431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601596F")]
		[Address(RVA = "0xE09DC0", Offset = "0xE089C0", VA = "0x180E09DC0")]
		public static void DynIllustMgrOnlyFetchDynIllustList(List<UICharacterDynIllust> outputList)
		{
		}

		// Token: 0x06015970 RID: 88432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015970")]
		[Address(RVA = "0xE0E9B0", Offset = "0xE0D5B0", VA = "0x180E0E9B0")]
		public UICharacterIllustController()
		{
		}

		// Token: 0x04019E02 RID: 105986
		[Token(Token = "0x4019E02")]
		[FieldOffset(Offset = "0x18")]
		[Inspect]
		[ReadOnly]
		private List<UICharacterIllust> m_illusts;

		// Token: 0x04019E03 RID: 105987
		[Token(Token = "0x4019E03")]
		[FieldOffset(Offset = "0x20")]
		[Inspect]
		private UICharacterIllustController.Config m_config;

		// Token: 0x04019E04 RID: 105988
		[Token(Token = "0x4019E04")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[ReadOnly]
		private string m_activeIllustId;

		// Token: 0x04019E05 RID: 105989
		[Token(Token = "0x4019E05")]
		[FieldOffset(Offset = "0x38")]
		[Inspect]
		[ReadOnly]
		private bool m_pausedByDynEntrance;

		// Token: 0x04019E06 RID: 105990
		[Token(Token = "0x4019E06")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_activateIllustCoroutine;

		// Token: 0x04019E07 RID: 105991
		[Token(Token = "0x4019E07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019E08 RID: 105992
		[Token(Token = "0x4019E08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019E09 RID: 105993
		[Token(Token = "0x4019E09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019E0A RID: 105994
		[Token(Token = "0x4019E0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSettingChanged;

		// Token: 0x04019E0B RID: 105995
		[Token(Token = "0x4019E0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetConfig;

		// Token: 0x04019E0C RID: 105996
		[Token(Token = "0x4019E0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GachaOnlyLoadChrIllust;

		// Token: 0x04019E0D RID: 105997
		[Token(Token = "0x4019E0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GachaOnlyLoadChrStaticIllust;

		// Token: 0x04019E0E RID: 105998
		[Token(Token = "0x4019E0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BattleFinishOnlyLoadChrStaticIllust;

		// Token: 0x04019E0F RID: 105999
		[Token(Token = "0x4019E0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HomeOnlyLoadChrIllust;

		// Token: 0x04019E10 RID: 106000
		[Token(Token = "0x4019E10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SkinShopOnlyLoadChrIllust;

		// Token: 0x04019E11 RID: 106001
		[Token(Token = "0x4019E11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadChrIllust;

		// Token: 0x04019E12 RID: 106002
		[Token(Token = "0x4019E12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadChrDynamicIllust;

		// Token: 0x04019E13 RID: 106003
		[Token(Token = "0x4019E13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadChrStaticIllust;

		// Token: 0x04019E14 RID: 106004
		[Token(Token = "0x4019E14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadNpcStaticIllust;

		// Token: 0x04019E15 RID: 106005
		[Token(Token = "0x4019E15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshConfig;

		// Token: 0x04019E16 RID: 106006
		[Token(Token = "0x4019E16")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ActivateIllust;

		// Token: 0x04019E17 RID: 106007
		[Token(Token = "0x4019E17")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ChangeDynIllustTarget;

		// Token: 0x04019E18 RID: 106008
		[Token(Token = "0x4019E18")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsActiveIllust;

		// Token: 0x04019E19 RID: 106009
		[Token(Token = "0x4019E19")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AddIllustRef;

		// Token: 0x04019E1A RID: 106010
		[Token(Token = "0x4019E1A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RemoveIllustRef;

		// Token: 0x04019E1B RID: 106011
		[Token(Token = "0x4019E1B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RemoveInvalidIllustRef;

		// Token: 0x04019E1C RID: 106012
		[Token(Token = "0x4019E1C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PostProcessOnRemove;

		// Token: 0x04019E1D RID: 106013
		[Token(Token = "0x4019E1D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ResumeDynInstanceIfNecessary;

		// Token: 0x04019E1E RID: 106014
		[Token(Token = "0x4019E1E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PauseDynInstanceIfNecessary;

		// Token: 0x04019E1F RID: 106015
		[Token(Token = "0x4019E1F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ContainsTarget;

		// Token: 0x04019E20 RID: 106016
		[Token(Token = "0x4019E20")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__IsStaticTarget;

		// Token: 0x04019E21 RID: 106017
		[Token(Token = "0x4019E21")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ActivateIllustImmediately;

		// Token: 0x04019E22 RID: 106018
		[Token(Token = "0x4019E22")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ActivateIllustCoroutine;

		// Token: 0x04019E23 RID: 106019
		[Token(Token = "0x4019E23")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__PauseDynIllustByDynEntrance;

		// Token: 0x04019E24 RID: 106020
		[Token(Token = "0x4019E24")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__PlayStartByDynEntrance;

		// Token: 0x04019E25 RID: 106021
		[Token(Token = "0x4019E25")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FetchDynIllustList;

		// Token: 0x04019E26 RID: 106022
		[Token(Token = "0x4019E26")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GachaOnlyLoadChrIllust;

		// Token: 0x04019E27 RID: 106023
		[Token(Token = "0x4019E27")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_BattleFinishOnlyLoadChrStaticIllust;

		// Token: 0x04019E28 RID: 106024
		[Token(Token = "0x4019E28")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_HomeOnlyLoadChrIllust;

		// Token: 0x04019E29 RID: 106025
		[Token(Token = "0x4019E29")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SkinShopOnlyLoadChrIllust;

		// Token: 0x04019E2A RID: 106026
		[Token(Token = "0x4019E2A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_LoadChrIllust;

		// Token: 0x04019E2B RID: 106027
		[Token(Token = "0x4019E2B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadChrStaticIllust;

		// Token: 0x04019E2C RID: 106028
		[Token(Token = "0x4019E2C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_LoadNpcStaticIllust;

		// Token: 0x04019E2D RID: 106029
		[Token(Token = "0x4019E2D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetIllustConfig;

		// Token: 0x04019E2E RID: 106030
		[Token(Token = "0x4019E2E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_PauseDynIllustByDynEntrance;

		// Token: 0x04019E2F RID: 106031
		[Token(Token = "0x4019E2F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_PlayStartByDynEntrance;

		// Token: 0x04019E30 RID: 106032
		[Token(Token = "0x4019E30")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_HomeOnlyUseDynIllust;

		// Token: 0x04019E31 RID: 106033
		[Token(Token = "0x4019E31")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_DynIllustMgrOnlyFetchDynIllustList;

		// Token: 0x04019E32 RID: 106034
		[Token(Token = "0x4019E32")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034E6 RID: 13542
		[Token(Token = "0x20034E6")]
		public struct Config
		{
			// Token: 0x04019E33 RID: 106035
			[Token(Token = "0x4019E33")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public static readonly UICharacterIllustController.Config DEFAULT;

			// Token: 0x04019E34 RID: 106036
			[Token(Token = "0x4019E34")]
			[FieldOffset(Offset = "0x0")]
			public UICharacterIllustController.LoadStrategy loadStrategy;

			// Token: 0x04019E35 RID: 106037
			[Token(Token = "0x4019E35")]
			[FieldOffset(Offset = "0x4")]
			public bool dynIllustResourceAvailable;

			// Token: 0x04019E36 RID: 106038
			[Token(Token = "0x4019E36")]
			[FieldOffset(Offset = "0x5")]
			public bool ignoreStaticActivation;

			// Token: 0x04019E37 RID: 106039
			[Token(Token = "0x4019E37")]
			[FieldOffset(Offset = "0x8")]
			public float fadeDuration;
		}

		// Token: 0x020034E7 RID: 13543
		[Token(Token = "0x20034E7")]
		public struct NPCConfig
		{
			// Token: 0x04019E38 RID: 106040
			[Token(Token = "0x4019E38")]
			[FieldOffset(Offset = "0x0")]
			public UICharacterIllustLoader staticIllustLoader;

			// Token: 0x04019E39 RID: 106041
			[Token(Token = "0x4019E39")]
			[FieldOffset(Offset = "0x8")]
			public string npcId;

			// Token: 0x04019E3A RID: 106042
			[Token(Token = "0x4019E3A")]
			[FieldOffset(Offset = "0x10")]
			public IllustNPCResType resType;

			// Token: 0x04019E3B RID: 106043
			[Token(Token = "0x4019E3B")]
			[FieldOffset(Offset = "0x18")]
			public string npcIllustId;

			// Token: 0x04019E3C RID: 106044
			[Token(Token = "0x4019E3C")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform parent;
		}

		// Token: 0x020034E8 RID: 13544
		[Token(Token = "0x20034E8")]
		public class IllustHandler : IHotfixable
		{
			// Token: 0x06015972 RID: 88434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015972")]
			[Address(RVA = "0xE39330", Offset = "0xE37F30", VA = "0x180E39330")]
			public IllustHandler(UICharacterIllustController closure)
			{
			}

			// Token: 0x06015973 RID: 88435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015973")]
			[Address(RVA = "0xE39010", Offset = "0xE37C10", VA = "0x180E39010")]
			public void ActivateIllust(UICharacterIllust dynIllust, bool fastMode)
			{
			}

			// Token: 0x06015974 RID: 88436 RVA: 0x0008CB38 File Offset: 0x0008AD38
			[Token(Token = "0x6015974")]
			[Address(RVA = "0xE39150", Offset = "0xE37D50", VA = "0x180E39150")]
			public bool IsActiveIllust(UICharacterIllust illsut)
			{
				return default(bool);
			}

			// Token: 0x06015975 RID: 88437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015975")]
			[Address(RVA = "0xE39240", Offset = "0xE37E40", VA = "0x180E39240")]
			public void RemoveIllustRef(UICharacterIllust illust)
			{
			}

			// Token: 0x06015976 RID: 88438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015976")]
			[Address(RVA = "0xE392C0", Offset = "0xE37EC0", VA = "0x180E392C0")]
			public void ResumeDynInstanceIfNecessary()
			{
			}

			// Token: 0x06015977 RID: 88439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015977")]
			[Address(RVA = "0xE391D0", Offset = "0xE37DD0", VA = "0x180E391D0")]
			public void PauseDynInstanceIfNecessary()
			{
			}

			// Token: 0x06015978 RID: 88440 RVA: 0x0008CB50 File Offset: 0x0008AD50
			[Token(Token = "0x6015978")]
			[Address(RVA = "0xE390C0", Offset = "0xE37CC0", VA = "0x180E390C0")]
			public UICharacterIllustController.Config GetConfg()
			{
				return default(UICharacterIllustController.Config);
			}

			// Token: 0x04019E3D RID: 106045
			[Token(Token = "0x4019E3D")]
			[FieldOffset(Offset = "0x10")]
			private UICharacterIllustController m_closure;

			// Token: 0x04019E3E RID: 106046
			[Token(Token = "0x4019E3E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019E3F RID: 106047
			[Token(Token = "0x4019E3F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ActivateIllust;

			// Token: 0x04019E40 RID: 106048
			[Token(Token = "0x4019E40")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsActiveIllust;

			// Token: 0x04019E41 RID: 106049
			[Token(Token = "0x4019E41")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RemoveIllustRef;

			// Token: 0x04019E42 RID: 106050
			[Token(Token = "0x4019E42")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResumeDynInstanceIfNecessary;

			// Token: 0x04019E43 RID: 106051
			[Token(Token = "0x4019E43")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PauseDynInstanceIfNecessary;

			// Token: 0x04019E44 RID: 106052
			[Token(Token = "0x4019E44")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetConfg;
		}

		// Token: 0x020034E9 RID: 13545
		[Token(Token = "0x20034E9")]
		public enum LoadStrategy
		{
			// Token: 0x04019E46 RID: 106054
			[Token(Token = "0x4019E46")]
			DEFAULT,
			// Token: 0x04019E47 RID: 106055
			[Token(Token = "0x4019E47")]
			HOME_DYNAMIC_ONLY,
			// Token: 0x04019E48 RID: 106056
			[Token(Token = "0x4019E48")]
			STATIC_ONLY
		}
	}
}
