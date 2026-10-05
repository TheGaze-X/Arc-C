using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	internal class Panel : BaseVisualElementPanel
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000066")]
		public sealed override VisualElement visualTree
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x5997630", Offset = "0x5996230", VA = "0x185997630", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public sealed override EventDispatcher dispatcher
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x4D6D140", Offset = "0x4D6BD40", VA = "0x184D6D140", Slot = "37")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000068")]
		public TimerEventScheduler timerEventScheduler
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x5A399A0", Offset = "0x5A385A0", VA = "0x185A399A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000069")]
		internal override IScheduler scheduler
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5A399A0", Offset = "0x5A385A0", VA = "0x185A399A0", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		internal override IStylePropertyAnimationSystem styleAnimationSystem
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0", Slot = "39")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x5A39B60", Offset = "0x5A38760", VA = "0x185A39B60", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public override ScriptableObject ownerObject
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x22F8A40", Offset = "0x22F7640", VA = "0x1822F8A40", Slot = "13")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public override ContextType contextType
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x58923D0", Offset = "0x5890FD0", VA = "0x1858923D0", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return ContextType.Player;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x5892590", Offset = "0x5891190", VA = "0x185892590", Slot = "42")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700006D")]
		public override SavePersistentViewData saveViewData
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700006E")]
		public override GetViewDataDictionary getViewDataDictionary
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public sealed override FocusController focusController
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public override EventInterests IMGUIEventInterests
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x5A398D0", Offset = "0x5A384D0", VA = "0x185A398D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(EventInterests);
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x5A39A40", Offset = "0x5A38640", VA = "0x185A39A40", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000071")]
		private static LoadResourceFunction loadResourceFunc
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x5A39950", Offset = "0x5A38550", VA = "0x185A39950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x5A38330", Offset = "0x5A36F30", VA = "0x185A38330")]
		internal static Object LoadResource(string pathName, Type type, float dpiScaling)
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x5A38200", Offset = "0x5A36E00", VA = "0x185A38200")]
		internal void Focus()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x5A37CF0", Offset = "0x5A368F0", VA = "0x185A37CF0")]
		internal void Blur()
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		internal string name
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x5997710", Offset = "0x5996310", VA = "0x185997710")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x5A39B30", Offset = "0x5A38730", VA = "0x185A39B30")]
			set
			{
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x5A37E00", Offset = "0x5A36A00", VA = "0x185A37E00")]
		private void CreateMarkers()
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000073")]
		private static TimeMsFunction TimeSinceStartup
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5A398F0", Offset = "0x5A384F0", VA = "0x185A398F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public override int IMGUIContainersCount
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5080700", Offset = "0x507F300", VA = "0x185080700", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x5A39A30", Offset = "0x5A38630", VA = "0x185A39A30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000075")]
		public override IMGUIContainer rootIMGUIContainer
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x17000076")]
		internal override uint version
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x789280", Offset = "0x787E80", VA = "0x180789280", Slot = "27")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x17000077")]
		internal override uint hierarchyVersion
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xED1D70", Offset = "0xED0970", VA = "0x180ED1D70", Slot = "28")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000078")]
		internal override Shader standardShader
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x5A39A20", Offset = "0x5A38620", VA = "0x185A39A20", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public override AtlasBase atlas
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x5A39940", Offset = "0x5A38540", VA = "0x185A39940", Slot = "48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x5A39A60", Offset = "0x5A38660", VA = "0x185A39A60", Slot = "49")]
			set
			{
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5A39110", Offset = "0x5A37D10", VA = "0x185A39110")]
		public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x5A38070", Offset = "0x5A36C70", VA = "0x185A38070", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x5A38E30", Offset = "0x5A37A30", VA = "0x185A38E30")]
		public static long TimeSinceStartupMs()
		{
			return 0L;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x5A38050", Offset = "0x5A36C50", VA = "0x185A38050")]
		internal static long DefaultTimeSinceStartupMs()
		{
			return 0L;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x5A38820", Offset = "0x5A37420", VA = "0x185A38820")]
		private static VisualElement PickAll(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x5A384C0", Offset = "0x5A370C0", VA = "0x185A384C0")]
		private static VisualElement PerformPick(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x5A38730", Offset = "0x5A37330", VA = "0x185A38730", Slot = "44")]
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x5A388D0", Offset = "0x5A374D0", VA = "0x185A388D0", Slot = "43")]
		public override VisualElement Pick(Vector2 point)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x5A39020", Offset = "0x5A37C20", VA = "0x185A39020", Slot = "23")]
		public override void ValidateLayout()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x5A38EF0", Offset = "0x5A37AF0", VA = "0x185A38EF0", Slot = "24")]
		public override void UpdateAnimations()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5A38F40", Offset = "0x5A37B40", VA = "0x185A38F40", Slot = "25")]
		public override void UpdateBindings()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x5A37CC0", Offset = "0x5A368C0", VA = "0x185A37CC0", Slot = "26")]
		public override void ApplyStyles()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x5A38F90", Offset = "0x5A37B90", VA = "0x185A38F90")]
		private void UpdateForRepaint()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5A38A60", Offset = "0x5A37660", VA = "0x185A38A60", Slot = "22")]
		public override void Repaint(Event e)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5A38470", Offset = "0x5A37070", VA = "0x185A38470", Slot = "29")]
		internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x5A38300", Offset = "0x5A36F00", VA = "0x185A38300", Slot = "45")]
		internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5953480", Offset = "0x5952080", VA = "0x185953480")]
		[CompilerGenerated]
		internal static Vector2Int <Pick>g__PixelOf|99_0(Vector2 p)
		{
			return default(Vector2Int);
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private VisualElement m_RootContainer;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private VisualTreeUpdater m_VisualTreeUpdater;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string m_PanelName;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private uint m_Version;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private uint m_RepaintVersion;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private uint m_HierarchyVersion;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ProfilerMarker m_MarkerBeforeUpdate;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ProfilerMarker m_MarkerUpdate;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ProfilerMarker m_MarkerLayout;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ProfilerMarker m_MarkerBindings;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ProfilerMarker m_MarkerAnimations;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProfilerMarker s_MarkerPickAll;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TimerEventScheduler m_Scheduler;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Shader m_StandardShader;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private AtlasBase m_Atlas;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool m_ValidatingLayout;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Panel> beforeAnyRepaint;
	}
}
