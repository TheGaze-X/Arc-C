using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200452F RID: 17711
	[Token(Token = "0x200452F")]
	public class RoguelikeTopicEntry : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0601B044 RID: 110660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004041")]
		public RoguelikeTopicModeViewModelExtension extensionModel
		{
			[Token(Token = "0x601B044")]
			[Address(RVA = "0x14389E0", Offset = "0x14375E0", VA = "0x1814389E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x0601B045 RID: 110661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B046 RID: 110662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004042")]
		private protected string topicId
		{
			[Token(Token = "0x601B045")]
			[Address(RVA = "0x1438A40", Offset = "0x1437640", VA = "0x181438A40")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601B046")]
			[Address(RVA = "0x1438AA0", Offset = "0x14376A0", VA = "0x181438AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B047 RID: 110663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B047")]
		[Address(RVA = "0x1437C10", Offset = "0x1436810", VA = "0x181437C10")]
		public void EventOnAnnounceClicked()
		{
		}

		// Token: 0x0601B048 RID: 110664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B048")]
		[Address(RVA = "0x1437C80", Offset = "0x1436880", VA = "0x181437C80")]
		public void EventOnOpenBattlePath()
		{
		}

		// Token: 0x0601B049 RID: 110665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B049")]
		[Address(RVA = "0x1437E10", Offset = "0x1436A10", VA = "0x181437E10")]
		public void Init(RoguelikeTopicState.Bridge bridge, RoguelikeTopicController controller)
		{
		}

		// Token: 0x0601B04A RID: 110666 RVA: 0x000A3E48 File Offset: 0x000A2048
		[Token(Token = "0x601B04A")]
		[Address(RVA = "0x1437D40", Offset = "0x1436940", VA = "0x181437D40")]
		public RoguelikeTopicEntry.DisplayParentConfig GetDisplayParentConfig(bool useFastMode)
		{
			return default(RoguelikeTopicEntry.DisplayParentConfig);
		}

		// Token: 0x0601B04B RID: 110667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B04B")]
		[Address(RVA = "0x1438530", Offset = "0x1437130", VA = "0x181438530")]
		public Coroutine StartShowEffect(bool fastMode)
		{
			return null;
		}

		// Token: 0x0601B04C RID: 110668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B04C")]
		[Address(RVA = "0x14382E0", Offset = "0x1436EE0", VA = "0x1814382E0")]
		public void SetEffectsEnable(bool isEnable)
		{
		}

		// Token: 0x0601B04D RID: 110669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B04D")]
		[Address(RVA = "0x1438780", Offset = "0x1437380", VA = "0x181438780")]
		private void _TriggerTopicAvg(string topicId, Action nextStep)
		{
		}

		// Token: 0x0601B04E RID: 110670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B04E")]
		[Address(RVA = "0x14386C0", Offset = "0x14372C0", VA = "0x1814386C0")]
		private IEnumerator _ShowEffectCoroutine(bool useFastMode)
		{
			return null;
		}

		// Token: 0x0601B04F RID: 110671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B04F")]
		[Address(RVA = "0x1438980", Offset = "0x1437580", VA = "0x181438980")]
		public RoguelikeTopicEntry()
		{
		}

		// Token: 0x04022B37 RID: 142135
		[Token(Token = "0x4022B37")]
		private const string ROGUELIKE_TOPIC_ENTRY_AVG_TRIGGER = "ro_entry";

		// Token: 0x04022B38 RID: 142136
		[Token(Token = "0x4022B38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicModeViewModelExtension _modelExtension;

		// Token: 0x04022B39 RID: 142137
		[Token(Token = "0x4022B39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicModeTab[] _tabs;

		// Token: 0x04022B3A RID: 142138
		[Token(Token = "0x4022B3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicViewHolder[] _stableViewHolders;

		// Token: 0x04022B3B RID: 142139
		[Token(Token = "0x4022B3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeTopicSubView[] _stableViews;

		// Token: 0x04022B3C RID: 142140
		[Token(Token = "0x4022B3C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("DisplayEffect")]
		private UIAnimationLocation[] _enterAnims;

		// Token: 0x04022B3D RID: 142141
		[Token(Token = "0x4022B3D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DisplayEffect")]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x04022B3E RID: 142142
		[Token(Token = "0x4022B3E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DisplayEffect")]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x04022B3F RID: 142143
		[Token(Token = "0x4022B3F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("DisplayEffect")]
		private Canvas[] _canvases;

		// Token: 0x04022B40 RID: 142144
		[Token(Token = "0x4022B40")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("DisplayEffect")]
		private RoguelikeTopicEntry.DisplayParentConfig _displayParentConfig;

		// Token: 0x04022B41 RID: 142145
		[Token(Token = "0x4022B41")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04022B42 RID: 142146
		[Token(Token = "0x4022B42")]
		[FieldOffset(Offset = "0x68")]
		private UITwoStepAnimation m_animPlayer;

		// Token: 0x04022B43 RID: 142147
		[Token(Token = "0x4022B43")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeTopicState.Bridge m_bridge;

		// Token: 0x04022B44 RID: 142148
		[Token(Token = "0x4022B44")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_showEffectCoroutine;

		// Token: 0x04022B46 RID: 142150
		[Token(Token = "0x4022B46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extensionModel;

		// Token: 0x04022B47 RID: 142151
		[Token(Token = "0x4022B47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022B48 RID: 142152
		[Token(Token = "0x4022B48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04022B49 RID: 142153
		[Token(Token = "0x4022B49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnAnnounceClicked;

		// Token: 0x04022B4A RID: 142154
		[Token(Token = "0x4022B4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnOpenBattlePath;

		// Token: 0x04022B4B RID: 142155
		[Token(Token = "0x4022B4B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022B4C RID: 142156
		[Token(Token = "0x4022B4C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDisplayParentConfig;

		// Token: 0x04022B4D RID: 142157
		[Token(Token = "0x4022B4D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StartShowEffect;

		// Token: 0x04022B4E RID: 142158
		[Token(Token = "0x4022B4E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetEffectsEnable;

		// Token: 0x04022B4F RID: 142159
		[Token(Token = "0x4022B4F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TriggerTopicAvg;

		// Token: 0x04022B50 RID: 142160
		[Token(Token = "0x4022B50")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowEffectCoroutine;

		// Token: 0x04022B51 RID: 142161
		[Token(Token = "0x4022B51")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004530 RID: 17712
		[Token(Token = "0x2004530")]
		[Serializable]
		public struct DisplayParentConfig
		{
			// Token: 0x04022B52 RID: 142162
			[Token(Token = "0x4022B52")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[NonSerialized]
			public static readonly RoguelikeTopicEntry.DisplayParentConfig FAST_MODE;

			// Token: 0x04022B53 RID: 142163
			[Token(Token = "0x4022B53")]
			[FieldOffset(Offset = "0x0")]
			public float delay;

			// Token: 0x04022B54 RID: 142164
			[Token(Token = "0x4022B54")]
			[FieldOffset(Offset = "0x4")]
			public float duration;
		}
	}
}
