using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003980 RID: 14720
	[Token(Token = "0x2003980")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LoopScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController, IWheelListener, IHotfixable, IScrollNormalizedPosition
	{
		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x060173F1 RID: 95217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060173F2 RID: 95218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700378B")]
		[Inspect]
		private LoopScrollAdapter adapter
		{
			[Token(Token = "0x60173F1")]
			[Address(RVA = "0xFA8000", Offset = "0xFA6C00", VA = "0x180FA8000")]
			get
			{
				return null;
			}
			[Token(Token = "0x60173F2")]
			[Address(RVA = "0xFA9E50", Offset = "0xFA8A50", VA = "0x180FA9E50")]
			set
			{
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x060173F3 RID: 95219 RVA: 0x00095778 File Offset: 0x00093978
		// (set) Token: 0x060173F4 RID: 95220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700378C")]
		private protected bool isLayoutReady
		{
			[Token(Token = "0x60173F3")]
			[Address(RVA = "0xFA8ED0", Offset = "0xFA7AD0", VA = "0x180FA8ED0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60173F4")]
			[Address(RVA = "0xFAA580", Offset = "0xFA9180", VA = "0x180FAA580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x060173F5 RID: 95221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700378D")]
		private LoopScrollRect.FlyBundle m_fly
		{
			[Token(Token = "0x60173F5")]
			[Address(RVA = "0xFA8F90", Offset = "0xFA7B90", VA = "0x180FA8F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060173F6 RID: 95222 RVA: 0x00095790 File Offset: 0x00093990
		[Token(Token = "0x60173F6")]
		[Address(RVA = "0xFA0BA0", Offset = "0xF9F7A0", VA = "0x180FA0BA0")]
		public int GetItemTypeStart()
		{
			return 0;
		}

		// Token: 0x060173F7 RID: 95223 RVA: 0x000957A8 File Offset: 0x000939A8
		[Token(Token = "0x60173F7")]
		[Address(RVA = "0xFA0B40", Offset = "0xF9F740", VA = "0x180FA0B40")]
		public int GetItemTypeEnd()
		{
			return 0;
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x060173F8 RID: 95224 RVA: 0x000957C0 File Offset: 0x000939C0
		[Token(Token = "0x1700378E")]
		public int startOffset
		{
			[Token(Token = "0x60173F8")]
			[Address(RVA = "0xFA94B0", Offset = "0xFA80B0", VA = "0x180FA94B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060173F9 RID: 95225
		[Token(Token = "0x60173F9")]
		protected abstract float GetSize(RectTransform item);

		// Token: 0x060173FA RID: 95226
		[Token(Token = "0x60173FA")]
		protected abstract float GetDimension(Vector2 vector);

		// Token: 0x060173FB RID: 95227
		[Token(Token = "0x60173FB")]
		protected abstract Vector2 GetVector(float value);

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x060173FC RID: 95228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700378F")]
		protected GridLayoutGroup gridLayout
		{
			[Token(Token = "0x60173FC")]
			[Address(RVA = "0xFA8AE0", Offset = "0xFA76E0", VA = "0x180FA8AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x060173FD RID: 95229 RVA: 0x000957D8 File Offset: 0x000939D8
		[Token(Token = "0x17003790")]
		protected float contentSpacing
		{
			[Token(Token = "0x60173FD")]
			[Address(RVA = "0xFA8700", Offset = "0xFA7300", VA = "0x180FA8700")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x060173FE RID: 95230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003791")]
		protected RectOffset contentPadding
		{
			[Token(Token = "0x60173FE")]
			[Address(RVA = "0xFA84F0", Offset = "0xFA70F0", VA = "0x180FA84F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x060173FF RID: 95231 RVA: 0x000957F0 File Offset: 0x000939F0
		[Token(Token = "0x17003792")]
		public int contentContraintCount
		{
			[Token(Token = "0x60173FF")]
			[Address(RVA = "0xFA8140", Offset = "0xFA6D40", VA = "0x180FA8140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06017400 RID: 95232 RVA: 0x00095808 File Offset: 0x00093A08
		[Token(Token = "0x6017400")]
		[Address(RVA = "0xF9F590", Offset = "0xF9E190", VA = "0x180F9F590")]
		protected int EstimateCountPerPage(bool useFloorCnt = true)
		{
			return 0;
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x00095820 File Offset: 0x00093A20
		[Token(Token = "0x6017401")]
		[Address(RVA = "0xFA0220", Offset = "0xF9EE20", VA = "0x180FA0220")]
		protected float EstimateTotalContentSize()
		{
			return 0f;
		}

		// Token: 0x06017402 RID: 95234 RVA: 0x00095838 File Offset: 0x00093A38
		[Token(Token = "0x6017402")]
		[Address(RVA = "0xF9EAE0", Offset = "0xF9D6E0", VA = "0x180F9EAE0")]
		protected static bool CheckIfNeedNewItemsToFill(float viewport, float padding, float entitySize, float totalSize)
		{
			return default(bool);
		}

		// Token: 0x06017403 RID: 95235 RVA: 0x00095850 File Offset: 0x00093A50
		[Token(Token = "0x6017403")]
		[Address(RVA = "0xFA6550", Offset = "0xFA5150", VA = "0x180FA6550", Slot = "44")]
		protected virtual bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			return default(bool);
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x06017404 RID: 95236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017405 RID: 95237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003793")]
		public RectTransform content
		{
			[Token(Token = "0x6017404")]
			[Address(RVA = "0xFA8900", Offset = "0xFA7500", VA = "0x180FA8900")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017405")]
			[Address(RVA = "0xFA9FB0", Offset = "0xFA8BB0", VA = "0x180FA9FB0")]
			set
			{
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x06017406 RID: 95238
		[Token(Token = "0x17003794")]
		protected abstract bool defaultHorizontal { [Token(Token = "0x6017406")] get; }

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x06017407 RID: 95239
		// (set) Token: 0x06017408 RID: 95240
		[Token(Token = "0x17003795")]
		[Inspect]
		[ReadOnly]
		public abstract bool horizontal { [Token(Token = "0x6017407")] get; [Token(Token = "0x6017408")] set; }

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x06017409 RID: 95241
		[Token(Token = "0x17003796")]
		protected abstract bool defaultVertical { [Token(Token = "0x6017409")] get; }

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0601740A RID: 95242
		// (set) Token: 0x0601740B RID: 95243
		[Token(Token = "0x17003797")]
		[Inspect]
		[ReadOnly]
		public abstract bool vertical { [Token(Token = "0x601740A")] get; [Token(Token = "0x601740B")] set; }

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0601740C RID: 95244 RVA: 0x00095868 File Offset: 0x00093A68
		// (set) Token: 0x0601740D RID: 95245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003798")]
		public LoopScrollRect.MovementType movementType
		{
			[Token(Token = "0x601740C")]
			[Address(RVA = "0xFA9160", Offset = "0xFA7D60", VA = "0x180FA9160")]
			get
			{
				return LoopScrollRect.MovementType.Unrestricted;
			}
			[Token(Token = "0x601740D")]
			[Address(RVA = "0xFAA5F0", Offset = "0xFA91F0", VA = "0x180FAA5F0")]
			set
			{
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0601740E RID: 95246 RVA: 0x00095880 File Offset: 0x00093A80
		// (set) Token: 0x0601740F RID: 95247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003799")]
		public float elasticity
		{
			[Token(Token = "0x601740E")]
			[Address(RVA = "0xFA89C0", Offset = "0xFA75C0", VA = "0x180FA89C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601740F")]
			[Address(RVA = "0xFAA0B0", Offset = "0xFA8CB0", VA = "0x180FAA0B0")]
			set
			{
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06017410 RID: 95248 RVA: 0x00095898 File Offset: 0x00093A98
		// (set) Token: 0x06017411 RID: 95249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379A")]
		public bool inertia
		{
			[Token(Token = "0x6017410")]
			[Address(RVA = "0xFA8E70", Offset = "0xFA7A70", VA = "0x180FA8E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017411")]
			[Address(RVA = "0xFAA510", Offset = "0xFA9110", VA = "0x180FAA510")]
			set
			{
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x06017412 RID: 95250 RVA: 0x000958B0 File Offset: 0x00093AB0
		// (set) Token: 0x06017413 RID: 95251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379B")]
		public float decelerationRate
		{
			[Token(Token = "0x6017412")]
			[Address(RVA = "0xFA8960", Offset = "0xFA7560", VA = "0x180FA8960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017413")]
			[Address(RVA = "0xFAA030", Offset = "0xFA8C30", VA = "0x180FAA030")]
			set
			{
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x06017414 RID: 95252 RVA: 0x000958C8 File Offset: 0x00093AC8
		// (set) Token: 0x06017415 RID: 95253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379C")]
		public float scrollSensitivity
		{
			[Token(Token = "0x6017414")]
			[Address(RVA = "0xFA9450", Offset = "0xFA8050", VA = "0x180FA9450")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017415")]
			[Address(RVA = "0xFAA780", Offset = "0xFA9380", VA = "0x180FAA780")]
			set
			{
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x06017416 RID: 95254 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017417 RID: 95255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379D")]
		public RectTransform viewport
		{
			[Token(Token = "0x6017416")]
			[Address(RVA = "0xFA9920", Offset = "0xFA8520", VA = "0x180FA9920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017417")]
			[Address(RVA = "0xFAABF0", Offset = "0xFA97F0", VA = "0x180FAABF0")]
			set
			{
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x06017418 RID: 95256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017419 RID: 95257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379E")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x6017418")]
			[Address(RVA = "0xFA8E10", Offset = "0xFA7A10", VA = "0x180FA8E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017419")]
			[Address(RVA = "0xFAA320", Offset = "0xFA8F20", VA = "0x180FAA320")]
			set
			{
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0601741A RID: 95258 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601741B RID: 95259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700379F")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x601741A")]
			[Address(RVA = "0xFA9760", Offset = "0xFA8360", VA = "0x180FA9760")]
			get
			{
				return null;
			}
			[Token(Token = "0x601741B")]
			[Address(RVA = "0xFAAA00", Offset = "0xFA9600", VA = "0x180FAAA00")]
			set
			{
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0601741C RID: 95260 RVA: 0x000958E0 File Offset: 0x00093AE0
		// (set) Token: 0x0601741D RID: 95261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A0")]
		public LoopScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x601741C")]
			[Address(RVA = "0xFA8DB0", Offset = "0xFA79B0", VA = "0x180FA8DB0")]
			get
			{
				return LoopScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x601741D")]
			[Address(RVA = "0xFAA2A0", Offset = "0xFA8EA0", VA = "0x180FAA2A0")]
			set
			{
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0601741E RID: 95262 RVA: 0x000958F8 File Offset: 0x00093AF8
		// (set) Token: 0x0601741F RID: 95263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A1")]
		public LoopScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x601741E")]
			[Address(RVA = "0xFA9700", Offset = "0xFA8300", VA = "0x180FA9700")]
			get
			{
				return LoopScrollRect.ScrollbarVisibility.Permanent;
			}
			[Token(Token = "0x601741F")]
			[Address(RVA = "0xFAA980", Offset = "0xFA9580", VA = "0x180FAA980")]
			set
			{
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x06017420 RID: 95264 RVA: 0x00095910 File Offset: 0x00093B10
		// (set) Token: 0x06017421 RID: 95265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A2")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x6017420")]
			[Address(RVA = "0xFA8D50", Offset = "0xFA7950", VA = "0x180FA8D50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017421")]
			[Address(RVA = "0xFAA220", Offset = "0xFA8E20", VA = "0x180FAA220")]
			set
			{
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x06017422 RID: 95266 RVA: 0x00095928 File Offset: 0x00093B28
		// (set) Token: 0x06017423 RID: 95267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A3")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x6017422")]
			[Address(RVA = "0xFA96A0", Offset = "0xFA82A0", VA = "0x180FA96A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017423")]
			[Address(RVA = "0xFAA900", Offset = "0xFA9500", VA = "0x180FAA900")]
			set
			{
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x06017424 RID: 95268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017425 RID: 95269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A4")]
		public LoopScrollRect.ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x6017424")]
			[Address(RVA = "0xFA9250", Offset = "0xFA7E50", VA = "0x180FA9250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017425")]
			[Address(RVA = "0xFAA700", Offset = "0xFA9300", VA = "0x180FAA700")]
			set
			{
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x06017426 RID: 95270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037A5")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x6017426")]
			[Address(RVA = "0xFA97C0", Offset = "0xFA83C0", VA = "0x180FA97C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x06017427 RID: 95271 RVA: 0x00095940 File Offset: 0x00093B40
		// (set) Token: 0x06017428 RID: 95272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037A6")]
		public Vector2 velocity
		{
			[Token(Token = "0x6017427")]
			[Address(RVA = "0xFA95C0", Offset = "0xFA81C0", VA = "0x180FA95C0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6017428")]
			[Address(RVA = "0xFAA800", Offset = "0xFA9400", VA = "0x180FAA800")]
			set
			{
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x06017429 RID: 95273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037A7")]
		public ScrollWheelHandler wheelHandler
		{
			[Token(Token = "0x6017429")]
			[Address(RVA = "0xFA99F0", Offset = "0xFA85F0", VA = "0x180FA99F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0601742A RID: 95274 RVA: 0x00095958 File Offset: 0x00093B58
		[Token(Token = "0x170037A8")]
		public Vector2 wholeCalcSize
		{
			[Token(Token = "0x601742A")]
			[Address(RVA = "0xFA9A60", Offset = "0xFA8660", VA = "0x180FA9A60")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0601742B RID: 95275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601742B")]
		[Address(RVA = "0xFA50B0", Offset = "0xFA3CB0", VA = "0x180FA50B0")]
		public void SetPostLayoutCallback(Action onPostLayoutCallback)
		{
		}

		// Token: 0x0601742C RID: 95276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601742C")]
		[Address(RVA = "0xF9E9E0", Offset = "0xF9D5E0", VA = "0x180F9E9E0")]
		public void CancelPostLayoutCallback(Action onPostLayoutCallback)
		{
		}

		// Token: 0x0601742D RID: 95277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601742D")]
		[Address(RVA = "0xFA7A60", Offset = "0xFA6660", VA = "0x180FA7A60")]
		private void _TryToCallbackWhenPostLayout()
		{
		}

		// Token: 0x0601742E RID: 95278 RVA: 0x00095970 File Offset: 0x00093B70
		[Token(Token = "0x601742E")]
		[Address(RVA = "0xF9FCE0", Offset = "0xF9E8E0", VA = "0x180F9FCE0")]
		public Vector2 EstimateTargetNormalizedPos(int index)
		{
			return default(Vector2);
		}

		// Token: 0x0601742F RID: 95279 RVA: 0x00095988 File Offset: 0x00093B88
		[Token(Token = "0x601742F")]
		[Address(RVA = "0xF9F840", Offset = "0xF9E440", VA = "0x180F9F840")]
		public Bounds EstimateTargetBounds(int index)
		{
			return default(Bounds);
		}

		// Token: 0x06017430 RID: 95280 RVA: 0x000959A0 File Offset: 0x00093BA0
		[Token(Token = "0x6017430")]
		[Address(RVA = "0xFA0410", Offset = "0xF9F010", VA = "0x180FA0410")]
		public int FindNearIndex(int targetIndex, Vector2 targetPos, float slideMaxLength)
		{
			return 0;
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x06017431 RID: 95281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037A9")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6017431")]
			[Address(RVA = "0xFA9370", Offset = "0xFA7F70", VA = "0x180FA9370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017432 RID: 95282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017432")]
		[Address(RVA = "0xFA7D90", Offset = "0xFA6990", VA = "0x180FA7D90")]
		protected LoopScrollRect()
		{
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017433")]
		[Address(RVA = "0xF9EBE0", Offset = "0xF9D7E0", VA = "0x180F9EBE0")]
		public void ClearCells()
		{
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017434")]
		[Address(RVA = "0xFA3A70", Offset = "0xFA2670", VA = "0x180FA3A70")]
		public void RefreshCells()
		{
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017435")]
		[Address(RVA = "0xFA3990", Offset = "0xFA2590", VA = "0x180FA3990")]
		public void RefreshCell(int itemDataIndex)
		{
		}

		// Token: 0x06017436 RID: 95286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017436")]
		[Address(RVA = "0xFA0CC0", Offset = "0xF9F8C0", VA = "0x180FA0CC0")]
		public void HandleViews(Action<GameObject> viewHandler)
		{
		}

		// Token: 0x06017437 RID: 95287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017437")]
		[Address(RVA = "0xFA35C0", Offset = "0xFA21C0", VA = "0x180FA35C0")]
		public void RefillCells(int offset = 0)
		{
		}

		// Token: 0x06017438 RID: 95288 RVA: 0x000959B8 File Offset: 0x00093BB8
		[Token(Token = "0x6017438")]
		[Address(RVA = "0xFA21B0", Offset = "0xFA0DB0", VA = "0x180FA21B0")]
		protected float NewItemAtStart()
		{
			return 0f;
		}

		// Token: 0x06017439 RID: 95289 RVA: 0x000959D0 File Offset: 0x00093BD0
		[Token(Token = "0x6017439")]
		[Address(RVA = "0xF9F050", Offset = "0xF9DC50", VA = "0x180F9F050")]
		protected float DeleteItemAtStart()
		{
			return 0f;
		}

		// Token: 0x0601743A RID: 95290 RVA: 0x000959E8 File Offset: 0x00093BE8
		[Token(Token = "0x601743A")]
		[Address(RVA = "0xFA1E90", Offset = "0xFA0A90", VA = "0x180FA1E90")]
		protected float NewItemAtEnd()
		{
			return 0f;
		}

		// Token: 0x0601743B RID: 95291 RVA: 0x00095A00 File Offset: 0x00093C00
		[Token(Token = "0x601743B")]
		[Address(RVA = "0xF9ECA0", Offset = "0xF9D8A0", VA = "0x180F9ECA0")]
		protected float DeleteItemAtEnd()
		{
			return 0f;
		}

		// Token: 0x0601743C RID: 95292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601743C")]
		[Address(RVA = "0xFA0FC0", Offset = "0xF9FBC0", VA = "0x180FA0FC0")]
		protected RectTransform InstNextItemAtStart(int itemIdx)
		{
			return null;
		}

		// Token: 0x0601743D RID: 95293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601743D")]
		[Address(RVA = "0xFA0DF0", Offset = "0xF9F9F0", VA = "0x180FA0DF0")]
		protected RectTransform InstNextItemAtEnd(int itemIdx)
		{
			return null;
		}

		// Token: 0x0601743E RID: 95294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601743E")]
		[Address(RVA = "0xFA7170", Offset = "0xFA5D70", VA = "0x180FA7170")]
		private void _BindWheelListener()
		{
		}

		// Token: 0x0601743F RID: 95295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601743F")]
		[Address(RVA = "0xFA34B0", Offset = "0xFA20B0", VA = "0x180FA34B0", Slot = "51")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06017440 RID: 95296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017440")]
		[Address(RVA = "0xFA1D50", Offset = "0xFA0950", VA = "0x180FA1D50", Slot = "52")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06017441 RID: 95297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017441")]
		[Address(RVA = "0xFA0C60", Offset = "0xF9F860", VA = "0x180FA0C60", Slot = "53")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06017442 RID: 95298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017442")]
		[Address(RVA = "0xFA6090", Offset = "0xFA4C90", VA = "0x180FA6090")]
		private void UpdateCachedData()
		{
		}

		// Token: 0x06017443 RID: 95299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017443")]
		[Address(RVA = "0xFA2DE0", Offset = "0xFA19E0", VA = "0x180FA2DE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06017444 RID: 95300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017444")]
		[Address(RVA = "0xFA2830", Offset = "0xFA1430", VA = "0x180FA2830", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x00095A18 File Offset: 0x00093C18
		[Token(Token = "0x6017445")]
		[Address(RVA = "0xFA1190", Offset = "0xF9FD90", VA = "0x180FA1190", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017446")]
		[Address(RVA = "0xF9F4F0", Offset = "0xF9E0F0", VA = "0x180F9F4F0")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017447")]
		[Address(RVA = "0xFA53D0", Offset = "0xFA3FD0", VA = "0x180FA53D0", Slot = "54")]
		public virtual void StopMovement()
		{
		}

		// Token: 0x06017448 RID: 95304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017448")]
		[Address(RVA = "0xFA3400", Offset = "0xFA2000", VA = "0x180FA3400", Slot = "55")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		// Token: 0x06017449 RID: 95305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017449")]
		[Address(RVA = "0xFA32E0", Offset = "0xFA1EE0", VA = "0x180FA32E0", Slot = "56")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601744A RID: 95306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744A")]
		[Address(RVA = "0xFA2640", Offset = "0xFA1240", VA = "0x180FA2640", Slot = "57")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601744B RID: 95307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744B")]
		[Address(RVA = "0xFA3160", Offset = "0xFA1D60", VA = "0x180FA3160", Slot = "58")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601744C RID: 95308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744C")]
		[Address(RVA = "0xFA2AC0", Offset = "0xFA16C0", VA = "0x180FA2AC0", Slot = "59")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601744D RID: 95309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744D")]
		[Address(RVA = "0xFA3D00", Offset = "0xFA2900", VA = "0x180FA3D00", Slot = "60")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744E")]
		[Address(RVA = "0xFA12C0", Offset = "0xF9FEC0", VA = "0x180FA12C0", Slot = "61")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0601744F RID: 95311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601744F")]
		[Address(RVA = "0xFA6610", Offset = "0xFA5210", VA = "0x180FA6610")]
		private void UpdatePrevData()
		{
		}

		// Token: 0x06017450 RID: 95312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017450")]
		[Address(RVA = "0xFA6D10", Offset = "0xFA5910", VA = "0x180FA6D10")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x06017451 RID: 95313 RVA: 0x00095A30 File Offset: 0x00093C30
		// (set) Token: 0x06017452 RID: 95314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037AA")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x6017451")]
			[Address(RVA = "0xFA91C0", Offset = "0xFA7DC0", VA = "0x180FA91C0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6017452")]
			[Address(RVA = "0xFAA660", Offset = "0xFA9260", VA = "0x180FAA660")]
			set
			{
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x06017453 RID: 95315 RVA: 0x00095A48 File Offset: 0x00093C48
		[Token(Token = "0x170037AB")]
		private Vector2 position
		{
			[Token(Token = "0x6017453")]
			[Address(RVA = "0xFA5670", Offset = "0xFA4270", VA = "0x180FA5670", Slot = "40")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06017454 RID: 95316 RVA: 0x00095A60 File Offset: 0x00093C60
		// (set) Token: 0x06017455 RID: 95317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037AC")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x6017454")]
			[Address(RVA = "0xFA8CE0", Offset = "0xFA78E0", VA = "0x180FA8CE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017455")]
			[Address(RVA = "0xFAA1A0", Offset = "0xFA8DA0", VA = "0x180FAA1A0")]
			set
			{
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06017456 RID: 95318 RVA: 0x00095A78 File Offset: 0x00093C78
		// (set) Token: 0x06017457 RID: 95319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037AD")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x6017456")]
			[Address(RVA = "0xFA9630", Offset = "0xFA8230", VA = "0x180FA9630")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017457")]
			[Address(RVA = "0xFAA880", Offset = "0xFA9480", VA = "0x180FAA880")]
			set
			{
			}
		}

		// Token: 0x06017458 RID: 95320 RVA: 0x00095A90 File Offset: 0x00093C90
		[Token(Token = "0x6017458")]
		[Address(RVA = "0xFA7420", Offset = "0xFA6020", VA = "0x180FA7420")]
		private float _HorizontalNormPosAfterUpdateBound()
		{
			return 0f;
		}

		// Token: 0x06017459 RID: 95321 RVA: 0x00095AA8 File Offset: 0x00093CA8
		[Token(Token = "0x6017459")]
		[Address(RVA = "0xFA7AE0", Offset = "0xFA66E0", VA = "0x180FA7AE0")]
		private float _VerticalNormPosAfterUpdateBound()
		{
			return 0f;
		}

		// Token: 0x0601745A RID: 95322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601745A")]
		[Address(RVA = "0xFA4090", Offset = "0xFA2C90", VA = "0x180FA4090")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		// Token: 0x0601745B RID: 95323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601745B")]
		[Address(RVA = "0xFA52E0", Offset = "0xFA3EE0", VA = "0x180FA52E0")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		// Token: 0x0601745C RID: 95324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601745C")]
		[Address(RVA = "0xFA4B80", Offset = "0xFA3780", VA = "0x180FA4B80")]
		private void SetNormalizedPosition(float value, int axis)
		{
		}

		// Token: 0x0601745D RID: 95325 RVA: 0x00095AC0 File Offset: 0x00093CC0
		[Token(Token = "0x601745D")]
		[Address(RVA = "0xFA3C30", Offset = "0xFA2830", VA = "0x180FA3C30")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return 0f;
		}

		// Token: 0x0601745E RID: 95326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601745E")]
		[Address(RVA = "0xFA1DB0", Offset = "0xFA09B0", VA = "0x180FA1DB0")]
		protected Canvas NearestEnabledCanvas()
		{
			return null;
		}

		// Token: 0x0601745F RID: 95327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601745F")]
		[Address(RVA = "0xFA33A0", Offset = "0xFA1FA0", VA = "0x180FA33A0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x06017460 RID: 95328 RVA: 0x00095AD8 File Offset: 0x00093CD8
		[Token(Token = "0x170037AE")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x6017460")]
			[Address(RVA = "0xFA8C30", Offset = "0xFA7830", VA = "0x180FA8C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x06017461 RID: 95329 RVA: 0x00095AF0 File Offset: 0x00093CF0
		[Token(Token = "0x170037AF")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x6017461")]
			[Address(RVA = "0xFA9510", Offset = "0xFA8110", VA = "0x180FA9510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017462 RID: 95330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017462")]
		[Address(RVA = "0xF9E5E0", Offset = "0xF9D1E0", VA = "0x180F9E5E0", Slot = "62")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06017463 RID: 95331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017463")]
		[Address(RVA = "0xF9E640", Offset = "0xF9D240", VA = "0x180F9E640", Slot = "63")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x06017464 RID: 95332 RVA: 0x00095B08 File Offset: 0x00093D08
		[Token(Token = "0x170037B0")]
		public virtual float minWidth
		{
			[Token(Token = "0x6017464")]
			[Address(RVA = "0xFA9100", Offset = "0xFA7D00", VA = "0x180FA9100", Slot = "64")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x06017465 RID: 95333 RVA: 0x00095B20 File Offset: 0x00093D20
		[Token(Token = "0x170037B1")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6017465")]
			[Address(RVA = "0xFA9310", Offset = "0xFA7F10", VA = "0x180FA9310", Slot = "65")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x06017466 RID: 95334 RVA: 0x00095B38 File Offset: 0x00093D38
		// (set) Token: 0x06017467 RID: 95335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037B2")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6017466")]
			[Address(RVA = "0xFA8A80", Offset = "0xFA7680", VA = "0x180FA8A80", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017467")]
			[Address(RVA = "0xFAA120", Offset = "0xFA8D20", VA = "0x180FAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x06017468 RID: 95336 RVA: 0x00095B50 File Offset: 0x00093D50
		[Token(Token = "0x170037B3")]
		public virtual float minHeight
		{
			[Token(Token = "0x6017468")]
			[Address(RVA = "0xFA90A0", Offset = "0xFA7CA0", VA = "0x180FA90A0", Slot = "67")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x06017469 RID: 95337 RVA: 0x00095B68 File Offset: 0x00093D68
		[Token(Token = "0x170037B4")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6017469")]
			[Address(RVA = "0xFA92B0", Offset = "0xFA7EB0", VA = "0x180FA92B0", Slot = "68")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0601746A RID: 95338 RVA: 0x00095B80 File Offset: 0x00093D80
		[Token(Token = "0x170037B5")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x601746A")]
			[Address(RVA = "0xFA8A20", Offset = "0xFA7620", VA = "0x180FA8A20", Slot = "69")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0601746B RID: 95339 RVA: 0x00095B98 File Offset: 0x00093D98
		[Token(Token = "0x170037B6")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x601746B")]
			[Address(RVA = "0xFA8F30", Offset = "0xFA7B30", VA = "0x180FA8F30", Slot = "70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601746C RID: 95340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601746C")]
		[Address(RVA = "0xFA4110", Offset = "0xFA2D10", VA = "0x180FA4110", Slot = "71")]
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x0601746D RID: 95341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601746D")]
		[Address(RVA = "0xFA49D0", Offset = "0xFA35D0", VA = "0x180FA49D0", Slot = "72")]
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x0601746E RID: 95342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601746E")]
		[Address(RVA = "0xFA6B50", Offset = "0xFA5750", VA = "0x180FA6B50")]
		private void UpdateScrollbarVisibility()
		{
		}

		// Token: 0x0601746F RID: 95343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601746F")]
		[Address(RVA = "0xFA6750", Offset = "0xFA5350", VA = "0x180FA6750")]
		private void UpdateScrollbarLayout()
		{
		}

		// Token: 0x06017470 RID: 95344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017470")]
		[Address(RVA = "0xFA5700", Offset = "0xFA4300", VA = "0x180FA5700")]
		private void UpdateBounds(bool updateItems = true)
		{
		}

		// Token: 0x06017471 RID: 95345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017471")]
		[Address(RVA = "0xF9E2D0", Offset = "0xF9CED0", VA = "0x180F9E2D0")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		// Token: 0x06017472 RID: 95346 RVA: 0x00095BB0 File Offset: 0x00093DB0
		[Token(Token = "0x6017472")]
		[Address(RVA = "0xFA0790", Offset = "0xF9F390", VA = "0x180FA0790")]
		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06017473 RID: 95347 RVA: 0x00095BC8 File Offset: 0x00093DC8
		[Token(Token = "0x6017473")]
		[Address(RVA = "0xF9E6A0", Offset = "0xF9D2A0", VA = "0x180F9E6A0")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		// Token: 0x06017474 RID: 95348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017474")]
		[Address(RVA = "0xFA3FD0", Offset = "0xFA2BD0", VA = "0x180FA3FD0")]
		protected void SetDirty()
		{
		}

		// Token: 0x06017475 RID: 95349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017475")]
		[Address(RVA = "0xFA3EE0", Offset = "0xFA2AE0", VA = "0x180FA3EE0")]
		protected void SetDirtyCaching()
		{
		}

		// Token: 0x06017476 RID: 95350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017476")]
		[Address(RVA = "0xFA25C0", Offset = "0xFA11C0", VA = "0x180FA25C0", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x06017477 RID: 95351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037B7")]
		private Canvas canvas
		{
			[Token(Token = "0x6017477")]
			[Address(RVA = "0xFA8060", Offset = "0xFA6C60", VA = "0x180FA8060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017478 RID: 95352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017478")]
		[Address(RVA = "0xFA7620", Offset = "0xFA6220", VA = "0x180FA7620")]
		private void _InitTorappuIfNot()
		{
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017479")]
		[Address(RVA = "0xFA7690", Offset = "0xFA6290", VA = "0x180FA7690")]
		private IEnumerator _NotifyActivateCoroutine()
		{
			return null;
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x00095BE0 File Offset: 0x00093DE0
		[Token(Token = "0x601747A")]
		[Address(RVA = "0xFA1230", Offset = "0xF9FE30", VA = "0x180FA1230")]
		protected bool IsVelocityZero()
		{
			return default(bool);
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601747B")]
		[Address(RVA = "0xFA7CE0", Offset = "0xFA68E0", VA = "0x180FA7CE0")]
		private IEnumerator _WaitForLayoutReady()
		{
			return null;
		}

		// Token: 0x0601747C RID: 95356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601747C")]
		[Address(RVA = "0xFA5360", Offset = "0xFA3F60", VA = "0x180FA5360", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0601747D RID: 95357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601747D")]
		[Address(RVA = "0xF9E440", Offset = "0xF9D040", VA = "0x180F9E440")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0601747E RID: 95358 RVA: 0x00095BF8 File Offset: 0x00093DF8
		[Token(Token = "0x601747E")]
		[Address(RVA = "0xFA0C00", Offset = "0xF9F800", VA = "0x180FA0C00", Slot = "38")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0601747F RID: 95359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601747F")]
		[Address(RVA = "0xFA7740", Offset = "0xFA6340", VA = "0x180FA7740")]
		private void _OnScrollWork(Vector2 delta)
		{
		}

		// Token: 0x06017480 RID: 95360 RVA: 0x00095C10 File Offset: 0x00093E10
		[Token(Token = "0x6017480")]
		[Address(RVA = "0xFA5470", Offset = "0xFA4070", VA = "0x180FA5470", Slot = "39")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x06017481 RID: 95361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017481")]
		[Address(RVA = "0xFA5610", Offset = "0xFA4210", VA = "0x180FA5610", Slot = "23")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06017482 RID: 95362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017482")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06017483 RID: 95363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017483")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x06017484 RID: 95364 RVA: 0x00095C28 File Offset: 0x00093E28
		[Token(Token = "0x6017484")]
		[Address(RVA = "0xFA5600", Offset = "0xFA4200", VA = "0x180FA5600")]
		private bool <>xLuaBaseProxy_IsActive()
		{
			return default(bool);
		}

		// Token: 0x06017485 RID: 95365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017485")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06017486 RID: 95366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017486")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x06017487 RID: 95367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017487")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x0401C0FB RID: 114939
		[Token(Token = "0x401C0FB")]
		private const float INERTIA_THRESHOLD = 70f;

		// Token: 0x0401C0FC RID: 114940
		[Token(Token = "0x401C0FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private LoopScrollAdapter _adapter;

		// Token: 0x0401C0FE RID: 114942
		[Token(Token = "0x401C0FE")]
		private const float FLY_THRESHOLD = 1000f;

		// Token: 0x0401C0FF RID: 114943
		[Token(Token = "0x401C0FF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("The max speed for gesture \"fly\"")]
		private float _flyMaxSpeed;

		// Token: 0x0401C100 RID: 114944
		[Token(Token = "0x401C100")]
		[FieldOffset(Offset = "0x28")]
		private LoopScrollRect.FlyBundle m_flyBundleCache;

		// Token: 0x0401C101 RID: 114945
		[Token(Token = "0x401C101")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("pixel distance for preloading and deleting")]
		public float threshold;

		// Token: 0x0401C102 RID: 114946
		[Token(Token = "0x401C102")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		[Obsolete("PreloadHold couldn't be supported correctly and has been deprecated.")]
		public float preLoadHold;

		// Token: 0x0401C103 RID: 114947
		[Token(Token = "0x401C103")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[Tooltip("Reverse direction for dragging")]
		[Obsolete("Don't use, not supported")]
		public bool reverseDirection;

		// Token: 0x0401C104 RID: 114948
		[Token(Token = "0x401C104")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Rubber scale for outside")]
		public float rubberScale;

		// Token: 0x0401C105 RID: 114949
		[Token(Token = "0x401C105")]
		[FieldOffset(Offset = "0x40")]
		[Inspect]
		[ReadOnly]
		protected int itemTypeStart;

		// Token: 0x0401C106 RID: 114950
		[Token(Token = "0x401C106")]
		[FieldOffset(Offset = "0x44")]
		[Inspect]
		[ReadOnly]
		protected int itemTypeEnd;

		// Token: 0x0401C107 RID: 114951
		[Token(Token = "0x401C107")]
		[FieldOffset(Offset = "0x48")]
		protected int directionSign;

		// Token: 0x0401C108 RID: 114952
		[Token(Token = "0x401C108")]
		[FieldOffset(Offset = "0x4C")]
		private float m_contentSpacing;

		// Token: 0x0401C109 RID: 114953
		[Token(Token = "0x401C109")]
		[FieldOffset(Offset = "0x50")]
		private RectOffset m_contentPadding;

		// Token: 0x0401C10A RID: 114954
		[Token(Token = "0x401C10A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_gridNotFound;

		// Token: 0x0401C10B RID: 114955
		[Token(Token = "0x401C10B")]
		[FieldOffset(Offset = "0x60")]
		private GridLayoutGroup m_gridLayout;

		// Token: 0x0401C10C RID: 114956
		[Token(Token = "0x401C10C")]
		[FieldOffset(Offset = "0x68")]
		private int m_contentConstraintCount;

		// Token: 0x0401C10D RID: 114957
		[Token(Token = "0x401C10D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0401C10E RID: 114958
		[Token(Token = "0x401C10E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LoopScrollRect.MovementType m_MovementType;

		// Token: 0x0401C10F RID: 114959
		[Token(Token = "0x401C10F")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float m_Elasticity;

		// Token: 0x0401C110 RID: 114960
		[Token(Token = "0x401C110")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool m_Inertia;

		// Token: 0x0401C111 RID: 114961
		[Token(Token = "0x401C111")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float m_DecelerationRate;

		// Token: 0x0401C112 RID: 114962
		[Token(Token = "0x401C112")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float m_ScrollSensitivity;

		// Token: 0x0401C113 RID: 114963
		[Token(Token = "0x401C113")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x0401C114 RID: 114964
		[Token(Token = "0x401C114")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x0401C115 RID: 114965
		[Token(Token = "0x401C115")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x0401C116 RID: 114966
		[Token(Token = "0x401C116")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private LoopScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x0401C117 RID: 114967
		[Token(Token = "0x401C117")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private LoopScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x0401C118 RID: 114968
		[Token(Token = "0x401C118")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x0401C119 RID: 114969
		[Token(Token = "0x401C119")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x0401C11A RID: 114970
		[Token(Token = "0x401C11A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private LoopScrollRect.ScrollRectEvent m_OnValueChanged;

		// Token: 0x0401C11B RID: 114971
		[Token(Token = "0x401C11B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private InertiaTickHandler.Option m_ScrollOption;

		// Token: 0x0401C11C RID: 114972
		[Token(Token = "0x401C11C")]
		[FieldOffset(Offset = "0xC8")]
		private Vector2 m_PointerStartLocalCursor;

		// Token: 0x0401C11D RID: 114973
		[Token(Token = "0x401C11D")]
		[FieldOffset(Offset = "0xD0")]
		private Vector2 m_ContentStartPosition;

		// Token: 0x0401C11E RID: 114974
		[Token(Token = "0x401C11E")]
		[FieldOffset(Offset = "0xD8")]
		private RectTransform m_ViewRect;

		// Token: 0x0401C11F RID: 114975
		[Token(Token = "0x401C11F")]
		[FieldOffset(Offset = "0xE0")]
		private Bounds m_ContentBounds;

		// Token: 0x0401C120 RID: 114976
		[Token(Token = "0x401C120")]
		[FieldOffset(Offset = "0xF8")]
		private Bounds m_ViewBounds;

		// Token: 0x0401C121 RID: 114977
		[Token(Token = "0x401C121")]
		[FieldOffset(Offset = "0x110")]
		private Vector2 m_Velocity;

		// Token: 0x0401C122 RID: 114978
		[Token(Token = "0x401C122")]
		[FieldOffset(Offset = "0x118")]
		private ScrollWheelHandler m_ScrollWheelHandler;

		// Token: 0x0401C123 RID: 114979
		[Token(Token = "0x401C123")]
		[FieldOffset(Offset = "0x120")]
		private Action m_onPostLayoutCallback;

		// Token: 0x0401C124 RID: 114980
		[Token(Token = "0x401C124")]
		[FieldOffset(Offset = "0x128")]
		private bool m_Dragging;

		// Token: 0x0401C125 RID: 114981
		[Token(Token = "0x401C125")]
		[FieldOffset(Offset = "0x129")]
		private bool m_Scrolling;

		// Token: 0x0401C126 RID: 114982
		[Token(Token = "0x401C126")]
		[FieldOffset(Offset = "0x12C")]
		private Vector2 m_PrevPosition;

		// Token: 0x0401C127 RID: 114983
		[Token(Token = "0x401C127")]
		[FieldOffset(Offset = "0x134")]
		private Bounds m_PrevContentBounds;

		// Token: 0x0401C128 RID: 114984
		[Token(Token = "0x401C128")]
		[FieldOffset(Offset = "0x14C")]
		private Bounds m_PrevViewBounds;

		// Token: 0x0401C129 RID: 114985
		[Token(Token = "0x401C129")]
		[FieldOffset(Offset = "0x164")]
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x0401C12A RID: 114986
		[Token(Token = "0x401C12A")]
		[FieldOffset(Offset = "0x165")]
		private bool m_HSliderExpand;

		// Token: 0x0401C12B RID: 114987
		[Token(Token = "0x401C12B")]
		[FieldOffset(Offset = "0x166")]
		private bool m_VSliderExpand;

		// Token: 0x0401C12C RID: 114988
		[Token(Token = "0x401C12C")]
		[FieldOffset(Offset = "0x168")]
		private float m_HSliderHeight;

		// Token: 0x0401C12D RID: 114989
		[Token(Token = "0x401C12D")]
		[FieldOffset(Offset = "0x16C")]
		private float m_VSliderWidth;

		// Token: 0x0401C12E RID: 114990
		[Token(Token = "0x401C12E")]
		[FieldOffset(Offset = "0x170")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0401C12F RID: 114991
		[Token(Token = "0x401C12F")]
		[FieldOffset(Offset = "0x178")]
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x0401C130 RID: 114992
		[Token(Token = "0x401C130")]
		[FieldOffset(Offset = "0x180")]
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x0401C131 RID: 114993
		[Token(Token = "0x401C131")]
		[FieldOffset(Offset = "0x188")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0401C132 RID: 114994
		[Token(Token = "0x401C132")]
		[FieldOffset(Offset = "0x189")]
		private bool m_isRebuilding;

		// Token: 0x0401C134 RID: 114996
		[Token(Token = "0x401C134")]
		[FieldOffset(Offset = "0x190")]
		private int logCtr;

		// Token: 0x0401C135 RID: 114997
		[Token(Token = "0x401C135")]
		[FieldOffset(Offset = "0x198")]
		private readonly Vector3[] m_Corners;

		// Token: 0x0401C136 RID: 114998
		[Token(Token = "0x401C136")]
		[FieldOffset(Offset = "0x1A0")]
		[NonSerialized]
		private Canvas m_cacheCanvas;

		// Token: 0x0401C137 RID: 114999
		[Token(Token = "0x401C137")]
		[FieldOffset(Offset = "0x1A8")]
		private bool m_initedByTorappu;

		// Token: 0x0401C138 RID: 115000
		[Token(Token = "0x401C138")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0401C139 RID: 115001
		[Token(Token = "0x401C139")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_adapter;

		// Token: 0x0401C13A RID: 115002
		[Token(Token = "0x401C13A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isLayoutReady;

		// Token: 0x0401C13B RID: 115003
		[Token(Token = "0x401C13B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isLayoutReady;

		// Token: 0x0401C13C RID: 115004
		[Token(Token = "0x401C13C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_m_fly;

		// Token: 0x0401C13D RID: 115005
		[Token(Token = "0x401C13D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetItemTypeStart;

		// Token: 0x0401C13E RID: 115006
		[Token(Token = "0x401C13E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetItemTypeEnd;

		// Token: 0x0401C13F RID: 115007
		[Token(Token = "0x401C13F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_startOffset;

		// Token: 0x0401C140 RID: 115008
		[Token(Token = "0x401C140")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0401C141 RID: 115009
		[Token(Token = "0x401C141")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_contentSpacing;

		// Token: 0x0401C142 RID: 115010
		[Token(Token = "0x401C142")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_contentPadding;

		// Token: 0x0401C143 RID: 115011
		[Token(Token = "0x401C143")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_contentContraintCount;

		// Token: 0x0401C144 RID: 115012
		[Token(Token = "0x401C144")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EstimateCountPerPage;

		// Token: 0x0401C145 RID: 115013
		[Token(Token = "0x401C145")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EstimateTotalContentSize;

		// Token: 0x0401C146 RID: 115014
		[Token(Token = "0x401C146")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIfNeedNewItemsToFill;

		// Token: 0x0401C147 RID: 115015
		[Token(Token = "0x401C147")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateItems;

		// Token: 0x0401C148 RID: 115016
		[Token(Token = "0x401C148")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_content;

		// Token: 0x0401C149 RID: 115017
		[Token(Token = "0x401C149")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_content;

		// Token: 0x0401C14A RID: 115018
		[Token(Token = "0x401C14A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_movementType;

		// Token: 0x0401C14B RID: 115019
		[Token(Token = "0x401C14B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_movementType;

		// Token: 0x0401C14C RID: 115020
		[Token(Token = "0x401C14C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_elasticity;

		// Token: 0x0401C14D RID: 115021
		[Token(Token = "0x401C14D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_elasticity;

		// Token: 0x0401C14E RID: 115022
		[Token(Token = "0x401C14E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_inertia;

		// Token: 0x0401C14F RID: 115023
		[Token(Token = "0x401C14F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_inertia;

		// Token: 0x0401C150 RID: 115024
		[Token(Token = "0x401C150")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_decelerationRate;

		// Token: 0x0401C151 RID: 115025
		[Token(Token = "0x401C151")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_decelerationRate;

		// Token: 0x0401C152 RID: 115026
		[Token(Token = "0x401C152")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_scrollSensitivity;

		// Token: 0x0401C153 RID: 115027
		[Token(Token = "0x401C153")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_scrollSensitivity;

		// Token: 0x0401C154 RID: 115028
		[Token(Token = "0x401C154")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_viewport;

		// Token: 0x0401C155 RID: 115029
		[Token(Token = "0x401C155")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_viewport;

		// Token: 0x0401C156 RID: 115030
		[Token(Token = "0x401C156")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbar;

		// Token: 0x0401C157 RID: 115031
		[Token(Token = "0x401C157")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbar;

		// Token: 0x0401C158 RID: 115032
		[Token(Token = "0x401C158")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbar;

		// Token: 0x0401C159 RID: 115033
		[Token(Token = "0x401C159")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbar;

		// Token: 0x0401C15A RID: 115034
		[Token(Token = "0x401C15A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbarVisibility;

		// Token: 0x0401C15B RID: 115035
		[Token(Token = "0x401C15B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbarVisibility;

		// Token: 0x0401C15C RID: 115036
		[Token(Token = "0x401C15C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbarVisibility;

		// Token: 0x0401C15D RID: 115037
		[Token(Token = "0x401C15D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbarVisibility;

		// Token: 0x0401C15E RID: 115038
		[Token(Token = "0x401C15E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_horizontalScrollbarSpacing;

		// Token: 0x0401C15F RID: 115039
		[Token(Token = "0x401C15F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_set_horizontalScrollbarSpacing;

		// Token: 0x0401C160 RID: 115040
		[Token(Token = "0x401C160")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_verticalScrollbarSpacing;

		// Token: 0x0401C161 RID: 115041
		[Token(Token = "0x401C161")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_verticalScrollbarSpacing;

		// Token: 0x0401C162 RID: 115042
		[Token(Token = "0x401C162")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_onValueChanged;

		// Token: 0x0401C163 RID: 115043
		[Token(Token = "0x401C163")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_set_onValueChanged;

		// Token: 0x0401C164 RID: 115044
		[Token(Token = "0x401C164")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_viewRect;

		// Token: 0x0401C165 RID: 115045
		[Token(Token = "0x401C165")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x0401C166 RID: 115046
		[Token(Token = "0x401C166")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_set_velocity;

		// Token: 0x0401C167 RID: 115047
		[Token(Token = "0x401C167")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_wheelHandler;

		// Token: 0x0401C168 RID: 115048
		[Token(Token = "0x401C168")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_wholeCalcSize;

		// Token: 0x0401C169 RID: 115049
		[Token(Token = "0x401C169")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_SetPostLayoutCallback;

		// Token: 0x0401C16A RID: 115050
		[Token(Token = "0x401C16A")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_CancelPostLayoutCallback;

		// Token: 0x0401C16B RID: 115051
		[Token(Token = "0x401C16B")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__TryToCallbackWhenPostLayout;

		// Token: 0x0401C16C RID: 115052
		[Token(Token = "0x401C16C")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_EstimateTargetNormalizedPos;

		// Token: 0x0401C16D RID: 115053
		[Token(Token = "0x401C16D")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_EstimateTargetBounds;

		// Token: 0x0401C16E RID: 115054
		[Token(Token = "0x401C16E")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_FindNearIndex;

		// Token: 0x0401C16F RID: 115055
		[Token(Token = "0x401C16F")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x0401C170 RID: 115056
		[Token(Token = "0x401C170")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C171 RID: 115057
		[Token(Token = "0x401C171")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ClearCells;

		// Token: 0x0401C172 RID: 115058
		[Token(Token = "0x401C172")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_RefreshCells;

		// Token: 0x0401C173 RID: 115059
		[Token(Token = "0x401C173")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_RefreshCell;

		// Token: 0x0401C174 RID: 115060
		[Token(Token = "0x401C174")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_HandleViews;

		// Token: 0x0401C175 RID: 115061
		[Token(Token = "0x401C175")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_RefillCells;

		// Token: 0x0401C176 RID: 115062
		[Token(Token = "0x401C176")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_NewItemAtStart;

		// Token: 0x0401C177 RID: 115063
		[Token(Token = "0x401C177")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_DeleteItemAtStart;

		// Token: 0x0401C178 RID: 115064
		[Token(Token = "0x401C178")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_NewItemAtEnd;

		// Token: 0x0401C179 RID: 115065
		[Token(Token = "0x401C179")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_DeleteItemAtEnd;

		// Token: 0x0401C17A RID: 115066
		[Token(Token = "0x401C17A")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_InstNextItemAtStart;

		// Token: 0x0401C17B RID: 115067
		[Token(Token = "0x401C17B")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_InstNextItemAtEnd;

		// Token: 0x0401C17C RID: 115068
		[Token(Token = "0x401C17C")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__BindWheelListener;

		// Token: 0x0401C17D RID: 115069
		[Token(Token = "0x401C17D")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_Rebuild;

		// Token: 0x0401C17E RID: 115070
		[Token(Token = "0x401C17E")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_LayoutComplete;

		// Token: 0x0401C17F RID: 115071
		[Token(Token = "0x401C17F")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GraphicUpdateComplete;

		// Token: 0x0401C180 RID: 115072
		[Token(Token = "0x401C180")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_UpdateCachedData;

		// Token: 0x0401C181 RID: 115073
		[Token(Token = "0x401C181")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C182 RID: 115074
		[Token(Token = "0x401C182")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C183 RID: 115075
		[Token(Token = "0x401C183")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x0401C184 RID: 115076
		[Token(Token = "0x401C184")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_EnsureLayoutHasRebuilt;

		// Token: 0x0401C185 RID: 115077
		[Token(Token = "0x401C185")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_StopMovement;

		// Token: 0x0401C186 RID: 115078
		[Token(Token = "0x401C186")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0401C187 RID: 115079
		[Token(Token = "0x401C187")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_OnInitializePotentialDrag;

		// Token: 0x0401C188 RID: 115080
		[Token(Token = "0x401C188")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0401C189 RID: 115081
		[Token(Token = "0x401C189")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0401C18A RID: 115082
		[Token(Token = "0x401C18A")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0401C18B RID: 115083
		[Token(Token = "0x401C18B")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_SetContentAnchoredPosition;

		// Token: 0x0401C18C RID: 115084
		[Token(Token = "0x401C18C")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401C18D RID: 115085
		[Token(Token = "0x401C18D")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_UpdatePrevData;

		// Token: 0x0401C18E RID: 115086
		[Token(Token = "0x401C18E")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_UpdateScrollbars;

		// Token: 0x0401C18F RID: 115087
		[Token(Token = "0x401C18F")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_get_normalizedPosition;

		// Token: 0x0401C190 RID: 115088
		[Token(Token = "0x401C190")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_set_normalizedPosition;

		// Token: 0x0401C191 RID: 115089
		[Token(Token = "0x401C191")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge get_position;

		// Token: 0x0401C192 RID: 115090
		[Token(Token = "0x401C192")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_get_horizontalNormalizedPosition;

		// Token: 0x0401C193 RID: 115091
		[Token(Token = "0x401C193")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_set_horizontalNormalizedPosition;

		// Token: 0x0401C194 RID: 115092
		[Token(Token = "0x401C194")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_verticalNormalizedPosition;

		// Token: 0x0401C195 RID: 115093
		[Token(Token = "0x401C195")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_set_verticalNormalizedPosition;

		// Token: 0x0401C196 RID: 115094
		[Token(Token = "0x401C196")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__HorizontalNormPosAfterUpdateBound;

		// Token: 0x0401C197 RID: 115095
		[Token(Token = "0x401C197")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__VerticalNormPosAfterUpdateBound;

		// Token: 0x0401C198 RID: 115096
		[Token(Token = "0x401C198")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_SetHorizontalNormalizedPosition;

		// Token: 0x0401C199 RID: 115097
		[Token(Token = "0x401C199")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_SetVerticalNormalizedPosition;

		// Token: 0x0401C19A RID: 115098
		[Token(Token = "0x401C19A")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_SetNormalizedPosition;

		// Token: 0x0401C19B RID: 115099
		[Token(Token = "0x401C19B")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_RubberDelta;

		// Token: 0x0401C19C RID: 115100
		[Token(Token = "0x401C19C")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_NearestEnabledCanvas;

		// Token: 0x0401C19D RID: 115101
		[Token(Token = "0x401C19D")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0401C19E RID: 115102
		[Token(Token = "0x401C19E")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_get_hScrollingNeeded;

		// Token: 0x0401C19F RID: 115103
		[Token(Token = "0x401C19F")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_get_vScrollingNeeded;

		// Token: 0x0401C1A0 RID: 115104
		[Token(Token = "0x401C1A0")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401C1A1 RID: 115105
		[Token(Token = "0x401C1A1")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401C1A2 RID: 115106
		[Token(Token = "0x401C1A2")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0401C1A3 RID: 115107
		[Token(Token = "0x401C1A3")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401C1A4 RID: 115108
		[Token(Token = "0x401C1A4")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0401C1A5 RID: 115109
		[Token(Token = "0x401C1A5")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_set_flexibleWidth;

		// Token: 0x0401C1A6 RID: 115110
		[Token(Token = "0x401C1A6")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0401C1A7 RID: 115111
		[Token(Token = "0x401C1A7")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401C1A8 RID: 115112
		[Token(Token = "0x401C1A8")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0401C1A9 RID: 115113
		[Token(Token = "0x401C1A9")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0401C1AA RID: 115114
		[Token(Token = "0x401C1AA")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_SetLayoutHorizontal;

		// Token: 0x0401C1AB RID: 115115
		[Token(Token = "0x401C1AB")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_SetLayoutVertical;

		// Token: 0x0401C1AC RID: 115116
		[Token(Token = "0x401C1AC")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_UpdateScrollbarVisibility;

		// Token: 0x0401C1AD RID: 115117
		[Token(Token = "0x401C1AD")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_UpdateScrollbarLayout;

		// Token: 0x0401C1AE RID: 115118
		[Token(Token = "0x401C1AE")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_UpdateBounds;

		// Token: 0x0401C1AF RID: 115119
		[Token(Token = "0x401C1AF")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_AdjustBounds;

		// Token: 0x0401C1B0 RID: 115120
		[Token(Token = "0x401C1B0")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_GetBounds;

		// Token: 0x0401C1B1 RID: 115121
		[Token(Token = "0x401C1B1")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CalculateOffset;

		// Token: 0x0401C1B2 RID: 115122
		[Token(Token = "0x401C1B2")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_SetDirty;

		// Token: 0x0401C1B3 RID: 115123
		[Token(Token = "0x401C1B3")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_SetDirtyCaching;

		// Token: 0x0401C1B4 RID: 115124
		[Token(Token = "0x401C1B4")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_OnBeforeTransformParentChanged;

		// Token: 0x0401C1B5 RID: 115125
		[Token(Token = "0x401C1B5")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_get_canvas;

		// Token: 0x0401C1B6 RID: 115126
		[Token(Token = "0x401C1B6")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0__InitTorappuIfNot;

		// Token: 0x0401C1B7 RID: 115127
		[Token(Token = "0x401C1B7")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0__NotifyActivateCoroutine;

		// Token: 0x0401C1B8 RID: 115128
		[Token(Token = "0x401C1B8")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_IsVelocityZero;

		// Token: 0x0401C1B9 RID: 115129
		[Token(Token = "0x401C1B9")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0__WaitForLayoutReady;

		// Token: 0x0401C1BA RID: 115130
		[Token(Token = "0x401C1BA")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C1BB RID: 115131
		[Token(Token = "0x401C1BB")]
		[FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401C1BC RID: 115132
		[Token(Token = "0x401C1BC")]
		[FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401C1BD RID: 115133
		[Token(Token = "0x401C1BD")]
		[FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0__OnScrollWork;

		// Token: 0x0401C1BE RID: 115134
		[Token(Token = "0x401C1BE")]
		[FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401C1BF RID: 115135
		[Token(Token = "0x401C1BF")]
		[FieldOffset(Offset = "0x438")]
		private static DelegateBridge get_transform;

		// Token: 0x02003981 RID: 14721
		[Token(Token = "0x2003981")]
		private class FlyBundle
		{
			// Token: 0x06017488 RID: 95368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017488")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public FlyBundle(LoopScrollRect rect)
			{
			}

			// Token: 0x06017489 RID: 95369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017489")]
			[Address(RVA = "0xF9C470", Offset = "0xF9B070", VA = "0x180F9C470")]
			public void BeginDrag(Vector2 localCursor)
			{
			}

			// Token: 0x0601748A RID: 95370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601748A")]
			[Address(RVA = "0xF9C4A0", Offset = "0xF9B0A0", VA = "0x180F9C4A0")]
			public void EndDrag(Vector2 localCursor)
			{
			}

			// Token: 0x0601748B RID: 95371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601748B")]
			[Address(RVA = "0xF9C4E0", Offset = "0xF9B0E0", VA = "0x180F9C4E0")]
			public void Reset()
			{
			}

			// Token: 0x170037B8 RID: 14264
			// (get) Token: 0x0601748C RID: 95372 RVA: 0x00095C40 File Offset: 0x00093E40
			[Token(Token = "0x170037B8")]
			public Vector2 velocity
			{
				[Token(Token = "0x601748C")]
				[Address(RVA = "0xF9C780", Offset = "0xF9B380", VA = "0x180F9C780")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170037B9 RID: 14265
			// (get) Token: 0x0601748D RID: 95373 RVA: 0x00095C58 File Offset: 0x00093E58
			[Token(Token = "0x170037B9")]
			public bool isValid
			{
				[Token(Token = "0x601748D")]
				[Address(RVA = "0xF9C680", Offset = "0xF9B280", VA = "0x180F9C680")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601748E RID: 95374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601748E")]
			[Address(RVA = "0xF9C4F0", Offset = "0xF9B0F0", VA = "0x180F9C4F0")]
			private void _ClacEndSpeed()
			{
			}

			// Token: 0x0401C1C0 RID: 115136
			[Token(Token = "0x401C1C0")]
			[FieldOffset(Offset = "0x10")]
			private LoopScrollRect m_scroll;

			// Token: 0x0401C1C1 RID: 115137
			[Token(Token = "0x401C1C1")]
			[FieldOffset(Offset = "0x18")]
			private bool m_beginFlag;

			// Token: 0x0401C1C2 RID: 115138
			[Token(Token = "0x401C1C2")]
			[FieldOffset(Offset = "0x1C")]
			private Vector2 m_dragPos;

			// Token: 0x0401C1C3 RID: 115139
			[Token(Token = "0x401C1C3")]
			[FieldOffset(Offset = "0x24")]
			private Vector2 m_endPos;

			// Token: 0x0401C1C4 RID: 115140
			[Token(Token = "0x401C1C4")]
			[FieldOffset(Offset = "0x2C")]
			private float m_dragTime;

			// Token: 0x0401C1C5 RID: 115141
			[Token(Token = "0x401C1C5")]
			[FieldOffset(Offset = "0x30")]
			private float m_endTime;

			// Token: 0x0401C1C6 RID: 115142
			[Token(Token = "0x401C1C6")]
			[FieldOffset(Offset = "0x34")]
			private bool m_isDone;

			// Token: 0x0401C1C7 RID: 115143
			[Token(Token = "0x401C1C7")]
			[FieldOffset(Offset = "0x38")]
			private Vector2 m_endSpeed;
		}

		// Token: 0x02003982 RID: 14722
		[Token(Token = "0x2003982")]
		public enum MovementType
		{
			// Token: 0x0401C1C9 RID: 115145
			[Token(Token = "0x401C1C9")]
			Unrestricted,
			// Token: 0x0401C1CA RID: 115146
			[Token(Token = "0x401C1CA")]
			Elastic,
			// Token: 0x0401C1CB RID: 115147
			[Token(Token = "0x401C1CB")]
			Clamped
		}

		// Token: 0x02003983 RID: 14723
		[Token(Token = "0x2003983")]
		public enum ScrollbarVisibility
		{
			// Token: 0x0401C1CD RID: 115149
			[Token(Token = "0x401C1CD")]
			Permanent,
			// Token: 0x0401C1CE RID: 115150
			[Token(Token = "0x401C1CE")]
			AutoHide,
			// Token: 0x0401C1CF RID: 115151
			[Token(Token = "0x401C1CF")]
			AutoHideAndExpandViewport
		}

		// Token: 0x02003984 RID: 14724
		[Token(Token = "0x2003984")]
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x0601748F RID: 95375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601748F")]
			[Address(RVA = "0xFAECD0", Offset = "0xFAD8D0", VA = "0x180FAECD0")]
			public ScrollRectEvent()
			{
			}
		}
	}
}
