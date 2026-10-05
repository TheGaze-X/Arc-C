using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200590E RID: 22798
	[Token(Token = "0x200590E")]
	public class CrisisV2MapPage : StateEnginePage
	{
		// Token: 0x06021389 RID: 136073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021389")]
		[Address(RVA = "0x1B90CA0", Offset = "0x1B8F8A0", VA = "0x181B90CA0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602138A RID: 136074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602138A")]
		[Address(RVA = "0x1B90C10", Offset = "0x1B8F810", VA = "0x181B90C10")]
		public static CrisisV2MapPage.Param LoadParamFromBundle(DataBundle bundle)
		{
			return null;
		}

		// Token: 0x0602138B RID: 136075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602138B")]
		[Address(RVA = "0x1B90D90", Offset = "0x1B8F990", VA = "0x181B90D90")]
		public static UIPageControllerParam SceneParamToCrisisV2Map(CrisisV2MapPage.Param param)
		{
			return null;
		}

		// Token: 0x0602138C RID: 136076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602138C")]
		[Address(RVA = "0x1B90A20", Offset = "0x1B8F620", VA = "0x181B90A20")]
		public static DataBundle CreateRecoverDataBundleForBattle(string mapId)
		{
			return null;
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x0602138D RID: 136077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DF8")]
		public string initMapId
		{
			[Token(Token = "0x602138D")]
			[Address(RVA = "0x1B91350", Offset = "0x1B8FF50", VA = "0x181B91350")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602138E RID: 136078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602138E")]
		[Address(RVA = "0x1B90B60", Offset = "0x1B8F760", VA = "0x181B90B60", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602138F RID: 136079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602138F")]
		[Address(RVA = "0x1B91240", Offset = "0x1B8FE40", VA = "0x181B91240")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x06021390 RID: 136080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021390")]
		[Address(RVA = "0x1B910E0", Offset = "0x1B8FCE0", VA = "0x181B910E0")]
		private IEnumerator _JumpToEntryState()
		{
			return null;
		}

		// Token: 0x06021391 RID: 136081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021391")]
		[Address(RVA = "0x1B91190", Offset = "0x1B8FD90", VA = "0x181B91190")]
		private IEnumerator _JumpToMapState()
		{
			return null;
		}

		// Token: 0x06021392 RID: 136082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021392")]
		[Address(RVA = "0x1B912F0", Offset = "0x1B8FEF0", VA = "0x181B912F0")]
		public CrisisV2MapPage()
		{
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021394")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021395")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0402D401 RID: 185345
		[Token(Token = "0x402D401")]
		[FieldOffset(Offset = "0xF0")]
		private string m_initMapId;

		// Token: 0x0402D402 RID: 185346
		[Token(Token = "0x402D402")]
		[FieldOffset(Offset = "0xF8")]
		private UIPopupWindow.ReentrantFloatRef m_globalBlackMask;

		// Token: 0x0402D403 RID: 185347
		[Token(Token = "0x402D403")]
		private const string KEY_PARAM_BUNDLE = "key_crisis_v2_map_param";

		// Token: 0x0402D404 RID: 185348
		[Token(Token = "0x402D404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0402D405 RID: 185349
		[Token(Token = "0x402D405")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadParamFromBundle;

		// Token: 0x0402D406 RID: 185350
		[Token(Token = "0x402D406")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SceneParamToCrisisV2Map;

		// Token: 0x0402D407 RID: 185351
		[Token(Token = "0x402D407")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateRecoverDataBundleForBattle;

		// Token: 0x0402D408 RID: 185352
		[Token(Token = "0x402D408")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_initMapId;

		// Token: 0x0402D409 RID: 185353
		[Token(Token = "0x402D409")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0402D40A RID: 185354
		[Token(Token = "0x402D40A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x0402D40B RID: 185355
		[Token(Token = "0x402D40B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__JumpToEntryState;

		// Token: 0x0402D40C RID: 185356
		[Token(Token = "0x402D40C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__JumpToMapState;

		// Token: 0x0402D40D RID: 185357
		[Token(Token = "0x402D40D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200590F RID: 22799
		[Token(Token = "0x200590F")]
		public class Param
		{
			// Token: 0x06021396 RID: 136086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021396")]
			[Address(RVA = "0x1B9C2F0", Offset = "0x1B9AEF0", VA = "0x181B9C2F0")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06021397 RID: 136087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021397")]
			[Address(RVA = "0x1B9C1D0", Offset = "0x1B9ADD0", VA = "0x181B9C1D0")]
			public static CrisisV2MapPage.Param Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06021398 RID: 136088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021398")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0402D40E RID: 185358
			[Token(Token = "0x402D40E")]
			[FieldOffset(Offset = "0x10")]
			public string mapId;
		}
	}
}
