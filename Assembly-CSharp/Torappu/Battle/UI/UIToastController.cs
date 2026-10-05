using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032F3 RID: 13043
	[Token(Token = "0x20032F3")]
	[RequireComponent(typeof(RectTransform))]
	public class UIToastController : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06014B84 RID: 84868 RVA: 0x00088188 File Offset: 0x00086388
		// (set) Token: 0x06014B85 RID: 84869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700310B")]
		public UIToastController.ToastState state
		{
			[Token(Token = "0x6014B84")]
			[Address(RVA = "0xD30810", Offset = "0xD2F410", VA = "0x180D30810")]
			[CompilerGenerated]
			get
			{
				return UIToastController.ToastState.HIDING;
			}
			[Token(Token = "0x6014B85")]
			[Address(RVA = "0xD30870", Offset = "0xD2F470", VA = "0x180D30870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06014B86 RID: 84870 RVA: 0x000881A0 File Offset: 0x000863A0
		[Token(Token = "0x1700310C")]
		protected float progress
		{
			[Token(Token = "0x6014B86")]
			[Address(RVA = "0xD30620", Offset = "0xD2F220", VA = "0x180D30620")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06014B87 RID: 84871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700310D")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x6014B87")]
			[Address(RVA = "0xD30740", Offset = "0xD2F340", VA = "0x180D30740")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014B88 RID: 84872 RVA: 0x000881B8 File Offset: 0x000863B8
		[Token(Token = "0x6014B88")]
		[Address(RVA = "0xD2F750", Offset = "0xD2E350", VA = "0x180D2F750")]
		public int Show(UIToastController.Options options, bool needHide = true)
		{
			return 0;
		}

		// Token: 0x06014B89 RID: 84873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014B89")]
		[Address(RVA = "0xD30420", Offset = "0xD2F020", VA = "0x180D30420")]
		private IEnumerator _ShowInternal(UIToastController.Options options, bool needHide = true)
		{
			return null;
		}

		// Token: 0x06014B8A RID: 84874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8A")]
		[Address(RVA = "0xD2F670", Offset = "0xD2E270", VA = "0x180D2F670")]
		public void SetPaused(bool value)
		{
		}

		// Token: 0x06014B8B RID: 84875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8B")]
		[Address(RVA = "0xD2F290", Offset = "0xD2DE90", VA = "0x180D2F290")]
		public void Hide(bool withAnimation = true)
		{
		}

		// Token: 0x06014B8C RID: 84876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8C")]
		[Address(RVA = "0xD2F360", Offset = "0xD2DF60", VA = "0x180D2F360")]
		public void Hide(int popupId, bool withAnimation = true)
		{
		}

		// Token: 0x06014B8D RID: 84877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8D")]
		[Address(RVA = "0xD2F400", Offset = "0xD2E000", VA = "0x180D2F400")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B8E RID: 84878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8E")]
		[Address(RVA = "0xD2F460", Offset = "0xD2E060", VA = "0x180D2F460")]
		public void OnInit()
		{
		}

		// Token: 0x06014B8F RID: 84879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B8F")]
		[Address(RVA = "0xD2F190", Offset = "0xD2DD90", VA = "0x180D2F190")]
		public void AttachExtraSubPanel(UIToastController.UIToastSubPanel subPanel, UIToastController.ToastType toastType)
		{
		}

		// Token: 0x06014B90 RID: 84880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B90")]
		[Address(RVA = "0xD2F5D0", Offset = "0xD2E1D0", VA = "0x180D2F5D0")]
		public void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06014B91 RID: 84881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014B91")]
		[Address(RVA = "0xD2FD20", Offset = "0xD2E920", VA = "0x180D2FD20")]
		private UIToastController.UIToastSubPanel _GetSubPanel(UIToastController.ToastType popupType)
		{
			return null;
		}

		// Token: 0x06014B92 RID: 84882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B92")]
		[Address(RVA = "0xD30180", Offset = "0xD2ED80", VA = "0x180D30180")]
		private void _PlaySoundEffect(UIToastController.SeType seType)
		{
		}

		// Token: 0x06014B93 RID: 84883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B93")]
		[Address(RVA = "0xD302C0", Offset = "0xD2EEC0", VA = "0x180D302C0")]
		private void _ResetAll()
		{
		}

		// Token: 0x06014B94 RID: 84884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B94")]
		[Address(RVA = "0xD2FEC0", Offset = "0xD2EAC0", VA = "0x180D2FEC0")]
		private void _HideInternal(int popupId, bool force)
		{
		}

		// Token: 0x06014B95 RID: 84885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B95")]
		[Address(RVA = "0xD2FBB0", Offset = "0xD2E7B0", VA = "0x180D2FBB0")]
		private void Update()
		{
		}

		// Token: 0x06014B96 RID: 84886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B96")]
		[Address(RVA = "0xD30560", Offset = "0xD2F160", VA = "0x180D30560")]
		public UIToastController()
		{
		}

		// Token: 0x040189EA RID: 100842
		[Token(Token = "0x40189EA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x040189EB RID: 100843
		[Token(Token = "0x40189EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIToastController.UIToastSubPanel _infoPanel;

		// Token: 0x040189EC RID: 100844
		[Token(Token = "0x40189EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIToastController.UIToastSubPanel _enemyPanel;

		// Token: 0x040189ED RID: 100845
		[Token(Token = "0x40189ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _ignoreTimeScale;

		// Token: 0x040189EE RID: 100846
		[Token(Token = "0x40189EE")]
		[FieldOffset(Offset = "0x34")]
		private float m_curShowTime;

		// Token: 0x040189EF RID: 100847
		[Token(Token = "0x40189EF")]
		[FieldOffset(Offset = "0x38")]
		private float m_curLastTime;

		// Token: 0x040189F0 RID: 100848
		[Token(Token = "0x40189F0")]
		[FieldOffset(Offset = "0x3C")]
		private int m_idCounter;

		// Token: 0x040189F1 RID: 100849
		[Token(Token = "0x40189F1")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_rectTransform;

		// Token: 0x040189F2 RID: 100850
		[Token(Token = "0x40189F2")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 m_originAnchorPos;

		// Token: 0x040189F3 RID: 100851
		[Token(Token = "0x40189F3")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, UIToastController.UIToastSubPanel> m_subPanels;

		// Token: 0x040189F4 RID: 100852
		[Token(Token = "0x40189F4")]
		[FieldOffset(Offset = "0x58")]
		private Tweener m_tweener;

		// Token: 0x040189F5 RID: 100853
		[Token(Token = "0x40189F5")]
		[FieldOffset(Offset = "0x60")]
		private UIToastController.UIToastSubPanel m_lastSubPanel;

		// Token: 0x040189F7 RID: 100855
		[Token(Token = "0x40189F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x040189F8 RID: 100856
		[Token(Token = "0x40189F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x040189F9 RID: 100857
		[Token(Token = "0x40189F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x040189FA RID: 100858
		[Token(Token = "0x40189FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x040189FB RID: 100859
		[Token(Token = "0x40189FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040189FC RID: 100860
		[Token(Token = "0x40189FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowInternal;

		// Token: 0x040189FD RID: 100861
		[Token(Token = "0x40189FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x040189FE RID: 100862
		[Token(Token = "0x40189FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040189FF RID: 100863
		[Token(Token = "0x40189FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_Hide;

		// Token: 0x04018A00 RID: 100864
		[Token(Token = "0x4018A00")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018A01 RID: 100865
		[Token(Token = "0x4018A01")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018A02 RID: 100866
		[Token(Token = "0x4018A02")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AttachExtraSubPanel;

		// Token: 0x04018A03 RID: 100867
		[Token(Token = "0x4018A03")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04018A04 RID: 100868
		[Token(Token = "0x4018A04")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetSubPanel;

		// Token: 0x04018A05 RID: 100869
		[Token(Token = "0x4018A05")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlaySoundEffect;

		// Token: 0x04018A06 RID: 100870
		[Token(Token = "0x4018A06")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetAll;

		// Token: 0x04018A07 RID: 100871
		[Token(Token = "0x4018A07")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HideInternal;

		// Token: 0x04018A08 RID: 100872
		[Token(Token = "0x4018A08")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018A09 RID: 100873
		[Token(Token = "0x4018A09")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032F4 RID: 13044
		[Token(Token = "0x20032F4")]
		public enum ToastType
		{
			// Token: 0x04018A0B RID: 100875
			[Token(Token = "0x4018A0B")]
			INFO,
			// Token: 0x04018A0C RID: 100876
			[Token(Token = "0x4018A0C")]
			ENEMY,
			// Token: 0x04018A0D RID: 100877
			[Token(Token = "0x4018A0D")]
			LEGION_BLAST_CARD,
			// Token: 0x04018A0E RID: 100878
			[Token(Token = "0x4018A0E")]
			LEGION_TRAP_EFFECT,
			// Token: 0x04018A0F RID: 100879
			[Token(Token = "0x4018A0F")]
			ROGUE_DICE,
			// Token: 0x04018A10 RID: 100880
			[Token(Token = "0x4018A10")]
			ROGUE_EMERGENCY_ALERT,
			// Token: 0x04018A11 RID: 100881
			[Token(Token = "0x4018A11")]
			COOPERTE_BATTLE,
			// Token: 0x04018A12 RID: 100882
			[Token(Token = "0x4018A12")]
			PLUGIN_0,
			// Token: 0x04018A13 RID: 100883
			[Token(Token = "0x4018A13")]
			PLUGIN_1,
			// Token: 0x04018A14 RID: 100884
			[Token(Token = "0x4018A14")]
			PLUGIN_2,
			// Token: 0x04018A15 RID: 100885
			[Token(Token = "0x4018A15")]
			PLUGIN_3
		}

		// Token: 0x020032F5 RID: 13045
		[Token(Token = "0x20032F5")]
		public enum SeType
		{
			// Token: 0x04018A17 RID: 100887
			[Token(Token = "0x4018A17")]
			DEFAULT,
			// Token: 0x04018A18 RID: 100888
			[Token(Token = "0x4018A18")]
			ALERT
		}

		// Token: 0x020032F6 RID: 13046
		[Token(Token = "0x20032F6")]
		public enum ToastState
		{
			// Token: 0x04018A1A RID: 100890
			[Token(Token = "0x4018A1A")]
			HIDING,
			// Token: 0x04018A1B RID: 100891
			[Token(Token = "0x4018A1B")]
			SHOWING,
			// Token: 0x04018A1C RID: 100892
			[Token(Token = "0x4018A1C")]
			ANIMATING
		}

		// Token: 0x020032F7 RID: 13047
		[Token(Token = "0x20032F7")]
		public struct Options
		{
			// Token: 0x04018A1D RID: 100893
			[Token(Token = "0x4018A1D")]
			[FieldOffset(Offset = "0x0")]
			public UIToastController.ToastType toastType;

			// Token: 0x04018A1E RID: 100894
			[Token(Token = "0x4018A1E")]
			[FieldOffset(Offset = "0x4")]
			public UIToastController.SeType seType;

			// Token: 0x04018A1F RID: 100895
			[Token(Token = "0x4018A1F")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x04018A20 RID: 100896
			[Token(Token = "0x4018A20")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04018A21 RID: 100897
			[Token(Token = "0x4018A21")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04018A22 RID: 100898
			[Token(Token = "0x4018A22")]
			[FieldOffset(Offset = "0x20")]
			public float lastTime;

			// Token: 0x04018A23 RID: 100899
			[Token(Token = "0x4018A23")]
			[FieldOffset(Offset = "0x28")]
			public object extraParam;

			// Token: 0x04018A24 RID: 100900
			[Token(Token = "0x4018A24")]
			[FieldOffset(Offset = "0x30")]
			public int priority;
		}

		// Token: 0x020032F8 RID: 13048
		[Token(Token = "0x20032F8")]
		public abstract class UIToastSubPanel : MonoBehaviour, IHotfixable
		{
			// Token: 0x1700310E RID: 12558
			// (get) Token: 0x06014B9A RID: 84890 RVA: 0x000881E8 File Offset: 0x000863E8
			[Token(Token = "0x1700310E")]
			public float remainingProgress
			{
				[Token(Token = "0x6014B9A")]
				[Address(RVA = "0xD30DF0", Offset = "0xD2F9F0", VA = "0x180D30DF0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700310F RID: 12559
			// (get) Token: 0x06014B9B RID: 84891 RVA: 0x00088200 File Offset: 0x00086400
			[Token(Token = "0x1700310F")]
			public bool isFull
			{
				[Token(Token = "0x6014B9B")]
				[Address(RVA = "0xD30B30", Offset = "0xD2F730", VA = "0x180D30B30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003110 RID: 12560
			// (get) Token: 0x06014B9C RID: 84892 RVA: 0x00088218 File Offset: 0x00086418
			// (set) Token: 0x06014B9D RID: 84893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003110")]
			public int priority
			{
				[Token(Token = "0x6014B9C")]
				[Address(RVA = "0xD30BD0", Offset = "0xD2F7D0", VA = "0x180D30BD0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6014B9D")]
				[Address(RVA = "0xD30EE0", Offset = "0xD2FAE0", VA = "0x180D30EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003111 RID: 12561
			// (get) Token: 0x06014B9E RID: 84894 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014B9F RID: 84895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003111")]
			private protected UIToastController controller
			{
				[Token(Token = "0x6014B9E")]
				[Address(RVA = "0xD30AD0", Offset = "0xD2F6D0", VA = "0x180D30AD0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6014B9F")]
				[Address(RVA = "0xD30E60", Offset = "0xD2FA60", VA = "0x180D30E60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003112 RID: 12562
			// (get) Token: 0x06014BA0 RID: 84896 RVA: 0x00088230 File Offset: 0x00086430
			[Token(Token = "0x17003112")]
			protected float progress
			{
				[Token(Token = "0x6014BA0")]
				[Address(RVA = "0xD30C30", Offset = "0xD2F830", VA = "0x180D30C30")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06014BA1 RID: 84897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BA1")]
			[Address(RVA = "0xD308E0", Offset = "0xD2F4E0", VA = "0x180D308E0", Slot = "4")]
			public virtual void OnInit(UIToastController controller)
			{
			}

			// Token: 0x06014BA2 RID: 84898
			[Token(Token = "0x6014BA2")]
			public abstract void OnShow(UIToastController.Options options);

			// Token: 0x06014BA3 RID: 84899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BA3")]
			[Address(RVA = "0xD2E920", Offset = "0xD2D520", VA = "0x180D2E920", Slot = "6")]
			public virtual void OnUpdate()
			{
			}

			// Token: 0x06014BA4 RID: 84900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BA4")]
			[Address(RVA = "0xD30A10", Offset = "0xD2F610", VA = "0x180D30A10", Slot = "7")]
			public virtual void SetPaused(bool value)
			{
			}

			// Token: 0x06014BA5 RID: 84901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BA5")]
			[Address(RVA = "0xD309B0", Offset = "0xD2F5B0", VA = "0x180D309B0", Slot = "8")]
			public virtual void OnUIStateChanged(IUIStateNode stateNode)
			{
			}

			// Token: 0x06014BA6 RID: 84902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BA6")]
			[Address(RVA = "0xD30A70", Offset = "0xD2F670", VA = "0x180D30A70")]
			protected UIToastSubPanel()
			{
			}

			// Token: 0x04018A27 RID: 100903
			[Token(Token = "0x4018A27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_remainingProgress;

			// Token: 0x04018A28 RID: 100904
			[Token(Token = "0x4018A28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isFull;

			// Token: 0x04018A29 RID: 100905
			[Token(Token = "0x4018A29")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_priority;

			// Token: 0x04018A2A RID: 100906
			[Token(Token = "0x4018A2A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_priority;

			// Token: 0x04018A2B RID: 100907
			[Token(Token = "0x4018A2B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_controller;

			// Token: 0x04018A2C RID: 100908
			[Token(Token = "0x4018A2C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_controller;

			// Token: 0x04018A2D RID: 100909
			[Token(Token = "0x4018A2D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_progress;

			// Token: 0x04018A2E RID: 100910
			[Token(Token = "0x4018A2E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04018A2F RID: 100911
			[Token(Token = "0x4018A2F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnUpdate;

			// Token: 0x04018A30 RID: 100912
			[Token(Token = "0x4018A30")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_SetPaused;

			// Token: 0x04018A31 RID: 100913
			[Token(Token = "0x4018A31")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnUIStateChanged;

			// Token: 0x04018A32 RID: 100914
			[Token(Token = "0x4018A32")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
