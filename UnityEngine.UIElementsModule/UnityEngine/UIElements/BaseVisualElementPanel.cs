using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017D RID: 381
		// (set) Token: 0x0600017E RID: 382
		[Token(Token = "0x1700004C")]
		public abstract EventInterests IMGUIEventInterests { [Token(Token = "0x600017D")] get; [Token(Token = "0x600017E")] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017F RID: 383
		// (set) Token: 0x06000180 RID: 384
		[Token(Token = "0x1700004D")]
		public abstract ScriptableObject ownerObject { [Token(Token = "0x600017F")] get; [Token(Token = "0x6000180")] protected set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000181 RID: 385
		[Token(Token = "0x1700004E")]
		public abstract SavePersistentViewData saveViewData { [Token(Token = "0x6000181")] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000182 RID: 386
		[Token(Token = "0x1700004F")]
		public abstract GetViewDataDictionary getViewDataDictionary { [Token(Token = "0x6000182")] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000183 RID: 387
		// (set) Token: 0x06000184 RID: 388
		[Token(Token = "0x17000050")]
		public abstract int IMGUIContainersCount { [Token(Token = "0x6000183")] get; [Token(Token = "0x6000184")] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000185 RID: 389
		// (set) Token: 0x06000186 RID: 390
		[Token(Token = "0x17000051")]
		public abstract FocusController focusController { [Token(Token = "0x6000185")] get; [Token(Token = "0x6000186")] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000187 RID: 391
		[Token(Token = "0x17000052")]
		public abstract IMGUIContainer rootIMGUIContainer { [Token(Token = "0x6000187")] get; }

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		internal event Action<BaseVisualElementPanel> panelDisposed
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x5A25D10", Offset = "0x5A24910", VA = "0x185A25D10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x5A26070", Offset = "0x5A24C70", VA = "0x185A26070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5A25AA0", Offset = "0x5A246A0", VA = "0x185A25AA0")]
		protected BaseVisualElementPanel()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5A25130", Offset = "0x5A23D30", VA = "0x185A25130", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5A251A0", Offset = "0x5A23DA0", VA = "0x185A251A0", Slot = "21")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600018D RID: 397
		[Token(Token = "0x600018D")]
		public abstract void Repaint(Event e);

		// Token: 0x0600018E RID: 398
		[Token(Token = "0x600018E")]
		public abstract void ValidateLayout();

		// Token: 0x0600018F RID: 399
		[Token(Token = "0x600018F")]
		public abstract void UpdateAnimations();

		// Token: 0x06000190 RID: 400
		[Token(Token = "0x6000190")]
		public abstract void UpdateBindings();

		// Token: 0x06000191 RID: 401
		[Token(Token = "0x6000191")]
		public abstract void ApplyStyles();

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		internal float scale
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x5917F60", Offset = "0x5916B60", VA = "0x185917F60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5A26340", Offset = "0x5A24F40", VA = "0x185A26340")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		internal float pixelsPerPoint
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x5A26270", Offset = "0x5A24E70", VA = "0x185A26270")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000055")]
		public float scaledPixelsPerPoint
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x5A25F20", Offset = "0x5A24B20", VA = "0x185A25F20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		internal PanelClearSettings clearSettings
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x5A25F00", Offset = "0x5A24B00", VA = "0x185A25F00")]
			[CompilerGenerated]
			get
			{
				return default(PanelClearSettings);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x5A26260", Offset = "0x5A24E60", VA = "0x185A26260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		internal bool duringLayoutPhase
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600019A RID: 410
		[Token(Token = "0x17000058")]
		internal abstract uint version { [Token(Token = "0x600019A")] get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600019B RID: 411
		[Token(Token = "0x17000059")]
		internal abstract uint hierarchyVersion { [Token(Token = "0x600019B")] get; }

		// Token: 0x0600019C RID: 412
		[Token(Token = "0x600019C")]
		internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		internal virtual RepaintData repaintData
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		internal virtual ICursorManager cursorManager
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public ContextualMenuManager contextualMenuManager
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A3 RID: 419
		[Token(Token = "0x1700005D")]
		public abstract VisualElement visualTree { [Token(Token = "0x60001A3")] get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		[Token(Token = "0x1700005E")]
		public abstract EventDispatcher dispatcher { [Token(Token = "0x60001A4")] get; [Token(Token = "0x60001A5")] set; }

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5A25500", Offset = "0x5A24100", VA = "0x185A25500")]
		internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A7 RID: 423
		[Token(Token = "0x1700005F")]
		internal abstract IScheduler scheduler { [Token(Token = "0x60001A7")] get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		[Token(Token = "0x17000060")]
		internal abstract IStylePropertyAnimationSystem styleAnimationSystem { [Token(Token = "0x60001A8")] get; [Token(Token = "0x60001A9")] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001AB RID: 427
		[Token(Token = "0x17000061")]
		public abstract ContextType contextType { [Token(Token = "0x60001AA")] get; [Token(Token = "0x60001AB")] protected set; }

		// Token: 0x060001AC RID: 428
		[Token(Token = "0x60001AC")]
		public abstract VisualElement Pick(Vector2 point);

		// Token: 0x060001AD RID: 429
		[Token(Token = "0x60001AD")]
		public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		internal bool disposed
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x36D4FA0", Offset = "0x36D3BA0", VA = "0x1836D4FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001B0 RID: 432
		[Token(Token = "0x60001B0")]
		internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);

		// Token: 0x060001B1 RID: 433 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5A252F0", Offset = "0x5A23EF0", VA = "0x185A252F0")]
		internal VisualElement GetTopElementUnderPointer(int pointerId)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x5A25390", Offset = "0x5A23F90", VA = "0x185A25390")]
		internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5A25060", Offset = "0x5A23C60", VA = "0x185A25060")]
		internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x5A25090", Offset = "0x5A23C90", VA = "0x185A25090")]
		internal void CommitElementUnderPointers()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B5 RID: 437
		[Token(Token = "0x17000063")]
		internal abstract Shader standardShader { [Token(Token = "0x60001B5")] get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000064")]
		internal virtual Shader standardWorldSpaceShader
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x592C430", Offset = "0x592B030", VA = "0x18592C430", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		internal event Action standardShaderChanged
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5A25DC0", Offset = "0x5A249C0", VA = "0x185A25DC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5A26120", Offset = "0x5A24D20", VA = "0x185A26120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		internal event Action standardWorldSpaceShaderChanged
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5A25E60", Offset = "0x5A24A60", VA = "0x185A25E60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x5A261C0", Offset = "0x5A24DC0", VA = "0x185A261C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		internal event Action atlasChanged
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x5A25BD0", Offset = "0x5A247D0", VA = "0x185A25BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5A25F30", Offset = "0x5A24B30", VA = "0x185A25F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x5A25310", Offset = "0x5A23F10", VA = "0x185A25310")]
		protected void InvokeAtlasChanged()
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001BE RID: 446
		// (set) Token: 0x060001BF RID: 447
		[Token(Token = "0x17000065")]
		public abstract AtlasBase atlas { [Token(Token = "0x60001BE")] get; [Token(Token = "0x60001BF")] set; }

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x5A25370", Offset = "0x5A23F70", VA = "0x185A25370")]
		internal void InvokeUpdateMaterial(Material mat)
		{
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		internal event HierarchyEvent hierarchyChanged
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x5A25C70", Offset = "0x5A24870", VA = "0x185A25C70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x5A25FD0", Offset = "0x5A24BD0", VA = "0x185A25FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x5A25350", Offset = "0x5A23F50", VA = "0x185A25350")]
		internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x5A25330", Offset = "0x5A23F30", VA = "0x185A25330")]
		internal void InvokeBeforeUpdate()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5A25750", Offset = "0x5A24350", VA = "0x185A25750")]
		internal void UpdateElementUnderPointers()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x5A259B0", Offset = "0x5A245B0", VA = "0x185A259B0", Slot = "50")]
		public virtual void Update()
		{
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		private float m_Scale;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		internal YogaConfig yogaConfig;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private float m_PixelsPerPoint;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x68")]
		internal ElementUnderPointer m_TopElementUnderPointers;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Material> updateMaterial;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x98")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IPanel> beforeUpdate;
	}
}
