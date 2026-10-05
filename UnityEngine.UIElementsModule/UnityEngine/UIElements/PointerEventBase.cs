using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal where T : PointerEventBase<T>, new()
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000065E8 File Offset: 0x000047E8
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		public int pointerId
		{
			[Token(Token = "0x6000C9F")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DB")]
		public string pointerType
		{
			[Token(Token = "0x6000CA1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DC")]
		public bool isPrimary
		{
			[Token(Token = "0x6000CA3")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CA4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		public int button
		{
			[Token(Token = "0x6000CA5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CA6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00006630 File Offset: 0x00004830
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DE")]
		public int pressedButtons
		{
			[Token(Token = "0x6000CA7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CA8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00006648 File Offset: 0x00004848
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		public Vector3 position
		{
			[Token(Token = "0x6000CA9")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000CAA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00006660 File Offset: 0x00004860
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public Vector3 localPosition
		{
			[Token(Token = "0x6000CAB")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000CAC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public Vector3 deltaPosition
		{
			[Token(Token = "0x6000CAD")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000CAE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public float deltaTime
		{
			[Token(Token = "0x6000CAF")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		public int clickCount
		{
			[Token(Token = "0x6000CB1")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CB2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E4")]
		public float pressure
		{
			[Token(Token = "0x6000CB3")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CB4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public float tangentialPressure
		{
			[Token(Token = "0x6000CB5")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CB6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public float altitudeAngle
		{
			[Token(Token = "0x6000CB7")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CB8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00006708 File Offset: 0x00004908
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public float azimuthAngle
		{
			[Token(Token = "0x6000CB9")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CBA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00006720 File Offset: 0x00004920
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E8")]
		public float twist
		{
			[Token(Token = "0x6000CBB")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CBC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public Vector2 radius
		{
			[Token(Token = "0x6000CBD")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000CBE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00006750 File Offset: 0x00004950
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		public Vector2 radiusVariance
		{
			[Token(Token = "0x6000CBF")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000CC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00006768 File Offset: 0x00004968
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EB")]
		public EventModifiers modifiers
		{
			[Token(Token = "0x6000CC1")]
			[CompilerGenerated]
			get
			{
				return EventModifiers.None;
			}
			[Token(Token = "0x6000CC2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x170002EC")]
		public bool shiftKey
		{
			[Token(Token = "0x6000CC3")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x170002ED")]
		public bool ctrlKey
		{
			[Token(Token = "0x6000CC4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x170002EE")]
		public bool commandKey
		{
			[Token(Token = "0x6000CC5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x170002EF")]
		public bool altKey
		{
			[Token(Token = "0x6000CC6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x170002F0")]
		public bool actionKey
		{
			[Token(Token = "0x6000CC7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x000067F8 File Offset: 0x000049F8
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		private bool triggeredByOS
		{
			[Token(Token = "0x6000CC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CC9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00006810 File Offset: 0x00004A10
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		private bool recomputeTopElementUnderPointer
		{
			[Token(Token = "0x6000CCA")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CCB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCC")]
		protected override void Init()
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCD")]
		private void LocalInit()
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		public override IEventHandler currentTarget
		{
			[Token(Token = "0x6000CCE")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CCF")]
			internal set
			{
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000CD0")]
		private static bool IsMouse(Event systemEvent)
		{
			return default(bool);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CD1")]
		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CD2")]
		public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None)
		{
			return null;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CD3")]
		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			return null;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CD4")]
		public static T GetPooled(IPointerEvent triggerEvent)
		{
			return null;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD5")]
		protected internal override void PreDispatch(IPanel panel)
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD6")]
		protected internal override void PostDispatch(IPanel panel)
		{
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD7")]
		protected PointerEventBase()
		{
		}
	}
}
