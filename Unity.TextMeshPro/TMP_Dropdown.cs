using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public RectTransform template
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x5888330", Offset = "0x5886F30", VA = "0x185888330")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public TMP_Text captionText
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x5888230", Offset = "0x5886E30", VA = "0x185888230")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public Image captionImage
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x5888200", Offset = "0x5886E00", VA = "0x185888200")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public Graphic placeholder
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x5888300", Offset = "0x5886F00", VA = "0x185888300")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public TMP_Text itemText
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x5888290", Offset = "0x5886E90", VA = "0x185888290")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public Image itemImage
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x5888260", Offset = "0x5886E60", VA = "0x185888260")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public List<TMP_Dropdown.OptionData> options
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x58881C0", Offset = "0x5886DC0", VA = "0x1858881C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x58882C0", Offset = "0x5886EC0", VA = "0x1858882C0")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public TMP_Dropdown.DropdownEvent onValueChanged
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public float alphaFadeSpeed
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x58881B0", Offset = "0x5886DB0", VA = "0x1858881B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x58881F0", Offset = "0x5886DF0", VA = "0x1858881F0")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public int value
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x58881E0", Offset = "0x5886DE0", VA = "0x1858881E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x5888360", Offset = "0x5886F60", VA = "0x185888360")]
			set
			{
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x5886630", Offset = "0x5885230", VA = "0x185886630")]
		public void SetValueWithoutNotify(int input)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5886640", Offset = "0x5885240", VA = "0x185886640")]
		private void SetValue(int value, bool sendCallback = true)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x17000043")]
		public bool IsExpanded
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x5888150", Offset = "0x5886D50", VA = "0x185888150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x5887F90", Offset = "0x5886B90", VA = "0x185887F90")]
		protected TMP_Dropdown()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x58853B0", Offset = "0x5883FB0", VA = "0x1858853B0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5887E40", Offset = "0x5886A40", VA = "0x185887E40", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x58860E0", Offset = "0x5884CE0", VA = "0x1858860E0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x58862E0", Offset = "0x5884EE0", VA = "0x1858862E0")]
		public void RefreshShownValue()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x5884F30", Offset = "0x5883B30", VA = "0x185884F30")]
		public void AddOptions(List<TMP_Dropdown.OptionData> options)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5884FA0", Offset = "0x5883BA0", VA = "0x185884FA0")]
		public void AddOptions(List<string> options)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x58850B0", Offset = "0x5883CB0", VA = "0x1858850B0")]
		public void AddOptions(List<Sprite> options)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x58854C0", Offset = "0x58840C0", VA = "0x1858854C0")]
		public void ClearOptions()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5886790", Offset = "0x5885390", VA = "0x185886790")]
		private void SetupTemplate()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A0")]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x58861B0", Offset = "0x5884DB0", VA = "0x1858861B0", Slot = "44")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x58861B0", Offset = "0x5884DB0", VA = "0x1858861B0", Slot = "45")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x58860D0", Offset = "0x5884CD0", VA = "0x1858860D0", Slot = "46")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5886E70", Offset = "0x5885A70", VA = "0x185886E70")]
		public void Show()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5885580", Offset = "0x5884180", VA = "0x185885580", Slot = "47")]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5885BE0", Offset = "0x58847E0", VA = "0x185885BE0", Slot = "48")]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x5885A90", Offset = "0x5884690", VA = "0x185885A90", Slot = "49")]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5885C30", Offset = "0x5884830", VA = "0x185885C30", Slot = "50")]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x5885AF0", Offset = "0x58846F0", VA = "0x185885AF0", Slot = "51")]
		protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "52")]
		protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5884C40", Offset = "0x5883840", VA = "0x185884C40")]
		private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5885320", Offset = "0x5883F20", VA = "0x185885320")]
		private void AlphaFadeList(float duration, float alpha)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x58851C0", Offset = "0x5883DC0", VA = "0x1858851C0")]
		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5886580", Offset = "0x5885180", VA = "0x185886580")]
		private void SetAlpha(float alpha)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x5885C80", Offset = "0x5884880", VA = "0x185885C80")]
		public void Hide()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x5885B50", Offset = "0x5884750", VA = "0x185885B50")]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5885ED0", Offset = "0x5884AD0", VA = "0x185885ED0")]
		private void ImmediateDestroyDropdownList()
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x58861C0", Offset = "0x5884DC0", VA = "0x1858861C0")]
		private void OnSelectItem(Toggle toggle)
		{
		}

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_Template;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TMP_Text m_CaptionText;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image m_CaptionImage;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Graphic m_Placeholder;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Space]
		private TMP_Text m_ItemText;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image m_ItemImage;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Space]
		private int m_Value;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Space]
		private TMP_Dropdown.OptionDataList m_Options;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Space]
		private TMP_Dropdown.DropdownEvent m_OnValueChanged;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float m_AlphaFadeSpeed;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x148")]
		private GameObject m_Dropdown;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x150")]
		private GameObject m_Blocker;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x158")]
		private List<TMP_Dropdown.DropdownItem> m_Items;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x160")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x168")]
		private bool validTemplate;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine m_Coroutine;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_Dropdown.OptionData s_NoOptionData;

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000044")]
			public TMP_Text text
			{
				[Token(Token = "0x60001B4")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000045")]
			public Image image
			{
				[Token(Token = "0x60001B6")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B7")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				set
				{
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000046")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x60001B8")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B9")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				set
				{
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060001BA RID: 442 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000047")]
			public Toggle toggle
			{
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				set
				{
				}
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5880340", Offset = "0x587EF40", VA = "0x185880340", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x58802B0", Offset = "0x587EEB0", VA = "0x1858802B0", Slot = "7")]
			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			public DropdownItem()
			{
			}

			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TMP_Text m_Text;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image m_Image;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RectTransform m_RectTransform;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Toggle m_Toggle;
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		[Serializable]
		public class OptionData
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060001BF RID: 447 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000048")]
			public string text
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C0")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000049")]
			public Sprite image
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionData()
			{
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OptionData(string text)
			{
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
			public OptionData(Sprite image)
			{
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public OptionData(string text, Sprite image)
			{
			}

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Text;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_Image;
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700004A")]
			public List<TMP_Dropdown.OptionData> options
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x5881CF0", Offset = "0x58808F0", VA = "0x185881CF0")]
			public OptionDataList()
			{
			}

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<TMP_Dropdown.OptionData> m_Options;
		}

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x5880270", Offset = "0x587EE70", VA = "0x185880270")]
			public DropdownEvent()
			{
			}
		}
	}
}
