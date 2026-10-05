using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x02004006 RID: 16390
	[Token(Token = "0x2004006")]
	public class SandboxPermHomePage : StateEnginePage
	{
		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x06019613 RID: 103955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C83")]
		protected FadeSwitchTween blackLoadingSwitch
		{
			[Token(Token = "0x6019613")]
			[Address(RVA = "0x1217A50", Offset = "0x1216650", VA = "0x181217A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x06019614 RID: 103956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C84")]
		public string topicId
		{
			[Token(Token = "0x6019614")]
			[Address(RVA = "0x1217B40", Offset = "0x1216740", VA = "0x181217B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x06019615 RID: 103957 RVA: 0x0009DDD0 File Offset: 0x0009BFD0
		[Token(Token = "0x17003C85")]
		public bool backFromBattle
		{
			[Token(Token = "0x6019615")]
			[Address(RVA = "0x12179D0", Offset = "0x12165D0", VA = "0x1812179D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019616 RID: 103958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019616")]
		[Address(RVA = "0x1217110", Offset = "0x1215D10", VA = "0x181217110", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06019617 RID: 103959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019617")]
		[Address(RVA = "0x1216DC0", Offset = "0x12159C0", VA = "0x181216DC0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06019618 RID: 103960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019618")]
		[Address(RVA = "0x1216FF0", Offset = "0x1215BF0", VA = "0x181216FF0", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06019619 RID: 103961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019619")]
		[Address(RVA = "0x1216D00", Offset = "0x1215900", VA = "0x181216D00", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601961A RID: 103962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601961A")]
		[Address(RVA = "0x1216C20", Offset = "0x1215820", VA = "0x181216C20", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601961B RID: 103963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601961B")]
		[Address(RVA = "0x12177D0", Offset = "0x12163D0", VA = "0x1812177D0")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x0601961C RID: 103964 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
		[Token(Token = "0x601961C")]
		[Address(RVA = "0x12176C0", Offset = "0x12162C0", VA = "0x1812176C0")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0601961D RID: 103965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601961D")]
		[Address(RVA = "0x12173C0", Offset = "0x1215FC0", VA = "0x1812173C0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601961E RID: 103966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601961E")]
		[Address(RVA = "0x12174A0", Offset = "0x12160A0", VA = "0x1812174A0")]
		private void _EventBackClick()
		{
		}

		// Token: 0x0601961F RID: 103967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601961F")]
		[Address(RVA = "0x1217720", Offset = "0x1216320", VA = "0x181217720")]
		private IEnumerator _TopicEnterShowEffect()
		{
			return null;
		}

		// Token: 0x06019620 RID: 103968 RVA: 0x0009DE00 File Offset: 0x0009C000
		[Token(Token = "0x6019620")]
		[Address(RVA = "0x1217330", Offset = "0x1215F30", VA = "0x181217330")]
		private bool _CheckIfUseFastEnterAndMarkTrace()
		{
			return default(bool);
		}

		// Token: 0x06019621 RID: 103969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019621")]
		[Address(RVA = "0x1217940", Offset = "0x1216540", VA = "0x181217940")]
		public SandboxPermHomePage()
		{
		}

		// Token: 0x06019625 RID: 103973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019625")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06019626 RID: 103974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019626")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06019627 RID: 103975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019627")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06019628 RID: 103976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019628")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06019629 RID: 103977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019629")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0401F93A RID: 129338
		[Token(Token = "0x401F93A")]
		private const float DUR_BLACK_LOADING_FADEIN = 0.3f;

		// Token: 0x0401F93B RID: 129339
		[Token(Token = "0x401F93B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0401F93C RID: 129340
		[Token(Token = "0x401F93C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _canvasBlackLoading;

		// Token: 0x0401F93D RID: 129341
		[Token(Token = "0x401F93D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _canvasTopLayer;

		// Token: 0x0401F93E RID: 129342
		[Token(Token = "0x401F93E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _canvasHomeState;

		// Token: 0x0401F93F RID: 129343
		[Token(Token = "0x401F93F")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_blackLoadingTween;

		// Token: 0x0401F940 RID: 129344
		[Token(Token = "0x401F940")]
		[FieldOffset(Offset = "0x118")]
		private string m_topicId;

		// Token: 0x0401F941 RID: 129345
		[Token(Token = "0x401F941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_blackLoadingSwitch;

		// Token: 0x0401F942 RID: 129346
		[Token(Token = "0x401F942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401F943 RID: 129347
		[Token(Token = "0x401F943")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_backFromBattle;

		// Token: 0x0401F944 RID: 129348
		[Token(Token = "0x401F944")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401F945 RID: 129349
		[Token(Token = "0x401F945")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401F946 RID: 129350
		[Token(Token = "0x401F946")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F947 RID: 129351
		[Token(Token = "0x401F947")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0401F948 RID: 129352
		[Token(Token = "0x401F948")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0401F949 RID: 129353
		[Token(Token = "0x401F949")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x0401F94A RID: 129354
		[Token(Token = "0x401F94A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x0401F94B RID: 129355
		[Token(Token = "0x401F94B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x0401F94C RID: 129356
		[Token(Token = "0x401F94C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventBackClick;

		// Token: 0x0401F94D RID: 129357
		[Token(Token = "0x401F94D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TopicEnterShowEffect;

		// Token: 0x0401F94E RID: 129358
		[Token(Token = "0x401F94E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckIfUseFastEnterAndMarkTrace;

		// Token: 0x0401F94F RID: 129359
		[Token(Token = "0x401F94F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004007 RID: 16391
		[Token(Token = "0x2004007")]
		public class Param
		{
			// Token: 0x0601962A RID: 103978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601962A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401F950 RID: 129360
			[Token(Token = "0x401F950")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0401F951 RID: 129361
			[Token(Token = "0x401F951")]
			[FieldOffset(Offset = "0x18")]
			public bool backFromBattle;
		}

		// Token: 0x02004008 RID: 16392
		[Token(Token = "0x2004008")]
		[Serializable]
		public struct DisplayTweenConfig
		{
			// Token: 0x0401F952 RID: 129362
			[Token(Token = "0x401F952")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[NonSerialized]
			public static readonly SandboxPermHomePage.DisplayTweenConfig FAST_MODE;

			// Token: 0x0401F953 RID: 129363
			[Token(Token = "0x401F953")]
			[FieldOffset(Offset = "0x0")]
			public float delay;

			// Token: 0x0401F954 RID: 129364
			[Token(Token = "0x401F954")]
			[FieldOffset(Offset = "0x4")]
			public float duration;
		}
	}
}
