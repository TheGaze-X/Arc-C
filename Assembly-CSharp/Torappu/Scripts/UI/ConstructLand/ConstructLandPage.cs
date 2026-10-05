using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Sandbox;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017AD RID: 6061
	[Token(Token = "0x20017AD")]
	public class ConstructLandPage : UIPage, ConstructBattleSceneUser
	{
		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06009916 RID: 39190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001074")]
		public ConstructLandPageProp prop
		{
			[Token(Token = "0x6009916")]
			[Address(RVA = "0x3142010", Offset = "0x3140C10", VA = "0x183142010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001075")]
		public ConstructPageMsg pageMsg
		{
			[Token(Token = "0x6009917")]
			[Address(RVA = "0x3141FB0", Offset = "0x3140BB0", VA = "0x183141FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009918")]
		[Address(RVA = "0x3141660", Offset = "0x3140260", VA = "0x183141660")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009919")]
		[Address(RVA = "0x31406A0", Offset = "0x313F2A0", VA = "0x1831406A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991A")]
		[Address(RVA = "0x3140AD0", Offset = "0x313F6D0", VA = "0x183140AD0", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x0003B940 File Offset: 0x00039B40
		[Token(Token = "0x600991B")]
		[Address(RVA = "0x3140EA0", Offset = "0x313FAA0", VA = "0x183140EA0", Slot = "24")]
		public bool RequestExit()
		{
			return default(bool);
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600991C")]
		[Address(RVA = "0x3141960", Offset = "0x3140560", VA = "0x183141960")]
		private IEnumerator _SetupLoad()
		{
			return null;
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991D")]
		[Address(RVA = "0x3141D20", Offset = "0x3140920", VA = "0x183141D20")]
		private void _UpdateTextTips()
		{
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991E")]
		[Address(RVA = "0x3141410", Offset = "0x3140010", VA = "0x183141410")]
		private void _DoLoadScene()
		{
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991F")]
		[Address(RVA = "0x31417E0", Offset = "0x31403E0", VA = "0x1831417E0")]
		private void _OnLandLoaded()
		{
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009920")]
		[Address(RVA = "0x3141360", Offset = "0x313FF60", VA = "0x183141360")]
		private IEnumerator _ClosePageWithTrans()
		{
			return null;
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009921")]
		[Address(RVA = "0x3141C50", Offset = "0x3140850", VA = "0x183141C50")]
		private void _TryUnloadLand()
		{
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009922")]
		[Address(RVA = "0x31418A0", Offset = "0x31404A0", VA = "0x1831418A0")]
		private void _OnLandUnloaded()
		{
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009923")]
		[Address(RVA = "0x3140B40", Offset = "0x313F740", VA = "0x183140B40", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009924")]
		[Address(RVA = "0x3140D20", Offset = "0x313F920", VA = "0x183140D20", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009925")]
		[Address(RVA = "0x3140FB0", Offset = "0x313FBB0", VA = "0x183140FB0")]
		private void Update()
		{
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009926")]
		[Address(RVA = "0x3141010", Offset = "0x313FC10", VA = "0x183141010")]
		private void _BindIfNot()
		{
		}

		// Token: 0x06009927 RID: 39207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009927")]
		[Address(RVA = "0x3141AC0", Offset = "0x31406C0", VA = "0x183141AC0")]
		private void _TriggerSandboxV2ConstructBGM()
		{
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009928")]
		[Address(RVA = "0x3141280", Offset = "0x313FE80", VA = "0x183141280")]
		private void _ClearBGM()
		{
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x0003B958 File Offset: 0x00039B58
		[Token(Token = "0x6009929")]
		[Address(RVA = "0x3141600", Offset = "0x3140200", VA = "0x183141600")]
		private int _GetBGMInstId()
		{
			return 0;
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600992A")]
		[Address(RVA = "0x3141A10", Offset = "0x3140610", VA = "0x183141A10")]
		private IEnumerator _ShowMask()
		{
			return null;
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600992B")]
		[Address(RVA = "0x31405C0", Offset = "0x313F1C0", VA = "0x1831405C0", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992C")]
		[Address(RVA = "0x3141F50", Offset = "0x3140B50", VA = "0x183141F50")]
		public ConstructLandPage()
		{
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992F")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009930")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009931")]
		[Address(RVA = "0xE98780", Offset = "0xE97380", VA = "0x180E98780")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009932")]
		[Address(RVA = "0xE98790", Offset = "0xE97390", VA = "0x180E98790")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009933")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04008F38 RID: 36664
		[Token(Token = "0x4008F38")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIFadeFloatPanel _maskView;

		// Token: 0x04008F39 RID: 36665
		[Token(Token = "0x4008F39")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private AnimationWrapper _animEnter;

		// Token: 0x04008F3A RID: 36666
		[Token(Token = "0x4008F3A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AnimationWrapper _animLoop;

		// Token: 0x04008F3B RID: 36667
		[Token(Token = "0x4008F3B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _maskImg;

		// Token: 0x04008F3C RID: 36668
		[Token(Token = "0x4008F3C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x04008F3D RID: 36669
		[Token(Token = "0x4008F3D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x04008F3E RID: 36670
		[Token(Token = "0x4008F3E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ConstructLandPageController _sceneBinder;

		// Token: 0x04008F3F RID: 36671
		[Token(Token = "0x4008F3F")]
		[FieldOffset(Offset = "0x110")]
		private bool m_isInited;

		// Token: 0x04008F40 RID: 36672
		[Token(Token = "0x4008F40")]
		[FieldOffset(Offset = "0x118")]
		private ConstructLandPage.LoadingShowSwitchTween m_switchTween;

		// Token: 0x04008F41 RID: 36673
		[Token(Token = "0x4008F41")]
		private const float MASK_MIN_TIME = 0.5f;

		// Token: 0x04008F42 RID: 36674
		[Token(Token = "0x4008F42")]
		[FieldOffset(Offset = "0x120")]
		private ConstructLandPage.Params m_param;

		// Token: 0x04008F43 RID: 36675
		[Token(Token = "0x4008F43")]
		[FieldOffset(Offset = "0x158")]
		private bool m_alreadyDoLoad;

		// Token: 0x04008F44 RID: 36676
		[Token(Token = "0x4008F44")]
		[FieldOffset(Offset = "0x159")]
		private bool m_alreadyLoaded;

		// Token: 0x04008F45 RID: 36677
		[Token(Token = "0x4008F45")]
		[FieldOffset(Offset = "0x15A")]
		private bool m_binded;

		// Token: 0x04008F46 RID: 36678
		[Token(Token = "0x4008F46")]
		[FieldOffset(Offset = "0x160")]
		private ConstructLandPageProp m_prop;

		// Token: 0x04008F47 RID: 36679
		[Token(Token = "0x4008F47")]
		[FieldOffset(Offset = "0x168")]
		private ConstructPageMsg m_pageMsg;

		// Token: 0x04008F48 RID: 36680
		[Token(Token = "0x4008F48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04008F49 RID: 36681
		[Token(Token = "0x4008F49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageMsg;

		// Token: 0x04008F4A RID: 36682
		[Token(Token = "0x4008F4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04008F4B RID: 36683
		[Token(Token = "0x4008F4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04008F4C RID: 36684
		[Token(Token = "0x4008F4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04008F4D RID: 36685
		[Token(Token = "0x4008F4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RequestExit;

		// Token: 0x04008F4E RID: 36686
		[Token(Token = "0x4008F4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetupLoad;

		// Token: 0x04008F4F RID: 36687
		[Token(Token = "0x4008F4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateTextTips;

		// Token: 0x04008F50 RID: 36688
		[Token(Token = "0x4008F50")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoLoadScene;

		// Token: 0x04008F51 RID: 36689
		[Token(Token = "0x4008F51")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnLandLoaded;

		// Token: 0x04008F52 RID: 36690
		[Token(Token = "0x4008F52")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClosePageWithTrans;

		// Token: 0x04008F53 RID: 36691
		[Token(Token = "0x4008F53")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryUnloadLand;

		// Token: 0x04008F54 RID: 36692
		[Token(Token = "0x4008F54")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnLandUnloaded;

		// Token: 0x04008F55 RID: 36693
		[Token(Token = "0x4008F55")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04008F56 RID: 36694
		[Token(Token = "0x4008F56")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04008F57 RID: 36695
		[Token(Token = "0x4008F57")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008F58 RID: 36696
		[Token(Token = "0x4008F58")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__BindIfNot;

		// Token: 0x04008F59 RID: 36697
		[Token(Token = "0x4008F59")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TriggerSandboxV2ConstructBGM;

		// Token: 0x04008F5A RID: 36698
		[Token(Token = "0x4008F5A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04008F5B RID: 36699
		[Token(Token = "0x4008F5B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x04008F5C RID: 36700
		[Token(Token = "0x4008F5C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ShowMask;

		// Token: 0x04008F5D RID: 36701
		[Token(Token = "0x4008F5D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04008F5E RID: 36702
		[Token(Token = "0x4008F5E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020017AE RID: 6062
		[Token(Token = "0x20017AE")]
		public struct Params
		{
			// Token: 0x04008F5F RID: 36703
			[Token(Token = "0x4008F5F")]
			[FieldOffset(Offset = "0x0")]
			public string loadingIllust;

			// Token: 0x04008F60 RID: 36704
			[Token(Token = "0x4008F60")]
			[FieldOffset(Offset = "0x8")]
			public string unloadingIllust;

			// Token: 0x04008F61 RID: 36705
			[Token(Token = "0x4008F61")]
			[FieldOffset(Offset = "0x10")]
			public string sceneName;

			// Token: 0x04008F62 RID: 36706
			[Token(Token = "0x4008F62")]
			[FieldOffset(Offset = "0x18")]
			public SandboxInput sandboxInput;

			// Token: 0x04008F63 RID: 36707
			[Token(Token = "0x4008F63")]
			[FieldOffset(Offset = "0x20")]
			public GameModeMeta.GameModeType gameMode;

			// Token: 0x04008F64 RID: 36708
			[Token(Token = "0x4008F64")]
			[FieldOffset(Offset = "0x28")]
			public string homeBuildModeBGM;

			// Token: 0x04008F65 RID: 36709
			[Token(Token = "0x4008F65")]
			[FieldOffset(Offset = "0x30")]
			public string nodeId;
		}

		// Token: 0x020017AF RID: 6063
		[Token(Token = "0x20017AF")]
		private class LoadingShowSwitchTween : UISwitchTween
		{
			// Token: 0x06009934 RID: 39220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009934")]
			[Address(RVA = "0x31471B0", Offset = "0x3145DB0", VA = "0x1831471B0")]
			public LoadingShowSwitchTween(UIFadeFloatPanel maskView, AnimationWrapper entry, AnimationWrapper loop)
			{
			}

			// Token: 0x06009935 RID: 39221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009935")]
			[Address(RVA = "0x3146E80", Offset = "0x3145A80", VA = "0x183146E80", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06009936 RID: 39222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009936")]
			[Address(RVA = "0x3146F50", Offset = "0x3145B50", VA = "0x183146F50", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06009937 RID: 39223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009937")]
			[Address(RVA = "0x3146C80", Offset = "0x3145880", VA = "0x183146C80", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06009938 RID: 39224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009938")]
			[Address(RVA = "0x3146D50", Offset = "0x3145950", VA = "0x183146D50", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06009939 RID: 39225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009939")]
			[Address(RVA = "0x3147020", Offset = "0x3145C20", VA = "0x183147020", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0600993A RID: 39226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600993A")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0600993B RID: 39227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600993B")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0600993C RID: 39228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600993C")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04008F66 RID: 36710
			[Token(Token = "0x4008F66")]
			[FieldOffset(Offset = "0x48")]
			private AnimationWrapper m_anim1;

			// Token: 0x04008F67 RID: 36711
			[Token(Token = "0x4008F67")]
			[FieldOffset(Offset = "0x50")]
			private AnimationWrapper m_anim2;

			// Token: 0x04008F68 RID: 36712
			[Token(Token = "0x4008F68")]
			[FieldOffset(Offset = "0x58")]
			private UIFadeFloatPanel m_maskView;

			// Token: 0x04008F69 RID: 36713
			[Token(Token = "0x4008F69")]
			[FieldOffset(Offset = "0x60")]
			private Tween m_selectionLoopTween;

			// Token: 0x04008F6A RID: 36714
			[Token(Token = "0x4008F6A")]
			private const string LOADING_ENTER_ANIM = "loading_enter";

			// Token: 0x04008F6B RID: 36715
			[Token(Token = "0x4008F6B")]
			private const string LOADING_HIDE_ANIM = "loading_hide";

			// Token: 0x04008F6C RID: 36716
			[Token(Token = "0x4008F6C")]
			private const string LOADING_LOOP_ANIM = "loading_loop";

			// Token: 0x04008F6D RID: 36717
			[Token(Token = "0x4008F6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04008F6E RID: 36718
			[Token(Token = "0x4008F6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04008F6F RID: 36719
			[Token(Token = "0x4008F6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04008F70 RID: 36720
			[Token(Token = "0x4008F70")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04008F71 RID: 36721
			[Token(Token = "0x4008F71")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04008F72 RID: 36722
			[Token(Token = "0x4008F72")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
