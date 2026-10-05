using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034C3 RID: 13507
	[Token(Token = "0x20034C3")]
	public abstract class DynIllustBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x06015864 RID: 88164
		[Token(Token = "0x170032D8")]
		protected abstract bool actionDataInitialized { [Token(Token = "0x6015864")] get; }

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x06015865 RID: 88165 RVA: 0x0008C688 File Offset: 0x0008A888
		[Token(Token = "0x170032D9")]
		public Vector2 maxSize
		{
			[Token(Token = "0x6015865")]
			[Address(RVA = "0xDFD320", Offset = "0xDFBF20", VA = "0x180DFD320")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x06015866 RID: 88166 RVA: 0x0008C6A0 File Offset: 0x0008A8A0
		[Token(Token = "0x170032DA")]
		public float cameraSize
		{
			[Token(Token = "0x6015866")]
			[Address(RVA = "0xDFD1D0", Offset = "0xDFBDD0", VA = "0x180DFD1D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x06015867 RID: 88167 RVA: 0x0008C6B8 File Offset: 0x0008A8B8
		// (set) Token: 0x06015868 RID: 88168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032DB")]
		public bool started
		{
			[Token(Token = "0x6015867")]
			[Address(RVA = "0xDFD440", Offset = "0xDFC040", VA = "0x180DFD440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015868")]
			[Address(RVA = "0xDFD560", Offset = "0xDFC160", VA = "0x180DFD560")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x06015869 RID: 88169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032DC")]
		public DynIllustMgr.Context context
		{
			[Token(Token = "0x6015869")]
			[Address(RVA = "0xDFD240", Offset = "0xDFBE40", VA = "0x180DFD240")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0601586A RID: 88170
		[Token(Token = "0x170032DD")]
		public abstract SkeletonAnimation skeleton { [Token(Token = "0x601586A")] get; }

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0601586B RID: 88171
		[Token(Token = "0x170032DE")]
		public abstract float playingActionDur { [Token(Token = "0x601586B")] get; }

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0601586C RID: 88172
		[Token(Token = "0x170032DF")]
		public abstract float playingTime { [Token(Token = "0x601586C")] get; }

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0601586D RID: 88173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032E0")]
		public DynIllustEffectHolder[] holders
		{
			[Token(Token = "0x601586D")]
			[Address(RVA = "0xDFD2B0", Offset = "0xDFBEB0", VA = "0x180DFD2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601586E RID: 88174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601586E")]
		[Address(RVA = "0xDFC7C0", Offset = "0xDFB3C0", VA = "0x180DFC7C0", Slot = "8")]
		public virtual void SetContext(DynIllustMgr.Context context)
		{
		}

		// Token: 0x0601586F RID: 88175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601586F")]
		[Address(RVA = "0xDFC250", Offset = "0xDFAE50", VA = "0x180DFC250", Slot = "9")]
		public virtual void Init()
		{
		}

		// Token: 0x06015870 RID: 88176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015870")]
		[Address(RVA = "0xDFC170", Offset = "0xDFAD70", VA = "0x180DFC170")]
		protected void InitAnimators()
		{
		}

		// Token: 0x06015871 RID: 88177
		[Token(Token = "0x6015871")]
		protected abstract bool SupportNormalActionType(DynIllustAction action);

		// Token: 0x06015872 RID: 88178
		[Token(Token = "0x6015872")]
		public abstract float GetActionDur(DynIllustBase.DynIllustActionQuery action);

		// Token: 0x06015873 RID: 88179 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
		[Token(Token = "0x6015873")]
		[Address(RVA = "0xDFBF90", Offset = "0xDFAB90", VA = "0x180DFBF90")]
		public bool GetNormalAnimationName(DynIllustAction action, out string actionName)
		{
			return default(bool);
		}

		// Token: 0x06015874 RID: 88180 RVA: 0x0008C6E8 File Offset: 0x0008A8E8
		[Token(Token = "0x6015874")]
		[Address(RVA = "0xDFBE10", Offset = "0xDFAA10", VA = "0x180DFBE10")]
		public bool GetNormalActionType(string name, out DynIllustAction action)
		{
			return default(bool);
		}

		// Token: 0x06015875 RID: 88181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015875")]
		[Address(RVA = "0xDFB8D0", Offset = "0xDFA4D0", VA = "0x180DFB8D0", Slot = "12")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06015876 RID: 88182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015876")]
		[Address(RVA = "0xDFC850", Offset = "0xDFB450", VA = "0x180DFC850", Slot = "13")]
		protected virtual void Start()
		{
		}

		// Token: 0x06015877 RID: 88183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015877")]
		[Address(RVA = "0xDFC540", Offset = "0xDFB140", VA = "0x180DFC540", Slot = "14")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06015878 RID: 88184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015878")]
		[Address(RVA = "0xDFC4C0", Offset = "0xDFB0C0", VA = "0x180DFC4C0", Slot = "15")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06015879 RID: 88185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015879")]
		[Address(RVA = "0xDFCA30", Offset = "0xDFB630", VA = "0x180DFCA30", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x0601587A RID: 88186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601587A")]
		[Address(RVA = "0xDFC380", Offset = "0xDFAF80", VA = "0x180DFC380")]
		protected void LateUpdate()
		{
		}

		// Token: 0x0601587B RID: 88187 RVA: 0x0008C700 File Offset: 0x0008A900
		[Token(Token = "0x601587B")]
		[Address(RVA = "0xDFC920", Offset = "0xDFB520", VA = "0x180DFC920")]
		public bool TryGetAdjustParam(DynIllustAdjustType type, out DynIllustAdjust adjust)
		{
			return default(bool);
		}

		// Token: 0x0601587C RID: 88188 RVA: 0x0008C718 File Offset: 0x0008A918
		[Token(Token = "0x601587C")]
		[Address(RVA = "0xDFBCF0", Offset = "0xDFA8F0", VA = "0x180DFBCF0")]
		public DynIllustAdjust GetAdjustParam(DynIllustAdjustType type)
		{
			return default(DynIllustAdjust);
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0601587D RID: 88189 RVA: 0x0008C730 File Offset: 0x0008A930
		[Token(Token = "0x170032E1")]
		public DynIllustBase.DynIllustActionQuery action
		{
			[Token(Token = "0x601587D")]
			[Address(RVA = "0xDFD040", Offset = "0xDFBC40", VA = "0x180DFD040")]
			get
			{
				return default(DynIllustBase.DynIllustActionQuery);
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0601587F RID: 88191 RVA: 0x0008C748 File Offset: 0x0008A948
		// (set) Token: 0x0601587E RID: 88190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032E2")]
		public DynIllustBase.DynIllustActionQuery playingAction
		{
			[Token(Token = "0x601587F")]
			[Address(RVA = "0xDFD3A0", Offset = "0xDFBFA0", VA = "0x180DFD3A0")]
			get
			{
				return default(DynIllustBase.DynIllustActionQuery);
			}
			[Token(Token = "0x601587E")]
			[Address(RVA = "0xDFD4C0", Offset = "0xDFC0C0", VA = "0x180DFD4C0")]
			protected set
			{
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x06015880 RID: 88192 RVA: 0x0008C760 File Offset: 0x0008A960
		[Token(Token = "0x170032E3")]
		public float activeTime
		{
			[Token(Token = "0x6015880")]
			[Address(RVA = "0xDFD0E0", Offset = "0xDFBCE0", VA = "0x180DFD0E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06015881 RID: 88193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015881")]
		[Address(RVA = "0xDFBB50", Offset = "0xDFA750", VA = "0x180DFBB50", Slot = "17")]
		public virtual void ChangeAction(DynIllustBase.DynIllustActionQuery action, float loop)
		{
		}

		// Token: 0x06015882 RID: 88194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015882")]
		[Address(RVA = "0xDFCB30", Offset = "0xDFB730", VA = "0x180DFCB30")]
		private void _LoadEffectsByHolder(DynIllustBase.DynIllustActionQuery action)
		{
		}

		// Token: 0x06015883 RID: 88195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015883")]
		[Address(RVA = "0xDFBC30", Offset = "0xDFA830", VA = "0x180DFBC30")]
		public void CopyManualParam(DynIllustBase src)
		{
		}

		// Token: 0x06015884 RID: 88196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015884")]
		[Address(RVA = "0xDFCED0", Offset = "0xDFBAD0", VA = "0x180DFCED0")]
		protected DynIllustBase()
		{
		}

		// Token: 0x04019CB8 RID: 105656
		[Token(Token = "0x4019CB8")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<DynIllustAction, string> s_animatorTriggerDict;

		// Token: 0x04019CB9 RID: 105657
		[Token(Token = "0x4019CB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected ActionParticle[] _particles;

		// Token: 0x04019CBA RID: 105658
		[Token(Token = "0x4019CBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Animator[] _animators;

		// Token: 0x04019CBB RID: 105659
		[Token(Token = "0x4019CBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected DynIllustEffectHolder[] _holders;

		// Token: 0x04019CBC RID: 105660
		[Token(Token = "0x4019CBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected float _cameraSize;

		// Token: 0x04019CBD RID: 105661
		[Token(Token = "0x4019CBD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Vector2 _maxSize;

		// Token: 0x04019CBE RID: 105662
		[Token(Token = "0x4019CBE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected DynIllustAdjust[] _adjustes;

		// Token: 0x04019CBF RID: 105663
		[Token(Token = "0x4019CBF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected bool _fixFxDelay;

		// Token: 0x04019CC0 RID: 105664
		[Token(Token = "0x4019CC0")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		protected bool _animTimeFixed;

		// Token: 0x04019CC1 RID: 105665
		[Token(Token = "0x4019CC1")]
		[FieldOffset(Offset = "0x50")]
		private DynIllustBase.DynIllustActionQuery m_action;

		// Token: 0x04019CC2 RID: 105666
		[Token(Token = "0x4019CC2")]
		[FieldOffset(Offset = "0x60")]
		private DynIllustBase.DynIllustActionQuery m_playingAction;

		// Token: 0x04019CC3 RID: 105667
		[Token(Token = "0x4019CC3")]
		[FieldOffset(Offset = "0x70")]
		private DynIllustMgr.Context m_context;

		// Token: 0x04019CC4 RID: 105668
		[Token(Token = "0x4019CC4")]
		[FieldOffset(Offset = "0x78")]
		protected List<ActionParticle> m_particles;

		// Token: 0x04019CC5 RID: 105669
		[Token(Token = "0x4019CC5")]
		[FieldOffset(Offset = "0x80")]
		protected long lastEnableTick;

		// Token: 0x04019CC6 RID: 105670
		[Token(Token = "0x4019CC6")]
		[FieldOffset(Offset = "0x88")]
		protected float loop;

		// Token: 0x04019CC7 RID: 105671
		[Token(Token = "0x4019CC7")]
		[FieldOffset(Offset = "0x8C")]
		protected float playEnd;

		// Token: 0x04019CC8 RID: 105672
		[Token(Token = "0x4019CC8")]
		[FieldOffset(Offset = "0x90")]
		protected TrackEntry trackEntry;

		// Token: 0x04019CCA RID: 105674
		[Token(Token = "0x4019CCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxSize;

		// Token: 0x04019CCB RID: 105675
		[Token(Token = "0x4019CCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cameraSize;

		// Token: 0x04019CCC RID: 105676
		[Token(Token = "0x4019CCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_started;

		// Token: 0x04019CCD RID: 105677
		[Token(Token = "0x4019CCD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_started;

		// Token: 0x04019CCE RID: 105678
		[Token(Token = "0x4019CCE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x04019CCF RID: 105679
		[Token(Token = "0x4019CCF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_holders;

		// Token: 0x04019CD0 RID: 105680
		[Token(Token = "0x4019CD0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x04019CD1 RID: 105681
		[Token(Token = "0x4019CD1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019CD2 RID: 105682
		[Token(Token = "0x4019CD2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitAnimators;

		// Token: 0x04019CD3 RID: 105683
		[Token(Token = "0x4019CD3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetNormalAnimationName;

		// Token: 0x04019CD4 RID: 105684
		[Token(Token = "0x4019CD4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetNormalActionType;

		// Token: 0x04019CD5 RID: 105685
		[Token(Token = "0x4019CD5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019CD6 RID: 105686
		[Token(Token = "0x4019CD6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04019CD7 RID: 105687
		[Token(Token = "0x4019CD7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04019CD8 RID: 105688
		[Token(Token = "0x4019CD8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04019CD9 RID: 105689
		[Token(Token = "0x4019CD9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019CDA RID: 105690
		[Token(Token = "0x4019CDA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x04019CDB RID: 105691
		[Token(Token = "0x4019CDB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TryGetAdjustParam;

		// Token: 0x04019CDC RID: 105692
		[Token(Token = "0x4019CDC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetAdjustParam;

		// Token: 0x04019CDD RID: 105693
		[Token(Token = "0x4019CDD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_action;

		// Token: 0x04019CDE RID: 105694
		[Token(Token = "0x4019CDE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_playingAction;

		// Token: 0x04019CDF RID: 105695
		[Token(Token = "0x4019CDF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_playingAction;

		// Token: 0x04019CE0 RID: 105696
		[Token(Token = "0x4019CE0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_activeTime;

		// Token: 0x04019CE1 RID: 105697
		[Token(Token = "0x4019CE1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ChangeAction;

		// Token: 0x04019CE2 RID: 105698
		[Token(Token = "0x4019CE2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadEffectsByHolder;

		// Token: 0x04019CE3 RID: 105699
		[Token(Token = "0x4019CE3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CopyManualParam;

		// Token: 0x04019CE4 RID: 105700
		[Token(Token = "0x4019CE4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034C4 RID: 13508
		[Token(Token = "0x20034C4")]
		public struct DynIllustActionQuery : IHotfixable
		{
			// Token: 0x06015886 RID: 88198 RVA: 0x0008C778 File Offset: 0x0008A978
			[Token(Token = "0x6015886")]
			[Address(RVA = "0xDFB5D0", Offset = "0xDFA1D0", VA = "0x180DFB5D0")]
			public static bool operator ==(DynIllustBase.DynIllustActionQuery a, DynIllustBase.DynIllustActionQuery b)
			{
				return default(bool);
			}

			// Token: 0x06015887 RID: 88199 RVA: 0x0008C790 File Offset: 0x0008A990
			[Token(Token = "0x6015887")]
			[Address(RVA = "0xDFB690", Offset = "0xDFA290", VA = "0x180DFB690")]
			public static bool operator !=(DynIllustBase.DynIllustActionQuery a, DynIllustBase.DynIllustActionQuery b)
			{
				return default(bool);
			}

			// Token: 0x06015888 RID: 88200 RVA: 0x0008C7A8 File Offset: 0x0008A9A8
			[Token(Token = "0x6015888")]
			[Address(RVA = "0xDFB0C0", Offset = "0xDF9CC0", VA = "0x180DFB0C0")]
			public static DynIllustBase.DynIllustActionQuery CreateByType(DynIllustAction actionType)
			{
				return default(DynIllustBase.DynIllustActionQuery);
			}

			// Token: 0x06015889 RID: 88201 RVA: 0x0008C7C0 File Offset: 0x0008A9C0
			[Token(Token = "0x6015889")]
			[Address(RVA = "0xDFB000", Offset = "0xDF9C00", VA = "0x180DFB000")]
			public static DynIllustBase.DynIllustActionQuery CreateByTypeAndActionId(DynIllustAction actionType, string actionId)
			{
				return default(DynIllustBase.DynIllustActionQuery);
			}

			// Token: 0x0601588A RID: 88202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601588A")]
			[Address(RVA = "0xDFB160", Offset = "0xDF9D60", VA = "0x180DFB160", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0601588C RID: 88204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601588C")]
			[Address(RVA = "0xDFB250", Offset = "0xDF9E50", VA = "0x180DFB250")]
			private string <>xLuaBaseProxy_ToString()
			{
				return null;
			}

			// Token: 0x04019CE5 RID: 105701
			[Token(Token = "0x4019CE5")]
			[FieldOffset(Offset = "0x0")]
			public static DynIllustBase.DynIllustActionQuery NONE;

			// Token: 0x04019CE6 RID: 105702
			[Token(Token = "0x4019CE6")]
			[FieldOffset(Offset = "0x10")]
			public static DynIllustBase.DynIllustActionQuery IDLE;

			// Token: 0x04019CE7 RID: 105703
			[Token(Token = "0x4019CE7")]
			[FieldOffset(Offset = "0x20")]
			public static DynIllustBase.DynIllustActionQuery SPECIAL_IDLE;

			// Token: 0x04019CE8 RID: 105704
			[Token(Token = "0x4019CE8")]
			[FieldOffset(Offset = "0x30")]
			public static DynIllustBase.DynIllustActionQuery INTERACTION;

			// Token: 0x04019CE9 RID: 105705
			[Token(Token = "0x4019CE9")]
			[FieldOffset(Offset = "0x40")]
			public static DynIllustBase.DynIllustActionQuery START;

			// Token: 0x04019CEA RID: 105706
			[Token(Token = "0x4019CEA")]
			[FieldOffset(Offset = "0x0")]
			public DynIllustAction actionType;

			// Token: 0x04019CEB RID: 105707
			[Token(Token = "0x4019CEB")]
			[FieldOffset(Offset = "0x8")]
			public string actionId;

			// Token: 0x04019CEC RID: 105708
			[Token(Token = "0x4019CEC")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_op_Equality;

			// Token: 0x04019CED RID: 105709
			[Token(Token = "0x4019CED")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_op_Inequality;

			// Token: 0x04019CEE RID: 105710
			[Token(Token = "0x4019CEE")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_CreateByType;

			// Token: 0x04019CEF RID: 105711
			[Token(Token = "0x4019CEF")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CreateByTypeAndActionId;

			// Token: 0x04019CF0 RID: 105712
			[Token(Token = "0x4019CF0")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_ToString;
		}
	}
}
