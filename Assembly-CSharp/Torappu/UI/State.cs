using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200365D RID: 13917
	[Token(Token = "0x200365D")]
	public abstract class State : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016246 RID: 90694 RVA: 0x0008FB08 File Offset: 0x0008DD08
		[Token(Token = "0x6016246")]
		[Address(RVA = "0xE9BBB0", Offset = "0xE9A7B0", VA = "0x180E9BBB0")]
		public static bool IsState(Type state)
		{
			return default(bool);
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x06016247 RID: 90695 RVA: 0x0008FB20 File Offset: 0x0008DD20
		[Token(Token = "0x1700352F")]
		public virtual AVGPageKey avgPage
		{
			[Token(Token = "0x6016247")]
			[Address(RVA = "0xE9D270", Offset = "0xE9BE70", VA = "0x180E9D270", Slot = "4")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x06016248 RID: 90696 RVA: 0x0008FB38 File Offset: 0x0008DD38
		// (set) Token: 0x06016249 RID: 90697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003530")]
		public bool isPreloadReady
		{
			[Token(Token = "0x6016248")]
			[Address(RVA = "0xE9D330", Offset = "0xE9BF30", VA = "0x180E9D330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016249")]
			[Address(RVA = "0xE9D450", Offset = "0xE9C050", VA = "0x180E9D450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601624A RID: 90698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601624A")]
		[Address(RVA = "0xE9C400", Offset = "0xE9B000", VA = "0x180E9C400")]
		public void TriggerEnter(StateTransOptions options)
		{
		}

		// Token: 0x0601624B RID: 90699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601624B")]
		[Address(RVA = "0xE9C870", Offset = "0xE9B470", VA = "0x180E9C870", Slot = "5")]
		public virtual void TriggerPreResume(StateTransOptions options, bool isFromStack)
		{
		}

		// Token: 0x0601624C RID: 90700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601624C")]
		[Address(RVA = "0xE9CA70", Offset = "0xE9B670", VA = "0x180E9CA70", Slot = "6")]
		public virtual void TriggerResume(StateTransOptions options, bool bForceBackwardMode = false)
		{
		}

		// Token: 0x0601624D RID: 90701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601624D")]
		[Address(RVA = "0xE9C6F0", Offset = "0xE9B2F0", VA = "0x180E9C6F0", Slot = "7")]
		public virtual void TriggerPause(StateTransOptions options)
		{
		}

		// Token: 0x0601624E RID: 90702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601624E")]
		[Address(RVA = "0xE9C570", Offset = "0xE9B170", VA = "0x180E9C570", Slot = "8")]
		public virtual void TriggerExit(StateTransOptions options)
		{
		}

		// Token: 0x0601624F RID: 90703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601624F")]
		[Address(RVA = "0xE9C9C0", Offset = "0xE9B5C0", VA = "0x180E9C9C0")]
		public IEnumerator TriggerPreload()
		{
			return null;
		}

		// Token: 0x06016250 RID: 90704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016250")]
		[Address(RVA = "0xE9B7B0", Offset = "0xE9A3B0", VA = "0x180E9B7B0")]
		public DataTransAction FindAction2GiveData(Type toState)
		{
			return null;
		}

		// Token: 0x06016251 RID: 90705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016251")]
		[Address(RVA = "0xE9B8C0", Offset = "0xE9A4C0", VA = "0x180E9B8C0")]
		public DataTransAction FindAction2ReceiveData(Type fromState)
		{
			return null;
		}

		// Token: 0x06016252 RID: 90706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016252")]
		[Address(RVA = "0xE9BF90", Offset = "0xE9AB90", VA = "0x180E9BF90")]
		public ITransAction PrepareEnterTransAction(StateTransOptions transOptions)
		{
			return null;
		}

		// Token: 0x06016253 RID: 90707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016253")]
		[Address(RVA = "0xE9C030", Offset = "0xE9AC30", VA = "0x180E9C030")]
		public ITransAction PreparePreResumeTransAction(StateTransOptions transOptions, bool isForwardTransition)
		{
			return null;
		}

		// Token: 0x06016254 RID: 90708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016254")]
		[Address(RVA = "0xE9B9D0", Offset = "0xE9A5D0", VA = "0x180E9B9D0")]
		public UIPage GetPage()
		{
			return null;
		}

		// Token: 0x06016255 RID: 90709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016255")]
		public PageType GetPage<PageType>() where PageType : UIPage
		{
			return null;
		}

		// Token: 0x06016256 RID: 90710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016256")]
		[Address(RVA = "0xE9C240", Offset = "0xE9AE40", VA = "0x180E9C240")]
		public Coroutine StateEngineCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x06016257 RID: 90711 RVA: 0x0008FB50 File Offset: 0x0008DD50
		[Token(Token = "0x17003531")]
		protected bool isResumedFromStack
		{
			[Token(Token = "0x6016257")]
			[Address(RVA = "0xE9D390", Offset = "0xE9BF90", VA = "0x180E9D390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x06016258 RID: 90712 RVA: 0x0008FB68 File Offset: 0x0008DD68
		[Token(Token = "0x17003532")]
		protected bool isResumed
		{
			[Token(Token = "0x6016258")]
			[Address(RVA = "0xE9D3F0", Offset = "0xE9BFF0", VA = "0x180E9D3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016259 RID: 90713
		[Token(Token = "0x6016259")]
		public abstract IStateBean GetCacheBean();

		// Token: 0x0601625A RID: 90714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601625A")]
		[Address(RVA = "0xE9C160", Offset = "0xE9AD60", VA = "0x180E9C160", Slot = "10")]
		public virtual Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601625B RID: 90715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601625B")]
		[Address(RVA = "0xE9C100", Offset = "0xE9AD00", VA = "0x180E9C100", Slot = "11")]
		public virtual Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601625C RID: 90716 RVA: 0x0008FB80 File Offset: 0x0008DD80
		[Token(Token = "0x601625C")]
		[Address(RVA = "0xE9CC60", Offset = "0xE9B860", VA = "0x180E9CC60", Slot = "12")]
		public virtual bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0601625D RID: 90717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003533")]
		public virtual IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601625D")]
			[Address(RVA = "0xE9D2D0", Offset = "0xE9BED0", VA = "0x180E9D2D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601625E RID: 90718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601625E")]
		[Address(RVA = "0xE9BC90", Offset = "0xE9A890", VA = "0x180E9BC90", Slot = "14")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0601625F RID: 90719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601625F")]
		[Address(RVA = "0xE9BEA0", Offset = "0xE9AAA0", VA = "0x180E9BEA0", Slot = "15")]
		protected virtual void OnResume()
		{
		}

		// Token: 0x06016260 RID: 90720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016260")]
		[Address(RVA = "0xE9BDB0", Offset = "0xE9A9B0", VA = "0x180E9BDB0", Slot = "16")]
		protected virtual void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06016261 RID: 90721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016261")]
		[Address(RVA = "0xE9BD50", Offset = "0xE9A950", VA = "0x180E9BD50", Slot = "17")]
		protected virtual void OnPause()
		{
		}

		// Token: 0x06016262 RID: 90722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016262")]
		[Address(RVA = "0xE9BCF0", Offset = "0xE9A8F0", VA = "0x180E9BCF0", Slot = "18")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x06016263 RID: 90723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016263")]
		[Address(RVA = "0xE9BE10", Offset = "0xE9AA10", VA = "0x180E9BE10", Slot = "19")]
		protected virtual IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x06016264 RID: 90724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016264")]
		[Address(RVA = "0xE9BF00", Offset = "0xE9AB00", VA = "0x180E9BF00", Slot = "20")]
		public virtual ITransAction PickDynamicTransAction(State otherState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x06016265 RID: 90725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016265")]
		[Address(RVA = "0xE9C1C0", Offset = "0xE9ADC0", VA = "0x180E9C1C0")]
		public void Setup(IStateEngine engine)
		{
		}

		// Token: 0x06016266 RID: 90726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016266")]
		[Address(RVA = "0xE9BAB0", Offset = "0xE9A6B0", VA = "0x180E9BAB0", Slot = "21")]
		public IStateEngine GetSupportStateEngine()
		{
			return null;
		}

		// Token: 0x06016267 RID: 90727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016267")]
		[Address(RVA = "0xE9B5D0", Offset = "0xE9A1D0", VA = "0x180E9B5D0", Slot = "22")]
		public virtual void DismissSelf()
		{
		}

		// Token: 0x06016268 RID: 90728 RVA: 0x0008FB98 File Offset: 0x0008DD98
		[Token(Token = "0x6016268")]
		[Address(RVA = "0xE9CF60", Offset = "0xE9BB60", VA = "0x180E9CF60")]
		private bool _PreCheckEngine()
		{
			return default(bool);
		}

		// Token: 0x06016269 RID: 90729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016269")]
		[Address(RVA = "0xE9CCD0", Offset = "0xE9B8D0", VA = "0x180E9CCD0")]
		private static void _InitDataTransActions(out Dictionary<Type, DataTransAction> outDict, Dictionary<Type, Action<IStateBean>> inDict, TransitionSide side)
		{
		}

		// Token: 0x0601626A RID: 90730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601626A")]
		[Address(RVA = "0xE9D060", Offset = "0xE9BC60", VA = "0x180E9D060")]
		private void _UpdateLifeTimeStatusWhenEnter()
		{
		}

		// Token: 0x0601626B RID: 90731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601626B")]
		[Address(RVA = "0xE9D180", Offset = "0xE9BD80", VA = "0x180E9D180")]
		private void _UpdateLifeTimeStatusWhenResume(bool bForceBackwardMode)
		{
		}

		// Token: 0x0601626C RID: 90732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601626C")]
		[Address(RVA = "0xE9D120", Offset = "0xE9BD20", VA = "0x180E9D120")]
		private void _UpdateLifeTimeStatusWhenPause()
		{
		}

		// Token: 0x0601626D RID: 90733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601626D")]
		[Address(RVA = "0xE9D0C0", Offset = "0xE9BCC0", VA = "0x180E9D0C0")]
		private void _UpdateLifeTimeStatusWhenExit()
		{
		}

		// Token: 0x0601626E RID: 90734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601626E")]
		[Address(RVA = "0xE9D210", Offset = "0xE9BE10", VA = "0x180E9D210")]
		protected State()
		{
		}

		// Token: 0x0401A9DD RID: 109021
		[Token(Token = "0x401A9DD")]
		[FieldOffset(Offset = "0x18")]
		private State.InnerLifeTime m_lifeTime;

		// Token: 0x0401A9DE RID: 109022
		[Token(Token = "0x401A9DE")]
		[FieldOffset(Offset = "0x1C")]
		private State.LifeTimeStatus m_lifeStatus;

		// Token: 0x0401A9DF RID: 109023
		[Token(Token = "0x401A9DF")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, DataTransAction> m_dynamicGiveDataTransActions;

		// Token: 0x0401A9E0 RID: 109024
		[Token(Token = "0x401A9E0")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, DataTransAction> m_dynamicReceiveDataTransActions;

		// Token: 0x0401A9E1 RID: 109025
		[Token(Token = "0x401A9E1")]
		[FieldOffset(Offset = "0x30")]
		private State.EnterTransAction m_enterTransAction;

		// Token: 0x0401A9E2 RID: 109026
		[Token(Token = "0x401A9E2")]
		[FieldOffset(Offset = "0x38")]
		private State.PreResumeTransAction m_preResumeTransAction;

		// Token: 0x0401A9E4 RID: 109028
		[Token(Token = "0x401A9E4")]
		[FieldOffset(Offset = "0x48")]
		private IStateEngine m_supportEngine;

		// Token: 0x0401A9E5 RID: 109029
		[Token(Token = "0x401A9E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsState;

		// Token: 0x0401A9E6 RID: 109030
		[Token(Token = "0x401A9E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x0401A9E7 RID: 109031
		[Token(Token = "0x401A9E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isPreloadReady;

		// Token: 0x0401A9E8 RID: 109032
		[Token(Token = "0x401A9E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isPreloadReady;

		// Token: 0x0401A9E9 RID: 109033
		[Token(Token = "0x401A9E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerEnter;

		// Token: 0x0401A9EA RID: 109034
		[Token(Token = "0x401A9EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TriggerPreResume;

		// Token: 0x0401A9EB RID: 109035
		[Token(Token = "0x401A9EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TriggerResume;

		// Token: 0x0401A9EC RID: 109036
		[Token(Token = "0x401A9EC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerPause;

		// Token: 0x0401A9ED RID: 109037
		[Token(Token = "0x401A9ED")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TriggerExit;

		// Token: 0x0401A9EE RID: 109038
		[Token(Token = "0x401A9EE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TriggerPreload;

		// Token: 0x0401A9EF RID: 109039
		[Token(Token = "0x401A9EF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FindAction2GiveData;

		// Token: 0x0401A9F0 RID: 109040
		[Token(Token = "0x401A9F0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FindAction2ReceiveData;

		// Token: 0x0401A9F1 RID: 109041
		[Token(Token = "0x401A9F1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PrepareEnterTransAction;

		// Token: 0x0401A9F2 RID: 109042
		[Token(Token = "0x401A9F2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PreparePreResumeTransAction;

		// Token: 0x0401A9F3 RID: 109043
		[Token(Token = "0x401A9F3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetPage;

		// Token: 0x0401A9F4 RID: 109044
		[Token(Token = "0x401A9F4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_GetPage;

		// Token: 0x0401A9F5 RID: 109045
		[Token(Token = "0x401A9F5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_StateEngineCoroutine;

		// Token: 0x0401A9F6 RID: 109046
		[Token(Token = "0x401A9F6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isResumedFromStack;

		// Token: 0x0401A9F7 RID: 109047
		[Token(Token = "0x401A9F7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isResumed;

		// Token: 0x0401A9F8 RID: 109048
		[Token(Token = "0x401A9F8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401A9F9 RID: 109049
		[Token(Token = "0x401A9F9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0401A9FA RID: 109050
		[Token(Token = "0x401A9FA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0401A9FB RID: 109051
		[Token(Token = "0x401A9FB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x0401A9FC RID: 109052
		[Token(Token = "0x401A9FC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401A9FD RID: 109053
		[Token(Token = "0x401A9FD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401A9FE RID: 109054
		[Token(Token = "0x401A9FE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0401A9FF RID: 109055
		[Token(Token = "0x401A9FF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0401AA00 RID: 109056
		[Token(Token = "0x401AA00")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401AA01 RID: 109057
		[Token(Token = "0x401AA01")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x0401AA02 RID: 109058
		[Token(Token = "0x401AA02")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_PickDynamicTransAction;

		// Token: 0x0401AA03 RID: 109059
		[Token(Token = "0x401AA03")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0401AA04 RID: 109060
		[Token(Token = "0x401AA04")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetSupportStateEngine;

		// Token: 0x0401AA05 RID: 109061
		[Token(Token = "0x401AA05")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x0401AA06 RID: 109062
		[Token(Token = "0x401AA06")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__PreCheckEngine;

		// Token: 0x0401AA07 RID: 109063
		[Token(Token = "0x401AA07")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InitDataTransActions;

		// Token: 0x0401AA08 RID: 109064
		[Token(Token = "0x401AA08")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__UpdateLifeTimeStatusWhenEnter;

		// Token: 0x0401AA09 RID: 109065
		[Token(Token = "0x401AA09")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__UpdateLifeTimeStatusWhenResume;

		// Token: 0x0401AA0A RID: 109066
		[Token(Token = "0x401AA0A")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__UpdateLifeTimeStatusWhenPause;

		// Token: 0x0401AA0B RID: 109067
		[Token(Token = "0x401AA0B")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UpdateLifeTimeStatusWhenExit;

		// Token: 0x0401AA0C RID: 109068
		[Token(Token = "0x401AA0C")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200365E RID: 13918
		[Token(Token = "0x200365E")]
		public enum LifeTimeStatus
		{
			// Token: 0x0401AA0E RID: 109070
			[Token(Token = "0x401AA0E")]
			NONE,
			// Token: 0x0401AA0F RID: 109071
			[Token(Token = "0x401AA0F")]
			ONTO_STACK,
			// Token: 0x0401AA10 RID: 109072
			[Token(Token = "0x401AA10")]
			HIDE_IN_STACK,
			// Token: 0x0401AA11 RID: 109073
			[Token(Token = "0x401AA11")]
			RESUMED_FROM_STACK,
			// Token: 0x0401AA12 RID: 109074
			[Token(Token = "0x401AA12")]
			OUT_OF_STACK
		}

		// Token: 0x0200365F RID: 13919
		[Token(Token = "0x200365F")]
		public struct TransEvent
		{
			// Token: 0x0401AA13 RID: 109075
			[Token(Token = "0x401AA13")]
			[FieldOffset(Offset = "0x0")]
			public State inst;

			// Token: 0x0401AA14 RID: 109076
			[Token(Token = "0x401AA14")]
			[FieldOffset(Offset = "0x8")]
			public StateTransOptions transOptions;

			// Token: 0x0401AA15 RID: 109077
			[Token(Token = "0x401AA15")]
			[FieldOffset(Offset = "0x9")]
			public bool isStateFromStack;
		}

		// Token: 0x02003660 RID: 13920
		[Token(Token = "0x2003660")]
		private abstract class LifecycleTransAction : ITransAction
		{
			// Token: 0x17003534 RID: 13620
			// (get) Token: 0x0601626F RID: 90735 RVA: 0x0008FBB0 File Offset: 0x0008DDB0
			// (set) Token: 0x06016270 RID: 90736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003534")]
			private protected StateTransOptions transOptions
			{
				[Token(Token = "0x601626F")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				[CompilerGenerated]
				protected get
				{
					return default(StateTransOptions);
				}
				[Token(Token = "0x6016270")]
				[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003535 RID: 13621
			// (get) Token: 0x06016271 RID: 90737 RVA: 0x0008FBC8 File Offset: 0x0008DDC8
			[Token(Token = "0x17003535")]
			public TransActionType ActionType
			{
				[Token(Token = "0x6016271")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x06016272 RID: 90738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016272")]
			public static void PrepareAction<TAction>(ref TAction action, State state, StateTransOptions options) where TAction : State.LifecycleTransAction, new()
			{
			}

			// Token: 0x06016273 RID: 90739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016273")]
			[Address(RVA = "0xE92FC0", Offset = "0xE91BC0", VA = "0x180E92FC0", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x06016274 RID: 90740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016274")]
			[Address(RVA = "0xE92FC0", Offset = "0xE91BC0", VA = "0x180E92FC0", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x06016275 RID: 90741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016275")]
			[Address(RVA = "0xE930F0", Offset = "0xE91CF0", VA = "0x180E930F0")]
			private void _ExecuteImpl(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x06016276 RID: 90742
			[Token(Token = "0x6016276")]
			protected abstract void TriggerLifeCycle(State toState);

			// Token: 0x06016277 RID: 90743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016277")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected LifecycleTransAction()
			{
			}

			// Token: 0x0401AA16 RID: 109078
			[Token(Token = "0x401AA16")]
			[FieldOffset(Offset = "0x10")]
			private State m_closure;
		}

		// Token: 0x02003661 RID: 13921
		[Token(Token = "0x2003661")]
		private class EnterTransAction : State.LifecycleTransAction
		{
			// Token: 0x06016278 RID: 90744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016278")]
			[Address(RVA = "0xE92230", Offset = "0xE90E30", VA = "0x180E92230", Slot = "7")]
			protected override void TriggerLifeCycle(State toState)
			{
			}

			// Token: 0x06016279 RID: 90745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016279")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EnterTransAction()
			{
			}
		}

		// Token: 0x02003662 RID: 13922
		[Token(Token = "0x2003662")]
		private class PreResumeTransAction : State.LifecycleTransAction
		{
			// Token: 0x0601627A RID: 90746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601627A")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			public void Init(bool isForwardTransition)
			{
			}

			// Token: 0x0601627B RID: 90747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601627B")]
			[Address(RVA = "0xE93DF0", Offset = "0xE929F0", VA = "0x180E93DF0", Slot = "7")]
			protected override void TriggerLifeCycle(State toState)
			{
			}

			// Token: 0x0601627C RID: 90748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601627C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PreResumeTransAction()
			{
			}

			// Token: 0x0401AA18 RID: 109080
			[Token(Token = "0x401AA18")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isForwardTransition;
		}

		// Token: 0x02003663 RID: 13923
		[Token(Token = "0x2003663")]
		private enum InnerLifeTime
		{
			// Token: 0x0401AA1A RID: 109082
			[Token(Token = "0x401AA1A")]
			NONE,
			// Token: 0x0401AA1B RID: 109083
			[Token(Token = "0x401AA1B")]
			ENTERED,
			// Token: 0x0401AA1C RID: 109084
			[Token(Token = "0x401AA1C")]
			RESUMED,
			// Token: 0x0401AA1D RID: 109085
			[Token(Token = "0x401AA1D")]
			PAUSED,
			// Token: 0x0401AA1E RID: 109086
			[Token(Token = "0x401AA1E")]
			EXITED
		}
	}
}
