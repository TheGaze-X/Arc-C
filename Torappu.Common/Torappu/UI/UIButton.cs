using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public class UIButton : Button
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000069EC File Offset: 0x00004BEC
		[Token(Token = "0x170000A1")]
		public UIButton.ClickGuardEnum clickableCheckRule
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x553F080", Offset = "0x553DC80", VA = "0x18553F080")]
			get
			{
				return UIButton.ClickGuardEnum.NONE;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00006A04 File Offset: 0x00004C04
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000A2")]
		public override bool interactable
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x4C374F0", Offset = "0x4C360F0", VA = "0x184C374F0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x553F0A0", Offset = "0x553DCA0", VA = "0x18553F0A0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x553E790", Offset = "0x553D390", VA = "0x18553E790")]
		public void SetSelfDefineCheck(Func<bool> checkFunc)
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x553D830", Offset = "0x553C430", VA = "0x18553D830")]
		public bool CheckSelfDefineFuncClick()
		{
			return default(bool);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x22F8A40", Offset = "0x22F7640", VA = "0x1822F8A40")]
		public void FakeButtonOnlySetAudio(UIButton.AudioModule audioModule)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x553D900", Offset = "0x553C500", VA = "0x18553D900")]
		public void FakeButtonOnlySetAudio(UIButton uiButton)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x553D870", Offset = "0x553C470", VA = "0x18553D870")]
		public void FakeButtonOnlyEnableBindKey(bool enable)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "44")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x553DF30", Offset = "0x553CB30", VA = "0x18553DF30", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x553DE50", Offset = "0x553CA50", VA = "0x18553DE50")]
		public void OnKeyboardTriggerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x553E320", Offset = "0x553CF20", VA = "0x18553E320", Slot = "35")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x553DE30", Offset = "0x553CA30", VA = "0x18553DE30", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x553DE00", Offset = "0x553CA00", VA = "0x18553DE00", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x553E6E0", Offset = "0x553D2E0", VA = "0x18553E6E0")]
		public void SetBindStateDirty()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x553DC20", Offset = "0x553C820", VA = "0x18553DC20", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x553EC10", Offset = "0x553D810", VA = "0x18553EC10")]
		private void _OnTickForLongPress(float timeDelta)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x553ED40", Offset = "0x553D940", VA = "0x18553ED40")]
		private void _StartTickLongPress()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x553EE40", Offset = "0x553DA40", VA = "0x18553EE40")]
		private void _StopTickLongPress()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x553DC10", Offset = "0x553C810", VA = "0x18553DC10")]
		public void InterruptClickState()
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00006A34 File Offset: 0x00004C34
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x553E7C0", Offset = "0x553D3C0", VA = "0x18553E7C0")]
		public bool TryTickPressByKeyCode()
		{
			return default(bool);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x553EB90", Offset = "0x553D790", VA = "0x18553EB90")]
		private void _InterruptAllPress()
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x553EE60", Offset = "0x553DA60", VA = "0x18553EE60")]
		private void _TryTriggerClick(bool isPressed)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x553E930", Offset = "0x553D530", VA = "0x18553E930")]
		private bool _CheckButtonClickEnabled()
		{
			return default(bool);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00006A64 File Offset: 0x00004C64
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x553DBD0", Offset = "0x553C7D0", VA = "0x18553DBD0")]
		public KeyBoardVirtualButtonEnum GetBindKeyCodeEnum()
		{
			return KeyBoardVirtualButtonEnum.ESC;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x553DBF0", Offset = "0x553C7F0", VA = "0x18553DBF0")]
		public RectTransform GetBindRect()
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x553D930", Offset = "0x553C530", VA = "0x18553D930")]
		public KeyBoardVirtualButtonConfig GetBindKeyCodeConfig()
		{
			return null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x553EF10", Offset = "0x553DB10", VA = "0x18553EF10")]
		public UIButton()
		{
		}

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIButton.ClickGuardModule _clickGuard;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIButton.AudioModule _audio;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIButton.LongPressModule _longPress;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIButton.BindKeyCodeModule _bindKey;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x120")]
		private TickFunction m_tickLongPress;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x128")]
		private int m_cachePointId;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x130")]
		private List<RaycastResult> m_resultList;

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		public const float DEFAULT_COOLDOWN = 0.5f;

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		private const string EDITOR_LONG_PRESS_PREFIX = "LONG_PRESS";

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		private const string EDITOR_LONG_PRESS_GROUP = "LONG_PRESS/Group";

		// Token: 0x0200013F RID: 319
		[Token(Token = "0x200013F")]
		private class TransitionModule
		{
			// Token: 0x060007B0 RID: 1968 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			public void Awake(UIButton host)
			{
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x5536010", Offset = "0x5534C10", VA = "0x185536010")]
			public void OnStateChange(UIButton.TransitionModule.UISelectionState state)
			{
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x55363C0", Offset = "0x5534FC0", VA = "0x1855363C0")]
			private void _PlayAnim(AnimationClip clip)
			{
			}

			// Token: 0x060007B3 RID: 1971 RVA: 0x00006A7C File Offset: 0x00004C7C
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			private float _GetAnimPos()
			{
				return 0f;
			}

			// Token: 0x060007B4 RID: 1972 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5536630", Offset = "0x5535230", VA = "0x185536630")]
			private void _StartColorTween(Color targetColor, bool instant)
			{
			}

			// Token: 0x060007B5 RID: 1973 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x5536580", Offset = "0x5535180", VA = "0x185536580")]
			private void _SetAnimState(AnimationClip clip, float pos)
			{
			}

			// Token: 0x060007B6 RID: 1974 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TransitionModule()
			{
			}

			// Token: 0x040006BC RID: 1724
			[Token(Token = "0x40006BC")]
			public const string DISABLE_ANIM = "disabled_anim";

			// Token: 0x040006BD RID: 1725
			[Token(Token = "0x40006BD")]
			public const string PRESSED_ANIM = "pressed_anim";

			// Token: 0x040006BE RID: 1726
			[Token(Token = "0x40006BE")]
			public const string LONGPRESSED_ANIM = "longpressed_anim";

			// Token: 0x040006BF RID: 1727
			[Token(Token = "0x40006BF")]
			public const string DEFAULT_ANIM = "default_anim";

			// Token: 0x040006C0 RID: 1728
			[Token(Token = "0x40006C0")]
			public const float FADE_COLOR_DURATION = 0.2f;

			// Token: 0x040006C1 RID: 1729
			[Token(Token = "0x40006C1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIButton.TransitionModule.TransItem[] DEFAULT_TRANS_LIST;

			// Token: 0x040006C2 RID: 1730
			[Token(Token = "0x40006C2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Animation _animation;

			// Token: 0x040006C3 RID: 1731
			[Token(Token = "0x40006C3")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIButton.TransitionModule.TransItem[] _transList;

			// Token: 0x040006C4 RID: 1732
			[Token(Token = "0x40006C4")]
			[FieldOffset(Offset = "0x20")]
			private Tween m_cacheAnimTransTween;

			// Token: 0x040006C5 RID: 1733
			[Token(Token = "0x40006C5")]
			[FieldOffset(Offset = "0x28")]
			private float m_cacheAnimPos;

			// Token: 0x040006C6 RID: 1734
			[Token(Token = "0x40006C6")]
			[FieldOffset(Offset = "0x30")]
			private UIButton m_host;

			// Token: 0x02000140 RID: 320
			[Token(Token = "0x2000140")]
			public enum UISelectionState
			{
				// Token: 0x040006C8 RID: 1736
				[Token(Token = "0x40006C8")]
				Normal,
				// Token: 0x040006C9 RID: 1737
				[Token(Token = "0x40006C9")]
				Highlighted,
				// Token: 0x040006CA RID: 1738
				[Token(Token = "0x40006CA")]
				Pressed,
				// Token: 0x040006CB RID: 1739
				[Token(Token = "0x40006CB")]
				LongPressed,
				// Token: 0x040006CC RID: 1740
				[Token(Token = "0x40006CC")]
				Disabled
			}

			// Token: 0x02000141 RID: 321
			[Token(Token = "0x2000141")]
			public enum TransType
			{
				// Token: 0x040006CE RID: 1742
				[Token(Token = "0x40006CE")]
				NONE,
				// Token: 0x040006CF RID: 1743
				[Token(Token = "0x40006CF")]
				COLOR,
				// Token: 0x040006D0 RID: 1744
				[Token(Token = "0x40006D0")]
				ANIM
			}

			// Token: 0x02000142 RID: 322
			[Token(Token = "0x2000142")]
			[Serializable]
			public class TransItem
			{
				// Token: 0x170000A3 RID: 163
				// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00006A94 File Offset: 0x00004C94
				[Token(Token = "0x170000A3")]
				public bool showAnimPathProperty
				{
					[Token(Token = "0x60007B8")]
					[Address(RVA = "0x5535FF0", Offset = "0x5534BF0", VA = "0x185535FF0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x170000A4 RID: 164
				// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x170000A4")]
				public string animPath
				{
					[Token(Token = "0x60007B9")]
					[Address(RVA = "0x5535F70", Offset = "0x5534B70", VA = "0x185535F70")]
					get
					{
						return null;
					}
				}

				// Token: 0x060007BA RID: 1978 RVA: 0x000020FA File Offset: 0x000002FA
				[Token(Token = "0x60007BA")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public TransItem()
				{
				}

				// Token: 0x040006D1 RID: 1745
				[Token(Token = "0x40006D1")]
				[FieldOffset(Offset = "0x10")]
				public UIButton.TransitionModule.UISelectionState selectionState;

				// Token: 0x040006D2 RID: 1746
				[Token(Token = "0x40006D2")]
				[FieldOffset(Offset = "0x14")]
				public UIButton.TransitionModule.TransType transType;

				// Token: 0x040006D3 RID: 1747
				[Token(Token = "0x40006D3")]
				[FieldOffset(Offset = "0x18")]
				public Color transColor;
			}
		}

		// Token: 0x02000144 RID: 324
		[Token(Token = "0x2000144")]
		[Serializable]
		public class AudioModule
		{
			// Token: 0x060007BD RID: 1981 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AudioModule()
			{
			}

			// Token: 0x040006D6 RID: 1750
			[Token(Token = "0x40006D6")]
			[FieldOffset(Offset = "0x10")]
			public AudioSoundType soundType;

			// Token: 0x040006D7 RID: 1751
			[Token(Token = "0x40006D7")]
			[FieldOffset(Offset = "0x14")]
			public UiInternalSoundType internalType;

			// Token: 0x040006D8 RID: 1752
			[Token(Token = "0x40006D8")]
			[FieldOffset(Offset = "0x18")]
			public UiBuildingSoundType buildingSoundType;

			// Token: 0x040006D9 RID: 1753
			[Token(Token = "0x40006D9")]
			[FieldOffset(Offset = "0x20")]
			public string signal;

			// Token: 0x040006DA RID: 1754
			[Token(Token = "0x40006DA")]
			[FieldOffset(Offset = "0x28")]
			public string subsignal;
		}

		// Token: 0x02000145 RID: 325
		[Token(Token = "0x2000145")]
		[Serializable]
		private class BindKeyCodeModule
		{
			// Token: 0x060007BE RID: 1982 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x552EC80", Offset = "0x552D880", VA = "0x18552EC80")]
			public BindKeyCodeModule()
			{
			}

			// Token: 0x040006DB RID: 1755
			[Token(Token = "0x40006DB")]
			[FieldOffset(Offset = "0x10")]
			public bool bindKeyFlag;

			// Token: 0x040006DC RID: 1756
			[Token(Token = "0x40006DC")]
			[FieldOffset(Offset = "0x14")]
			public KeyBoardVirtualButtonEnum bindingkeyCode;

			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform bindRect;

			// Token: 0x02000146 RID: 326
			[Token(Token = "0x2000146")]
			public struct BindLogic
			{
				// Token: 0x040006DE RID: 1758
				[Token(Token = "0x40006DE")]
				[FieldOffset(Offset = "0x0")]
				public bool blockOther;
			}
		}

		// Token: 0x02000147 RID: 327
		[Token(Token = "0x2000147")]
		[Serializable]
		private class LongPressModule
		{
			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060007BF RID: 1983 RVA: 0x00006AAC File Offset: 0x00004CAC
			// (set) Token: 0x060007C0 RID: 1984 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000A5")]
			public bool inLongPressState
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00006AC4 File Offset: 0x00004CC4
			[Token(Token = "0x170000A6")]
			public int pointerId
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00006ADC File Offset: 0x00004CDC
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x55318B0", Offset = "0x55304B0", VA = "0x1855318B0")]
			public bool OnPointerDown(PointerEventData eventData)
			{
				return default(bool);
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00006AF4 File Offset: 0x00004CF4
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x5531890", Offset = "0x5530490", VA = "0x185531890")]
			public bool ExcludeNormalClick()
			{
				return default(bool);
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x00006B0C File Offset: 0x00004D0C
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x55318E0", Offset = "0x55304E0", VA = "0x1855318E0")]
			public bool TickDuringPress(float deltaTime)
			{
				return default(bool);
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x5531950", Offset = "0x5530550", VA = "0x185531950")]
			private void _ResetPressStatus()
			{
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x5531960", Offset = "0x5530560", VA = "0x185531960")]
			public LongPressModule()
			{
			}

			// Token: 0x040006DF RID: 1759
			[Token(Token = "0x40006DF")]
			[FieldOffset(Offset = "0x10")]
			public bool useLongPress;

			// Token: 0x040006E0 RID: 1760
			[Token(Token = "0x40006E0")]
			[FieldOffset(Offset = "0x11")]
			[Tooltip("Long press would be triggered only once if not continus")]
			public bool continuous;

			// Token: 0x040006E1 RID: 1761
			[Token(Token = "0x40006E1")]
			[FieldOffset(Offset = "0x12")]
			[Tooltip("Exclude short-single click when long-press triggered")]
			public bool excludeClick;

			// Token: 0x040006E2 RID: 1762
			[Token(Token = "0x40006E2")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("How many seconds should the user hold to trigger a long-press event")]
			public float pThresSecs;

			// Token: 0x040006E3 RID: 1763
			[Token(Token = "0x40006E3")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Interval seconds to trigger long-press event")]
			public float intervalSecs;

			// Token: 0x040006E4 RID: 1764
			[Token(Token = "0x40006E4")]
			[FieldOffset(Offset = "0x20")]
			public Button.ButtonClickedEvent events;

			// Token: 0x040006E5 RID: 1765
			[Token(Token = "0x40006E5")]
			[FieldOffset(Offset = "0x28")]
			private int m_pointerId;

			// Token: 0x040006E6 RID: 1766
			[Token(Token = "0x40006E6")]
			[FieldOffset(Offset = "0x30")]
			private double m_timestamp;

			// Token: 0x040006E7 RID: 1767
			[Token(Token = "0x40006E7")]
			[FieldOffset(Offset = "0x38")]
			private double m_lastUpdateTs;
		}

		// Token: 0x02000148 RID: 328
		[Token(Token = "0x2000148")]
		[Flags]
		[Serializable]
		public enum ClickGuardEnum
		{
			// Token: 0x040006EA RID: 1770
			[Token(Token = "0x40006EA")]
			NONE = 0,
			// Token: 0x040006EB RID: 1771
			[Token(Token = "0x40006EB")]
			ENABLE_PAGE = 2,
			// Token: 0x040006EC RID: 1772
			[Token(Token = "0x40006EC")]
			ENABLE_STATE = 4,
			// Token: 0x040006ED RID: 1773
			[Token(Token = "0x40006ED")]
			ENABLE_DIALOG = 8,
			// Token: 0x040006EE RID: 1774
			[Token(Token = "0x40006EE")]
			ENABLE_SCENE = 16,
			// Token: 0x040006EF RID: 1775
			[Token(Token = "0x40006EF")]
			TIGHT = 30
		}

		// Token: 0x02000149 RID: 329
		[Token(Token = "0x2000149")]
		[Serializable]
		private class ClickGuardModule
		{
			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00006B24 File Offset: 0x00004D24
			// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000A7")]
			public bool enableClickGuard
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x552F130", Offset = "0x552DD30", VA = "0x18552F130")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x552F140", Offset = "0x552DD40", VA = "0x18552F140")]
				set
				{
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x060007CA RID: 1994 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000A8")]
			public Func<bool> selfDefineClickCheck
			{
				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00006B3C File Offset: 0x00004D3C
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x552F090", Offset = "0x552DC90", VA = "0x18552F090")]
			public bool IsInCooldown()
			{
				return default(bool);
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x552F030", Offset = "0x552DC30", VA = "0x18552F030")]
			public void ConfirmClick()
			{
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00006B54 File Offset: 0x00004D54
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x552F010", Offset = "0x552DC10", VA = "0x18552F010")]
			public bool CheckSelfDefineFuncClick()
			{
				return default(bool);
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x552F110", Offset = "0x552DD10", VA = "0x18552F110")]
			public ClickGuardModule()
			{
			}

			// Token: 0x040006F0 RID: 1776
			[Token(Token = "0x40006F0")]
			[FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public UIButton.ClickGuardEnum guardMask;

			// Token: 0x040006F1 RID: 1777
			[Token(Token = "0x40006F1")]
			[FieldOffset(Offset = "0x14")]
			public bool cooldown;

			// Token: 0x040006F2 RID: 1778
			[Token(Token = "0x40006F2")]
			[FieldOffset(Offset = "0x18")]
			public float seconds;

			// Token: 0x040006F3 RID: 1779
			[Token(Token = "0x40006F3")]
			[FieldOffset(Offset = "0x20")]
			private double m_lastClickTs;
		}
	}
}
