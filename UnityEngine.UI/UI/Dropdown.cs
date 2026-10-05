using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[AddComponentMenu("UI/Legacy/Dropdown", 102)]
	[RequireComponent(typeof(RectTransform))]
	public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000016")]
		public RectTransform template
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x5A12630", Offset = "0x5A11230", VA = "0x185A12630")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000017")]
		public Text captionText
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x5A12560", Offset = "0x5A11160", VA = "0x185A12560")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000018")]
		public Image captionImage
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5A12530", Offset = "0x5A11130", VA = "0x185A12530")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000019")]
		public Text itemText
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x5A125C0", Offset = "0x5A111C0", VA = "0x185A125C0")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001A")]
		public Image itemImage
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x5A12590", Offset = "0x5A11190", VA = "0x185A12590")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001B")]
		public List<Dropdown.OptionData> options
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x5A124F0", Offset = "0x5A110F0", VA = "0x185A124F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x5A125F0", Offset = "0x5A111F0", VA = "0x185A125F0")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001C")]
		public Dropdown.DropdownEvent onValueChanged
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001D")]
		public float alphaFadeSpeed
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5A124E0", Offset = "0x5A110E0", VA = "0x185A124E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x5A12520", Offset = "0x5A11120", VA = "0x185A12520")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001E")]
		public int value
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x5A12510", Offset = "0x5A11110", VA = "0x185A12510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x5A12660", Offset = "0x5A11260", VA = "0x185A12660")]
			set
			{
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5A10A20", Offset = "0x5A0F620", VA = "0x185A10A20")]
		public void SetValueWithoutNotify(int input)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5A10A30", Offset = "0x5A0F630", VA = "0x185A10A30")]
		private void Set(int value, bool sendCallback = true)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5A12320", Offset = "0x5A10F20", VA = "0x185A12320")]
		protected Dropdown()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5A0F890", Offset = "0x5A0E490", VA = "0x185A0F890", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5A121D0", Offset = "0x5A10DD0", VA = "0x185A121D0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5A10540", Offset = "0x5A0F140", VA = "0x185A10540", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x5A10740", Offset = "0x5A0F340", VA = "0x185A10740")]
		public void RefreshShownValue()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5A0F630", Offset = "0x5A0E230", VA = "0x185A0F630")]
		public void AddOptions(List<Dropdown.OptionData> options)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5A0F3D0", Offset = "0x5A0DFD0", VA = "0x185A0F3D0")]
		public void AddOptions(List<string> options)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5A0F500", Offset = "0x5A0E100", VA = "0x185A0F500")]
		public void AddOptions(List<Sprite> options)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5A0F9A0", Offset = "0x5A0E5A0", VA = "0x185A0F9A0")]
		public void ClearOptions()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5A10B40", Offset = "0x5A0F740", VA = "0x185A10B40")]
		private void SetupTemplate(Canvas rootCanvas)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5A10610", Offset = "0x5A0F210", VA = "0x185A10610", Slot = "44")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5A10610", Offset = "0x5A0F210", VA = "0x185A10610", Slot = "45")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5A10530", Offset = "0x5A0F130", VA = "0x185A10530", Slot = "46")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x5A11260", Offset = "0x5A0FE60", VA = "0x185A11260")]
		public void Show()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5A0FA20", Offset = "0x5A0E620", VA = "0x185A0FA20", Slot = "47")]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x5A100B0", Offset = "0x5A0ECB0", VA = "0x185A100B0", Slot = "48")]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x5A0FF60", Offset = "0x5A0EB60", VA = "0x185A0FF60", Slot = "49")]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x5A10100", Offset = "0x5A0ED00", VA = "0x185A10100", Slot = "50")]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x5A0FFC0", Offset = "0x5A0EBC0", VA = "0x185A0FFC0", Slot = "51")]
		protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "52")]
		protected virtual void DestroyItem(Dropdown.DropdownItem item)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x5A0F0E0", Offset = "0x5A0DCE0", VA = "0x185A0F0E0")]
		private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
		{
			return null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5A0F800", Offset = "0x5A0E400", VA = "0x185A0F800")]
		private void AlphaFadeList(float duration, float alpha)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x5A0F6A0", Offset = "0x5A0E2A0", VA = "0x185A0F6A0")]
		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x5A10970", Offset = "0x5A0F570", VA = "0x185A10970")]
		private void SetAlpha(float alpha)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5A10150", Offset = "0x5A0ED50", VA = "0x185A10150")]
		public void Hide()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x5A10020", Offset = "0x5A0EC20", VA = "0x185A10020")]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x5A10370", Offset = "0x5A0EF70", VA = "0x185A10370")]
		private void ImmediateDestroyDropdownList()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x5A10620", Offset = "0x5A0F220", VA = "0x185A10620")]
		private void OnSelectItem(Toggle toggle)
		{
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_Template;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text m_CaptionText;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image m_CaptionImage;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Space]
		private Text m_ItemText;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Image m_ItemImage;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x120")]
		[Space]
		[SerializeField]
		private int m_Value;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x128")]
		[Space]
		[SerializeField]
		private Dropdown.OptionDataList m_Options;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x130")]
		[Space]
		[SerializeField]
		private Dropdown.DropdownEvent m_OnValueChanged;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float m_AlphaFadeSpeed;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x140")]
		private GameObject m_Dropdown;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x148")]
		private GameObject m_Blocker;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x150")]
		private List<Dropdown.DropdownItem> m_Items;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x158")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x160")]
		private bool validTemplate;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		private const int kHighSortingLayer = 30000;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		private static Dropdown.OptionData s_NoOptionData;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700001F")]
			public Text text
			{
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000020")]
			public Image image
			{
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				set
				{
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000021")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x60000A6")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				set
				{
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000022")]
			public Toggle toggle
			{
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				set
				{
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x5A0F060", Offset = "0x5A0DC60", VA = "0x185A0F060", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x5A0EFD0", Offset = "0x5A0DBD0", VA = "0x185A0EFD0", Slot = "7")]
			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			public DropdownItem()
			{
			}

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text m_Text;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image m_Image;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RectTransform m_RectTransform;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Toggle m_Toggle;
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		[Serializable]
		public class OptionData
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000023")]
			public string text
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000024")]
			public Sprite image
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionData()
			{
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OptionData(string text)
			{
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
			public OptionData(Sprite image)
			{
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public OptionData(string text, Sprite image)
			{
			}

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Text;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_Image;
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000025")]
			public List<Dropdown.OptionData> options
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x5A22980", Offset = "0x5A21580", VA = "0x185A22980")]
			public OptionDataList()
			{
			}

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<Dropdown.OptionData> m_Options;
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5A0EF90", Offset = "0x5A0DB90", VA = "0x185A0EF90")]
			public DropdownEvent()
			{
			}
		}
	}
}
