using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SelectionBase]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, IWheelListener, IScrollNormalizedPosition, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000106")]
		public RectTransform content
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000107")]
		public bool horizontal
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000108")]
		public bool vertical
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			set
			{
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000109")]
		public ScrollRect.MovementType movementType
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return ScrollRect.MovementType.Unrestricted;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010A")]
		public float elasticity
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010B")]
		public bool inertia
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public InertiaTickHandler.Option scrollOption
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010D")]
		public float decelerationRate
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010E")]
		public float scrollSensitivity
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x42B1310", Offset = "0x42AFF10", VA = "0x1842B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x4469FE0", Offset = "0x4468BE0", VA = "0x184469FE0")]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010F")]
		public RectTransform viewport
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x5B74EA0", Offset = "0x5B73AA0", VA = "0x185B74EA0")]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000110")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x5B74AC0", Offset = "0x5B736C0", VA = "0x185B74AC0")]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000111")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x5B74D00", Offset = "0x5B73900", VA = "0x185B74D00")]
			set
			{
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000112")]
		public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return ScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x5B74AB0", Offset = "0x5B736B0", VA = "0x185B74AB0")]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000113")]
		public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return ScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x5B74CF0", Offset = "0x5B738F0", VA = "0x185B74CF0")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000114")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x5B74AA0", Offset = "0x5B736A0", VA = "0x185B74AA0")]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000115")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x5B74CE0", Offset = "0x5B738E0", VA = "0x185B74CE0")]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000116")]
		public ScrollRect.ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x5B74980", Offset = "0x5B73580", VA = "0x185B74980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000118")]
		public Vector2 velocity
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x5B747F0", Offset = "0x5B733F0", VA = "0x185B747F0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x538FB30", Offset = "0x538E730", VA = "0x18538FB30")]
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000119")]
		public bool Scrolling
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x4DA4EC0", Offset = "0x4DA3AC0", VA = "0x184DA4EC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x4DA4FA0", Offset = "0x4DA3BA0", VA = "0x184DA4FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		public Canvas canvas
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x5B74410", Offset = "0x5B73010", VA = "0x185B74410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x5B746D0", Offset = "0x5B732D0", VA = "0x185B746D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x5B741E0", Offset = "0x5B72DE0", VA = "0x185B741E0")]
		protected ScrollRect()
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x5B71A80", Offset = "0x5B70680", VA = "0x185B71A80", Slot = "41")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "42")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5B73520", Offset = "0x5B72120", VA = "0x185B73520")]
		private void UpdateCachedData()
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x5B71440", Offset = "0x5B70040", VA = "0x185B71440", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x5B70F10", Offset = "0x5B6FB10", VA = "0x185B70F10", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x5B70C60", Offset = "0x5B6F860", VA = "0x185B70C60", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x5B704C0", Offset = "0x5B6F0C0", VA = "0x185B704C0")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x5B72CD0", Offset = "0x5B718D0", VA = "0x185B72CD0", Slot = "44")]
		public virtual void StopMovement()
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x5B71A60", Offset = "0x5B70660", VA = "0x185B71A60", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x5B719A0", Offset = "0x5B705A0", VA = "0x185B719A0", Slot = "45")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x5B716F0", Offset = "0x5B702F0", VA = "0x185B716F0")]
		public void OnScrollHandle(Vector2 delta)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x5B717A0", Offset = "0x5B703A0", VA = "0x185B717A0")]
		public void OnScrollWork(Vector2 delta)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x5B71670", Offset = "0x5B70270", VA = "0x185B71670", Slot = "46")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x5B70D90", Offset = "0x5B6F990", VA = "0x185B70D90", Slot = "47")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x5B71640", Offset = "0x5B70240", VA = "0x185B71640", Slot = "48")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x5B71160", Offset = "0x5B6FD60", VA = "0x185B71160", Slot = "49")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x5B71B70", Offset = "0x5B70770", VA = "0x185B71B70", Slot = "50")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x5B70CD0", Offset = "0x5B6F8D0", VA = "0x185B70CD0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5B6FA20", Offset = "0x5B6E620", VA = "0x185B6FA20", Slot = "52")]
		public virtual void BaseUpdate(float deltaTime)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5B739E0", Offset = "0x5B725E0", VA = "0x185B739E0")]
		protected void UpdatePrevData()
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5B73F90", Offset = "0x5B72B90", VA = "0x185B73F90")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011C")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x5B74690", Offset = "0x5B73290", VA = "0x185B74690")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x5B74C60", Offset = "0x5B73860", VA = "0x185B74C60")]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011D")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x5B74530", Offset = "0x5B73130", VA = "0x185B74530")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x5B71DC0", Offset = "0x5B709C0", VA = "0x185B71DC0")]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011E")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x5B74810", Offset = "0x5B73410", VA = "0x185B74810")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x5B72C80", Offset = "0x5B71880", VA = "0x185B72C80")]
			set
			{
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5B71DC0", Offset = "0x5B709C0", VA = "0x185B71DC0")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x5B72C80", Offset = "0x5B71880", VA = "0x185B72C80")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x5B72770", Offset = "0x5B71370", VA = "0x185B72770", Slot = "53")]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5B71B10", Offset = "0x5B70710", VA = "0x185B71B10")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return 0f;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5B716E0", Offset = "0x5B702E0", VA = "0x185B716E0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x1700011F")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x5B744C0", Offset = "0x5B730C0", VA = "0x185B744C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x17000120")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x5B74780", Offset = "0x5B73380", VA = "0x185B74780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "54")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "55")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x17000121")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "56")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x17000122")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "57")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x17000123")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "58")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x17000124")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "59")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x17000125")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000126")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "61")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x17000127")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "62")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x17000128")]
		public Vector2 position
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x5B74690", Offset = "0x5B73290", VA = "0x185B74690", Slot = "24")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5B71E10", Offset = "0x5B70A10", VA = "0x185B71E10", Slot = "63")]
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5B72620", Offset = "0x5B71220", VA = "0x185B72620", Slot = "64")]
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x5B73EA0", Offset = "0x5B72AA0", VA = "0x185B73EA0")]
		private void UpdateScrollbarVisibility()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x5B738F0", Offset = "0x5B724F0", VA = "0x185B738F0")]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x5B73AE0", Offset = "0x5B726E0", VA = "0x185B73AE0")]
		private void UpdateScrollbarLayout()
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x5B72DB0", Offset = "0x5B719B0", VA = "0x185B72DB0")]
		protected void UpdateBounds()
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x5B6F900", Offset = "0x5B6E500", VA = "0x185B6F900")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x5B70520", Offset = "0x5B6F120", VA = "0x185B70520")]
		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x5B70A50", Offset = "0x5B6F650", VA = "0x185B70A50")]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default(Bounds);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x5B702A0", Offset = "0x5B6EEA0", VA = "0x185B702A0")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x5B70860", Offset = "0x5B6F460", VA = "0x185B70860")]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x5B71D30", Offset = "0x5B70930", VA = "0x185B71D30")]
		protected void SetDirty()
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x5B71C60", Offset = "0x5B70860", VA = "0x185B71C60")]
		protected void SetDirtyCaching()
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "22")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x5B72D30", Offset = "0x5B71930", VA = "0x185B72D30", Slot = "23")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "26")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_Horizontal;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool m_Vertical;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ScrollRect.MovementType m_MovementType;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_Elasticity;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_Inertia;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_DecelerationRate;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InertiaTickHandler.Option m_scrollOption;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x0")]
		public static ScrollAspects s_aspects;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_ScrollSensitivity;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect.ScrollRectEvent m_OnValueChanged;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PointerStartLocalCursor;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x80")]
		protected Vector2 m_ContentStartPosition;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform m_ViewRect;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x90")]
		protected Bounds m_ContentBounds;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0xA8")]
		private Bounds m_ViewBounds;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0xC0")]
		private Vector2 m_Velocity;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_Dragging;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_Scrolling;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 m_PrevPosition;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0xD4")]
		private Bounds m_PrevContentBounds;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0xEC")]
		private Bounds m_PrevViewBounds;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x104")]
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x105")]
		private bool m_HSliderExpand;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x106")]
		private bool m_VSliderExpand;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x108")]
		private float m_HSliderHeight;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x10C")]
		private float m_VSliderWidth;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x118")]
		public ScrollWheelHandler scrollWheelHandler;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		private Canvas m_cacheCanvas;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x130")]
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x138")]
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x140")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x148")]
		private readonly Vector3[] m_Corners;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		public enum MovementType
		{
			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			Unrestricted,
			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			Elastic,
			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			Clamped
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public enum ScrollbarVisibility
		{
			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			Permanent,
			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			AutoHide,
			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			AutoHideAndExpandViewport
		}

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x5B6F8C0", Offset = "0x5B6E4C0", VA = "0x185B6F8C0")]
			public ScrollRectEvent()
			{
			}
		}
	}
}
