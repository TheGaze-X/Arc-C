using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200616A RID: 24938
	[Token(Token = "0x200616A")]
	public class BossRushPage : StateEnginePage, IHotfixable
	{
		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x06023FE7 RID: 147431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054F8")]
		public string activityId
		{
			[Token(Token = "0x6023FE7")]
			[Address(RVA = "0x1EA4640", Offset = "0x1EA3240", VA = "0x181EA4640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023FE8 RID: 147432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FE8")]
		[Address(RVA = "0x1EA4320", Offset = "0x1EA2F20", VA = "0x181EA4320", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06023FE9 RID: 147433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FE9")]
		[Address(RVA = "0x1EA41E0", Offset = "0x1EA2DE0", VA = "0x181EA41E0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023FEA RID: 147434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FEA")]
		[Address(RVA = "0x1EA3D70", Offset = "0x1EA2970", VA = "0x181EA3D70")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06023FEB RID: 147435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FEB")]
		[Address(RVA = "0x1EA3EF0", Offset = "0x1EA2AF0", VA = "0x181EA3EF0")]
		public static List<UIPageStackParam.StackElement> GenPageStackToJumpBack(DataBundle stagePageBundle, BossRushPage.Params param)
		{
			return null;
		}

		// Token: 0x06023FEC RID: 147436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FEC")]
		[Address(RVA = "0x1EA4460", Offset = "0x1EA3060", VA = "0x181EA4460")]
		public static void SaveParamToBundle(string actId, string stageGroupId, string stageId, string teamId, DataBundle targetBundle)
		{
		}

		// Token: 0x06023FED RID: 147437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FED")]
		[Address(RVA = "0x1EA4290", Offset = "0x1EA2E90", VA = "0x181EA4290")]
		public static BossRushPage.Params LoadParamFromBundle(DataBundle bundleToJumpBack)
		{
			return null;
		}

		// Token: 0x06023FEE RID: 147438 RVA: 0x000C2B38 File Offset: 0x000C0D38
		[Token(Token = "0x6023FEE")]
		[Address(RVA = "0x1EA3CC0", Offset = "0x1EA28C0", VA = "0x181EA3CC0")]
		public BossRushPage.BossRushCacheData ConsumeCacheParam()
		{
			return default(BossRushPage.BossRushCacheData);
		}

		// Token: 0x06023FEF RID: 147439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FEF")]
		[Address(RVA = "0x1EA45E0", Offset = "0x1EA31E0", VA = "0x181EA45E0")]
		public BossRushPage()
		{
		}

		// Token: 0x06023FF1 RID: 147441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FF1")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06023FF2 RID: 147442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FF2")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04032011 RID: 204817
		[Token(Token = "0x4032011")]
		private const string KEY_PARAM_BUNDLE = "key_boss_rush_param";

		// Token: 0x04032012 RID: 204818
		[Token(Token = "0x4032012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private BossRushPage.BossRushCacheData m_cachedData;

		// Token: 0x04032013 RID: 204819
		[Token(Token = "0x4032013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string m_actId;

		// Token: 0x04032014 RID: 204820
		[Token(Token = "0x4032014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04032015 RID: 204821
		[Token(Token = "0x4032015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04032016 RID: 204822
		[Token(Token = "0x4032016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04032017 RID: 204823
		[Token(Token = "0x4032017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04032018 RID: 204824
		[Token(Token = "0x4032018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenPageStackToJumpBack;

		// Token: 0x04032019 RID: 204825
		[Token(Token = "0x4032019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SaveParamToBundle;

		// Token: 0x0403201A RID: 204826
		[Token(Token = "0x403201A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadParamFromBundle;

		// Token: 0x0403201B RID: 204827
		[Token(Token = "0x403201B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ConsumeCacheParam;

		// Token: 0x0403201C RID: 204828
		[Token(Token = "0x403201C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200616B RID: 24939
		[Token(Token = "0x200616B")]
		public class Params
		{
			// Token: 0x06023FF3 RID: 147443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023FF3")]
			[Address(RVA = "0x1EB18B0", Offset = "0x1EB04B0", VA = "0x181EB18B0")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06023FF4 RID: 147444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023FF4")]
			[Address(RVA = "0x1EB1790", Offset = "0x1EB0390", VA = "0x181EB1790")]
			public static BossRushPage.Params Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06023FF5 RID: 147445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FF5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403201D RID: 204829
			[Token(Token = "0x403201D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403201E RID: 204830
			[Token(Token = "0x403201E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string selectStageGroupId;

			// Token: 0x0403201F RID: 204831
			[Token(Token = "0x403201F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string selectStageId;

			// Token: 0x04032020 RID: 204832
			[Token(Token = "0x4032020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string selectTeamId;
		}

		// Token: 0x0200616C RID: 24940
		[Token(Token = "0x200616C")]
		public struct BossRushCacheData
		{
			// Token: 0x06023FF6 RID: 147446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FF6")]
			[Address(RVA = "0x1EA2BE0", Offset = "0x1EA17E0", VA = "0x181EA2BE0")]
			public BossRushCacheData([Optional] BossRushPage.Params param)
			{
			}

			// Token: 0x04032021 RID: 204833
			[Token(Token = "0x4032021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string stageGroupId;

			// Token: 0x04032022 RID: 204834
			[Token(Token = "0x4032022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x04032023 RID: 204835
			[Token(Token = "0x4032023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string teamId;
		}
	}
}
