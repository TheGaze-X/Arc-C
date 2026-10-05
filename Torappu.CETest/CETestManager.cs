using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.CETest
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public sealed class CETestManager : SingletonMonoBehaviour<CETestManager>, ISingletonNotAutoCreate
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		private string DefaultLuaRootPath
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x54D9300", Offset = "0x54D7F00", VA = "0x1854D9300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		private static string DefaultLuaHotfixRootPath
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x54D9290", Offset = "0x54D7E90", VA = "0x1854D9290")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x54D8D10", Offset = "0x54D7910", VA = "0x1854D8D10")]
		public static string OnInit()
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x54D8BF0", Offset = "0x54D77F0", VA = "0x1854D8BF0")]
		public static void OnDispose()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x54D8BB0", Offset = "0x54D77B0", VA = "0x1854D8BB0")]
		public static object LoadData()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x54D8F30", Offset = "0x54D7B30", VA = "0x1854D8F30")]
		public static bool TryGetLevelAndSquad(string levelId, string squadId, out TextAsset levelAsset, out TextAsset squadAsset)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x54D8A70", Offset = "0x54D7670", VA = "0x1854D8A70")]
		public static bool CheckShouldTriggerCEExclusion()
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x54D8A50", Offset = "0x54D7650", VA = "0x1854D8A50")]
		public static bool CEUpdateInBattleCharExcludeInfoWhenCharacterBuilt(string charId)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x54D8A60", Offset = "0x54D7660", VA = "0x1854D8A60")]
		public static bool CEUpdateInBattleCharExcludeInfoWhenCharacterOut(string charId, List<string> charactersOnGround)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x54D8B10", Offset = "0x54D7710", VA = "0x1854D8B10")]
		public static string GetLuaHotfixRootPath()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		private CETestDataType _ParseUIData()
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x54D90B0", Offset = "0x54D7CB0", VA = "0x1854D90B0")]
		private void _InitConfigsFromResources()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x54D91B0", Offset = "0x54D7DB0", VA = "0x1854D91B0")]
		private bool _TryGetLevelAndSquadImpl(string levelId, string squadId, out TextAsset levelAsset, out TextAsset squadAsset)
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x54D8FC0", Offset = "0x54D7BC0", VA = "0x1854D8FC0")]
		private string _GetLuaRootPath()
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x54D9250", Offset = "0x54D7E50", VA = "0x1854D9250")]
		public CETestManager()
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _ceTestPersistentPrefab;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CETestConfigs configs;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		private CETestDataType m_uiDataCache;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CE_CHARACTER_TEST_BATTLE_SCENE;
	}
}
