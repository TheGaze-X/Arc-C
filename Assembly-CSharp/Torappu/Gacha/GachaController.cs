using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.Resource;
using Torappu.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x0200164B RID: 5707
	[Token(Token = "0x200164B")]
	public class GachaController : PersistentSingleton<GachaController>, ISingletonNotAutoCreate, ICompDialogCallBack
	{
		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06008168 RID: 33128 RVA: 0x000388E0 File Offset: 0x00036AE0
		// (set) Token: 0x06008169 RID: 33129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F53")]
		public GachaController.StateEnum state
		{
			[Token(Token = "0x6008168")]
			[Address(RVA = "0x2B006A0", Offset = "0x2AFF2A0", VA = "0x182B006A0")]
			[CompilerGenerated]
			get
			{
				return GachaController.StateEnum.NONE;
			}
			[Token(Token = "0x6008169")]
			[Address(RVA = "0x2B007D0", Offset = "0x2AFF3D0", VA = "0x182B007D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x0600816A RID: 33130 RVA: 0x000388F8 File Offset: 0x00036AF8
		[Token(Token = "0x17000F54")]
		public GachaController.CharacterConfig charConfig
		{
			[Token(Token = "0x600816A")]
			[Address(RVA = "0x2B00150", Offset = "0x2AFED50", VA = "0x182B00150")]
			get
			{
				return default(GachaController.CharacterConfig);
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600816B RID: 33131 RVA: 0x00038910 File Offset: 0x00036B10
		[Token(Token = "0x17000F55")]
		public bool isNew
		{
			[Token(Token = "0x600816B")]
			[Address(RVA = "0x2B002F0", Offset = "0x2AFEEF0", VA = "0x182B002F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F56")]
		public ProfessionSpriteHub professionHub
		{
			[Token(Token = "0x600816C")]
			[Address(RVA = "0x2B00580", Offset = "0x2AFF180", VA = "0x182B00580")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x0600816D RID: 33133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F57")]
		public CharacterData characterData
		{
			[Token(Token = "0x600816D")]
			[Address(RVA = "0x2B00210", Offset = "0x2AFEE10", VA = "0x182B00210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F58")]
		public AbstractAssetLoader assetLoader
		{
			[Token(Token = "0x600816E")]
			[Address(RVA = "0x2B000F0", Offset = "0x2AFECF0", VA = "0x182B000F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x0600816F RID: 33135 RVA: 0x00038928 File Offset: 0x00036B28
		[Token(Token = "0x17000F59")]
		public bool isRunning
		{
			[Token(Token = "0x600816F")]
			[Address(RVA = "0x2B00350", Offset = "0x2AFEF50", VA = "0x182B00350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06008170 RID: 33136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F5A")]
		public ItemBundle[] itemList
		{
			[Token(Token = "0x6008170")]
			[Address(RVA = "0x2B004C0", Offset = "0x2AFF0C0", VA = "0x182B004C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06008171 RID: 33137 RVA: 0x00038940 File Offset: 0x00036B40
		[Token(Token = "0x17000F5B")]
		public bool showDynEntrance
		{
			[Token(Token = "0x6008171")]
			[Address(RVA = "0x2B00640", Offset = "0x2AFF240", VA = "0x182B00640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x00038958 File Offset: 0x00036B58
		[Token(Token = "0x17000F5C")]
		public RarityRank totalRarity
		{
			[Token(Token = "0x6008172")]
			[Address(RVA = "0x2B00700", Offset = "0x2AFF300", VA = "0x182B00700")]
			get
			{
				return RarityRank.TIER_1;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06008173 RID: 33139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F5D")]
		public List<RarityRank> rarityList
		{
			[Token(Token = "0x6008173")]
			[Address(RVA = "0x2B005E0", Offset = "0x2AFF1E0", VA = "0x182B005E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06008174 RID: 33140 RVA: 0x00038970 File Offset: 0x00036B70
		[Token(Token = "0x17000F5E")]
		public bool isMultipleGacha
		{
			[Token(Token = "0x6008174")]
			[Address(RVA = "0x2B00270", Offset = "0x2AFEE70", VA = "0x182B00270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06008175 RID: 33141 RVA: 0x00038988 File Offset: 0x00036B88
		[Token(Token = "0x17000F5F")]
		public bool isSkipped
		{
			[Token(Token = "0x6008175")]
			[Address(RVA = "0x2B00400", Offset = "0x2AFF000", VA = "0x182B00400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06008176 RID: 33142 RVA: 0x000389A0 File Offset: 0x00036BA0
		[Token(Token = "0x17000F60")]
		public bool isSkipping
		{
			[Token(Token = "0x6008176")]
			[Address(RVA = "0x2B00460", Offset = "0x2AFF060", VA = "0x182B00460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06008177 RID: 33143 RVA: 0x000389B8 File Offset: 0x00036BB8
		// (set) Token: 0x06008178 RID: 33144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F61")]
		private protected GachaController.PlayMode playMode
		{
			[Token(Token = "0x6008177")]
			[Address(RVA = "0x2B00520", Offset = "0x2AFF120", VA = "0x182B00520")]
			[CompilerGenerated]
			protected get
			{
				return GachaController.PlayMode.FULL_GACHA;
			}
			[Token(Token = "0x6008178")]
			[Address(RVA = "0x2B00760", Offset = "0x2AFF360", VA = "0x182B00760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008179")]
		[Address(RVA = "0x2AFD2C0", Offset = "0x2AFBEC0", VA = "0x182AFD2C0")]
		public static void Play(GachaController.PlayMode playMode, GachaController.Input input, Action<GachaController.Output> endCb)
		{
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817A")]
		[Address(RVA = "0x2AFD460", Offset = "0x2AFC060", VA = "0x182AFD460")]
		public static void Play(GachaController.PlayMode playMode, GachaController.Input[] input, Action<GachaController.Output> endCb)
		{
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x000389D0 File Offset: 0x00036BD0
		[Token(Token = "0x600817B")]
		[Address(RVA = "0x2AFC650", Offset = "0x2AFB250", VA = "0x182AFC650")]
		public static bool PlayInStandaloneScene(GachaController.PlayMode playMode, GachaController.Input input, string backScene, [Optional] Action<GachaController.Output> endCb)
		{
			return default(bool);
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x000389E8 File Offset: 0x00036BE8
		[Token(Token = "0x600817C")]
		[Address(RVA = "0x2AFC440", Offset = "0x2AFB040", VA = "0x182AFC440")]
		public static bool PlayInStandaloneScene(GachaController.PlayMode playMode, GachaController.Input input, string backScene, GameFlowController.Options backOptions, [Optional] Action<GachaController.Output> endCb)
		{
			return default(bool);
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x00038A00 File Offset: 0x00036C00
		[Token(Token = "0x600817D")]
		[Address(RVA = "0x2AFBDC0", Offset = "0x2AFA9C0", VA = "0x182AFBDC0")]
		public static GachaController.Output GetOutput()
		{
			return default(GachaController.Output);
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817E")]
		[Address(RVA = "0x2AFD520", Offset = "0x2AFC120", VA = "0x182AFD520")]
		public static void Prewarm(GachaController.PlayMode playMode)
		{
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817F")]
		[Address(RVA = "0x2AFDC90", Offset = "0x2AFC890", VA = "0x182AFDC90")]
		public static void StopAll()
		{
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x00038A18 File Offset: 0x00036C18
		[Token(Token = "0x6008180")]
		[Address(RVA = "0x2AFDD80", Offset = "0x2AFC980", VA = "0x182AFDD80")]
		public static bool TryFetchAndAddCameras(List<Camera> cameras)
		{
			return default(bool);
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008181")]
		[Address(RVA = "0x2AFC370", Offset = "0x2AFAF70", VA = "0x182AFC370")]
		public void OnMaskClicked()
		{
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008182")]
		[Address(RVA = "0x2AFCDE0", Offset = "0x2AFB9E0", VA = "0x182AFCDE0")]
		protected void PlayInternal(GachaController.PlayMode playMode, GachaController.Input[] inputList, Action<GachaController.Output> endCb)
		{
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008183")]
		[Address(RVA = "0x2AFC8F0", Offset = "0x2AFB4F0", VA = "0x182AFC8F0")]
		protected void PlayInternal(GachaController.PlayMode playMode, GachaController.Input input, Action<GachaController.Output> endCb)
		{
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008184")]
		[Address(RVA = "0x2AFC000", Offset = "0x2AFAC00", VA = "0x182AFC000")]
		protected void InitData(GachaController.Input input)
		{
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008185")]
		[Address(RVA = "0x2AFBA50", Offset = "0x2AFA650", VA = "0x182AFBA50")]
		protected void FinishIfNot([Optional] string errorMsg)
		{
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008186")]
		[Address(RVA = "0x2AFD890", Offset = "0x2AFC490", VA = "0x182AFD890")]
		protected void SkipToEndIfNot(bool setSkippedFlag)
		{
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008187")]
		[Address(RVA = "0x2AFE9D0", Offset = "0x2AFD5D0", VA = "0x182AFE9D0")]
		private void _DoEndCb()
		{
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008188")]
		[Address(RVA = "0x2AFEDC0", Offset = "0x2AFD9C0", VA = "0x182AFEDC0")]
		private IEnumerator _DoPlay(GachaController.Input input)
		{
			return null;
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008189")]
		[Address(RVA = "0x2AFECC0", Offset = "0x2AFD8C0", VA = "0x182AFECC0")]
		private IEnumerator _DoPhase1(GachaController.Input input)
		{
			return null;
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600818A")]
		[Address(RVA = "0x2AFEF10", Offset = "0x2AFDB10", VA = "0x182AFEF10")]
		private IEnumerator _DoSkipFromPhase1ToEnd(GachaController.Input input)
		{
			return null;
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818B")]
		[Address(RVA = "0x2AFE190", Offset = "0x2AFCD90", VA = "0x182AFE190")]
		private void _ClearResource(bool unloadUnusedResources)
		{
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818C")]
		[Address(RVA = "0x2AFE010", Offset = "0x2AFCC10", VA = "0x182AFE010")]
		private void _ClearCoroutines()
		{
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818D")]
		[Address(RVA = "0x2AFF730", Offset = "0x2AFE330", VA = "0x182AFF730")]
		private void _LoadResourceIfNot()
		{
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600818E")]
		[Address(RVA = "0x2AFE3C0", Offset = "0x2AFCFC0", VA = "0x182AFE3C0")]
		private GachaController.GachaPhase _CreatePhase0()
		{
			return null;
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600818F")]
		[Address(RVA = "0x2AFE420", Offset = "0x2AFD020", VA = "0x182AFE420")]
		private GachaController.GachaPhase _CreatePhase1()
		{
			return null;
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008190")]
		[Address(RVA = "0x2AFE480", Offset = "0x2AFD080", VA = "0x182AFE480")]
		private GachaController.GachaPhase _CreatePhaseUncached(string path)
		{
			return null;
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008191")]
		[Address(RVA = "0x2AFF580", Offset = "0x2AFE180", VA = "0x182AFF580")]
		private GameObject _InstGachaPhase(GameObject prefab)
		{
			return null;
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008192")]
		[Address(RVA = "0x2AFE6B0", Offset = "0x2AFD2B0", VA = "0x182AFE6B0")]
		private void _DisposePhase0()
		{
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008193")]
		[Address(RVA = "0x2AFE7F0", Offset = "0x2AFD3F0", VA = "0x182AFE7F0")]
		private void _DisposePhase1()
		{
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008194")]
		[Address(RVA = "0x2AFE8E0", Offset = "0x2AFD4E0", VA = "0x182AFE8E0")]
		private void _DisposePhase(ref GachaController.GachaPhase phaseField)
		{
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008195")]
		private T _LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008196")]
		[Address(RVA = "0x2AFFAE0", Offset = "0x2AFE6E0", VA = "0x182AFFAE0")]
		private void _OnSceneUnloaded(Scene scene)
		{
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x00038A30 File Offset: 0x00036C30
		[Token(Token = "0x6008197")]
		[Address(RVA = "0x2AFF0D0", Offset = "0x2AFDCD0", VA = "0x182AFF0D0")]
		private RarityRank _GetTotalRarity(GachaController.Input input, List<RarityRank> rarityList)
		{
			return RarityRank.TIER_1;
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x00038A48 File Offset: 0x00036C48
		[Token(Token = "0x6008198")]
		[Address(RVA = "0x2AFF2E0", Offset = "0x2AFDEE0", VA = "0x182AFF2E0")]
		private RarityRank _GetTotalRarity(GachaController.Input[] inputList, List<RarityRank> rarityList)
		{
			return RarityRank.TIER_1;
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008199")]
		[Address(RVA = "0x2AFFB70", Offset = "0x2AFE770", VA = "0x182AFFB70")]
		private void _PopulateItems(GachaController.Input[] inputList, List<ItemBundle> items)
		{
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819A")]
		[Address(RVA = "0x2AFFD60", Offset = "0x2AFE960", VA = "0x182AFFD60")]
		private void _PreloadGachaSounds(GachaController.PlayMode playMode, RarityRank rarity, bool isMultipleGacha)
		{
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819B")]
		[Address(RVA = "0x2AFC2C0", Offset = "0x2AFAEC0", VA = "0x182AFC2C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819C")]
		[Address(RVA = "0x2AFC200", Offset = "0x2AFAE00", VA = "0x182AFC200")]
		private void OnDisable()
		{
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819D")]
		[Address(RVA = "0x2AFD5C0", Offset = "0x2AFC1C0", VA = "0x182AFD5C0")]
		public void ShowDisplaySkin(GachaController.Input input, Action<GachaController.Output> endCb)
		{
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819E")]
		[Address(RVA = "0x2AFE0A0", Offset = "0x2AFCCA0", VA = "0x182AFE0A0")]
		private void _ClearDlgMgrHost()
		{
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x00038A60 File Offset: 0x00036C60
		[Token(Token = "0x600819F")]
		[Address(RVA = "0x2AFF010", Offset = "0x2AFDC10", VA = "0x182AFF010")]
		private bool _FinishWhenUsingDlg()
		{
			return default(bool);
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A0")]
		[Address(RVA = "0x2AFFA70", Offset = "0x2AFE670", VA = "0x182AFFA70")]
		private void _OnHostCallback()
		{
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A1")]
		[Address(RVA = "0x2AFBF70", Offset = "0x2AFAB70", VA = "0x182AFBF70", Slot = "8")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A2")]
		[Address(RVA = "0x2AFFEE0", Offset = "0x2AFEAE0", VA = "0x182AFFEE0")]
		public GachaController()
		{
		}

		// Token: 0x0400833D RID: 33597
		[Token(Token = "0x400833D")]
		private const float AUTO_EXIT_DELAY_NORMAL = 0.5f;

		// Token: 0x0400833E RID: 33598
		[Token(Token = "0x400833E")]
		private const float AUTO_EXIT_DELAY_SKIP = 1.5f;

		// Token: 0x0400833F RID: 33599
		[Token(Token = "0x400833F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x04008340 RID: 33600
		[Token(Token = "0x4008340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _uiCamera;

		// Token: 0x04008341 RID: 33601
		[Token(Token = "0x4008341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _bodyTransform;

		// Token: 0x04008342 RID: 33602
		[Token(Token = "0x4008342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _uiPhaseContainer;

		// Token: 0x04008343 RID: 33603
		[Token(Token = "0x4008343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _generalPhaseContainer;

		// Token: 0x04008344 RID: 33604
		[Token(Token = "0x4008344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _mask;

		// Token: 0x04008345 RID: 33605
		[Token(Token = "0x4008345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Resources")]
		private string _phase0Path;

		// Token: 0x04008346 RID: 33606
		[Token(Token = "0x4008346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Resources")]
		private string _phase1Path;

		// Token: 0x04008347 RID: 33607
		[Token(Token = "0x4008347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_newCnt;

		// Token: 0x04008348 RID: 33608
		[Token(Token = "0x4008348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GachaController.Input m_input;

		// Token: 0x04008349 RID: 33609
		[Token(Token = "0x4008349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AbstractAssetLoader m_assetLoader;

		// Token: 0x0400834A RID: 33610
		[Token(Token = "0x400834A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CharacterData m_character;

		// Token: 0x0400834B RID: 33611
		[Token(Token = "0x400834B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ProfessionSpriteHub m_professionHub;

		// Token: 0x0400834C RID: 33612
		[Token(Token = "0x400834C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GachaController.GachaPhase m_phase0;

		// Token: 0x0400834D RID: 33613
		[Token(Token = "0x400834D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GachaController.GachaPhase m_phase1;

		// Token: 0x0400834E RID: 33614
		[Token(Token = "0x400834E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action<GachaController.Output> m_endCb;

		// Token: 0x0400834F RID: 33615
		[Token(Token = "0x400834F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform m_interactivePanel;

		// Token: 0x04008350 RID: 33616
		[Token(Token = "0x4008350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine m_playCorout;

		// Token: 0x04008351 RID: 33617
		[Token(Token = "0x4008351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Queue<GachaController.Input> m_pendingInputQueue;

		// Token: 0x04008352 RID: 33618
		[Token(Token = "0x4008352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<RarityRank> m_rarityList;

		// Token: 0x04008353 RID: 33619
		[Token(Token = "0x4008353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool m_isSkipped;

		// Token: 0x04008354 RID: 33620
		[Token(Token = "0x4008354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		private bool m_isSkipping;

		// Token: 0x04008355 RID: 33621
		[Token(Token = "0x4008355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private RarityRank m_totalRarity;

		// Token: 0x04008356 RID: 33622
		[Token(Token = "0x4008356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<ItemBundle> m_allItems;

		// Token: 0x04008359 RID: 33625
		[Token(Token = "0x4008359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private RectTransform _hostContainer;

		// Token: 0x0400835A RID: 33626
		[Token(Token = "0x400835A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GachaControllerDlgMgrHost m_hostView;

		// Token: 0x0400835B RID: 33627
		[Token(Token = "0x400835B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400835C RID: 33628
		[Token(Token = "0x400835C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0400835D RID: 33629
		[Token(Token = "0x400835D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charConfig;

		// Token: 0x0400835E RID: 33630
		[Token(Token = "0x400835E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isNew;

		// Token: 0x0400835F RID: 33631
		[Token(Token = "0x400835F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_professionHub;

		// Token: 0x04008360 RID: 33632
		[Token(Token = "0x4008360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_characterData;

		// Token: 0x04008361 RID: 33633
		[Token(Token = "0x4008361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04008362 RID: 33634
		[Token(Token = "0x4008362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isRunning;

		// Token: 0x04008363 RID: 33635
		[Token(Token = "0x4008363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x04008364 RID: 33636
		[Token(Token = "0x4008364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_showDynEntrance;

		// Token: 0x04008365 RID: 33637
		[Token(Token = "0x4008365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_totalRarity;

		// Token: 0x04008366 RID: 33638
		[Token(Token = "0x4008366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_rarityList;

		// Token: 0x04008367 RID: 33639
		[Token(Token = "0x4008367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isMultipleGacha;

		// Token: 0x04008368 RID: 33640
		[Token(Token = "0x4008368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isSkipped;

		// Token: 0x04008369 RID: 33641
		[Token(Token = "0x4008369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isSkipping;

		// Token: 0x0400836A RID: 33642
		[Token(Token = "0x400836A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_playMode;

		// Token: 0x0400836B RID: 33643
		[Token(Token = "0x400836B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_playMode;

		// Token: 0x0400836C RID: 33644
		[Token(Token = "0x400836C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400836D RID: 33645
		[Token(Token = "0x400836D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1_Play;

		// Token: 0x0400836E RID: 33646
		[Token(Token = "0x400836E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PlayInStandaloneScene;

		// Token: 0x0400836F RID: 33647
		[Token(Token = "0x400836F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_PlayInStandaloneScene;

		// Token: 0x04008370 RID: 33648
		[Token(Token = "0x4008370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetOutput;

		// Token: 0x04008371 RID: 33649
		[Token(Token = "0x4008371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Prewarm;

		// Token: 0x04008372 RID: 33650
		[Token(Token = "0x4008372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_StopAll;

		// Token: 0x04008373 RID: 33651
		[Token(Token = "0x4008373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

		// Token: 0x04008374 RID: 33652
		[Token(Token = "0x4008374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnMaskClicked;

		// Token: 0x04008375 RID: 33653
		[Token(Token = "0x4008375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_PlayInternal;

		// Token: 0x04008376 RID: 33654
		[Token(Token = "0x4008376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix1_PlayInternal;

		// Token: 0x04008377 RID: 33655
		[Token(Token = "0x4008377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04008378 RID: 33656
		[Token(Token = "0x4008378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_FinishIfNot;

		// Token: 0x04008379 RID: 33657
		[Token(Token = "0x4008379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SkipToEndIfNot;

		// Token: 0x0400837A RID: 33658
		[Token(Token = "0x400837A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__DoEndCb;

		// Token: 0x0400837B RID: 33659
		[Token(Token = "0x400837B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__DoPlay;

		// Token: 0x0400837C RID: 33660
		[Token(Token = "0x400837C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__DoPhase1;

		// Token: 0x0400837D RID: 33661
		[Token(Token = "0x400837D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__DoSkipFromPhase1ToEnd;

		// Token: 0x0400837E RID: 33662
		[Token(Token = "0x400837E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ClearResource;

		// Token: 0x0400837F RID: 33663
		[Token(Token = "0x400837F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ClearCoroutines;

		// Token: 0x04008380 RID: 33664
		[Token(Token = "0x4008380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__LoadResourceIfNot;

		// Token: 0x04008381 RID: 33665
		[Token(Token = "0x4008381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CreatePhase0;

		// Token: 0x04008382 RID: 33666
		[Token(Token = "0x4008382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__CreatePhase1;

		// Token: 0x04008383 RID: 33667
		[Token(Token = "0x4008383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CreatePhaseUncached;

		// Token: 0x04008384 RID: 33668
		[Token(Token = "0x4008384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__InstGachaPhase;

		// Token: 0x04008385 RID: 33669
		[Token(Token = "0x4008385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__DisposePhase0;

		// Token: 0x04008386 RID: 33670
		[Token(Token = "0x4008386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__DisposePhase1;

		// Token: 0x04008387 RID: 33671
		[Token(Token = "0x4008387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__DisposePhase;

		// Token: 0x04008388 RID: 33672
		[Token(Token = "0x4008388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__LoadAsset;

		// Token: 0x04008389 RID: 33673
		[Token(Token = "0x4008389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnSceneUnloaded;

		// Token: 0x0400838A RID: 33674
		[Token(Token = "0x400838A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GetTotalRarity;

		// Token: 0x0400838B RID: 33675
		[Token(Token = "0x400838B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix1__GetTotalRarity;

		// Token: 0x0400838C RID: 33676
		[Token(Token = "0x400838C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__PopulateItems;

		// Token: 0x0400838D RID: 33677
		[Token(Token = "0x400838D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__PreloadGachaSounds;

		// Token: 0x0400838E RID: 33678
		[Token(Token = "0x400838E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400838F RID: 33679
		[Token(Token = "0x400838F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04008390 RID: 33680
		[Token(Token = "0x4008390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ShowDisplaySkin;

		// Token: 0x04008391 RID: 33681
		[Token(Token = "0x4008391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__ClearDlgMgrHost;

		// Token: 0x04008392 RID: 33682
		[Token(Token = "0x4008392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__FinishWhenUsingDlg;

		// Token: 0x04008393 RID: 33683
		[Token(Token = "0x4008393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__OnHostCallback;

		// Token: 0x04008394 RID: 33684
		[Token(Token = "0x4008394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04008395 RID: 33685
		[Token(Token = "0x4008395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200164C RID: 5708
		[Token(Token = "0x200164C")]
		public abstract class GachaPhase : MonoBehaviour, IHotfixable
		{
			// Token: 0x17000F62 RID: 3938
			// (get) Token: 0x060081A3 RID: 33187
			[Token(Token = "0x17000F62")]
			public abstract bool canSkip { [Token(Token = "0x60081A3")] get; }

			// Token: 0x17000F63 RID: 3939
			// (get) Token: 0x060081A4 RID: 33188 RVA: 0x00038A78 File Offset: 0x00036C78
			[Token(Token = "0x17000F63")]
			public virtual bool hasOwnCamera
			{
				[Token(Token = "0x60081A4")]
				[Address(RVA = "0x2B02190", Offset = "0x2B00D90", VA = "0x182B02190", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060081A5 RID: 33189
			[Token(Token = "0x60081A5")]
			public abstract IEnumerator Play(GachaController controller, GachaController.PlayMode playMode);

			// Token: 0x060081A6 RID: 33190
			[Token(Token = "0x60081A6")]
			public abstract void SkipToEnd(GachaController controller, GachaController.PlayMode playMode);

			// Token: 0x060081A7 RID: 33191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60081A7")]
			[Address(RVA = "0x2B04230", Offset = "0x2B02E30", VA = "0x182B04230", Slot = "8")]
			public virtual IEnumerator SkipToEndAsync(GachaController controller, GachaController.PlayMode playMode)
			{
				return null;
			}

			// Token: 0x060081A8 RID: 33192
			[Token(Token = "0x60081A8")]
			public abstract void PreloadSounds(GachaController.PlayMode playMode, RarityRank rarity, bool isMultipleGacha);

			// Token: 0x060081A9 RID: 33193 RVA: 0x00038A90 File Offset: 0x00036C90
			[Token(Token = "0x60081A9")]
			[Address(RVA = "0x2B02080", Offset = "0x2B00C80", VA = "0x182B02080", Slot = "10")]
			public virtual bool TryFetchAndAddCameras(List<Camera> cameras)
			{
				return default(bool);
			}

			// Token: 0x060081AA RID: 33194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081AA")]
			[Address(RVA = "0x2B02020", Offset = "0x2B00C20", VA = "0x182B02020", Slot = "11")]
			public virtual void OnInit()
			{
			}

			// Token: 0x060081AB RID: 33195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081AB")]
			[Address(RVA = "0x2B01FC0", Offset = "0x2B00BC0", VA = "0x182B01FC0", Slot = "12")]
			protected virtual void OnDisposeForReuse()
			{
			}

			// Token: 0x060081AC RID: 33196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081AC")]
			[Address(RVA = "0x2B041B0", Offset = "0x2B02DB0", VA = "0x182B041B0")]
			public void DisposeForReuse()
			{
			}

			// Token: 0x060081AD RID: 33197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081AD")]
			[Address(RVA = "0x2B04320", Offset = "0x2B02F20", VA = "0x182B04320")]
			protected GachaPhase()
			{
			}

			// Token: 0x04008396 RID: 33686
			[Token(Token = "0x4008396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hasOwnCamera;

			// Token: 0x04008397 RID: 33687
			[Token(Token = "0x4008397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SkipToEndAsync;

			// Token: 0x04008398 RID: 33688
			[Token(Token = "0x4008398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

			// Token: 0x04008399 RID: 33689
			[Token(Token = "0x4008399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0400839A RID: 33690
			[Token(Token = "0x400839A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnDisposeForReuse;

			// Token: 0x0400839B RID: 33691
			[Token(Token = "0x400839B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DisposeForReuse;

			// Token: 0x0400839C RID: 33692
			[Token(Token = "0x400839C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200164E RID: 5710
		[Token(Token = "0x200164E")]
		public struct CharacterConfig
		{
			// Token: 0x060081B4 RID: 33204 RVA: 0x00038AC0 File Offset: 0x00036CC0
			[Token(Token = "0x60081B4")]
			[Address(RVA = "0x2AF9AB0", Offset = "0x2AF86B0", VA = "0x182AF9AB0")]
			public VoiceQuery GetVoiceQuery()
			{
				return default(VoiceQuery);
			}

			// Token: 0x060081B5 RID: 33205 RVA: 0x00038AD8 File Offset: 0x00036CD8
			[Token(Token = "0x60081B5")]
			[Address(RVA = "0x2AF9A60", Offset = "0x2AF8660", VA = "0x182AF9A60")]
			public CharQuery GetCharQuery()
			{
				return default(CharQuery);
			}

			// Token: 0x060081B6 RID: 33206 RVA: 0x00038AF0 File Offset: 0x00036CF0
			[Token(Token = "0x60081B6")]
			[Address(RVA = "0x2AF9960", Offset = "0x2AF8560", VA = "0x182AF9960")]
			public static GachaController.CharacterConfig FromPlayerCharacterWithoutSkin(PlayerCharacter playerCharacter, bool isGacha)
			{
				return default(GachaController.CharacterConfig);
			}

			// Token: 0x060081B7 RID: 33207 RVA: 0x00038B08 File Offset: 0x00036D08
			[Token(Token = "0x60081B7")]
			[Address(RVA = "0x2AF9910", Offset = "0x2AF8510", VA = "0x182AF9910")]
			public static GachaController.CharacterConfig FromGachaResult(GachaResult charResult)
			{
				return default(GachaController.CharacterConfig);
			}

			// Token: 0x040083A2 RID: 33698
			[Token(Token = "0x40083A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x040083A3 RID: 33699
			[Token(Token = "0x40083A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public EvolvePhase evolvePhase;

			// Token: 0x040083A4 RID: 33700
			[Token(Token = "0x40083A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string skinId;

			// Token: 0x040083A5 RID: 33701
			[Token(Token = "0x40083A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string tmplId;

			// Token: 0x040083A6 RID: 33702
			[Token(Token = "0x40083A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool showSpDynIllust;

			// Token: 0x040083A7 RID: 33703
			[Token(Token = "0x40083A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool showGachaText;

			// Token: 0x040083A8 RID: 33704
			[Token(Token = "0x40083A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceQuery overrideVoice;
		}

		// Token: 0x0200164F RID: 5711
		[Token(Token = "0x200164F")]
		public struct Input
		{
			// Token: 0x040083A9 RID: 33705
			[Token(Token = "0x40083A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isNew;

			// Token: 0x040083AA RID: 33706
			[Token(Token = "0x40083AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool isAutoExit;

			// Token: 0x040083AB RID: 33707
			[Token(Token = "0x40083AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool isSkippable;

			// Token: 0x040083AC RID: 33708
			[Token(Token = "0x40083AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool showDynEntrance;

			// Token: 0x040083AD RID: 33709
			[Token(Token = "0x40083AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject disableTarget;

			// Token: 0x040083AE RID: 33710
			[Token(Token = "0x40083AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GachaController.CharacterConfig characterConfig;

			// Token: 0x040083AF RID: 33711
			[Token(Token = "0x40083AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public ItemBundle[] itemGet;
		}

		// Token: 0x02001650 RID: 5712
		[Token(Token = "0x2001650")]
		public struct Output
		{
			// Token: 0x040083B0 RID: 33712
			[Token(Token = "0x40083B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GachaController.CharacterConfig characterConfig;

			// Token: 0x040083B1 RID: 33713
			[Token(Token = "0x40083B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ItemBundle[] itemGet;

			// Token: 0x040083B2 RID: 33714
			[Token(Token = "0x40083B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int newCnt;
		}

		// Token: 0x02001651 RID: 5713
		[Token(Token = "0x2001651")]
		public enum PlayMode
		{
			// Token: 0x040083B4 RID: 33716
			[Token(Token = "0x40083B4")]
			FULL_GACHA,
			// Token: 0x040083B5 RID: 33717
			[Token(Token = "0x40083B5")]
			SIMPLE_GACHA,
			// Token: 0x040083B6 RID: 33718
			[Token(Token = "0x40083B6")]
			DISPLAY_ONLY,
			// Token: 0x040083B7 RID: 33719
			[Token(Token = "0x40083B7")]
			DISPLAY_SKIN
		}

		// Token: 0x02001652 RID: 5714
		[Token(Token = "0x2001652")]
		public enum StateEnum
		{
			// Token: 0x040083B9 RID: 33721
			[Token(Token = "0x40083B9")]
			NONE,
			// Token: 0x040083BA RID: 33722
			[Token(Token = "0x40083BA")]
			INIT,
			// Token: 0x040083BB RID: 33723
			[Token(Token = "0x40083BB")]
			PHASE_0,
			// Token: 0x040083BC RID: 33724
			[Token(Token = "0x40083BC")]
			PHASE_1,
			// Token: 0x040083BD RID: 33725
			[Token(Token = "0x40083BD")]
			HOLD
		}
	}
}
