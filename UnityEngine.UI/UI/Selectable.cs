using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Selectable", 35)]
	[ExecuteAlways]
	[SelectionBase]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public static Selectable[] allSelectablesArray
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x5B791E0", Offset = "0x5B77DE0", VA = "0x185B791E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x1700012A")]
		public static int allSelectableCount
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x5B79190", Offset = "0x5B77D90", VA = "0x185B79190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x5B79270", Offset = "0x5B77E70", VA = "0x185B79270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x5B76AA0", Offset = "0x5B756A0", VA = "0x185B76AA0")]
		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			return 0;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003BB8 File Offset: 0x00001DB8
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012C")]
		public Navigation navigation
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xF54880", Offset = "0xF53480", VA = "0x180F54880")]
			get
			{
				return default(Navigation);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x5B79890", Offset = "0x5B78490", VA = "0x185B79890")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00003BD0 File Offset: 0x00001DD0
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012D")]
		public Selectable.Transition transition
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return Selectable.Transition.None;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x5B79A70", Offset = "0x5B78670", VA = "0x185B79A70")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012E")]
		public ColorBlock colors
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x5B793C0", Offset = "0x5B77FC0", VA = "0x185B793C0")]
			get
			{
				return default(ColorBlock);
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x5B79600", Offset = "0x5B78200", VA = "0x185B79600")]
			set
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00003C00 File Offset: 0x00001E00
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012F")]
		public SpriteState spriteState
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x5B79550", Offset = "0x5B78150", VA = "0x185B79550")]
			get
			{
				return default(SpriteState);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x5B79940", Offset = "0x5B78540", VA = "0x185B79940")]
			set
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000130")]
		public AnimationTriggers animationTriggers
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x789430", Offset = "0x788030", VA = "0x180789430")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x5B79570", Offset = "0x5B78170", VA = "0x185B79570")]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000131")]
		public Graphic targetGraphic
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x5B799E0", Offset = "0x5B785E0", VA = "0x185B799E0")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000132")]
		public virtual bool interactable
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x4C374F0", Offset = "0x4C360F0", VA = "0x184C374F0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x5B796E0", Offset = "0x5B782E0", VA = "0x185B796E0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000133")]
		protected bool isPointerInside
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x3739000", Offset = "0x3737C00", VA = "0x183739000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x37390F0", Offset = "0x3737CF0", VA = "0x1837390F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000134")]
		protected bool isPointerDown
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x5B79540", Offset = "0x5B78140", VA = "0x185B79540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x5B79880", Offset = "0x5B78480", VA = "0x185B79880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00003C60 File Offset: 0x00001E60
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000135")]
		protected bool hasSelection
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x5B79480", Offset = "0x5B78080", VA = "0x185B79480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x5B796D0", Offset = "0x5B782D0", VA = "0x185B796D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5B79000", Offset = "0x5B77C00", VA = "0x185B79000")]
		protected Selectable()
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000136")]
		public Image image
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x5B79490", Offset = "0x5B78090", VA = "0x185B79490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			set
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000137")]
		public Animator animator
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x5B79380", Offset = "0x5B77F80", VA = "0x185B79380")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x5B76B60", Offset = "0x5B75760", VA = "0x185B76B60", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x5B77FC0", Offset = "0x5B76BC0", VA = "0x185B77FC0", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x5B78990", Offset = "0x5B77590", VA = "0x185B78990")]
		private bool ParentGroupAllowsInteraction()
		{
			return default(bool);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x5B77DD0", Offset = "0x5B769D0", VA = "0x185B77DD0", Slot = "26")]
		public virtual bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x5B78040", Offset = "0x5B76C40", VA = "0x185B78040", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5B78340", Offset = "0x5B76F40", VA = "0x185B78340", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x5B78950", Offset = "0x5B77550", VA = "0x185B78950", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5B78040", Offset = "0x5B76C40", VA = "0x185B78040")]
		private void OnSetProperty()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5B78090", Offset = "0x5B76C90", VA = "0x185B78090", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x5B77F20", Offset = "0x5B76B20", VA = "0x185B77F20")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x17000138")]
		protected Selectable.SelectionState currentSelectionState
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x5B79400", Offset = "0x5B78000", VA = "0x185B79400")]
			get
			{
				return Selectable.SelectionState.Normal;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x5B77C60", Offset = "0x5B76860", VA = "0x185B77C60", Slot = "27")]
		protected virtual void InstantClearState()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x5B76CA0", Offset = "0x5B758A0", VA = "0x185B76CA0", Slot = "28")]
		protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5B77390", Offset = "0x5B75F90", VA = "0x185B77390")]
		public Selectable FindSelectable(Vector3 dir)
		{
			return null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x5B77A50", Offset = "0x5B76650", VA = "0x185B77A50")]
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x5B77E70", Offset = "0x5B76A70", VA = "0x185B77E70")]
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x5B770F0", Offset = "0x5B75CF0", VA = "0x185B770F0", Slot = "29")]
		public virtual Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x5B771D0", Offset = "0x5B75DD0", VA = "0x185B771D0", Slot = "30")]
		public virtual Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x5B772B0", Offset = "0x5B75EB0", VA = "0x185B772B0", Slot = "31")]
		public virtual Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x5B77010", Offset = "0x5B75C10", VA = "0x185B77010", Slot = "32")]
		public virtual Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x5B78630", Offset = "0x5B77230", VA = "0x185B78630", Slot = "33")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x5B78C10", Offset = "0x5B77810", VA = "0x185B78C10")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x5B76C00", Offset = "0x5B75800", VA = "0x185B76C00")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x5B78D30", Offset = "0x5B77930", VA = "0x185B78D30")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x5B77D40", Offset = "0x5B76940", VA = "0x185B77D40")]
		protected bool IsHighlighted()
		{
			return default(bool);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x5B77DF0", Offset = "0x5B769F0", VA = "0x185B77DF0")]
		protected bool IsPressed()
		{
			return default(bool);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x5B76F60", Offset = "0x5B75B60", VA = "0x185B76F60")]
		private void EvaluateAndTransitionToSelectionState()
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x5B787B0", Offset = "0x5B773B0", VA = "0x185B787B0", Slot = "34")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x5B78910", Offset = "0x5B77510", VA = "0x185B78910", Slot = "35")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x5B788F0", Offset = "0x5B774F0", VA = "0x185B788F0", Slot = "36")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x5B78900", Offset = "0x5B77500", VA = "0x185B78900", Slot = "37")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x5B78940", Offset = "0x5B77540", VA = "0x185B78940", Slot = "38")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x5B78030", Offset = "0x5B76C30", VA = "0x185B78030", Slot = "39")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x5B78B20", Offset = "0x5B77720", VA = "0x185B78B20", Slot = "40")]
		public virtual void Select()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		protected static Selectable[] s_Selectables;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x8")]
		protected static int s_SelectableCount;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x18")]
		private bool m_EnableCalled;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("navigation")]
		private Navigation m_Navigation;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("transition")]
		private Selectable.Transition m_Transition;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("colors")]
		[SerializeField]
		private ColorBlock m_Colors;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("spriteState")]
		[SerializeField]
		private SpriteState m_SpriteState;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0xC8")]
		[FormerlySerializedAs("animationTriggers")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Can the Selectable be interacted with?")]
		[SerializeField]
		private bool m_Interactable;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xD8")]
		[FormerlySerializedAs("highlightGraphic")]
		[SerializeField]
		[FormerlySerializedAs("m_HighlightGraphic")]
		private Graphic m_TargetGraphic;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_GroupsAllowInteraction;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0xE4")]
		protected int m_CurrentIndex;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<CanvasGroup> m_CanvasGroupCache;

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		public enum Transition
		{
			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			None,
			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			ColorTint,
			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			SpriteSwap,
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			Animation
		}

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		protected enum SelectionState
		{
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			Normal,
			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			Highlighted,
			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			Pressed,
			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			Selected,
			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			Disabled
		}
	}
}
