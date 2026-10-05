using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Toggle", 30)]
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000166")]
		public ToggleGroup group
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x5B809F0", Offset = "0x5B7F5F0", VA = "0x185B809F0")]
			set
			{
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5B80930", Offset = "0x5B7F530", VA = "0x185B80930")]
		protected Toggle()
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "48")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "49")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "50")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x5B80210", Offset = "0x5B7EE10", VA = "0x185B80210", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x5B803D0", Offset = "0x5B7EFD0", VA = "0x185B803D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x5B803A0", Offset = "0x5B7EFA0", VA = "0x185B803A0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x5B802A0", Offset = "0x5B7EEA0", VA = "0x185B802A0", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x5B80550", Offset = "0x5B7F150", VA = "0x185B80550")]
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000167")]
		public bool isOn
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x538F7C0", Offset = "0x538E3C0", VA = "0x18538F7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x5B80A20", Offset = "0x5B7F620", VA = "0x185B80A20")]
			set
			{
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x5B80540", Offset = "0x5B7F140", VA = "0x185B80540")]
		public void SetIsOnWithoutNotify(bool value)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x5B807A0", Offset = "0x5B7F3A0", VA = "0x185B807A0")]
		private void Set(bool value, bool sendCallback = true)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x5B80450", Offset = "0x5B7F050", VA = "0x185B80450")]
		private void PlayEffect(bool instant)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x5B80920", Offset = "0x5B7F520", VA = "0x185B80920", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x5B80180", Offset = "0x5B7ED80", VA = "0x185B80180")]
		private void InternalToggle()
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5B80410", Offset = "0x5B7F010", VA = "0x185B80410", Slot = "51")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x5B80440", Offset = "0x5B7F040", VA = "0x185B80440", Slot = "52")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "44")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0xF8")]
		public Toggle.ToggleTransition toggleTransition;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x100")]
		public Graphic graphic;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ToggleGroup m_Group;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x110")]
		public Toggle.ToggleEvent onValueChanged;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn;

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public enum ToggleTransition
		{
			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			None,
			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			Fade
		}

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x5B7F390", Offset = "0x5B7DF90", VA = "0x185B7F390")]
			public ToggleEvent()
			{
			}
		}
	}
}
