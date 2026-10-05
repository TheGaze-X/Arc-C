using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using Torappu.Fx;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x0200166A RID: 5738
	[Token(Token = "0x200166A")]
	public class GachaPhase0 : GachaController.GachaPhase
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F72")]
		public GachaPhase0.Options options
		{
			[Token(Token = "0x6008215")]
			[Address(RVA = "0x2B027A0", Offset = "0x2B013A0", VA = "0x182B027A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x00038BE0 File Offset: 0x00036DE0
		[Token(Token = "0x17000F73")]
		public override bool canSkip
		{
			[Token(Token = "0x6008216")]
			[Address(RVA = "0x2B026E0", Offset = "0x2B012E0", VA = "0x182B026E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06008217 RID: 33303 RVA: 0x00038BF8 File Offset: 0x00036DF8
		[Token(Token = "0x17000F74")]
		public override bool hasOwnCamera
		{
			[Token(Token = "0x6008217")]
			[Address(RVA = "0x2B02740", Offset = "0x2B01340", VA = "0x182B02740", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06008218 RID: 33304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F75")]
		[Inspect(InspectorLevel.Debug)]
		public string stateDebugStr
		{
			[Token(Token = "0x6008218")]
			[Address(RVA = "0x2B02800", Offset = "0x2B01400", VA = "0x182B02800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008219")]
		[Address(RVA = "0x2B01950", Offset = "0x2B00550", VA = "0x182B01950", Slot = "11")]
		public override void OnInit()
		{
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821A")]
		[Address(RVA = "0x2B02360", Offset = "0x2B00F60", VA = "0x182B02360")]
		private static void _ResetAnimationState(Animation animation)
		{
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600821B")]
		[Address(RVA = "0x2B01A60", Offset = "0x2B00660", VA = "0x182B01A60", Slot = "6")]
		public override IEnumerator Play(GachaController controller, GachaController.PlayMode playMode)
		{
			return null;
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821C")]
		[Address(RVA = "0x2B01E40", Offset = "0x2B00A40", VA = "0x182B01E40", Slot = "7")]
		public override void SkipToEnd(GachaController controller, GachaController.PlayMode playMode)
		{
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821D")]
		[Address(RVA = "0x2B01B40", Offset = "0x2B00740", VA = "0x182B01B40", Slot = "9")]
		public override void PreloadSounds(GachaController.PlayMode playMode, RarityRank rarity, bool isMultipleGacha)
		{
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x00038C10 File Offset: 0x00036E10
		[Token(Token = "0x600821E")]
		[Address(RVA = "0x2B01EE0", Offset = "0x2B00AE0", VA = "0x182B01EE0", Slot = "10")]
		public override bool TryFetchAndAddCameras(List<Camera> cameras)
		{
			return default(bool);
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821F")]
		[Address(RVA = "0x2B01200", Offset = "0x2AFFE00", VA = "0x182B01200")]
		public void OnBeginDrag(BaseEventData evData)
		{
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008220")]
		[Address(RVA = "0x2B01580", Offset = "0x2B00180", VA = "0x182B01580")]
		public void OnDrag(BaseEventData evData)
		{
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008221")]
		[Address(RVA = "0x2B017A0", Offset = "0x2B003A0", VA = "0x182B017A0")]
		public void OnEndDrag(BaseEventData evData)
		{
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008222")]
		[Address(RVA = "0x2B01A00", Offset = "0x2B00600", VA = "0x182B01A00")]
		public void OnSkipAllBtnClicked()
		{
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008223")]
		[Address(RVA = "0x2B01460", Offset = "0x2B00060", VA = "0x182B01460", Slot = "12")]
		protected override void OnDisposeForReuse()
		{
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008224")]
		[Address(RVA = "0x2B022C0", Offset = "0x2B00EC0", VA = "0x182B022C0")]
		private void _ResetAllAnimations()
		{
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008225")]
		[Address(RVA = "0x2B01730", Offset = "0x2B00330", VA = "0x182B01730")]
		private void OnEnable()
		{
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008226")]
		[Address(RVA = "0x2B013B0", Offset = "0x2AFFFB0", VA = "0x182B013B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008227")]
		[Address(RVA = "0x2B021F0", Offset = "0x2B00DF0", VA = "0x182B021F0")]
		private void Update()
		{
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008228")]
		[Address(RVA = "0x2B02640", Offset = "0x2B01240", VA = "0x182B02640")]
		public GachaPhase0()
		{
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x00038C28 File Offset: 0x00036E28
		[Token(Token = "0x6008229")]
		[Address(RVA = "0x2B02190", Offset = "0x2B00D90", VA = "0x182B02190")]
		private bool <>xLuaBaseProxy_get_hasOwnCamera()
		{
			return default(bool);
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600822A")]
		[Address(RVA = "0x2B02020", Offset = "0x2B00C20", VA = "0x182B02020")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x00038C40 File Offset: 0x00036E40
		[Token(Token = "0x600822B")]
		[Address(RVA = "0x2B02080", Offset = "0x2B00C80", VA = "0x182B02080")]
		private bool <>xLuaBaseProxy_TryFetchAndAddCameras(List<Camera> P0)
		{
			return default(bool);
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600822C")]
		[Address(RVA = "0x2B01FC0", Offset = "0x2B00BC0", VA = "0x182B01FC0")]
		private void <>xLuaBaseProxy_OnDisposeForReuse()
		{
		}

		// Token: 0x04008432 RID: 33842
		[Token(Token = "0x4008432")]
		private const float CAMERA_ANIMATION_CROSSFADE = 0.2f;

		// Token: 0x04008433 RID: 33843
		[Token(Token = "0x4008433")]
		private const string BAG_ANIMATION_START = "gacha_bag_start";

		// Token: 0x04008434 RID: 33844
		[Token(Token = "0x4008434")]
		private const string BAG_ANIMATION_OPEN = "gacha_bag_open";

		// Token: 0x04008435 RID: 33845
		[Token(Token = "0x4008435")]
		private const string CAMERA_ANIMATION_START = "gacha_main_cam_start";

		// Token: 0x04008436 RID: 33846
		[Token(Token = "0x4008436")]
		private const string CAMERA_ANIMATION_HOLD = "gacha_main_cam_loop";

		// Token: 0x04008437 RID: 33847
		[Token(Token = "0x4008437")]
		private const string CAMERA_ANIMATION_SHAKE = "gacha_main_cam_shake";

		// Token: 0x04008438 RID: 33848
		[Token(Token = "0x4008438")]
		private const string SPINE_ANIMATION_DEFAULT = "Gacha_Default";

		// Token: 0x04008439 RID: 33849
		[Token(Token = "0x4008439")]
		private const string SPINE_ANIMATION_ONE = "Gacha_One";

		// Token: 0x0400843A RID: 33850
		[Token(Token = "0x400843A")]
		private const string SPINE_ANIMATION_TEN = "Gacha_Ten";

		// Token: 0x0400843B RID: 33851
		[Token(Token = "0x400843B")]
		private const string FOLDER_ANIMATION_START = "gacha_folder_start";

		// Token: 0x0400843C RID: 33852
		[Token(Token = "0x400843C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GachaPhase0.Options _options;

		// Token: 0x0400843D RID: 33853
		[Token(Token = "0x400843D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400843E RID: 33854
		[Token(Token = "0x400843E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animation _bagAnimation;

		// Token: 0x0400843F RID: 33855
		[Token(Token = "0x400843F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animation _camAnimation;

		// Token: 0x04008440 RID: 33856
		[Token(Token = "0x4008440")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animation _folderAnimation;

		// Token: 0x04008441 RID: 33857
		[Token(Token = "0x4008441")]
		[FieldOffset(Offset = "0x40")]
		private StateMachine m_stateMachine;

		// Token: 0x04008442 RID: 33858
		[Token(Token = "0x4008442")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x04008443 RID: 33859
		[Token(Token = "0x4008443")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canSkip;

		// Token: 0x04008444 RID: 33860
		[Token(Token = "0x4008444")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasOwnCamera;

		// Token: 0x04008445 RID: 33861
		[Token(Token = "0x4008445")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stateDebugStr;

		// Token: 0x04008446 RID: 33862
		[Token(Token = "0x4008446")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008447 RID: 33863
		[Token(Token = "0x4008447")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimationState;

		// Token: 0x04008448 RID: 33864
		[Token(Token = "0x4008448")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04008449 RID: 33865
		[Token(Token = "0x4008449")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SkipToEnd;

		// Token: 0x0400844A RID: 33866
		[Token(Token = "0x400844A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PreloadSounds;

		// Token: 0x0400844B RID: 33867
		[Token(Token = "0x400844B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

		// Token: 0x0400844C RID: 33868
		[Token(Token = "0x400844C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0400844D RID: 33869
		[Token(Token = "0x400844D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0400844E RID: 33870
		[Token(Token = "0x400844E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0400844F RID: 33871
		[Token(Token = "0x400844F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSkipAllBtnClicked;

		// Token: 0x04008450 RID: 33872
		[Token(Token = "0x4008450")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDisposeForReuse;

		// Token: 0x04008451 RID: 33873
		[Token(Token = "0x4008451")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetAllAnimations;

		// Token: 0x04008452 RID: 33874
		[Token(Token = "0x4008452")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04008453 RID: 33875
		[Token(Token = "0x4008453")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04008454 RID: 33876
		[Token(Token = "0x4008454")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008455 RID: 33877
		[Token(Token = "0x4008455")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200166B RID: 5739
		[Token(Token = "0x200166B")]
		[Serializable]
		public class Options : StateMachine.DefaultBlackboard
		{
			// Token: 0x0600822D RID: 33325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600822D")]
			[Address(RVA = "0x2B08C30", Offset = "0x2B07830", VA = "0x182B08C30", Slot = "7")]
			public override void OnReset()
			{
			}

			// Token: 0x0600822E RID: 33326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600822E")]
			[Address(RVA = "0x2B08E60", Offset = "0x2B07A60", VA = "0x182B08E60")]
			public Options()
			{
			}

			// Token: 0x04008456 RID: 33878
			[Token(Token = "0x4008456")]
			[FieldOffset(Offset = "0x10")]
			[Group("Zipper")]
			public float zipperSpeed;

			// Token: 0x04008457 RID: 33879
			[Token(Token = "0x4008457")]
			[FieldOffset(Offset = "0x14")]
			[Group("Zipper")]
			public float zipperAutoThreshold;

			// Token: 0x04008458 RID: 33880
			[Token(Token = "0x4008458")]
			[FieldOffset(Offset = "0x18")]
			[Group("Zipper")]
			public float zipperAutoFlyCriteria;

			// Token: 0x04008459 RID: 33881
			[Token(Token = "0x4008459")]
			[FieldOffset(Offset = "0x1C")]
			[Group("Zipper")]
			public float zipperAutoFlyAttenuate;

			// Token: 0x0400845A RID: 33882
			[Token(Token = "0x400845A")]
			[FieldOffset(Offset = "0x20")]
			[Group("Zipper")]
			public float zipperHoldStillTime;

			// Token: 0x0400845B RID: 33883
			[Token(Token = "0x400845B")]
			[FieldOffset(Offset = "0x28")]
			[Group("Zipper")]
			public FxDelay zipperGuide;

			// Token: 0x0400845C RID: 33884
			[Token(Token = "0x400845C")]
			[FieldOffset(Offset = "0x30")]
			[Group("Zipper")]
			public GameObject[] zipperEffects;

			// Token: 0x0400845D RID: 33885
			[Token(Token = "0x400845D")]
			[FieldOffset(Offset = "0x38")]
			[Group("Light")]
			public float probToShowLowerBagLightWhenTopRarity;

			// Token: 0x0400845E RID: 33886
			[Token(Token = "0x400845E")]
			[FieldOffset(Offset = "0x40")]
			[Group("Light")]
			[Collection(6)]
			public GameObject[] gachaEffects;

			// Token: 0x0400845F RID: 33887
			[Token(Token = "0x400845F")]
			[FieldOffset(Offset = "0x48")]
			[Group("Light")]
			[Collection(6)]
			public BagLightController[] bagLights;

			// Token: 0x04008460 RID: 33888
			[Token(Token = "0x4008460")]
			[FieldOffset(Offset = "0x50")]
			[Group("Folder")]
			public Transform folderContainer;

			// Token: 0x04008461 RID: 33889
			[Token(Token = "0x4008461")]
			[FieldOffset(Offset = "0x58")]
			[Group("Folder")]
			public SkeletonAnimation folderSpine;

			// Token: 0x04008462 RID: 33890
			[Token(Token = "0x4008462")]
			[FieldOffset(Offset = "0x60")]
			[Group("Folder")]
			public FolderMultiSkin folderSkin;

			// Token: 0x04008463 RID: 33891
			[Token(Token = "0x4008463")]
			[FieldOffset(Offset = "0x68")]
			[Group("Folder")]
			public float folderEndTime;

			// Token: 0x04008464 RID: 33892
			[Token(Token = "0x4008464")]
			[FieldOffset(Offset = "0x70")]
			[Group("UI")]
			public Transform _skipContainer;

			// Token: 0x04008465 RID: 33893
			[Token(Token = "0x4008465")]
			[FieldOffset(Offset = "0x78")]
			[NonSerialized]
			public Action<PointerEventData> onDrag;

			// Token: 0x04008466 RID: 33894
			[Token(Token = "0x4008466")]
			[FieldOffset(Offset = "0x80")]
			[NonSerialized]
			public Action<PointerEventData> onBeginDrag;

			// Token: 0x04008467 RID: 33895
			[Token(Token = "0x4008467")]
			[FieldOffset(Offset = "0x88")]
			[NonSerialized]
			public Action<PointerEventData> onEndDrag;

			// Token: 0x04008468 RID: 33896
			[Token(Token = "0x4008468")]
			[FieldOffset(Offset = "0x90")]
			[NonSerialized]
			public PeriodicTimer zipperHoldStillTimer;
		}

		// Token: 0x0200166C RID: 5740
		[Token(Token = "0x200166C")]
		public static class States
		{
			// Token: 0x0600822F RID: 33327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600822F")]
			[Address(RVA = "0x2B0C510", Offset = "0x2B0B110", VA = "0x182B0C510")]
			public static StateMachine ConstructStateMachine(GachaPhase0 owner)
			{
				return null;
			}

			// Token: 0x0200166D RID: 5741
			[Token(Token = "0x200166D")]
			public enum State
			{
				// Token: 0x0400846A RID: 33898
				[Token(Token = "0x400846A")]
				DEFAULT,
				// Token: 0x0400846B RID: 33899
				[Token(Token = "0x400846B")]
				DROP,
				// Token: 0x0400846C RID: 33900
				[Token(Token = "0x400846C")]
				UNPACK,
				// Token: 0x0400846D RID: 33901
				[Token(Token = "0x400846D")]
				FOLDER,
				// Token: 0x0400846E RID: 33902
				[Token(Token = "0x400846E")]
				TERMINAL = -1
			}

			// Token: 0x0200166E RID: 5742
			[Token(Token = "0x200166E")]
			private class DropState : HierachyStateMachine<GachaPhase0.States.State, GachaPhase0, GachaPhase0.Options>.StateNode
			{
				// Token: 0x06008230 RID: 33328 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008230")]
				[Address(RVA = "0x2AFA450", Offset = "0x2AF9050", VA = "0x182AFA450", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06008231 RID: 33329 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008231")]
				[Address(RVA = "0x2AFA670", Offset = "0x2AF9270", VA = "0x182AFA670")]
				private void _GotoNext()
				{
				}

				// Token: 0x06008232 RID: 33330 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008232")]
				[Address(RVA = "0x2AFA6B0", Offset = "0x2AF92B0", VA = "0x182AFA6B0")]
				public DropState()
				{
				}
			}

			// Token: 0x0200166F RID: 5743
			[Token(Token = "0x200166F")]
			private class UnpackState : HierachyStateMachine<GachaPhase0.States.State, GachaPhase0, GachaPhase0.Options>.StateNode
			{
				// Token: 0x17000F76 RID: 3958
				// (get) Token: 0x06008233 RID: 33331 RVA: 0x00038C58 File Offset: 0x00036E58
				// (set) Token: 0x06008234 RID: 33332 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000F76")]
				public float progress
				{
					[Token(Token = "0x6008233")]
					[Address(RVA = "0x2B243C0", Offset = "0x2B22FC0", VA = "0x182B243C0")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x6008234")]
					[Address(RVA = "0x2B244B0", Offset = "0x2B230B0", VA = "0x182B244B0")]
					private set
					{
					}
				}

				// Token: 0x17000F77 RID: 3959
				// (get) Token: 0x06008235 RID: 33333 RVA: 0x00038C70 File Offset: 0x00036E70
				// (set) Token: 0x06008236 RID: 33334 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000F77")]
				private bool isZipperSePlaying
				{
					[Token(Token = "0x6008235")]
					[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6008236")]
					[Address(RVA = "0x2B24410", Offset = "0x2B23010", VA = "0x182B24410")]
					set
					{
					}
				}

				// Token: 0x06008237 RID: 33335 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008237")]
				[Address(RVA = "0x2B22B00", Offset = "0x2B21700", VA = "0x182B22B00", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06008238 RID: 33336 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008238")]
				[Address(RVA = "0x2B231B0", Offset = "0x2B21DB0", VA = "0x182B231B0", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x06008239 RID: 33337 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008239")]
				[Address(RVA = "0x2B230C0", Offset = "0x2B21CC0", VA = "0x182B230C0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600823A RID: 33338 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823A")]
				[Address(RVA = "0x2B23610", Offset = "0x2B22210", VA = "0x182B23610")]
				private void _BeginAutoPhase()
				{
				}

				// Token: 0x0600823B RID: 33339 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823B")]
				[Address(RVA = "0x2B23F30", Offset = "0x2B22B30", VA = "0x182B23F30")]
				private void _StopDragPhase()
				{
				}

				// Token: 0x0600823C RID: 33340 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823C")]
				[Address(RVA = "0x2B23B10", Offset = "0x2B22710", VA = "0x182B23B10")]
				private void _OnDrag(PointerEventData evData)
				{
				}

				// Token: 0x0600823D RID: 33341 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823D")]
				[Address(RVA = "0x2B23950", Offset = "0x2B22550", VA = "0x182B23950")]
				private void _OnBeginDrag(PointerEventData evData)
				{
				}

				// Token: 0x0600823E RID: 33342 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823E")]
				[Address(RVA = "0x2B23CC0", Offset = "0x2B228C0", VA = "0x182B23CC0")]
				private void _OnEndDrag(PointerEventData evData)
				{
				}

				// Token: 0x0600823F RID: 33343 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600823F")]
				[Address(RVA = "0x2B23910", Offset = "0x2B22510", VA = "0x182B23910")]
				private void _GotoNext()
				{
				}

				// Token: 0x06008240 RID: 33344 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008240")]
				[Address(RVA = "0x2B24380", Offset = "0x2B22F80", VA = "0x182B24380")]
				public UnpackState()
				{
				}

				// Token: 0x0400846F RID: 33903
				[Token(Token = "0x400846F")]
				[FieldOffset(Offset = "0x18")]
				private bool m_isAuto;

				// Token: 0x04008470 RID: 33904
				[Token(Token = "0x4008470")]
				[FieldOffset(Offset = "0x19")]
				private bool m_isZipperSePlaying;

				// Token: 0x04008471 RID: 33905
				[Token(Token = "0x4008471")]
				[FieldOffset(Offset = "0x20")]
				private AnimationState m_animState;

				// Token: 0x04008472 RID: 33906
				[Token(Token = "0x4008472")]
				[FieldOffset(Offset = "0x28")]
				private BagLightController m_bagLight;

				// Token: 0x04008473 RID: 33907
				[Token(Token = "0x4008473")]
				[FieldOffset(Offset = "0x30")]
				private float m_remainingDelta;

				// Token: 0x04008474 RID: 33908
				[Token(Token = "0x4008474")]
				[FieldOffset(Offset = "0x34")]
				private float m_cachedCurProgress;

				// Token: 0x04008475 RID: 33909
				[Token(Token = "0x4008475")]
				[FieldOffset(Offset = "0x38")]
				private float m_cachedLastProgress;
			}

			// Token: 0x02001670 RID: 5744
			[Token(Token = "0x2001670")]
			private class FolderState : HierachyStateMachine<GachaPhase0.States.State, GachaPhase0, GachaPhase0.Options>.StateNode
			{
				// Token: 0x06008241 RID: 33345 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008241")]
				[Address(RVA = "0x2AFAA20", Offset = "0x2AF9620", VA = "0x182AFAA20", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06008242 RID: 33346 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6008242")]
				[Address(RVA = "0x2AFABB0", Offset = "0x2AF97B0", VA = "0x182AFABB0")]
				private IEnumerator _DoAnimation()
				{
					return null;
				}

				// Token: 0x06008243 RID: 33347 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008243")]
				[Address(RVA = "0x2AFAC30", Offset = "0x2AF9830", VA = "0x182AFAC30")]
				private void _GotoNext()
				{
				}

				// Token: 0x06008244 RID: 33348 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008244")]
				[Address(RVA = "0x2AFAC70", Offset = "0x2AF9870", VA = "0x182AFAC70")]
				public FolderState()
				{
				}
			}
		}
	}
}
